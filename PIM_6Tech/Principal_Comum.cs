using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_6Tech
{
    public partial class Principal_Comum : MaterialForm
    {
        public Principal_Comum()
        {
            //Inicialização do material skin
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-U33RJQE\SQLLEO;Initial Catalog=Banco_tech;Integrated Security=True");

        private void Folha_Pag_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarPag_Click(object sender, EventArgs e)
        {
            //botão para buscar os descontos e o salário líquido do funcionário
            conexao.Open();
            string matricula = matriculaPag.Text;
            string nome = txtNomePag.Text;
            string salarioBruto = txtSalarioPag.Text;
            string INSS = txtINSSPag.Text;
            string FGTS = txtFGTSPag.Text;
            string VT = txtVTPag.Text;
            string VR = txtVRPag.Text;
            string dataFolha = txtDataPag.Text;
            string salarioLiquido = txtSalarioLiqPag.Text;
            string queryp1 = "SELECT * FROM Funcionario WHERE Matricula = '" + matriculaPag.Text + "'";
            SqlDataAdapter dpp1 = new SqlDataAdapter(queryp1, conexao);
            DataTable dtp1 = new DataTable();
            dpp1.Fill(dtp1);
            txtNomePag.Text = dtp1.Rows[0]["Nome"].ToString();
            txtSalarioPag.Text = dtp1.Rows[0]["Salario_base"].ToString();
            SqlCommand crp1 = new SqlCommand(queryp1, conexao);
            SqlDataReader readerp1 = crp1.ExecuteReader();
            readerp1.Close();

            string queryp2 = "SELECT * FROM Pagamentos WHERE Matricula = @Matricula AND Data_ferias = @DataFerias";
            SqlDataAdapter dpp2 = new SqlDataAdapter(queryp2, conexao);
            dpp2.SelectCommand.Parameters.AddWithValue("@Matricula", matriculaPag.Text);
            dpp2.SelectCommand.Parameters.AddWithValue("@DataFerias", txtDataPag.Text);
            DataTable dtp2 = new DataTable();

            try
            {
                dpp2.Fill(dtp2);

                if (dtp2.Rows.Count > 0)
                {
                    txtINSSPag.Text = dtp2.Rows[0]["INSS_Func"].ToString();
                    txtFGTSPag.Text = dtp2.Rows[0]["FGTS_Func"].ToString();
                    txtVTPag.Text = dtp2.Rows[0]["VT_Func"].ToString();
                    txtVRPag.Text = dtp2.Rows[0]["VR_Func"].ToString();
                    txtSalarioLiqPag.Text = dtp2.Rows[0]["Salario_liq"].ToString();
                }
                else
                {
                    MessageBox.Show("Nenhum resultado encontrado para a Matrícula e Data informadas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void txtSalarioPag_TextChanged(object sender, EventArgs e)
        {

        }

        private void matriculaPag_Click(object sender, EventArgs e)
        {

        }

        private void txtDataPag_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();

        }
    }
}
