using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02
{
    public partial class Frm_Main : Form
    {

        private Contato contato = new Contato();
        private Contatos agenda = new Contatos();
        private Data data = new Data();
        private DateTime dt = new DateTime();
        private string msg;

        public Frm_Main()
        {
            InitializeComponent();
        }
        
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            txt_Email.ResetText();
            txt_Nome.ResetText();
            mtx_Nasc.ResetText();
            mtx_Tel.ResetText();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            contato.Email = txt_Email.Text;

            contato = agenda.pesquisar(contato);

            if (contato == null)
            {
                dt = DateTime.Parse(mtx_Nasc.Text);

                data.setData(dt.Day, dt.Month, dt.Year);

                contato = new Contato(txt_Email.Text, txt_Nome.Text, mtx_Tel.Text, data);

                if (agenda.adicionar(contato))
                    msg = "Contato adicionado!";
                else
                    msg = "Contato não adicionado!";
            }
            else
            {
                contato.Email = txt_Email.Text;
                contato.Nome = txt_Nome.Text;
                contato.Telefone = mtx_Tel.Text;


                msg = (agenda.alterar(contato) ? "Contato alterado!" : "Contato não alterado!");
            }

            MessageBox.Show(msg, msg, MessageBoxButtons.OK, MessageBoxIcon.Information);

            btn_Novo.PerformClick();
            btn_Listar.PerformClick();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            contato.Email = txt_Email.Text;

            contato = agenda.pesquisar(contato);

            if (contato != null)
            {
                agenda.remover(contato);

                msg = "Contato removido!";
            }
            else
                msg = "Contato não localizado!";

            MessageBox.Show(msg, msg, MessageBoxButtons.OK, MessageBoxIcon.Information);

            btn_Novo.PerformClick();
            btn_Listar.PerformClick();
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            lst_Agenda.Items.Clear();

            foreach (Contato c in agenda.Agenda)
            {
                lst_Agenda.Items.Add(c.ToString());
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (txt_Email.Text != "")
            {
                btn_Gravar.Enabled = true;
                btn_Excluir.Enabled = true;
            }
            else
            {
                btn_Gravar.Enabled = false;
                btn_Excluir.Enabled = false;
            }
        }
    }
}
