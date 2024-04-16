namespace JokenpoGame
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblYou = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnPaper = new System.Windows.Forms.Button();
            this.BtnTesoura = new System.Windows.Forms.Button();
            this.BtnRock = new System.Windows.Forms.Button();
            this.PicBoxResult = new System.Windows.Forms.PictureBox();
            this.PicBox2 = new System.Windows.Forms.PictureBox();
            this.Picbox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(39, 19);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(892, 118);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Escolha : Pedra, Papel ou Tesoura";
            // 
            // LblYou
            // 
            this.LblYou.AutoSize = true;
            this.LblYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYou.Location = new System.Drawing.Point(119, 112);
            this.LblYou.Name = "LblYou";
            this.LblYou.Size = new System.Drawing.Size(65, 25);
            this.LblYou.TabIndex = 4;
            this.LblYou.Text = "Você";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(476, 112);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(43, 25);
            this.Lbl1.TabIndex = 7;
            this.Lbl1.Text = "PC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(819, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "VS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            // 
            // BtnPaper
            // 
            this.BtnPaper.BackgroundImage = global::JokenpoGame.Properties.Resources.Papel;
            this.BtnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPaper.Location = new System.Drawing.Point(395, 365);
            this.BtnPaper.Name = "BtnPaper";
            this.BtnPaper.Size = new System.Drawing.Size(200, 200);
            this.BtnPaper.TabIndex = 12;
            this.BtnPaper.UseVisualStyleBackColor = true;
            this.BtnPaper.Click += new System.EventHandler(this.BtnPaper_Click);
            // 
            // BtnTesoura
            // 
            this.BtnTesoura.BackgroundImage = global::JokenpoGame.Properties.Resources.Tesoura;
            this.BtnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTesoura.Location = new System.Drawing.Point(731, 365);
            this.BtnTesoura.Name = "BtnTesoura";
            this.BtnTesoura.Size = new System.Drawing.Size(200, 200);
            this.BtnTesoura.TabIndex = 13;
            this.BtnTesoura.UseVisualStyleBackColor = true;
            this.BtnTesoura.Click += new System.EventHandler(this.BtnTesoura_Click);
            // 
            // BtnRock
            // 
            this.BtnRock.BackgroundImage = global::JokenpoGame.Properties.Resources.Pedra;
            this.BtnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRock.Location = new System.Drawing.Point(54, 365);
            this.BtnRock.Name = "BtnRock";
            this.BtnRock.Size = new System.Drawing.Size(200, 200);
            this.BtnRock.TabIndex = 11;
            this.BtnRock.UseVisualStyleBackColor = true;
            this.BtnRock.Click += new System.EventHandler(this.BtnRock_Click);
            // 
            // PicBoxResult
            // 
            this.PicBoxResult.Location = new System.Drawing.Point(731, 159);
            this.PicBoxResult.Name = "PicBoxResult";
            this.PicBoxResult.Size = new System.Drawing.Size(200, 200);
            this.PicBoxResult.TabIndex = 3;
            this.PicBoxResult.TabStop = false;
            // 
            // PicBox2
            // 
            this.PicBox2.Location = new System.Drawing.Point(395, 159);
            this.PicBox2.Name = "PicBox2";
            this.PicBox2.Size = new System.Drawing.Size(200, 200);
            this.PicBox2.TabIndex = 2;
            this.PicBox2.TabStop = false;
            // 
            // Picbox1
            // 
            this.Picbox1.Location = new System.Drawing.Point(54, 159);
            this.Picbox1.Name = "Picbox1";
            this.Picbox1.Size = new System.Drawing.Size(200, 200);
            this.Picbox1.TabIndex = 1;
            this.Picbox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 623);
            this.Controls.Add(this.BtnTesoura);
            this.Controls.Add(this.BtnPaper);
            this.Controls.Add(this.BtnRock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.LblYou);
            this.Controls.Add(this.PicBoxResult);
            this.Controls.Add(this.PicBox2);
            this.Controls.Add(this.Picbox1);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox Picbox1;
        private System.Windows.Forms.PictureBox PicBox2;
        private System.Windows.Forms.PictureBox PicBoxResult;
        private System.Windows.Forms.Label LblYou;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRock;
        private System.Windows.Forms.Button BtnPaper;
        private System.Windows.Forms.Button BtnTesoura;
    }
}

