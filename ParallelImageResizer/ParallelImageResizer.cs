using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace ParallelImageResizer
{
    public partial class ParallelImageResizer : Form
    {
        CancellationTokenSource cancellationTokenSource;
        ITargetBlock<string> headBlock = null;


        public ParallelImageResizer()
        {
            cancellationTokenSource = new CancellationTokenSource();
            InitializeComponent();
        }

        private void buttonSelectInputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog
            {
                ShowNewFolderButton = false
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                labelInputFolder.Text = dlg.SelectedPath;
            }
        }

        private void buttonSelectOutputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog
            {
                ShowNewFolderButton = false
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                labelOutputFolder.Text = dlg.SelectedPath;
            }
        }

        private void buttonStartWatching_Click(object sender, EventArgs e)
        {
            fileSystemWatcher1.Path = labelInputFolder.Text;
            fileSystemWatcher1.Filter = "*.jpg";
            if (headBlock == null)
            {
                headBlock = CreateImageResizingNetwork();
            }

            // Post the selected path to the network.
            foreach (string fileName in Directory.GetFiles(fileSystemWatcher1.Path))
            {
                textBoxInput.Text += Environment.NewLine + "Recieved Input: " + Path.GetFileName(fileName);
                headBlock.Post(fileName);
            }

            fileSystemWatcher1.EnableRaisingEvents = true;
        }


        ITargetBlock<string> CreateImageResizingNetwork()
        {
            var loadBitmap = new TransformBlock<string, Bitmap>(path =>
            {
                try
                {
                    return LoadBitmap(path);
                }
                catch (OperationCanceledException)
                {
                    return null;
                }
            });

            var resizedBitmap = new TransformBlock<Bitmap, Bitmap>(bitmap =>
            {
                try
                {
                    return ResizeBitmap(bitmap);
                }
                catch (OperationCanceledException)
                {
                    return null;
                }
            });

            Random rnd = new Random();
            var saveResizedBitmap = new ActionBlock<Bitmap>(returnStatus =>
            {
                string fileName = labelOutputFolder.Text + @"\" + rnd.Next().ToString() + ".jpg";
                returnStatus.Save(fileName);
                textBoxOutput.Text += Environment.NewLine + fileName;
                Cursor = DefaultCursor;
            },
               new ExecutionDataflowBlockOptions
               {
                   TaskScheduler = TaskScheduler.FromCurrentSynchronizationContext()
               });

            var operationCancelled = new ActionBlock<object>(delegate
            {
                // Display the error image to indicate that the operation 
                // was cancelled.

                Cursor = DefaultCursor;
            },
                // Specify a task scheduler from the current synchronization context 
                // so that the action runs on the UI thread. 
               new ExecutionDataflowBlockOptions
               {
                   TaskScheduler = TaskScheduler.FromCurrentSynchronizationContext()
               });

            // 
            // Connect the network. 
            // 
            loadBitmap.LinkTo(resizedBitmap, bitmaps => bitmaps!=null);

            loadBitmap.LinkTo(operationCancelled);

            resizedBitmap.LinkTo(saveResizedBitmap, bitmap => bitmap != null);

            resizedBitmap.LinkTo(operationCancelled);

            return loadBitmap;
        }

        // Loads all bitmap files that exist at the provided path.
        Bitmap LoadBitmap(string fileName)
        {
            //List<Bitmap> bitmaps = new List<Bitmap>();


            // Load each bitmap for the current extension. 
            // Throw OperationCanceledException if cancellation is requested.
            cancellationTokenSource.Token.ThrowIfCancellationRequested();

            try
            {
                // Add the Bitmap object to the collection.
                return new Bitmap(fileName);
            }
            catch (Exception)
            {
                // TODO: A complete application might handle the error.
            }
            return null;
        }

        // Creates a 50% reduced size bitmap from given Bitmap
        Bitmap ResizeBitmap(Bitmap bitmapIn)
        {
            // Create a 32-bit Bitmap object with the greatest dimensions.
            Bitmap result = new Bitmap(bitmapIn.Width / 2, bitmapIn.Height / 2,
               PixelFormat.Format32bppArgb);

            using (Graphics g = Graphics.FromImage(result))
                g.DrawImage(bitmapIn, 0, 0, result.Width, result.Height);

            // Return the result. 
            return result;
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            textBoxInput.Text += Environment.NewLine + "Recieved Input: " + Path.GetFileName(e.FullPath);
            if (headBlock != null)
            {
                headBlock.Post(e.FullPath);
            }
        }
    }
}
