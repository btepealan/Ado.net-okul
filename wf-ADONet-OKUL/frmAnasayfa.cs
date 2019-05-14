using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_ADONet_OKUL
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void mitmCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mitmOgrenciKayit_Click(object sender, EventArgs e)
        {
            frmOgrenciIsleri frm = new frmOgrenciIsleri();
            FormAcikmi(frm);
        }
        private void FormAcikmi(Form AcilacakForm)
        {
            bool Varmi = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (AcilacakForm.Name == MdiChildren[i].Name)
                {
                    MdiChildren[i].Focus();
                    Varmi = true;
                }
            }
            if (Varmi == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose(); //Nesne hafızadan atılır.
            }
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
