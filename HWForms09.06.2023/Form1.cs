namespace HWForms09._06._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle topRect = new Rectangle(0, 0, ClientSize.Width, (int)(ClientSize.Height * 0.7));
            g.FillRectangle(Brushes.LightBlue, topRect);

            int circleSize = 200;
            int circleX = (ClientSize.Width - circleSize) / 10;
            int circleY = (ClientSize.Height - circleSize) / 2;
            Rectangle circleRect = new Rectangle(circleX, circleY, circleSize, circleSize);
            g.FillEllipse(Brushes.Yellow, circleRect);

            Rectangle bottomRect = new Rectangle(0, (int)(ClientSize.Height * 0.7), ClientSize.Width, (int)(ClientSize.Height * 0.3));
            g.FillRectangle(Brushes.Blue, bottomRect);

            Rectangle rectTop = new Rectangle(530, 125, 50, 200);
            g.FillRectangle(Brushes.RosyBrown, rectTop);

            Rectangle rect = new Rectangle(425, 275, 275, 75);
            g.FillRectangle(Brushes.Brown, rect);

            

            Rectangle rectParus = new Rectangle(450, 75, 250, 125);
            g.FillRectangle(Brushes.White, rectParus);
        }
    }
}