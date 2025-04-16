using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Text;

namespace DragDrop
{
    public partial class PdfTools : Form
    {
        private bool isDragging = false;
        private Point currentPosPanel = new Point();
        private Point currentPosMouse = new Point();
        private List<Panel> panels = new List<Panel>();

        private int panelwidth = 500;
        private int panelheight = 50;
        private int panelpadx = 10;
        private int panelpady = 10;
        private int panelspacing = 0;

        private bool snaptoleft = true;
        private bool snapposy = true;
        private bool layoutsuspension = false;
        Panel? movingpanel = null;

        Color panelbackcolor = Color.White;

        Color defaultpanelcolor = Color.FromArgb(240, 245, 244);
        Color selectedpanelcolor = Color.FromArgb(188, 232, 245);



        IDictionary<string, int> sameFileCountMergePdf = new Dictionary<string, int>();
        List<string> mergepdf_finallist = new List<string>();

        private FDList mergepdf_selectedfiles = new FDList();
        //private Random rnd = new Random();

        public PdfTools()
        {
            InitializeComponent();
        }
        private Panel CreatePanel(int position_x, int position_y, int width, int height)
        {
            Panel panel = new Panel();
            panel.Location = new Point(position_x, position_y);
            panel.Size = new Size(width, height);
            panel.BackColor = defaultpanelcolor;//FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            return panel;
        }

        private void CreatePanels()
        {
            for (int i = panels.Count; i < mergepdf_selectedfiles.Count; i++)
            {
                Panel panel = CreatePanel(panelpadx, panelpady + (panelheight + panelspacing) * panels.Count, panelwidth, panelheight);
                Label l = new Label();
                l.Text = mergepdf_selectedfiles.files[i].Name;
                l.AutoSize = true;
                l.Location = new Point(0, 0);
                l.MouseUp += MouseUpHandle;
                l.MouseMove += MouseMoveHandle;
                l.MouseDown += MouseDownHandle;
                panel.Controls.Add(l);
                panel.MouseUp += MouseUpHandle;
                panel.MouseMove += MouseMoveHandle;
                panel.MouseDown += MouseDownHandle;
                panels.Add(panel);
            }
            AddPanelsto(panel1);
        }

        private void AddPanelsto(object master)
        {
            Panel? obj = master as Panel;
            if (obj != null)
            {
                foreach (Panel p in panels)
                {
                    obj.Controls.Add(p);

                }
            }
        }

        private Point SubtractPoints(Point point1, Point point2)
        {
            Point point = new Point(point1.X - point2.X, point1.Y - point2.Y);
            return point;
        }

        private Point AddPoints(Point point1, Point point2)
        {
            Point point = new Point(point1.X + point2.X, point1.Y + point2.Y);
            return point;
        }

        private void MouseDownHandle(object? sender, MouseEventArgs e)
        {
            if (movingpanel != null)
            {
                //movingpanel.BorderStyle = BorderStyle.None;
                movingpanel.BackColor = panelbackcolor;
            }
            movingpanel = sender as Panel;
            if (movingpanel == null)
            {
                Label? nulllabel = sender as Label;
                if (nulllabel == null)
                {
                    return;
                }
                movingpanel = nulllabel.Parent as Panel;
                if (movingpanel == null)
                {
                    return;
                }
            }
            //toolStripStatusLabel1.Text = "Selected: " + panels.IndexOf(movingpanel).ToString();

            isDragging = true;
            movingpanel.BringToFront();
            currentPosPanel = movingpanel.Location;
            currentPosMouse = e.Location;

            //movingpanel.BorderStyle = BorderStyle.Fixed3D;
            panelbackcolor = movingpanel.BackColor;
            movingpanel.BackColor = selectedpanelcolor;
            toolStripStatusLabel1.Text = "Selected: " + movingpanel.GetChildAtPoint(new Point(0, 0)).Text;

        }

