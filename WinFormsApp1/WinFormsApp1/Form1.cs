using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Control startButton;
        Control gretting;
        Control endButton;
        System.Windows.Forms.Timer gameTimer;
        Control snakeImg;

        public Form1()
        {
            InitializeComponent();

            this.startButton = this.Controls.Find("button1", true)[0];
            this.gretting = this.Controls.Find("label1", true)[0];
            this.endButton = this.Controls.Find("button2", true)[0];
            this.snakeImg = this.Controls.Find("pictureBox1", true)[0];

            this.gameTimer = new System.Windows.Forms.Timer();
            this.gameTimer.Interval = 1000/30; ;

            gameTimer.Tick += update;
        }

        public void update(object sender, EventArgs e)
        {
            snakeImg.Location = new Point(snakeImg.Location.X + 1, snakeImg.Location.Y);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            var m = new Form2();
            m.Show();

        }

        //start button
        private void button1_Click(object sender, EventArgs e)
        {
            this.startButton.Visible = false;
            this.gretting.Visible = false;

            this.endButton.Visible = true;

            this.gameTimer.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.startButton.Visible = true;
            this.gretting.Visible = true;

            this.endButton.Visible = false;
            this.gameTimer.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
