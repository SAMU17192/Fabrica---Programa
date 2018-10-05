namespace WindowsFormsApplication2
{
    partial class Vendas
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbocliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.NumericUpDown();
            this.btnvender = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnpesquisa = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20F);
            this.label5.Location = new System.Drawing.Point(288, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "Venda de produto";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(548, 248);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(177, 20);
            this.txtvalor.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Escolha o cliente";
            // 
            // cbocliente
            // 
            this.cbocliente.FormattingEnabled = true;
            this.cbocliente.Location = new System.Drawing.Point(180, 296);
            this.cbocliente.Name = "cbocliente";
            this.cbocliente.Size = new System.Drawing.Size(163, 21);
            this.cbocliente.TabIndex = 25;
            this.cbocliente.SelectedIndexChanged += new System.EventHandler(this.cbocliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quantidade";
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(180, 249);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(163, 20);
            this.txtquantidade.TabIndex = 23;
            // 
            // btnvender
            // 
            this.btnvender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvender.Location = new System.Drawing.Point(341, 364);
            this.btnvender.Name = "btnvender";
            this.btnvender.Size = new System.Drawing.Size(101, 32);
            this.btnvender.TabIndex = 30;
            this.btnvender.Text = "Vender";
            this.btnvender.UseVisualStyleBackColor = true;
            this.btnvender.Click += new System.EventHandler(this.btnvender_Click);
            // 
            // txtnome
            // 
            this.txtnome.Enabled = false;
            this.txtnome.Location = new System.Drawing.Point(180, 199);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(163, 20);
            this.txtnome.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nome do produto";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Enabled = false;
            this.txtdescricao.Location = new System.Drawing.Point(548, 199);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(177, 20);
            this.txtdescricao.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Descrição";
            // 
            // btnpesquisa
            // 
            this.btnpesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisa.Location = new System.Drawing.Point(551, 127);
            this.btnpesquisa.Name = "btnpesquisa";
            this.btnpesquisa.Size = new System.Drawing.Size(101, 33);
            this.btnpesquisa.TabIndex = 38;
            this.btnpesquisa.Text = "Pesquisar";
            this.btnpesquisa.UseVisualStyleBackColor = true;
            this.btnpesquisa.Click += new System.EventHandler(this.btnpesquisa_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(279, 135);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(266, 20);
            this.txtpesquisa.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Código";
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(548, 297);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(177, 20);
            this.txtnota.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(478, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "N° Nota";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(408, 101);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(0, 18);
            this.lbldata.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(366, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "Data:";
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 424);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnpesquisa);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnvender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbocliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtquantidade);
            this.Name = "Vendas";
            this.Text = "Indaya";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtquantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbocliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtquantidade;
        private System.Windows.Forms.Button btnvender;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnpesquisa;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label label8;
    }
}