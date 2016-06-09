namespace Chp8_Test10
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
            this.add = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.browried = new System.Windows.Forms.RadioButton();
            this.banana = new System.Windows.Forms.RadioButton();
            this.addFood = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.feed = new System.Windows.Forms.GroupBox();
            this.lines = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.feed.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(367, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(200, 72);
            this.add.TabIndex = 0;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(73, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(265, 38);
            this.name.TabIndex = 1;
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(21, 46);
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(154, 38);
            this.howMany.TabIndex = 3;
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(21, 104);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(126, 36);
            this.crispy.TabIndex = 4;
            this.crispy.TabStop = true;
            this.crispy.Text = "crispy";
            this.crispy.UseVisualStyleBackColor = true;
            this.crispy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(21, 161);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(128, 36);
            this.soggy.TabIndex = 5;
            this.soggy.TabStop = true;
            this.soggy.Text = "soggy";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // browried
            // 
            this.browried.AutoSize = true;
            this.browried.Location = new System.Drawing.Point(21, 222);
            this.browried.Name = "browried";
            this.browried.Size = new System.Drawing.Size(161, 36);
            this.browried.TabIndex = 6;
            this.browried.TabStop = true;
            this.browried.Text = "browried";
            this.browried.UseVisualStyleBackColor = true;
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Location = new System.Drawing.Point(21, 280);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(148, 36);
            this.banana.TabIndex = 7;
            this.banana.TabStop = true;
            this.banana.Text = "banana";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // addFood
            // 
            this.addFood.Location = new System.Drawing.Point(21, 351);
            this.addFood.Name = "addFood";
            this.addFood.Size = new System.Drawing.Size(215, 68);
            this.addFood.TabIndex = 8;
            this.addFood.Text = "add food";
            this.addFood.UseVisualStyleBackColor = true;
            this.addFood.Click += new System.EventHandler(this.addFood_Click);
            // 
            // message
            // 
            this.message.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.message.Location = new System.Drawing.Point(21, 433);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(215, 152);
            this.message.TabIndex = 9;
            this.message.Text = "label1";
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(27, 602);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(209, 67);
            this.next.TabIndex = 10;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // feed
            // 
            this.feed.Controls.Add(this.howMany);
            this.feed.Controls.Add(this.next);
            this.feed.Controls.Add(this.message);
            this.feed.Controls.Add(this.crispy);
            this.feed.Controls.Add(this.addFood);
            this.feed.Controls.Add(this.soggy);
            this.feed.Controls.Add(this.banana);
            this.feed.Controls.Add(this.browried);
            this.feed.Location = new System.Drawing.Point(367, 102);
            this.feed.Name = "feed";
            this.feed.Size = new System.Drawing.Size(376, 723);
            this.feed.TabIndex = 11;
            this.feed.TabStop = false;
            this.feed.Text = "feed";
            // 
            // lines
            // 
            this.lines.FormattingEnabled = true;
            this.lines.ItemHeight = 31;
            this.lines.Location = new System.Drawing.Point(73, 102);
            this.lines.Name = "lines";
            this.lines.Size = new System.Drawing.Size(265, 717);
            this.lines.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 889);
            this.Controls.Add(this.lines);
            this.Controls.Add(this.feed);
            this.Controls.Add(this.name);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.feed.ResumeLayout(false);
            this.feed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.NumericUpDown howMany;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton browried;
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.Button addFood;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.GroupBox feed;
        private System.Windows.Forms.ListBox lines;
    }
}

