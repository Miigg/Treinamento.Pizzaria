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
            pedidoBindingSource.DataSource = lstPedido;
            //gridPedido.DataSource = lstPedido;
            gridPedido.Refresh();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            Pedido.NomePedido = txtNome.Text;
            Pedido.TipoPedido = txtTipoPedido.Text;
            Pedido.StatusPedido = Convert.ToChar(txtStatusPedido.Text);

            Pedido.AdicionaPedido(Pedido);
            pedidoBindingSource.ResetBindings(true);
            MessageBox.Show("Pedido Inserido!", "Pedido");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Pedido.IdPedido = Convert.ToInt32(txtIdPed.Text);
            Pedido.NomePedido = txtNomePed.Text;
            Pedido.TipoPedido = txtTipoPed.Text;
            Pedido.StatusPedido = Convert.ToChar(txtStatusPed.Text);

            Pedido.ModificaPedido(Pedido);

            pedidoBindingSource.ResetBindings(true);
            txtIdPed.Enabled = true;
            txtIdPed.ReadOnly = false;
            txtIdPed.Clear();
            txtNomePed.Clear();
            txtStatusPed.Clear();
            txtTipoPed.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDelete.Text == "" || txtDelete.Text == string.Empty)
            {
                MessageBox.Show("Digite um Id para deletar");

            }
            else
            {
                //    Pedido = lstPedido.Find(x => x.IdPedido.Equals(Convert.ToInt32(txtDelete.Text)));
                //    Pedido.DeletaPedido(Pedido);
                //    lstPedido.Remove(Pedido);

                Pedido = (Pedido)pedidoBindingSource.Current;
                Pedido.DeletaPedido(Pedido);
                lstPedido.Remove(Pedido);
                pedidoBindingSource.ResetBindings(true);
                txtDelete.Enabled = true;
                txtDelete.ReadOnly = false;
                txtDelete.Clear();
            }
        }

        private void gridPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Modificar?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtIdPed.Enabled = false;
                txtIdPed.ReadOnly = true;
                tabPedido.SelectTab(tabMod);
                Pedido = (Pedido)pedidoBindingSource.Current;
                txtIdPed.Text = Convert.ToString(Pedido.IdPedido);
                txtNomePed.Text = Convert.ToString(Pedido.NomePedido);
                txtTipoPed.Text = Convert.ToString(Pedido.TipoPedido);
                txtStatusPed.Text = Convert.ToString(Pedido.StatusPedido);
            }
            else
            {
                if ((MessageBox.Show("Deletar?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    txtDelete.Enabled = false;
                    txtDelete.ReadOnly = true;
                    tabPedido.SelectTab(tabDel);
                    Pedido = (Pedido)pedidoBindingSource.Current;
                    txtDelete.Text = Convert.ToString(Pedido.IdPedido);
                }

            }
        }
    }
}
