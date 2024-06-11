namespace FazendaUrbana.Forms
{
    partial class FrmProductionProductRelationship
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
            productionCbx = new ComboBox();
            productionProductBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            totalPriceTxt = new TextBox();
            label4 = new Label();
            quantityTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            productCbx = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            productionProductDataGridView = new DataGridView();
            productionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityProducedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productionProductBindingSourceGridView = new BindingSource(components);
            relationshipBtn = new Button();
            deleteRelationshipBtn = new Button();
            errorProvider1 = new ErrorProvider(components);
            clearBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)productionProductBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productionProductDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productionProductBindingSourceGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // productionCbx
            // 
            productionCbx.DataBindings.Add(new Binding("SelectedValue", productionProductBindingSource, "ProductionId", true, DataSourceUpdateMode.OnPropertyChanged));
            productionCbx.FormattingEnabled = true;
            productionCbx.Location = new Point(25, 51);
            productionCbx.Name = "productionCbx";
            productionCbx.Size = new Size(112, 23);
            productionCbx.TabIndex = 0;
            // 
            // productionProductBindingSource
            // 
            productionProductBindingSource.DataSource = typeof(Model.ProductionProduct);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(totalPriceTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(quantityTxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(productCbx);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(productionCbx);
            groupBox1.Location = new Point(21, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(613, 103);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Relacionamento entre Produção e Produto";
            // 
            // totalPriceTxt
            // 
            totalPriceTxt.DataBindings.Add(new Binding("Text", productionProductBindingSource, "TotalPrice", true, DataSourceUpdateMode.OnPropertyChanged));
            totalPriceTxt.Location = new Point(436, 51);
            totalPriceTxt.Name = "totalPriceTxt";
            totalPriceTxt.Size = new Size(154, 23);
            totalPriceTxt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 33);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Preço Total";
            // 
            // quantityTxt
            // 
            quantityTxt.DataBindings.Add(new Binding("Text", productionProductBindingSource, "QuantityProduced", true, DataSourceUpdateMode.OnPropertyChanged));
            quantityTxt.Location = new Point(306, 51);
            quantityTxt.Name = "quantityTxt";
            quantityTxt.Size = new Size(100, 23);
            quantityTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 33);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 33);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "Produto";
            // 
            // productCbx
            // 
            productCbx.DataBindings.Add(new Binding("SelectedValue", productionProductBindingSource, "ProductId", true, DataSourceUpdateMode.OnPropertyChanged));
            productCbx.FormattingEnabled = true;
            productCbx.Location = new Point(166, 51);
            productCbx.Name = "productCbx";
            productCbx.Size = new Size(109, 23);
            productCbx.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 33);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Produção";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(productionProductDataGridView);
            groupBox2.Location = new Point(21, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(613, 328);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produção e Produto";
            // 
            // productionProductDataGridView
            // 
            productionProductDataGridView.AllowUserToAddRows = false;
            productionProductDataGridView.AllowUserToDeleteRows = false;
            productionProductDataGridView.AllowUserToOrderColumns = true;
            productionProductDataGridView.AutoGenerateColumns = false;
            productionProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productionProductDataGridView.Columns.AddRange(new DataGridViewColumn[] { productionIdDataGridViewTextBoxColumn, productIdDataGridViewTextBoxColumn, quantityProducedDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn });
            productionProductDataGridView.DataSource = productionProductBindingSourceGridView;
            productionProductDataGridView.Location = new Point(6, 22);
            productionProductDataGridView.Name = "productionProductDataGridView";
            productionProductDataGridView.ReadOnly = true;
            productionProductDataGridView.Size = new Size(601, 288);
            productionProductDataGridView.TabIndex = 0;
            // 
            // productionIdDataGridViewTextBoxColumn
            // 
            productionIdDataGridViewTextBoxColumn.DataPropertyName = "ProductionId";
            productionIdDataGridViewTextBoxColumn.HeaderText = "Identificador da Produção";
            productionIdDataGridViewTextBoxColumn.Name = "productionIdDataGridViewTextBoxColumn";
            productionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "Identificador do Produto";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityProducedDataGridViewTextBoxColumn
            // 
            quantityProducedDataGridViewTextBoxColumn.DataPropertyName = "QuantityProduced";
            quantityProducedDataGridViewTextBoxColumn.HeaderText = "Quantidade Produzida";
            quantityProducedDataGridViewTextBoxColumn.Name = "quantityProducedDataGridViewTextBoxColumn";
            quantityProducedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "Valor Gerado";
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionProductBindingSourceGridView
            // 
            productionProductBindingSourceGridView.DataSource = typeof(Model.ProductionProduct);
            // 
            // relationshipBtn
            // 
            relationshipBtn.Location = new Point(328, 475);
            relationshipBtn.Name = "relationshipBtn";
            relationshipBtn.Size = new Size(98, 40);
            relationshipBtn.TabIndex = 3;
            relationshipBtn.Text = "Relacionar";
            relationshipBtn.UseVisualStyleBackColor = true;
            relationshipBtn.Click += relationshipBtn_Click;
            // 
            // deleteRelationshipBtn
            // 
            deleteRelationshipBtn.Location = new Point(432, 475);
            deleteRelationshipBtn.Name = "deleteRelationshipBtn";
            deleteRelationshipBtn.Size = new Size(98, 40);
            deleteRelationshipBtn.TabIndex = 4;
            deleteRelationshipBtn.Text = "Excluir";
            deleteRelationshipBtn.UseVisualStyleBackColor = true;
            deleteRelationshipBtn.Click += deleteRelationshipBtn_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(536, 475);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(98, 40);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "Limpar";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // FrmProductionProductRelationship
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(clearBtn);
            Controls.Add(deleteRelationshipBtn);
            Controls.Add(relationshipBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmProductionProductRelationship";
            Size = new Size(651, 537);
            ((System.ComponentModel.ISupportInitialize)productionProductBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productionProductDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productionProductBindingSourceGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox productionCbx;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private ComboBox productCbx;
        private GroupBox groupBox2;
        private DataGridView productionProductDataGridView;
        private Button relationshipBtn;
        private Button deleteRelationshipBtn;
        private BindingSource productionProductBindingSource;
        private BindingSource productionProductBindingSourceGridView;
        private ErrorProvider errorProvider1;
        private TextBox quantityTxt;
        private Label label3;
        private TextBox totalPriceTxt;
        private Label label4;
        private Button clearBtn;
        private DataGridViewTextBoxColumn productionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityProducedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}
