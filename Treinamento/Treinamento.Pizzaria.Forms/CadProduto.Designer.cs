namespace Treinamento.Pizzaria.Forms
{
    partial class CadProduto
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
            this.lblAtivo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tabFilPrd = new System.Windows.Forms.TabPage();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.tabControlProduto = new System.Windows.Forms.TabControl();
            this.tabRegPrd = new System.Windows.Forms.TabPage();
            this.checkAtivo = new System.Windows.Forms.CheckBox();
            this.tabModPrd = new System.Windows.Forms.TabPage();
            this.checkAtivoMod = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdPrd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescPrd = new System.Windows.Forms.TextBox();
            this.txtNomePrd = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tabDelPrd = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gridProduto = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabFilPrd.SuspendLayout();
            this.tabControlProduto.SuspendLayout();
            this.tabRegPrd.SuspendLayout();
            this.tabModPrd.SuspendLayout();
            this.tabDelPrd.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(6, 72);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(31, 13);
            this.lblAtivo.TabIndex = 6;
            this.lblAtivo.Text = "Ativo";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IdProduto";
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
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 44);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descricao";
            // 
            // tabFilPrd
            // 
            this.tabFilPrd.Controls.Add(this.label1);
            this.tabFilPrd.Controls.Add(this.txtFiltrar);
            this.tabFilPrd.Controls.Add(this.btnFiltrar);
            this.tabFilPrd.Location = new System.Drawing.Point(4, 22);
            this.tabFilPrd.Name = "tabFilPrd";
            this.tabFilPrd.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilPrd.Size = new System.Drawing.Size(522, 111);
            this.tabFilPrd.TabIndex = 1;
            this.tabFilPrd.Text = "Filtros";
            this.tabFilPrd.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(95, 41);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 1;
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
            this.btnGravar.Location = new System.Drawing.Point(120, 66);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // tabControlProduto
            // 
            this.tabControlProduto.Controls.Add(this.tabRegPrd);
            this.tabControlProduto.Controls.Add(this.tabFilPrd);
            this.tabControlProduto.Controls.Add(this.tabModPrd);
            this.tabControlProduto.Controls.Add(this.tabDelPrd);
            this.tabControlProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlProduto.Location = new System.Drawing.Point(3, 3);
            this.tabControlProduto.Name = "tabControlProduto";
            this.tabControlProduto.SelectedIndex = 0;
            this.tabControlProduto.Size = new System.Drawing.Size(530, 137);
            this.tabControlProduto.TabIndex = 0;
            // 
            // tabRegPrd
            // 
            this.tabRegPrd.Controls.Add(this.checkAtivo);
            this.tabRegPrd.Controls.Add(this.lblAtivo);
            this.tabRegPrd.Controls.Add(this.lblDescricao);
            this.tabRegPrd.Controls.Add(this.lblNome);
            this.tabRegPrd.Controls.Add(this.txtDescricao);
            this.tabRegPrd.Controls.Add(this.txtNome);
            this.tabRegPrd.Controls.Add(this.btnGravar);
            this.tabRegPrd.Location = new System.Drawing.Point(4, 22);
            this.tabRegPrd.Name = "tabRegPrd";
            this.tabRegPrd.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegPrd.Size = new System.Drawing.Size(522, 111);
            this.tabRegPrd.TabIndex = 0;
            this.tabRegPrd.Text = "Registro";
            this.tabRegPrd.UseVisualStyleBackColor = true;
            // 
            // checkAtivo
            // 
            this.checkAtivo.AutoSize = true;
            this.checkAtivo.Location = new System.Drawing.Point(95, 72);
            this.checkAtivo.Name = "checkAtivo";
            this.checkAtivo.Size = new System.Drawing.Size(15, 14);
            this.checkAtivo.TabIndex = 7;
            this.checkAtivo.UseVisualStyleBackColor = true;
            // 
            // tabModPrd
            // 
            this.tabModPrd.Controls.Add(this.checkAtivoMod);
            this.tabModPrd.Controls.Add(this.label5);
            this.tabModPrd.Controls.Add(this.txtIdPrd);
            this.tabModPrd.Controls.Add(this.label4);
            this.tabModPrd.Controls.Add(this.label2);
            this.tabModPrd.Controls.Add(this.label3);
            this.tabModPrd.Controls.Add(this.txtDescPrd);
            this.tabModPrd.Controls.Add(this.txtNomePrd);
            this.tabModPrd.Controls.Add(this.btnModificar);
            this.tabModPrd.Location = new System.Drawing.Point(4, 22);
            this.tabModPrd.Name = "tabModPrd";
            this.tabModPrd.Padding = new System.Windows.Forms.Padding(3);
            this.tabModPrd.Size = new System.Drawing.Size(522, 111);
            this.tabModPrd.TabIndex = 2;
            this.tabModPrd.Text = "Modificar";
            this.tabModPrd.UseVisualStyleBackColor = true;
            // 
            // checkAtivoMod
            // 
            this.checkAtivoMod.AutoSize = true;
            this.checkAtivoMod.Location = new System.Drawing.Point(97, 88);
            this.checkAtivoMod.Name = "checkAtivoMod";
            this.checkAtivoMod.Size = new System.Drawing.Size(15, 14);
            this.checkAtivoMod.TabIndex = 18;
            this.checkAtivoMod.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "IdProduto";
            // 
            // txtIdPrd
            // 
            this.txtIdPrd.Location = new System.Drawing.Point(97, 7);
            this.txtIdPrd.Name = "txtIdPrd";
            this.txtIdPrd.Size = new System.Drawing.Size(100, 20);
            this.txtIdPrd.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descricao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome";
            // 
            // txtDescPrd
            // 
            this.txtDescPrd.Location = new System.Drawing.Point(97, 59);
            this.txtDescPrd.Name = "txtDescPrd";
            this.txtDescPrd.Size = new System.Drawing.Size(100, 20);
            this.txtDescPrd.TabIndex = 10;
            // 
            // txtNomePrd
            // 
            this.txtNomePrd.Location = new System.Drawing.Point(97, 33);
            this.txtNomePrd.Name = "txtNomePrd";
            this.txtNomePrd.Size = new System.Drawing.Size(100, 20);
            this.txtNomePrd.TabIndex = 9;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(122, 83);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tabDelPrd
            // 
            this.tabDelPrd.Controls.Add(this.label6);
            this.tabDelPrd.Controls.Add(this.txtDelete);
            this.tabDelPrd.Controls.Add(this.btnDelete);
            this.tabDelPrd.Location = new System.Drawing.Point(4, 22);
            this.tabDelPrd.Name = "tabDelPrd";
            this.tabDelPrd.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelPrd.Size = new System.Drawing.Size(522, 111);
            this.tabDelPrd.TabIndex = 3;
            this.tabDelPrd.Text = "Deletar";
            this.tabDelPrd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "IdProduto";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(63, 6);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(100, 20);
            this.txtDelete.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(63, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabControlProduto);
            this.flowLayoutPanel1.Controls.Add(this.gridProduto);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(533, 412);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // gridProduto
            // 
            this.gridProduto.AllowUserToAddRows = false;
            this.gridProduto.AllowUserToDeleteRows = false;
            this.gridProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gridProduto.AutoGenerateColumns = false;
            this.gridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.gridProduto.DataSource = this.produtoBindingSource;
            this.gridProduto.Location = new System.Drawing.Point(3, 146);
            this.gridProduto.Name = "gridProduto";
            this.gridProduto.ReadOnly = true;
            this.gridProduto.Size = new System.Drawing.Size(526, 249);
            this.gridProduto.TabIndex = 1;
            this.gridProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProduto_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdProduto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeProduto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DescricaoProduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "DescricaoProduto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Ativo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Treinamento.Pizzaria.Produto);
            // 
            // CadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 412);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CadProduto";
            this.Text = "Produto";
            this.tabFilPrd.ResumeLayout(false);
            this.tabFilPrd.PerformLayout();
            this.tabControlProduto.ResumeLayout(false);
            this.tabRegPrd.ResumeLayout(false);
            this.tabRegPrd.PerformLayout();
            this.tabModPrd.ResumeLayout(false);
            this.tabModPrd.PerformLayout();
            this.tabDelPrd.ResumeLayout(false);
            this.tabDelPrd.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TabPage tabFilPrd;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TabControl tabControlProduto;
        private System.Windows.Forms.TabPage tabRegPrd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView gridProduto;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.CheckBox checkAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TabPage tabModPrd;
        private System.Windows.Forms.CheckBox checkAtivoMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdPrd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescPrd;
        private System.Windows.Forms.TextBox txtNomePrd;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TabPage tabDelPrd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnDelete;
    }
}