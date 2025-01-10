namespace InventoryControl.Formularios
{
    partial class frmEditProduto
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
            this.numTotalEstoque = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtPosicao = new System.Windows.Forms.TextBox();
            this.txtPrateleira = new System.Windows.Forms.TextBox();
            this.txtEstante = new System.Windows.Forms.TextBox();
            this.txtCorredor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEditProdutos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // numTotalEstoque
            // 
            this.numTotalEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTotalEstoque.Location = new System.Drawing.Point(79, 244);
            this.numTotalEstoque.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTotalEstoque.Name = "numTotalEstoque";
            this.numTotalEstoque.Size = new System.Drawing.Size(641, 34);
            this.numTotalEstoque.TabIndex = 37;
            this.numTotalEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(-21, 556);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(847, 1);
            this.panel4.TabIndex = 26;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.Location = new System.Drawing.Point(432, 584);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(164, 46);
            this.btnFechar.TabIndex = 36;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Green;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(618, 584);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(164, 46);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtPosicao
            // 
            this.txtPosicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPosicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtPosicao.Location = new System.Drawing.Point(473, 480);
            this.txtPosicao.Multiline = true;
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.Size = new System.Drawing.Size(247, 37);
            this.txtPosicao.TabIndex = 34;
            // 
            // txtPrateleira
            // 
            this.txtPrateleira.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrateleira.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtPrateleira.Location = new System.Drawing.Point(473, 387);
            this.txtPrateleira.Multiline = true;
            this.txtPrateleira.Name = "txtPrateleira";
            this.txtPrateleira.Size = new System.Drawing.Size(247, 37);
            this.txtPrateleira.TabIndex = 33;
            // 
            // txtEstante
            // 
            this.txtEstante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstante.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtEstante.Location = new System.Drawing.Point(79, 480);
            this.txtEstante.Multiline = true;
            this.txtEstante.Name = "txtEstante";
            this.txtEstante.Size = new System.Drawing.Size(247, 37);
            this.txtEstante.TabIndex = 32;
            // 
            // txtCorredor
            // 
            this.txtCorredor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorredor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtCorredor.Location = new System.Drawing.Point(79, 387);
            this.txtCorredor.Multiline = true;
            this.txtCorredor.Name = "txtCorredor";
            this.txtCorredor.Size = new System.Drawing.Size(247, 37);
            this.txtCorredor.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Posição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Prateleira";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Estante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Corredor";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(37, 325);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(732, 1);
            this.panel3.TabIndex = 25;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(79, 155);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(641, 37);
            this.txtNome.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Quantidade em Estoque do Produto*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome do produto*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 1);
            this.panel2.TabIndex = 21;
            // 
            // lblEditProdutos
            // 
            this.lblEditProdutos.AutoSize = true;
            this.lblEditProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditProdutos.Location = new System.Drawing.Point(31, 30);
            this.lblEditProdutos.Name = "lblEditProdutos";
            this.lblEditProdutos.Size = new System.Drawing.Size(219, 32);
            this.lblEditProdutos.TabIndex = 19;
            this.lblEditProdutos.Text = "Alterar Produtos";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 71);
            this.panel1.TabIndex = 20;
            // 
            // frmEditProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 639);
            this.Controls.Add(this.numTotalEstoque);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPosicao);
            this.Controls.Add(this.txtPrateleira);
            this.Controls.Add(this.txtEstante);
            this.Controls.Add(this.txtCorredor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblEditProdutos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditProduto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditProduto_FormClosed);
            this.Load += new System.EventHandler(this.frmEditProduto_Load);
            this.Shown += new System.EventHandler(this.frmEditProduto_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numTotalEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTotalEstoque;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtPosicao;
        private System.Windows.Forms.TextBox txtPrateleira;
        private System.Windows.Forms.TextBox txtEstante;
        private System.Windows.Forms.TextBox txtCorredor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEditProdutos;
        private System.Windows.Forms.Panel panel1;
    }
}