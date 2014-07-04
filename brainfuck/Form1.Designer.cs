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
            this.inputStreamBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coder
            // 
            this.coder.AcceptsReturn = true;
            this.coder.AcceptsTab = true;
            this.coder.Location = new System.Drawing.Point(123, 43);
            this.coder.Multiline = true;
            this.coder.Name = "coder";
            this.coder.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.coder.Size = new System.Drawing.Size(649, 225);
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
            this.term.Location = new System.Drawing.Point(123, 383);
            this.term.Multiline = true;
            this.term.Name = "term";
            this.term.ReadOnly = true;
            this.term.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.term.Size = new System.Drawing.Size(649, 129);
            this.term.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "代码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "终端：";
            // 
            // inputStreamBox
            // 
            this.inputStreamBox.AcceptsReturn = true;
            this.inputStreamBox.AcceptsTab = true;
            this.inputStreamBox.Location = new System.Drawing.Point(123, 300);
            this.inputStreamBox.Multiline = true;
            this.inputStreamBox.Name = "inputStreamBox";
            this.inputStreamBox.ReadOnly = true;
            this.inputStreamBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputStreamBox.Size = new System.Drawing.Size(649, 52);
            this.inputStreamBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "输入流：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = " brainfuck 说明";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(12, 131);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(105, 20);
            this.comboBox.TabIndex = 8;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "样例代码：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputStreamBox);
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
        private System.Windows.Forms.TextBox inputStreamBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label4;
    }
}

