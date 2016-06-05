namespace Chp6_Test6
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
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.assignJob = new System.Windows.Forms.Button();
            this.shift = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shift)).BeginInit();
            this.SuspendLayout();
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Egg care",
            "Hive maintenance",
            "Baby Bee Tutoring",
            "Honey manufacting",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(66, 110);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(340, 39);
            this.workerBeeJob.TabIndex = 0;
            // 
            // assignJob
            // 
            this.assignJob.Location = new System.Drawing.Point(66, 193);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(340, 46);
            this.assignJob.TabIndex = 1;
            this.assignJob.Text = "Assignthis job to a bee";
            this.assignJob.UseVisualStyleBackColor = true;
            this.assignJob.Click += new System.EventHandler(this.assignJob_Click);
            // 
            // shift
            // 
            this.shift.Location = new System.Drawing.Point(424, 110);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(170, 38);
            this.shift.TabIndex = 2;
            this.shift.ValueChanged += new System.EventHandler(this.shift_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 129);
            this.button2.TabIndex = 3;
            this.button2.Text = "Work the next shift";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(66, 260);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(808, 432);
            this.report.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Worker bee job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Shifts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 704);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.report);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.shift);
            this.Controls.Add(this.assignJob);
            this.Controls.Add(this.workerBeeJob);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.shift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Button assignJob;
        private System.Windows.Forms.NumericUpDown shift;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox report;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

