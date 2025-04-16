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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBoxSelectedFilesMergePDF = new GroupBox();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonMergeFiles = new Button();
            buttonRemoveMergePDF = new Button();
            MergeFilesSelectButton = new Button();
            SplitPDF = new TabPage();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            textBoxSplitPdfFilename2 = new TextBox();
            groupBox2 = new GroupBox();
            textBoxSplitPdfFilename1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelSplitPdfAtPage = new Label();
            textBoxSplitPageValue = new TextBox();
            buttonSplitPdf = new Button();
            groupBox1 = new GroupBox();
            textBoxSplitPdfSelectedFile = new TextBox();
            buttonSplitPdfSelectFile = new Button();
            tabControl2 = new TabPage();
            flowLayoutPanel2 = new FlowLayoutPanel();
            extractPdfSelectButton = new Button();
            groupBox4 = new GroupBox();
            textBoxExtractPagesSelectedFile = new TextBox();
            panelExtractPagesBottom = new Panel();
            groupBox5 = new GroupBox();
            textBoxExtractPageNumbers = new TextBox();
            buttonExtractPage = new Button();
            checkBoxExtractMerge = new CheckBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            openFileDialogMergepdf = new OpenFileDialog();
            saveFileDialogMergepdf = new SaveFileDialog();
            openFileDialogSplitPdf = new OpenFileDialog();
            openFileDialogExtractPages = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBoxSelectedFilesMergePDF.SuspendLayout();
            panel2.SuspendLayout();
            SplitPDF.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox4.SuspendLayout();
            panelExtractPagesBottom.SuspendLayout();
            groupBox5.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(SplitPDF);
            tabControl1.Controls.Add(tabControl2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(700, 316);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBoxSelectedFilesMergePDF);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(MergeFilesSelectButton);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(692, 288);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "MergePDF";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxSelectedFilesMergePDF
            // 
            groupBoxSelectedFilesMergePDF.Controls.Add(panel1);
            groupBoxSelectedFilesMergePDF.Dock = DockStyle.Fill;
            groupBoxSelectedFilesMergePDF.Location = new Point(3, 24);
            groupBoxSelectedFilesMergePDF.Margin = new Padding(3, 2, 3, 2);
            groupBoxSelectedFilesMergePDF.Name = "groupBoxSelectedFilesMergePDF";
            groupBoxSelectedFilesMergePDF.Padding = new Padding(3, 2, 3, 2);
            groupBoxSelectedFilesMergePDF.Size = new Size(686, 239);
            groupBoxSelectedFilesMergePDF.TabIndex = 2;
            groupBoxSelectedFilesMergePDF.TabStop = false;
            groupBoxSelectedFilesMergePDF.Text = "Selected Files";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 18);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 219);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonMergeFiles);
            panel2.Controls.Add(buttonRemoveMergePDF);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 263);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(686, 23);
            panel2.TabIndex = 3;
            // 
            // buttonMergeFiles
            // 
            buttonMergeFiles.Dock = DockStyle.Fill;
            buttonMergeFiles.Location = new Point(0, 0);
            buttonMergeFiles.Margin = new Padding(3, 2, 3, 2);
            buttonMergeFiles.Name = "buttonMergeFiles";
            buttonMergeFiles.Size = new Size(551, 23);
            buttonMergeFiles.TabIndex = 0;
            buttonMergeFiles.Text = "Merge Files";
            buttonMergeFiles.UseVisualStyleBackColor = true;
            buttonMergeFiles.Click += buttonMergeFiles_Click;
            // 
            // buttonRemoveMergePDF
            // 
            buttonRemoveMergePDF.Dock = DockStyle.Right;
            buttonRemoveMergePDF.Location = new Point(551, 0);
            buttonRemoveMergePDF.Margin = new Padding(3, 2, 3, 2);
            buttonRemoveMergePDF.Name = "buttonRemoveMergePDF";
            buttonRemoveMergePDF.Size = new Size(135, 23);
            buttonRemoveMergePDF.TabIndex = 1;
            buttonRemoveMergePDF.Text = "Remove";
            buttonRemoveMergePDF.UseVisualStyleBackColor = true;
            buttonRemoveMergePDF.Click += RemovePanelHandle;
            // 
            // MergeFilesSelectButton
            // 
            MergeFilesSelectButton.Dock = DockStyle.Top;
            MergeFilesSelectButton.Location = new Point(3, 2);
            MergeFilesSelectButton.Margin = new Padding(3, 2, 3, 2);
            MergeFilesSelectButton.Name = "MergeFilesSelectButton";
            MergeFilesSelectButton.Size = new Size(686, 22);
            MergeFilesSelectButton.TabIndex = 0;
            MergeFilesSelectButton.Text = "Select Files";
            MergeFilesSelectButton.UseVisualStyleBackColor = true;
            MergeFilesSelectButton.Click += MergeFilesSelectButton_Click;
            // 
            // SplitPDF
            // 
            SplitPDF.Controls.Add(panel3);
            SplitPDF.Controls.Add(flowLayoutPanel1);
            SplitPDF.Controls.Add(groupBox1);
            SplitPDF.Controls.Add(buttonSplitPdfSelectFile);
            SplitPDF.Location = new Point(4, 24);
            SplitPDF.Margin = new Padding(3, 2, 3, 2);
            SplitPDF.Name = "SplitPDF";
            SplitPDF.Padding = new Padding(3, 2, 3, 2);
            SplitPDF.Size = new Size(692, 288);
            SplitPDF.TabIndex = 1;
            SplitPDF.Text = "SplitPDF";
            SplitPDF.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Enabled = false;
            panel3.Location = new Point(3, 95);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(686, 191);
            panel3.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxSplitPdfFilename2);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 38);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(686, 38);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filename2";
            // 
            // textBoxSplitPdfFilename2
            // 
            textBoxSplitPdfFilename2.Dock = DockStyle.Top;
            textBoxSplitPdfFilename2.Location = new Point(3, 18);
            textBoxSplitPdfFilename2.Margin = new Padding(3, 2, 3, 2);
            textBoxSplitPdfFilename2.Name = "textBoxSplitPdfFilename2";
            textBoxSplitPdfFilename2.Size = new Size(680, 23);
            textBoxSplitPdfFilename2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxSplitPdfFilename1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(686, 38);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filename1";
            // 
            // textBoxSplitPdfFilename1
            // 
            textBoxSplitPdfFilename1.Dock = DockStyle.Top;
            textBoxSplitPdfFilename1.Location = new Point(3, 18);
            textBoxSplitPdfFilename1.Margin = new Padding(3, 2, 3, 2);
            textBoxSplitPdfFilename1.Name = "textBoxSplitPdfFilename1";
            textBoxSplitPdfFilename1.Size = new Size(680, 23);
            textBoxSplitPdfFilename1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelSplitPdfAtPage);
            flowLayoutPanel1.Controls.Add(textBoxSplitPageValue);
            flowLayoutPanel1.Controls.Add(buttonSplitPdf);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 65);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(686, 30);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // labelSplitPdfAtPage
            // 
            labelSplitPdfAtPage.AutoSize = true;
            labelSplitPdfAtPage.Location = new Point(3, 0);
            labelSplitPdfAtPage.Name = "labelSplitPdfAtPage";
            labelSplitPdfAtPage.Padding = new Padding(0, 4, 0, 0);
            labelSplitPdfAtPage.Size = new Size(98, 19);
            labelSplitPdfAtPage.TabIndex = 0;
            labelSplitPdfAtPage.Text = "Split PDF At Page";
            // 
            // textBoxSplitPageValue
            // 
            textBoxSplitPageValue.Location = new Point(107, 2);
            textBoxSplitPageValue.Margin = new Padding(3, 2, 3, 2);
            textBoxSplitPageValue.Name = "textBoxSplitPageValue";
            textBoxSplitPageValue.Size = new Size(110, 23);
            textBoxSplitPageValue.TabIndex = 1;
            textBoxSplitPageValue.Text = "0";
            textBoxSplitPageValue.TextAlign = HorizontalAlignment.Right;
            textBoxSplitPageValue.KeyPress += textBox_KeyPressHandle;
            // 
            // buttonSplitPdf
            // 
            buttonSplitPdf.Location = new Point(223, 2);
            buttonSplitPdf.Margin = new Padding(3, 2, 3, 2);
            buttonSplitPdf.Name = "buttonSplitPdf";
            buttonSplitPdf.Size = new Size(82, 22);
            buttonSplitPdf.TabIndex = 3;
            buttonSplitPdf.Text = "SplitPDF";
            buttonSplitPdf.UseVisualStyleBackColor = true;
            buttonSplitPdf.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxSplitPdfSelectedFile);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 24);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(686, 41);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected File";
            // 
            // textBoxSplitPdfSelectedFile
            // 
            textBoxSplitPdfSelectedFile.Dock = DockStyle.Fill;
            textBoxSplitPdfSelectedFile.Enabled = false;
            textBoxSplitPdfSelectedFile.Location = new Point(3, 18);
            textBoxSplitPdfSelectedFile.Margin = new Padding(3, 2, 3, 2);
            textBoxSplitPdfSelectedFile.Name = "textBoxSplitPdfSelectedFile";
            textBoxSplitPdfSelectedFile.Size = new Size(680, 23);
            textBoxSplitPdfSelectedFile.TabIndex = 0;
            textBoxSplitPdfSelectedFile.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonSplitPdfSelectFile
            // 
            buttonSplitPdfSelectFile.Dock = DockStyle.Top;
            buttonSplitPdfSelectFile.Location = new Point(3, 2);
            buttonSplitPdfSelectFile.Margin = new Padding(3, 2, 3, 2);
            buttonSplitPdfSelectFile.Name = "buttonSplitPdfSelectFile";
            buttonSplitPdfSelectFile.Size = new Size(686, 22);
            buttonSplitPdfSelectFile.TabIndex = 0;
            buttonSplitPdfSelectFile.Text = "Select PDF file";
            buttonSplitPdfSelectFile.UseVisualStyleBackColor = true;
            buttonSplitPdfSelectFile.Click += buttonSplitPdfSelectFile_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(flowLayoutPanel2);
            tabControl2.Location = new Point(4, 24);
            tabControl2.Name = "tabControl2";
            tabControl2.Padding = new Padding(3);
            tabControl2.Size = new Size(692, 288);
            tabControl2.TabIndex = 2;
            tabControl2.Text = "ExtractPages";
            tabControl2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(extractPdfSelectButton);
            flowLayoutPanel2.Controls.Add(groupBox4);
            flowLayoutPanel2.Controls.Add(panelExtractPagesBottom);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(686, 282);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // extractPdfSelectButton
            // 
            extractPdfSelectButton.Dock = DockStyle.Top;
            extractPdfSelectButton.Location = new Point(3, 3);
            extractPdfSelectButton.Name = "extractPdfSelectButton";
            extractPdfSelectButton.Size = new Size(680, 22);
            extractPdfSelectButton.TabIndex = 0;
            extractPdfSelectButton.Text = "SelectPDF";
            extractPdfSelectButton.UseVisualStyleBackColor = true;
            extractPdfSelectButton.Click += extractPdfSelectButton_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBoxExtractPagesSelectedFile);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Location = new Point(3, 31);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(680, 45);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Selected File";
            // 
            // textBoxExtractPagesSelectedFile
            // 
            textBoxExtractPagesSelectedFile.Dock = DockStyle.Top;
            textBoxExtractPagesSelectedFile.Enabled = false;
            textBoxExtractPagesSelectedFile.Location = new Point(3, 19);
            textBoxExtractPagesSelectedFile.Name = "textBoxExtractPagesSelectedFile";
            textBoxExtractPagesSelectedFile.Size = new Size(674, 23);
            textBoxExtractPagesSelectedFile.TabIndex = 0;
            // 
            // panelExtractPagesBottom
            // 
            panelExtractPagesBottom.Controls.Add(groupBox5);
            panelExtractPagesBottom.Controls.Add(buttonExtractPage);
            panelExtractPagesBottom.Controls.Add(checkBoxExtractMerge);
            panelExtractPagesBottom.Dock = DockStyle.Top;
            panelExtractPagesBottom.Enabled = false;
            panelExtractPagesBottom.Location = new Point(3, 82);
            panelExtractPagesBottom.Name = "panelExtractPagesBottom";
            panelExtractPagesBottom.Size = new Size(680, 130);
            panelExtractPagesBottom.TabIndex = 4;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBoxExtractPageNumbers);
            groupBox5.Dock = DockStyle.Top;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(680, 50);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Page Numbers";
            // 
            // textBoxExtractPageNumbers
            // 
            textBoxExtractPageNumbers.Dock = DockStyle.Top;
            textBoxExtractPageNumbers.Location = new Point(3, 19);
            textBoxExtractPageNumbers.Name = "textBoxExtractPageNumbers";
            textBoxExtractPageNumbers.Size = new Size(674, 23);
            textBoxExtractPageNumbers.TabIndex = 0;
            // 
            // buttonExtractPage
            // 
            buttonExtractPage.Location = new Point(10, 56);
            buttonExtractPage.Name = "buttonExtractPage";
            buttonExtractPage.Size = new Size(680, 23);
            buttonExtractPage.TabIndex = 3;
            buttonExtractPage.Text = "Extract";
            buttonExtractPage.UseVisualStyleBackColor = true;
            buttonExtractPage.Click += buttonExtractPage_Click;
            // 
            // checkBoxExtractMerge
            // 
            checkBoxExtractMerge.AutoSize = true;
            checkBoxExtractMerge.Checked = true;
            checkBoxExtractMerge.CheckState = CheckState.Checked;
            checkBoxExtractMerge.Location = new Point(279, 85);
            checkBoxExtractMerge.Name = "checkBoxExtractMerge";
            checkBoxExtractMerge.Size = new Size(146, 19);
            checkBoxExtractMerge.TabIndex = 4;
            checkBoxExtractMerge.Text = "Merge Extracted Pages";
            checkBoxExtractMerge.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 316);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(700, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Status";
            // 
            // openFileDialogMergepdf
            // 
            openFileDialogMergepdf.DefaultExt = "pdf(*.pdf)";
            openFileDialogMergepdf.Filter = "pdf|*.pdf";
            openFileDialogMergepdf.Multiselect = true;
            openFileDialogMergepdf.FileOk += openFileDialogMergepdf_FileOk;
            // 
            // saveFileDialogMergepdf
            // 
            saveFileDialogMergepdf.DefaultExt = "*.pdf";
            saveFileDialogMergepdf.Filter = "pdf|*.pdf";
            saveFileDialogMergepdf.FileOk += saveFileDialogMergepdf_FileOk;
            // 
            // openFileDialogSplitPdf
            // 
            openFileDialogSplitPdf.DefaultExt = "*.pdf";
            openFileDialogSplitPdf.Filter = "pdf|*.pdf";
            openFileDialogSplitPdf.FileOk += openFileDialogSplitPdf_FileOk;
            // 
            // openFileDialogExtractPages
            // 
            openFileDialogExtractPages.DefaultExt = "*.pdf";
            openFileDialogExtractPages.Filter = "pdf|*.pdf";
            openFileDialogExtractPages.FileOk += openFileDialogExtractPages_FileOk;
            // 
            // PdfTools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PdfTools";
            Text = "PDFTOOLS";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBoxSelectedFilesMergePDF.ResumeLayout(false);
            panel2.ResumeLayout(false);
            SplitPDF.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panelExtractPagesBottom.ResumeLayout(false);
            panelExtractPagesBottom.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TabPage tabControl2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button extractPdfSelectButton;
        private GroupBox groupBox4;
        private TextBox textBoxExtractPagesSelectedFile;
        private GroupBox groupBox5;
        private TextBox textBoxExtractPageNumbers;
        private Button buttonExtractPage;
        private OpenFileDialog openFileDialogExtractPages;
        private Panel panelExtractPagesBottom;
        private CheckBox checkBoxExtractMerge;
    }
}