﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf05login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "abcd" && textBox2.Text == "1234")
            {
                lblresult.Text = "로그인 성공";
            }    
                
            else
            {
                lblresult.Text = "로그인 실패";
            }
                
        }
    }
}
