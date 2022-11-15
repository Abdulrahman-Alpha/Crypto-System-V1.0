namespace Crypto_System_V1._0
{
    partial class Form_4Autokey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Recoveredtext = new System.Windows.Forms.TextBox();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.txt_Ciphertext = new System.Windows.Forms.TextBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.lbl_Recoveredtext = new System.Windows.Forms.Label();
            this.lbl_Ciphertext = new System.Windows.Forms.Label();
            this.lbl_Plaintext = new System.Windows.Forms.Label();
            this.txt_Plaintext = new System.Windows.Forms.TextBox();
            this.lbl_Key = new System.Windows.Forms.Label();
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 161);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(318, 16);
            this.label17.TabIndex = 107;
            this.label17.Text = "Warning: This text will be lower cases without spaces";
            // 
            // txt_Recoveredtext
            // 
            this.txt_Recoveredtext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Recoveredtext.Location = new System.Drawing.Point(21, 580);
            this.txt_Recoveredtext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Recoveredtext.Multiline = true;
            this.txt_Recoveredtext.Name = "txt_Recoveredtext";
            this.txt_Recoveredtext.Size = new System.Drawing.Size(604, 122);
            this.txt_Recoveredtext.TabIndex = 106;
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Decrypt.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Decrypt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Decrypt.Location = new System.Drawing.Point(489, 437);
            this.btn_Decrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(137, 34);
            this.btn_Decrypt.TabIndex = 105;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = false;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // txt_Ciphertext
            // 
            this.txt_Ciphertext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ciphertext.Location = new System.Drawing.Point(21, 306);
            this.txt_Ciphertext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Ciphertext.Multiline = true;
            this.txt_Ciphertext.Name = "txt_Ciphertext";
            this.txt_Ciphertext.Size = new System.Drawing.Size(604, 122);
            this.txt_Ciphertext.TabIndex = 104;
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Encrypt.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encrypt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Encrypt.Location = new System.Drawing.Point(489, 169);
            this.btn_Encrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(137, 34);
            this.btn_Encrypt.TabIndex = 103;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = false;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // lbl_Recoveredtext
            // 
            this.lbl_Recoveredtext.AutoSize = true;
            this.lbl_Recoveredtext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Recoveredtext.Location = new System.Drawing.Point(16, 553);
            this.lbl_Recoveredtext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Recoveredtext.Name = "lbl_Recoveredtext";
            this.lbl_Recoveredtext.Size = new System.Drawing.Size(132, 24);
            this.lbl_Recoveredtext.TabIndex = 102;
            this.lbl_Recoveredtext.Text = "Recoverd Text:";
            // 
            // lbl_Ciphertext
            // 
            this.lbl_Ciphertext.AutoSize = true;
            this.lbl_Ciphertext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ciphertext.Location = new System.Drawing.Point(16, 279);
            this.lbl_Ciphertext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ciphertext.Name = "lbl_Ciphertext";
            this.lbl_Ciphertext.Size = new System.Drawing.Size(110, 24);
            this.lbl_Ciphertext.TabIndex = 101;
            this.lbl_Ciphertext.Text = "Cipher Text:";
            // 
            // lbl_Plaintext
            // 
            this.lbl_Plaintext.AutoSize = true;
            this.lbl_Plaintext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Plaintext.Location = new System.Drawing.Point(16, 11);
            this.lbl_Plaintext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Plaintext.Name = "lbl_Plaintext";
            this.lbl_Plaintext.Size = new System.Drawing.Size(97, 24);
            this.lbl_Plaintext.TabIndex = 100;
            this.lbl_Plaintext.Text = "Plain Text:";
            // 
            // txt_Plaintext
            // 
            this.txt_Plaintext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Plaintext.Location = new System.Drawing.Point(21, 38);
            this.txt_Plaintext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Plaintext.Multiline = true;
            this.txt_Plaintext.Name = "txt_Plaintext";
            this.txt_Plaintext.Size = new System.Drawing.Size(604, 122);
            this.txt_Plaintext.TabIndex = 99;
            // 
            // lbl_Key
            // 
            this.lbl_Key.AutoSize = true;
            this.lbl_Key.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Key.Location = new System.Drawing.Point(684, 38);
            this.lbl_Key.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Key.Name = "lbl_Key";
            this.lbl_Key.Size = new System.Drawing.Size(46, 24);
            this.lbl_Key.TabIndex = 113;
            this.lbl_Key.Text = "Key:";
            // 
            // txt_Key
            // 
            this.txt_Key.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Key.Location = new System.Drawing.Point(688, 66);
            this.txt_Key.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(103, 31);
            this.txt_Key.TabIndex = 112;
            // 
            // Form_4Autokey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1261, 710);
            this.Controls.Add(this.lbl_Key);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_Recoveredtext);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.txt_Ciphertext);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.lbl_Recoveredtext);
            this.Controls.Add(this.lbl_Ciphertext);
            this.Controls.Add(this.lbl_Plaintext);
            this.Controls.Add(this.txt_Plaintext);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_4Autokey";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_Recoveredtext;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.TextBox txt_Ciphertext;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Label lbl_Recoveredtext;
        private System.Windows.Forms.Label lbl_Ciphertext;
        private System.Windows.Forms.Label lbl_Plaintext;
        private System.Windows.Forms.TextBox txt_Plaintext;
        private System.Windows.Forms.Label lbl_Key;
        private System.Windows.Forms.TextBox txt_Key;
    }
}