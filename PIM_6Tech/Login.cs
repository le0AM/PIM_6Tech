using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PIM_6Tech
{
    public partial class Login : MaterialForm
    {

        public Login()
        {
            InitializeComponent();
            txtMatricula.Select();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }
        // string de conexão com o banco de dados
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-U33RJQE\SQLLEO;Initial Catalog=Banco_tech;Integrated Security=True");
        
        // Verifico se os campos estão vazios
        void Verificar()
        {
            if (txtMatricula.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Select();
            }

        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        // botão de entrar com a lógica de verificação de usuário
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            conexao.Open();
            String matricula = txtMatricula.Text;
            String senha = txtSenha.Text;

            // faz a consulta com o banco de dados
            
            string query = "SELECT tipo_usuario FROM Login_Func WHERE Matricula = @matricula AND Senha = @senha";
            //Abre a conexão com o banco de dados
            
             
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@matricula", matricula);
            cmd.Parameters.AddWithValue("@senha", senha);


            object userType = cmd.ExecuteScalar(); // Obtém o tipo de usuário

                if (userType != null)
                {
                    if (userType.ToString() == "Comum")
                    {
                        Principal_Comum frmComum = new Principal_Comum();
                        this.Hide();
                        frmComum.Show();
                        // Redirecione para a tela de usuário comum
                        MessageBox.Show("Login bem-sucedido como usuário comum.");
                    }


                    else if (userType.ToString() == "ADM")
                    {

                        Principal principal = new Principal();
                        this.Hide();
                        principal.Show();
                        // Redirecione para a tela de administrador
                        MessageBox.Show("Login bem-sucedido como administrador.");
                    }
                    conexao.Close();
                
                /* conexao.Open();
                 Verificar();
                 string query = "SELECT * FROM Funcionario WHERE Matricula = '" + txtMatricula.Text + "' AND Senha = '" + txtSenha.Text + "'";
                 SqlDataAdapter dp = new SqlDataAdapter(query, conexao);
                 DataTable dt = new DataTable();
                 dp.Fill(dt);
                 // CRIAR UM IF PARA SE O QUERRY2 FOIR VERDADEIRO IR PARA PAGINA DE USUARIO 


                 try
                 {
                     if (dt.Rows.Count == 1)
                     {

                           Principal frmprincipal = new Principal();
                           this.Hide();
                           frmprincipal.Show();
                           conexao.Close();
                     }
                 }
                 catch (Exception erro)
                 {


                     MessageBox.Show("Matricula ou Senha incorreta" + erro);
                     txtMatricula.Text = "";
                     txtSenha.Text = "";
                     txtMatricula.Select();
                 }
                 conexao.Close();*/
            }


        }
    }
}


