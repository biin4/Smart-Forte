using System;
using System.Threading;
using System.Windows.Forms;

namespace SmartForte
{
	public partial class BTVoltar2 : Form
    {
		Thread tela;
		public BTVoltar2()
        {
            InitializeComponent();
        }

        private void BTVoltar1_Click(object sender, EventArgs e)
        {
			this.Close();
			tela = new Thread(VoltarAluno);
			tela.SetApartmentState(ApartmentState.STA);
			tela.Start();
		}
		private void VoltarAluno(object obj)
		{
			Application.Run(new Form1());
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
