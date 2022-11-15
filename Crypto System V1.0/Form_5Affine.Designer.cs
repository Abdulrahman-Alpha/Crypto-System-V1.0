namespace Crypto_System_V1._0
{
    partial class Form_5Affine
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
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Ciphertext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Plaintext = new System.Windows.Forms.TextBox();
            this.lbl_Key = new System.Windows.Forms.Label();
            this.txt_Key1 = new System.Windows.Forms.TextBox();
            this.txt_Key2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Recoveredtext = new System.Windows.Forms.TextBox();
            this.lbl_Recoveredtext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 159);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(318, 16);
            this.label17.TabIndex = 96;
            this.label17.Text = "Warning: This text will be lower cases without spaces";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(486, 435);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 34);
            this.button2.TabIndex = 95;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Ciphertext
            // 
            this.txt_Ciphertext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ciphertext.Location = new System.Drawing.Point(18, 304);
            this.txt_Ciphertext.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ciphertext.Multiline = true;
            this.txt_Ciphertext.Name = "txt_Ciphertext";
            this.txt_Ciphertext.Size = new System.Drawing.Size(604, 122);
            this.txt_Ciphertext.TabIndex = 94;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(486, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 34);
            this.button1.TabIndex = 93;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 92;
            this.label2.Text = "Cipher Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 91;
            this.label1.Text = "Plain Text:";
            // 
            // txt_Plaintext
            // 
            this.txt_Plaintext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Plaintext.Location = new System.Drawing.Point(18, 36);
            this.txt_Plaintext.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Plaintext.Multiline = true;
            this.txt_Plaintext.Name = "txt_Plaintext";
            this.txt_Plaintext.Size = new System.Drawing.Size(604, 122);
            this.txt_Plaintext.TabIndex = 90;
            // 
            // lbl_Key
            // 
            this.lbl_Key.AutoSize = true;
            this.lbl_Key.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Key.Location = new System.Drawing.Point(684, 38);
            this.lbl_Key.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Key.Name = "lbl_Key";
            this.lbl_Key.Size = new System.Drawing.Size(46, 24);
            this.lbl_Key.TabIndex = 103;
            this.lbl_Key.Text = "Key:";
            // 
            // txt_Key1
            // 
            this.txt_Key1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Key1.Location = new System.Drawing.Point(734, 67);
            this.txt_Key1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Key1.Name = "txt_Key1";
            this.txt_Key1.Size = new System.Drawing.Size(42, 31);
            this.txt_Key1.TabIndex = 102;
            // 
            // txt_Key2
            // 
            this.txt_Key2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Key2.Location = new System.Drawing.Point(802, 67);
            this.txt_Key2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Key2.Name = "txt_Key2";
            this.txt_Key2.Size = new System.Drawing.Size(42, 31);
            this.txt_Key2.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(707, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 35);
            this.label3.TabIndex = 105;
            this.label3.Text = "(";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(847, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 35);
            this.label4.TabIndex = 106;
            this.label4.Text = ")";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(776, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 35);
            this.label5.TabIndex = 107;
            this.label5.Text = ",";
            // 
            // txt_Recoveredtext
            // 
            this.txt_Recoveredtext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Recoveredtext.Location = new System.Drawing.Point(20, 581);
            this.txt_Recoveredtext.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Recoveredtext.Multiline = true;
            this.txt_Recoveredtext.Name = "txt_Recoveredtext";
            this.txt_Recoveredtext.Size = new System.Drawing.Size(604, 122);
            this.txt_Recoveredtext.TabIndex = 109;
            // 
            // lbl_Recoveredtext
            // 
            this.lbl_Recoveredtext.AutoSize = true;
            this.lbl_Recoveredtext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Recoveredtext.Location = new System.Drawing.Point(16, 553);
            this.lbl_Recoveredtext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Recoveredtext.Name = "lbl_Recoveredtext";
            this.lbl_Recoveredtext.Size = new System.Drawing.Size(132, 24);
            this.lbl_Recoveredtext.TabIndex = 108;
            this.lbl_Recoveredtext.Text = "Recoverd Text:";
            // 
            // Form_5Affine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1261, 710);
            this.Controls.Add(this.txt_Recoveredtext);
            this.Controls.Add(this.lbl_Recoveredtext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Key2);
            this.Controls.Add(this.lbl_Key);
            this.Controls.Add(this.txt_Key1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_Ciphertext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Plaintext);
            this.Name = "Form_5Affine";
            this.Text = "Form_5Affine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_Ciphertext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Plaintext;
        private System.Windows.Forms.Label lbl_Key;
        private System.Windows.Forms.TextBox txt_Key1;
        private System.Windows.Forms.TextBox txt_Key2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Recoveredtext;
        private System.Windows.Forms.Label lbl_Recoveredtext;
    }
}