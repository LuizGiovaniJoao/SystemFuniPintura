namespace SystemFunipintura
{
    partial class ListaClientes
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
            this.txt_CpfCnpj = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.listView_Clientes = new System.Windows.Forms.ListView();
            this.bt_Remover = new System.Windows.Forms.Button();
            this.bt_Alterar = new System.Windows.Forms.Button();
            this.bt_Adicionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_CpfCnpj
            // 
            this.txt_CpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CpfCnpj.Location = new System.Drawing.Point(6, 17);
            this.txt_CpfCnpj.Name = "txt_CpfCnpj";
            this.txt_CpfCnpj.Size = new System.Drawing.Size(305, 38);
            this.txt_CpfCnpj.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Location = new System.Drawing.Point(364, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NOME";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_CpfCnpj);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 61);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPF/CNPJ";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(6, 35);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(841, 20);
            this.txt_Nome.TabIndex = 4;
            // 
            // listView_Clientes
            // 
            this.listView_Clientes.Location = new System.Drawing.Point(12, 79);
            this.listView_Clientes.Name = "listView_Clientes";
            this.listView_Clientes.Size = new System.Drawing.Size(1223, 506);
            this.listView_Clientes.TabIndex = 4;
            this.listView_Clientes.UseCompatibleStateImageBehavior = false;
            // 
            // bt_Remover
            // 
            this.bt_Remover.Location = new System.Drawing.Point(998, 591);
            this.bt_Remover.Name = "bt_Remover";
            this.bt_Remover.Size = new System.Drawing.Size(75, 23);
            this.bt_Remover.TabIndex = 5;
            this.bt_Remover.Text = "Remover";
            this.bt_Remover.UseVisualStyleBackColor = true;
            // 
            // bt_Alterar
            // 
            this.bt_Alterar.Location = new System.Drawing.Point(1079, 591);
            this.bt_Alterar.Name = "bt_Alterar";
            this.bt_Alterar.Size = new System.Drawing.Size(75, 23);
            this.bt_Alterar.TabIndex = 6;
            this.bt_Alterar.Text = "Alterar";
            this.bt_Alterar.UseVisualStyleBackColor = true;
            // 
            // bt_Adicionar
            // 
            this.bt_Adicionar.Location = new System.Drawing.Point(1160, 591);
            this.bt_Adicionar.Name = "bt_Adicionar";
            this.bt_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.bt_Adicionar.TabIndex = 7;
            this.bt_Adicionar.Text = "Adicionar";
            this.bt_Adicionar.UseVisualStyleBackColor = true;
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 621);
            this.Controls.Add(this.bt_Adicionar);
            this.Controls.Add(this.bt_Alterar);
            this.Controls.Add(this.bt_Remover);
            this.Controls.Add(this.listView_Clientes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListaClientes";
            this.Text = "ListaClientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CpfCnpj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView_Clientes;
        private System.Windows.Forms.Button bt_Remover;
        private System.Windows.Forms.Button bt_Alterar;
        private System.Windows.Forms.Button bt_Adicionar;
    }
}