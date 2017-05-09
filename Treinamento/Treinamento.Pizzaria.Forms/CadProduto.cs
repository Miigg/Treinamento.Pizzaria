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
    public partial class CadProduto : Form
    {
        public Produto Produto { get; set; }
        List<Produto> lstProduto { get; set; }
        public CadProduto()
        {
            InitializeComponent();
            Produto = new Produto();
            lstProduto = new List<Produto>();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            lstProduto.Clear();
            if (txtFiltrar.Text == "" || txtFiltrar.Text == string.Empty)
            {
                lstProduto = new List<Produto>();
                lstProduto.AddRange(Produto.LoadProduto());

            }
            else
            {
                lstProduto = new List<Produto>();
                lstProduto.Add(Produto.WhereProduto(Convert.ToInt32(txtFiltrar.Text)));
            }

            gridPedido.Refresh();
            gridPedido.DataSource = lstProduto;
            
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Produto = new Produto();
            Produto.NomeProduto = txtNome.Text;
            Produto.DescricaoProduto = txtDescricao.Text;
            Produto.Ativo = Convert.ToBoolean(checkAtivo.Checked);

            Produto.AdicionaProduto(Produto);
            MessageBox.Show("Produto Inserido!");
        }

    }
}

