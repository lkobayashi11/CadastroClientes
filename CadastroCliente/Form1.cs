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

namespace CadastroCliente
{
    public partial class Frm_CadastroCliente : Form
    {
        public Frm_CadastroCliente()
        {
            InitializeComponent();
            btn_deletar.Visible = false;
        }

        int _linhaIndice;
        bool _novo = true;

        SqlConnection sqlConexao = null;
        private string strConexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=db_DPSP;Data Source=localhost\SQLEXPRESS01";
        private string strSql = string.Empty;

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {        
           
            btn_deletar.Visible = false;
        }

        
        private void btn_inserir_Click(object sender, EventArgs e)
        {

            if (txt_nome_cli.Text == "" || txt_endereco_cli.Text == "" || txt_numero_cli.Text =="" 
                || txt_bairro_cli.Text == "" || txt_cidade_cli.Text == "" || txt_uf_cli.Text =="")
            { 
                MessageBox.Show("Favor preencher todos os campos!");
                return;
            }

            if (!txt_cep_cli.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo cep corretamente.");
                return;
            }

            if (!txt_telefone_cli.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo telefone corretamente.");
                return;
            }

            
            if (_novo) { 
                strSql = "insert into tb_cliente (Nome_CLI, Endereco_CLI,Numero_CLI, Bairro_CLI, Cidade_CLI, UF_Cli," +
                    "CEP_Cli,Telefone_CLI) values(@nome,@endereco,@numero,@bairro,@cidade,@UF,@CEP,@telefone)";

                sqlConexao = new SqlConnection(strConexao);
                SqlCommand comando = new SqlCommand(strSql, sqlConexao);

             
                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txt_nome_cli.Text;
                comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txt_endereco_cli.Text;
                comando.Parameters.Add("@numero", SqlDbType.VarChar).Value = txt_numero_cli.Text;
                comando.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txt_bairro_cli.Text;
                comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txt_cidade_cli.Text;
                comando.Parameters.Add("@UF", SqlDbType.VarChar).Value = txt_uf_cli.Text;
                comando.Parameters.Add("@CEP", SqlDbType.VarChar).Value = txt_cep_cli.Text;
                comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txt_telefone_cli.Text;

                try
                {
                    sqlConexao.Open();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cliente criado com sucesso!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConexao.Close();
                }
            }
            else
            {
                strSql = "update tb_cliente set Nome_CLI=@nome, Endereco_CLI=@endereco, Numero_CLI=@numero, Bairro_CLI=@bairro," +
                    " Cidade_CLI=@cidade,UF_Cli=@uf,CEP_Cli=@cep,Telefone_CLI=@telefone WHERE ID_Cli = @Id";

                sqlConexao = new SqlConnection(strConexao);
                SqlCommand comando = new SqlCommand(strSql, sqlConexao);

                comando.Parameters.Add("@id", SqlDbType.Int).Value = txt_id_cli.Text;
                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txt_nome_cli.Text;
                comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txt_endereco_cli.Text;
                comando.Parameters.Add("@numero", SqlDbType.VarChar).Value = txt_numero_cli.Text;
                comando.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txt_bairro_cli.Text;
                comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txt_cidade_cli.Text;
                comando.Parameters.Add("@UF", SqlDbType.VarChar).Value = txt_uf_cli.Text;
                comando.Parameters.Add("@CEP", SqlDbType.VarChar).Value = txt_cep_cli.Text;
                comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txt_telefone_cli.Text;

                try
                {
                    sqlConexao.Open();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cliente atualizado com sucesso!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConexao.Close();
                }
                _novo = true;
                               
            }
            Clean_fields();
            this.tb_clienteTableAdapter.Fill(this.db_DPSPDataSet.tb_cliente);

            btn_deletar.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            this.tb_clienteTableAdapter.Fill(this.db_DPSPDataSet.tb_cliente);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                      
             _linhaIndice = e.RowIndex;

            if (_linhaIndice == -1)
            {
                return;
            }

            DataGridViewRow rowData = dataGridView1.Rows[_linhaIndice];

            txt_id_cli.Text = rowData.Cells[0].Value.ToString();
            txt_nome_cli.Text = rowData.Cells[1].Value.ToString();
            txt_endereco_cli.Text = rowData.Cells[2].Value.ToString();
            txt_numero_cli.Text = rowData.Cells[3].Value.ToString();
            txt_bairro_cli.Text = rowData.Cells[4].Value.ToString();
            txt_cidade_cli.Text = rowData.Cells[5].Value.ToString();
            txt_uf_cli.Text = rowData.Cells[6].Value.ToString();
            txt_cep_cli.Text = rowData.Cells[7].Value.ToString();
            txt_telefone_cli.Text = rowData.Cells[8].Value.ToString();

            _novo = false;
            btn_deletar.Visible = true;

        }

    
        private void btn_busca_Click(object sender, EventArgs e)
        {
            if (txt_buscanome.Text != "")
                try
                {
                    this.tb_clienteTableAdapter.FindByName(this.db_DPSPDataSet.tb_cliente, txt_buscanome.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_buscanome.Clear();
            this.tb_clienteTableAdapter.Fill(this.db_DPSPDataSet.tb_cliente);
        }

     
        private void btn_deletar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Deseja deletar o registro?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.OK))
            {
                string strSql = "DELETE FROM tb_cliente WHERE ID_Cli = @Id";

                sqlConexao = new SqlConnection(strConexao);
                SqlCommand comando = new SqlCommand(strSql, sqlConexao);

                comando.Parameters.Add("@id", SqlDbType.Int).Value = txt_id_cli.Text;

                try
                {
                    sqlConexao.Open();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cliente deletado com sucesso!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConexao.Close();
                }

                Clean_fields();
                _novo = true;

                this.tb_clienteTableAdapter.Fill(this.db_DPSPDataSet.tb_cliente);
                
            } 
            else
            {
                 Clean_fields();
                _novo = true;
            }
            btn_deletar.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clean_fields();
            _novo = true;
        }

        public void Clean_fields() {
            txt_id_cli.Clear();
            txt_nome_cli.Clear();
            txt_endereco_cli.Clear();
            txt_numero_cli.Clear();
            txt_bairro_cli.Clear();
            txt_cidade_cli.Clear();
            txt_uf_cli.Clear();
            txt_cep_cli.Clear();
            txt_telefone_cli.Clear();
            
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Você deseja sair?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }
    }
    
}
