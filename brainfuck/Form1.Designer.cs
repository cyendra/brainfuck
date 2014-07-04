namespace brainfuck
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
            this.coder = new System.Windows.Forms.TextBox();
            this.complie = new System.Windows.Forms.Button();
            this.term = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coder
            // 
            this.coder.AcceptsTab = true;
            this.coder.Location = new System.Drawing.Point(211, 43);
            this.coder.Multiline = true;
            this.coder.Name = "coder";
            this.coder.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.coder.Size = new System.Drawing.Size(561, 227);
            this.coder.TabIndex = 0;
            // 
            // complie
            // 
            this.complie.Location = new System.Drawing.Point(636, 518);
            this.complie.Name = "complie";
            this.complie.Size = new System.Drawing.Size(136, 31);
            this.complie.TabIndex = 1;
            this.complie.Text = "执行";
            this.complie.UseVisualStyleBackColor = true;
            this.complie.Click += new System.EventHandler(this.complie_Click);
            // 
            // term
            // 
            this.term.AcceptsReturn = true;
            this.term.AcceptsTab = true;
            this.term.Location = new System.Drawing.Point(211, 315);
            this.term.Multiline = true;
            this.term.Name = "term";
            this.term.ReadOnly = true;
            this.term.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.term.Size = new System.Drawing.Size(561, 142);
            this.term.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "代码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "终端：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.term);
            this.Controls.Add(this.complie);
            this.Controls.Add(this.coder);
            this.Name = "Form1";
            this.Text = "brainfuck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox coder;
        private System.Windows.Forms.Button complie;
        private System.Windows.Forms.TextBox term;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

