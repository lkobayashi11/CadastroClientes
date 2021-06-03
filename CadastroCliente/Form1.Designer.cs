
namespace CadastroCliente
{
    partial class Frm_CadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroCliente));
            this.txt_numero_cli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cep_cli = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telefone_cli = new System.Windows.Forms.MaskedTextBox();
            this.txt_uf_cli = new System.Windows.Forms.TextBox();
            this.txt_cidade_cli = new System.Windows.Forms.TextBox();
            this.txt_bairro_cli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_endereco_cli = new System.Windows.Forms.TextBox();
            this.txt_nome_cli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_endereco_cli = new System.Windows.Forms.Label();
            this.lbl_nome_cli = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_DPSPDataSet = new CadastroCliente.db_DPSPDataSet();
            this.tb_clienteTableAdapter = new CadastroCliente.db_DPSPDataSetTableAdapters.tb_clienteTableAdapter();
            this.btn_findAll = new System.Windows.Forms.Button();
            this.btn_busca = new System.Windows.Forms.Button();
            this.txt_buscanome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Consulta = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_id_cli = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DPSPDataSet)).BeginInit();
            this.Consulta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_numero_cli
            // 
            this.txt_numero_cli.Location = new System.Drawing.Point(793, 102);
            this.txt_numero_cli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero_cli.Name = "txt_numero_cli";
            this.txt_numero_cli.Size = new System.Drawing.Size(55, 24);
            this.txt_numero_cli.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(721, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Número";
            // 
            // txt_cep_cli
            // 
            this.txt_cep_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cep_cli.Location = new System.Drawing.Point(158, 178);
            this.txt_cep_cli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cep_cli.Mask = "00000-000";
            this.txt_cep_cli.Name = "txt_cep_cli";
            this.txt_cep_cli.Size = new System.Drawing.Size(130, 24);
            this.txt_cep_cli.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "CEP";
            // 
            // txt_telefone_cli
            // 
            this.txt_telefone_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone_cli.Location = new System.Drawing.Point(158, 217);
            this.txt_telefone_cli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefone_cli.Mask = "(00)00000-0000";
            this.txt_telefone_cli.Name = "txt_telefone_cli";
            this.txt_telefone_cli.Size = new System.Drawing.Size(130, 24);
            this.txt_telefone_cli.TabIndex = 13;
            // 
            // txt_uf_cli
            // 
            this.txt_uf_cli.Location = new System.Drawing.Point(793, 141);
            this.txt_uf_cli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_uf_cli.Name = "txt_uf_cli";
            this.txt_uf_cli.Size = new System.Drawing.Size(40, 24);
            this.txt_uf_cli.TabIndex = 11;
            // 
            // txt_cidade_cli
            // 
            this.txt_cidade_cli.Location = new System.Drawing.Point(450, 141);
            this.txt_cidade_cli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cidade_cli.Name = "txt_cidade_cli";
            this.txt_cidade_cli.Size = new System.Drawing.Size(261, 24);
            this.txt_cidade_cli.TabIndex = 10;
            // 
            // txt_bairro_cli
            // 
            this.txt_bairro_cli.Location = new System.Drawing.Point(158, 141);
            this.txt_bairro_cli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bairro_cli.Name = "txt_bairro_cli";
            this.txt_bairro_cli.Size = new System.Drawing.Size(207, 24);
            this.txt_bairro_cli.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(725, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "UF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bairro";
            // 
            // txt_endereco_cli
            // 
            this.txt_endereco_cli.Location = new System.Drawing.Point(158, 102);
            this.txt_endereco_cli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_endereco_cli.Name = "txt_endereco_cli";
            this.txt_endereco_cli.Size = new System.Drawing.Size(553, 24);
            this.txt_endereco_cli.TabIndex = 4;
            // 
            // txt_nome_cli
            // 
            this.txt_nome_cli.Location = new System.Drawing.Point(158, 57);
            this.txt_nome_cli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome_cli.Name = "txt_nome_cli";
            this.txt_nome_cli.Size = new System.Drawing.Size(553, 24);
            this.txt_nome_cli.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // lbl_endereco_cli
            // 
            this.lbl_endereco_cli.AutoSize = true;
            this.lbl_endereco_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco_cli.Location = new System.Drawing.Point(40, 105);
            this.lbl_endereco_cli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_endereco_cli.Name = "lbl_endereco_cli";
            this.lbl_endereco_cli.Size = new System.Drawing.Size(72, 18);
            this.lbl_endereco_cli.TabIndex = 1;
            this.lbl_endereco_cli.Text = "Endereço";
            // 
            // lbl_nome_cli
            // 
            this.lbl_nome_cli.AutoSize = true;
            this.lbl_nome_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_cli.Location = new System.Drawing.Point(40, 60);
            this.lbl_nome_cli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome_cli.Name = "lbl_nome_cli";
            this.lbl_nome_cli.Size = new System.Drawing.Size(49, 18);
            this.lbl_nome_cli.TabIndex = 0;
            this.lbl_nome_cli.Text = "Nome";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCLIDataGridViewTextBoxColumn,
            this.nomeCLIDataGridViewTextBoxColumn,
            this.enderecoCLIDataGridViewTextBoxColumn,
            this.numeroCLIDataGridViewTextBoxColumn,
            this.bairroCLIDataGridViewTextBoxColumn,
            this.cidadeCLIDataGridViewTextBoxColumn,
            this.uFCliDataGridViewTextBoxColumn,
            this.cEPCliDataGridViewTextBoxColumn,
            this.telefoneCLIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbclienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 535);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 185);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDCLIDataGridViewTextBoxColumn
            // 
            this.iDCLIDataGridViewTextBoxColumn.DataPropertyName = "ID_CLI";
            this.iDCLIDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDCLIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCLIDataGridViewTextBoxColumn.Name = "iDCLIDataGridViewTextBoxColumn";
            this.iDCLIDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCLIDataGridViewTextBoxColumn.Width = 25;
            // 
            // nomeCLIDataGridViewTextBoxColumn
            // 
            this.nomeCLIDataGridViewTextBoxColumn.DataPropertyName = "Nome_CLI";
            this.nomeCLIDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeCLIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeCLIDataGridViewTextBoxColumn.Name = "nomeCLIDataGridViewTextBoxColumn";
            this.nomeCLIDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeCLIDataGridViewTextBoxColumn.Width = 125;
            // 
            // enderecoCLIDataGridViewTextBoxColumn
            // 
            this.enderecoCLIDataGridViewTextBoxColumn.DataPropertyName = "Endereco_CLI";
            this.enderecoCLIDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoCLIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enderecoCLIDataGridViewTextBoxColumn.Name = "enderecoCLIDataGridViewTextBoxColumn";
            this.enderecoCLIDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoCLIDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroCLIDataGridViewTextBoxColumn
            // 
            this.numeroCLIDataGridViewTextBoxColumn.DataPropertyName = "Numero_CLI";
            this.numeroCLIDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroCLIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroCLIDataGridViewTextBoxColumn.Name = "numeroCLIDataGridViewTextBoxColumn";
            this.numeroCLIDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroCLIDataGridViewTextBoxColumn.Width = 125;
            // 
            // bairroCLIDataGridViewTextBoxColumn
            // 
            this.bairroCLIDataGridViewTextBoxColumn.DataPropertyName = "Bairro_CLI";
            this.bairroCLIDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroCLIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bairroCLIDataGridViewTextBoxColumn.Name = "bairroCLIDataGridViewTextBoxColumn";
            this.bairroCLIDataGridViewTextBoxColumn.ReadOnly = true;
            this.bairroCLIDataGridViewTextBoxColumn.Width = 125;
            // 
            // cidadeCLIDataGridViewTextBoxColumn
            // 
            this.cidadeCLIDataGridViewTextBoxColumn.DataPropertyName = "Cidade_CLI";
            this.cidadeCLIDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeCLIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cidadeCLIDataGridViewTextBoxColumn.Name = "cidadeCLIDataGridViewTextBoxColumn";
            this.cidadeCLIDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidadeCLIDataGridViewTextBoxColumn.Width = 125;
            // 
            // uFCliDataGridViewTextBoxColumn
            // 
            this.uFCliDataGridViewTextBoxColumn.DataPropertyName = "UF_Cli";
            this.uFCliDataGridViewTextBoxColumn.HeaderText = "UF";
            this.uFCliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uFCliDataGridViewTextBoxColumn.Name = "uFCliDataGridViewTextBoxColumn";
            this.uFCliDataGridViewTextBoxColumn.ReadOnly = true;
            this.uFCliDataGridViewTextBoxColumn.Width = 125;
            // 
            // cEPCliDataGridViewTextBoxColumn
            // 
            this.cEPCliDataGridViewTextBoxColumn.DataPropertyName = "CEP_Cli";
            this.cEPCliDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPCliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cEPCliDataGridViewTextBoxColumn.Name = "cEPCliDataGridViewTextBoxColumn";
            this.cEPCliDataGridViewTextBoxColumn.ReadOnly = true;
            this.cEPCliDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefoneCLIDataGridViewTextBoxColumn
            // 
            this.telefoneCLIDataGridViewTextBoxColumn.DataPropertyName = "Telefone_CLI";
            this.telefoneCLIDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneCLIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneCLIDataGridViewTextBoxColumn.Name = "telefoneCLIDataGridViewTextBoxColumn";
            this.telefoneCLIDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneCLIDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbclienteBindingSource
            // 
            this.tbclienteBindingSource.DataMember = "tb_cliente";
            this.tbclienteBindingSource.DataSource = this.db_DPSPDataSet;
            // 
            // db_DPSPDataSet
            // 
            this.db_DPSPDataSet.DataSetName = "db_DPSPDataSet";
            this.db_DPSPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // btn_findAll
            // 
            this.btn_findAll.AllowDrop = true;
            this.btn_findAll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_findAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_findAll.Location = new System.Drawing.Point(886, 44);
            this.btn_findAll.Margin = new System.Windows.Forms.Padding(4);
            this.btn_findAll.Name = "btn_findAll";
            this.btn_findAll.Size = new System.Drawing.Size(100, 28);
            this.btn_findAll.TabIndex = 3;
            this.btn_findAll.Text = "Todos";
            this.btn_findAll.UseVisualStyleBackColor = false;
            this.btn_findAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_busca
            // 
            this.btn_busca.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_busca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_busca.Location = new System.Drawing.Point(778, 44);
            this.btn_busca.Margin = new System.Windows.Forms.Padding(4);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(100, 28);
            this.btn_busca.TabIndex = 2;
            this.btn_busca.Text = "Buscar";
            this.btn_busca.UseVisualStyleBackColor = false;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // txt_buscanome
            // 
            this.txt_buscanome.Location = new System.Drawing.Point(158, 41);
            this.txt_buscanome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscanome.Name = "txt_buscanome";
            this.txt_buscanome.Size = new System.Drawing.Size(553, 22);
            this.txt_buscanome.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nome";
            // 
            // Consulta
            // 
            this.Consulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Consulta.Controls.Add(this.btn_findAll);
            this.Consulta.Controls.Add(this.label7);
            this.Consulta.Controls.Add(this.btn_busca);
            this.Consulta.Controls.Add(this.txt_buscanome);
            this.Consulta.Location = new System.Drawing.Point(39, 400);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(1012, 100);
            this.Consulta.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_id_cli);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_deletar);
            this.panel1.Controls.Add(this.txt_numero_cli);
            this.panel1.Controls.Add(this.lbl_nome_cli);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_nome_cli);
            this.panel1.Controls.Add(this.txt_cep_cli);
            this.panel1.Controls.Add(this.btn_inserir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_endereco_cli);
            this.panel1.Controls.Add(this.txt_telefone_cli);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_endereco_cli);
            this.panel1.Controls.Add(this.txt_uf_cli);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_cidade_cli);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_bairro_cli);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(39, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 298);
            this.panel1.TabIndex = 5;
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_deletar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_deletar.Location = new System.Drawing.Point(886, 245);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(110, 28);
            this.btn_deletar.TabIndex = 19;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_inserir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_inserir.Location = new System.Drawing.Point(671, 246);
            this.btn_inserir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(100, 28);
            this.btn_inserir.TabIndex = 12;
            this.btn_inserir.Text = "Salvar";
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Informações";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Consulta";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancelar.Location = new System.Drawing.Point(778, 245);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 29);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Id";
            // 
            // txt_id_cli
            // 
            this.txt_id_cli.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_id_cli.Enabled = false;
            this.txt_id_cli.Location = new System.Drawing.Point(158, 22);
            this.txt_id_cli.Name = "txt_id_cli";
            this.txt_id_cli.Size = new System.Drawing.Size(90, 24);
            this.txt_id_cli.TabIndex = 22;
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(976, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(64, 49);
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sair.Location = new System.Drawing.Point(927, 726);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 28);
            this.btn_sair.TabIndex = 9;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Frm_CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1077, 766);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Consulta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_CadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DPSPDataSet)).EndInit();
            this.Consulta.ResumeLayout(false);
            this.Consulta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txt_cep_cli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_telefone_cli;
        private System.Windows.Forms.TextBox txt_uf_cli;
        private System.Windows.Forms.TextBox txt_cidade_cli;
        private System.Windows.Forms.TextBox txt_bairro_cli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_endereco_cli;
        private System.Windows.Forms.TextBox txt_nome_cli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_endereco_cli;
        private System.Windows.Forms.Label lbl_nome_cli;
        private System.Windows.Forms.TextBox txt_numero_cli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_DPSPDataSet db_DPSPDataSet;
        private System.Windows.Forms.BindingSource tbclienteBindingSource;
        private db_DPSPDataSetTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.TextBox txt_buscanome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_findAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel Consulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_id_cli;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btn_sair;
    }
}

