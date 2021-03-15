namespace UoFiddler.Controls.Forms
{
    partial class RegionExporterForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.RegionPriorityTb = new System.Windows.Forms.TextBox();
            this.RegionNameTb = new System.Windows.Forms.TextBox();
            this.RegionMusicTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RectanglesTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 122);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(413, 212);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // RegionPriorityTb
            // 
            this.RegionPriorityTb.Location = new System.Drawing.Point(102, 12);
            this.RegionPriorityTb.Name = "RegionPriorityTb";
            this.RegionPriorityTb.Size = new System.Drawing.Size(100, 20);
            this.RegionPriorityTb.TabIndex = 1;
            // 
            // RegionNameTb
            // 
            this.RegionNameTb.Location = new System.Drawing.Point(102, 49);
            this.RegionNameTb.Name = "RegionNameTb";
            this.RegionNameTb.Size = new System.Drawing.Size(100, 20);
            this.RegionNameTb.TabIndex = 2;
            // 
            // RegionMusicTb
            // 
            this.RegionMusicTb.Location = new System.Drawing.Point(102, 86);
            this.RegionMusicTb.Name = "RegionMusicTb";
            this.RegionMusicTb.Size = new System.Drawing.Size(100, 20);
            this.RegionMusicTb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Region Priority";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Region Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Region Music";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(157, 340);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(130, 33);
            this.ExportButton.TabIndex = 7;
            this.ExportButton.Text = "Export Region";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rectangles:";
            // 
            // RectanglesTb
            // 
            this.RectanglesTb.Location = new System.Drawing.Point(322, 12);
            this.RectanglesTb.Name = "RectanglesTb";
            this.RectanglesTb.ReadOnly = true;
            this.RectanglesTb.Size = new System.Drawing.Size(100, 20);
            this.RectanglesTb.TabIndex = 9;
            // 
            // RegionExporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 385);
            this.Controls.Add(this.RectanglesTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegionMusicTb);
            this.Controls.Add(this.RegionNameTb);
            this.Controls.Add(this.RegionPriorityTb);
            this.Controls.Add(this.richTextBox1);
            this.Name = "RegionExporterForm";
            this.Text = "RegionExporterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox RegionPriorityTb;
        private System.Windows.Forms.TextBox RegionNameTb;
        private System.Windows.Forms.TextBox RegionMusicTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RectanglesTb;
    }
}