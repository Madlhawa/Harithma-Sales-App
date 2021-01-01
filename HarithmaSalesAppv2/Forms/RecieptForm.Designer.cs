
namespace HarithmaSalesAppv2.Forms
{
    partial class RecieptForm
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
            this.crptv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crptv
            // 
            this.crptv.ActiveViewIndex = -1;
            this.crptv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptv.Location = new System.Drawing.Point(0, 0);
            this.crptv.Name = "crptv";
            this.crptv.Size = new System.Drawing.Size(800, 450);
            this.crptv.TabIndex = 0;
            // 
            // RecieptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crptv);
            this.Name = "RecieptForm";
            this.Text = "Reciept";
            this.Load += new System.EventHandler(this.RecieptForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crptv;
    }
}