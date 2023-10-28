namespace Hardware_Info
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
            this.btnmac = new System.Windows.Forms.Button();
            this.mactxt = new System.Windows.Forms.TextBox();
            this.iptxt = new System.Windows.Forms.TextBox();
            this.btnip = new System.Windows.Forms.Button();
            this.cputxt = new System.Windows.Forms.TextBox();
            this.btncpu = new System.Windows.Forms.Button();
            this.hddtxt = new System.Windows.Forms.TextBox();
            this.btnhdd = new System.Windows.Forms.Button();
            this.ramtxt = new System.Windows.Forms.TextBox();
            this.btnram = new System.Windows.Forms.Button();
            this.videotxt = new System.Windows.Forms.TextBox();
            this.btnvideo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmac
            // 
            this.btnmac.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmac.Location = new System.Drawing.Point(12, 12);
            this.btnmac.Name = "btnmac";
            this.btnmac.Size = new System.Drawing.Size(172, 43);
            this.btnmac.TabIndex = 0;
            this.btnmac.Text = "Get Mac ID";
            this.btnmac.UseVisualStyleBackColor = true;
            this.btnmac.Click += new System.EventHandler(this.btnmac_Click);
            // 
            // mactxt
            // 
            this.mactxt.Location = new System.Drawing.Point(190, 12);
            this.mactxt.Multiline = true;
            this.mactxt.Name = "mactxt";
            this.mactxt.Size = new System.Drawing.Size(281, 43);
            this.mactxt.TabIndex = 1;
            // 
            // iptxt
            // 
            this.iptxt.Location = new System.Drawing.Point(190, 75);
            this.iptxt.Multiline = true;
            this.iptxt.Name = "iptxt";
            this.iptxt.Size = new System.Drawing.Size(281, 43);
            this.iptxt.TabIndex = 3;
            // 
            // btnip
            // 
            this.btnip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnip.Location = new System.Drawing.Point(12, 75);
            this.btnip.Name = "btnip";
            this.btnip.Size = new System.Drawing.Size(172, 43);
            this.btnip.TabIndex = 2;
            this.btnip.Text = "Get IP";
            this.btnip.UseVisualStyleBackColor = true;
            this.btnip.Click += new System.EventHandler(this.btnip_Click);
            // 
            // cputxt
            // 
            this.cputxt.Location = new System.Drawing.Point(190, 141);
            this.cputxt.Multiline = true;
            this.cputxt.Name = "cputxt";
            this.cputxt.Size = new System.Drawing.Size(281, 43);
            this.cputxt.TabIndex = 5;
            // 
            // btncpu
            // 
            this.btncpu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncpu.Location = new System.Drawing.Point(12, 141);
            this.btncpu.Name = "btncpu";
            this.btncpu.Size = new System.Drawing.Size(172, 43);
            this.btncpu.TabIndex = 4;
            this.btncpu.Text = "Get CPU ID";
            this.btncpu.UseVisualStyleBackColor = true;
            this.btncpu.Click += new System.EventHandler(this.btncpu_Click);
            // 
            // hddtxt
            // 
            this.hddtxt.Location = new System.Drawing.Point(190, 215);
            this.hddtxt.Multiline = true;
            this.hddtxt.Name = "hddtxt";
            this.hddtxt.Size = new System.Drawing.Size(281, 43);
            this.hddtxt.TabIndex = 7;
            // 
            // btnhdd
            // 
            this.btnhdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhdd.Location = new System.Drawing.Point(12, 215);
            this.btnhdd.Name = "btnhdd";
            this.btnhdd.Size = new System.Drawing.Size(172, 43);
            this.btnhdd.TabIndex = 6;
            this.btnhdd.Text = "Get HDD Serial";
            this.btnhdd.UseVisualStyleBackColor = true;
            this.btnhdd.Click += new System.EventHandler(this.btnhdd_Click);
            // 
            // ramtxt
            // 
            this.ramtxt.Location = new System.Drawing.Point(190, 282);
            this.ramtxt.Multiline = true;
            this.ramtxt.Name = "ramtxt";
            this.ramtxt.Size = new System.Drawing.Size(281, 43);
            this.ramtxt.TabIndex = 9;
            // 
            // btnram
            // 
            this.btnram.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnram.Location = new System.Drawing.Point(12, 282);
            this.btnram.Name = "btnram";
            this.btnram.Size = new System.Drawing.Size(172, 43);
            this.btnram.TabIndex = 8;
            this.btnram.Text = "Get RAM Size";
            this.btnram.UseVisualStyleBackColor = true;
            this.btnram.Click += new System.EventHandler(this.btnram_Click);
            // 
            // videotxt
            // 
            this.videotxt.Location = new System.Drawing.Point(190, 346);
            this.videotxt.Multiline = true;
            this.videotxt.Name = "videotxt";
            this.videotxt.Size = new System.Drawing.Size(281, 63);
            this.videotxt.TabIndex = 11;
            // 
            // btnvideo
            // 
            this.btnvideo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvideo.Location = new System.Drawing.Point(12, 346);
            this.btnvideo.Name = "btnvideo";
            this.btnvideo.Size = new System.Drawing.Size(172, 63);
            this.btnvideo.TabIndex = 10;
            this.btnvideo.Text = "Get Video Count Info";
            this.btnvideo.UseVisualStyleBackColor = true;
            this.btnvideo.Click += new System.EventHandler(this.btnvideo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 428);
            this.Controls.Add(this.videotxt);
            this.Controls.Add(this.btnvideo);
            this.Controls.Add(this.ramtxt);
            this.Controls.Add(this.btnram);
            this.Controls.Add(this.hddtxt);
            this.Controls.Add(this.btnhdd);
            this.Controls.Add(this.cputxt);
            this.Controls.Add(this.btncpu);
            this.Controls.Add(this.iptxt);
            this.Controls.Add(this.btnip);
            this.Controls.Add(this.mactxt);
            this.Controls.Add(this.btnmac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmac;
        private System.Windows.Forms.TextBox mactxt;
        private System.Windows.Forms.TextBox iptxt;
        private System.Windows.Forms.Button btnip;
        private System.Windows.Forms.TextBox cputxt;
        private System.Windows.Forms.Button btncpu;
        private System.Windows.Forms.TextBox hddtxt;
        private System.Windows.Forms.Button btnhdd;
        private System.Windows.Forms.TextBox ramtxt;
        private System.Windows.Forms.Button btnram;
        private System.Windows.Forms.TextBox videotxt;
        private System.Windows.Forms.Button btnvideo;
    }
}

