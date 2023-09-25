namespace _3SayininEnBuyugu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double no1, no2, no3;
            no1 = Convert.ToDouble(textBox1.Text);
            no2 = Convert.ToDouble(textBox2.Text);
            no3 = Convert.ToDouble(textBox3.Text);

            if (no1 >= no2 && no1 >= no3)
            {
                label4.Text = label1.Text;
            }
            else if (no2 > no1 && no2 > no3)
            {
                label4.Text = label2.Text;
            }
            else
            {
                label4.Text = label3.Text;
            }
        }
    }
}