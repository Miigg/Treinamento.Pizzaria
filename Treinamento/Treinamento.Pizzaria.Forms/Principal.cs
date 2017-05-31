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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadProduto CadProduto = new CadProduto();
            CadProduto.ShowDialog();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadPedido CadPedido = new CadPedido();
            CadPedido.ShowDialog();
        }

        private void pedidoMongoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadPedidoMongo CadPedidoMongo = new CadPedidoMongo();
            CadPedidoMongo.ShowDialog();
        }

        private void produtoMongoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadProdutoMongo CadProdutoMongo = new CadProdutoMongo();
            CadProdutoMongo.ShowDialog();
        }
    }
}
