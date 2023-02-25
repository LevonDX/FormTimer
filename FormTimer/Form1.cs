using System.Media;
using Timer = System.Windows.Forms.Timer;

namespace FormTimer
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        int deltaX = 50;

        public Form1()
        {
            InitializeComponent();

            timer.Interval = 50;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (this.button1.Location.X + this.button1.Width >= this.Width)
            {
                SystemSounds.Question.Play();
                deltaX = -deltaX;
            }

            this.button1.Location = new Point(this.button1.Location.X + deltaX, this.button1.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                timer.Stop();
            else
                timer.Start();
        }
    }
}