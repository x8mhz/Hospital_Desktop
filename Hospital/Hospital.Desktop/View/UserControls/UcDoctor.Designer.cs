namespace Hospital.Desktop.View.UserControls
{
    partial class UcDoctor
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridDoctor = new System.Windows.Forms.DataGridView();
            this.tabDoctor = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctor)).BeginInit();
            this.tabDoctor.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDoctor
            // 
            this.gridDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDoctor.Location = new System.Drawing.Point(0, 0);
            this.gridDoctor.Name = "gridDoctor";
            this.gridDoctor.Size = new System.Drawing.Size(934, 572);
            this.gridDoctor.TabIndex = 2;
            // 
            // tabDoctor
            // 
            this.tabDoctor.Controls.Add(this.gridDoctor);
            this.tabDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDoctor.HorizontalScrollbarBarColor = true;
            this.tabDoctor.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDoctor.HorizontalScrollbarSize = 10;
            this.tabDoctor.Location = new System.Drawing.Point(4, 38);
            this.tabDoctor.Name = "tabDoctor";
            this.tabDoctor.Size = new System.Drawing.Size(934, 572);
            this.tabDoctor.TabIndex = 0;
            this.tabDoctor.Text = "   Lista de Médicos   ";
            this.tabDoctor.VerticalScrollbarBarColor = true;
            this.tabDoctor.VerticalScrollbarHighlightOnWheel = false;
            this.tabDoctor.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabDoctor);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(942, 614);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // UcDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "UcDoctor";
            this.Size = new System.Drawing.Size(942, 613);
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctor)).EndInit();
            this.tabDoctor.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridDoctor;
        private MetroFramework.Controls.MetroTabPage tabDoctor;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
    }
}
