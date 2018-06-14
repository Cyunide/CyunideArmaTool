using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CyunideArmaTool {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public void addToList(string str) {
            lstActions.Items.Add(str);
        }

        public void Log(string str) {
            txtLog.Text = txtLog.Text + "\r\n> " + str;
            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.ScrollToCaret();
        }

        private void doStuff() {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("echo Oscar");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        private void btnAddPboPack_Click(object sender, EventArgs e) {
            frmPbo fp = new frmPbo(this);
            fp.Show();
        }

        private void btnArmaServerPath_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Exe Files|*.exe";
            openFileDialog1.Title = "Select Arma Server File...";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                txtArmaServerPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnTextEditorPath_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Exe Files|*.exe";
            openFileDialog1.Title = "Select Text Editor File...";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                txtTextEditorPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnPboManagerPath_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Exe Files|*.exe";
            openFileDialog1.Title = "Select Pbo Manager File...";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                txtArmaServerPath.Text = openFileDialog1.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnAddDeletes_Click(object sender, EventArgs e) {
            frmDelete fd = new frmDelete(this);
            fd.Show();
        }
    }
}
