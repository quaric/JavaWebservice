using System;
using System.Windows.Forms;

namespace Client
{
    partial class Form1
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
            this.userCheckBtn = new System.Windows.Forms.Button();
            this.userCheckName = new System.Windows.Forms.TextBox();
            this.userCheckPassword = new System.Windows.Forms.TextBox();
            this.UserCheckTitle = new System.Windows.Forms.Label();
            this.userCheckNameLabel = new System.Windows.Forms.Label();
            this.userCheckPasswordLabel = new System.Windows.Forms.Label();
            this.numericSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStringSize = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnStringSize = new System.Windows.Forms.Button();
            this.btnNumericSize = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.QRBILDE = new System.Windows.Forms.Label();
            this.qRPictureBox = new System.Windows.Forms.PictureBox();
            this.getQRBtn = new System.Windows.Forms.Button();
            this.checkQRsize = new System.Windows.Forms.Button();
            this.userNameQRBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendPerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userCheckBtn
            // 
            this.userCheckBtn.Location = new System.Drawing.Point(12, 152);
            this.userCheckBtn.Name = "userCheckBtn";
            this.userCheckBtn.Size = new System.Drawing.Size(154, 29);
            this.userCheckBtn.TabIndex = 0;
            this.userCheckBtn.Text = "Sjekk";
            this.userCheckBtn.UseVisualStyleBackColor = true;
            this.userCheckBtn.Click += new System.EventHandler(this.userCheckBtn_Click);
            // 
            // userCheckName
            // 
            this.userCheckName.Location = new System.Drawing.Point(12, 64);
            this.userCheckName.Name = "userCheckName";
            this.userCheckName.Size = new System.Drawing.Size(153, 27);
            this.userCheckName.TabIndex = 2;
            // 
            // userCheckPassword
            // 
            this.userCheckPassword.Location = new System.Drawing.Point(12, 118);
            this.userCheckPassword.Name = "userCheckPassword";
            this.userCheckPassword.PasswordChar = '*';
            this.userCheckPassword.Size = new System.Drawing.Size(153, 27);
            this.userCheckPassword.TabIndex = 3;
            // 
            // UserCheckTitle
            // 
            this.UserCheckTitle.AutoSize = true;
            this.UserCheckTitle.Location = new System.Drawing.Point(12, 9);
            this.UserCheckTitle.Name = "UserCheckTitle";
            this.UserCheckTitle.Size = new System.Drawing.Size(96, 20);
            this.UserCheckTitle.TabIndex = 4;
            this.UserCheckTitle.Text = "Brukersjekker";
            // 
            // userCheckNameLabel
            // 
            this.userCheckNameLabel.AutoSize = true;
            this.userCheckNameLabel.Location = new System.Drawing.Point(12, 41);
            this.userCheckNameLabel.Name = "userCheckNameLabel";
            this.userCheckNameLabel.Size = new System.Drawing.Size(82, 20);
            this.userCheckNameLabel.TabIndex = 5;
            this.userCheckNameLabel.Text = "Brukernavn";
            // 
            // userCheckPasswordLabel
            // 
            this.userCheckPasswordLabel.AutoSize = true;
            this.userCheckPasswordLabel.Location = new System.Drawing.Point(12, 98);
            this.userCheckPasswordLabel.Name = "userCheckPasswordLabel";
            this.userCheckPasswordLabel.Size = new System.Drawing.Size(59, 20);
            this.userCheckPasswordLabel.TabIndex = 6;
            this.userCheckPasswordLabel.Text = "Passord";
            // 
            // numericSize
            // 
            this.numericSize.Location = new System.Drawing.Point(237, 97);
            this.numericSize.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericSize.Name = "numericSize";
            this.numericSize.Size = new System.Drawing.Size(125, 27);
            this.numericSize.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ByteCounter";
            // 
            // textBoxStringSize
            // 
            this.textBoxStringSize.Location = new System.Drawing.Point(237, 64);
            this.textBoxStringSize.Name = "textBoxStringSize";
            this.textBoxStringSize.Size = new System.Drawing.Size(125, 27);
            this.textBoxStringSize.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnStringSize
            // 
            this.btnStringSize.Location = new System.Drawing.Point(400, 64);
            this.btnStringSize.Name = "btnStringSize";
            this.btnStringSize.Size = new System.Drawing.Size(94, 29);
            this.btnStringSize.TabIndex = 10;
            this.btnStringSize.Text = "Hent String";
            this.btnStringSize.UseVisualStyleBackColor = true;
            this.btnStringSize.Click += new System.EventHandler(this.btnStringSize_Click);
            // 
            // btnNumericSize
            // 
            this.btnNumericSize.Location = new System.Drawing.Point(400, 95);
            this.btnNumericSize.Name = "btnNumericSize";
            this.btnNumericSize.Size = new System.Drawing.Size(94, 29);
            this.btnNumericSize.TabIndex = 11;
            this.btnNumericSize.Text = "Hent Float";
            this.btnNumericSize.UseVisualStyleBackColor = true;
            this.btnNumericSize.Click += new System.EventHandler(this.btnNumericSize_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(237, 152);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(125, 29);
            this.btnOpenFile.TabIndex = 12;
            this.btnOpenFile.Text = "Velg fil";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // QRBILDE
            // 
            this.QRBILDE.AutoSize = true;
            this.QRBILDE.Location = new System.Drawing.Point(558, 9);
            this.QRBILDE.Name = "QRBILDE";
            this.QRBILDE.Size = new System.Drawing.Size(133, 20);
            this.QRBILDE.TabIndex = 14;
            this.QRBILDE.Text = "QR Fortune Cookie";
            // 
            // qRPictureBox
            // 
            this.qRPictureBox.Location = new System.Drawing.Point(558, 62);
            this.qRPictureBox.Name = "qRPictureBox";
            this.qRPictureBox.Size = new System.Drawing.Size(133, 119);
            this.qRPictureBox.TabIndex = 15;
            this.qRPictureBox.TabStop = false;
            // 
            // getQRBtn
            // 
            this.getQRBtn.Location = new System.Drawing.Point(710, 107);
            this.getQRBtn.Name = "getQRBtn";
            this.getQRBtn.Size = new System.Drawing.Size(125, 29);
            this.getQRBtn.TabIndex = 16;
            this.getQRBtn.Text = "Hent QR";
            this.getQRBtn.UseVisualStyleBackColor = true;
            this.getQRBtn.Click += new System.EventHandler(this.getQRBtn_Click);
            // 
            // checkQRsize
            // 
            this.checkQRsize.Location = new System.Drawing.Point(710, 152);
            this.checkQRsize.Name = "checkQRsize";
            this.checkQRsize.Size = new System.Drawing.Size(122, 29);
            this.checkQRsize.TabIndex = 17;
            this.checkQRsize.Text = "QR Size";
            this.checkQRsize.UseVisualStyleBackColor = true;
            this.checkQRsize.Click += new System.EventHandler(this.checkQRsize_Click);
            // 
            // userNameQRBox
            // 
            this.userNameQRBox.Location = new System.Drawing.Point(710, 62);
            this.userNameQRBox.Name = "userNameQRBox";
            this.userNameQRBox.Size = new System.Drawing.Size(125, 27);
            this.userNameQRBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Brukernavn";
            // 
            // btnSendPerson
            // 
            this.btnSendPerson.Location = new System.Drawing.Point(400, 141);
            this.btnSendPerson.Name = "btnSendPerson";
            this.btnSendPerson.Size = new System.Drawing.Size(94, 29);
            this.btnSendPerson.TabIndex = 20;
            this.btnSendPerson.Text = "Person";
            this.btnSendPerson.UseVisualStyleBackColor = true;
            this.btnSendPerson.Click += new System.EventHandler(this.btnSendPerson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 221);
            this.Controls.Add(this.btnSendPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameQRBox);
            this.Controls.Add(this.checkQRsize);
            this.Controls.Add(this.getQRBtn);
            this.Controls.Add(this.qRPictureBox);
            this.Controls.Add(this.QRBILDE);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnNumericSize);
            this.Controls.Add(this.btnStringSize);
            this.Controls.Add(this.textBoxStringSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericSize);
            this.Controls.Add(this.userCheckPasswordLabel);
            this.Controls.Add(this.userCheckNameLabel);
            this.Controls.Add(this.UserCheckTitle);
            this.Controls.Add(this.userCheckPassword);
            this.Controls.Add(this.userCheckName);
            this.Controls.Add(this.userCheckBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userCheckBtn;
        private System.Windows.Forms.TextBox userCheckName;
        private System.Windows.Forms.TextBox userCheckPassword;
        private System.Windows.Forms.Label UserCheckTitle;
        private System.Windows.Forms.Label userCheckNameLabel;
        private System.Windows.Forms.Label userCheckPasswordLabel;
        private NumericUpDown numericSize;
        private Label label1;
        private TextBox textBoxStringSize;
        private OpenFileDialog openFileDialog1;
        private Button btnStringSize;
        private Button btnNumericSize;
        private Button btnOpenFile;
        private Label QRBILDE;
        private PictureBox qRPictureBox;
        private Button getQRBtn;
        private Button checkQRsize;
        private TextBox userNameQRBox;
        private Label label2;
        private Button btnSendPerson;
    }
}

