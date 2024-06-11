using FazendaUrbana.Forms.Model;

namespace FazendaUrbana
{
    partial class FrmProductUC
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
            groupBox3 = new GroupBox();
            productIdTxt = new TextBox();
            label2 = new Label();
            priceTxt = new TextBox();
            productBindingSource = new BindingSource(components);
            label1 = new Label();
            descriptionTxt = new TextBox();
            label9 = new Label();
            nameTxt = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            productGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            productBindingSourceGridView = new BindingSource(components);
            btnSearch = new Button();
            btnClear = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            saveBtn = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSourceGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(productIdTxt);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(priceTxt);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(descriptionTxt);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(nameTxt);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(14, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(628, 129);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Produto";
            // 
            // productIdTxt
            // 
            productIdTxt.Location = new Point(545, 22);
            productIdTxt.Name = "productIdTxt";
            productIdTxt.ReadOnly = true;
            productIdTxt.Size = new Size(49, 23);
            productIdTxt.TabIndex = 28;
            productIdTxt.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(493, 25);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 27;
            label2.Text = "Código";
            // 
            // priceTxt
            // 
            priceTxt.DataBindings.Add(new Binding("Text", productBindingSource, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            priceTxt.Location = new Point(508, 88);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(86, 23);
            priceTxt.TabIndex = 20;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(508, 70);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 19;
            label1.Text = "Preço";
            // 
            // descriptionTxt
            // 
            descriptionTxt.DataBindings.Add(new Binding("Text", productBindingSource, "Description", true, DataSourceUpdateMode.OnPropertyChanged));
            descriptionTxt.Location = new Point(226, 88);
            descriptionTxt.Name = "descriptionTxt";
            descriptionTxt.Size = new Size(249, 23);
            descriptionTxt.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(226, 70);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 17;
            label9.Text = "Descrição";
            // 
            // nameTxt
            // 
            nameTxt.DataBindings.Add(new Binding("Text", productBindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            nameTxt.Location = new Point(6, 88);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(189, 23);
            nameTxt.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 70);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 0;
            label7.Text = "Nome";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(productGridView);
            groupBox2.Location = new Point(14, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(628, 389);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produtos";
            // 
            // productGridView
            // 
            productGridView.AllowUserToAddRows = false;
            productGridView.AllowUserToDeleteRows = false;
            productGridView.AllowUserToOrderColumns = true;
            productGridView.AutoGenerateColumns = false;
            productGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, Price });
            productGridView.DataSource = productBindingSourceGridView;
            productGridView.Location = new Point(6, 22);
            productGridView.Name = "productGridView";
            productGridView.ReadOnly = true;
            productGridView.Size = new Size(616, 351);
            productGridView.TabIndex = 1;
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
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Descrição";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Preço";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // productBindingSourceGridView
            // 
            productBindingSourceGridView.DataSource = typeof(Product);
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(272, 565);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 34);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Pesquisar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(559, 565);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 35);
            btnClear.TabIndex = 15;
            btnClear.Text = "Limpar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(465, 565);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(88, 35);
            deleteBtn.TabIndex = 14;
            deleteBtn.Text = "Deletar";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(372, 565);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(87, 35);
            editBtn.TabIndex = 13;
            editBtn.Text = "Editar";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(172, 565);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 34);
            saveBtn.TabIndex = 11;
            saveBtn.Text = "Salvar";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmProductUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(saveBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "FrmProductUC";
            Size = new Size(662, 624);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSourceGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox priceTxt;
        private Label label1;
        private TextBox descriptionTxt;
        private Label label9;
        private TextBox nameTxt;
        private Label label7;
        private GroupBox groupBox2;
        private DataGridView productGridView;
        private TextBox productIdTxt;
        private Label label2;
        private Button btnSearch;
        private Button btnClear;
        private Button deleteBtn;
        private Button editBtn;
        private Button saveBtn;
        private ErrorProvider errorProvider1;
        private BindingSource productBindingSource;
        private BindingSource productBindingSourceGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Price;
    }
}
