using System;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TEMPERO
{
    public partial class FormCadCliente : Form
    {
        public FormCadCliente()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormCadCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Conexao = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=base_clientes;User=root;Password="))
            {
                Conexao.Open();

                using (MySqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Clientes (nome, documento, genero, rg, endereco, estado_civil, nasc, cep, endereco, numero, bairro, cidade, estado, celular, email, obs, situacao) VALUES(@nome, @documento, @genero, @rg, @estado_civil, @nasc, @cep, @endereco, @numero, @bairro, @cidade, @estado, @celular, @email, @obs, @situacao )";

                    cmd.Parameters.AddWithValue("@nome", TxtNome.Text);
                    cmd.Parameters.AddWithValue("@documento", TxtDoc.Text);

                    cmd.Parameters.AddWithValue("@genero", "GENERO");

                    cmd.Parameters.AddWithValue("@rg", TxtRG.Text);
                    cmd.Parameters.AddWithValue("@estado_civil", CbEstadoCivil.Text);
                    cmd.Parameters.AddWithValue("@nasc", TxtNasc.Text);
                    cmd.Parameters.AddWithValue("@cep", TxtCEP.Text);
                    cmd.Parameters.AddWithValue("@endereco", CbEndereco.Text);
                    cmd.Parameters.AddWithValue("@numero", TxtNumero.Text);
                    cmd.Parameters.AddWithValue("@bairro", CbBairro.Text);
                    cmd.Parameters.AddWithValue("@cidade", CbCidade.Text);
                    cmd.Parameters.AddWithValue("@estado", CbEstado.Text);
                    cmd.Parameters.AddWithValue("@celular", TxtCelular.Text);
                    cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@obs", TxtObs.Text);

                    cmd.Parameters.AddWithValue("@situacao", "SITUAÇÃO");

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using(MySqlConnection Conexao = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=base_clientes;User=root;Password="))
            {
                Conexao.Open();

                using(MySqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO clientes (nome, documento, genero, rg, endereco, estado_civil, nasc, cep, endereco, numero, bairro, cidade, estado, celular, email, obs, situacao) VALUES(@nome, @documento, @genero, @rg, @estado_civil, @nasc, @cep, @endereco, @numero, @bairro, @cidade, @estado, @celular, @email, @obs, @situacao )";

                    cmd.Parameters.AddWithValue("@nome", TxtNome.Text);
                    cmd.Parameters.AddWithValue("@documento", TxtDoc.Text);

                    cmd.Parameters.AddWithValue("@genero", "GENERO");

                    cmd.Parameters.AddWithValue("@rg", TxtRG.Text);
                    cmd.Parameters.AddWithValue("@estado_civil", CbEstadoCivil.Text);
                    cmd.Parameters.AddWithValue("@nasc", TxtNasc.Text);
                    cmd.Parameters.AddWithValue("@cep", TxtCEP.Text);
                    cmd.Parameters.AddWithValue("@endereco", CbEndereco.Text);
                    cmd.Parameters.AddWithValue("@numero", TxtNumero.Text);
                    cmd.Parameters.AddWithValue("@bairro", CbBairro.Text);
                    cmd.Parameters.AddWithValue("@cidade", CbCidade.Text);
                    cmd.Parameters.AddWithValue("@estado", CbEstado.Text);
                    cmd.Parameters.AddWithValue("@celular", TxtCelular.Text);
                    cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@obs", TxtObs.Text);

                    cmd.Parameters.AddWithValue("@situacao", "SITUAÇÃO");

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("OK");
            }
        }
    }
}    