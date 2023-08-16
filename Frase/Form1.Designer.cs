namespace Frase
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
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btLong = new System.Windows.Forms.Button();
            this.btMayuscula = new System.Windows.Forms.Button();
            this.btExtraer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(13, 13);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(431, 20);
            this.txtFrase.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(13, 99);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 2;
            // 
            // btLong
            // 
            this.btLong.Location = new System.Drawing.Point(13, 52);
            this.btLong.Name = "btLong";
            this.btLong.Size = new System.Drawing.Size(75, 23);
            this.btLong.TabIndex = 0;
            this.btLong.Text = "Longitud";
            this.btLong.UseVisualStyleBackColor = true;
            this.btLong.Click += new System.EventHandler(this.btLong_Click);
            // 
            // btMayuscula
            // 
            this.btMayuscula.Location = new System.Drawing.Point(95, 51);
            this.btMayuscula.Name = "btMayuscula";
            this.btMayuscula.Size = new System.Drawing.Size(75, 23);
            this.btMayuscula.TabIndex = 3;
            this.btMayuscula.Text = "Mayuscula";
            this.btMayuscula.UseVisualStyleBackColor = true;
            this.btMayuscula.Click += new System.EventHandler(this.btMayuscula_Click);
            // 
            // btExtraer
            // 
            this.btExtraer.Location = new System.Drawing.Point(177, 51);
            this.btExtraer.Name = "btExtraer";
            this.btExtraer.Size = new System.Drawing.Size(75, 23);
            this.btExtraer.TabIndex = 4;
            this.btExtraer.Text = "Extraer";
            this.btExtraer.UseVisualStyleBackColor = true;
            this.btExtraer.Click += new System.EventHandler(this.btExtraer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 133);
            this.Controls.Add(this.btExtraer);
            this.Controls.Add(this.btMayuscula);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.btLong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btLong;
        private System.Windows.Forms.Button btMayuscula;
        private System.Windows.Forms.Button btExtraer;
    }
}

