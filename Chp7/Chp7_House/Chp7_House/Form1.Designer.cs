namespace Chp7_House
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
            this.description = new System.Windows.Forms.TextBox();
            this.goHere = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.ComboBox();
            this.goThrough = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 12);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(1015, 514);
            this.description.TabIndex = 0;
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(12, 532);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(201, 79);
            this.goHere.TabIndex = 1;
            this.goHere.Text = "Go here;";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // exits
            // 
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(378, 532);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(649, 39);
            this.exits.TabIndex = 2;
            // 
            // goThrough
            // 
            this.goThrough.Location = new System.Drawing.Point(12, 640);
            this.goThrough.Name = "goThrough";
            this.goThrough.Size = new System.Drawing.Size(1015, 83);
            this.goThrough.TabIndex = 3;
            this.goThrough.Text = "Go through the door";
            this.goThrough.UseVisualStyleBackColor = true;
            this.goThrough.Click += new System.EventHandler(this.goThrough_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 755);
            this.Controls.Add(this.goThrough);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.description);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button goThrough;
    }
}

