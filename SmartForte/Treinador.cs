using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SmartForte
{
    public partial class Treinador : Form
    {
		Thread tl;
		public Treinador()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTVoltar2_Click(object sender, EventArgs e)
        {
			this.Close();
			tl = new Thread(VoltarTreinador);
			tl.SetApartmentState(ApartmentState.STA);
			tl.Start();
		}
		private void VoltarTreinador(object obj)
		{
			Application.Run(new Form1());
		}

        private void EntrarTreinador_Click(object sender, EventArgs e)
        {

        }
    }
}
