namespace WindowsFormsApplication2
{
    partial class Menu
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
            this.btncadprod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.btncadusu = new System.Windows.Forms.Button();
            this.btnconprod = new System.Windows.Forms.Button();
            this.btnconusu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnconvenda = new System.Windows.Forms.Button();
            this.btnvender = new System.Windows.Forms.Button();
            this.btnentraestoque = new System.Windows.Forms.Button();
            this.btnconcli = new System.Windows.Forms.Button();
            this.btncadcli = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncadprod
            // 
            this.btncadprod.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadprod.Location = new System.Drawing.Point(40, 236);
            this.btncadprod.Name = "btncadprod";
            this.btncadprod.Size = new System.Drawing.Size(285, 44);
            this.btncadprod.TabIndex = 0;
            this.btncadprod.Text = "Cadastro de Produto";
            this.btncadprod.UseVisualStyleBackColor = true;
            this.btncadprod.Click += new System.EventHandler(this.btncadprod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(557, 39);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(115, 18);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "nome completo";
            // 
            // btncadusu
            // 
            this.btncadusu.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadusu.Location = new System.Drawing.Point(41, 318);
            this.btncadusu.Name = "btncadusu";
            this.btncadusu.Size = new System.Drawing.Size(284, 44);
            this.btncadusu.TabIndex = 3;
            this.btncadusu.Text = "Cadastro de Usuário";
            this.btncadusu.UseVisualStyleBackColor = true;
            this.btncadusu.Click += new System.EventHandler(this.btncadusu_Click);
            // 
            // btnconprod
            // 
            this.btnconprod.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconprod.Location = new System.Drawing.Point(483, 236);
            this.btnconprod.Name = "btnconprod";
            this.btnconprod.Size = new System.Drawing.Size(285, 44);
            this.btnconprod.TabIndex = 4;
            this.btnconprod.Text = "Consulta de Produtos";
            this.btnconprod.UseVisualStyleBackColor = true;
            this.btnconprod.Click += new System.EventHandler(this.btnconprod_Click);
            // 
            // btnconusu
            // 
            this.btnconusu.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconusu.Location = new System.Drawing.Point(483, 318);
            this.btnconusu.Name = "btnconusu";
            this.btnconusu.Size = new System.Drawing.Size(285, 44);
            this.btnconusu.TabIndex = 5;
            this.btnconusu.Text = "Consulta de Usuários";
            this.btnconusu.UseVisualStyleBackColor = true;
            this.btnconusu.Click += new System.EventHandler(this.btnconusu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1,
            this.consultaToolStripMenuItem1});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // btnconvenda
            // 
            this.btnconvenda.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvenda.Location = new System.Drawing.Point(484, 158);
            this.btnconvenda.Name = "btnconvenda";
            this.btnconvenda.Size = new System.Drawing.Size(285, 44);
            this.btnconvenda.TabIndex = 15;
            this.btnconvenda.Text = "Consulta de vendas";
            this.btnconvenda.UseVisualStyleBackColor = true;
            this.btnconvenda.Click += new System.EventHandler(this.btnconvenda_Click);
            // 
            // btnvender
            // 
            this.btnvender.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvender.Location = new System.Drawing.Point(41, 158);
            this.btnvender.Name = "btnvender";
            this.btnvender.Size = new System.Drawing.Size(285, 44);
            this.btnvender.TabIndex = 14;
            this.btnvender.Text = "Vender";
            this.btnvender.UseVisualStyleBackColor = true;
            this.btnvender.Click += new System.EventHandler(this.btnvender_Click);
            // 
            // btnentraestoque
            // 
            this.btnentraestoque.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentraestoque.Location = new System.Drawing.Point(276, 81);
            this.btnentraestoque.Name = "btnentraestoque";
            this.btnentraestoque.Size = new System.Drawing.Size(285, 44);
            this.btnentraestoque.TabIndex = 13;
            this.btnentraestoque.Text = "Entrada estoque";
            this.btnentraestoque.UseVisualStyleBackColor = true;
            this.btnentraestoque.Click += new System.EventHandler(this.btnentraestoque_Click);
            // 
            // btnconcli
            // 
            this.btnconcli.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconcli.Location = new System.Drawing.Point(483, 398);
            this.btnconcli.Name = "btnconcli";
            this.btnconcli.Size = new System.Drawing.Size(285, 44);
            this.btnconcli.TabIndex = 17;
            this.btnconcli.Text = "Consulta de Cliente";
            this.btnconcli.UseVisualStyleBackColor = true;
            this.btnconcli.Click += new System.EventHandler(this.btnconcli_Click);
            // 
            // btncadcli
            // 
            this.btncadcli.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadcli.Location = new System.Drawing.Point(40, 398);
            this.btncadcli.Name = "btncadcli";
            this.btncadcli.Size = new System.Drawing.Size(285, 44);
            this.btncadcli.TabIndex = 16;
            this.btncadcli.Text = "Cadastro de Cliente";
            this.btncadcli.UseVisualStyleBackColor = true;
            this.btncadcli.Click += new System.EventHandler(this.btncadcli_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 463);
            this.Controls.Add(this.btnconcli);
            this.Controls.Add(this.btncadcli);
            this.Controls.Add(this.btnconvenda);
            this.Controls.Add(this.btnvender);
            this.Controls.Add(this.btnentraestoque);
            this.Controls.Add(this.btnconusu);
            this.Controls.Add(this.btnconprod);
            this.Controls.Add(this.btncadusu);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncadprod);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Indaya";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncadprod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Button btncadusu;
        private System.Windows.Forms.Button btnconprod;
        private System.Windows.Forms.Button btnconusu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Button btnconvenda;
        private System.Windows.Forms.Button btnvender;
        private System.Windows.Forms.Button btnentraestoque;
        private System.Windows.Forms.Button btnconcli;
        private System.Windows.Forms.Button btncadcli;
    }
}