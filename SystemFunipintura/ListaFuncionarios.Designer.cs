﻿namespace SystemFunipintura
{
    partial class ListaFuncionarios
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
            this.txt_CpfCodigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_NomeApelido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView_Funcionarios = new System.Windows.Forms.ListView();
            this.bt_Adicionar = new System.Windows.Forms.Button();
            this.bt_Alterar = new System.Windows.Forms.Button();
            this.bt_Remover = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_CpfCodigo
            // 
            this.txt_CpfCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CpfCodigo.Location = new System.Drawing.Point(6, 17);
            this.txt_CpfCodigo.Name = "txt_CpfCodigo";
            this.txt_CpfCodigo.Size = new System.Drawing.Size(305, 38);
            this.txt_CpfCodigo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_CpfCodigo);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPF/CÓDIGO";
            // 
            // txt_NomeApelido
            // 
            this.txt_NomeApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeApelido.Location = new System.Drawing.Point(6, 29);
            this.txt_NomeApelido.Name = "txt_NomeApelido";
            this.txt_NomeApelido.Size = new System.Drawing.Size(600, 26);
            this.txt_NomeApelido.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_NomeApelido);
            this.groupBox1.Location = new System.Drawing.Point(364, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NOME/APELIDO";
            // 
            // listView_Funcionarios
            // 
            this.listView_Funcionarios.Location = new System.Drawing.Point(12, 79);
            this.listView_Funcionarios.Name = "listView_Funcionarios";
            this.listView_Funcionarios.Size = new System.Drawing.Size(985, 524);
            this.listView_Funcionarios.TabIndex = 6;
            this.listView_Funcionarios.UseCompatibleStateImageBehavior = false;
            // 
            // bt_Adicionar
            // 
            this.bt_Adicionar.Location = new System.Drawing.Point(923, 609);
            this.bt_Adicionar.Name = "bt_Adicionar";
            this.bt_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.bt_Adicionar.TabIndex = 10;
            this.bt_Adicionar.Text = "Adicionar";
            this.bt_Adicionar.UseVisualStyleBackColor = true;
            // 
            // bt_Alterar
            // 
            this.bt_Alterar.Location = new System.Drawing.Point(842, 609);
            this.bt_Alterar.Name = "bt_Alterar";
            this.bt_Alterar.Size = new System.Drawing.Size(75, 23);
            this.bt_Alterar.TabIndex = 9;
            this.bt_Alterar.Text = "Alterar";
            this.bt_Alterar.UseVisualStyleBackColor = true;
            // 
            // bt_Remover
            // 
            this.bt_Remover.Location = new System.Drawing.Point(761, 609);
            this.bt_Remover.Name = "bt_Remover";
            this.bt_Remover.Size = new System.Drawing.Size(75, 23);
            this.bt_Remover.TabIndex = 8;
            this.bt_Remover.Text = "Remover";
            this.bt_Remover.UseVisualStyleBackColor = true;
            // 
            // ListaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 639);
            this.Controls.Add(this.bt_Adicionar);
            this.Controls.Add(this.bt_Alterar);
            this.Controls.Add(this.bt_Remover);
            this.Controls.Add(this.listView_Funcionarios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ListaFuncionarios";
            this.Text = "ListaFuncionarios";
            this.Load += new System.EventHandler(this.ListaFuncionarios_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CpfCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_NomeApelido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView_Funcionarios;
        private System.Windows.Forms.Button bt_Adicionar;
        private System.Windows.Forms.Button bt_Alterar;
        private System.Windows.Forms.Button bt_Remover;
    }
}