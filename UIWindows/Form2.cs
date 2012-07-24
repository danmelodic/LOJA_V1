using System;
using System.Windows.Forms;
using Loja.DAL;
using Loja.Modelos;

namespace Loja.UIWindows
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void validarButton_Click(object sender, EventArgs e)
        {
            LoginInformation login = new LoginInformation();
            login.NomeLogin = nomeTextBox.Text;
            login.Senha = senhaTextBox.Text;
            LoginDAL loginDal = new LoginDAL();

            Console.WriteLine(login.Senha);
            Console.WriteLine(login.NomeLogin);

            if (loginDal.verificaLogin(login))
            {
                MessageBox.Show("Passou");
            }
            else
            {              
                MessageBox.Show("Não Passou");
            }
        }

       
    }
}