        private void MouseMoveHandle(object? sender, MouseEventArgs e)
        {

            if (isDragging)
            {
                Panel? obj = sender as Panel;

                if (obj == null)
                {
                    Label? nulllabel = sender as Label;
                    if (nulllabel == null)
                    {
                        return;
                    }
                    obj = nulllabel.Parent as Panel;
                    if (obj == null)
                    {
                        return;
                    }
                }
                //autoscrollup clause
                if (obj.Location.Y <= panelpady)
                {
                    if (e.Location.Y < panel1.VerticalScroll.Value)
                    {
                        if (panel1.VerticalScroll.Value > 4)
                        {
                            panel1.VerticalScroll.Value -= 4;
                        }
                        else if (panel1.VerticalScroll.Value <= 4 && panel1.VerticalScroll.Value > 0)
                        {
                            panel1.VerticalScroll.Value = 0;
                        }
                        else
                        {
                            if (movingpanel != null)
                            {
                                if (movingpanel.Location.Y != panelpady)
                                {
                                    movingpanel.Location = new Point(panelpadx, panelpady);
                                }
                            }

                            return;
                        }
                    }


                }

                currentPosPanel = new Point(currentPosPanel.X + e.Location.X - currentPosMouse.X, currentPosPanel.Y + e.Location.Y - currentPosMouse.Y);

                int index = GetPanelPos();
                if (index != panels.IndexOf(obj) && index < panels.Count)
                {
                    if (index < 0)
                    {
                        if (movingpanel != null)
                        {

                            movingpanel.Location = new Point(panelpadx, panelpady);
                        }

                        return;
                    }
                    MovePaneltoIndex(panels[index], panels.IndexOf(obj));

                }

                //autoscroll down clause
                toolStripStatusLabel1.Text = (panel1.VerticalScroll.Value + obj.Location.Y).ToString() + " " + (panels.Count * (panelheight + panelspacing));
                if (currentPosPanel.Y > panel1.Height)
                {
                    if (panel1.VerticalScroll.Value + obj.Location.Y <= panels.Count * (panelheight + panelspacing))
                    {
                        panel1.VerticalScroll.Value += 4;

                    }
                    else if (e.Y > 0)
                    {
                        obj.Location = AddPoints(panels[panels.Count - 2].Location, new Point(0, panelheight + panelspacing));

                        layoutsuspension = true;

                    }


                }

                if (!layoutsuspension)
                {
                    obj.Location = currentPosPanel;

                }
                else
                {
                    if (e.Y < 0)
                    {
                        layoutsuspension = false;

                    }

                }
            }
        }

        private void MouseUpHandle(object? sender, MouseEventArgs eventArgs)
        {
            layoutsuspension = false;
            isDragging = false;
            if (movingpanel != null)
            {
                if (snaptoleft)
                {
                    movingpanel.Location = new Point(panelpadx, movingpanel.Location.Y);
                }
                if (snapposy)
                {
                    int pos;
                    int index = GetPanelPos();
                    if (index >= panels.Count)
                    {
                        pos = panelpady + (panels.Count - 1) * (panelspacing + panelheight);
                    }
                    else
                    {
                        pos = panelpady + index * (panelspacing + panelheight);
                    }
                    if (pos < 0)
                    {
                        pos = 0;
                    }

                    movingpanel.Location = new Point(panelpadx, pos + panel1.AutoScrollPosition.Y);
                }

            }
        }

        private void RemovePanelHandle(object sender, EventArgs e)
        {
            if (movingpanel == null)
            {
                toolStripStatusLabel1.Text = "Nothing Selected to Remove";
                return;
            }
            string name = movingpanel.GetChildAtPoint(new Point(0, 0)).Text;
            toolStripStatusLabel1.Text = "Removed " + name + " from the list";
            mergepdf_selectedfiles.Remove(name);
            name = Path.GetFileNameWithoutExtension(name) + ".pdf";
            panels.Remove(movingpanel);
            if (sameFileCountMergePdf.ContainsKey(name))
            {
                if (sameFileCountMergePdf[name] == 0)
                {
                    sameFileCountMergePdf.Remove(name);

                }
                else
                {
                    sameFileCountMergePdf[name] -= 1;

                }
            }
            panel1.Controls.Remove(movingpanel);

            movingpanel = null;

            UpdateListPanels();

        }

