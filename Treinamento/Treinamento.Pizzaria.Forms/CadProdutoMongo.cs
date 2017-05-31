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
    public partial class CadPedidoMongo : Form
    {
        public PedidoMongo PedidoMongo { get; set; }
        List<PedidoMongo> lstPedidoMongo { get; set; }
        public CadPedidoMongo()
        {
            InitializeComponent();
            PedidoMongo = new PedidoMongo();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            PedidoMongo = new PedidoMongo();
            PedidoMongo.NomePedido = txtNome.Text;
            PedidoMongo.TipoPedido = txtTipoPedido.Text;
            PedidoMongo.StatusPedido = txtStatusPedido.Text;

            PedidoMongo.AdicionaPedido(PedidoMongo);
            MessageBox.Show("Pedido Inserido!");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //lstPedidoMongo.Clear();
            if (txtFiltrar.Text == "" || txtFiltrar.Text == string.Empty)
            {
                lstPedidoMongo = new List<PedidoMongo>();
                //PedidoMongo.LoadPedido();
                lstPedidoMongo.AddRange(PedidoMongo.LoadPedido());
              
            }
            else
            {
                lstPedidoMongo = new List<PedidoMongo>();
                lstPedidoMongo.AddRange(PedidoMongo.WherePedido(Convert.ToString(txtFiltrar.Text)));
            }
            gridPedido.DataSource = lstPedidoMongo;
            gridPedido.Refresh();
        }
    }
}
