namespace CyunideArmaTool {
    partial class Form1 {
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
            this.lstActions = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddRun = new System.Windows.Forms.Button();
            this.btnAddCopies = new System.Windows.Forms.Button();
            this.btnAddDeletes = new System.Windows.Forms.Button();
            this.btnAddPboPack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPboManagerPath = new System.Windows.Forms.Button();
            this.txtPboManagerPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTextEditorPath = new System.Windows.Forms.Button();
            this.txtTextEditorPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnArmaServerPath = new System.Windows.Forms.Button();
            this.txtArmaServerPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstActions
            // 
            this.lstActions.FormattingEnabled = true;
            this.lstActions.Location = new System.Drawing.Point(12, 12);
            this.lstActions.Name = "lstActions";
            this.lstActions.Size = new System.Drawing.Size(899, 244);
            this.lstActions.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddRun);
            this.groupBox1.Controls.Add(this.btnAddCopies);
            this.groupBox1.Controls.Add(this.btnAddDeletes);
            this.groupBox1.Controls.Add(this.btnAddPboPack);
            this.groupBox1.Location = new System.Drawing.Point(520, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Command:";
            // 
            // btnAddRun
            // 
            this.btnAddRun.Location = new System.Drawing.Point(308, 25);
            this.btnAddRun.Name = "btnAddRun";
            this.btnAddRun.Size = new System.Drawing.Size(75, 23);
            this.btnAddRun.TabIndex = 3;
            this.btnAddRun.Text = "Run";
            this.btnAddRun.UseVisualStyleBackColor = true;
            // 
            // btnAddCopies
            // 
            this.btnAddCopies.Location = new System.Drawing.Point(209, 25);
            this.btnAddCopies.Name = "btnAddCopies";
            this.btnAddCopies.Size = new System.Drawing.Size(75, 23);
            this.btnAddCopies.TabIndex = 2;
            this.btnAddCopies.Text = "Copy";
            this.btnAddCopies.UseVisualStyleBackColor = true;
            // 
            // btnAddDeletes
            // 
            this.btnAddDeletes.Location = new System.Drawing.Point(110, 25);
            this.btnAddDeletes.Name = "btnAddDeletes";
            this.btnAddDeletes.Size = new System.Drawing.Size(75, 23);
            this.btnAddDeletes.TabIndex = 1;
            this.btnAddDeletes.Text = "Delete";
            this.btnAddDeletes.UseVisualStyleBackColor = true;
            this.btnAddDeletes.Click += new System.EventHandler(this.btnAddDeletes_Click);
            // 
            // btnAddPboPack
            // 
            this.btnAddPboPack.Location = new System.Drawing.Point(11, 25);
            this.btnAddPboPack.Name = "btnAddPboPack";
            this.btnAddPboPack.Size = new System.Drawing.Size(75, 23);
            this.btnAddPboPack.TabIndex = 0;
            this.btnAddPboPack.Text = "PBO Pack";
            this.btnAddPboPack.UseVisualStyleBackColor = true;
            this.btnAddPboPack.Click += new System.EventHandler(this.btnAddPboPack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPboManagerPath);
            this.groupBox2.Controls.Add(this.txtPboManagerPath);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnTextEditorPath);
            this.groupBox2.Controls.Add(this.txtTextEditorPath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnArmaServerPath);
            this.groupBox2.Controls.Add(this.txtArmaServerPath);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 132);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paths:";
            // 
            // btnPboManagerPath
            // 
            this.btnPboManagerPath.Location = new System.Drawing.Point(436, 96);
            this.btnPboManagerPath.Name = "btnPboManagerPath";
            this.btnPboManagerPath.Size = new System.Drawing.Size(34, 23);
            this.btnPboManagerPath.TabIndex = 8;
            this.btnPboManagerPath.Text = "...";
            this.btnPboManagerPath.UseVisualStyleBackColor = true;
            this.btnPboManagerPath.Click += new System.EventHandler(this.btnPboManagerPath_Click);
            // 
            // txtPboManagerPath
            // 
            this.txtPboManagerPath.Location = new System.Drawing.Point(80, 97);
            this.txtPboManagerPath.Name = "txtPboManagerPath";
            this.txtPboManagerPath.Size = new System.Drawing.Size(350, 20);
            this.txtPboManagerPath.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PBO Manager:";
            // 
            // btnTextEditorPath
            // 
            this.btnTextEditorPath.Location = new System.Drawing.Point(436, 57);
            this.btnTextEditorPath.Name = "btnTextEditorPath";
            this.btnTextEditorPath.Size = new System.Drawing.Size(34, 23);
            this.btnTextEditorPath.TabIndex = 5;
            this.btnTextEditorPath.Text = "...";
            this.btnTextEditorPath.UseVisualStyleBackColor = true;
            this.btnTextEditorPath.Click += new System.EventHandler(this.btnTextEditorPath_Click);
            // 
            // txtTextEditorPath
            // 
            this.txtTextEditorPath.Location = new System.Drawing.Point(80, 58);
            this.txtTextEditorPath.Name = "txtTextEditorPath";
            this.txtTextEditorPath.Size = new System.Drawing.Size(350, 20);
            this.txtTextEditorPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text Editor:";
            // 
            // btnArmaServerPath
            // 
            this.btnArmaServerPath.Location = new System.Drawing.Point(436, 20);
            this.btnArmaServerPath.Name = "btnArmaServerPath";
            this.btnArmaServerPath.Size = new System.Drawing.Size(34, 23);
            this.btnArmaServerPath.TabIndex = 2;
            this.btnArmaServerPath.Text = "...";
            this.btnArmaServerPath.UseVisualStyleBackColor = true;
            this.btnArmaServerPath.Click += new System.EventHandler(this.btnArmaServerPath_Click);
            // 
            // txtArmaServerPath
            // 
            this.txtArmaServerPath.Location = new System.Drawing.Point(80, 21);
            this.txtArmaServerPath.Name = "txtArmaServerPath";
            this.txtArmaServerPath.Size = new System.Drawing.Size(350, 20);
            this.txtArmaServerPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arma Server:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(12, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(899, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Command Line:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 18);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(878, 69);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "-mod=; -servermod=; -config= -port=2302 -profiles=SC -cfg= -name=SC -autoinit";
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(520, 328);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(391, 67);
            this.btnGO.TabIndex = 4;
            this.btnGO.Text = "GO!";
            this.btnGO.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLog);
            this.groupBox4.Location = new System.Drawing.Point(12, 516);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(899, 130);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log:";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(9, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(881, 105);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "> CyunideArmaTool Loaded.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 658);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstActions);
            this.Name = "Form1";
            this.Text = "CyunideArmaTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstActions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddPboPack;
        private System.Windows.Forms.Button btnAddRun;
        private System.Windows.Forms.Button btnAddCopies;
        private System.Windows.Forms.Button btnAddDeletes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPboManagerPath;
        private System.Windows.Forms.TextBox txtPboManagerPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTextEditorPath;
        private System.Windows.Forms.TextBox txtTextEditorPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnArmaServerPath;
        private System.Windows.Forms.TextBox txtArmaServerPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtLog;
    }
}

