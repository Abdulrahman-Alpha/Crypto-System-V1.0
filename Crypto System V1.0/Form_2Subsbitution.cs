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
    public partial class Form_2Subsbitution : Form
    {
        public Form_2Subsbitution()
        {
            InitializeComponent();
        }
        string Plaintext = "";
        string Ciphertext = "";
        string Recoveredtext = "";



        Random r = new Random();
        string unshuffledLetters = "";
        string shuffledLetters = "";

        
        public void Random_Permutation()
        {
            unshuffledLetters = "abcdefghijklmnopqrstuvwxyz";
            shuffledLetters = "";
            for (int n = unshuffledLetters.Length; n > 0; n--)
            {
                int k = r.Next(n);

                char temp = unshuffledLetters[k];
                shuffledLetters = shuffledLetters + temp;

                unshuffledLetters = unshuffledLetters.Remove(k, 1);

            }

            #region allocate char in txt
            txt_A.Text = shuffledLetters[0].ToString();
            txt_B.Text = shuffledLetters[1].ToString();
            txt_C.Text = shuffledLetters[2].ToString();
            txt_D.Text = shuffledLetters[3].ToString();
            txt_E.Text = shuffledLetters[4].ToString();
            txt_F.Text = shuffledLetters[5].ToString();
            txt_G.Text = shuffledLetters[6].ToString();
            txt_H.Text = shuffledLetters[7].ToString();
            txt_I.Text = shuffledLetters[8].ToString();
            txt_J.Text = shuffledLetters[9].ToString();
            txt_K.Text = shuffledLetters[10].ToString();
            txt_L.Text = shuffledLetters[11].ToString();
            txt_M.Text = shuffledLetters[12].ToString();
            txt_N.Text = shuffledLetters[13].ToString();
            txt_O.Text = shuffledLetters[14].ToString();
            txt_P.Text = shuffledLetters[15].ToString();
            txt_Q.Text = shuffledLetters[16].ToString();
            txt_R.Text = shuffledLetters[17].ToString();
            txt_S.Text = shuffledLetters[18].ToString();
            txt_T.Text = shuffledLetters[19].ToString();
            txt_U.Text = shuffledLetters[20].ToString();
            txt_V.Text = shuffledLetters[21].ToString();
            txt_W.Text = shuffledLetters[22].ToString();
            txt_X.Text = shuffledLetters[23].ToString();
            txt_Y.Text = shuffledLetters[24].ToString();
            txt_Z.Text = shuffledLetters[25].ToString();
#endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random_Permutation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region take key from UI
            shuffledLetters = "";
            shuffledLetters += txt_A.Text;
            shuffledLetters += txt_B.Text;
            shuffledLetters += txt_C.Text;
            shuffledLetters += txt_D.Text;
            shuffledLetters += txt_E.Text;
            shuffledLetters += txt_F.Text;
            shuffledLetters += txt_G.Text;
            shuffledLetters += txt_H.Text;
            shuffledLetters += txt_I.Text;
            shuffledLetters += txt_J.Text;
            shuffledLetters += txt_K.Text;
            shuffledLetters += txt_L.Text;
            shuffledLetters += txt_M.Text;
            shuffledLetters += txt_N.Text;
            shuffledLetters += txt_O.Text;
            shuffledLetters += txt_P.Text;
            shuffledLetters += txt_Q.Text;
            shuffledLetters += txt_R.Text;
            shuffledLetters += txt_S.Text;
            shuffledLetters += txt_T.Text;
            shuffledLetters += txt_U.Text;
            shuffledLetters += txt_V.Text;
            shuffledLetters += txt_W.Text;
            shuffledLetters += txt_X.Text;
            shuffledLetters += txt_Y.Text;
            shuffledLetters += txt_Z.Text;

            #endregion
            Plaintext = txt_Plaintext.Text.ToLower();
            Plaintext = String.Concat(Plaintext.Where(c => !Char.IsWhiteSpace(c)));
            Ciphertext = "";

            for (int i = 0; i < Plaintext.Length; i++)
            {
                Ciphertext += shuffledLetters[(Plaintext[i] - 'a')];

            }

            txt_Ciphertext.Text = Ciphertext;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region take key from UI
            shuffledLetters = "";
            shuffledLetters += txt_A.Text;
            shuffledLetters += txt_B.Text;
            shuffledLetters += txt_C.Text;
            shuffledLetters += txt_D.Text;
            shuffledLetters += txt_E.Text;
            shuffledLetters += txt_F.Text;
            shuffledLetters += txt_G.Text;
            shuffledLetters += txt_H.Text;
            shuffledLetters += txt_I.Text;
            shuffledLetters += txt_J.Text;
            shuffledLetters += txt_K.Text;
            shuffledLetters += txt_L.Text;
            shuffledLetters += txt_M.Text;
            shuffledLetters += txt_N.Text;
            shuffledLetters += txt_O.Text;
            shuffledLetters += txt_P.Text;
            shuffledLetters += txt_Q.Text;
            shuffledLetters += txt_R.Text;
            shuffledLetters += txt_S.Text;
            shuffledLetters += txt_T.Text;
            shuffledLetters += txt_U.Text;
            shuffledLetters += txt_V.Text;
            shuffledLetters += txt_W.Text;
            shuffledLetters += txt_X.Text;
            shuffledLetters += txt_Y.Text;
            shuffledLetters += txt_Z.Text;

            #endregion
            unshuffledLetters = "abcdefghijklmnopqrstuvwxyz";
            Ciphertext = txt_Ciphertext.Text.ToLower();
            Ciphertext = String.Concat(Ciphertext.Where(c => !Char.IsWhiteSpace(c)));
            Recoveredtext = "";

            for (int i = 0; i < Ciphertext.Length; i++)
            {
                Recoveredtext += unshuffledLetters[shuffledLetters.IndexOf(Ciphertext[i])];
            }

            txt_Recoveredtext.Text = Recoveredtext;

        }
    }
}