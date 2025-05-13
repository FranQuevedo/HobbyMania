namespace HobbyManiaManager
{
    partial class ImdbForm
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
            this.MoviewebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.MoviewebView)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviewebView
            // 
            this.MoviewebView.AllowExternalDrop = true;
            this.MoviewebView.CreationProperties = null;
            this.MoviewebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.MoviewebView.Location = new System.Drawing.Point(12, 12);
            this.MoviewebView.Name = "MoviewebView";
            this.MoviewebView.Size = new System.Drawing.Size(707, 361);
            this.MoviewebView.TabIndex = 0;
            this.MoviewebView.ZoomFactor = 1D;
            // 
            // ImdbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 385);
            this.Controls.Add(this.MoviewebView);
            this.Name = "ImdbForm";
            this.Text = "ImdbForm";
            this.Load += new System.EventHandler(this.ImdbForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoviewebView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 MoviewebView;
    }
}