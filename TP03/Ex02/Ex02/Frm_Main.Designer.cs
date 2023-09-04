namespace Ex02
{
    partial class Frm_Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtx_Tel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtx_Nasc = new System.Windows.Forms.MaskedTextBox();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.lst_Agenda = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(85, 11);
            this.txt_Email.MaxLength = 60;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(249, 20);
            this.txt_Email.TabIndex = 1;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(85, 37);
            this.txt_Nome.MaxLength = 60;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(249, 20);
            this.txt_Nome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone:";
            // 
            // mtx_Tel
            // 
            this.mtx_Tel.Location = new System.Drawing.Point(85, 63);
            this.mtx_Tel.Mask = "(99) 00000-0000";
            this.mtx_Tel.Name = "mtx_Tel";
            this.mtx_Tel.Size = new System.Drawing.Size(87, 20);
            this.mtx_Tel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nascimento:";
            // 
            // mtx_Nasc
            // 
            this.mtx_Nasc.Location = new System.Drawing.Point(247, 63);
            this.mtx_Nasc.Mask = "00/00/0000";
            this.mtx_Nasc.Name = "mtx_Nasc";
            this.mtx_Nasc.Size = new System.Drawing.Size(87, 20);
            this.mtx_Nasc.TabIndex = 7;
            this.mtx_Nasc.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(16, 89);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 8;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Enabled = false;
            this.btn_Gravar.Location = new System.Drawing.Point(97, 89);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_Gravar.TabIndex = 9;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.Location = new System.Drawing.Point(178, 89);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 10;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(259, 89);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(75, 23);
            this.btn_Listar.TabIndex = 11;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // lst_Agenda
            // 
            this.lst_Agenda.FormattingEnabled = true;
            this.lst_Agenda.Location = new System.Drawing.Point(12, 118);
            this.lst_Agenda.Name = "lst_Agenda";
            this.lst_Agenda.Size = new System.Drawing.Size(322, 147);
            this.lst_Agenda.TabIndex = 12;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 279);
            this.Controls.Add(this.lst_Agenda);
            this.Controls.Add(this.btn_Listar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.mtx_Nasc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtx_Tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtx_Tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtx_Nasc;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.ListBox lst_Agenda;
    }
}

