namespace FazendaUrbana
{
    partial class FrmInputUC
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
            inputIdTxt = new TextBox();
            label6 = new Label();
            descriptionTxt = new TextBox();
            inputBindingSource = new BindingSource(components);
            label2 = new Label();
            nameTxt = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            inputDataGridView = new DataGridView();
            inputBindingSourceGridView = new BindingSource(components);
            btnSearch = new Button();
            btnClear = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            saveBtn = new Button();
            errorProvider1 = new ErrorProvider(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputBindingSourceGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(inputIdTxt);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(descriptionTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(518, 126);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insumos";
            // 
            // inputIdTxt
            // 
            inputIdTxt.Location = new Point(449, 22);
            inputIdTxt.Name = "inputIdTxt";
            inputIdTxt.ReadOnly = true;
            inputIdTxt.Size = new Size(49, 23);
            inputIdTxt.TabIndex = 24;
            inputIdTxt.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(397, 25);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 23;
            label6.Text = "Código";
            // 
            // descriptionTxt
            // 
            descriptionTxt.DataBindings.Add(new Binding("Text", inputBindingSource, "Description", true, DataSourceUpdateMode.OnPropertyChanged));
            descriptionTxt.Location = new Point(255, 93);
            descriptionTxt.Name = "descriptionTxt";
            descriptionTxt.Size = new Size(243, 23);
            descriptionTxt.TabIndex = 1;
            // 
            // inputBindingSource
            // 
            inputBindingSource.DataSource = typeof(Forms.Model.Input);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 76);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Descrição";
            // 
            // nameTxt
            // 
            nameTxt.DataBindings.Add(new Binding("Text", inputBindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            nameTxt.Location = new Point(7, 93);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(242, 23);
            nameTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 76);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(inputDataGridView);
            groupBox2.Location = new Point(14, 154);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(518, 312);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Controle de Insumos";
            // 
            // inputDataGridView
            // 
            inputDataGridView.AllowUserToAddRows = false;
            inputDataGridView.AllowUserToDeleteRows = false;
            inputDataGridView.AllowUserToOrderColumns = true;
            inputDataGridView.AutoGenerateColumns = false;
            inputDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inputDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            inputDataGridView.DataSource = inputBindingSourceGridView;
            inputDataGridView.Location = new Point(7, 22);
            inputDataGridView.Name = "inputDataGridView";
            inputDataGridView.ReadOnly = true;
            inputDataGridView.Size = new Size(505, 273);
            inputDataGridView.TabIndex = 0;
            // 
            // inputBindingSourceGridView
            // 
            inputBindingSourceGridView.DataSource = typeof(Forms.Model.Input);
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(157, 472);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Pesquisar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(444, 472);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 35);
            btnClear.TabIndex = 5;
            btnClear.Text = "Limpar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(350, 472);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(88, 35);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Deletar";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(257, 472);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(87, 35);
            editBtn.TabIndex = 3;
            editBtn.Text = "Editar";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(57, 472);
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
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmInputUC
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
            Name = "FrmInputUC";
            Size = new Size(547, 526);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inputDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputBindingSourceGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox descriptionTxt;
        private Label label2;
        private TextBox nameTxt;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView inputDataGridView;
        private BindingSource inputBindingSourceGridView;
        private BindingSource inputBindingSource;
        private Button btnSearch;
        private Button btnClear;
        private Button deleteBtn;
        private Button editBtn;
        private Button saveBtn;
        private TextBox inputIdTxt;
        private Label label6;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}
