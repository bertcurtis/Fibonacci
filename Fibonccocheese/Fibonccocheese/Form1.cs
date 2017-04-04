using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonccocheese
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "     When Fibonacci was a young man he was very good at math. But he was too good at it. " +
                "Everyone mocked him. His mother told him that it was because they were envious of him. " +
                "He didn't believe her so he developed a formula to see if she was telling the truth or not. " +
                "The formula is this:" +
                "Type the first letter of your first name to see how many people are envious of you. " +
                "When you are done click below or press enter.";
        }



        private string fibonacci()
        {
            string result = "";
            int a = 0;
            int b = 1;
            int c = 1;
            int d = b + c;
            int e = d + c;
            int f = d + e;
            int g = f + e;
            int h = g + f;
            int i = h + g;
            int j = i + h;
            int k = j + i;
            int l = k + j;
            int m = l + k;
            int n = m + l;
            int o = n + m;
            int p = o + n;
            int q = p + o;
            int r = q + p;
            int s = r + q;
            int t = s + r;
            int u = t + s;
            int v = u + t;
            int w = v + u;
            int x = w + v;
            int y = x + w;
            int z = y + x;
            string userValue7 = textBox2.Text;

            switch (userValue7)
            {
                case "a":
                    result = a.ToString();
                    break;
                case "b":
                    result = b.ToString();
                    break;
                case "c":
                    result = c.ToString();
                    break;
                case "d":
                    result = d.ToString();
                    break;
                case "e":
                    result = e.ToString();
                    break;
                case "f":
                    result = f.ToString();
                    break;
                case "g":
                    result = g.ToString();
                    break;
                case "h":
                    result = h.ToString();
                    break;
                case "i":
                    result = i.ToString();
                    break;
                case "j":
                    result = j.ToString();
                    break;
                case "k":
                    result = k.ToString();
                    break;
                case "l":
                    result = l.ToString();
                    break;
                case "m":
                    result = m.ToString();
                    break;
                case "n":
                    result = n.ToString();
                    break;
                case "o":
                    result = o.ToString();
                    break;
                case "p":
                    result = p.ToString();
                    break;
                case "q":
                    result = q.ToString();
                    break;
                case "r":
                    result = r.ToString();
                    break;
                case "s":
                    result = s.ToString();
                    break;
                case "t":
                    result = t.ToString();
                    break;
                case "u":
                    result = u.ToString();
                    break;
                case "v":
                    result = v.ToString();
                    break;
                case "w":
                    result = w.ToString();
                    break;
                case "x":
                    result = x.ToString();
                    break;
                case "y":
                    result = y.ToString();
                    break;
                case "z":
                    result = z.ToString();
                    break;
                //case "done":
                //result = "".ToString();
                //break;
                default:
                    result = " Fibonacci is growing impatient with your inability to follow simple directions... Absolutely no";

                    break;


            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fibonacci2 = fibonacci();
            MessageBox.Show(fibonacci2 + " people are envious of you.");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=JmvnYnQv1UI");
            }
            catch { }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=ussCHoQttyQ");
            }
            catch { }
        }




        private void textBox_HelpRequested(object sender, System.Windows.Forms.HelpEventArgs hlpevent)
        {

            string helpBox = "If this box is showing up it means you have clicked something using the '?' button in the top right corner." +
                " This action is intended to provide" + 
                " help for those who are having difficulty with this simple program. If you are one of those people then there is" +
                " help for you. But you will not find it here. This is simply a text box meant to instruct you in regards to this program. Due to the fact that this" +
                " program is so simple it is obvious to me that if you actually need help navigating navigating this program then you should close the program" +
                " immediately and seek professional help. Although if you can't work this program then you probably will not be capable to seek professional help" +
                " in which case I am now unsure how to help you. Good luck in your life endeavors and please don't operate any heavy machinery. Ever.";
            MessageBox.Show(helpBox);
        }

     

    }

    }
