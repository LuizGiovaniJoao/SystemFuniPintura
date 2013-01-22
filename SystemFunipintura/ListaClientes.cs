using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemFunipintura
{
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void txt_CpfCnpj_Enter(object sender, EventArgs e)
        {
            if(txt_CpfCnpj.Text == "CPF/CNPJ")
            {
                txt_CpfCnpj.Text = "";
            }
        }

        private void txt_CpfCnpj_Leave(object sender, EventArgs e)
        {
            if(txt_CpfCnpj.Text == "")
            {
                txt_CpfCnpj.Text = "CPF/CNPJ";
            }
        }

        private void txt_Nome_Enter(object sender, EventArgs e)
        {
            if (txt_Nome.Text == "Nome do cliente")
            {
                txt_Nome.Text = "";
            }
        }

        private void txt_Nome_Leave(object sender, EventArgs e)
        {
            if (txt_Nome.Text == "")
            {
                txt_Nome.Text = "Nome do cliente";
            }
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            txt_CpfCnpj.Focus();
        }
    }
}
