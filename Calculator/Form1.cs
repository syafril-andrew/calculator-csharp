using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        private void button_click(object sender, EventArgs e)
        {
            if (screen.Text == "0" || op_pressed)
            {
                screen.Clear();
            }
            Button button = (Button)sender;
            screen.Text = screen.Text + button.Text;
            op_pressed = false;
        }

        Double val = 0;
        String text = "";
        bool op_pressed = false;
        private void op_pres(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            text = button.Text;
            val = Double.Parse(screen.Text);
            op_pressed = true;
        }

        private void op_res(object sender, EventArgs e)
        {
            switch (text)
            {
                case ("+"):
                    screen.Text = (val + Double.Parse(screen.Text)).ToString();
                    break;
                case ("-"):
                    screen.Text = (val - Double.Parse(screen.Text)).ToString();
                    break;
                case ("*"):
                    screen.Text = (val * Double.Parse(screen.Text)).ToString();
                    break;
                case ("/"):
                    screen.Text = (val / Double.Parse(screen.Text)).ToString();
                    break;
                default:
                    break;
            }
            op_pressed = false;
        }

        private void ce_button(object sender, EventArgs e)
        {
            screen.Text = "0";
        }
        private void c_button(object sender, EventArgs e)
        {
            screen.Text = "0";
            val = 0;
        }

        private void screen_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
