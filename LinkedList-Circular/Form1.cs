using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList_Circular
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        LinkedListCircular LLC = new LinkedListCircular();

        ButtonClass[] bt;
        Node[] newNode;
        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = textBox1.Text.Split(';');
            bt = new ButtonClass[arr.Length];
            newNode = new Node[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                LLC.InsertNode(arr[i]);
                bt[i] = new ButtonClass(arr[i]);
                this.Controls.Add(bt[i]);
                bt[i].Location = new Point(50 + i * 50, 200);
                bt[i].Name = "button" + i;
                bt[i].Size = new Size(50, 30);
                bt[i].TabIndex = i;
                bt[i].Text = arr[i];
                bt[i].UseVisualStyleBackColor = true;
                //bt[i].Click += new System.EventHandler(this.button1_Click);
                //System.Drawing.Pen myPen;
                //myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
                //System.Drawing.Graphics formGraphics = this.CreateGraphics();
                //formGraphics.DrawLine(myPen, 0, 0, 200, 200);
                //myPen.Dispose();
                //formGraphics.Dispose();
            }
        }
    }
}
