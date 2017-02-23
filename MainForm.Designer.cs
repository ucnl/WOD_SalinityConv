namespace WOD_SalinityConv
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openBtn = new System.Windows.Forms.ToolStripButton();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(583, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openBtn
            // 
            this.openBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openBtn.Image = ((System.Drawing.Image)(resources.GetObject("openBtn.Image")));
            this.openBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(74, 24);
            this.openBtn.Text = "Open file";
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(12, 30);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(559, 304);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBox.TabIndex = 1;
            this.pBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 346);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "WOD salinity converter";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openBtn;
        private System.Windows.Forms.PictureBox pBox;
    }
}

