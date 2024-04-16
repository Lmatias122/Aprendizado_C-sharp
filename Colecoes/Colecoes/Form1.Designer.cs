namespace Colecoes
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
            this.Lista = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.BtnSortedList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 25;
            this.Lista.Location = new System.Drawing.Point(18, 17);
            this.Lista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(923, 654);
            this.Lista.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(949, 18);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(273, 86);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // BtnSortedList
            // 
            this.BtnSortedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSortedList.Location = new System.Drawing.Point(949, 114);
            this.BtnSortedList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSortedList.Name = "BtnSortedList";
            this.BtnSortedList.Size = new System.Drawing.Size(273, 86);
            this.BtnSortedList.TabIndex = 2;
            this.BtnSortedList.Text = "SortedList";
            this.BtnSortedList.UseVisualStyleBackColor = true;
            this.BtnSortedList.Click += new System.EventHandler(this.BtnSortedList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 688);
            this.Controls.Add(this.BtnSortedList);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.Lista);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListasGenericas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button BtnSortedList;
    }
}

