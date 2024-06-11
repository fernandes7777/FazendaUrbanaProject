namespace FazendaUrbana
{
    partial class FrmSupplierUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox4 = new GroupBox();
            contactIdTxt = new TextBox();
            label17 = new Label();
            label15 = new Label();
            phoneTxt = new TextBox();
            contactBindingSource = new BindingSource(components);
            label20 = new Label();
            emailTxt = new TextBox();
            supplierBindingSource = new BindingSource(components);
            groupBox3 = new GroupBox();
            addressIdTxt = new TextBox();
            label16 = new Label();
            countryComboBox = new ComboBox();
            addressBindingSource = new BindingSource(components);
            label14 = new Label();
            complementTxt = new TextBox();
            label13 = new Label();
            numberTxt = new TextBox();
            label7 = new Label();
            stateCbx = new ComboBox();
            label12 = new Label();
            neighborhoodTxt = new TextBox();
            label8 = new Label();
            zipCodeTxt = new TextBox();
            label9 = new Label();
            cityTxt = new TextBox();
            label10 = new Label();
            streetTxt = new TextBox();
            label11 = new Label();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            label1 = new Label();
            radioButton1 = new RadioButton();
            supplierIdTxt = new TextBox();
            label6 = new Label();
            taxIdTextBox = new MaskedTextBox();
            companyNameTxt = new TextBox();
            label5 = new Label();
            tradeNameTxt = new TextBox();
            label4 = new Label();
            nameTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            supplierGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tradeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            companyNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taxIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierBindingSource1 = new BindingSource(components);
            groupBox1 = new GroupBox();
            saveBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnClear = new Button();
            btnSearch = new Button();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addressBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)supplierGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(contactIdTxt);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(phoneTxt);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(emailTxt);
            groupBox4.Location = new Point(12, 448);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(791, 127);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Contato";
            // 
            // contactIdTxt
            // 
            contactIdTxt.Location = new Point(690, 22);
            contactIdTxt.Name = "contactIdTxt";
            contactIdTxt.ReadOnly = true;
            contactIdTxt.Size = new Size(49, 23);
            contactIdTxt.TabIndex = 20;
            contactIdTxt.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(638, 25);
            label17.Name = "label17";
            label17.Size = new Size(46, 15);
            label17.TabIndex = 18;
            label17.Text = "Código";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(392, 70);
            label15.Name = "label15";
            label15.Size = new Size(41, 15);
            label15.TabIndex = 6;
            label15.Text = "E-mail";
            // 
            // phoneTxt
            // 
            phoneTxt.DataBindings.Add(new Binding("Text", contactBindingSource, "Phone", true, DataSourceUpdateMode.OnPropertyChanged));
            phoneTxt.Location = new Point(13, 88);
            phoneTxt.Name = "phoneTxt";
            phoneTxt.Size = new Size(344, 23);
            phoneTxt.TabIndex = 0;
            // 
            // contactBindingSource
            // 
            contactBindingSource.DataSource = typeof(Forms.Model.Contact);
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(13, 70);
            label20.Name = "label20";
            label20.Size = new Size(51, 15);
            label20.TabIndex = 4;
            label20.Text = "Telefone";
            // 
            // emailTxt
            // 
            emailTxt.DataBindings.Add(new Binding("Text", contactBindingSource, "Email", true, DataSourceUpdateMode.OnPropertyChanged));
            emailTxt.Location = new Point(393, 88);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(346, 23);
            emailTxt.TabIndex = 1;
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(Forms.Model.Supplier);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(addressIdTxt);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(countryComboBox);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(complementTxt);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(numberTxt);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(stateCbx);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(neighborhoodTxt);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(zipCodeTxt);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(cityTxt);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(streetTxt);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(12, 216);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(791, 226);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Endereço";
            // 
            // addressIdTxt
            // 
            addressIdTxt.Location = new Point(690, 22);
            addressIdTxt.Name = "addressIdTxt";
            addressIdTxt.ReadOnly = true;
            addressIdTxt.Size = new Size(49, 23);
            addressIdTxt.TabIndex = 21;
            addressIdTxt.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(638, 25);
            label16.Name = "label16";
            label16.Size = new Size(46, 15);
            label16.TabIndex = 15;
            label16.Text = "Código";
            // 
            // countryComboBox
            // 
            countryComboBox.DataBindings.Add(new Binding("Text", addressBindingSource, "Country", true, DataSourceUpdateMode.OnPropertyChanged));
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(13, 82);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(90, 23);
            countryComboBox.TabIndex = 0;
            // 
            // addressBindingSource
            // 
            addressBindingSource.DataSource = typeof(Forms.Model.Address);
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 65);
            label14.Name = "label14";
            label14.Size = new Size(28, 15);
            label14.TabIndex = 16;
            label14.Text = "País";
            // 
            // complementTxt
            // 
            complementTxt.DataBindings.Add(new Binding("Text", addressBindingSource, "Complement", true, DataSourceUpdateMode.OnPropertyChanged));
            complementTxt.Location = new Point(15, 187);
            complementTxt.Name = "complementTxt";
            complementTxt.Size = new Size(344, 23);
            complementTxt.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 169);
            label13.Name = "label13";
            label13.Size = new Size(84, 15);
            label13.TabIndex = 14;
            label13.Text = "Complemento";
            // 
            // numberTxt
            // 
            numberTxt.DataBindings.Add(new Binding("Text", addressBindingSource, "Number", true, DataSourceUpdateMode.OnPropertyChanged));
            numberTxt.Location = new Point(393, 131);
            numberTxt.Name = "numberTxt";
            numberTxt.Size = new Size(61, 23);
            numberTxt.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(393, 113);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 12;
            label7.Text = "Número";
            // 
            // stateCbx
            // 
            stateCbx.DataBindings.Add(new Binding("Text", addressBindingSource, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            stateCbx.FormattingEnabled = true;
            stateCbx.Location = new Point(690, 82);
            stateCbx.Name = "stateCbx";
            stateCbx.Size = new Size(49, 23);
            stateCbx.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(690, 64);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 10;
            label12.Text = "Estado";
            // 
            // neighborhoodTxt
            // 
            neighborhoodTxt.DataBindings.Add(new Binding("Text", addressBindingSource, "Neighborhood", true, DataSourceUpdateMode.OnPropertyChanged));
            neighborhoodTxt.Location = new Point(13, 132);
            neighborhoodTxt.Name = "neighborhoodTxt";
            neighborhoodTxt.Size = new Size(346, 23);
            neighborhoodTxt.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 114);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 6;
            label8.Text = "Bairro";
            // 
            // zipCodeTxt
            // 
            zipCodeTxt.DataBindings.Add(new Binding("Text", addressBindingSource, "ZipCode", true, DataSourceUpdateMode.OnPropertyChanged));
            zipCodeTxt.Location = new Point(145, 83);
            zipCodeTxt.Name = "zipCodeTxt";
            zipCodeTxt.Size = new Size(212, 23);
            zipCodeTxt.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(145, 65);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 4;
            label9.Text = "CEP";
            // 
            // cityTxt
            // 
            cityTxt.DataBindings.Add(new Binding("Text", addressBindingSource, "City", true, DataSourceUpdateMode.OnPropertyChanged));
            cityTxt.Location = new Point(393, 82);
            cityTxt.Name = "cityTxt";
            cityTxt.Size = new Size(261, 23);
            cityTxt.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(393, 64);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 2;
            label10.Text = "Cidade";
            // 
            // streetTxt
            // 
            streetTxt.DataBindings.Add(new Binding("Text", addressBindingSource, "Street", true, DataSourceUpdateMode.OnPropertyChanged));
            streetTxt.Location = new Point(490, 131);
            streetTxt.Name = "streetTxt";
            streetTxt.Size = new Size(249, 23);
            streetTxt.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(490, 113);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 0;
            label11.Text = "Logradouro";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(supplierIdTxt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(taxIdTextBox);
            groupBox2.Controls.Add(companyNameTxt);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(tradeNameTxt);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(nameTxt);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(791, 198);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fornecedor";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(74, 53);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Jurídica";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 32);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 23;
            label1.Text = "Tipo de pessoa";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 53);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(54, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Física";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // supplierIdTxt
            // 
            supplierIdTxt.Location = new Point(688, 24);
            supplierIdTxt.Name = "supplierIdTxt";
            supplierIdTxt.ReadOnly = true;
            supplierIdTxt.Size = new Size(49, 23);
            supplierIdTxt.TabIndex = 22;
            supplierIdTxt.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(636, 27);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 13;
            label6.Text = "Código";
            // 
            // taxIdTextBox
            // 
            taxIdTextBox.DataBindings.Add(new Binding("Text", supplierBindingSource, "TaxId", true, DataSourceUpdateMode.OnPropertyChanged));
            taxIdTextBox.Location = new Point(11, 99);
            taxIdTextBox.Name = "taxIdTextBox";
            taxIdTextBox.ReadOnly = true;
            taxIdTextBox.Size = new Size(344, 23);
            taxIdTextBox.TabIndex = 2;
            // 
            // companyNameTxt
            // 
            companyNameTxt.DataBindings.Add(new Binding("Text", supplierBindingSource, "CompanyName", true, DataSourceUpdateMode.OnPropertyChanged));
            companyNameTxt.Location = new Point(391, 154);
            companyNameTxt.Name = "companyNameTxt";
            companyNameTxt.Size = new Size(346, 23);
            companyNameTxt.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 136);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 6;
            label5.Text = "Razão Social";
            // 
            // tradeNameTxt
            // 
            tradeNameTxt.DataBindings.Add(new Binding("Text", supplierBindingSource, "TradeName", true, DataSourceUpdateMode.OnPropertyChanged));
            tradeNameTxt.Location = new Point(11, 154);
            tradeNameTxt.Name = "tradeNameTxt";
            tradeNameTxt.Size = new Size(346, 23);
            tradeNameTxt.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 136);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 4;
            label4.Text = "Nome Fantasia";
            // 
            // nameTxt
            // 
            nameTxt.DataBindings.Add(new Binding("Text", supplierBindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            nameTxt.Location = new Point(391, 99);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(346, 23);
            nameTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 81);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 81);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "CPF/CNPJ";
            // 
            // supplierGridView
            // 
            supplierGridView.AllowUserToAddRows = false;
            supplierGridView.AllowUserToOrderColumns = true;
            supplierGridView.AutoGenerateColumns = false;
            supplierGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            supplierGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, tradeNameDataGridViewTextBoxColumn, companyNameDataGridViewTextBoxColumn, taxIdDataGridViewTextBoxColumn, addressIdDataGridViewTextBoxColumn, contactIdDataGridViewTextBoxColumn });
            supplierGridView.DataSource = supplierBindingSource1;
            supplierGridView.Location = new Point(11, 22);
            supplierGridView.Name = "supplierGridView";
            supplierGridView.ReadOnly = true;
            supplierGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            supplierGridView.Size = new Size(766, 273);
            supplierGridView.TabIndex = 23;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tradeNameDataGridViewTextBoxColumn
            // 
            tradeNameDataGridViewTextBoxColumn.DataPropertyName = "TradeName";
            tradeNameDataGridViewTextBoxColumn.HeaderText = "TradeName";
            tradeNameDataGridViewTextBoxColumn.Name = "tradeNameDataGridViewTextBoxColumn";
            tradeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxIdDataGridViewTextBoxColumn
            // 
            taxIdDataGridViewTextBoxColumn.DataPropertyName = "TaxId";
            taxIdDataGridViewTextBoxColumn.HeaderText = "TaxId";
            taxIdDataGridViewTextBoxColumn.Name = "taxIdDataGridViewTextBoxColumn";
            taxIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressIdDataGridViewTextBoxColumn
            // 
            addressIdDataGridViewTextBoxColumn.DataPropertyName = "AddressId";
            addressIdDataGridViewTextBoxColumn.HeaderText = "AddressId";
            addressIdDataGridViewTextBoxColumn.Name = "addressIdDataGridViewTextBoxColumn";
            addressIdDataGridViewTextBoxColumn.ReadOnly = true;
            addressIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // contactIdDataGridViewTextBoxColumn
            // 
            contactIdDataGridViewTextBoxColumn.DataPropertyName = "ContactId";
            contactIdDataGridViewTextBoxColumn.HeaderText = "ContactId";
            contactIdDataGridViewTextBoxColumn.Name = "contactIdDataGridViewTextBoxColumn";
            contactIdDataGridViewTextBoxColumn.ReadOnly = true;
            contactIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // supplierBindingSource1
            // 
            supplierBindingSource1.DataSource = typeof(Forms.Model.Supplier);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(supplierGridView);
            groupBox1.Location = new Point(12, 581);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(791, 312);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fornecedores";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(328, 899);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 34);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Salvar";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(528, 899);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(87, 35);
            editBtn.TabIndex = 5;
            editBtn.Text = "Editar";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(621, 899);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(88, 35);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Deletar";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(715, 899);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 35);
            btnClear.TabIndex = 7;
            btnClear.Text = "Limpar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(428, 899);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 34);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Pesquisar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // FrmSupplierUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(saveBtn);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "FrmSupplierUC";
            Size = new Size(808, 949);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addressBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)supplierGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Label label15;
        private TextBox phoneTxt;
        private Label label20;
        private TextBox emailTxt;
        private GroupBox groupBox3;
        private ComboBox countryComboBox;
        private Label label14;
        private TextBox complementTxt;
        private Label label13;
        private TextBox numberTxt;
        private Label label7;
        private ComboBox stateCbx;
        private Label label12;
        private TextBox neighborhoodTxt;
        private Label label8;
        private TextBox zipCodeTxt;
        private Label label9;
        private TextBox cityTxt;
        private Label label10;
        private TextBox streetTxt;
        private Label label11;
        private GroupBox groupBox2;
        private TextBox companyNameTxt;
        private Label label5;
        private TextBox tradeNameTxt;
        private Label label4;
        private TextBox nameTxt;
        private Label label3;
        private Label label2;
        private DataGridView supplierGridView;
        private GroupBox groupBox1;
        private BindingSource supplierBindingSource;
        private BindingSource addressBindingSource;
        private MaskedTextBox taxIdTextBox;
        private BindingSource contactBindingSource;
        private BindingSource supplierBindingSource1;
        private Button saveBtn;
        private Button editBtn;
        private Button deleteBtn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tradeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactIdDataGridViewTextBoxColumn;
        private ErrorProvider errorProvider1;
        private TextBox supplierIdTxt;
        private Label label6;
        private TextBox contactIdTxt;
        private Label label17;
        private TextBox addressIdTxt;
        private Label label16;
        private Button btnClear;
        private RadioButton radioButton2;
        private Label label1;
        private RadioButton radioButton1;
        private Button btnSearch;
    }
}
