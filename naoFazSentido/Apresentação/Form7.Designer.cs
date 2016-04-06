namespace naoFazSentido.Apresentação
{
    partial class Combústivel
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
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNsalvar = new System.Windows.Forms.Button();
            this.TXTcombustivel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTplaca = new System.Windows.Forms.TextBox();
            this.TXTdata = new System.Windows.Forms.TextBox();
            this.TXTlitros = new System.Windows.Forms.TextBox();
            this.TXTvalor = new System.Windows.Forms.TextBox();
            this.TXTkm = new System.Windows.Forms.TextBox();
            this.TXTmotorista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(373, 272);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTNCancelar.TabIndex = 0;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // BTNsalvar
            // 
            this.BTNsalvar.Location = new System.Drawing.Point(247, 272);
            this.BTNsalvar.Name = "BTNsalvar";
            this.BTNsalvar.Size = new System.Drawing.Size(75, 23);
            this.BTNsalvar.TabIndex = 1;
            this.BTNsalvar.Text = "Salvar";
            this.BTNsalvar.UseVisualStyleBackColor = true;
            this.BTNsalvar.Click += new System.EventHandler(this.BTNsalvar_Click);
            // 
            // TXTcombustivel
            // 
            this.TXTcombustivel.FormattingEnabled = true;
            this.TXTcombustivel.Items.AddRange(new object[] {
            "Disel",
            "Etanol",
            "Gasolina ",
            "Gás"});
            this.TXTcombustivel.Location = new System.Drawing.Point(12, 38);
            this.TXTcombustivel.Name = "TXTcombustivel";
            this.TXTcombustivel.Size = new System.Drawing.Size(164, 21);
            this.TXTcombustivel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Combustivel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Litros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "KM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Motorista";
            // 
            // TXTplaca
            // 
            this.TXTplaca.Location = new System.Drawing.Point(247, 46);
            this.TXTplaca.Name = "TXTplaca";
            this.TXTplaca.Size = new System.Drawing.Size(201, 20);
            this.TXTplaca.TabIndex = 10;
            // 
            // TXTdata
            // 
            this.TXTdata.Location = new System.Drawing.Point(12, 105);
            this.TXTdata.Name = "TXTdata";
            this.TXTdata.Size = new System.Drawing.Size(164, 20);
            this.TXTdata.TabIndex = 11;
            // 
            // TXTlitros
            // 
            this.TXTlitros.Location = new System.Drawing.Point(247, 105);
            this.TXTlitros.Name = "TXTlitros";
            this.TXTlitros.Size = new System.Drawing.Size(201, 20);
            this.TXTlitros.TabIndex = 12;
            // 
            // TXTvalor
            // 
            this.TXTvalor.Location = new System.Drawing.Point(12, 165);
            this.TXTvalor.Name = "TXTvalor";
            this.TXTvalor.Size = new System.Drawing.Size(164, 20);
            this.TXTvalor.TabIndex = 13;
            // 
            // TXTkm
            // 
            this.TXTkm.Location = new System.Drawing.Point(247, 165);
            this.TXTkm.Name = "TXTkm";
            this.TXTkm.Size = new System.Drawing.Size(201, 20);
            this.TXTkm.TabIndex = 14;
            // 
            // TXTmotorista
            // 
            this.TXTmotorista.Location = new System.Drawing.Point(12, 234);
            this.TXTmotorista.Name = "TXTmotorista";
            this.TXTmotorista.Size = new System.Drawing.Size(436, 20);
            this.TXTmotorista.TabIndex = 15;
            // 
            // Combústivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 309);
            this.Controls.Add(this.TXTmotorista);
            this.Controls.Add(this.TXTkm);
            this.Controls.Add(this.TXTvalor);
            this.Controls.Add(this.TXTlitros);
            this.Controls.Add(this.TXTdata);
            this.Controls.Add(this.TXTplaca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTcombustivel);
            this.Controls.Add(this.BTNsalvar);
            this.Controls.Add(this.BTNCancelar);
            this.Name = "Combústivel";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNsalvar;
        private System.Windows.Forms.ComboBox TXTcombustivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTplaca;
        private System.Windows.Forms.TextBox TXTdata;
        private System.Windows.Forms.TextBox TXTlitros;
        private System.Windows.Forms.TextBox TXTvalor;
        private System.Windows.Forms.TextBox TXTkm;
        private System.Windows.Forms.TextBox TXTmotorista;
    }
}