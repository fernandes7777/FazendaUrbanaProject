namespace FazendaUrbana
{
    partial class FrmLogin
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
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            btnLogin = new Button();
            passwordTxt = new TextBox();
            label3 = new Label();
            userTxt = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(passwordTxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(userTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(82, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 264);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(220, 172);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 45);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(51, 172);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(116, 45);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.CharacterCasing = CharacterCasing.Upper;
            passwordTxt.Location = new Point(140, 95);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(138, 23);
            passwordTxt.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 93);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 9;
            label3.Text = "Senha:";
            // 
            // userTxt
            // 
            userTxt.CharacterCasing = CharacterCasing.Upper;
            userTxt.Location = new Point(140, 49);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(138, 23);
            userTxt.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 47);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 7;
            label2.Text = "Usuário:";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 361);
            Controls.Add(groupBox1);
            Name = "FrmLogin";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCancel;
        private Button btnLogin;
        private TextBox passwordTxt;
        private Label label3;
        private TextBox userTxt;
        private Label label2;
    }
}