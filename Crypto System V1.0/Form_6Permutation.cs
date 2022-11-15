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
    public partial class Form_6Permutation : Form
    {
        public Form_6Permutation()
        {
            InitializeComponent();
        }

        int[] Numarr = new int[6] { 1, 2, 3, 4, 5, 6 };
        int[] ShuffledNums = new int[6];
        Random r = new Random();
        public string[] SubStrings;
        string PlainText;
        string CipherText;
        string RecoveredText;


        private void Perm_btn_Click(object sender, EventArgs e)
        {
            int Num = 0;

            for (int n = 6; n > 0; n--)
            {
                int k = r.Next(n);
                int temp = Numarr[k];
                ShuffledNums[Num] = temp;
                Num++;
                Numarr = Numarr.Where((source, index) => index != k).ToArray();
            }

            Numarr = new int[6] { 1, 2, 3, 4, 5, 6 };


            txt_1Enc.Text = ($"{ShuffledNums[0]}").ToString();
            txt_2Enc.Text = ($"{ShuffledNums[1]}").ToString();
            txt_3Enc.Text = ($"{ShuffledNums[2]}").ToString();
            txt_4Enc.Text = ($"{ShuffledNums[3]}").ToString();
            txt_5Enc.Text = ($"{ShuffledNums[4]}").ToString();
            txt_6Enc.Text = ($"{ShuffledNums[5]}").ToString();


            txt_1Dec.Text = ((Array.IndexOf(ShuffledNums, Numarr[0])) + 1).ToString();
            txt_2Dec.Text = ((Array.IndexOf(ShuffledNums, Numarr[1])) + 1).ToString();
            txt_3Dec.Text = ((Array.IndexOf(ShuffledNums, Numarr[2])) + 1).ToString();
            txt_4Dec.Text = ((Array.IndexOf(ShuffledNums, Numarr[3])) + 1).ToString();
            txt_5Dec.Text = ((Array.IndexOf(ShuffledNums, Numarr[4])) + 1).ToString();
            txt_6Dec.Text = ((Array.IndexOf(ShuffledNums, Numarr[5])) + 1).ToString();

            //Sixletters(txt_Plaintext.Text);
            //txt_Ciphertext.Text = SubStrings[0];
            //txt_Recoveredtext.Text = SubStrings[1];
        }


        public void Sixletters(string Text)
        {

            decimal Strings = Text.Length / 6;
            int StringsNum = Convert.ToInt32(Math.Round(Strings, 0));
            SubStrings = new string[StringsNum + 1];
            int j = 0;
            int m = 0;
            int l = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                if (l < 6)
                {
                    SubStrings[m] += Text[i];
                    l++;
                }
                else
                {
                    SubStrings[m + 1] += Text[i];
                    m++;
                    l = 0;
                }
            }
        }


        private void btn_Encrypt_Click_1(object sender, EventArgs e)
        {
            #region key from user
            ShuffledNums[0] = int.Parse(txt_1Enc.Text);
            ShuffledNums[1] = int.Parse(txt_2Enc.Text);
            ShuffledNums[2] = int.Parse(txt_3Enc.Text);
            ShuffledNums[3] = int.Parse(txt_4Enc.Text);
            ShuffledNums[4] = int.Parse(txt_5Enc.Text);
            ShuffledNums[5] = int.Parse(txt_6Enc.Text);
            #endregion


            PlainText = txt_Plaintext.Text;
            CipherText = "";
            Sixletters(PlainText);
            int j = 0;
            int m = 0;
            int k = 0;
            for (int i = 0; i < PlainText.Length; i++)
            {
                if (j < SubStrings[m].Length && k < 6)
                {
                    CipherText += SubStrings[m][ShuffledNums[k] - 1];
                    j++;
                    k++;
                }
                else
                {
                    k = 0;
                    CipherText += SubStrings[m + 1][ShuffledNums[k] - 1];
                    m++;
                    k++;
                    j = 0;
                }
            }

            txt_Ciphertext.Text = CipherText;
        }



        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            #region key from user
            ShuffledNums[0] = int.Parse(txt_1Enc.Text);
            ShuffledNums[1] = int.Parse(txt_2Enc.Text);
            ShuffledNums[2] = int.Parse(txt_3Enc.Text);
            ShuffledNums[3] = int.Parse(txt_4Enc.Text);
            ShuffledNums[4] = int.Parse(txt_5Enc.Text);
            ShuffledNums[5] = int.Parse(txt_6Enc.Text);
            #endregion

            CipherText = txt_Ciphertext.Text;
            RecoveredText = "";
            Sixletters(CipherText);
            int j = 0;
            int m = 0;
            int k = 0;
            for (int i = 0; i < CipherText.Length; i++)
            {
                if (j < SubStrings[m].Length && k < 6)
                {
                    RecoveredText += SubStrings[m][((Array.IndexOf(ShuffledNums, Numarr[k])) + 1) - 1];
                    j++;
                    k++;
                }
                else
                {
                    k = 0;
                    RecoveredText += SubStrings[m + 1][((Array.IndexOf(ShuffledNums, Numarr[k])) + 1) - 1];
                    m++;
                    k++;
                    j = 0;
                }
            }

            txt_Recoveredtext.Text = RecoveredText;
        }

    }
}