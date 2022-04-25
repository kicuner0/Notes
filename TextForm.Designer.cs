namespace Notes
{
    partial class TextForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnItalic = new System.Windows.Forms.ToolStripButton();
            this.BtnBold = new System.Windows.Forms.ToolStripButton();
            this.BtnFontUp = new System.Windows.Forms.ToolStripButton();
            this.BtnFontDown = new System.Windows.Forms.ToolStripButton();
            this.TbxData = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnItalic,
            this.BtnBold,
            this.BtnFontUp,
            this.BtnFontDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(482, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnItalic
            // 
            this.BtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnItalic.Image = ((System.Drawing.Image)(resources.GetObject("BtnItalic.Image")));
            this.BtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnItalic.Name = "BtnItalic";
            this.BtnItalic.Size = new System.Drawing.Size(29, 24);
            this.BtnItalic.Text = "Italic";
            this.BtnItalic.Click += new System.EventHandler(this.BtnItalic_Click);
            // 
            // BtnBold
            // 
            this.BtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnBold.Image = ((System.Drawing.Image)(resources.GetObject("BtnBold.Image")));
            this.BtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBold.Name = "BtnBold";
            this.BtnBold.Size = new System.Drawing.Size(29, 24);
            this.BtnBold.Text = "Bold";
            this.BtnBold.Click += new System.EventHandler(this.BtnBold_Click);
            // 
            // BtnFontUp
            // 
            this.BtnFontUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnFontUp.Image = ((System.Drawing.Image)(resources.GetObject("BtnFontUp.Image")));
            this.BtnFontUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFontUp.Name = "BtnFontUp";
            this.BtnFontUp.Size = new System.Drawing.Size(29, 24);
            this.BtnFontUp.Text = "Font Up";
            this.BtnFontUp.Click += new System.EventHandler(this.BtnFontUp_Click);
            // 
            // BtnFontDown
            // 
            this.BtnFontDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnFontDown.Image = ((System.Drawing.Image)(resources.GetObject("BtnFontDown.Image")));
            this.BtnFontDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFontDown.Name = "BtnFontDown";
            this.BtnFontDown.Size = new System.Drawing.Size(29, 24);
            this.BtnFontDown.Text = "Font Down";
            this.BtnFontDown.Click += new System.EventHandler(this.BtnFontDown_Click);
            // 
            // TbxData
            // 
            this.TbxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxData.Location = new System.Drawing.Point(0, 27);
            this.TbxData.Name = "TbxData";
            this.TbxData.Size = new System.Drawing.Size(482, 426);
            this.TbxData.TabIndex = 1;
            this.TbxData.Text = "";
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.TbxData);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "TextForm";
            this.Text = "TextForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextForm_FormClosing);
            this.Load += new System.EventHandler(this.TextForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private RichTextBox TbxData;
        private ToolStripButton BtnItalic;
        private ToolStripButton BtnBold;
        private ToolStripButton BtnFontUp;
        private ToolStripButton BtnFontDown;
    }
}