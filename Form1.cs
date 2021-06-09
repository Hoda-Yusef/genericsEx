using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genericsEx
{
    public partial class Form1 : Form
    {
        private static SpecialStack<double> s1 = new SpecialStack<double>(10);
        private static SpecialStack<string> s2 = new SpecialStack<string>(10);
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_insertNum_Click(object sender, EventArgs e)//כפתור להכנסת מספר לתור
        {
            s1.Push(Convert.ToDouble(txt_number.Text));
            txt_number.Clear();
        }

        private void txt_number_KeyPress(object sender, KeyPressEventArgs e)//שדה מקבל רק מספרים
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void txt_string_KeyPress(object sender, KeyPressEventArgs e)//שדה מקבל רק אותיות
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void btn_removeNum_Click(object sender, EventArgs e)//כפתור למחיקת ערך מספרי מהתור
        {
            double tmp;
            tmp = s1.Remove(s1);
            if (tmp != 0.0)
                txt_outNumber.Text = tmp.ToString();
            else
                txt_outNumber.Text = "";
        }

        private void btn_insertStr_Click(object sender, EventArgs e)//כפתור להכנסת אותיות לתור
        {
            s2.Push(txt_string.Text.ToString());
            txt_string.Clear();
        }

        private void btn_removeStr_Click(object sender, EventArgs e)//כפתור למחיקת אותיות מתור
        {
            string tmp;
            tmp = s2.Remove(s2);
            if (tmp != string.Empty)
                txt_outString.Text = tmp;
            else
                txt_outString.Text = "";
        }
    }
}
