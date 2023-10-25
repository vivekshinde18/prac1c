using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Pract1c : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text.Equals("Fibonacci"))
        {
            int usrInputNumber = Convert.ToInt32(textBox1.Text.ToString());
            int firstNo = 0;
            int secondNo = 1;
            int sum = 0;
            Response.Write("fibonnaci series : " + firstNo + ", " + secondNo);
            int i = 2;
            while (i < usrInputNumber)
            {
                sum = firstNo + secondNo;
                Response.Write(", " + sum);
                firstNo = secondNo;
                secondNo = sum;
                i++;
            }
        }
        else if (DropDownList1.SelectedItem.Text.Equals("prime"))
        {
            int num1 = Convert.ToInt32(textBox1.Text.ToString());
            int i;
            for (i = 2; i < num1 - 1; i++)
            {
                if (num1 % i == 0)
                    break;
            }
            if (i < num1 - 1)
            {
                result.Text = "IS NOT A PRIME NUMBER";
            }
            else
            {
                result.Text = "A PRIME NUMBER";
            }
        }
        else if (DropDownList1.SelectedItem.Text.Equals("vowels"))
        {
            string str = textBox1.Text.ToString().ToLower();
            int c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str.Substring(i, 1)) == "a" || (str.Substring(i, 1)) == "e" || (str.Substring(i, 1)) ==
                "i" || (str.Substring(i, 1)) == "o" || (str.Substring(i, 1)) == "u")
                {
                    c++;
                }
            }
            result.Text = ("Total number of vowels in " + str + " is " + c);
        }
        else if (DropDownList1.SelectedItem.Text.Equals("Reverse and Find sum of  Digit"))
        {
            int num1 = Convert.ToInt32(textBox1.Text.ToString());
            int reverse = 0;
            int sum = 0;
            while (num1 != 0)
            {
                int remainder = num1 % 10;
                reverse = reverse * 10 + remainder;
                sum = remainder + sum;
                num1 = num1 / 10;
            }
            result.Text = "<br>" + "Reverse of entered number is " + reverse + "<br>" + "Sum of digits is " + sum;
        }
        else
        {
            String s = textBox1.Text.ToString();
            foreach (char c in s)
            {
                Response.Write("<br>" + c);
            }
        }
    }
}