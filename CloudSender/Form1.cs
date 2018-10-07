using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CloudSender.Properties;
using Microsoft.VisualBasic;

namespace CloudSender
{
    public partial class Form1 : Form
    {
        private string _lastRandom = string.Empty;
        private string _random = string.Empty;
        private bool _newFileMode;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            TopMost = true;
            Top = 0;
            Left = Screen.PrimaryScreen.WorkingArea.Width - Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            foreach (var directory in Directory.GetDirectories("."))
            {
                dfcCollections.Items.Add(directory.Substring(2));
            }
            if (File.Exists("LastUsedCollection"))
            {
                var lastUsedCollection = File.ReadAllText("LastUsedCollection");
                if (!string.IsNullOrEmpty(lastUsedCollection) && dfcCollections.Items.Contains(lastUsedCollection))
                {
                    dfcCollections.SelectedItem = lastUsedCollection;
                    return;
                }
                
                
            }


            dfcCollections.SelectedIndex = 0;
        }

        public  int StringToInt(string input)
        {
            var fileName = Path.GetFileNameWithoutExtension(input);
            if (fileName != null && Regex.IsMatch(fileName, @"^\d+$"))
            {
                return int.Parse(fileName);
            }
            return 0;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            Hide();
            CaptureScreen();
            File.WriteAllText(dfcCollections.SelectedItem + "\\"+ dfsPageName.Text + ".CloudSender", dfsSendString.Text);
            if (!File.Exists(dfcCollections.SelectedItem + "\\" + dfsPageName.Text + ".CloudSender"))
                _newFileMode = true;

            if (_newFileMode)
            {
                var files = Directory.GetFiles("." + "\\" +  dfcCollections.SelectedItem , "*.CloudSender");
                foreach (var file in files)
                    lstPages.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
            if (dfsSendString.Text.Contains("{random}")) //If the string to send does not contain random then both lastrandom for sure will retain previous value
            {
                _random = DateTime.Now.Ticks.ToString("x");
                _lastRandom = _random;

                Clipboard.SetText(_random + "@sharklasers.com");
                tsMessage.Text = $"Copied {_random}@sharklasers.com to clipboard";
            }

            if (dfsSendString.Text.Contains("{lastrandom}")) //If the string to send does not contain random then both lastrandom for sure will retain previous value
            {
                if (string.IsNullOrEmpty(_lastRandom))
                    _random = DateTime.Now.Ticks.ToString("x");

                _lastRandom = _random;
                Clipboard.SetText(_lastRandom + "@sharklasers.com");
                tsMessage.Text = $"Copied {_lastRandom}@sharklasers.com to clipboard";
            }


            

            var stringToSend = dfsSendString.Text.Replace("{random}", _random).Replace("{lastrandom}", _lastRandom).Replace("{10digits}",DateTime.Now.ToString("ddMMyyhhmm"));
            SendKeys.SendWait(stringToSend);
            if (!_newFileMode)
                if (lstPages.SelectedIndex == lstPages.Items.Count - 1) lstPages.SelectedIndex = 0;
                else
                    lstPages.SelectedIndex += 1;
            CaptureScreen();
            Show();
        }

        private void CaptureScreen()
        {
//Take screen shot
            if (dffTakeScreenshots.Checked)
            {
                using (Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width,
                    Screen.PrimaryScreen.WorkingArea.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(new Point(0, 0), Point.Empty, Screen.PrimaryScreen.WorkingArea.Size);
                    }
                    var capturesDirectory = $"{dfcCollections.SelectedItem}\\Captures";
                    if (!Directory.Exists(capturesDirectory)) Directory.CreateDirectory(capturesDirectory);
                    var allIntFiles = Directory.GetFiles(capturesDirectory).ToList();
                    var nextFileNumber = allIntFiles.Any()
                        ? Directory.GetFiles(capturesDirectory).ToList().ConvertAll(StringToInt).Max() + 1
                        : 1;
                    bitmap.Save($"{capturesDirectory}\\{nextFileNumber}.jpg", ImageFormat.Jpeg);
                }
            }
        }

        private void lstPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!File.Exists(dfcCollections.SelectedItem + "\\" + lstPages.SelectedItem + ".CloudSender")) return;
            _newFileMode = false;
            dfsSendString.Text = File.ReadAllText(dfcCollections.SelectedItem + "\\" +  lstPages.SelectedItem + ".CloudSender");
            dfsPageName.Text = lstPages.SelectedItem.ToString();
        }

        private void lstPages_DoubleClick(object sender, EventArgs e)
        {
            btnSend_Click(sender, e);
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            AddSpecialText("{TAB}");
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            AddSpecialText("{random}");
        }

        private void btnLastRandom_Click(object sender, EventArgs e)
        {
            AddSpecialText("{lastrandom}");
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            AddSpecialText("{ Down}");
        }

        private void dfsPageName_DoubleClick(object sender, EventArgs e)
        {
            var input = Interaction.InputBox("New Script Name", "Enter new script name", dfsPageName.Text, -1, -1);
            if (string.IsNullOrEmpty(input)) return;
            File.Copy(dfcCollections.SelectedItem + "\\" +  dfsPageName.Text + ".CloudSender", dfcCollections.SelectedItem + "\\"  + input + ".CloudSender");
            File.Delete(dfcCollections.SelectedItem + "\\" + dfsPageName.Text + ".CloudSender");
            lstPages.Items.Remove(dfsPageName.Text);
            dfsPageName.Text = input;
            lstPages.Items.Add(input);
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            if (TopMost)
                btnPin.BackgroundImage = imgList.Images[0];
            else
                btnPin.BackgroundImage = imgList.Images[1];
        }

        private void lblScriptName_DoubleClick(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath);
        }

        private void btnAddCollection_Click(object sender, EventArgs e)
        {
            var input = Interaction.InputBox("New Collection", "Enter new collection name", "", -1, -1);
            if (!string.IsNullOrEmpty(input) && !Directory.Exists(input))
            {
                Directory.CreateDirectory(input);
                dfcCollections.Items.Add(input);
                dfcCollections.SelectedItem = input;
            }
        }

        private void dfcCollections_SelectedIndexChanged(object sender, EventArgs e)
        {
            File.WriteAllText("LastUsedCollection", dfcCollections.SelectedItem.ToString());
            var files = Directory.GetFiles("./" + dfcCollections.SelectedItem, "*.CloudSender").OrderBy(x=> Regex.Match(x,@"^\d+")) .ToList();
            lstPages.Items.Clear();
            foreach (var file in files)
                lstPages.Items.Add(Path.GetFileNameWithoutExtension(file));
        }

        private void dfsPageName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn10Digits_Click(object sender, EventArgs e)
        {
            AddSpecialText("{10digits}");
        }

        private void AddSpecialText(string input)
        {
            dfsSendString.Text += input;
            dfsSendString.Focus();
            dfsSendString.SelectionStart = dfsSendString.Text.Length; // add some logic if length is 0
            dfsSendString.SelectionLength = 0;
        }

        private void lblScriptName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start($"{Application.StartupPath}\\{dfcCollections.SelectedItem}");
        }


    }
}