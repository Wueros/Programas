
namespace Juego1P
{
    partial class F1
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
            this.LVidaP2 = new System.Windows.Forms.Label();
            this.LVidaP1 = new System.Windows.Forms.Label();
            this.VidaP2 = new System.Windows.Forms.ProgressBar();
            this.VidaP1 = new System.Windows.Forms.ProgressBar();
            this.PanelP2 = new System.Windows.Forms.Panel();
            this.PanelP1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LVidaP2
            // 
            this.LVidaP2.AutoSize = true;
            this.LVidaP2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVidaP2.Location = new System.Drawing.Point(1179, 55);
            this.LVidaP2.Name = "LVidaP2";
            this.LVidaP2.Size = new System.Drawing.Size(37, 18);
            this.LVidaP2.TabIndex = 24;
            this.LVidaP2.Text = "100";
            // 
            // LVidaP1
            // 
            this.LVidaP1.AutoSize = true;
            this.LVidaP1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVidaP1.Location = new System.Drawing.Point(560, 55);
            this.LVidaP1.Name = "LVidaP1";
            this.LVidaP1.Size = new System.Drawing.Size(37, 18);
            this.LVidaP1.TabIndex = 23;
            this.LVidaP1.Text = "100";
            // 
            // VidaP2
            // 
            this.VidaP2.Location = new System.Drawing.Point(1169, 12);
            this.VidaP2.Name = "VidaP2";
            this.VidaP2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VidaP2.RightToLeftLayout = true;
            this.VidaP2.Size = new System.Drawing.Size(520, 40);
            this.VidaP2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.VidaP2.TabIndex = 21;
            this.VidaP2.Tag = "";
            // 
            // VidaP1
            // 
            this.VidaP1.Location = new System.Drawing.Point(93, 12);
            this.VidaP1.Name = "VidaP1";
            this.VidaP1.Size = new System.Drawing.Size(520, 40);
            this.VidaP1.TabIndex = 20;
            // 
            // PanelP2
            // 
            this.PanelP2.BackColor = System.Drawing.Color.Transparent;
            this.PanelP2.Enabled = false;
            this.PanelP2.Location = new System.Drawing.Point(723, 12);
            this.PanelP2.Name = "PanelP2";
            this.PanelP2.Size = new System.Drawing.Size(374, 156);
            this.PanelP2.TabIndex = 19;
            // 
            // PanelP1
            // 
            this.PanelP1.BackColor = System.Drawing.Color.Transparent;
            this.PanelP1.Location = new System.Drawing.Point(563, 510);
            this.PanelP1.Name = "PanelP1";
            this.PanelP1.Size = new System.Drawing.Size(635, 287);
            this.PanelP1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1218, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 315);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(520, 315);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // F1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1783, 809);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LVidaP2);
            this.Controls.Add(this.LVidaP1);
            this.Controls.Add(this.VidaP2);
            this.Controls.Add(this.VidaP1);
            this.Controls.Add(this.PanelP2);
            this.Controls.Add(this.PanelP1);
            this.Name = "F1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LVidaP2;
        private System.Windows.Forms.Label LVidaP1;
        private System.Windows.Forms.ProgressBar VidaP2;
        private System.Windows.Forms.ProgressBar VidaP1;
        private System.Windows.Forms.Panel PanelP2;
        public System.Windows.Forms.Panel PanelP1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

