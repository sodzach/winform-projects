using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace play_ground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool LaNT(int k)
        {
            for (int i = 2; i < k; i++)
                if (k % i == 0)
                    return false;
            return true;
        }

        void LietKeNT(int n)
        {
            for (int i = 2; i < n; i++)
                if (LaNT(i) == true)
                    kq.Text = kq.Text + "," + i.ToString();
        }

        int TinhTongNT(int n)
        {
            int s = 0;
            for (int i = 2; i < n; i++)
                if (LaNT(i) == true)
                    s += i;
                    return s;

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*
            int s;

            int nhapA = int.Parse(a.Text);
            int nhapB = int.Parse(b.Text);

            s = nhapA + nhapB;

            kq.Text = s.ToString();
            */
            
            int n = int.Parse(a.Text);
            LietKeNT(n);
            tong.Text = TinhTongNT(n).ToString();

            

      
            
        }

        private void A_Click(object sender, EventArgs e)
        {

        }
    }
}
