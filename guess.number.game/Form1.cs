﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guess.number.game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rnd = 0, counter = 0, min=100 , max =999, num = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = rnd.ToString();
            num = (min + max) / 2;
            label5.Text = num.ToString();
            listBox1.Items.Add(label5.Text);
            while (num != rnd)
            {
                if (num > rnd) { max = num; num = (num + min) / 2; }
                if (num < rnd) { min = num; num = (num + max) / 2; }
                label5.Text = num.ToString();
                listBox1.Items.Add(label5.Text);
                counter ++ ;
                if ( num ==  rnd) { listBox1.Text = "great";button1.Enabled = false; }
                
          
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            rnd = r.Next(100, 999);
            label7.Text = rnd.ToString();

           
        }
    }
}
