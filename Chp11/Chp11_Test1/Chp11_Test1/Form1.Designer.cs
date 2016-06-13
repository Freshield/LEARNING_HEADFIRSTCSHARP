namespace Chp11_Test1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Trajectory = new System.Windows.Forms.NumericUpDown();
            this.Distance = new System.Windows.Forms.NumericUpDown();
            this.playball = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Trajectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Distance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trajectory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance";
            // 
            // Trajectory
            // 
            this.Trajectory.Location = new System.Drawing.Point(283, 145);
            this.Trajectory.Name = "Trajectory";
            this.Trajectory.Size = new System.Drawing.Size(199, 38);
            this.Trajectory.TabIndex = 2;
            // 
            // Distance
            // 
            this.Distance.Location = new System.Drawing.Point(283, 237);
            this.Distance.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(199, 38);
            this.Distance.TabIndex = 3;
            // 
            // playball
            // 
            this.playball.Location = new System.Drawing.Point(283, 349);
            this.playball.Name = "playball";
            this.playball.Size = new System.Drawing.Size(199, 49);
            this.playball.TabIndex = 4;
            this.playball.Text = "Play Ball!!!";
            this.playball.UseVisualStyleBackColor = true;
            this.playball.Click += new System.EventHandler(this.playball_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 544);
            this.Controls.Add(this.playball);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.Trajectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Trajectory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Distance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Trajectory;
        private System.Windows.Forms.NumericUpDown Distance;
        private System.Windows.Forms.Button playball;
    }
}

