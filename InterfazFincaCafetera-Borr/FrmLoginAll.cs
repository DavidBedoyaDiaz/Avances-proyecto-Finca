using System;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmLoginAll : Form
    {
        public FrmLoginAll()
        {
            InitializeComponent();
        }
        public String Perfil { get; set; }
     

        private void FrmLoginAll_Load(object sender, EventArgs e)
        {
            if (this.Perfil == "Administrador")
            {
                PicPerfil.Image = imageList1.Images[2];
            }else
            {
                if (this.Perfil == "Mayordomo")
                {
                    PicPerfil.Image = imageList1.Images[0];
                }
                else
                {
                    if (this.Perfil == "Propietario")
                    {
                        PicPerfil.Image = imageList1.Images[1];
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

     

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Perfil = comboBox1.Text;
        //    this.FrmLoginAll_Load(sender, e);

        //}
    }
}
