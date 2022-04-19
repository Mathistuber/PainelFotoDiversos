using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainelFotoDiversos
{
    public partial class TelaFotos : Form
    {
        public TelaFotos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogFoto.Filter = "Arquivos jpg|*.jpg|Arquivos png|*.png";

            if (openFileDialogFoto.ShowDialog() == DialogResult.OK)
            {
                pbxFoto1.ImageLocation = openFileDialogFoto.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialogFoto.Filter = "Arquivos jpg|*.jpg|Arquivos png|*.png";

            if (openFileDialogFoto.ShowDialog() == DialogResult.OK)
            {
                pbxFoto2.ImageLocation = openFileDialogFoto.FileName;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialogFoto.Filter = "Arquivos jpg|*.jpg|Arquivos png|*.png";

            if (openFileDialogFoto.ShowDialog() == DialogResult.OK)
            {
                pbxFoto3.ImageLocation = openFileDialogFoto.FileName;
            }
        }
    }
}
