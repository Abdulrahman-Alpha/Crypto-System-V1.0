using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_System_V1._0
{
    public partial class Form_1Shift : Form
    {
        public Form_1Shift()
        {
            InitializeComponent();
        }
        string Plaintext = "";
        string Ciphertext= "";
        string Recoverdtext= "";
        int key = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            Ciphertext = "";
            txt_Ciphertext.Clear();

            string Plaintext = txt_Plaintext.Text.ToLower();
            Plaintext = String.Concat(Plaintext.Where(c => !Char.IsWhiteSpace(c)));
            key = Convert.ToInt32(txt_Key.Text);

            for (int i = 0; i < Plaintext.Length; i++)
            {
                Ciphertext += Convert.ToChar(Convert.ToInt32(Plaintext[i] - 'a' + key + 26) % 26 + 'a');
            }

            txt_Ciphertext.Text = Ciphertext;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Recoverdtext = "";
            txt_Recoveredtext.Clear();
            Ciphertext = this.txt_Ciphertext.Text.ToLower();
            Ciphertext = String.Concat(Ciphertext.Where(c => !Char.IsWhiteSpace(c)));
            key = Convert.ToInt32(txt_Key.Text);
            
            for (int i = 0; i < Ciphertext.Length; i++)
            {
                Recoverdtext += Convert.ToChar(Convert.ToInt32(Ciphertext[i] - 'a' - key + 26) % 26 + 'a');
            }

            txt_Recoveredtext.Text = Recoverdtext;
        }
    }
}
