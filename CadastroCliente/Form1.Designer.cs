
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
            this.txt_numeroCli = new System.Windows.Forms.TextBox();
            this.lblNumeroCli = new System.Windows.Forms.Label();
            this.txt_cepCli = new System.Windows.Forms.MaskedTextBox();
            this.lblCepCli = new System.Windows.Forms.Label();
            this.txt_telefoneCli = new System.Windows.Forms.MaskedTextBox();
            this.txt_ufCli = new System.Windows.Forms.TextBox();
            this.txt_cidadeCli = new System.Windows.Forms.TextBox();
            this.txt_bairroCli = new System.Windows.Forms.TextBox();
            this.lblUFCli = new System.Windows.Forms.Label();
            this.lblCidadeCli = new System.Windows.Forms.Label();
            this.lblBairroCli = new System.Windows.Forms.Label();
            this.txt_enderecoCli = new System.Windows.Forms.TextBox();
            this.txt_nomeCli = new System.Windows.Forms.TextBox();
            this.lblTelefoneCli = new System.Windows.Forms.Label();
            this.lblEnderecoCli = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEPCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_DPSPDataSet = new CadastroCliente.db_DPSPDataSet();
            this.btn_findAll = new System.Windows.Forms.Button();
            this.btn_busca = new System.Windows.Forms.Button();
            this.txt_buscaNome = new System.Windows.Forms.TextBox();
            this.Consulta = new System.Windows.Forms.Panel();
            this.cmb_campo = new System.Windows.Forms.ComboBox();
            this.pnlInformacoes = new System.Windows.Forms.Panel();
            this.cmb_ufCli = new System.Windows.Forms.ComboBox();
            this.tbUFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_DPSPDataSet11 = new CadastroCliente.db_DPSPDataSet1();
            this.txt_idCli = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.lblInformacoes = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.tb_clienteTableAdapter = new CadastroCliente.db_DPSPDataSetTableAdapters.tb_clienteTableAdapter();
            this.db_DPSPDataSet1 = new CadastroCliente.db_DPSPDataSet();
            this.dbDPSPDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbclienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbDPSPDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbclienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbclienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_UFTableAdapter = new CadastroCliente.db_DPSPDataSet1TableAdapters.tb_UFTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DPSPDataSet)).BeginInit();
            this.Consulta.SuspendLayout();
            this.pnlInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DPSPDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DPSPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDPSPDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDPSPDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_numeroCli
            // 
            this.txt_numeroCli.Location = new System.Drawing.Point(793, 102);
            this.txt_numeroCli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numeroCli.Name = "txt_numeroCli";
            this.txt_numeroCli.Size = new System.Drawing.Size(55, 24);
            this.txt_numeroCli.TabIndex = 17;
            // 
            // lblNumeroCli
            // 
            this.lblNumeroCli.AutoSize = true;
            this.lblNumeroCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCli.Location = new System.Drawing.Point(721, 105);
            this.lblNumeroCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroCli.Name = "lblNumeroCli";
            this.lblNumeroCli.Size = new System.Drawing.Size(62, 18);
            this.lblNumeroCli.TabIndex = 16;
            this.lblNumeroCli.Text = "Número";
            // 
            // txt_cepCli
            // 
            this.txt_cepCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cepCli.Location = new System.Drawing.Point(158, 178);
            this.txt_cepCli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cepCli.Mask = "00000-000";
            this.txt_cepCli.Name = "txt_cepCli";
            this.txt_cepCli.Size = new System.Drawing.Size(130, 24);
            this.txt_cepCli.TabIndex = 15;
            // 
            // lblCepCli
            // 
            this.lblCepCli.AutoSize = true;
            this.lblCepCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepCli.Location = new System.Drawing.Point(40, 184);
            this.lblCepCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCepCli.Name = "lblCepCli";
            this.lblCepCli.Size = new System.Drawing.Size(39, 18);
            this.lblCepCli.TabIndex = 14;
            this.lblCepCli.Text = "CEP";
            // 
            // txt_telefoneCli
            // 
            this.txt_telefoneCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefoneCli.Location = new System.Drawing.Point(158, 217);
            this.txt_telefoneCli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefoneCli.Mask = "(00)00000-0000";
            this.txt_telefoneCli.Name = "txt_telefoneCli";
            this.txt_telefoneCli.Size = new System.Drawing.Size(130, 24);
            this.txt_telefoneCli.TabIndex = 13;
            // 
            // txt_ufCli
            // 
            this.txt_ufCli.Location = new System.Drawing.Point(793, 141);
            this.txt_ufCli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ufCli.Name = "txt_ufCli";
            this.txt_ufCli.Size = new System.Drawing.Size(40, 24);
            this.txt_ufCli.TabIndex = 11;
            // 
            // txt_cidadeCli
            // 
            this.txt_cidadeCli.Location = new System.Drawing.Point(450, 141);
            this.txt_cidadeCli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cidadeCli.Name = "txt_cidadeCli";
            this.txt_cidadeCli.Size = new System.Drawing.Size(261, 24);
            this.txt_cidadeCli.TabIndex = 10;
            // 
            // txt_bairroCli
            // 
            this.txt_bairroCli.Location = new System.Drawing.Point(158, 141);
            this.txt_bairroCli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bairroCli.Name = "txt_bairroCli";
            this.txt_bairroCli.Size = new System.Drawing.Size(207, 24);
            this.txt_bairroCli.TabIndex = 9;
            // 
            // lblUFCli
            // 
            this.lblUFCli.AutoSize = true;
            this.lblUFCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUFCli.Location = new System.Drawing.Point(725, 146);
            this.lblUFCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUFCli.Name = "lblUFCli";
            this.lblUFCli.Size = new System.Drawing.Size(28, 18);
            this.lblUFCli.TabIndex = 8;
            this.lblUFCli.Text = "UF";
            // 
            // lblCidadeCli
            // 
            this.lblCidadeCli.AutoSize = true;
            this.lblCidadeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeCli.Location = new System.Drawing.Point(389, 146);
            this.lblCidadeCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidadeCli.Name = "lblCidadeCli";
            this.lblCidadeCli.Size = new System.Drawing.Size(54, 18);
            this.lblCidadeCli.TabIndex = 7;
            this.lblCidadeCli.Text = "Cidade";
            // 
            // lblBairroCli
            // 
            this.lblBairroCli.AutoSize = true;
            this.lblBairroCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroCli.Location = new System.Drawing.Point(40, 146);
            this.lblBairroCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairroCli.Name = "lblBairroCli";
            this.lblBairroCli.Size = new System.Drawing.Size(48, 18);
            this.lblBairroCli.TabIndex = 6;
            this.lblBairroCli.Text = "Bairro";
            // 
            // txt_enderecoCli
            // 
            this.txt_enderecoCli.Location = new System.Drawing.Point(158, 102);
            this.txt_enderecoCli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_enderecoCli.Name = "txt_enderecoCli";
            this.txt_enderecoCli.Size = new System.Drawing.Size(553, 24);
            this.txt_enderecoCli.TabIndex = 4;
            // 
            // txt_nomeCli
            // 
            this.txt_nomeCli.Location = new System.Drawing.Point(158, 57);
            this.txt_nomeCli.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nomeCli.Name = "txt_nomeCli";
            this.txt_nomeCli.Size = new System.Drawing.Size(553, 24);
            this.txt_nomeCli.TabIndex = 3;
            // 
            // lblTelefoneCli
            // 
            this.lblTelefoneCli.AutoSize = true;
            this.lblTelefoneCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCli.Location = new System.Drawing.Point(40, 221);
            this.lblTelefoneCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefoneCli.Name = "lblTelefoneCli";
            this.lblTelefoneCli.Size = new System.Drawing.Size(65, 18);
            this.lblTelefoneCli.TabIndex = 2;
            this.lblTelefoneCli.Text = "Telefone";
            // 
            // lblEnderecoCli
            // 
            this.lblEnderecoCli.AutoSize = true;
            this.lblEnderecoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoCli.Location = new System.Drawing.Point(40, 105);
            this.lblEnderecoCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnderecoCli.Name = "lblEnderecoCli";
            this.lblEnderecoCli.Size = new System.Drawing.Size(72, 18);
            this.lblEnderecoCli.TabIndex = 1;
            this.lblEnderecoCli.Text = "Endereço";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCli.Location = new System.Drawing.Point(40, 60);
            this.lblNomeCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(49, 18);
            this.lblNomeCli.TabIndex = 0;
            this.lblNomeCli.Text = "Nome";
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
            this.CEPCliDataGridViewTextBoxColumn,
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
            // CEPCliDataGridViewTextBoxColumn
            // 
            this.CEPCliDataGridViewTextBoxColumn.DataPropertyName = "CEP_Cli";
            this.CEPCliDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.CEPCliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.CEPCliDataGridViewTextBoxColumn.Name = "CEPCliDataGridViewTextBoxColumn";
            this.CEPCliDataGridViewTextBoxColumn.ReadOnly = true;
            this.CEPCliDataGridViewTextBoxColumn.Width = 125;
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
            // btn_findAll
            // 
            this.btn_findAll.AllowDrop = true;
            this.btn_findAll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_findAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_findAll.Location = new System.Drawing.Point(886, 39);
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
            this.btn_busca.Location = new System.Drawing.Point(778, 39);
            this.btn_busca.Margin = new System.Windows.Forms.Padding(4);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(100, 28);
            this.btn_busca.TabIndex = 2;
            this.btn_busca.Text = "Buscar";
            this.btn_busca.UseVisualStyleBackColor = false;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // txt_buscaNome
            // 
            this.txt_buscaNome.Location = new System.Drawing.Point(158, 41);
            this.txt_buscaNome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscaNome.Name = "txt_buscaNome";
            this.txt_buscaNome.Size = new System.Drawing.Size(553, 22);
            this.txt_buscaNome.TabIndex = 1;
            // 
            // Consulta
            // 
            this.Consulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Consulta.Controls.Add(this.cmb_campo);
            this.Consulta.Controls.Add(this.btn_findAll);
            this.Consulta.Controls.Add(this.btn_busca);
            this.Consulta.Controls.Add(this.txt_buscaNome);
            this.Consulta.Location = new System.Drawing.Point(39, 400);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(1012, 100);
            this.Consulta.TabIndex = 3;
            // 
            // cmb_campo
            // 
            this.cmb_campo.FormattingEnabled = true;
            this.cmb_campo.Items.AddRange(new object[] {
            "Nome",
            "Endereço",
            "Bairro",
            "Cidade",
            "UF"});
            this.cmb_campo.Location = new System.Drawing.Point(21, 41);
            this.cmb_campo.Name = "cmb_campo";
            this.cmb_campo.Size = new System.Drawing.Size(121, 24);
            this.cmb_campo.TabIndex = 4;
            this.cmb_campo.SelectedIndexChanged += new System.EventHandler(this.cmb_campo_SelectedIndexChanged);
            // 
            // pnlInformacoes
            // 
            this.pnlInformacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInformacoes.Controls.Add(this.cmb_ufCli);
            this.pnlInformacoes.Controls.Add(this.txt_idCli);
            this.pnlInformacoes.Controls.Add(this.lblIdCli);
            this.pnlInformacoes.Controls.Add(this.btn_cancelar);
            this.pnlInformacoes.Controls.Add(this.btn_deletar);
            this.pnlInformacoes.Controls.Add(this.txt_numeroCli);
            this.pnlInformacoes.Controls.Add(this.lblNomeCli);
            this.pnlInformacoes.Controls.Add(this.lblNumeroCli);
            this.pnlInformacoes.Controls.Add(this.txt_nomeCli);
            this.pnlInformacoes.Controls.Add(this.txt_cepCli);
            this.pnlInformacoes.Controls.Add(this.btn_inserir);
            this.pnlInformacoes.Controls.Add(this.lblCepCli);
            this.pnlInformacoes.Controls.Add(this.lblEnderecoCli);
            this.pnlInformacoes.Controls.Add(this.txt_telefoneCli);
            this.pnlInformacoes.Controls.Add(this.lblTelefoneCli);
            this.pnlInformacoes.Controls.Add(this.txt_enderecoCli);
            this.pnlInformacoes.Controls.Add(this.txt_ufCli);
            this.pnlInformacoes.Controls.Add(this.lblBairroCli);
            this.pnlInformacoes.Controls.Add(this.txt_cidadeCli);
            this.pnlInformacoes.Controls.Add(this.lblCidadeCli);
            this.pnlInformacoes.Controls.Add(this.txt_bairroCli);
            this.pnlInformacoes.Controls.Add(this.lblUFCli);
            this.pnlInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlInformacoes.Location = new System.Drawing.Point(39, 58);
            this.pnlInformacoes.Name = "pnlInformacoes";
            this.pnlInformacoes.Size = new System.Drawing.Size(1012, 298);
            this.pnlInformacoes.TabIndex = 5;
            // 
            // cmb_ufCli
            // 
            this.cmb_ufCli.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbUFBindingSource, "Nome_UF", true));
            this.cmb_ufCli.DataSource = this.tbUFBindingSource;
            this.cmb_ufCli.DisplayMember = "ID_UF";
            this.cmb_ufCli.FormattingEnabled = true;
            this.cmb_ufCli.Location = new System.Drawing.Point(793, 184);
            this.cmb_ufCli.Name = "cmb_ufCli";
            this.cmb_ufCli.Size = new System.Drawing.Size(121, 26);
            this.cmb_ufCli.TabIndex = 23;
            this.cmb_ufCli.ValueMember = "ID_UF";
            // 
            // tbUFBindingSource
            // 
            this.tbUFBindingSource.DataMember = "tb_UF";
            this.tbUFBindingSource.DataSource = this.db_DPSPDataSet11;
            // 
            // db_DPSPDataSet11
            // 
            this.db_DPSPDataSet11.DataSetName = "db_DPSPDataSet1";
            this.db_DPSPDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_idCli
            // 
            this.txt_idCli.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_idCli.Enabled = false;
            this.txt_idCli.Location = new System.Drawing.Point(158, 22);
            this.txt_idCli.Name = "txt_idCli";
            this.txt_idCli.Size = new System.Drawing.Size(90, 24);
            this.txt_idCli.TabIndex = 22;
            // 
            // lblIdCli
            // 
            this.lblIdCli.AutoSize = true;
            this.lblIdCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCli.Location = new System.Drawing.Point(40, 25);
            this.lblIdCli.Name = "lblIdCli";
            this.lblIdCli.Size = new System.Drawing.Size(19, 18);
            this.lblIdCli.TabIndex = 21;
            this.lblIdCli.Text = "Id";
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
            // lblInformacoes
            // 
            this.lblInformacoes.AutoSize = true;
            this.lblInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacoes.Location = new System.Drawing.Point(58, 48);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(112, 20);
            this.lblInformacoes.TabIndex = 6;
            this.lblInformacoes.Text = "Informações";
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(63, 392);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(83, 20);
            this.lblConsulta.TabIndex = 7;
            this.lblConsulta.Text = "Consulta";
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
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // db_DPSPDataSet1
            // 
            this.db_DPSPDataSet1.DataSetName = "db_DPSPDataSet";
            this.db_DPSPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbDPSPDataSet1BindingSource
            // 
            this.dbDPSPDataSet1BindingSource.DataSource = this.db_DPSPDataSet1;
            this.dbDPSPDataSet1BindingSource.Position = 0;
            // 
            // tbclienteBindingSource1
            // 
            this.tbclienteBindingSource1.DataMember = "tb_cliente";
            this.tbclienteBindingSource1.DataSource = this.dbDPSPDataSet1BindingSource;
            // 
            // dbDPSPDataSet1BindingSource1
            // 
            this.dbDPSPDataSet1BindingSource1.DataSource = this.db_DPSPDataSet1;
            this.dbDPSPDataSet1BindingSource1.Position = 0;
            // 
            // tbclienteBindingSource2
            // 
            this.tbclienteBindingSource2.DataMember = "tb_cliente";
            this.tbclienteBindingSource2.DataSource = this.dbDPSPDataSet1BindingSource1;
            // 
            // tbclienteBindingSource3
            // 
            this.tbclienteBindingSource3.DataMember = "tb_cliente";
            this.tbclienteBindingSource3.DataSource = this.dbDPSPDataSet1BindingSource1;
            // 
            // tb_UFTableAdapter
            // 
            this.tb_UFTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1077, 774);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.lblInformacoes);
            this.Controls.Add(this.pnlInformacoes);
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
            this.pnlInformacoes.ResumeLayout(false);
            this.pnlInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DPSPDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DPSPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDPSPDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDPSPDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txt_cepCli;
        private System.Windows.Forms.Label lblCepCli;
        private System.Windows.Forms.MaskedTextBox txt_telefoneCli;
        private System.Windows.Forms.TextBox txt_ufCli;
        private System.Windows.Forms.TextBox txt_cidadeCli;
        private System.Windows.Forms.TextBox txt_bairroCli;
        private System.Windows.Forms.Label lblUFCli;
        private System.Windows.Forms.Label lblCidadeCli;
        private System.Windows.Forms.Label lblBairroCli;
        private System.Windows.Forms.TextBox txt_enderecoCli;
        private System.Windows.Forms.TextBox txt_nomeCli;
        private System.Windows.Forms.Label lblTelefoneCli;
        private System.Windows.Forms.Label lblEnderecoCli;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.TextBox txt_numeroCli;
        private System.Windows.Forms.Label lblNumeroCli;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_DPSPDataSet db_DPSPDataSet;
        private System.Windows.Forms.BindingSource tbclienteBindingSource;
        private db_DPSPDataSetTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.TextBox txt_buscaNome;
        private System.Windows.Forms.Button btn_findAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEPCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel Consulta;
        private System.Windows.Forms.Panel pnlInformacoes;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Label lblInformacoes;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_idCli;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ComboBox cmb_campo;
        private System.Windows.Forms.BindingSource dbDPSPDataSet1BindingSource;
        private db_DPSPDataSet db_DPSPDataSet1;
        private System.Windows.Forms.BindingSource tbclienteBindingSource1;
        private System.Windows.Forms.BindingSource dbDPSPDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource tbclienteBindingSource2;
        private System.Windows.Forms.BindingSource tbclienteBindingSource3;
        private System.Windows.Forms.ComboBox cmb_ufCli;
        private db_DPSPDataSet1 db_DPSPDataSet11;
        private System.Windows.Forms.BindingSource tbUFBindingSource;
        private db_DPSPDataSet1TableAdapters.tb_UFTableAdapter tb_UFTableAdapter;
    }
}

