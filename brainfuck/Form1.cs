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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void complie_Click(object sender, EventArgs e)
        {
            // 记录所有位置的字典
            Dictionary<int, int> map = new Dictionary<int, int>();
            // 循环用栈
            Stack<int> stack = new Stack<int>();

            // 初始化
         
            term.Clear(); // 清空终端

            

            // brainfuck 代码
            string code = coder.Text;
            //term.AppendText("准备执行：\r\n" + code + "\r\n---------\r\n执行结果：\r\n");
            
            // 当前位置
            int pos = 0;
            // 当前代码所在
            int ip = 0;
            // 跳过开关
            int pause = -1;
            // 注释开关
            bool doc = false;
            // 设置初期位置
            map.Add(pos, 0);
            
            //while (ip>=0 && ip<code.Length)
            for (ip = 0; ip < code.Length; ip++)
            {
                char c = code[ip]; // 当前字符

                // 注释的情况下
                if (doc)
                {
                    if (c == '}') doc = false;
                    continue;
                }

                // 跳过的情况下
                if (pause != -1)
                {
                    switch (c)
                    {
                        case '[': // 块入栈
                            stack.Push(ip);
                            break;
                        case ']': // 块出栈
                            int top = stack.Pop();
                            if (top == pause) pause = -1; // 已成功跳过块
                            break;
                        default:
                            break;
                    }
                    continue;
                }
                // 执行的情况下
                switch (c)
                {
                    case '{':
                        doc = true;
                        break;
                    case '}':
                        doc = false;
                        break;
                    case '>':
                        pos++;
                        if (!map.ContainsKey(pos)) map.Add(pos, 0);
                        break;
                    case '<':
                        pos--;
                        if (!map.ContainsKey(pos)) map.Add(pos, 0);
                        break;
                    case '+':
                        map[pos]++;
                        break;
                    case '-':
                        map[pos]--;
                        break;
                    case '.':
                        //MessageBox.Show(""+map[pos]);
                        term.AppendText("" + (char)map[pos]);
                        break;
                    case '[':
                        stack.Push(ip);
                        if (map[pos] == 0) pause = ip;
                        break;
                    case ']':
                        int top = stack.Pop();
                        ip = top - 1;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
