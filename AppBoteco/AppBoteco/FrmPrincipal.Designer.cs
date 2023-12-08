namespace AppBoteco
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxProdutos = new System.Windows.Forms.PictureBox();
            this.pbxFuncionarios = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxClientes = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxVendas = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxTipoProduto = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTipoProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.cadastrosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1416, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.tipoDoProdutoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // tipoDoProdutoToolStripMenuItem
            // 
            this.tipoDoProdutoToolStripMenuItem.Name = "tipoDoProdutoToolStripMenuItem";
            this.tipoDoProdutoToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.tipoDoProdutoToolStripMenuItem.Text = "Tipo do Produto";
            this.tipoDoProdutoToolStripMenuItem.Click += new System.EventHandler(this.tipoDoProdutoToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUTOS";
            // 
            // pbxProdutos
            // 
            this.pbxProdutos.Image = global::AppBoteco.Properties.Resources.produtos;
            this.pbxProdutos.Location = new System.Drawing.Point(26, 53);
            this.pbxProdutos.Name = "pbxProdutos";
            this.pbxProdutos.Size = new System.Drawing.Size(138, 172);
            this.pbxProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProdutos.TabIndex = 2;
            this.pbxProdutos.TabStop = false;
            this.pbxProdutos.Click += new System.EventHandler(this.pbxProdutos_Click);
            // 
            // pbxFuncionarios
            // 
            this.pbxFuncionarios.Image = global::AppBoteco.Properties.Resources.funcionarios;
            this.pbxFuncionarios.Location = new System.Drawing.Point(215, 53);
            this.pbxFuncionarios.Name = "pbxFuncionarios";
            this.pbxFuncionarios.Size = new System.Drawing.Size(138, 172);
            this.pbxFuncionarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFuncionarios.TabIndex = 4;
            this.pbxFuncionarios.TabStop = false;
            this.pbxFuncionarios.Click += new System.EventHandler(this.pbxFuncionarios_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "FUNCIONÁRIOS";
            // 
            // pbxClientes
            // 
            this.pbxClientes.Image = global::AppBoteco.Properties.Resources.clientes;
            this.pbxClientes.Location = new System.Drawing.Point(408, 53);
            this.pbxClientes.Name = "pbxClientes";
            this.pbxClientes.Size = new System.Drawing.Size(138, 172);
            this.pbxClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClientes.TabIndex = 6;
            this.pbxClientes.TabStop = false;
            this.pbxClientes.Click += new System.EventHandler(this.pbxClientes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "CLIENTES";
            // 
            // pbxVendas
            // 
            this.pbxVendas.Image = global::AppBoteco.Properties.Resources.vendas;
            this.pbxVendas.Location = new System.Drawing.Point(602, 53);
            this.pbxVendas.Name = "pbxVendas";
            this.pbxVendas.Size = new System.Drawing.Size(138, 172);
            this.pbxVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVendas.TabIndex = 8;
            this.pbxVendas.TabStop = false;
            this.pbxVendas.Click += new System.EventHandler(this.pbxVendas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(629, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "VENDAS";
            // 
            // pbxSair
            // 
            this.pbxSair.Image = global::AppBoteco.Properties.Resources.sair;
            this.pbxSair.Location = new System.Drawing.Point(1006, 53);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(138, 172);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 10;
            this.pbxSair.TabStop = false;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1043, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "SAIR";
            // 
            // pbxTipoProduto
            // 
            this.pbxTipoProduto.Image = global::AppBoteco.Properties.Resources.tipoprodutos;
            this.pbxTipoProduto.Location = new System.Drawing.Point(804, 53);
            this.pbxTipoProduto.Name = "pbxTipoProduto";
            this.pbxTipoProduto.Size = new System.Drawing.Size(138, 172);
            this.pbxTipoProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTipoProduto.TabIndex = 12;
            this.pbxTipoProduto.TabStop = false;
            this.pbxTipoProduto.Click += new System.EventHandler(this.pbxTipoProduto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(768, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "TIPOS DE PRODUTOS";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1416, 551);
            this.Controls.Add(this.pbxTipoProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbxVendas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbxFuncionarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxProdutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Boteco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTipoProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxProdutos;
        private System.Windows.Forms.PictureBox pbxFuncionarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxVendas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbxSair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbxTipoProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem tipoDoProdutoToolStripMenuItem;
    }
}

