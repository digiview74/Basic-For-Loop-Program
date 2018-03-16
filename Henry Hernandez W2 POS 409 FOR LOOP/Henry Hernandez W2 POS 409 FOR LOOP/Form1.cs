using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// This program is based on a FOR LOOP that displays every third number beginning with 10 and continues to 100
namespace Henry_Hernandez_W2_POS_409_FOR_LOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // The button initiates the FOR LOOP and displays the output in the listbox
        private void button1_Click(object sender, EventArgs e)
        {
            int myValue = 10;
            int maxNum = 100;
            if (myValue >= maxNum)
                myValue -= maxNum;
    //FOR LOOP - displays every 3rd num beginning with ten and ending at 100
            for (; myValue <= maxNum; myValue +=3)
            {
              //Displays FOR LOOP output
                listBox1.Items.Add(myValue.ToString());
            }
            
        }
        //Clears listbox output 
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
