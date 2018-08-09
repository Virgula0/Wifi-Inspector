using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Wifi_Inspector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }

        public static List<string> list = new List<string>();

        private void Process_Click(object sender, EventArgs e)
        {
            Result.CheckBoxes = true;
            checkall.Checked = false;
            Find.Enabled = false;
            Save.Enabled = false;
            Result.Items.Clear();
            list.Clear();
            Result.Columns[0].Text = "Number";
            Result.Columns[1].Text = "SSID";
            try
            {
                string command = "netsh wlan show profiles";

                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                int j = 0;
                string result = proc.StandardOutput.ReadToEnd();
                string[] lines = result.Split(new[] { "\n" }, StringSplitOptions.None);

                string[] yes = new string[lines.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    yes[i] = getBetween(lines[i], "    : ", "\r");
                    if (yes[i] != "")
                    {
                        j++; ;
                        string[] row = { Convert.ToString(j), yes[i] };
                        var listViewItem = new ListViewItem(row);
                        Result.Items.Add(listViewItem);
                    }
                }


            }
            catch (Exception objException)
            {
                MessageBox.Show(Convert.ToString(objException), "Error");
            }

            Find.Enabled = true;
            checkall.Enabled = true;
        }

        private void Find_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This could take a while please wait after you clicked ok", "Starting");
            int d = 0;
            string[] commands = new string[Result.Items.Count];
            string[] items = new string[Result.Items.Count];
            for (int i = 0; i < Result.Items.Count; i++)
            {
                if (Result.Items[i].Checked == true)
                {
                    commands[d] = "netsh wlan show profiles " + "\"" + Result.Items[i].SubItems[1].Text + "\"" + " key=clear";
                    items[d] = Result.Items[i].SubItems[1].Text;
                    d++;
                }
            }

            if (d == 0)
                MessageBox.Show("You Have To Select At Least One SSID", "Error");
            else
            {

                Result.Items.Clear();
                Result.Columns[0].Text = "SSID";
                Result.Columns[1].Text = "Password";
                Result.CheckBoxes = false;
                for (int i = 0; i < d; i++)
                {
                    try
                    {
                        System.Diagnostics.ProcessStartInfo procStartInfo =
                        new System.Diagnostics.ProcessStartInfo("cmd", "/c " + commands[i]);
                        procStartInfo.RedirectStandardOutput = true;
                        procStartInfo.UseShellExecute = false;
                        procStartInfo.CreateNoWindow = true;
                        System.Diagnostics.Process proc = new System.Diagnostics.Process();
                        proc.StartInfo = procStartInfo;
                        proc.Start();
                        string result = proc.StandardOutput.ReadToEnd();

                        string[] lines = result.Split(new[] { "\n" }, StringSplitOptions.None);

                        string yes;
                        yes = getBetween(lines[33], ": ", "\r");
                        if (lines[33] != "")
                        {
                            string[] row = { items[i], yes };
                            var listViewItem = new ListViewItem(row);
                            Result.Items.Add(listViewItem);
                            list.Add("SSID: " + items[i] + " Password: " + yes);
                        }
                    }
                    catch (Exception objException)
                    {
                        MessageBox.Show(Convert.ToString(objException), "Error");
                    }
                }
                MessageBox.Show($"Done! {d} saved networks analyzed");
                Save.Enabled = true;
                Find.Enabled = false;
                checkall.Checked = false;
                checkall.Enabled = false;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Stream myStream;
            string[] works;
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "Text File (*.txt)|*.txt";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = ofd.OpenFile()) != null)
                {
                    works = list.ToArray();
                    using (StreamWriter sw = new StreamWriter(myStream, Encoding.UTF8))
                    {
                        for (int i = 0; i < works.Length; i++)
                        {
                            sw.WriteLine(works[i]);
                        }
                        sw.Close();
                    }
                    MessageBox.Show("Output Exported", "Well Done");
                    myStream.Close();
                }
            }
        }

        private void checkall_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkall.Checked == true)
            {
                for (int i = 0; i < Result.Items.Count; i++)
                {
                    Result.Items[i].Checked = true;
                }
            }
            else
            {
                for (int i = 0; i < Result.Items.Count; i++)
                {
                    Result.Items[i].Checked = false;
                }
            }
        }
    }
}
