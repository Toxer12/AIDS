namespace Md_Graf
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Guzior = new System.Windows.Forms.Button();
            this.Guzior2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Guzior
            // 
            this.Guzior.Location = new System.Drawing.Point(207, 335);
            this.Guzior.Name = "Guzior";
            this.Guzior.Size = new System.Drawing.Size(75, 23);
            this.Guzior.TabIndex = 0;
            this.Guzior.Text = "Dziecko";
            this.Guzior.UseVisualStyleBackColor = true;
            this.Guzior.Click += new System.EventHandler(this.Guzior_Click);
            // 
            // Guzior2
            // 
            this.Guzior2.Location = new System.Drawing.Point(537, 335);
            this.Guzior2.Name = "Guzior2";
            this.Guzior2.Size = new System.Drawing.Size(75, 23);
            this.Guzior2.TabIndex = 1;
            this.Guzior2.Text = "Somsiad";
            this.Guzior2.UseVisualStyleBackColor = true;
            this.Guzior2.Click += new System.EventHandler(this.Guzior2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Guzior2);
            this.Controls.Add(this.Guzior);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Guzior;
        private System.Windows.Forms.Button Guzior2;
    }
}

