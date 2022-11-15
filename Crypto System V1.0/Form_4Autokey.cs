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
    public partial class Form_4Autokey : Form
    {
        public Form_4Autokey()
        {
            InitializeComponent();
        }
        string Plaintext = "";
        string Ciphertext = "";
        string Recoveredtext = "";
        string Keystream = "";
        int Key = 0;
        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            Plaintext = txt_Plaintext.Text.ToLower();
            Plaintext = String.Concat(Plaintext.Where(c => !Char.IsWhiteSpace(c)));
            Key = Convert.ToInt32(txt_Key.Text);
            Keystream = "";
            Keystream += Convert.ToChar(Convert.ToInt32(Key + 'a'));

            for (int i = 0; i < Plaintext.Length - 1; i++)
            {
                Keystream += Convert.ToChar(Convert.ToInt32(Plaintext[i] - 'a' + 26) % 26 + 'a');
            }

            for (int i = 0; i < Plaintext.Length; i++)
            {
                Ciphertext += Convert.ToChar(Convert.ToInt32(Plaintext[i] - 'a' + Keystream[i] - 'a' + 26) % 26 + 'a');
            }

            txt_Ciphertext.Text = Ciphertext;
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            Key = Convert.ToInt32(txt_Key.Text);
            Keystream += Convert.ToChar(Convert.ToInt32(Key + 'a'));
            Ciphertext = txt_Ciphertext.Text.ToLower();
            Ciphertext = String.Concat(Ciphertext.Where(c => !Char.IsWhiteSpace(c)));

            Recoveredtext += Convert.ToChar(Convert.ToInt32((Ciphertext[0] - 'a') - (Keystream[0] - 'a') + 26) % 26 + 'a');

            for (int i = 1; i < Ciphertext.Length; i++)
            {
                Recoveredtext += Convert.ToChar(Convert.ToInt32((Ciphertext[i] - 'a') - (Recoveredtext[i-1] - 'a') + 26) % 26 + 'a');
            }

            txt_Recoveredtext.Text = Recoveredtext;
        }
    }
}