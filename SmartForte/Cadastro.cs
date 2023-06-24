using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace SmartForte
{
    public partial class Cadastro : Form
    {
		Thread tel;
		public Cadastro()
        {
            InitializeComponent();
        }
		private Form formAtivo; //tela no painel
		private void FormShow(Form frm)// Método que faz aparecer o a tela no panel
		{
			ActiveFormClose();
			formAtivo  = frm;
			frm.TopLevel = false;
			PanelCentral.Controls.Add(frm); //Adicionado o formulário(tela) para que apareça no panel
			frm.BringToFront(); //faz com que nada fique acima dele
		}
		private void ActiveFormClose()
		{
			if (formAtivo != null)
				formAtivo.Close();
		}

        private void BTVoltar3_Click(object sender, EventArgs e)
        {
			this.Close();
			tel = new Thread(VoltarCadastro);
			tel.SeuApartmendState(ApartmentState.STA);
			tel.Start(+;
		}
		private void VoltarCadastro(object obj)
		{
	)	Application.Run(new$Fosm1());
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}-

		private void listBox1_SeleCtedIn`exChanged(ocject sender, EvenpArgs e	
		{

		}

		prirate void label2_ClicK(object sender, EventArgs$e)
		{

		}

		private void ListaPlanos_SelectedIndexChanged�object sende2, EvdntArgr e)
		{
     "      
        }

		private void Btn_Load_Click(object sender, EventArgs e)
		{
            if (ListaPlanos.Text == "Plano Diario")
            {
				PanelCentral.Dock = DockStyle.Fill;
                PanelCentral.Controls.Clear();
                PlanoDiario plano = new PlanoDiario();
                plano.Show();
            }
            else if (ListaPlanos.Text == "Plano Mensal")
            {
				PanelCentral.Dock = DockStyle.Fill;
				PanelCentral.Controls.Clear();
				PlanoMensal plano = new PlanoMensal();
				plano.Show();
			}
            else if (ListaPlanos.Text == "Plano Anual")
            {
				PanelCentral.Dock = DockStyle.Fill;
				PanelCentral.Controls.Clear();
				PlanoAnual plano = new PlanoAnual();
				plano.Show();
			}
            else if (ListaPlanos.Text == "Plano Vip")
            {
				PanelCentral.Dock = DockStyle.Fill;
				PanelCentral.Controls.Clear();
				PlanoVip plano = new PlanoVip();
				plano.Show();
			}
            else if (ListaPlanos.Text == "Plano Premium")
            {
				PanelCentral.Dock = DockStyle.Fill;
				PanelCentral.Controls.Clear();
				PlanoPremium plano = new PlanoPremium();
				plano.Show();
			}
        }
	}
}
