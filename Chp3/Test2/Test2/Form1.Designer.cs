namespace Test2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.joeCashlabel = new System.Windows.Forms.Label();
            this.bobsCashlabel = new System.Windows.Forms.Label();
            this.bankCashlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joeGiveToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joeCashlabel
            // 
            this.joeCashlabel.AutoSize = true;
            this.joeCashlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joeCashlabel.Location = new System.Drawing.Point(96, 48);
            this.joeCashlabel.Name = "joeCashlabel";
            this.joeCashlabel.Size = new System.Drawing.Size(259, 48);
            this.joeCashlabel.TabIndex = 0;
            this.joeCashlabel.Text = "Joe has $50";
            // 
            // bobsCashlabel
            // 
            this.bobsCashlabel.AutoSize = true;
            this.bobsCashlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobsCashlabel.Location = new System.Drawing.Point(96, 124);
            this.bobsCashlabel.Name = "bobsCashlabel";
            this.bobsCashlabel.Size = new System.Drawing.Size(294, 48);
            this.bobsCashlabel.TabIndex = 1;
            this.bobsCashlabel.Text = "Bob has $100";
            // 
            // bankCashlabel
            // 
            this.bankCashlabel.AutoSize = true;
            this.bankCashlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankCashlabel.Location = new System.Drawing.Point(96, 202);
            this.bankCashlabel.Name = "bankCashlabel";
            this.bankCashlabel.Size = new System.Drawing.Size(404, 48);
            this.bankCashlabel.TabIndex = 2;
            this.bankCashlabel.Text = "The bank has $100";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(104, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 113);
            this.button1.TabIndex = 3;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(425, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 113);
            this.button2.TabIndex = 4;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joeGiveToBob
            // 
            this.joeGiveToBob.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joeGiveToBob.Location = new System.Drawing.Point(104, 465);
            this.joeGiveToBob.Name = "joeGiveToBob";
            this.joeGiveToBob.Size = new System.Drawing.Size(263, 113);
            this.joeGiveToBob.TabIndex = 5;
            this.joeGiveToBob.Text = "Joe gives $10 to Bob";
            this.joeGiveToBob.UseVisualStyleBackColor = true;
            this.joeGiveToBob.Click += new System.EventHandler(this.joeGiveToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobGivesToJoe.Location = new System.Drawing.Point(425, 465);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(281, 113);
            this.bobGivesToJoe.TabIndex = 6;
            this.bobGivesToJoe.Text = "Bob gives $5 to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 618);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGiveToBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankCashlabel);
            this.Controls.Add(this.bobsCashlabel);
            this.Controls.Add(this.joeCashlabel);
            this.Name = "Form1";
            this.Text = "Fun with Joe an Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joeCashlabel;
        private System.Windows.Forms.Label bobsCashlabel;
        private System.Windows.Forms.Label bankCashlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button joeGiveToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
    }
}

