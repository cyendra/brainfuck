using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brainfuck
{
    public partial class InputForm : Form
    {
        public string str = "";
        public bool error = false;
        public InputForm()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            str = inputText.Text;
            if (str == "") MessageBox.Show("请输入一些字符");
            else Close();
        }

        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            error = true;
        }
    }
}
