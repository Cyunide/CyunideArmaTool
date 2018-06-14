using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyunideArmaTool {
    public partial class frmPbo : Form {
        public frmPbo() {
            InitializeComponent();
        }
        private Form1 mainForm = null;
        public frmPbo(Form callingForm) {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (txtPboPath.Text == "" || txtFolderPath.Text == "") {
                MessageBox.Show("Path and Output cannot be blank!", "ERROR");
            } else {
                this.mainForm.addToList("PBOPACK " + txtFolderPath.Text + " to " + txtPboPath.Text);
                this.Close();
            }
        }

        private void btnPBOOutputPath_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PBO File|*.pbo";
            saveFileDialog1.Title = "Output pbo to...";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "") {
                txtPboPath.Text = saveFileDialog1.FileName;
            }
        }

        private void btnFolderToPack_Click(object sender, EventArgs e) {
            using (var fbd = new FolderBrowserDialog()) {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                    txtFolderPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void frmPbo_Load(object sender, EventArgs e) {

        }
    }
}
