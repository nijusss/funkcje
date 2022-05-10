namespace funkcje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




















        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(ab.Text);
            float b = Convert.ToSingle(bb.Text);
            float c = Convert.ToSingle(cc.Text);
            float delta = (b * b) - (4 * a * c);

            wd.Text = delta.ToString();
            float minusb = b * -1;

            float x1 = (float)(minusb - Math.Sqrt(delta)) / (2 * a);
            float x2 = (float)(minusb + Math.Sqrt(delta)) / (2 * b);

            x1b.Text = x1.ToString();
            x2b.Text = x2.ToString();

            if (delta > 0)
            {
                addText.Text = "Delta dodatnia";
            }
            else if (delta < 0)
            {
                addText.Text = "Delta ujemna";
            }
            else if (delta == 0)
            {
                addText.Text = "Delta równa zero";
            }
        }
    }
}