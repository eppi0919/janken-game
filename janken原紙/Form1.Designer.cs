namespace janken原紙
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.playerLife = new System.Windows.Forms.ProgressBar();
            this.oniLife = new System.Windows.Forms.ProgressBar();
            this.playerhandPB = new System.Windows.Forms.PictureBox();
            this.onihandPB = new System.Windows.Forms.PictureBox();
            this.oniPB = new System.Windows.Forms.PictureBox();
            this.guPB = new System.Windows.Forms.PictureBox();
            this.chokiPB = new System.Windows.Forms.PictureBox();
            this.paPB = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wl1 = new System.Windows.Forms.PictureBox();
            this.wl2 = new System.Windows.Forms.PictureBox();
            this.wl3 = new System.Windows.Forms.PictureBox();
            this.wl4 = new System.Windows.Forms.PictureBox();
            this.wl5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerhandPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onihandPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oniPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chokiPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wl5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.playerLife);
            this.panel1.Controls.Add(this.oniLife);
            this.panel1.Controls.Add(this.playerhandPB);
            this.panel1.Controls.Add(this.onihandPB);
            this.panel1.Controls.Add(this.oniPB);
            this.panel1.Location = new System.Drawing.Point(4, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 410);
            this.panel1.TabIndex = 0;
            // 
            // playerLife
            // 
            this.playerLife.Location = new System.Drawing.Point(4, 394);
            this.playerLife.Name = "playerLife";
            this.playerLife.Size = new System.Drawing.Size(270, 10);
            this.playerLife.TabIndex = 3;
            // 
            // oniLife
            // 
            this.oniLife.Location = new System.Drawing.Point(4, 4);
            this.oniLife.Name = "oniLife";
            this.oniLife.Size = new System.Drawing.Size(270, 10);
            this.oniLife.TabIndex = 3;
            // 
            // playerhandPB
            // 
            this.playerhandPB.Location = new System.Drawing.Point(92, 290);
            this.playerhandPB.Name = "playerhandPB";
            this.playerhandPB.Size = new System.Drawing.Size(100, 100);
            this.playerhandPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerhandPB.TabIndex = 2;
            this.playerhandPB.TabStop = false;
            // 
            // onihandPB
            // 
            this.onihandPB.Location = new System.Drawing.Point(92, 184);
            this.onihandPB.Name = "onihandPB";
            this.onihandPB.Size = new System.Drawing.Size(100, 100);
            this.onihandPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.onihandPB.TabIndex = 1;
            this.onihandPB.TabStop = false;
            // 
            // oniPB
            // 
            this.oniPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oniPB.Image = global::janken原紙.Properties.Resources.dragon;
            this.oniPB.Location = new System.Drawing.Point(40, 20);
            this.oniPB.Name = "oniPB";
            this.oniPB.Size = new System.Drawing.Size(200, 160);
            this.oniPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oniPB.TabIndex = 0;
            this.oniPB.TabStop = false;
            // 
            // guPB
            // 
            this.guPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guPB.Image = global::janken原紙.Properties.Resources.gu;
            this.guPB.Location = new System.Drawing.Point(18, 444);
            this.guPB.Name = "guPB";
            this.guPB.Size = new System.Drawing.Size(80, 80);
            this.guPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guPB.TabIndex = 0;
            this.guPB.TabStop = false;
            this.guPB.Click += new System.EventHandler(this.guPB_Click);
            // 
            // chokiPB
            // 
            this.chokiPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chokiPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chokiPB.Image = global::janken原紙.Properties.Resources.choki;
            this.chokiPB.Location = new System.Drawing.Point(104, 444);
            this.chokiPB.Name = "chokiPB";
            this.chokiPB.Size = new System.Drawing.Size(80, 80);
            this.chokiPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chokiPB.TabIndex = 0;
            this.chokiPB.TabStop = false;
            this.chokiPB.Click += new System.EventHandler(this.chokiPB_Click);
            // 
            // paPB
            // 
            this.paPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paPB.Image = global::janken原紙.Properties.Resources.pa;
            this.paPB.Location = new System.Drawing.Point(190, 444);
            this.paPB.Name = "paPB";
            this.paPB.Size = new System.Drawing.Size(80, 80);
            this.paPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paPB.TabIndex = 0;
            this.paPB.TabStop = false;
            this.paPB.Click += new System.EventHandler(this.paPB_Click);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.start.Location = new System.Drawing.Point(290, 156);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(260, 40);
            this.start.TabIndex = 1;
            this.start.Text = "スタート";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(290, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 122);
            this.label1.TabIndex = 2;
            this.label1.Text = "じゃんけん\r\nバトル";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wl1
            // 
            this.wl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wl1.Location = new System.Drawing.Point(390, 201);
            this.wl1.Name = "wl1";
            this.wl1.Size = new System.Drawing.Size(60, 60);
            this.wl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wl1.TabIndex = 3;
            this.wl1.TabStop = false;
            // 
            // wl2
            // 
            this.wl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wl2.Location = new System.Drawing.Point(390, 267);
            this.wl2.Name = "wl2";
            this.wl2.Size = new System.Drawing.Size(60, 60);
            this.wl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wl2.TabIndex = 3;
            this.wl2.TabStop = false;
            // 
            // wl3
            // 
            this.wl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wl3.Location = new System.Drawing.Point(390, 333);
            this.wl3.Name = "wl3";
            this.wl3.Size = new System.Drawing.Size(60, 60);
            this.wl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wl3.TabIndex = 3;
            this.wl3.TabStop = false;
            // 
            // wl4
            // 
            this.wl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wl4.Location = new System.Drawing.Point(390, 399);
            this.wl4.Name = "wl4";
            this.wl4.Size = new System.Drawing.Size(60, 60);
            this.wl4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wl4.TabIndex = 3;
            this.wl4.TabStop = false;
            // 
            // wl5
            // 
            this.wl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wl5.Location = new System.Drawing.Point(390, 465);
            this.wl5.Name = "wl5";
            this.wl5.Size = new System.Drawing.Size(60, 60);
            this.wl5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wl5.TabIndex = 3;
            this.wl5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 531);
            this.Controls.Add(this.wl5);
            this.Controls.Add(this.wl4);
            this.Controls.Add(this.wl3);
            this.Controls.Add(this.wl2);
            this.Controls.Add(this.wl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.paPB);
            this.Controls.Add(this.chokiPB);
            this.Controls.Add(this.guPB);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerhandPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onihandPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oniPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chokiPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wl5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar playerLife;
        private System.Windows.Forms.ProgressBar oniLife;
        private System.Windows.Forms.PictureBox playerhandPB;
        private System.Windows.Forms.PictureBox onihandPB;
        private System.Windows.Forms.PictureBox oniPB;
        private System.Windows.Forms.PictureBox guPB;
        private System.Windows.Forms.PictureBox chokiPB;
        private System.Windows.Forms.PictureBox paPB;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox wl1;
        private System.Windows.Forms.PictureBox wl2;
        private System.Windows.Forms.PictureBox wl3;
        private System.Windows.Forms.PictureBox wl4;
        private System.Windows.Forms.PictureBox wl5;
    }
}

