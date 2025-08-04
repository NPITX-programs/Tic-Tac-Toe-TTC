namespace TicTacToeProject
{
    partial class frmSplashScreen
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
            this.btn_viewDebug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_viewDebug
            // 
            this.btn_viewDebug.Location = new System.Drawing.Point(0, 0);
            this.btn_viewDebug.Name = "btn_viewDebug";
            this.btn_viewDebug.Size = new System.Drawing.Size(75, 23);
            this.btn_viewDebug.TabIndex = 0;
            this.btn_viewDebug.Text = "Debug Info";
            this.btn_viewDebug.UseVisualStyleBackColor = true;
            this.btn_viewDebug.Click += new System.EventHandler(this.btn_viewDebug_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_viewDebug);
            this.Name = "frm_main";
            this.Text = "Form 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_viewDebug;
    }
}

