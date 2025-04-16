namespace DragDrop
{
    partial class PdfTools
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfTools));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxSelectedFilesMergePDF = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMergeFiles = new System.Windows.Forms.Button();
            this.buttonRemoveMergePDF = new System.Windows.Forms.Button();
            this.MergeFilesSelectButton = new System.Windows.Forms.Button();
            this.SplitPDF = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSplitPdfAtPage = new System.Windows.Forms.Label();
            this.textBoxSplitPageValue = new System.Windows.Forms.TextBox();
            this.buttonSplitPdf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSplitPdfSelectedFile = new System.Windows.Forms.TextBox();
            this.buttonSplitPdfSelectFile = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialogMergepdf = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMergepdf = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogSplitPdf = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSplitPdfFilename1 = new System.Windows.Forms.TextBox();
            this.textBoxSplitPdfFilename2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxSelectedFilesMergePDF.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SplitPDF.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.SplitPDF);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxSelectedFilesMergePDF);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.MergeFilesSelectButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MergePDF";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxSelectedFilesMergePDF
            // 
            this.groupBoxSelectedFilesMergePDF.Controls.Add(this.panel1);
            this.groupBoxSelectedFilesMergePDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSelectedFilesMergePDF.Location = new System.Drawing.Point(3, 32);
            this.groupBoxSelectedFilesMergePDF.Name = "groupBoxSelectedFilesMergePDF";
            this.groupBoxSelectedFilesMergePDF.Size = new System.Drawing.Size(786, 326);
            this.groupBoxSelectedFilesMergePDF.TabIndex = 2;
            this.groupBoxSelectedFilesMergePDF.TabStop = false;
            this.groupBoxSelectedFilesMergePDF.Text = "Selected Files";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 300);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonMergeFiles);
            this.panel2.Controls.Add(this.buttonRemoveMergePDF);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 31);
            this.panel2.TabIndex = 3;
            // 
            // buttonMergeFiles
            // 
            this.buttonMergeFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMergeFiles.Location = new System.Drawing.Point(0, 0);
            this.buttonMergeFiles.Name = "buttonMergeFiles";
            this.buttonMergeFiles.Size = new System.Drawing.Size(632, 31);
            this.buttonMergeFiles.TabIndex = 0;
            this.buttonMergeFiles.Text = "Merge Files";
            this.buttonMergeFiles.UseVisualStyleBackColor = true;
            this.buttonMergeFiles.Click += new System.EventHandler(this.buttonMergeFiles_Click);
            // 
            // buttonRemoveMergePDF
            // 
            this.buttonRemoveMergePDF.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRemoveMergePDF.Location = new System.Drawing.Point(632, 0);
            this.buttonRemoveMergePDF.Name = "buttonRemoveMergePDF";
            this.buttonRemoveMergePDF.Size = new System.Drawing.Size(154, 31);
            this.buttonRemoveMergePDF.TabIndex = 1;
            this.buttonRemoveMergePDF.Text = "Remove";
            this.buttonRemoveMergePDF.UseVisualStyleBackColor = true;
            this.buttonRemoveMergePDF.Click += new System.EventHandler(this.RemovePanelHandle);
            // 
            // MergeFilesSelectButton
            // 
            this.MergeFilesSelectButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MergeFilesSelectButton.Location = new System.Drawing.Point(3, 3);
            this.MergeFilesSelectButton.Name = "MergeFilesSelectButton";
            this.MergeFilesSelectButton.Size = new System.Drawing.Size(786, 29);
            this.MergeFilesSelectButton.TabIndex = 0;
            this.MergeFilesSelectButton.Text = "Select Files";
            this.MergeFilesSelectButton.UseVisualStyleBackColor = true;
            this.MergeFilesSelectButton.Click += new System.EventHandler(this.MergeFilesSelectButton_Click);
            // 
            // SplitPDF
            // 
            this.SplitPDF.Controls.Add(this.panel3);
            this.SplitPDF.Controls.Add(this.flowLayoutPanel1);
            this.SplitPDF.Controls.Add(this.groupBox1);
            this.SplitPDF.Controls.Add(this.buttonSplitPdfSelectFile);
            this.SplitPDF.Location = new System.Drawing.Point(4, 29);
            this.SplitPDF.Name = "SplitPDF";
            this.SplitPDF.Padding = new System.Windows.Forms.Padding(3);
            this.SplitPDF.Size = new System.Drawing.Size(792, 392);
            this.SplitPDF.TabIndex = 1;
            this.SplitPDF.Text = "SplitPDF";
            this.SplitPDF.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(3, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 262);
            this.panel3.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelSplitPdfAtPage);
            this.flowLayoutPanel1.Controls.Add(this.textBoxSplitPageValue);
            this.flowLayoutPanel1.Controls.Add(this.buttonSplitPdf);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(786, 40);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // labelSplitPdfAtPage
            // 
            this.labelSplitPdfAtPage.AutoSize = true;
            this.labelSplitPdfAtPage.Location = new System.Drawing.Point(3, 0);
            this.labelSplitPdfAtPage.Name = "labelSplitPdfAtPage";
            this.labelSplitPdfAtPage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelSplitPdfAtPage.Size = new System.Drawing.Size(124, 25);
            this.labelSplitPdfAtPage.TabIndex = 0;
            this.labelSplitPdfAtPage.Text = "Split PDF At Page";
            // 
            // textBoxSplitPageValue
            // 
            this.textBoxSplitPageValue.Location = new System.Drawing.Point(133, 3);
            this.textBoxSplitPageValue.Name = "textBoxSplitPageValue";
            this.textBoxSplitPageValue.Size = new System.Drawing.Size(125, 27);
            this.textBoxSplitPageValue.TabIndex = 1;
            this.textBoxSplitPageValue.Text = "0";
            this.textBoxSplitPageValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSplitPageValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressHandle);
            // 
            // buttonSplitPdf
            // 
            this.buttonSplitPdf.Location = new System.Drawing.Point(264, 3);
            this.buttonSplitPdf.Name = "buttonSplitPdf";
            this.buttonSplitPdf.Size = new System.Drawing.Size(94, 29);
            this.buttonSplitPdf.TabIndex = 3;
            this.buttonSplitPdf.Text = "SplitPDF";
            this.buttonSplitPdf.UseVisualStyleBackColor = true;
            this.buttonSplitPdf.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSplitPdfSelectedFile);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected File";
            // 
            // textBoxSplitPdfSelectedFile
            // 
            this.textBoxSplitPdfSelectedFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSplitPdfSelectedFile.Enabled = false;
            this.textBoxSplitPdfSelectedFile.Location = new System.Drawing.Point(3, 23);
            this.textBoxSplitPdfSelectedFile.Name = "textBoxSplitPdfSelectedFile";
            this.textBoxSplitPdfSelectedFile.Size = new System.Drawing.Size(780, 27);
            this.textBoxSplitPdfSelectedFile.TabIndex = 0;
            this.textBoxSplitPdfSelectedFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSplitPdfSelectFile
            // 
            this.buttonSplitPdfSelectFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSplitPdfSelectFile.Location = new System.Drawing.Point(3, 3);
            this.buttonSplitPdfSelectFile.Name = "buttonSplitPdfSelectFile";
            this.buttonSplitPdfSelectFile.Size = new System.Drawing.Size(786, 29);
            this.buttonSplitPdfSelectFile.TabIndex = 0;
            this.buttonSplitPdfSelectFile.Text = "Select PDF file";
            this.buttonSplitPdfSelectFile.UseVisualStyleBackColor = true;
            this.buttonSplitPdfSelectFile.Click += new System.EventHandler(this.buttonSplitPdfSelectFile_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // openFileDialogMergepdf
            // 
            this.openFileDialogMergepdf.DefaultExt = "pdf(*.pdf)";
            this.openFileDialogMergepdf.Filter = "pdf|*.pdf";
            this.openFileDialogMergepdf.Multiselect = true;
            this.openFileDialogMergepdf.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogMergepdf_FileOk);
            // 
            // saveFileDialogMergepdf
            // 
            this.saveFileDialogMergepdf.DefaultExt = "*.pdf";
            this.saveFileDialogMergepdf.Filter = "pdf|*.pdf";
            this.saveFileDialogMergepdf.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogMergepdf_FileOk);
            // 
            // openFileDialogSplitPdf
            // 
            this.openFileDialogSplitPdf.DefaultExt = "*.pdf";
            this.openFileDialogSplitPdf.Filter = "pdf|*.pdf";
            this.openFileDialogSplitPdf.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogSplitPdf_FileOk);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSplitPdfFilename1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 50);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filename1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSplitPdfFilename2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 50);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filename2";
            // 
            // textBoxSplitPdfFilename1
            // 
            this.textBoxSplitPdfFilename1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSplitPdfFilename1.Location = new System.Drawing.Point(3, 23);
            this.textBoxSplitPdfFilename1.Name = "textBoxSplitPdfFilename1";
            this.textBoxSplitPdfFilename1.Size = new System.Drawing.Size(780, 27);
            this.textBoxSplitPdfFilename1.TabIndex = 0;
            // 
            // textBoxSplitPdfFilename2
            // 
            this.textBoxSplitPdfFilename2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSplitPdfFilename2.Location = new System.Drawing.Point(3, 23);
            this.textBoxSplitPdfFilename2.Name = "textBoxSplitPdfFilename2";
            this.textBoxSplitPdfFilename2.Size = new System.Drawing.Size(780, 27);
            this.textBoxSplitPdfFilename2.TabIndex = 0;
            // 
            // PdfTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "PdfTools";
            this.Text = "PDFTOOLS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxSelectedFilesMergePDF.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.SplitPDF.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBoxSelectedFilesMergePDF;
        private Button MergeFilesSelectButton;
        private TabPage SplitPDF;
        private StatusStrip statusStrip1;
        private Panel panel1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel panel2;
        private Button buttonRemoveMergePDF;
        private Button buttonMergeFiles;
        private OpenFileDialog openFileDialogMergepdf;
        private SaveFileDialog saveFileDialogMergepdf;
        private GroupBox groupBox1;
        private TextBox textBoxSplitPdfSelectedFile;
        private Button buttonSplitPdfSelectFile;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelSplitPdfAtPage;
        private TextBox textBoxSplitPageValue;
        private OpenFileDialog openFileDialogSplitPdf;
        private Button buttonSplitPdf;
        private Panel panel3;
        private GroupBox groupBox3;
        private TextBox textBoxSplitPdfFilename2;
        private GroupBox groupBox2;
        private TextBox textBoxSplitPdfFilename1;
    }
}