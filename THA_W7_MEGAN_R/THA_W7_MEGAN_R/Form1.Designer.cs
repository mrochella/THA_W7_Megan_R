namespace THA_W7_MEGAN_R
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
            this.panel_seating = new System.Windows.Forms.Panel();
            this.panel_mvList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_seating
            // 
            this.panel_seating.Location = new System.Drawing.Point(488, 2);
            this.panel_seating.Name = "panel_seating";
            this.panel_seating.Size = new System.Drawing.Size(388, 496);
            this.panel_seating.TabIndex = 1;
            // 
            // panel_mvList
            // 
            this.panel_mvList.Location = new System.Drawing.Point(2, 2);
            this.panel_mvList.Name = "panel_mvList";
            this.panel_mvList.Size = new System.Drawing.Size(480, 496);
            this.panel_mvList.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 502);
            this.Controls.Add(this.panel_mvList);
            this.Controls.Add(this.panel_seating);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_seating;
        private System.Windows.Forms.Panel panel_mvList;
    }
}

