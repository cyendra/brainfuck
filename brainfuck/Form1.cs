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
        private Dictionary<string, string> dic = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            dic.Add("Hello World", @"+++++ +++               Set Cell #0 to 8
[
    >++++               Add 4 to Cell #1; this will always set Cell #1 to 4
    [                   as the cell will be cleared by the loop
        >++             Add 2 to Cell #2
        >+++            Add 3 to Cell #3
        >+++            Add 3 to Cell #4
        >+              Add 1 to Cell #5
        <<<<-           Decrement the loop counter in Cell #1
    ]                   Loop till Cell #1 is zero; number of iterations is 4
    >+                  Add 1 to Cell #2
    >+                  Add 1 to Cell #3
    >-                  Subtract 1 from Cell #4
    >>+                 Add 1 to Cell #6
    [<]                 Move back to the first zero cell you find; this will
                        be Cell #1 which was cleared by the previous loop
    <-                  Decrement the loop Counter in Cell #0
]                       Loop till Cell #0 is zero; number of iterations is 8
 
The result of this is:
Cell No :   0   1   2   3   4   5   6
Contents:   0   0  72 104  88  32   8
Pointer :   ^
 
>>.                     Cell #2 has value 72 which is 'H'
>---.                   Subtract 3 from Cell #3 to get 101 which is 'e'
+++++ ++..+++.          Likewise for 'llo' from Cell #3
>>.                     Cell #5 is 32 for the space
<-.                     Subtract 1 from Cell #4 for 87 to give a 'W'
<.                      Cell #3 was set to 'o' from the end of 'Hello'
+++.----- -.----- ---.  Cell #3 for 'rl' and 'd'
>>+.                    Add 1 to Cell #5 gives us an exclamation point
>++.                    And finally a newline from Cell #6");
            dic.Add("ROT13", @"-,+[                         Read first character and start outer character reading loop
    -[                       Skip forward if character is 0
        >>++++[>++++++++<-]  Set up divisor (32) for division loop
                               (MEMORY LAYOUT: dividend copy remainder divisor quotient zero zero)
        <+<-[                Set up dividend (x minus 1) and enter division loop
            >+>+>-[>>>]      Increase copy and remainder / reduce divisor / Normal case: skip forward
            <[[>+<-]>>+>]    Special case: move remainder back to divisor and increase quotient
            <<<<<-           Decrement dividend
        ]                    End division loop
    ]>>>[-]+                 End skip loop; zero former divisor and reuse space for a flag
    >--[-[<->+++[-]]]<[         Zero that flag unless quotient was 2 or 3; zero quotient; check flag
        ++++++++++++<[       If flag then set up divisor (13) for second division loop
                               (MEMORY LAYOUT: zero copy dividend divisor remainder quotient zero zero)
            >-[>+>>]         Reduce divisor; Normal case: increase remainder
            >[+[<+>-]>+>>]   Special case: increase remainder / move it back to divisor / increase quotient
            <<<<<-           Decrease dividend
        ]                    End division loop
        >>[<+>-]             Add remainder back to divisor to get a useful 13
        >[                   Skip forward if quotient was 0
            -[               Decrement quotient and skip forward if quotient was 1
                -<<[-]>>     Zero quotient and divisor if quotient was 2
            ]<<[<<->>-]>>    Zero divisor and subtract 13 from copy if quotient was 1
        ]<<[<<+>>-]          Zero divisor and add 13 to copy if quotient was 0
    ]                        End outer skip loop (jump to here if ((character minus 1)/32) was not 2 or 3)
    <[-]                     Clear remainder from first division if second division was skipped
    <.[-]                    Output ROT13ed character from copy and clear it
    <-,+                     Read next character
]                            End character reading loop");
            foreach(string s in dic.Keys)
            {
                comboBox.Items.Add(s);
            }
            
        }

        private void complie_Click(object sender, EventArgs e)
        {
            // 记录所有位置的字典
            Dictionary<int, int> map = new Dictionary<int, int>();
            // 循环用栈
            Stack<int> stack = new Stack<int>();

            // 初始化
         
            term.Clear(); // 清空终端
            inputStreamBox.Clear();
            

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

            bool error = false;
            
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
                    case ',':
                        string text = inputStreamBox.Text;
                        
                        while (text.Length == 0)
                        {
                            InputForm fm = new InputForm();
                            fm.ShowDialog();
                            error = fm.error;
                            if (fm.error) break;
                            string sinput = fm.str;
                            text += sinput;
                        }
                        if (error) break;
                        char tc = text[0];
                        text = text.Substring(1);
                        inputStreamBox.Text = text;
                        map[pos] = (int)tc;
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
                if (error) break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string so = @"{
brainfuck是一种极小化的编程语言，只有8种指令。brainfuck是图灵完全的，也就是说，你用C写的所有程序、算法都可以用brainfuck实现。
五分钟包您学会 brainfuck（健）脑操语言 

（非句首请勿首字母大写 brainfuck 谢谢） 

包学包会，学不会免费再学。 

将八个操作符 < > + - [ ] . , 分别转写为：
> 右
< 左
+ 上
- 下
[ 始
] 终
. 写
, 读
然后找一张方格纸，对就是小学作文本那种，一支铅笔（不，钢笔不行，Lamy 的也不行），一块橡皮，一张从你的旧 C 语言书上撕下来的 ASCII 码表。 

现在来看 +++[>+<-] 这行程序。按照我们的转写，它变成：上上上始右上左下终。 

接下来在你的方格纸上的第一个格子里写下 0 。 

［0］ 

很好。现在我们一边读转写好的程序，一边按照以下规则行事：
遇到什么都没写的格子就当里面写了 0
右：向右移动一个格子。嗯你盯着它看就行了，什么都不用做 
左：向左移动一个格子 
上：给格子里的数字加上 1，擦掉原来的数字再写回去。现在你知道为什么要用铅笔了吧，少年！
下：给格子里的数字减去 1 
始：开始重复「始……终」之间的指令，直到你读到「始」之前盯着的那个格子里的数字变成 0 为止。（什么？那个格子里已经是负数了？……不要这么没有下限好不好） 
终：如果当前格子里的数字为 0，就跳过，否则回头到「始」那里 
写：查当前格子里的数字在 ASCII 表上对应的字母，把它写下来（不，别写在格子里，就写在你买来一直立志想用但是没有用的日记本上吧） 
读：随便想一个英文字母，查表找到它对应的数字，写到当前格子里 


}";
            coder.Clear();
            coder.Text = so;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            coder.Clear();
            coder.Text = dic[comboBox.SelectedItem.ToString()];
        }
    }
}
