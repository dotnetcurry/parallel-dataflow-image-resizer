namespace ParallelImageResizer
{
    partial class ParallelImageResizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.labelInputFolder = new System.Windows.Forms.Label();
            this.buttonSelectInputFolder = new System.Windows.Forms.Button();
            this.buttonSelectOutputFolder = new System.Windows.Forms.Button();
            this.labelOutputFolder = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonStartWatching = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(3, 37);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(372, 506);
            this.textBoxInput.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "*.jpg,*.png,*.jpeg,*.bmp";
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            // 
            // labelInputFolder
            // 
            this.labelInputFolder.AutoSize = true;
            this.labelInputFolder.Location = new System.Drawing.Point(121, 0);
            this.labelInputFolder.Name = "labelInputFolder";
            this.labelInputFolder.Size = new System.Drawing.Size(0, 13);
            this.labelInputFolder.TabIndex = 1;
            // 
            // buttonSelectInputFolder
            // 
            this.buttonSelectInputFolder.Location = new System.Drawing.Point(3, 3);
            this.buttonSelectInputFolder.Name = "buttonSelectInputFolder";
            this.buttonSelectInputFolder.Size = new System.Drawing.Size(112, 23);
            this.buttonSelectInputFolder.TabIndex = 2;
            this.buttonSelectInputFolder.Text = "Select Input Folder";
            this.buttonSelectInputFolder.UseVisualStyleBackColor = true;
            this.buttonSelectInputFolder.Click += new System.EventHandler(this.buttonSelectInputFolder_Click);
            // 
            // buttonSelectOutputFolder
            // 
            this.buttonSelectOutputFolder.Location = new System.Drawing.Point(3, 3);
            this.buttonSelectOutputFolder.Name = "buttonSelectOutputFolder";
            this.buttonSelectOutputFolder.Size = new System.Drawing.Size(112, 23);
            this.buttonSelectOutputFolder.TabIndex = 3;
            this.buttonSelectOutputFolder.Text = "Select Output Folder";
            this.buttonSelectOutputFolder.UseVisualStyleBackColor = true;
            this.buttonSelectOutputFolder.Click += new System.EventHandler(this.buttonSelectOutputFolder_Click);
            // 
            // labelOutputFolder
            // 
            this.labelOutputFolder.AutoSize = true;
            this.labelOutputFolder.Location = new System.Drawing.Point(121, 0);
            this.labelOutputFolder.Name = "labelOutputFolder";
            this.labelOutputFolder.Size = new System.Drawing.Size(0, 13);
            this.labelOutputFolder.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxOutput, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.410256F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.58974F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 546);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonSelectInputFolder);
            this.flowLayoutPanel1.Controls.Add(this.labelInputFolder);
            this.flowLayoutPanel1.Controls.Add(this.buttonStartWatching);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(372, 28);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // buttonStartWatching
            // 
            this.buttonStartWatching.Location = new System.Drawing.Point(127, 3);
            this.buttonStartWatching.Name = "buttonStartWatching";
            this.buttonStartWatching.Size = new System.Drawing.Size(106, 23);
            this.buttonStartWatching.TabIndex = 3;
            this.buttonStartWatching.Text = "Start Watching";
            this.buttonStartWatching.UseVisualStyleBackColor = true;
            this.buttonStartWatching.Click += new System.EventHandler(this.buttonStartWatching_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonSelectOutputFolder);
            this.flowLayoutPanel2.Controls.Add(this.labelOutputFolder);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(381, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(373, 28);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(381, 37);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(373, 506);
            this.textBoxOutput.TabIndex = 6;
            // 
            // ParallelImageResizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ParallelImageResizer";
            this.Text = "Parallel Image Resizer";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonSelectInputFolder;
        private System.Windows.Forms.Label labelInputFolder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonSelectOutputFolder;
        private System.Windows.Forms.Label labelOutputFolder;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonStartWatching;
    }
}

