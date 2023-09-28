namespace prueba2
{
    partial class DlgProyect1
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
            this.PbxFondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxFondo
            // 
            this.PbxFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxFondo.Image = global::prueba2.Properties.Resources.WhatsApp_Image_2023_09_26_at_6_09_51_PM;
            this.PbxFondo.Location = new System.Drawing.Point(0, 0);
            this.PbxFondo.Name = "PbxFondo";
            this.PbxFondo.Size = new System.Drawing.Size(800, 450);
            this.PbxFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxFondo.TabIndex = 0;
            this.PbxFondo.TabStop = false;
            // 
            // DlgProyect1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PbxFondo);
            this.Name = "DlgProyect1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            ((System.ComponentModel.ISupportInitialize)(this.PbxFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxFondo;
    }
}