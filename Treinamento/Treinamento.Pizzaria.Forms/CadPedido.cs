using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treinamento.Pizzaria.Forms
{
    public partial class CadPedido : Form
    {
        public Pedido Pedido { get; set; }
        List<Pedido> lstPedido { get; set; }
        public CadPedido()
        {
            InitializeComponent();
            Pedido = new Pedido();
            lstPedido = new List<Pedido>();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            lstPedido.Clear();
            if (txtFiltrar.Text == "" || txtFiltrar.Text == string.Empty)
            {
                lstPedido = new List<Pedido>();
                lstPedido.AddRange(Pedido.LoadPedido());

            }
            else
            {
                lstPedido = new List<Pedido>();
                lstPedido.Add(Pedido.WherePedido(Convert.ToInt32(txtFiltrar.Text)));
            }
            gridPedido.DataSource = lstPedido;
            gridPedido.Refresh();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Pedido = new Pedido();
            Pedido.NomePedido = txtNome.Text;
            Pedido.TipoPedido = txtTipoPedido.Text;
            Pedido.StatusPedido = Convert.ToChar(txtStatusPedido.Text);
            
            Pedido.AdicionaPedido(Pedido);
            MessageBox.Show("Pedido Inserido!");
        }
    }
}
