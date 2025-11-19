using Backprop;
using System.Linq.Expressions;

namespace BPNNActivity
{
    public partial class Form1 : Form
    {
        NeuralNet nn;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 1, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (int, int, int, int, int)[] value =

            [
                (0, 0, 0, 0, 0),
                (0, 0, 0, 1, 0),
                (0, 0, 1, 0, 0),
                (0, 0, 1, 1, 0),
                (0, 1, 0, 0, 0),
                (0, 1, 0, 1, 0),
                (0, 1, 1, 0, 0),
                (0, 1, 1, 1, 0),
                (1, 0, 0, 0, 0),
                (1, 0, 0, 1, 0),
                (1, 0, 1, 0, 0),
                (1, 0, 1, 1, 0),
                (1, 1, 0, 0, 0),
                (1, 1, 0, 1, 0),
                (1, 1, 1, 0, 0),
                (1, 1, 1, 1, 1)
            ];

            for (int i = 0; i < 100; i++)
            {
                foreach (var (a, b, c, d, f) in value)
                {
                    nn.setInputs(0, a);
                    nn.setInputs(1, b);
                    nn.setInputs(2, c);
                    nn.setInputs(3, d);
                    nn.setDesiredOutput(0, f);
                    nn.learn();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox3.Text));
            nn.setInputs(3, Convert.ToDouble(textBox4.Text));
            nn.run();
            textBox5.Text = "" + nn.getOuputData(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
