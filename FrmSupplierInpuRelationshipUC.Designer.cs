namespace FazendaUrbana.Forms
{
    partial class FrmSupplierInpuRelationshipUC
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
            clearBtn = new Button();
            deleteRelationshipBtn = new Button();
            relationshipBtn = new Button();
            groupBox2 = new GroupBox();
            supplierInputDataGridView = new DataGridView();
            supplierIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inputIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            purchasePriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentTermsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierInputBindingSourceGridView = new BindingSource(components);
            groupBox1 = new GroupBox();
            purchasePriceTxt = new TextBox();
            supplierInputBindingSource = new BindingSource(components);
            label4 = new Label();
            paymentTermsTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            inputCbx = new ComboBox();
            label1 = new Label();
            supplierCbx = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)supplierInputDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierInputBindingSourceGridView).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)supplierInputBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(518, 462);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(98, 40);
            clearBtn.TabIndex = 10;
            clearBtn.Text = "Limpar";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // deleteRelationshipBtn
            // 
            deleteRelationshipBtn.Location = new Point(414, 462);
            deleteRelationshipBtn.Name = "deleteRelationshipBtn";
            deleteRelationshipBtn.Size = new Size(98, 40);
            deleteRelationshipBtn.TabIndex = 9;
            deleteRelationshipBtn.Text = "Excluir";
            deleteRelationshipBtn.UseVisualStyleBackColor = true;
            deleteRelationshipBtn.Click += deleteRelationshipBtn_Click;
            // 
            // relationshipBtn
            // 
            relationshipBtn.Location = new Point(310, 462);
            relationshipBtn.Name = "relationshipBtn";
            relationshipBtn.Size = new Size(98, 40);
            relationshipBtn.TabIndex = 8;
            relationshipBtn.Text = "Relacionar";
            relationshipBtn.UseVisualStyleBackColor = true;
            relationshipBtn.Click += relationshipBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(supplierInputDataGridView);
            groupBox2.Location = new Point(3, 112);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(613, 328);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fornecedor e Insumo";
            // 
            // supplierInputDataGridView
            // 
            supplierInputDataGridView.AllowUserToAddRows = false;
            supplierInputDataGridView.AllowUserToDeleteRows = false;
            supplierInputDataGridView.AllowUserToOrderColumns = true;
            supplierInputDataGridView.AutoGenerateColumns = false;
            supplierInputDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            supplierInputDataGridView.Columns.AddRange(new DataGridViewColumn[] { supplierIdDataGridViewTextBoxColumn, inputIdDataGridViewTextBoxColumn, purchasePriceDataGridViewTextBoxColumn, paymentTermsDataGridViewTextBoxColumn });
            supplierInputDataGridView.DataSource = supplierInputBindingSourceGridView;
            supplierInputDataGridView.Location = new Point(6, 22);
            supplierInputDataGridView.Name = "supplierInputDataGridView";
            supplierInputDataGridView.ReadOnly = true;
            supplierInputDataGridView.Size = new Size(601, 288);
            supplierInputDataGridView.TabIndex = 0;
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            supplierIdDataGridViewTextBoxColumn.HeaderText = "Identificador Fornecedor";
            supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            supplierIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inputIdDataGridViewTextBoxColumn
            // 
            inputIdDataGridViewTextBoxColumn.DataPropertyName = "InputId";
            inputIdDataGridViewTextBoxColumn.HeaderText = "Identificador Insumo";
            inputIdDataGridViewTextBoxColumn.Name = "inputIdDataGridViewTextBoxColumn";
            inputIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            purchasePriceDataGridViewTextBoxColumn.HeaderText = "Preço da Compra";
            purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            purchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentTermsDataGridViewTextBoxColumn
            // 
            paymentTermsDataGridViewTextBoxColumn.DataPropertyName = "PaymentTerms";
            paymentTermsDataGridViewTextBoxColumn.HeaderText = "Termos do pagamento";
            paymentTermsDataGridViewTextBoxColumn.Name = "paymentTermsDataGridViewTextBoxColumn";
            paymentTermsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierInputBindingSourceGridView
            // 
            supplierInputBindingSourceGridView.DataSource = typeof(Model.SupplierInput);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(purchasePriceTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(paymentTermsTxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(inputCbx);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(supplierCbx);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(613, 103);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Relacionamento entre Fornecedor e Insumo";
            // 
            // purchasePriceTxt
            // 
            purchasePriceTxt.DataBindings.Add(new Binding("Text", supplierInputBindingSource, "PaymentTerms", true, DataSourceUpdateMode.OnPropertyChanged));
            purchasePriceTxt.Location = new Point(436, 51);
            purchasePriceTxt.Name = "purchasePriceTxt";
            purchasePriceTxt.Size = new Size(154, 23);
            purchasePriceTxt.TabIndex = 7;
            // 
            // supplierInputBindingSource
            // 
            supplierInputBindingSource.DataSource = typeof(Model.SupplierInput);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 33);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 6;
            label4.Text = "Termos do pagamento";
            // 
            // paymentTermsTxt
            // 
            paymentTermsTxt.DataBindings.Add(new Binding("Text", supplierInputBindingSource, "PurchasePrice", true, DataSourceUpdateMode.OnPropertyChanged));
            paymentTermsTxt.Location = new Point(306, 51);
            paymentTermsTxt.Name = "paymentTermsTxt";
            paymentTermsTxt.Size = new Size(100, 23);
            paymentTermsTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 33);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 4;
            label3.Text = "Preço da compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 33);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Insumo";
            // 
            // inputCbx
            // 
            inputCbx.DataBindings.Add(new Binding("SelectedValue", supplierInputBindingSource, "InputId", true, DataSourceUpdateMode.OnPropertyChanged));
            inputCbx.FormattingEnabled = true;
            inputCbx.Location = new Point(166, 51);
            inputCbx.Name = "inputCbx";
            inputCbx.Size = new Size(109, 23);
            inputCbx.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 33);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Fornecedor";
            // 
            // supplierCbx
            // 
            supplierCbx.DataBindings.Add(new Binding("SelectedValue", supplierInputBindingSource, "SupplierId", true, DataSourceUpdateMode.OnPropertyChanged));
            supplierCbx.FormattingEnabled = true;
            supplierCbx.Location = new Point(25, 51);
            supplierCbx.Name = "supplierCbx";
            supplierCbx.Size = new Size(112, 23);
            supplierCbx.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmSupplierInpuRelationshipUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(clearBtn);
            Controls.Add(deleteRelationshipBtn);
            Controls.Add(relationshipBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmSupplierInpuRelationshipUC";
            Size = new Size(627, 509);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)supplierInputDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierInputBindingSourceGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)supplierInputBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button clearBtn;
        private Button deleteRelationshipBtn;
        private Button relationshipBtn;
        private GroupBox groupBox2;
        private DataGridView supplierInputDataGridView;
        private GroupBox groupBox1;
        private TextBox purchasePriceTxt;
        private Label label4;
        private TextBox paymentTermsTxt;
        private Label label3;
        private Label label2;
        private ComboBox inputCbx;
        private Label label1;
        private ComboBox supplierCbx;
        private ErrorProvider errorProvider1;
        private BindingSource supplierInputBindingSource;
        private BindingSource supplierInputBindingSourceGridView;
        private DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inputIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentTermsDataGridViewTextBoxColumn;
    }
}
