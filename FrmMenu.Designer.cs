namespace FazendaUrbana
{
    partial class FrmMenu
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
            menuStrip1 = new MenuStrip();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            controlesToolStripMenuItem = new ToolStripMenuItem();
            inputToolStripMenuItem = new ToolStripMenuItem();
            productionToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            saleToolStripMenuItem = new ToolStripMenuItem();
            relacionamentosToolStripMenuItem = new ToolStripMenuItem();
            productionProductRelationshipToolStripMenuItem = new ToolStripMenuItem();
            supplierInputRelationshipToolStripMenuItem = new ToolStripMenuItem();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            tabPages = new TabControl();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fornecedorToolStripMenuItem, controlesToolStripMenuItem, relacionamentosToolStripMenuItem, usuárioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(822, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { supplierToolStripMenuItem });
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(79, 20);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(198, 22);
            supplierToolStripMenuItem.Text = "Cadastro de fornecedor";
            supplierToolStripMenuItem.Click += supplierToolStripMenuItem_Click;
            // 
            // controlesToolStripMenuItem
            // 
            controlesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inputToolStripMenuItem, productionToolStripMenuItem, productToolStripMenuItem, saleToolStripMenuItem });
            controlesToolStripMenuItem.Name = "controlesToolStripMenuItem";
            controlesToolStripMenuItem.Size = new Size(70, 20);
            controlesToolStripMenuItem.Text = "Controles";
            // 
            // inputToolStripMenuItem
            // 
            inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            inputToolStripMenuItem.Size = new Size(190, 22);
            inputToolStripMenuItem.Text = "Cadastro de insumos";
            inputToolStripMenuItem.Click += inputToolStripMenuItem_Click;
            // 
            // productionToolStripMenuItem
            // 
            productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            productionToolStripMenuItem.Size = new Size(190, 22);
            productionToolStripMenuItem.Text = "Controle de produção";
            productionToolStripMenuItem.Click += productionToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(190, 22);
            productToolStripMenuItem.Text = "Cadastro de produtos";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // saleToolStripMenuItem
            // 
            saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            saleToolStripMenuItem.Size = new Size(190, 22);
            saleToolStripMenuItem.Text = "Controle de vendas";
            saleToolStripMenuItem.Click += saleToolStripMenuItem_Click;
            // 
            // relacionamentosToolStripMenuItem
            // 
            relacionamentosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productionProductRelationshipToolStripMenuItem, supplierInputRelationshipToolStripMenuItem });
            relacionamentosToolStripMenuItem.Name = "relacionamentosToolStripMenuItem";
            relacionamentosToolStripMenuItem.Size = new Size(110, 20);
            relacionamentosToolStripMenuItem.Text = "Relacionamentos";
            // 
            // productionProductRelationshipToolStripMenuItem
            // 
            productionProductRelationshipToolStripMenuItem.Name = "productionProductRelationshipToolStripMenuItem";
            productionProductRelationshipToolStripMenuItem.Size = new Size(307, 22);
            productionProductRelationshipToolStripMenuItem.Text = "Relacionamento de produção com produto";
            productionProductRelationshipToolStripMenuItem.Click += productionProductRelationshipToolStripMenuItem_Click;
            // 
            // supplierInputRelationshipToolStripMenuItem
            // 
            supplierInputRelationshipToolStripMenuItem.Name = "supplierInputRelationshipToolStripMenuItem";
            supplierInputRelationshipToolStripMenuItem.Size = new Size(307, 22);
            supplierInputRelationshipToolStripMenuItem.Text = "Relacionamento de fornecedor com insumo";
            supplierInputRelationshipToolStripMenuItem.Click += supplierInputRelationshipToolStripMenuItem_Click;
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(59, 20);
            usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // tabPages
            // 
            tabPages.Dock = DockStyle.Fill;
            tabPages.Location = new Point(0, 24);
            tabPages.Name = "tabPages";
            tabPages.SelectedIndex = 0;
            tabPages.Size = new Size(822, 974);
            tabPages.TabIndex = 1;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 998);
            Controls.Add(tabPages);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem controlesToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private TabControl tabPages;
        private ToolStripMenuItem inputToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem saleToolStripMenuItem;
        private ToolStripMenuItem relacionamentosToolStripMenuItem;
        private ToolStripMenuItem productionProductRelationshipToolStripMenuItem;
        private ToolStripMenuItem supplierInputRelationshipToolStripMenuItem;
    }
}