namespace Thread_Form
{
    partial class Form1
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
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnPrincipal = new System.Windows.Forms.Button();
            this.BtnContador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblResultado
            // 
            this.LblResultado.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(12, 9);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(776, 142);
            this.LblResultado.TabIndex = 0;
            // 
            // BtnPrincipal
            // 
            this.BtnPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrincipal.Location = new System.Drawing.Point(100, 293);
            this.BtnPrincipal.Name = "BtnPrincipal";
            this.BtnPrincipal.Size = new System.Drawing.Size(206, 70);
            this.BtnPrincipal.TabIndex = 1;
            this.BtnPrincipal.Text = "Principal";
            this.BtnPrincipal.UseVisualStyleBackColor = true;
            this.BtnPrincipal.Click += new System.EventHandler(this.BtnPrincipal_Click);
            // 
            // BtnContador
            // 
            this.BtnContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContador.Location = new System.Drawing.Point(487, 293);
            this.BtnContador.Name = "BtnContador";
            this.BtnContador.Size = new System.Drawing.Size(206, 70);
            this.BtnContador.TabIndex = 2;
            this.BtnContador.Text = "Contador";
            this.BtnContador.UseVisualStyleBackColor = true;
            this.BtnContador.Click += new System.EventHandler(this.BtnContador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnContador);
            this.Controls.Add(this.BtnPrincipal);
            this.Controls.Add(this.LblResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnPrincipal;
        private System.Windows.Forms.Button BtnContador;
    }
}

