using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Loja.Modelos;
using Loja.DAL;
using Loja.BLL;
using System.Data.SqlClient;

namespace Loja.UIWindows
{
    public partial class UsrLogin : Form
    {
        public UsrLogin()
        {
            InitializeComponent();
            dtgvr_ListarUsuario.Enabled = false;


        }       

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Atualizar_Click(object sender, EventArgs e)
        {
            dtgvr_ListarUsuario.Enabled = true;
            LoginDAL lgdal = new LoginDAL();
            dtgvr_ListarUsuario.DataSource = lgdal.AtualizarUsuarioInserir(txtb_Filtro.Text);          
        }

        private void bt_Ok_Click_1(object sender, System.EventArgs e)
        {
            try
            {
                LoginInformation lg = new LoginInformation();

                lg.NomeLogin = txtb_Nome.Text;
                lg.Senha = txtb_Senha1.Text;
                lg.Rsenha = txtb_Senha2.Text;

                LoginBLL lgbll = new LoginBLL();
                lgbll.Incluir(lg);
                MessageBox.Show("Usuário incluído com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void FiltroAtButton_Click(object sender, System.EventArgs e)
        {
            LoginBLL lgbll = new LoginBLL();
            dataGridView1.DataSource = lgbll.Listagem(textBox4.Text);
        }

        private void dataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            IDAtTextBox.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            NomeAtTextBox.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            senhaAtTextBox.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
        }

        private void salvarAtButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                LoginInformation login = new LoginInformation();
                login.NomeLogin = NomeAtTextBox.Text;
                login.Senha = senhaAtTextBox.Text;
                login.IdLogin = Convert.ToInt32(IDAtTextBox.Text);

                LoginBLL lgbll = new LoginBLL();
                lgbll.Alterar(login);
                MessageBox.Show("Usuário alterado com sucesso !");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void ExcluirButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                LoginBLL lgBLL = new LoginBLL();
                lgBLL.Deletar(IDDelTextBox.Text);
                MessageBox.Show("Excluido com sucesso");
                LoginBLL lgbll = new LoginBLL();
                string vazio = "";
                dataGridView2.DataSource = lgbll.Listagem(vazio);
            }
             
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void AtualizarButton_Click(object sender, System.EventArgs e)
        {
            LoginBLL lgbll = new LoginBLL();
            string vazio = "";
            dataGridView2.DataSource = lgbll.Listagem(vazio);
        }
            
        }    
    }


