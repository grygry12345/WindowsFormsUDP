namespace ListenUDP
{
    partial class frmUDPListener
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
            this.lblListener = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblListener
            // 
            this.lblListener.AutoSize = true;
            this.lblListener.Location = new System.Drawing.Point(121, 70);
            this.lblListener.Name = "lblListener";
            this.lblListener.Size = new System.Drawing.Size(20, 17);
            this.lblListener.TabIndex = 0;
            this.lblListener.Text = "...";
            // 
            // frmUDPListener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 155);
            this.Controls.Add(this.lblListener);
            this.Name = "frmUDPListener";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUDPListener_FormClosing);
            this.Load += new System.EventHandler(this.frmUDPListener_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListener;
    }
}

