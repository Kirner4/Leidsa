using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leidsa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            int[] numeroselegidos = a.generarNumerosAleatoriosNoRepetidos(6, 1, 38);
            Control[] controles = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };
            for (int i= 0; i < controles.Length; i++)
            {
                int valor = numeroselegidos[i];
                controles[i].Text = valor + "";
            }
        }

        private void Lotomas_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            int[] numeroselegidos = a.generarNumerosAleatoriosNoRepetidos(1, 1, 10);
            Control[] controles = { textBoxLotomas };
            for (int i = 0; i < controles.Length; i++)
            {
                int valor = numeroselegidos[i];
                controles[i].Text = valor + "";
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
