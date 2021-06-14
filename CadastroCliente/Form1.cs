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
        public int X = 13, Y = 14, n = 0, id = 0;
        public string ret_id;
        public Frm_CadastroCliente()
        {
            InitializeComponent();
            btn_deletar.Visible = false;
            btnIncluiTel.Visible = true;
            btnAtTel.Visible = false;
            btnDelTel.Visible = false;
            btnCanTel.Visible = false;
        }

        int _linhaIndice;
        bool _novo = true;
        String _idCliente;
              
        SqlConnection sqlConexao = null;
        private string strConexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=db_DPSP;Data Source=localhost\SQLEXPRESS01";
        private string strSql = string.Empty;

       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tb_clienteTableAdapter.Fill(this.db_DPSPDataSet.tb_cliente);
            dataGridView2.Visible = false;
            btn_deletar.Visible = false;
            
        }

        private void Criar_Telefone()
        {
                MaskedTextBox mt = new MaskedTextBox();
                mt.Location = new System.Drawing.Point(X, Y);
                mt.Mask = "(99)00000-0000";
                mt.Name = "Telefone" + id; ;
                mt.Size = new System.Drawing.Size(120, 24);
               //mt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
                panel1.Controls.Add(mt);
                Y += 24;
                id++;
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {

            if (txt_nomeCli.Text == "" || txt_enderecoCli.Text == "" || txt_numeroCli.Text =="" 
                || txt_bairroCli.Text == "" || txt_cidadeCli.Text == "" || txt_ufCli.Text =="")
            { 
                MessageBox.Show("Favor preencher todos os campos!");
                return;
            }

            if (!txt_cepCli.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo cep corretamente.");
                return;
            }

            if (id == 0 && _novo)
              {
                  MessageBox.Show("Preencha o campo telefone corretamente.");
                  return;
            }
                        
            if (_novo) { 
                strSql = "INSERT INTO tb_cliente (Nome_CLI, Endereco_CLI,Numero_CLI, Bairro_CLI, Cidade_CLI, UF_Cli," +
                    "CEP_Cli, Telefone_CLI) values(@nome,@endereco,@numero,@bairro,@cidade,@UF,@CEP,@telefone)";

                sqlConexao = new SqlConnection(strConexao);
                SqlCommand comando = new SqlCommand(strSql, sqlConexao);
                             
                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txt_nomeCli.Text;
                comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txt_enderecoCli.Text;
                comando.Parameters.Add("@numero", SqlDbType.VarChar).Value = txt_numeroCli.Text;
                comando.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txt_bairroCli.Text;
                comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txt_cidadeCli.Text;
                comando.Parameters.Add("@UF", SqlDbType.VarChar).Value = txt_ufCli.Text;
                comando.Parameters.Add("@CEP", SqlDbType.VarChar).Value = txt_cepCli.Text;
                comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = "999999999";

                try
                {
                    sqlConexao.Open();

                    comando.ExecuteNonQuery();

                    strSql = "select ident_current ('tb_cliente')";
                    comando = new SqlCommand(strSql, sqlConexao);

                    ret_id = comando.ExecuteScalar().ToString();

                    if (CadTelefone())
                    {
                     
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar telefone !");
                    }

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
                InicializaParams();
                btnIncluiTel.Visible = true;
                btnAtTel.Visible = false;
                btnDelTel.Visible = false;
            }
            else
            {
                strSql = "UPDATE tb_cliente SET Nome_CLI=@nome, Endereco_CLI=@endereco, Numero_CLI=@numero, Bairro_CLI=@bairro," +
                    " Cidade_CLI=@cidade,UF_Cli=@uf,CEP_Cli=@cep WHERE ID_Cli = @Id";

                sqlConexao = new SqlConnection(strConexao);
                SqlCommand comando = new SqlCommand(strSql, sqlConexao);

                comando.Parameters.Add("@id", SqlDbType.Int).Value = txt_idCli.Text;
                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txt_nomeCli.Text;
                comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txt_enderecoCli.Text;
                comando.Parameters.Add("@numero", SqlDbType.VarChar).Value = txt_numeroCli.Text;
                comando.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txt_bairroCli.Text;
                comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txt_cidadeCli.Text;
                comando.Parameters.Add("@UF", SqlDbType.VarChar).Value = txt_ufCli.Text;
                comando.Parameters.Add("@CEP", SqlDbType.VarChar).Value = txt_cepCli.Text;
       
                try
                {
                    sqlConexao.Open();

                    comando.ExecuteNonQuery();

                    ret_id = txt_idCli.Text;

                    if (CadTelefone())
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar telefone !");
                    }

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
            btnIncluiTel.Visible = true;
            btnAtTel.Visible = false;
            btnDelTel.Visible = false;
            InicializaParams();

        }
           
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                   
             _linhaIndice = e.RowIndex;

            if (_linhaIndice == -1)
            {
                return;
            }
            DataGridViewRow rowData = dataGridView1.Rows[_linhaIndice];

            txt_idCli.Text = rowData.Cells[0].Value.ToString();
            txt_nomeCli.Text = rowData.Cells[1].Value.ToString();
            txt_enderecoCli.Text = rowData.Cells[2].Value.ToString();
            txt_numeroCli.Text = rowData.Cells[3].Value.ToString();
            txt_bairroCli.Text = rowData.Cells[4].Value.ToString();
            txt_cidadeCli.Text = rowData.Cells[5].Value.ToString();
            txt_ufCli.Text = rowData.Cells[6].Value.ToString();
            txt_cepCli.Text = rowData.Cells[7].Value.ToString();
                        
            dataGridView2.Visible = true;
            this.tb_telefoneTableAdapter.FillByID(this.db_DPSPDataSet2.tb_telefone, Int16.Parse(txt_idCli.Text));
            
            _novo = false;
            btn_deletar.Visible = true;
            btnIncluiTel.Visible = true;
        }
            
        private void btn_busca_Click(object sender, EventArgs e)
        {
            if (txt_buscaNome.Text != "")
                try
                {
                    if (cmb_campo.Text == ""){
                        MessageBox.Show("Favor selecionar um campo opção!");
                     }
                    switch (cmb_campo.Text)
                    {
                        case "Nome":
                            this.tb_clienteTableAdapter.FindByName(this.db_DPSPDataSet.tb_cliente, txt_buscaNome.Text);
                            break;
                        case "Endereço":
                            this.tb_clienteTableAdapter.FindByAddress(this.db_DPSPDataSet.tb_cliente, txt_buscaNome.Text);
                            break;
                        case "Bairro":
                            this.tb_clienteTableAdapter.FindByBairro(this.db_DPSPDataSet.tb_cliente, txt_buscaNome.Text);
                            break;
                        case "Cidade":
                            this.tb_clienteTableAdapter.FindByCity(this.db_DPSPDataSet.tb_cliente, txt_buscaNome.Text);
                            break;
                        case "UF":
                            this.tb_clienteTableAdapter.FindByUF(this.db_DPSPDataSet.tb_cliente, txt_buscaNome.Text);
                            break;
                    }
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                cmb_campo.ResetText();
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            txt_buscaNome.Clear();
            this.tb_clienteTableAdapter.Fill(this.db_DPSPDataSet.tb_cliente);
        }
             
        private void btn_deletar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Deseja deletar o registro?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.OK))
            {
                string strSql = "DELETE FROM tb_telefone WHERE ID_Cli = @Id;" +
                    "DELETE FROM tb_cliente WHERE ID_Cli = @Id";

                sqlConexao = new SqlConnection(strConexao);
                SqlCommand comando = new SqlCommand(strSql, sqlConexao);

                comando.Parameters.Add("@id", SqlDbType.Int).Value = txt_idCli.Text;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clean_fields();
            InicializaParams();
            btnIncluiTel.Visible = true;
            btnAtTel.Visible = false;
            btnDelTel.Visible = false;
            btnCanTel.Visible = false;
            _novo = true;
        }

        public void Clean_fields() {
            txt_idCli.Clear();
            txt_nomeCli.Clear();
            txt_enderecoCli.Clear();
            txt_numeroCli.Clear();
            txt_bairroCli.Clear();
            txt_cidadeCli.Clear();
            txt_ufCli.Clear();
            txt_cepCli.Clear();
            dataGridView2.Visible = false;
        }

        private void btnIncluiTel_Click(object sender, EventArgs e)
        {
                Criar_Telefone();
                ((MaskedTextBox)panel1.Controls["Telefone" + (id - 1)]).Focus();
        }
           
        private void cmb_campo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_buscaNome.Clear();
        }
          
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnIncluiTel.Visible = false;
            btnAtTel.Visible = true;
            btnDelTel.Visible = true;
            btnCanTel.Visible = true;

            _linhaIndice = e.RowIndex;

            if (_linhaIndice == -1)
            {
                return;
            }
            DataGridViewRow rowData = dataGridView2.Rows[_linhaIndice];

            Criar_Telefone();
            _idCliente = rowData.Cells[0].Value.ToString();
            ((MaskedTextBox)panel1.Controls["Telefone" + (id - 1)]).Text = rowData.Cells[1].Value.ToString();

        }

        private void Gravar_Telefone()
        {
            strSql = "select ident_current (tb_cliente)";
            sqlConexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(strSql, sqlConexao);

            ret_id = comando.ExecuteScalar().ToString();
        }

        private void btnAtTel_Click(object sender, EventArgs e)
        {
            if (AtualizaTelefone())
            {
                MessageBox.Show(" Telefone atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o telefone !");
                              
            }

            btnIncluiTel.Visible = true;
            btnAtTel.Visible = false;
            btnDelTel.Visible = false;
            btnCanTel.Visible = false;
            InicializaParams();
        }

        private void btnDelTel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja deletar o telefone?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.OK))
            {
                if (DeletaTelefone())
                {
                    MessageBox.Show(" Telefone deletado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao deletar o telefone !");
                }

            }
            btnIncluiTel.Visible = true;
            btnAtTel.Visible = false;
            btnDelTel.Visible = false;
            btnCanTel.Visible = false;
            InicializaParams();

        }

        private bool CadTelefone()
        {
            n = panel1.Controls.Count;
            for (int i = 0; i < n; i++) { 
                strSql = "insert into [tb_telefone](ID_CLI, Telefone_CLI) values('" + ret_id + "', '" + ((MaskedTextBox)panel1.Controls["Telefone" +i]).Text+"')";
                SqlCommand comando = new SqlCommand(strSql, sqlConexao);
                if (((MaskedTextBox)panel1.Controls["Telefone"+i]).Text == "")
                {
                   
                }
               else
                {
                    comando.ExecuteNonQuery();                  
                }
            }
            return true;
        }
 
        private bool AtualizaTelefone()
        {
            n = panel1.Controls.Count;
            for (int i = 0; i < n; i++)
            {
                strSql = "UPDATE tb_telefone SET Telefone_CLI=@telefone WHERE ID_TEL = @Id";
                sqlConexao = new SqlConnection(strConexao);
                SqlCommand comando = new SqlCommand(strSql, sqlConexao);

                comando.Parameters.Add("@id", SqlDbType.Int).Value = _idCliente;
                comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = ((MaskedTextBox)panel1.Controls["Telefone" + i]).Text;
             
                if (((MaskedTextBox)panel1.Controls["Telefone" + i]).Text == "")
                {

                }
                else
                {
                    sqlConexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
            this.tb_telefoneTableAdapter.FillByID(this.db_DPSPDataSet2.tb_telefone, Int16.Parse(txt_idCli.Text));
           
            return true;
        }

        private bool DeletaTelefone()
        {
            n = panel1.Controls.Count;
            for (int i = 0; i < n; i++)
            {
                strSql = "DELETE FROM tb_telefone WHERE ID_TEL = @Id";
                sqlConexao = new SqlConnection(strConexao);
                SqlCommand comando = new SqlCommand(strSql, sqlConexao);

                comando.Parameters.Add("@id", SqlDbType.Int).Value = _idCliente;
                comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = ((MaskedTextBox)panel1.Controls["Telefone" + i]).Text;

                if (((MaskedTextBox)panel1.Controls["Telefone" + i]).Text == "")
                {

                }
                else
                {
                    sqlConexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
            this.tb_telefoneTableAdapter.FillByID(this.db_DPSPDataSet2.tb_telefone, Int16.Parse(txt_idCli.Text));
            return true;
        }

        private void InicializaParams()
        {
            Y = 14;
            n = 0;
            id = 0;
            ret_id = "";
            panel1.Controls.Clear();
         }

        private void btnCanTel_Click(object sender, EventArgs e)
        {
            btnIncluiTel.Visible = true;
            btnAtTel.Visible = false;
            btnDelTel.Visible = false;
            btnCanTel.Visible = false;
            InicializaParams();
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
