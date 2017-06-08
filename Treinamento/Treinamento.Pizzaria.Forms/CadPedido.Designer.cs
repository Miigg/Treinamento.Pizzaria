namespace Treinamento.Pizzaria.Forms
{
    partial class CadPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPedido = new System.Windows.Forms.TabControl();
            this.tabReg = new System.Windows.Forms.TabPage();
            this.lblStatusPedido = new System.Windows.Forms.Label();
            this.lblTipoPedido = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtStatusPedido = new System.Windows.Forms.TextBox();
            this.txtTipoPedido = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.tabFil = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.tabMod = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdPed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatusPed = new System.Windows.Forms.TextBox();
            this.txtTipoPed = new System.Windows.Forms.TextBox();
            this.txtNomePed = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tabDel = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gridPedido = new System.Windows.Forms.DataGridView();
            this.idPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPedido.SuspendLayout();
            this.tabReg.SuspendLayout();
            this.tabFil.SuspendLayout();
            this.tabMod.SuspendLayout();
            this.tabDel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabPedido);
            this.flowLayoutPanel1.Controls.Add(this.gridPedido);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(533, 410);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPedido
            // 
            this.tabPedido.Controls.Add(this.tabReg);
            this.tabPedido.Controls.Add(this.tabFil);
            this.tabPedido.Controls.Add(this.tabMod);
            this.tabPedido.Controls.Add(this.tabDel);
            this.tabPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPedido.Location = new System.Drawing.Point(3, 3);
            this.tabPedido.Name = "tabPedido";
            this.tabPedido.SelectedIndex = 0;
            this.tabPedido.Size = new System.Drawing.Size(530, 140);
            this.tabPedido.TabIndex = 0;
            // 
            // tabReg
            // 
            this.tabReg.Controls.Add(this.lblStatusPedido);
            this.tabReg.Controls.Add(this.lblTipoPedido);
            this.tabReg.Controls.Add(this.lblNome);
            this.tabReg.Controls.Add(this.txtStatusPedido);
            this.tabReg.Controls.Add(this.txtTipoPedido);
            this.tabReg.Controls.Add(this.txtNome);
            this.tabReg.Controls.Add(this.btnGravar);
            this.tabReg.Location = new System.Drawing.Point(4, 22);
            this.tabReg.Name = "tabReg";
            this.tabReg.Padding = new System.Windows.Forms.Padding(3);
            this.tabReg.Size = new System.Drawing.Size(522, 114);
            this.tabReg.TabIndex = 0;
            this.tabReg.Text = "Registro";
            this.tabReg.UseVisualStyleBackColor = true;
            // 
            // lblStatusPedido
            // 
            this.lblStatusPedido.AutoSize = true;
            this.lblStatusPedido.Location = new System.Drawing.Point(6, 72);
            this.lblStatusPedido.Name = "lblStatusPedido";
            this.lblStatusPedido.Size = new System.Drawing.Size(73, 13);
            this.lblStatusPedido.TabIndex = 6;
            this.lblStatusPedido.Text = "Status Pedido";
            // 
            // lblTipoPedido
            // 
            this.lblTipoPedido.AutoSize = true;
            this.lblTipoPedido.Location = new System.Drawing.Point(6, 44);
            this.lblTipoPedido.Name = "lblTipoPedido";
            this.lblTipoPedido.Size = new System.Drawing.Size(64, 13);
            this.lblTipoPedido.TabIndex = 5;
            this.lblTipoPedido.Text = "Tipo Pedido";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // txtStatusPedido
            // 
            this.txtStatusPedido.Location = new System.Drawing.Point(95, 69);
            this.txtStatusPedido.Name = "txtStatusPedido";
            this.txtStatusPedido.Size = new System.Drawing.Size(100, 20);
            this.txtStatusPedido.TabIndex = 2;
            // 
            // txtTipoPedido
            // 
            this.txtTipoPedido.Location = new System.Drawing.Point(95, 41);
            this.txtTipoPedido.Name = "txtTipoPedido";
            this.txtTipoPedido.Size = new System.Drawing.Size(100, 20);
            this.txtTipoPedido.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(95, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(201, 67);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // tabFil
            // 
            this.tabFil.Controls.Add(this.label1);
            this.tabFil.Controls.Add(this.txtFiltrar);
            this.tabFil.Controls.Add(this.btnFiltrar);
            this.tabFil.Location = new System.Drawing.Point(4, 22);
            this.tabFil.Name = "tabFil";
            this.tabFil.Padding = new System.Windows.Forms.Padding(3);
            this.tabFil.Size = new System.Drawing.Size(522, 114);
            this.tabFil.TabIndex = 1;
            this.tabFil.Text = "Filtros";
            this.tabFil.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IdPedido";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(61, 6);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrar.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(61, 32);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 23);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // tabMod
            // 
            this.tabMod.Controls.Add(this.label5);
            this.tabMod.Controls.Add(this.txtIdPed);
            this.tabMod.Controls.Add(this.label4);
            this.tabMod.Controls.Add(this.label2);
            this.tabMod.Controls.Add(this.label3);
            this.tabMod.Controls.Add(this.txtStatusPed);
            this.tabMod.Controls.Add(this.txtTipoPed);
            this.tabMod.Controls.Add(this.txtNomePed);
            this.tabMod.Controls.Add(this.btnModificar);
            this.tabMod.Location = new System.Drawing.Point(4, 22);
            this.tabMod.Name = "tabMod";
            this.tabMod.Padding = new System.Windows.Forms.Padding(3);
            this.tabMod.Size = new System.Drawing.Size(522, 114);
            this.tabMod.TabIndex = 3;
            this.tabMod.Text = "Modificar";
            this.tabMod.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "IdPedido";
            // 
            // txtIdPed
            // 
            this.txtIdPed.Location = new System.Drawing.Point(95, 11);
            this.txtIdPed.Name = "txtIdPed";
            this.txtIdPed.Size = new System.Drawing.Size(100, 20);
            this.txtIdPed.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome";
            // 
            // txtStatusPed
            // 
            this.txtStatusPed.Location = new System.Drawing.Point(95, 89);
            this.txtStatusPed.Name = "txtStatusPed";
            this.txtStatusPed.Size = new System.Drawing.Size(100, 20);
            this.txtStatusPed.TabIndex = 2;
            // 
            // txtTipoPed
            // 
            this.txtTipoPed.Location = new System.Drawing.Point(95, 63);
            this.txtTipoPed.Name = "txtTipoPed";
            this.txtTipoPed.Size = new System.Drawing.Size(100, 20);
            this.txtTipoPed.TabIndex = 1;
            // 
            // txtNomePed
            // 
            this.txtNomePed.Location = new System.Drawing.Point(95, 37);
            this.txtNomePed.Name = "txtNomePed";
            this.txtNomePed.Size = new System.Drawing.Size(100, 20);
            this.txtNomePed.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(201, 88);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tabDel
            // 
            this.tabDel.Controls.Add(this.label6);
            this.tabDel.Controls.Add(this.txtDelete);
            this.tabDel.Controls.Add(this.btnDelete);
            this.tabDel.Location = new System.Drawing.Point(4, 22);
            this.tabDel.Name = "tabDel";
            this.tabDel.Padding = new System.Windows.Forms.Padding(3);
            this.tabDel.Size = new System.Drawing.Size(522, 114);
            this.tabDel.TabIndex = 4;
            this.tabDel.Text = "Deletar";
            this.tabDel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "IdPedido";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(60, 6);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(100, 20);
            this.txtDelete.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(60, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gridPedido
            // 
            this.gridPedido.AllowUserToAddRows = false;
            this.gridPedido.AllowUserToDeleteRows = false;
            this.gridPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gridPedido.AutoGenerateColumns = false;
            this.gridPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedidoDataGridViewTextBoxColumn,
            this.nomePedidoDataGridViewTextBoxColumn,
            this.tipoPedidoDataGridViewTextBoxColumn,
            this.statusPedidoDataGridViewTextBoxColumn});
            this.gridPedido.DataSource = this.pedidoBindingSource;
            this.gridPedido.Location = new System.Drawing.Point(3, 149);
            this.gridPedido.Name = "gridPedido";
            this.gridPedido.ReadOnly = true;
            this.gridPedido.Size = new System.Drawing.Size(526, 280);
            this.gridPedido.TabIndex = 1;
            this.gridPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPedido_CellClick);
            // 
            // idPedidoDataGridViewTextBoxColumn
            // 
            this.idPedidoDataGridViewTextBoxColumn.DataPropertyName = "IdPedido";
            this.idPedidoDataGridViewTextBoxColumn.HeaderText = "IdPedido";
            this.idPedidoDataGridViewTextBoxColumn.Name = "idPedidoDataGridViewTextBoxColumn";
            this.idPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomePedidoDataGridViewTextBoxColumn
            // 
            this.nomePedidoDataGridViewTextBoxColumn.DataPropertyName = "NomePedido";
            this.nomePedidoDataGridViewTextBoxColumn.HeaderText = "NomePedido";
            this.nomePedidoDataGridViewTextBoxColumn.Name = "nomePedidoDataGridViewTextBoxColumn";
            this.nomePedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoPedidoDataGridViewTextBoxColumn
            // 
            this.tipoPedidoDataGridViewTextBoxColumn.DataPropertyName = "TipoPedido";
            this.tipoPedidoDataGridViewTextBoxColumn.HeaderText = "TipoPedido";
            this.tipoPedidoDataGridViewTextBoxColumn.Name = "tipoPedidoDataGridViewTextBoxColumn";
            this.tipoPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusPedidoDataGridViewTextBoxColumn
            // 
            this.statusPedidoDataGridViewTextBoxColumn.DataPropertyName = "StatusPedido";
            this.statusPedidoDataGridViewTextBoxColumn.HeaderText = "StatusPedido";
            this.statusPedidoDataGridViewTextBoxColumn.Name = "statusPedidoDataGridViewTextBoxColumn";
            this.statusPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataSource = typeof(Treinamento.Pizzaria.Pedido);
            // 
            // CadPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 410);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "CadPedido";
            this.Text = "Pedido";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPedido.ResumeLayout(false);
            this.tabReg.ResumeLayout(false);
            this.tabReg.PerformLayout();
            this.tabFil.ResumeLayout(false);
            this.tabFil.PerformLayout();
            this.tabMod.ResumeLayout(false);
            this.tabMod.PerformLayout();
            this.tabDel.ResumeLayout(false);
            this.tabDel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView gridPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private System.Windows.Forms.TabControl tabPedido;
        private System.Windows.Forms.TabPage tabReg;
        private System.Windows.Forms.Label lblStatusPedido;
        private System.Windows.Forms.Label lblTipoPedido;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtStatusPedido;
        private System.Windows.Forms.TextBox txtTipoPedido;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TabPage tabFil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TabPage tabMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdPed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatusPed;
        private System.Windows.Forms.TextBox txtTipoPed;
        private System.Windows.Forms.TextBox txtNomePed;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TabPage tabDel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnDelete;
    }
}