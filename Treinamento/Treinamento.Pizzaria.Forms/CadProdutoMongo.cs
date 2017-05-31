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
    public partial class CadProdutoMongo : Form
    {
        public ProdutoMongo ProdutoMongo { get; set; }
        List<ProdutoMongo> lstProdutoMongo { get; set; }
        public CadProdutoMongo()
        {
            InitializeComponent();
            ProdutoMongo = new ProdutoMongo();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ProdutoMongo = new ProdutoMongo();
            ProdutoMongo.NomeProduto = txtNome.Text;
            ProdutoMongo.DescricaoProduto = txtTipoPedido.Text;
            ProdutoMongo.Ativo = Convert.ToBoolean(checkAtivo.Checked);

            ProdutoMongo.AdicionaProduto(ProdutoMongo);
            MessageBox.Show("Produto Inserido!");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //lstPedidoMongo.Clear();
            if (txtFiltrar.Text == "" || txtFiltrar.Text == string.Empty)
            {
                lstProdutoMongo = new List<ProdutoMongo>();
                //PedidoMongo.LoadPedido();
                lstProdutoMongo.AddRange(ProdutoMongo.LoadProduto());
              
            }
            else
            {
                lstProdutoMongo = new List<ProdutoMongo>();
                lstProdutoMongo.AddRange(ProdutoMongo.WhereProduto(Convert.ToString(txtFiltrar.Text)));
            }
            gridPedido.DataSource = lstProdutoMongo;
            gridPedido.Refresh();
        }
    }
}