        private void UpdateListPanels()
        {
            for (int i = 0; i < panels.Count; i++)
            {
                panels[i].Location = new Point(panelpadx, panelpady - panel1.VerticalScroll.Value + i * (panelspacing + panelheight));
            }


        }
        private int GetPanelPos()
        {
            if (movingpanel != null)
            {//new changed
                return (movingpanel.Location.Y - panelpady - panel1.AutoScrollPosition.Y) / (panelspacing + panelheight);

            }
            return 0;
        }

        private int GetPanelPosRev(int pos)
        {
            if (movingpanel != null)
            {
                return panelpady + pos * (panelspacing + panelheight);

            }
            return 0;
        }

        private void MovePaneltoIndex(Panel panel, int pos)
        {
            //toolStripStatusLabel1.Text = "Swap " + pos.ToString() + " " + panels.IndexOf(panel).ToString();
            panel.Location = new Point(panelpadx, GetPanelPosRev(pos) + panel1.AutoScrollPosition.Y);
            Swap(panels, pos, panels.IndexOf(panel));

        }

        public static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CreatePanels();
            //AddPanelsto(panel1);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (movingpanel != null)
            {
                //movingpanel.BorderStyle = BorderStyle.None;
                movingpanel.BackColor = panelbackcolor;
                movingpanel = null;
            }
            toolStripStatusLabel1.Text = "Selected: None";

            //Graphics g = panel1.CreateGraphics();
            //g.FillRectangle(new SolidBrush(Color.FromArgb(0, Color.Black)), panel1.DisplayRectangle);
            //Point[] points = new Point[4];

            //points[0] = new Point(0, 0);
            //points[1] = new Point(0, panel1.Height);
            //points[2] = new Point(panel1.Width, panel1.Height);
            //points[3] = new Point(panel1.Width, 0);

            //Brush brush = new SolidBrush(Color.DarkGreen);

            //g.FillPolygon(brush, points);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (movingpanel != null)
            {
                if (e.KeyData == Keys.Delete)
                {
                    panels.Remove(movingpanel);
                    panel1.Controls.Remove(movingpanel);
                    movingpanel = null;
                    UpdateListPanels();
                }
            }
        }

        private void MergeFilesSelectButton_Click(object sender, EventArgs e)
        {
            openFileDialogMergepdf.FileName = "";
            openFileDialogMergepdf.ShowDialog();
        }

