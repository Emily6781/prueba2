namespace prueba2
{
    partial class DlgPractica1
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
            this.LblColumnas = new System.Windows.Forms.Label();
            this.LblRenglones = new System.Windows.Forms.Label();
            this.TbxNumRenglones = new System.Windows.Forms.TextBox();
            this.TbxNumColumnas = new System.Windows.Forms.TextBox();
            this.RtbMatriz = new System.Windows.Forms.RichTextBox();
            this.LblMatriz = new System.Windows.Forms.Label();
            this.BtnLlenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblColumnas
            // 
            this.LblColumnas.AutoSize = true;
            this.LblColumnas.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColumnas.Location = new System.Drawing.Point(176, 41);
            this.LblColumnas.Name = "LblColumnas";
            this.LblColumnas.Size = new System.Drawing.Size(88, 25);
            this.LblColumnas.TabIndex = 0;
            this.LblColumnas.Text = "Columnas";
            // 
            // LblRenglones
            // 
            this.LblRenglones.AutoSize = true;
            this.LblRenglones.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRenglones.Location = new System.Drawing.Point(31, 41);
            this.LblRenglones.Name = "LblRenglones";
            this.LblRenglones.Size = new System.Drawing.Size(95, 25);
            this.LblRenglones.TabIndex = 1;
            this.LblRenglones.Text = "Renglones";
            // 
            // TbxNumRenglones
            // 
            this.TbxNumRenglones.Location = new System.Drawing.Point(32, 67);
            this.TbxNumRenglones.Name = "TbxNumRenglones";
            this.TbxNumRenglones.Size = new System.Drawing.Size(115, 22);
            this.TbxNumRenglones.TabIndex = 2;
            // 
            // TbxNumColumnas
            // 
            this.TbxNumColumnas.Location = new System.Drawing.Point(179, 67);
            this.TbxNumColumnas.Name = "TbxNumColumnas";
            this.TbxNumColumnas.Size = new System.Drawing.Size(115, 22);
            this.TbxNumColumnas.TabIndex = 3;
            // 
            // RtbMatriz
            // 
            this.RtbMatriz.Location = new System.Drawing.Point(34, 169);
            this.RtbMatriz.Name = "RtbMatriz";
            this.RtbMatriz.Size = new System.Drawing.Size(633, 201);
            this.RtbMatriz.TabIndex = 4;
            this.RtbMatriz.Text = "";
            // 
            // LblMatriz
            // 
            this.LblMatriz.AutoSize = true;
            this.LblMatriz.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMatriz.Location = new System.Drawing.Point(31, 138);
            this.LblMatriz.Name = "LblMatriz";
            this.LblMatriz.Size = new System.Drawing.Size(69, 25);
            this.LblMatriz.TabIndex = 5;
            this.LblMatriz.Text = "Matriz";
            // 
            // BtnLlenar
            // 
            this.BtnLlenar.Location = new System.Drawing.Point(523, 58);
            this.BtnLlenar.Name = "BtnLlenar";
            this.BtnLlenar.Size = new System.Drawing.Size(188, 51);
            this.BtnLlenar.TabIndex = 6;
            this.BtnLlenar.Text = "Llenar";
            this.BtnLlenar.UseVisualStyleBackColor = true;
            this.BtnLlenar.Click += new System.EventHandler(this.BtnLlenar_Click);
            // 
            // DlgPractica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLlenar);
            this.Controls.Add(this.LblMatriz);
            this.Controls.Add(this.RtbMatriz);
            this.Controls.Add(this.TbxNumColumnas);
            this.Controls.Add(this.TbxNumRenglones);
            this.Controls.Add(this.LblRenglones);
            this.Controls.Add(this.LblColumnas);
            this.Name = "DlgPractica1";
            this.Text = "DlgPractica1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblColumnas;
        private System.Windows.Forms.Label LblRenglones;
        private System.Windows.Forms.TextBox TbxNumRenglones;
        private System.Windows.Forms.TextBox TbxNumColumnas;
        private System.Windows.Forms.RichTextBox RtbMatriz;
        private System.Windows.Forms.Label LblMatriz;
        private System.Windows.Forms.Button BtnLlenar;
    }
}