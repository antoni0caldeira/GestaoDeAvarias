using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeAvarias
{
    public partial class frmGestaoAvarias : Form
    {
        public frmGestaoAvarias()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            InserirDados();
        }

        private void InserirDados()
        {
            MessageBox.Show("Inseir", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReparado_Click(object sender, EventArgs e)
        {
            btnReparar();
        }

        private void btnReparar()
        {
            MessageBox.Show("Reparar", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
