using FazendaUrbana.Forms.Model;

namespace FazendaUrbana
{
    partial class FrmProductionUC
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
            descriptionTxt = new TextBox();
            productionBindingSource = new BindingSource(components);
            label9 = new Label();
            nameTxt = new TextBox();
            label8 = new Label();
            productionIdTxt = new TextBox();
            label7 = new Label();
            resourcesTxt = new TextBox();
            label6 = new Label();
            currentSateCbx = new ComboBox();
            label5 = new Label();
            methodTxt = new TextBox();
            label4 = new Label();
            locationTxt = new TextBox();
            label3 = new Label();
            finalDateTxt = new TextBox();
            label2 = new Label();
            initialDateTxt = new TextBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            productionDataGridView = new DataGridView();
            productionBindingSourceGridView = new BindingSource(components);
            errorProvider1 = new ErrorProvider(components);
            btnSearch = new Button();
            btnClear = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            saveBtn = new Button();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            locationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productionMethodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            currentStateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resourcesUsedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productionBindingSource).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productionDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productionBindingSourceGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(descriptionTxt);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(nameTxt);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(productionIdTxt);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(resourcesTxt);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(currentSateCbx);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(methodTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(locationTxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(finalDateTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(initialDateTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(19, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(628, 221);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produção";
            // 
            // descriptionTxt
            // 
            descriptionTxt.DataBindings.Add(new Binding("Text", productionBindingSource, "Description", true, DataSourceUpdateMode.OnPropertyChanged));
            descriptionTxt.Location = new Point(387, 72);
            descriptionTxt.Name = "descriptionTxt";
            descriptionTxt.Size = new Size(226, 23);
            descriptionTxt.TabIndex = 30;
            // 
            // productionBindingSource
            // 
            productionBindingSource.DataSource = typeof(Production);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(387, 54);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 29;
            label9.Text = "Descrição";
            // 
            // nameTxt
            // 
            nameTxt.DataBindings.Add(new Binding("Text", productionBindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            nameTxt.Location = new Point(253, 72);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(110, 23);
            nameTxt.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(253, 54);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 27;
            label8.Text = "Nome";
            // 
            // productionIdTxt
            // 
            productionIdTxt.Location = new Point(564, 22);
            productionIdTxt.Name = "productionIdTxt";
            productionIdTxt.ReadOnly = true;
            productionIdTxt.Size = new Size(49, 23);
            productionIdTxt.TabIndex = 26;
            productionIdTxt.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(512, 25);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 25;
            label7.Text = "Código";
            // 
            // resourcesTxt
            // 
            resourcesTxt.DataBindings.Add(new Binding("Text", productionBindingSource, "ResourcesUsed", true, DataSourceUpdateMode.OnPropertyChanged));
            resourcesTxt.Location = new Point(6, 184);
            resourcesTxt.Name = "resourcesTxt";
            resourcesTxt.Size = new Size(211, 23);
            resourcesTxt.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 166);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 10;
            label6.Text = "Recursos";
            // 
            // currentSateCbx
            // 
            currentSateCbx.DataBindings.Add(new Binding("SelectedValue", productionBindingSource, "CurrentState", true, DataSourceUpdateMode.OnPropertyChanged));
            currentSateCbx.FormattingEnabled = true;
            currentSateCbx.Location = new Point(503, 127);
            currentSateCbx.Name = "currentSateCbx";
            currentSateCbx.Size = new Size(110, 23);
            currentSateCbx.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(503, 109);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 8;
            label5.Text = "Estado atual";
            // 
            // methodTxt
            // 
            methodTxt.DataBindings.Add(new Binding("Text", productionBindingSource, "ProductionMethod", true, DataSourceUpdateMode.OnPropertyChanged));
            methodTxt.Location = new Point(6, 127);
            methodTxt.Name = "methodTxt";
            methodTxt.Size = new Size(458, 23);
            methodTxt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 109);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Método";
            // 
            // locationTxt
            // 
            locationTxt.DataBindings.Add(new Binding("Text", productionBindingSource, "Location", true, DataSourceUpdateMode.OnPropertyChanged));
            locationTxt.Location = new Point(254, 184);
            locationTxt.Name = "locationTxt";
            locationTxt.Size = new Size(359, 23);
            locationTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 166);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 4;
            label3.Text = "Localização";
            // 
            // finalDateTxt
            // 
            finalDateTxt.DataBindings.Add(new Binding("Text", productionBindingSource, "EndDate", true, DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            finalDateTxt.Location = new Point(130, 72);
            finalDateTxt.Name = "finalDateTxt";
            finalDateTxt.Size = new Size(100, 23);
            finalDateTxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 54);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Data Final";
            // 
            // initialDateTxt
            // 
            initialDateTxt.DataBindings.Add(new Binding("Text", productionBindingSource, "StartDate", true, DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            initialDateTxt.Location = new Point(6, 72);
            initialDateTxt.Name = "initialDateTxt";
            initialDateTxt.Size = new Size(100, 23);
            initialDateTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 54);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Data Inicio";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(productionDataGridView);
            groupBox4.Location = new Point(19, 242);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(628, 316);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Produtos e Produção";
            // 
            // productionDataGridView
            // 
            productionDataGridView.AllowUserToAddRows = false;
            productionDataGridView.AllowUserToDeleteRows = false;
            productionDataGridView.AllowUserToOrderColumns = true;
            productionDataGridView.AutoGenerateColumns = false;
            productionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productionDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, locationDataGridViewTextBoxColumn, productionMethodDataGridViewTextBoxColumn, currentStateDataGridViewTextBoxColumn, resourcesUsedDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, Description });
            productionDataGridView.DataSource = productionBindingSourceGridView;
            productionDataGridView.Location = new Point(6, 25);
            productionDataGridView.Name = "productionDataGridView";
            productionDataGridView.ReadOnly = true;
            productionDataGridView.Size = new Size(616, 285);
            productionDataGridView.TabIndex = 0;
            // 
            // productionBindingSourceGridView
            // 
            productionBindingSourceGridView.DataSource = typeof(Production);
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(272, 590);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 34);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Pesquisar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(559, 590);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 35);
            btnClear.TabIndex = 10;
            btnClear.Text = "Limpar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(465, 590);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(88, 35);
            deleteBtn.TabIndex = 9;
            deleteBtn.Text = "Deletar";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(372, 590);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(87, 35);
            editBtn.TabIndex = 8;
            editBtn.Text = "Editar";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(172, 590);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 34);
            saveBtn.TabIndex = 6;
            saveBtn.Text = "Salvar";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "Data Inicio";
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "Data Final";
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            locationDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            locationDataGridViewTextBoxColumn.HeaderText = "Localização";
            locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionMethodDataGridViewTextBoxColumn
            // 
            productionMethodDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productionMethodDataGridViewTextBoxColumn.DataPropertyName = "ProductionMethod";
            productionMethodDataGridViewTextBoxColumn.HeaderText = "Método de produção";
            productionMethodDataGridViewTextBoxColumn.Name = "productionMethodDataGridViewTextBoxColumn";
            productionMethodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentStateDataGridViewTextBoxColumn
            // 
            currentStateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            currentStateDataGridViewTextBoxColumn.DataPropertyName = "CurrentStateView";
            currentStateDataGridViewTextBoxColumn.HeaderText = "Estado Atual";
            currentStateDataGridViewTextBoxColumn.Name = "currentStateDataGridViewTextBoxColumn";
            currentStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resourcesUsedDataGridViewTextBoxColumn
            // 
            resourcesUsedDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resourcesUsedDataGridViewTextBoxColumn.DataPropertyName = "ResourcesUsed";
            resourcesUsedDataGridViewTextBoxColumn.HeaderText = "Recursos utilizados";
            resourcesUsedDataGridViewTextBoxColumn.Name = "resourcesUsedDataGridViewTextBoxColumn";
            resourcesUsedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Descrição";
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // FrmProductionUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(saveBtn);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Name = "FrmProductionUC";
            Size = new Size(662, 642);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productionBindingSource).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productionDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productionBindingSourceGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox finalDateTxt;
        private Label label2;
        private TextBox initialDateTxt;
        private Label label1;
        private TextBox methodTxt;
        private Label label4;
        private TextBox locationTxt;
        private Label label3;
        private Label label5;
        private ComboBox currentSateCbx;
        private TextBox resourcesTxt;
        private Label label6;
        private GroupBox groupBox4;
        private DataGridView productionDataGridView;
        private TextBox productionIdTxt;
        private Label label7;
        private ErrorProvider errorProvider1;
        private BindingSource productionBindingSource;
        private BindingSource productionBindingSourceGridView;
        private Button btnSearch;
        private Button btnClear;
        private Button deleteBtn;
        private Button editBtn;
        private Button saveBtn;
        private TextBox descriptionTxt;
        private Label label9;
        private TextBox nameTxt;
        private Label label8;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productionMethodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentStateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resourcesUsedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Description;
    }
}
