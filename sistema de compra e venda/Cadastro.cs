using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sistema_de_compra_e_venda
{
    public partial class Cadastro : Form
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=SistemaComercial;Trusted_Connection=True;";
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNomeFantasia.Text == "")
            {
                MessageBox.Show("O Nome Fantasia é obrigatório!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"INSERT INTO Empresa 
                               (NomeFantasia, RazaoSocial, CNPJ, Telefone, Email, Endereco)
                               VALUES
                               (@NomeFantasia, @RazaoSocial, @CNPJ, @Telefone, @Email, @Endereco)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@NomeFantasia", txtNomeFantasia.Text);
                cmd.Parameters.AddWithValue("@RazaoSocial", txtRazaoSocial.Text);
                cmd.Parameters.AddWithValue("@CNPJ", txtCNPJ.Text);
                cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Empresa cadastrada com sucesso!");

            txtNomeFantasia.Clear();
            txtRazaoSocial.Clear();
            txtCNPJ.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
        }

        private void txtCNPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
