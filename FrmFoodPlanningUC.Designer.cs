namespace FazendaUrbana
{
    partial class FrmFoodPlanningUC
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            groupBox2 = new GroupBox();
            comboBox3 = new ComboBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(13, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(733, 527);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Planejamento de alimentos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(721, 499);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Tipo de Alimento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 23);
            comboBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(208, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 19);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 4;
            label2.Text = "Localização";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 19);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Época do Ano";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(369, 40);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(174, 23);
            comboBox2.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(13, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(733, 81);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtros";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(549, 40);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(178, 23);
            comboBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(549, 19);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "Clima";
            // 
            // FrmFoodPlanningUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmFoodPlanningUC";
            Size = new Size(756, 649);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private GroupBox groupBox2;
        private ComboBox comboBox3;
        private Label label4;
    }
}
