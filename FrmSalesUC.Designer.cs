namespace FazendaUrbana
{
    partial class FrmSalesUC
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
            groupBox1 = new GroupBox();
            saleIdTxt = new TextBox();
            label7 = new Label();
            saleDateTxt = new TextBox();
            saleBindingSource = new BindingSource(components);
            methodCbx = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            buyerTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            totalPriceTxt = new TextBox();
            label2 = new Label();
            quantityTxt = new TextBox();
            productCbx = new ComboBox();
            label1 = new Label();
            saleDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            buyerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentMethodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleBindingSourceGridView = new BindingSource(components);
            groupBox2 = new GroupBox();
            btnSearch = new Button();
            btnClear = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            saveBtn = new Button();
            errorProvider1 = new ErrorProvider(components);
            exportCsvBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSourceGridView).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(saleIdTxt);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(saleDateTxt);
            groupBox1.Controls.Add(methodCbx);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(buyerTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(totalPriceTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(quantityTxt);
            groupBox1.Controls.Add(productCbx);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 180);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vendas";
            // 
            // saleIdTxt
            // 
            saleIdTxt.Location = new Point(455, 22);
            saleIdTxt.Name = "saleIdTxt";
            saleIdTxt.ReadOnly = true;
            saleIdTxt.Size = new Size(49, 23);
            saleIdTxt.TabIndex = 28;
            saleIdTxt.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(403, 25);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 27;
            label7.Text = "Código";
            // 
            // saleDateTxt
            // 
            saleDateTxt.DataBindings.Add(new Binding("Text", saleBindingSource, "SaleDate", true, DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            saleDateTxt.Location = new Point(404, 86);
            saleDateTxt.Name = "saleDateTxt";
            saleDateTxt.Size = new Size(100, 23);
            saleDateTxt.TabIndex = 2;
            // 
            // saleBindingSource
            // 
            saleBindingSource.DataSource = typeof(Forms.Model.Sale);
            // 
            // methodCbx
            // 
            methodCbx.DataBindings.Add(new Binding("Text", saleBindingSource, "PaymentMethod", true));
            methodCbx.FormattingEnabled = true;
            methodCbx.Location = new Point(245, 143);
            methodCbx.Name = "methodCbx";
            methodCbx.Size = new Size(120, 23);
            methodCbx.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 125);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 12;
            label6.Text = "Método Pagamento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 125);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 10;
            label5.Text = "Comprador";
            // 
            // buyerTxt
            // 
            buyerTxt.DataBindings.Add(new Binding("Text", saleBindingSource, "Buyer", true, DataSourceUpdateMode.OnPropertyChanged));
            buyerTxt.Location = new Point(17, 143);
            buyerTxt.Name = "buyerTxt";
            buyerTxt.Size = new Size(193, 23);
            buyerTxt.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 68);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 7;
            label4.Text = "Data da Venda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 125);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "Total";
            // 
            // totalPriceTxt
            // 
            totalPriceTxt.DataBindings.Add(new Binding("Text", saleBindingSource, "TotalPrice", true, DataSourceUpdateMode.OnPropertyChanged));
            totalPriceTxt.Location = new Point(404, 143);
            totalPriceTxt.Name = "totalPriceTxt";
            totalPriceTxt.ReadOnly = true;
            totalPriceTxt.Size = new Size(100, 23);
            totalPriceTxt.TabIndex = 5;
            totalPriceTxt.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 68);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Quantidade";
            // 
            // quantityTxt
            // 
            quantityTxt.DataBindings.Add(new Binding("Text", saleBindingSource, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged));
            quantityTxt.Location = new Point(245, 86);
            quantityTxt.Name = "quantityTxt";
            quantityTxt.Size = new Size(120, 23);
            quantityTxt.TabIndex = 1;
            quantityTxt.Leave += quantityTxt_Leave;
            // 
            // productCbx
            // 
            productCbx.DataBindings.Add(new Binding("SelectedValue", saleBindingSource, "ProductId", true));
            productCbx.FormattingEnabled = true;
            productCbx.Location = new Point(17, 86);
            productCbx.Name = "productCbx";
            productCbx.Size = new Size(193, 23);
            productCbx.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 68);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Produto";
            // 
            // saleDataGridView
            // 
            saleDataGridView.AllowUserToAddRows = false;
            saleDataGridView.AllowUserToDeleteRows = false;
            saleDataGridView.AllowUserToOrderColumns = true;
            saleDataGridView.AutoGenerateColumns = false;
            saleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saleDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, saleDateDataGridViewTextBoxColumn, buyerDataGridViewTextBoxColumn, paymentMethodDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn, productIdDataGridViewTextBoxColumn });
            saleDataGridView.DataSource = saleBindingSourceGridView;
            saleDataGridView.Location = new Point(17, 22);
            saleDataGridView.Name = "saleDataGridView";
            saleDataGridView.ReadOnly = true;
            saleDataGridView.Size = new Size(496, 205);
            saleDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            saleDateDataGridViewTextBoxColumn.HeaderText = "Data da Venda";
            saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buyerDataGridViewTextBoxColumn
            // 
            buyerDataGridViewTextBoxColumn.DataPropertyName = "Buyer";
            buyerDataGridViewTextBoxColumn.HeaderText = "Comprador";
            buyerDataGridViewTextBoxColumn.Name = "buyerDataGridViewTextBoxColumn";
            buyerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            paymentMethodDataGridViewTextBoxColumn.HeaderText = "Pagamento";
            paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            paymentMethodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "Preço Total";
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "Identificador do produto";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleBindingSourceGridView
            // 
            saleBindingSourceGridView.DataSource = typeof(Forms.Model.Sale);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(exportCsvBtn);
            groupBox2.Controls.Add(saleDataGridView);
            groupBox2.Location = new Point(14, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(519, 279);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Controle de Vendas";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(159, 484);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Pesquisar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(446, 484);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 35);
            btnClear.TabIndex = 5;
            btnClear.Text = "Limpar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(352, 484);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(88, 35);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Deletar";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(259, 484);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(87, 35);
            editBtn.TabIndex = 3;
            editBtn.Text = "Editar";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(59, 484);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 34);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Salvar";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // exportCsvBtn
            // 
            exportCsvBtn.Location = new Point(419, 233);
            exportCsvBtn.Name = "exportCsvBtn";
            exportCsvBtn.Size = new Size(94, 34);
            exportCsvBtn.TabIndex = 6;
            exportCsvBtn.Text = "Exportar";
            exportCsvBtn.UseVisualStyleBackColor = true;
            exportCsvBtn.Click += exportCsvBtn_Click;
            // 
            // FrmSalesUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(saveBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmSalesUC";
            Size = new Size(549, 541);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSourceGridView).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox productCbx;
        private Label label3;
        private TextBox totalPriceTxt;
        private Label label4;
        private Label label5;
        private TextBox buyerTxt;
        private Label label2;
        private TextBox quantityTxt;
        private Label label6;
        private ComboBox methodCbx;
        private DataGridView saleDataGridView;
        private GroupBox groupBox2;
        private TextBox saleDateTxt;
        private TextBox saleIdTxt;
        private Label label7;
        private Button btnSearch;
        private Button btnClear;
        private Button deleteBtn;
        private Button editBtn;
        private Button saveBtn;
        private BindingSource saleBindingSource;
        private BindingSource saleBindingSourceGridView;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn buyerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private Button exportCsvBtn;
    }
}