        private void openFileDialogMergepdf_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (string i in openFileDialogMergepdf.FileNames)
            {
                string key = Path.GetFileName(i);
                if (sameFileCountMergePdf.ContainsKey(key) == false)
                {
                    sameFileCountMergePdf.Add(key, 0);
                }
                else
                {
                    sameFileCountMergePdf[key] += 1;

                    string tempkey = key + "_" + sameFileCountMergePdf[key].ToString();
                    int tempcount = sameFileCountMergePdf[key];

                    while (mergepdf_selectedfiles.filenames.Contains(tempkey))
                    {
                        tempcount += 1;
                        tempkey = key + "_" + tempcount.ToString();
                    }
                    key = tempkey;
                }
                mergepdf_selectedfiles.Add(key, i);
            }
            CreatePanels();
        }

        private void buttonMergeFiles_Click(object sender, EventArgs e)
        {
            if (panels.Count > 1)
            {
                saveFileDialogMergepdf.ShowDialog();

            }
            else
            {
                toolStripStatusLabel1.Text = "Add at least two files";

            }
        }

        private void saveFileDialogMergepdf_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MergePDFs(saveFileDialogMergepdf.FileName, mergepdf_selectedfiles.filelocations.ToArray());
        }

        public void MergePDFs(string targetPath, params string[] pdfs)
        {
            mergepdf_finallist.Clear();
            foreach (Panel p in panels)
            {
                mergepdf_finallist.Add(mergepdf_selectedfiles.locfromkey[p.GetChildAtPoint(new Point(0, 0)).Text]);
            }

            using (var targetDoc = new PdfDocument())
            {
                foreach (var pdf in mergepdf_finallist)
                {
                    using (var pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                    {
                        for (var i = 0; i < pdfDoc.PageCount; i++)
                            targetDoc.AddPage(pdfDoc.Pages[i]);
                    }
                }
                targetDoc.Save(targetPath);
            }
            toolStripStatusLabel1.Text = "Successfully merged file to " + targetPath;

        }

        private void textBox_KeyPressHandle(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            //if (sender == null) { return; }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void buttonSplitPdfSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialogSplitPdf.ShowDialog();
        }

        private void openFileDialogSplitPdf_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            textBoxSplitPdfSelectedFile.Text = openFileDialogSplitPdf.FileName;
            panel3.Enabled = true;
            textBoxSplitPdfFilename1.Text = Path.GetFileNameWithoutExtension(openFileDialogSplitPdf.FileName) + "_1";
            textBoxSplitPdfFilename2.Text = Path.GetFileNameWithoutExtension(openFileDialogSplitPdf.FileName) + "_2";
        }

        private void SplitPdf(string sourceFilename, int pageNumber, string saveFilenameBefore, string saveFilenameAfter)
        {
            PdfDocument inputDocument = PdfReader.Open(sourceFilename, PdfDocumentOpenMode.Import);
            if (inputDocument.Pages.Count < pageNumber)
            {
                toolStripStatusLabel1.Text = "Split number cannot be larger or equal to Total no of Pages";
                return;
            }
            using (inputDocument)
            {
                // Save pages before split page number
                PdfDocument outputDocumentBefore = new PdfDocument();
                for (int i = 1; i < pageNumber; i++)
                {
                    outputDocumentBefore.AddPage(inputDocument.Pages[i - 1]);
                }
                outputDocumentBefore.Save(saveFilenameBefore);

                // Save pages after split page number
                PdfDocument outputDocumentAfter = new PdfDocument();
                for (int i = pageNumber; i <= inputDocument.Pages.Count; i++)
                {
                    outputDocumentAfter.AddPage(inputDocument.Pages[i - 1]);
                }
                outputDocumentAfter.Save(saveFilenameAfter);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int splitnumber = Convert.ToInt32(textBoxSplitPageValue.Text);
            if (textBoxSplitPdfSelectedFile.Text == "")
            {
                toolStripStatusLabel1.Text = "Select file first";
            }
            if (splitnumber <= 1)
            {
                toolStripStatusLabel1.Text = "Cannot pdf before page " + splitnumber.ToString() + " into first file!";
                return;
            }
            string? directory = Path.GetDirectoryName(textBoxSplitPdfSelectedFile.Text);
            if (directory == null)
            {
                unexpectedError();
                return;
            }
            string savepath1 = Path.Combine(directory, textBoxSplitPdfFilename1.Text + ".pdf");
            string savepath2 = Path.Combine(directory, textBoxSplitPdfFilename2.Text + ".pdf");
            if (savepath1 == savepath2)
            {
                toolStripStatusLabel1.Text = "Saves files cannot have same name";
                return;
            }
            SplitPdf(textBoxSplitPdfSelectedFile.Text, splitnumber, savepath1, savepath2);
            toolStripStatusLabel1.Text = "Succesfully completed splitting pdf at page " + textBoxSplitPageValue.Text;
        }

        private void extractPdfSelectButton_Click(object sender, EventArgs e)
        {
            openFileDialogExtractPages.ShowDialog();

        }

        private void openFileDialogExtractPages_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            textBoxExtractPagesSelectedFile.Text = openFileDialogExtractPages.FileName;
            panelExtractPagesBottom.Enabled = true;
        }

        private void unexpectedError()
        {
            toolStripStatusLabel1.Text = "Unexpected Error";
        }

        private void buttonExtractPage_Click(object sender, EventArgs e)
        {
            if (textBoxExtractPageNumbers.Text == "") return;
            int[] pgNumbers;
            try
            {
                pgNumbers = textBoxExtractPageNumbers.Text
                    .Split(',')
                    .Select(s => int.Parse(s.Trim()))
                    .ToArray();
            }
            catch (FormatException) 
            {
                toolStripStatusLabel1.Text = "Could not parse the pg numbers; Invalid Format";
                return; 
            }
            catch (OverflowException)
            {
                toolStripStatusLabel1.Text = "Could not parse the pg numbers; Integer Overflow";
                return; 
            }
            catch (Exception)
            {
                toolStripStatusLabel1.Text = "Could not parse the pg numbers; Unexpected Error";
                return; 
            }
            if (pgNumbers.Length == 0) return;
            string? directory = Path.GetDirectoryName(textBoxExtractPagesSelectedFile.Text);
            if (directory == null)
            {
                unexpectedError();
                return;
            }
            string fileNameWithoutExt = Path.GetFileNameWithoutExtension(textBoxExtractPagesSelectedFile.Text);
            string extension = Path.GetExtension(textBoxExtractPagesSelectedFile.Text);
            if (checkBoxExtractMerge.Checked)
            {
                string newFileName = $"{fileNameWithoutExt}_{string.Join("_", pgNumbers)}{extension}";
                string savepath1 = Path.Combine(directory, newFileName);
                PdfDocument inputDocument = PdfReader.Open(textBoxExtractPagesSelectedFile.Text, PdfDocumentOpenMode.Import);
                using (inputDocument)
                {
                    // Save the pages
                    PdfDocument outputDocument = new PdfDocument();
                    for (int i = 0; i < pgNumbers.Length; i++)
                    {
                        if (pgNumbers[i] <= 0)
                        {
                            toolStripStatusLabel1.Text = $"Page Numbers must start with 1; {pgNumbers[i]} found";
                            return;
                        }
                        else if (pgNumbers[i] > inputDocument.PageCount)
                        {
                            toolStripStatusLabel1.Text = $"Page Numbers exceed maximum of {inputDocument.PageCount}";
                            return;

                        }
                        outputDocument.AddPage(inputDocument.Pages[pgNumbers[i] - 1]);
                    }
                    outputDocument.Save(savepath1);
                }
            }
            else
            {
                PdfDocument inputDocument = PdfReader.Open(textBoxExtractPagesSelectedFile.Text, PdfDocumentOpenMode.Import);
                for (int i = 0; i < pgNumbers.Length; i++)
                {
                    if (pgNumbers[i] <= 0)
                    {
                        toolStripStatusLabel1.Text = $"Page Numbers must start with 1; {pgNumbers[i]} found";
                        return;
                    }
                    else if (pgNumbers[i] > inputDocument.PageCount)
                    {
                        toolStripStatusLabel1.Text = $"Page Numbers exceed maximum of {inputDocument.PageCount}";
                        return;

                    }
                    string newFileName = $"{fileNameWithoutExt}_{pgNumbers[i]}{extension}";
                    string savepath1 = Path.Combine(directory, newFileName);
                    PdfDocument outputDocument = new PdfDocument();
                    outputDocument.AddPage(inputDocument.Pages[pgNumbers[i] - 1]);
                    outputDocument.Save(savepath1);
                }
            }
            toolStripStatusLabel1.Text = "Extract Pages: " + textBoxExtractPageNumbers.Text + " completed successfullly";
        }
    }
}