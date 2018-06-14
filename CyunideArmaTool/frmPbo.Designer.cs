namespace CyunideArmaTool {
    partial class frmPbo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnFolderToPack = new System.Windows.Forms.Button();
            this.btnPBOOutputPath = new System.Windows.Forms.Button();
            this.txtPboPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add PBO Pack Command";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder to Pack:";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(97, 18);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(377, 20);
            this.txtFolderPath.TabIndex = 2;
            // 
            // btnFolderToPack
            // 
            this.btnFolderToPack.Location = new System.Drawing.Point(480, 16);
            this.btnFolderToPack.Name = "btnFolderToPack";
            this.btnFolderToPack.Size = new System.Drawing.Size(35, 23);
            this.btnFolderToPack.TabIndex = 3;
            this.btnFolderToPack.Text = "...";
            this.btnFolderToPack.UseVisualStyleBackColor = true;
            this.btnFolderToPack.Click += new System.EventHandler(this.btnFolderToPack_Click);
            // 
            // btnPBOOutputPath
            // 
            this.btnPBOOutputPath.Location = new System.Drawing.Point(480, 65);
            this.btnPBOOutputPath.Name = "btnPBOOutputPath";
            this.btnPBOOutputPath.Size = new System.Drawing.Size(35, 23);
            this.btnPBOOutputPath.TabIndex = 6;
            this.btnPBOOutputPath.Text = "...";
            this.btnPBOOutputPath.UseVisualStyleBackColor = true;
            this.btnPBOOutputPath.Click += new System.EventHandler(this.btnPBOOutputPath_Click);
            // 
            // txtPboPath
            // 
            this.txtPboPath.Location = new System.Drawing.Point(97, 66);
            this.txtPboPath.Name = "txtPboPath";
            this.txtPboPath.Size = new System.Drawing.Size(377, 20);
            this.txtPboPath.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output PBO to:";
            // 
            // frmPbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 146);
            this.Controls.Add(this.btnPBOOutputPath);
            this.Controls.Add(this.txtPboPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFolderToPack);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPbo";
            this.Text = "Add PBO Pack Command";
            this.Load += new System.EventHandler(this.frmPbo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnFolderToPack;
        private System.Windows.Forms.Button btnPBOOutputPath;
        private System.Windows.Forms.TextBox txtPboPath;
        private System.Windows.Forms.Label label2;
    }
}