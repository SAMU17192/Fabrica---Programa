namespace WindowsFormsApplication2
{
    partial class ConCli
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnpesquisa = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            this.codigoproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(383, 416);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 33);
            this.button4.TabIndex = 34;
            this.button4.Text = "Voltar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(261, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 33);
            this.button3.TabIndex = 33;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 32;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnpesquisa
            // 
            this.btnpesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisa.Location = new System.Drawing.Point(436, 144);
            this.btnpesquisa.Name = "btnpesquisa";
            this.btnpesquisa.Size = new System.Drawing.Size(101, 33);
            this.btnpesquisa.TabIndex = 31;
            this.btnpesquisa.Text = "Pesquisar";
            this.btnpesquisa.UseVisualStyleBackColor = true;
            this.btnpesquisa.Click += new System.EventHandler(this.btnpesquisa_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(164, 152);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(266, 20);
            this.txtpesquisa.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Pesquisa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20F);
            this.label4.Location = new System.Drawing.Point(176, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "Consulta de clientes";
            // 
            // dgvclientes
            // 
            this.dgvclientes.AllowUserToAddRows = false;
            this.dgvclientes.AllowUserToDeleteRows = false;
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoproduto,
            this.nomeproduto});
            this.dgvclientes.Location = new System.Drawing.Point(189, 213);
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.ReadOnly = true;
            this.dgvclientes.Size = new System.Drawing.Size(254, 156);
            this.dgvclientes.TabIndex = 38;
            // 
            // codigoproduto
            // 
            this.codigoproduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigoproduto.HeaderText = "Código";
            this.codigoproduto.Name = "codigoproduto";
            this.codigoproduto.ReadOnly = true;
            // 
            // nomeproduto
            // 
            this.nomeproduto.HeaderText = "Nome";
            this.nomeproduto.Name = "nomeproduto";
            this.nomeproduto.ReadOnly = true;
            // 
            // ConCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 468);
            this.Controls.Add(this.dgvclientes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnpesquisa);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "ConCli";
            this.Text = "Indaya";
            this.Load += new System.EventHandler(this.ConCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnpesquisa;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvclientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeproduto;
    }
}