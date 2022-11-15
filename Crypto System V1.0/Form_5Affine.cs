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
    public partial class Form_5Affine : Form
    {
        public static char[] CharsArr = new char[26];
        public Form_5Affine()
        {
            InitializeComponent();
            int count = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                CharsArr[count] = i;
                count++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Plaintext = txt_Plaintext.Text;
            int k1 = int.Parse(txt_Key1.Text);
            int k2 = int.Parse(txt_Key2.Text);
            string Ciphertext = "";
            for (int i = 0; i < Plaintext.Length; i++)
            {
                Ciphertext += CharsArr[(getCharIndex(Plaintext[i]) * k1 + k2) % 26];
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

        private void button2_Click(object sender, EventArgs e)
        {
            string cipher = txt_Ciphertext.Text;
            int a = int.Parse(txt_Key1.Text);
            int b = int.Parse(txt_Key2.Text);
            int k11 = inverse(a);
            string p = "";
            for (int i = 0; i < cipher.Length; i++)
            {
                int index = getCharIndex(cipher[i]) - b;
                while (index < 0)
                    index += 26;
                p += CharsArr[(index * k11) % 26];
            }
            txt_Recoveredtext.Text = p;
        }
        
        private int inverse(int k1)
        {

            for (int i = 1; i < 26; i++)
            {
                if ((k1 * i) % 26 == 1)
                    return i;
            }
            return -1;
        }
    }
}
