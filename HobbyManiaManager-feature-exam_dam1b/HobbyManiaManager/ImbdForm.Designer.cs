namespace HobbyManiaManager
{
    partial class ImbdForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MovieWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.MovieWebView)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieWebView
            // 
            this.MovieWebView.AllowExternalDrop = true;
            this.MovieWebView.CreationProperties = null;
            this.MovieWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.MovieWebView.Location = new System.Drawing.Point(29, 30);
            this.MovieWebView.Name = "MovieWebView";
            this.MovieWebView.Size = new System.Drawing.Size(745, 388);
            this.MovieWebView.TabIndex = 0;
            this.MovieWebView.ZoomFactor = 1D;
            // 
            // ImbdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MovieWebView);
            this.Name = "ImbdForm";
            this.Text = "ImbdForm";
            this.Load += new System.EventHandler(this.ImbdForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MovieWebView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.Web.WebView2.WinForms.WebView2 MovieWebView;
    }
}