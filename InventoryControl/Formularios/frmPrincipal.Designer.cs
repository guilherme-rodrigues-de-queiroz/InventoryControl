namespace InventoryControl.Formularios
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelSaida = new System.Windows.Forms.Panel();
            this.btnSaida = new System.Windows.Forms.Button();
            this.panelEntrada = new System.Windows.Forms.Panel();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.divisorNav = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.divisor = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.totalProdutoCadastrados = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalSaidaProdutos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalEntradaProdutos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProduto1 = new System.Windows.Forms.Button();
            this.btnProduto2 = new System.Windows.Forms.Button();
            this.btnSaida1 = new System.Windows.Forms.Button();
            this.btnSaida2 = new System.Windows.Forms.Button();
            this.btnEntrada1 = new System.Windows.Forms.Button();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnEntrada2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelSaida.SuspendLayout();
            this.panelEntrada.SuspendLayout();
            this.panelProdutos.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.divisorNav.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panelSaida);
            this.panel1.Controls.Add(this.panelEntrada);
            this.panel1.Controls.Add(this.panelProdutos);
            this.panel1.Controls.Add(this.panelDashboard);
            this.panel1.Controls.Add(this.divisorNav);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 674);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSair);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 619);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 55);
            this.panel5.TabIndex = 9;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(15, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSair.Size = new System.Drawing.Size(220, 36);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelSaida
            // 
            this.panelSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelSaida.Controls.Add(this.btnSaida);
            this.panelSaida.Location = new System.Drawing.Point(15, 307);
            this.panelSaida.Name = "panelSaida";
            this.panelSaida.Size = new System.Drawing.Size(220, 43);
            this.panelSaida.TabIndex = 8;
            // 
            // btnSaida
            // 
            this.btnSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaida.FlatAppearance.BorderSize = 0;
            this.btnSaida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnSaida.Image")));
            this.btnSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaida.Location = new System.Drawing.Point(3, 0);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSaida.Size = new System.Drawing.Size(220, 43);
            this.btnSaida.TabIndex = 5;
            this.btnSaida.Text = "  Saída";
            this.btnSaida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaida.UseVisualStyleBackColor = false;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // panelEntrada
            // 
            this.panelEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelEntrada.Controls.Add(this.btnEntrada);
            this.panelEntrada.Location = new System.Drawing.Point(15, 241);
            this.panelEntrada.Name = "panelEntrada";
            this.panelEntrada.Size = new System.Drawing.Size(220, 43);
            this.panelEntrada.TabIndex = 7;
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrada.FlatAppearance.BorderSize = 0;
            this.btnEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrada.Image")));
            this.btnEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrada.Location = new System.Drawing.Point(3, 0);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEntrada.Size = new System.Drawing.Size(220, 43);
            this.btnEntrada.TabIndex = 4;
            this.btnEntrada.Text = "  Entrada";
            this.btnEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // panelProdutos
            // 
            this.panelProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelProdutos.Controls.Add(this.btnProdutos);
            this.panelProdutos.Location = new System.Drawing.Point(15, 175);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(220, 43);
            this.panelProdutos.TabIndex = 6;
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(3, 0);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProdutos.Size = new System.Drawing.Size(220, 43);
            this.btnProdutos.TabIndex = 3;
            this.btnProdutos.Text = "  Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(92)))), ((int)(((byte)(254)))));
            this.panelDashboard.Controls.Add(this.btnDashboard);
            this.panelDashboard.Location = new System.Drawing.Point(15, 109);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(220, 43);
            this.panelDashboard.TabIndex = 5;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(218, 43);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // divisorNav
            // 
            this.divisorNav.Controls.Add(this.panel3);
            this.divisorNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.divisorNav.Location = new System.Drawing.Point(0, 66);
            this.divisorNav.Name = "divisorNav";
            this.divisorNav.Size = new System.Drawing.Size(250, 25);
            this.divisorNav.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(15, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 1);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 66);
            this.panel2.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(30, 16);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(40, 40);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // divisor
            // 
            this.divisor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("divisor.BackgroundImage")));
            this.divisor.Dock = System.Windows.Forms.DockStyle.Left;
            this.divisor.Location = new System.Drawing.Point(250, 0);
            this.divisor.Name = "divisor";
            this.divisor.Size = new System.Drawing.Size(25, 674);
            this.divisor.TabIndex = 1;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.totalProdutoCadastrados);
            this.panelForm.Controls.Add(this.label8);
            this.panelForm.Controls.Add(this.totalSaidaProdutos);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.totalEntradaProdutos);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.btnProduto1);
            this.panelForm.Controls.Add(this.btnProduto2);
            this.panelForm.Controls.Add(this.btnSaida1);
            this.panelForm.Controls.Add(this.btnSaida2);
            this.panelForm.Controls.Add(this.btnEntrada1);
            this.panelForm.Controls.Add(this.lblDashboard);
            this.panelForm.Controls.Add(this.btnEntrada2);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(275, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1649, 674);
            this.panelForm.TabIndex = 2;
            // 
            // totalProdutoCadastrados
            // 
            this.totalProdutoCadastrados.AutoSize = true;
            this.totalProdutoCadastrados.BackColor = System.Drawing.Color.Transparent;
            this.totalProdutoCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProdutoCadastrados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalProdutoCadastrados.Location = new System.Drawing.Point(1249, 197);
            this.totalProdutoCadastrados.Name = "totalProdutoCadastrados";
            this.totalProdutoCadastrados.Size = new System.Drawing.Size(30, 32);
            this.totalProdutoCadastrados.TabIndex = 19;
            this.totalProdutoCadastrados.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.label8.Location = new System.Drawing.Point(1250, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "PRODUTOS CADASTRADOS";
            // 
            // totalSaidaProdutos
            // 
            this.totalSaidaProdutos.AutoSize = true;
            this.totalSaidaProdutos.BackColor = System.Drawing.Color.Transparent;
            this.totalSaidaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSaidaProdutos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalSaidaProdutos.Location = new System.Drawing.Point(685, 199);
            this.totalSaidaProdutos.Name = "totalSaidaProdutos";
            this.totalSaidaProdutos.Size = new System.Drawing.Size(30, 32);
            this.totalSaidaProdutos.TabIndex = 15;
            this.totalSaidaProdutos.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(686, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "SAÍDA DE PRODUTOS";
            // 
            // totalEntradaProdutos
            // 
            this.totalEntradaProdutos.AutoSize = true;
            this.totalEntradaProdutos.BackColor = System.Drawing.Color.Transparent;
            this.totalEntradaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEntradaProdutos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalEntradaProdutos.Location = new System.Drawing.Point(109, 197);
            this.totalEntradaProdutos.Name = "totalEntradaProdutos";
            this.totalEntradaProdutos.Size = new System.Drawing.Size(30, 32);
            this.totalEntradaProdutos.TabIndex = 13;
            this.totalEntradaProdutos.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(110, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "ENTRADA DE PRODUTOS";
            // 
            // btnProduto1
            // 
            this.btnProduto1.BackColor = System.Drawing.Color.White;
            this.btnProduto1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnProduto1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnProduto1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProduto1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto1.Location = new System.Drawing.Point(1216, 109);
            this.btnProduto1.Name = "btnProduto1";
            this.btnProduto1.Size = new System.Drawing.Size(477, 211);
            this.btnProduto1.TabIndex = 10;
            this.btnProduto1.UseVisualStyleBackColor = false;
            // 
            // btnProduto2
            // 
            this.btnProduto2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnProduto2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnProduto2.FlatAppearance.BorderSize = 0;
            this.btnProduto2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnProduto2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnProduto2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto2.Location = new System.Drawing.Point(1205, 109);
            this.btnProduto2.Name = "btnProduto2";
            this.btnProduto2.Size = new System.Drawing.Size(477, 211);
            this.btnProduto2.TabIndex = 11;
            this.btnProduto2.UseVisualStyleBackColor = false;
            // 
            // btnSaida1
            // 
            this.btnSaida1.BackColor = System.Drawing.Color.White;
            this.btnSaida1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSaida1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSaida1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSaida1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaida1.Location = new System.Drawing.Point(655, 111);
            this.btnSaida1.Name = "btnSaida1";
            this.btnSaida1.Size = new System.Drawing.Size(477, 211);
            this.btnSaida1.TabIndex = 6;
            this.btnSaida1.UseVisualStyleBackColor = false;
            // 
            // btnSaida2
            // 
            this.btnSaida2.BackColor = System.Drawing.Color.IndianRed;
            this.btnSaida2.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnSaida2.FlatAppearance.BorderSize = 0;
            this.btnSaida2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSaida2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnSaida2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaida2.Location = new System.Drawing.Point(644, 111);
            this.btnSaida2.Name = "btnSaida2";
            this.btnSaida2.Size = new System.Drawing.Size(488, 211);
            this.btnSaida2.TabIndex = 7;
            this.btnSaida2.UseVisualStyleBackColor = false;
            // 
            // btnEntrada1
            // 
            this.btnEntrada1.BackColor = System.Drawing.Color.White;
            this.btnEntrada1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEntrada1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEntrada1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEntrada1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada1.Location = new System.Drawing.Point(85, 109);
            this.btnEntrada1.Name = "btnEntrada1";
            this.btnEntrada1.Size = new System.Drawing.Size(477, 211);
            this.btnEntrada1.TabIndex = 1;
            this.btnEntrada1.UseVisualStyleBackColor = false;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(42, 16);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(233, 51);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // btnEntrada2
            // 
            this.btnEntrada2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnEntrada2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnEntrada2.FlatAppearance.BorderSize = 0;
            this.btnEntrada2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnEntrada2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnEntrada2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada2.Location = new System.Drawing.Point(74, 109);
            this.btnEntrada2.Name = "btnEntrada2";
            this.btnEntrada2.Size = new System.Drawing.Size(477, 211);
            this.btnEntrada2.TabIndex = 5;
            this.btnEntrada2.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 674);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.divisor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTORY CONTROL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelSaida.ResumeLayout(false);
            this.panelEntrada.ResumeLayout(false);
            this.panelProdutos.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.divisorNav.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Panel divisorNav;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panelSaida;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Panel panelEntrada;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel divisor;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button btnEntrada1;
        private System.Windows.Forms.Button btnEntrada2;
        private System.Windows.Forms.Button btnProduto1;
        private System.Windows.Forms.Button btnProduto2;
        private System.Windows.Forms.Button btnSaida1;
        private System.Windows.Forms.Button btnSaida2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalProdutoCadastrados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalSaidaProdutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalEntradaProdutos;
    }
}