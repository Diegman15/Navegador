namespace navegador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BtFavorite = new System.Windows.Forms.Button();
            this.BtBack = new System.Windows.Forms.Button();
            this.BtSearch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.BtSearch);
            this.panel1.Controls.Add(this.BtBack);
            this.panel1.Controls.Add(this.BtFavorite);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 55);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 395);
            this.webBrowser1.TabIndex = 1;
            // 
            // BtFavorite
            // 
            this.BtFavorite.Location = new System.Drawing.Point(697, 6);
            this.BtFavorite.Name = "BtFavorite";
            this.BtFavorite.Size = new System.Drawing.Size(72, 37);
            this.BtFavorite.TabIndex = 2;
            this.BtFavorite.Text = "Agregar a &Favoritos";
            this.BtFavorite.UseVisualStyleBackColor = true;
            this.BtFavorite.Click += new System.EventHandler(this.BtFavorite_Click);
            // 
            // BtBack
            // 
            this.BtBack.Location = new System.Drawing.Point(12, 14);
            this.BtBack.Name = "BtBack";
            this.BtBack.Size = new System.Drawing.Size(84, 27);
            this.BtBack.TabIndex = 3;
            this.BtBack.Text = "&Atras";
            this.BtBack.UseVisualStyleBackColor = true;
            this.BtBack.Click += new System.EventHandler(this.BtBack_Click);
            // 
            // BtSearch
            // 
            this.BtSearch.Location = new System.Drawing.Point(442, 12);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(67, 27);
            this.BtSearch.TabIndex = 4;
            this.BtSearch.Text = "&Ir";
            this.BtSearch.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(532, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Fairfocs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtSearch;
        private System.Windows.Forms.Button BtBack;
        private System.Windows.Forms.Button BtFavorite;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

