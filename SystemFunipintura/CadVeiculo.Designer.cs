﻿namespace SystemFunipintura
{
    partial class CadVeiculo
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
            this.txt_Placa = new System.Windows.Forms.TextBox();
            this.txt_Tipo = new System.Windows.Forms.TextBox();
            this.txt_Chassis = new System.Windows.Forms.TextBox();
            this.txt_Ano = new System.Windows.Forms.TextBox();
            this.txt_OBS = new System.Windows.Forms.TextBox();
            this.label_Placa = new System.Windows.Forms.Label();
            this.label_Tipo = new System.Windows.Forms.Label();
            this.label_Chassis = new System.Windows.Forms.Label();
            this.label_Ano = new System.Windows.Forms.Label();
            this.label_OBS = new System.Windows.Forms.Label();
            this.label8_Marca = new System.Windows.Forms.Label();
            this.cbx_Marca = new System.Windows.Forms.ComboBox();
            this.label_Cor = new System.Windows.Forms.Label();
            this.txt_Cor = new System.Windows.Forms.TextBox();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_Gravar = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.txt_Proprietario = new System.Windows.Forms.TextBox();
            this.bt_Pesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Placa
            // 
            this.txt_Placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Placa.Location = new System.Drawing.Point(12, 64);
            this.txt_Placa.Name = "txt_Placa";
            this.txt_Placa.Size = new System.Drawing.Size(89, 20);
            this.txt_Placa.TabIndex = 0;
            this.txt_Placa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.Location = new System.Drawing.Point(12, 103);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Size = new System.Drawing.Size(490, 20);
            this.txt_Tipo.TabIndex = 1;
            // 
            // txt_Chassis
            // 
            this.txt_Chassis.Location = new System.Drawing.Point(107, 64);
            this.txt_Chassis.Name = "txt_Chassis";
            this.txt_Chassis.Size = new System.Drawing.Size(136, 20);
            this.txt_Chassis.TabIndex = 2;
            // 
            // txt_Ano
            // 
            this.txt_Ano.Location = new System.Drawing.Point(12, 142);
            this.txt_Ano.Name = "txt_Ano";
            this.txt_Ano.Size = new System.Drawing.Size(53, 20);
            this.txt_Ano.TabIndex = 3;
            // 
            // txt_OBS
            // 
            this.txt_OBS.Location = new System.Drawing.Point(12, 181);
            this.txt_OBS.Multiline = true;
            this.txt_OBS.Name = "txt_OBS";
            this.txt_OBS.Size = new System.Drawing.Size(490, 151);
            this.txt_OBS.TabIndex = 4;
            // 
            // label_Placa
            // 
            this.label_Placa.AutoSize = true;
            this.label_Placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_Placa.Location = new System.Drawing.Point(9, 48);
            this.label_Placa.Name = "label_Placa";
            this.label_Placa.Size = new System.Drawing.Size(34, 13);
            this.label_Placa.TabIndex = 6;
            this.label_Placa.Text = "Placa";
            // 
            // label_Tipo
            // 
            this.label_Tipo.AutoSize = true;
            this.label_Tipo.Location = new System.Drawing.Point(9, 87);
            this.label_Tipo.Name = "label_Tipo";
            this.label_Tipo.Size = new System.Drawing.Size(28, 13);
            this.label_Tipo.TabIndex = 7;
            this.label_Tipo.Text = "Tipo";
            // 
            // label_Chassis
            // 
            this.label_Chassis.AutoSize = true;
            this.label_Chassis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_Chassis.Location = new System.Drawing.Point(104, 48);
            this.label_Chassis.Name = "label_Chassis";
            this.label_Chassis.Size = new System.Drawing.Size(43, 13);
            this.label_Chassis.TabIndex = 8;
            this.label_Chassis.Text = "Chassis";
            // 
            // label_Ano
            // 
            this.label_Ano.AutoSize = true;
            this.label_Ano.Location = new System.Drawing.Point(9, 126);
            this.label_Ano.Name = "label_Ano";
            this.label_Ano.Size = new System.Drawing.Size(26, 13);
            this.label_Ano.TabIndex = 9;
            this.label_Ano.Text = "Ano";
            this.label_Ano.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_OBS
            // 
            this.label_OBS.AutoSize = true;
            this.label_OBS.Location = new System.Drawing.Point(9, 165);
            this.label_OBS.Name = "label_OBS";
            this.label_OBS.Size = new System.Drawing.Size(32, 13);
            this.label_OBS.TabIndex = 10;
            this.label_OBS.Text = "OBS:";
            // 
            // label8_Marca
            // 
            this.label8_Marca.AutoSize = true;
            this.label8_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8_Marca.Location = new System.Drawing.Point(246, 47);
            this.label8_Marca.Name = "label8_Marca";
            this.label8_Marca.Size = new System.Drawing.Size(37, 13);
            this.label8_Marca.TabIndex = 13;
            this.label8_Marca.Text = "Marca";
            this.label8_Marca.Click += new System.EventHandler(this.label8_Click);
            // 
            // cbx_Marca
            // 
            this.cbx_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Marca.FormattingEnabled = true;
            this.cbx_Marca.Items.AddRange(new object[] {
            "Agrale",
            "Alfa",
            "Romeo",
            "Audi",
            "BMW",
            "Cadillac",
            "CBT",
            "Chevrolet",
            "Citroën",
            "Dodge",
            "Ferrari",
            "Fiat",
            "Ford",
            "Honda",
            "Hyundai",
            "Jaguar",
            "KIA",
            "Lamborghini",
            "Mazda",
            "Mercedes Benz",
            "Mitsubishi",
            "Nissan",
            "Peugeot",
            "Renault",
            "Toyota",
            "Volkswagen"});
            this.cbx_Marca.Location = new System.Drawing.Point(249, 63);
            this.cbx_Marca.Name = "cbx_Marca";
            this.cbx_Marca.Size = new System.Drawing.Size(253, 21);
            this.cbx_Marca.TabIndex = 14;
            this.cbx_Marca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_Cor
            // 
            this.label_Cor.AutoSize = true;
            this.label_Cor.Location = new System.Drawing.Point(69, 126);
            this.label_Cor.Name = "label_Cor";
            this.label_Cor.Size = new System.Drawing.Size(23, 13);
            this.label_Cor.TabIndex = 15;
            this.label_Cor.Text = "Cor";
            // 
            // txt_Cor
            // 
            this.txt_Cor.Location = new System.Drawing.Point(71, 142);
            this.txt_Cor.Name = "txt_Cor";
            this.txt_Cor.Size = new System.Drawing.Size(431, 20);
            this.txt_Cor.TabIndex = 16;
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(265, 338);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_Limpar.TabIndex = 17;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            // 
            // bt_Gravar
            // 
            this.bt_Gravar.Location = new System.Drawing.Point(346, 338);
            this.bt_Gravar.Name = "bt_Gravar";
            this.bt_Gravar.Size = new System.Drawing.Size(75, 23);
            this.bt_Gravar.TabIndex = 18;
            this.bt_Gravar.Text = "Gravar";
            this.bt_Gravar.UseVisualStyleBackColor = true;
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.Location = new System.Drawing.Point(427, 338);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bt_Cadastrar.TabIndex = 19;
            this.bt_Cadastrar.Text = "Cadastrar";
            this.bt_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // txt_Proprietario
            // 
            this.txt_Proprietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Proprietario.Location = new System.Drawing.Point(12, 25);
            this.txt_Proprietario.Name = "txt_Proprietario";
            this.txt_Proprietario.Size = new System.Drawing.Size(409, 20);
            this.txt_Proprietario.TabIndex = 20;
            // 
            // bt_Pesquisar
            // 
            this.bt_Pesquisar.Location = new System.Drawing.Point(427, 23);
            this.bt_Pesquisar.Name = "bt_Pesquisar";
            this.bt_Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.bt_Pesquisar.TabIndex = 21;
            this.bt_Pesquisar.Text = "Pesquisar";
            this.bt_Pesquisar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Propriétário";
            // 
            // CadVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Pesquisar);
            this.Controls.Add(this.txt_Proprietario);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.bt_Gravar);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.txt_Cor);
            this.Controls.Add(this.label_Cor);
            this.Controls.Add(this.cbx_Marca);
            this.Controls.Add(this.label8_Marca);
            this.Controls.Add(this.label_OBS);
            this.Controls.Add(this.label_Ano);
            this.Controls.Add(this.label_Chassis);
            this.Controls.Add(this.label_Tipo);
            this.Controls.Add(this.label_Placa);
            this.Controls.Add(this.txt_OBS);
            this.Controls.Add(this.txt_Ano);
            this.Controls.Add(this.txt_Chassis);
            this.Controls.Add(this.txt_Tipo);
            this.Controls.Add(this.txt_Placa);
            this.Name = "CadVeiculo";
            this.Text = "Dados do Veículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Placa;
        private System.Windows.Forms.TextBox txt_Tipo;
        private System.Windows.Forms.TextBox txt_Chassis;
        private System.Windows.Forms.TextBox txt_Ano;
        private System.Windows.Forms.TextBox txt_OBS;
        private System.Windows.Forms.Label label_Placa;
        private System.Windows.Forms.Label label_Tipo;
        private System.Windows.Forms.Label label_Chassis;
        private System.Windows.Forms.Label label_Ano;
        private System.Windows.Forms.Label label_OBS;
        private System.Windows.Forms.Label label8_Marca;
        private System.Windows.Forms.ComboBox cbx_Marca;
        private System.Windows.Forms.Label label_Cor;
        private System.Windows.Forms.TextBox txt_Cor;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.Button bt_Gravar;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.TextBox txt_Proprietario;
        private System.Windows.Forms.Button bt_Pesquisar;
        private System.Windows.Forms.Label label1;
    }
}