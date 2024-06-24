
//using external tools we will be refrencing 

using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //refrencing elements (buttons, labeles, images, etc)
        Control startButton;
        Control gretting;
        Control endButton;
        Control snakeImg;

        //declarring a timer for the main game loop
        System.Windows.Forms.Timer gameTimer;
        
        //constrtor: the entry point of the class
        public Form1()
        {
            //this is alwasy the first thing that gets ran
            InitializeComponent();

            //defining the elements we declared earlier
            this.startButton = this.Controls.Find("button1", true)[0];
            this.gretting = this.Controls.Find("label1", true)[0];
            this.endButton = this.Controls.Find("button2", true)[0];
            this.snakeImg = this.Controls.Find("pictureBox1", true)[0];

            //defining the timer we declared 
            this.gameTimer = new System.Windows.Forms.Timer();
            this.gameTimer.Interval = 1000/30; //frames per second 

            //attaching the update method to the timer to get called
            gameTimer.Tick += update;
        }

        public void update(object sender, EventArgs e)
        {
            //a point is just like the vector class we made in project one 
            Point newPoint = new Point(snakeImg.Location.X + 1, snakeImg.Location.Y);
            snakeImg.Location = newPoint; //repoisition the image to the new point verctor 

        }

        //gets called when the label is clicked
        private void label1_Click(object sender, EventArgs e)
        {
            //var tells the compiler to automatically assign a type
            var m = new Form2();
            //create a new pop up 
            m.Show(); //show the pop up

        }

        //start button method 
        private void button1_Click(object sender, EventArgs e)
        {
            //toggels the visibality of other elements 
            this.startButton.Visible = false;
            this.gretting.Visible = false;

            this.endButton.Visible = true;

            this.gameTimer.Start();

        }

        //close button method 
        private void button2_Click(object sender, EventArgs e)
        {
            //undoes everything the start button does 
            this.startButton.Visible = true;
            this.gretting.Visible = true;

            this.endButton.Visible = false;
            this.gameTimer.Stop();
        }

        //empty method if the picture is clicked 
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this gets called after the "InitializeComponent" gets called in the construcor, its good practice 
            //to use this for refrencing elements on the constructor once everything is loaded 
            
            //this could be used if you decide to make a load screen, hide and unhide stuff
        }
    }
}
