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
    public partial class Form1 : Form
    {
        Thread telas;
        public Form1()
        {
            InitializeComponent();
        }

        private void BTCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            telas = new Thread(AbrirCadastro);
            telas.SetApartmentState(ApartmentState.STA);
            telas.Start();
        }
        private void AbrirCadastro(object obj)
        {
            Application.Run(new Cadastro()); 
        }
        private void AbrirAluno(object obj)
        {
            Application.Run(new BTVoltar2());
        }

        private void BTAluno_Click(object sender, EventArgs e)
        {
            this.Close();
            telas = new Thread(AbrirAluno);
            telas.SetApartmentState(ApartmentState.STA);
            telas.Start();
        }

        private void BTTreinadores_Click(object sender, EventArgs e)
        {
            this.Close();
            telas = new Thread(AbrirTreinador);
            telas.SetApartmentState(ApartmentState.STA);
            telas.Start();
        }
        private void AbrirTreinador(object obj)
        {
            Application.Run(new Treinador());
        }
    }
}
