using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Class___HW7___KDever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //creates a global car object
        Car myCar = new Car();

        private void accelerateButton_Click(object sender, EventArgs e)
        {
            if (!(makeTextBox.Text == ""))
            {
                if(!(yearTextBox.Text == ""))
                {
                    //calls car class accelerate method and shows result
                    myCar.Accelerate();
                    currentSpeedLabel.Text = myCar.Speed.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid car year");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid car make");
            }
        }

        private void brakeButton_Click(object sender, EventArgs e)
        {
            if (myCar.Speed >= 5)
            {
                //calls Car class brake method and shows result
                myCar.Brake();
                currentSpeedLabel.Text = myCar.Speed.ToString();
            }
            else
            {
                MessageBox.Show("Your car is not moving, you can't go any slower.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newCarButton_Click(object sender, EventArgs e)
        {
            //sets object's make
            myCar.Make = makeTextBox.Text;

            //sets object's year
            int year;
            if (int.TryParse(yearTextBox.Text, out year))
            {
                myCar.Year = year;
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for year");
            }
            //resets object's speed to zero
            myCar.Speed = 0.0;

            //shows information on current object
            currentMakeLabel.Text = myCar.Make.ToString();
            currentYearLabel.Text = myCar.Year.ToString();
            currentSpeedLabel.Text = myCar.Speed.ToString();
        }
    }
}
