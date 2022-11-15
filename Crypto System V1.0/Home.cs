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
    public partial class Form_CryptoMistaHome : Form
    {
        public Form_CryptoMistaHome()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_ChildForm.Controls.Add(childForm);
            panel_ChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form0());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_1Shift());
            this.btn_Shift.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_2Subsbitution());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_3Vigener());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_4Autokey());
        }

        private void btn_Affine_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_5Affine());
        }

        private void btn_Permutation_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_6Permutation());
        }
    }
}