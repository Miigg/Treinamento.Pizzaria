namespace Treinamento.Pizzaria.Forms
{
    partial class CadPedidoMongo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblStatusPedido = new System.Windows.Forms.Label();
            this.txtStatusPedido = new System.Windows.Forms.TextBox();
            this.lblTipoPedido = new System.Windows.Forms.Label();
            this.txtTipoPedido = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 131);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGravar);
            this.tabPage1.Controls.Add(this.lblStatusPedido);
            this.tabPage1.Controls.Add(this.txtStatusPedido);
            this.tabPage1.Controls.Add(this.lblTipoPedido);
            this.tabPage1.Controls.Add(this.txtTipoPedido);
            this.tabPage1.Controls.Add(this.lblNome);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(507, 105);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(196, 62);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lblStatusPedido
            // 
            this.lblStatusPedido.AutoSize = true;
            this.lblStatusPedido.Location = new System.Drawing.Point(7, 64);
            this.lblStatusPedido.Name = "lblStatusPedido";
            this.lblStatusPedido.Size = new System.Drawing.Size(73, 13);
            this.lblStatusPedido.TabIndex = 5;
            this.lblStatusPedido.Text = "Status Pedido";
            // 
            // txtStatusPedido
            // 
            this.txtStatusPedido.Location = new System.Drawing.Point(90, 64);
            this.txtStatusPedido.Name = "txtStatusPedido";
            this.txtStatusPedido.Size = new System.Drawing.Size(100, 20);
            this.txtStatusPedido.TabIndex = 4;
            // 
            // lblTipoPedido
            // 
            this.lblTipoPedido.AutoSize = true;
            this.lblTipoPedido.Location = new System.Drawing.Point(7, 38);
            this.lblTipoPedido.Name = "lblTipoPedido";
            this.lblTipoPedido.Size = new System.Drawing.Size(64, 13);
            this.lblTipoPedido.TabIndex = 3;
            this.lblTipoPedido.Text = "Tipo Pedido";
            // 
            // txtTipoPedido
            // 
            this.txtTipoPedido.Location = new System.Drawing.Point(90, 38);
            this.txtTipoPedido.Name = "txtTipoPedido";
            this.txtTipoPedido.Size = new System.Drawing.Size(100, 20);
            this.txtTipoPedido.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(90, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.lblIdPedido);
            this.tabPage2.Controls.Add(this.txtIdPedido);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(507, 105);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filtros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Location = new System.Drawing.Point(6, 14);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(49, 13);
            this.lblIdPedido.TabIndex = 8;
            this.lblIdPedido.Text = "IdPedido";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(61, 11);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(100, 20);
            this.txtIdPedido.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 266);
            this.dataGridView1.TabIndex = 1;
            // 
            // CadPedidoMongo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 409);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "CadPedidoMongo";
            this.Text = "CadPedidoMongo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblStatusPedido;
        private System.Windows.Forms.TextBox txtStatusPedido;
        private System.Windows.Forms.Label lblTipoPedido;
        private System.Windows.Forms.TextBox txtTipoPedido;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}