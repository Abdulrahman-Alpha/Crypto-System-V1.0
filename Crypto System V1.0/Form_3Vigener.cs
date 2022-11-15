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
    public partial class Form_3Vigener : Form
    {
        public static char[] CharsArr = new char[26];
        public Form_3Vigener()
        {
            InitializeComponent();
            int count = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                CharsArr[count] = i;
                count++;
            }
        }
        string Keyword = "";
        string Key = "";
        string Plaintext = "";
        string Ciphertext = "";
        string Recoveredtext = "";

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            Keyword = "";
            Key = "";
            Ciphertext = "";
            Keyword = txt_Keyword.Text.ToLower();
            Plaintext = txt_Plaintext.Text.ToLower();
            Plaintext = String.Concat(Plaintext.Where(c => !Char.IsWhiteSpace(c)));
            int j = 0;
            txt_KeyEn.Clear();
            txt_TextEn.Clear();

            for (int i = 0; i < Plaintext.Length; i++)
            {
                if (j < Keyword.Length)
                {
                    Key += Keyword[j];
                    j++;
                }
                else
                {
                    Key += Keyword[0];
                    j = 1;
                }
            }

            for (int i = 0; i < Plaintext.Length; i++)
            {
                txt_KeyEn.Text += Key[i] + " ";
                txt_TextEn.Text += Plaintext[i] + " ";
            }

            for (int i = 0; i < Plaintext.Length; i++)
            {
                Ciphertext += Convert.ToChar(Convert.ToInt32(((Plaintext[i] - 'a') + (Key[i] - 'a')) % 26 + 'a'));
            }
            txt_Ciphertext.Text = Ciphertext;
        }

        public static int getCharIndex(char c)
        {

            for (int i = 0; i < CharsArr.Length; i++)
            {
                if (CharsArr[i] == c)
                    return i;
            }
            return -1;
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            Ciphertext = txt_Ciphertext.Text.ToLower();
            Ciphertext = String.Concat(Ciphertext.Where(c => !Char.IsWhiteSpace(c)));
            string k = txt_Keyword.Text;
            Recoveredtext = "";
            for (int i = 0; i < Ciphertext.Length; i++)
            {
                int index = getCharIndex(Ciphertext[i]) - getCharIndex(k[i % k.Length]);
                while (index < 0)
                index += 26;
                Recoveredtext += CharsArr[index];
            }

            for (int i = 0; i < Plaintext.Length; i++)
            {
                txt_KeyDe.Text += Key[i] + " ";
                txt_TextDe.Text += Ciphertext[i] + " ";
            }

            txt_Recoveredtext.Text = Recoveredtext;
        }

    }
}