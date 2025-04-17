namespace TEMPERO
{
    partial class FormCadCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.OpFem = new System.Windows.Forms.RadioButton();
            this.CkSituacao = new System.Windows.Forms.CheckBox();
            this.OpOutros = new System.Windows.Forms.RadioButton();
            this.OpMasc = new System.Windows.Forms.RadioButton();
            this.TxtNasc = new System.Windows.Forms.MaskedTextBox();
            this.TxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.TxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.TxtRG = new System.Windows.Forms.MaskedTextBox();
            this.TxtDoc = new System.Windows.Forms.MaskedTextBox();
            this.OpCPF = new System.Windows.Forms.RadioButton();
            this.OpCNPJ = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.CbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.CbEndereco = new System.Windows.Forms.ComboBox();
            this.CbBairro = new System.Windows.Forms.ComboBox();
            this.CbCidade = new System.Windows.Forms.ComboBox();
            this.ImgCliente = new System.Windows.Forms.PictureBox();
            this.BtAddFoto = new System.Windows.Forms.Button();
            this.BtRemoveFoto = new System.Windows.Forms.Button();
            this.BtFechar = new System.Windows.Forms.Button();
            this.BtNovo = new System.Windows.Forms.Button();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "RG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "CEP";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bairro";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(433, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cidade";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(460, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Estado Civil";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(631, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Data de Nascimento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 416);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "Celular";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(208, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 28);
            this.label13.TabIndex = 0;
            this.label13.Text = "E-mail";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(761, 273);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 28);
            this.label14.TabIndex = 2;
            this.label14.Text = "Nº";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 498);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 28);
            this.label15.TabIndex = 0;
            this.label15.Text = "Observações";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 618);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(187, 28);
            this.label16.TabIndex = 0;
            this.label16.Text = "Situação Cadastral";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // TxtObs
            // 
            this.TxtObs.BackColor = System.Drawing.Color.LavenderBlush;
            this.TxtObs.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObs.ForeColor = System.Drawing.Color.DimGray;
            this.TxtObs.Location = new System.Drawing.Point(21, 529);
            this.TxtObs.Multiline = true;
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.Size = new System.Drawing.Size(815, 83);
            this.TxtObs.TabIndex = 15;
            this.TxtObs.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // textBox17
            // 
            this.textBox17.ForeColor = System.Drawing.Color.DimGray;
            this.textBox17.Location = new System.Drawing.Point(-349, 630);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(74, 22);
            this.textBox17.TabIndex = 1;
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.Color.LavenderBlush;
            this.TxtId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtId.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.ForeColor = System.Drawing.Color.DimGray;
            this.TxtId.Location = new System.Drawing.Point(228, 72);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(74, 34);
            this.TxtId.TabIndex = 1;
            this.TxtId.TabStop = false;
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.Color.LavenderBlush;
            this.TxtNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtNome.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.ForeColor = System.Drawing.Color.DimGray;
            this.TxtNome.Location = new System.Drawing.Point(311, 72);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(525, 34);
            this.TxtNome.TabIndex = 0;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.LavenderBlush;
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtEmail.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.TxtEmail.Location = new System.Drawing.Point(205, 447);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(631, 34);
            this.TxtEmail.TabIndex = 14;
            this.TxtEmail.TextChanged += new System.EventHandler(this.textBox14_TextChanged_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(311, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 28);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nome do Cliente";
            // 
            // TxtNumero
            // 
            this.TxtNumero.BackColor = System.Drawing.Color.LavenderBlush;
            this.TxtNumero.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.ForeColor = System.Drawing.Color.DimGray;
            this.TxtNumero.Location = new System.Drawing.Point(731, 310);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(99, 34);
            this.TxtNumero.TabIndex = 9;
            // 
            // OpFem
            // 
            this.OpFem.AutoSize = true;
            this.OpFem.BackColor = System.Drawing.Color.Transparent;
            this.OpFem.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpFem.Location = new System.Drawing.Point(161, 3);
            this.OpFem.Name = "OpFem";
            this.OpFem.Size = new System.Drawing.Size(120, 32);
            this.OpFem.TabIndex = 0;
            this.OpFem.Text = "Feminino";
            this.OpFem.UseVisualStyleBackColor = false;
            // 
            // CkSituacao
            // 
            this.CkSituacao.AutoSize = true;
            this.CkSituacao.BackColor = System.Drawing.Color.Transparent;
            this.CkSituacao.Checked = true;
            this.CkSituacao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkSituacao.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkSituacao.Location = new System.Drawing.Point(226, 618);
            this.CkSituacao.Name = "CkSituacao";
            this.CkSituacao.Size = new System.Drawing.Size(85, 32);
            this.CkSituacao.TabIndex = 4;
            this.CkSituacao.TabStop = false;
            this.CkSituacao.Text = "Ativo";
            this.CkSituacao.UseVisualStyleBackColor = false;
            // 
            // OpOutros
            // 
            this.OpOutros.AutoSize = true;
            this.OpOutros.BackColor = System.Drawing.Color.Transparent;
            this.OpOutros.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpOutros.Location = new System.Drawing.Point(293, 4);
            this.OpOutros.Name = "OpOutros";
            this.OpOutros.Size = new System.Drawing.Size(97, 32);
            this.OpOutros.TabIndex = 3;
            this.OpOutros.Text = "Outros";
            this.OpOutros.UseVisualStyleBackColor = false;
            // 
            // OpMasc
            // 
            this.OpMasc.AutoSize = true;
            this.OpMasc.BackColor = System.Drawing.Color.Transparent;
            this.OpMasc.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpMasc.Location = new System.Drawing.Point(9, 3);
            this.OpMasc.Name = "OpMasc";
            this.OpMasc.Size = new System.Drawing.Size(121, 32);
            this.OpMasc.TabIndex = 0;
            this.OpMasc.TabStop = true;
            this.OpMasc.Text = "Maculino";
            this.OpMasc.UseVisualStyleBackColor = false;
            // 
            // TxtNasc
            // 
            this.TxtNasc.BackColor = System.Drawing.Color.LavenderBlush;
            this.TxtNasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtNasc.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNasc.ForeColor = System.Drawing.Color.DimGray;
            this.TxtNasc.HidePromptOnLeave = true;
            this.TxtNasc.Location = new System.Drawing.Point(636, 234);
            this.TxtNasc.Mask = "00/00/0000";
            this.TxtNasc.Name = "TxtNasc";
            this.TxtNasc.Size = new System.Drawing.Size(136, 34);
            this.TxtNasc.TabIndex = 6;
            this.TxtNasc.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.TxtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // TxtCelular
            // 
            this.TxtCelular.BackColor = System.Drawing.Color.LavenderBlush;
            this.TxtCelular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtCelular.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelular.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCelular.HidePromptOnLeave = true;
            this.TxtCelular.Location = new System.Drawing.Point(23, 447);
            this.TxtCelular.Mask = "(00) - 00000 - 0000";
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(175, 34);
            this.TxtCelular.TabIndex = 13;
            this.TxtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // TxtCEP
            // 
            this.TxtCEP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtCEP.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCEP.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCEP.HidePromptOnLeave = true;
            this.TxtCEP.Location = new System.Drawing.Point(23, 310);
            this.TxtCEP.Mask = "00000-000";
            this.TxtCEP.Name = "TxtCEP";
            this.TxtCEP.Size = new System.Drawing.Size(148, 34);
            this.TxtCEP.TabIndex = 7;
            this.TxtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // TxtRG
            // 
            this.TxtRG.BackColor = System.Drawing.Color.LavenderBlush;
            this.TxtRG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtRG.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRG.ForeColor = System.Drawing.Color.DimGray;
            this.TxtRG.HidePromptOnLeave = true;
            this.TxtRG.Location = new System.Drawing.Point(232, 234);
            this.TxtRG.Mask = "00-000-000/0";
            this.TxtRG.Name = "TxtRG";
            this.TxtRG.Size = new System.Drawing.Size(203, 34);
            this.TxtRG.TabIndex = 4;
            this.TxtRG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // TxtDoc
            // 
            this.TxtDoc.BackColor = System.Drawing.Color.LavenderBlush;
            this.TxtDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtDoc.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDoc.ForeColor = System.Drawing.Color.DimGray;
            this.TxtDoc.HidePromptOnLeave = true;
            this.TxtDoc.Location = new System.Drawing.Point(228, 152);
            this.TxtDoc.Mask = "000-000-000-00";
            this.TxtDoc.Name = "TxtDoc";
            this.TxtDoc.Size = new System.Drawing.Size(205, 34);
            this.TxtDoc.TabIndex = 2;
            this.TxtDoc.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // OpCPF
            // 
            this.OpCPF.AutoSize = true;
            this.OpCPF.BackColor = System.Drawing.Color.Transparent;
            this.OpCPF.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpCPF.Location = new System.Drawing.Point(228, 116);
            this.OpCPF.Name = "OpCPF";
            this.OpCPF.Size = new System.Drawing.Size(67, 32);
            this.OpCPF.TabIndex = 1;
            this.OpCPF.TabStop = true;
            this.OpCPF.Text = "CPF";
            this.OpCPF.UseVisualStyleBackColor = false;
            // 
            // OpCNPJ
            // 
            this.OpCNPJ.AutoSize = true;
            this.OpCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.OpCNPJ.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpCNPJ.Location = new System.Drawing.Point(311, 116);
            this.OpCNPJ.Name = "OpCNPJ";
            this.OpCNPJ.Size = new System.Drawing.Size(82, 32);
            this.OpCNPJ.TabIndex = 3;
            this.OpCNPJ.TabStop = true;
            this.OpCNPJ.Text = "CNPJ";
            this.OpCNPJ.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.OpMasc);
            this.panel1.Controls.Add(this.OpOutros);
            this.panel1.Controls.Add(this.OpFem);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(433, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 40);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gênero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(662, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Estado";
            this.label7.Click += new System.EventHandler(this.label12_Click);
            // 
            // CbEstado
            // 
            this.CbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbEstado.BackColor = System.Drawing.Color.LavenderBlush;
            this.CbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbEstado.DropDownHeight = 200;
            this.CbEstado.DropDownWidth = 250;
            this.CbEstado.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEstado.ForeColor = System.Drawing.Color.DimGray;
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.IntegralHeight = false;
            this.CbEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins",
            "Distrito Federal"});
            this.CbEstado.Location = new System.Drawing.Point(667, 376);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(169, 36);
            this.CbEstado.TabIndex = 12;
            // 
            // CbEstadoCivil
            // 
            this.CbEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbEstadoCivil.BackColor = System.Drawing.Color.LavenderBlush;
            this.CbEstadoCivil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbEstadoCivil.DropDownHeight = 200;
            this.CbEstadoCivil.DropDownWidth = 100;
            this.CbEstadoCivil.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEstadoCivil.ForeColor = System.Drawing.Color.DimGray;
            this.CbEstadoCivil.FormattingEnabled = true;
            this.CbEstadoCivil.IntegralHeight = false;
            this.CbEstadoCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Divorciado(a)",
            "Separado(a)",
            "Solteiro(a)",
            "União Estável",
            "Viúvo(a)"});
            this.CbEstadoCivil.Location = new System.Drawing.Point(450, 234);
            this.CbEstadoCivil.Name = "CbEstadoCivil";
            this.CbEstadoCivil.Size = new System.Drawing.Size(169, 36);
            this.CbEstadoCivil.TabIndex = 5;
            // 
            // CbEndereco
            // 
            this.CbEndereco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbEndereco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbEndereco.BackColor = System.Drawing.Color.LavenderBlush;
            this.CbEndereco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbEndereco.DropDownHeight = 200;
            this.CbEndereco.DropDownWidth = 100;
            this.CbEndereco.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEndereco.ForeColor = System.Drawing.Color.DimGray;
            this.CbEndereco.FormattingEnabled = true;
            this.CbEndereco.IntegralHeight = false;
            this.CbEndereco.Location = new System.Drawing.Point(180, 310);
            this.CbEndereco.Name = "CbEndereco";
            this.CbEndereco.Size = new System.Drawing.Size(545, 36);
            this.CbEndereco.TabIndex = 8;
            // 
            // CbBairro
            // 
            this.CbBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbBairro.BackColor = System.Drawing.Color.LavenderBlush;
            this.CbBairro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbBairro.DropDownHeight = 200;
            this.CbBairro.DropDownWidth = 100;
            this.CbBairro.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbBairro.ForeColor = System.Drawing.Color.DimGray;
            this.CbBairro.FormattingEnabled = true;
            this.CbBairro.IntegralHeight = false;
            this.CbBairro.Location = new System.Drawing.Point(20, 374);
            this.CbBairro.Name = "CbBairro";
            this.CbBairro.Size = new System.Drawing.Size(386, 36);
            this.CbBairro.TabIndex = 10;
            // 
            // CbCidade
            // 
            this.CbCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbCidade.BackColor = System.Drawing.Color.LavenderBlush;
            this.CbCidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbCidade.DropDownHeight = 200;
            this.CbCidade.DropDownWidth = 100;
            this.CbCidade.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCidade.ForeColor = System.Drawing.Color.DimGray;
            this.CbCidade.FormattingEnabled = true;
            this.CbCidade.IntegralHeight = false;
            this.CbCidade.Location = new System.Drawing.Point(416, 376);
            this.CbCidade.Name = "CbCidade";
            this.CbCidade.Size = new System.Drawing.Size(245, 36);
            this.CbCidade.TabIndex = 11;
            // 
            // ImgCliente
            // 
            this.ImgCliente.BackColor = System.Drawing.Color.Transparent;
            this.ImgCliente.Image = ((System.Drawing.Image)(resources.GetObject("ImgCliente.Image")));
            this.ImgCliente.Location = new System.Drawing.Point(20, 18);
            this.ImgCliente.Name = "ImgCliente";
            this.ImgCliente.Size = new System.Drawing.Size(201, 209);
            this.ImgCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCliente.TabIndex = 9;
            this.ImgCliente.TabStop = false;
            // 
            // BtAddFoto
            // 
            this.BtAddFoto.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtAddFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtAddFoto.FlatAppearance.BorderSize = 0;
            this.BtAddFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.BtAddFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.BtAddFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAddFoto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAddFoto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtAddFoto.Image = ((System.Drawing.Image)(resources.GetObject("BtAddFoto.Image")));
            this.BtAddFoto.Location = new System.Drawing.Point(21, 229);
            this.BtAddFoto.Name = "BtAddFoto";
            this.BtAddFoto.Size = new System.Drawing.Size(132, 39);
            this.BtAddFoto.TabIndex = 10;
            this.BtAddFoto.TabStop = false;
            this.BtAddFoto.Text = "Imagem";
            this.BtAddFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAddFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtAddFoto.UseVisualStyleBackColor = false;
            // 
            // BtRemoveFoto
            // 
            this.BtRemoveFoto.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtRemoveFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtRemoveFoto.FlatAppearance.BorderSize = 0;
            this.BtRemoveFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.BtRemoveFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.BtRemoveFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRemoveFoto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRemoveFoto.ForeColor = System.Drawing.Color.Transparent;
            this.BtRemoveFoto.Image = ((System.Drawing.Image)(resources.GetObject("BtRemoveFoto.Image")));
            this.BtRemoveFoto.Location = new System.Drawing.Point(159, 229);
            this.BtRemoveFoto.Name = "BtRemoveFoto";
            this.BtRemoveFoto.Size = new System.Drawing.Size(54, 39);
            this.BtRemoveFoto.TabIndex = 10;
            this.BtRemoveFoto.TabStop = false;
            this.BtRemoveFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtRemoveFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtRemoveFoto.UseVisualStyleBackColor = false;
            this.BtRemoveFoto.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtFechar
            // 
            this.BtFechar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtFechar.FlatAppearance.BorderSize = 0;
            this.BtFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.BtFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.BtFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtFechar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFechar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtFechar.Image = ((System.Drawing.Image)(resources.GetObject("BtFechar.Image")));
            this.BtFechar.Location = new System.Drawing.Point(22, 662);
            this.BtFechar.Name = "BtFechar";
            this.BtFechar.Size = new System.Drawing.Size(132, 39);
            this.BtFechar.TabIndex = 10;
            this.BtFechar.TabStop = false;
            this.BtFechar.Text = "Fechar";
            this.BtFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtFechar.UseVisualStyleBackColor = false;
            // 
            // BtNovo
            // 
            this.BtNovo.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtNovo.FlatAppearance.BorderSize = 0;
            this.BtNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.BtNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.BtNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtNovo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNovo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtNovo.Image = ((System.Drawing.Image)(resources.GetObject("BtNovo.Image")));
            this.BtNovo.Location = new System.Drawing.Point(175, 662);
            this.BtNovo.Name = "BtNovo";
            this.BtNovo.Size = new System.Drawing.Size(132, 39);
            this.BtNovo.TabIndex = 10;
            this.BtNovo.TabStop = false;
            this.BtNovo.Text = "Novo";
            this.BtNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtNovo.UseVisualStyleBackColor = false;
            // 
            // BtSalvar
            // 
            this.BtSalvar.BackColor = System.Drawing.Color.GreenYellow;
            this.BtSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSalvar.FlatAppearance.BorderSize = 0;
            this.BtSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.BtSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.BtSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSalvar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalvar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtSalvar.Image")));
            this.BtSalvar.Location = new System.Drawing.Point(698, 662);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(132, 39);
            this.BtSalvar.TabIndex = 16;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtSalvar.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(346, 660);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 41);
            this.button6.TabIndex = 17;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadCliente_KeyDown);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(524, 660);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 41);
            this.button7.TabIndex = 17;
            this.button7.Text = "button6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadCliente_KeyDown);
            // 
            // FormCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::TEMPERO.Properties.Resources.gradiente_tempero2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 735);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.BtRemoveFoto);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.BtNovo);
            this.Controls.Add(this.BtFechar);
            this.Controls.Add(this.BtAddFoto);
            this.Controls.Add(this.ImgCliente);
            this.Controls.Add(this.CbCidade);
            this.Controls.Add(this.CbBairro);
            this.Controls.Add(this.CbEndereco);
            this.Controls.Add(this.CbEstadoCivil);
            this.Controls.Add(this.CbEstado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtCEP);
            this.Controls.Add(this.TxtRG);
            this.Controls.Add(this.TxtDoc);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.TxtNasc);
            this.Controls.Add(this.CkSituacao);
            this.Controls.Add(this.OpCNPJ);
            this.Controls.Add(this.OpCPF);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.TxtObs);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes :: Tempero Da Soso";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadCliente_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.RadioButton OpFem;
        private System.Windows.Forms.CheckBox CkSituacao;
        private System.Windows.Forms.RadioButton OpOutros;
        private System.Windows.Forms.RadioButton OpMasc;
        private System.Windows.Forms.MaskedTextBox TxtNasc;
        private System.Windows.Forms.MaskedTextBox TxtCelular;
        private System.Windows.Forms.MaskedTextBox TxtCEP;
        private System.Windows.Forms.MaskedTextBox TxtRG;
        private System.Windows.Forms.MaskedTextBox TxtDoc;
        private System.Windows.Forms.RadioButton OpCPF;
        private System.Windows.Forms.RadioButton OpCNPJ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.ComboBox CbEstadoCivil;
        private System.Windows.Forms.ComboBox CbEndereco;
        private System.Windows.Forms.ComboBox CbBairro;
        private System.Windows.Forms.ComboBox CbCidade;
        private System.Windows.Forms.PictureBox ImgCliente;
        private System.Windows.Forms.Button BtAddFoto;
        private System.Windows.Forms.Button BtRemoveFoto;
        private System.Windows.Forms.Button BtFechar;
        private System.Windows.Forms.Button BtNovo;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

