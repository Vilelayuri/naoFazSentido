namespace naoFazSentido.Apresentação
{
    partial class provisoria
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeMotoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarMotoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.testeToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeMotoristaToolStripMenuItem,
            this.cadastroDeVeiculoToolStripMenuItem,
            this.visualizarMotoristaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cadastroDeMotoristaToolStripMenuItem
            // 
            this.cadastroDeMotoristaToolStripMenuItem.Name = "cadastroDeMotoristaToolStripMenuItem";
            this.cadastroDeMotoristaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cadastroDeMotoristaToolStripMenuItem.Text = "Cadastro de Motorista";
            this.cadastroDeMotoristaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeMotoristaToolStripMenuItem_Click);
            // 
            // cadastroDeVeiculoToolStripMenuItem
            // 
            this.cadastroDeVeiculoToolStripMenuItem.Name = "cadastroDeVeiculoToolStripMenuItem";
            this.cadastroDeVeiculoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cadastroDeVeiculoToolStripMenuItem.Text = "Cadastro de Veiculo";
            // 
            // visualizarMotoristaToolStripMenuItem
            // 
            this.visualizarMotoristaToolStripMenuItem.Name = "visualizarMotoristaToolStripMenuItem";
            this.visualizarMotoristaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.visualizarMotoristaToolStripMenuItem.Text = "visualizar Motorista ";
            // 
            // provisoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 521);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "provisoria";
            this.Text = "Form6";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeMotoristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarMotoristaToolStripMenuItem;

    }
}