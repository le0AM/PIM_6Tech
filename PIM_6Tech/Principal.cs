using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_6Tech
{
    public partial class Principal : MaterialForm
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-U33RJQE\SQLLEO;Initial Catalog=Banco_tech;Integrated Security=True");

        public Principal()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtSalario.Text == "")
            {
                MessageBox.Show("O Campo salario é obrigatório", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
            }
            else
            {
                double salario = Convert.ToDouble(txtSalario.Text);
                double inss = 0.07;
                double fgts = 0.08;
                double vt = 0.06;
                double vr = 0.05;
                double salarioLiquido = (salario * inss) + (salario * fgts) + (salario * vt) + (salario * vr);
                double salarioDesc = salario - salarioLiquido;
                lblSalarioliqui.Text = Convert.ToString(salarioDesc);
                double salarioinss = salario * inss;
                double salariofgts = salario * fgts;
                double salariot = salario * vt;
                double salarior = salario * vr;
                lblINSS.Text = Convert.ToString(salarioinss);
                lblFGTS.Text = Convert.ToString(salariofgts);
                lblVT.Text = Convert.ToString(salariot);
                lblVR.Text = Convert.ToString(salarior);
            }
        }

        private void CalcularRend_Click(object sender, EventArgs e)
        {
            double salario = Convert.ToDouble(txtRend.Text);
            double inss = 0.07;
            double fgts = 0.08;
            double vt = 0.06;
            double vr = 0.05;
            double salarioLiquido = (salario * inss) + (salario * fgts) + (salario * vt) + (salario * vr);
            double salarioRend = (salario - salarioLiquido) * 12;
            label16.Text = Convert.ToString(salarioRend);
            double salarioinss = (salario * inss) * 12;
            double salariofgts = (salario * fgts) * 12;
            double salariot = (salario * vt) * 12;
            double salarior = (salario * vr) * 12;
            label11.Text = Convert.ToString(salarioinss);
            label10.Text = Convert.ToString(salariofgts);
            label9.Text = Convert.ToString(salariot);
            label8.Text = Convert.ToString(salarior);
        }

        private void btnCadastrar_Click(object sender, EventArgs e )
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O Campo nome é obrigatório", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else if (txtCadMatricula.Text == "")
            {
                MessageBox.Show("O Campo matricula é obrigatório", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCadMatricula.Focus();
            }
            else if (txtCadSenha.Text == "")
            {
                MessageBox.Show("O Campo senha é obrigatório", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCadSenha.Focus();
            }
            else if (txtCadSenha.TextLength < 8)
            {
                MessageBox.Show("A senha deve conter no minimo 8 caracteres", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCadSenha.Focus();
            }
            else if (txtConfSenha.Text == "")
            {
                MessageBox.Show("O Campo confirmar senha é obrigatório", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfSenha.Focus();
            }
            else if (txtConfSenha.Text != txtCadSenha.Text)
            {
                MessageBox.Show("As senhas não conferem", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfSenha.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("O Campo email é obrigatório", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else if (txtNascimento.Text == "")
            {
                MessageBox.Show("O Campo data de nascimento é obrigatório", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNascimento.Focus();
            }
            else if (txtAdmissao.Text == "")
            {
                MessageBox.Show("O Campo data de Admissão é obrigatório", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdmissao.Focus();
            }
            else
            {
                try
                {
                    conexao.Open();
                    String nome = txtNome.Text;
                    String matricula = txtCadMatricula.Text;
                    String senha = txtCadSenha.Text;
                    String email = txtEmail.Text;
                    String data_nasc = txtNascimento.Text;
                    String data_admissao = txtAdmissao.Text;
                    String tipoUsuario = txtCargo.SelectedItem.ToString();
                    String turno = txtTurno.SelectedItem.ToString();

                    string query = "insert into Login_Func(Matricula,Senha, tipo_usuario) values(@matricula,@senha,@tipoUsuario)";
                    SqlCommand command2 = new SqlCommand(query, conexao);
                    command2.Parameters.AddWithValue("@matricula", matricula);
                    command2.Parameters.AddWithValue("@senha", senha);
                    command2.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
                    int matriculaRowsAffected = command2.ExecuteNonQuery();

                    if(matriculaRowsAffected > 0)
                        {

                        string getIdQuery = "SELECT @@IDENTITY";
                        SqlCommand getIdcommand = new SqlCommand(getIdQuery, conexao);
                        string sqlFunc = "insert into Funcionario(Matricula,Nome,Data_Nasc,Email,Data_Admissao,Turno) values(@matricula, @nome,@data_nasc,@email,@data_admissao,@turno)";
                        SqlCommand cm = new SqlCommand(sqlFunc, conexao);
                        cm.Parameters.AddWithValue("@matricula", matricula);
                        cm.Parameters.AddWithValue("@nome", nome);
                        cm.Parameters.AddWithValue("@data_nasc", data_nasc);
                        cm.Parameters.AddWithValue("@email", email);
                        cm.Parameters.AddWithValue("@data_admissao", data_admissao);
                        cm.Parameters.AddWithValue("@turno", turno);

                        int funcionarioRowsAffected = cm.ExecuteNonQuery();
                  
                        MessageBox.Show("O cadastro foi realizado com sucesso", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Focus();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);

                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();

        }

        private void PesquisarFerias_Click(object sender, EventArgs e)
        {
            conexao.Open();
            string query = "SELECT * FROM Funcionario WHERE Matricula = '" + MatriculaFerias.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            lblColab.Text = dt.Rows[0]["Nome"].ToString();
            lblData.Text = dt.Rows[0]["Data_Admissao"].ToString();
            lblFerias.Text = dt.Rows[0]["Data_Admissao"].ToString(); // adiciona a data no label ferias
            SqlCommand command = new SqlCommand(query, conexao);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                DateTime dateTime = Convert.ToDateTime(lblFerias.Text); //Banco esta VARCHAR e no codigo está DATE  
                dateTime = dateTime.AddYears(1);
               // lblFerias.Text = dateTime("dd/MM/yyyy");
            }
            conexao.Close();
        }

        private void btnSalvarFerias_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                string query = "UPDATE Funcionario SET data_ferias = '" + lblSolicitadas.Text + "' WHERE Matricula = '" + MatriculaFerias.Text + "'";
                SqlDataAdapter dp = new SqlDataAdapter(query, conexao);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                lblSolicitadas.Text = dt.Rows[0]["data_ferias"].ToString();
                DateTime dateTime = Convert.ToDateTime(lblSolicitadas.Text);
                lblFerias.Text = dateTime.ToString("dd/MM/yyyy");
               MessageBox.Show("Ferias solicitadas com sucesso", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao solicitar ferias", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPagamentos_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void matriculaPag_Click(object sender, EventArgs e)
        {

        }

        private void btnPag_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblVR_Click(object sender, EventArgs e)
        {

        }

        private void lblVT_Click(object sender, EventArgs e)
        {

        }

        private void lblFGTS_Click(object sender, EventArgs e)
        {

        }

        private void lblINSS_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSalarioliqui_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRendimentos_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtRendMatricula_Click(object sender, EventArgs e)
        {

        }

        private void SalvarRend_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtRend_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFerias_Click(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblSolicitadas_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void lblFerias_Click(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void lblColab_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void MatriculaFerias_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColaborador_Click(object sender, EventArgs e)
        {

        }

        private void txtConfSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TxtAdmissão_Click(object sender, EventArgs e)
        {

        }

        private void txtNascimento_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefone_Click(object sender, EventArgs e)
        {

        }

        private void txtCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCadMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCadSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFinalizar_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string editarMatricula = txtEditarMatricula.Text;
            string editarNome = txtEditarNome.Text;
            string editaremail = txtEditarEmail.Text;
            string editartelefone = txtEditarTelefone.Text;
            string editarSenha = txtEditarSenha.Text;
            string editarConfSenha = txtEditarConfirmar.Text;
            string editarNascimento = txtEditarNascimento.Text;
            string editarAdmissao = txtEditarAdmissao.Text;
            string editarTuno = txtEditarTurno.SelectedItem.ToString();

            try
            {
                conexao.Open();
               string query = "SELECT * FROM Funcionario WHERE Matricula = '" + txtEditarMatricula.Text + "'";
                SqlDataAdapter dp = new SqlDataAdapter(query, conexao);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                txtEditarNome.Text = dt.Rows[0]["Nome"].ToString();
                txtEditarEmail.Text = dt.Rows[0]["Email"].ToString();
                txtEditarTelefone.Text = dt.Rows[0]["Telefone"].ToString();
                txtEditarSenha.Text = dt.Rows[0]["Senha"].ToString();
                txtEditarConfirmar.Text = dt.Rows[0]["Senha"].ToString();
                txtEditarNascimento.Text = dt.Rows[0]["Data_Nasc"].ToString();
                txtEditarAdmissao.Text = dt.Rows[0]["Data_Admissao"].ToString();
                txtEditarTurno.Text = dt.Rows[0]["Turno"].ToString();
                SqlCommand cr = new SqlCommand(query, conexao);
                SqlDataReader reader = cr.ExecuteReader();

            }
            catch
            {

            }
        }
    }
}
