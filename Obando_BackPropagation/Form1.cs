using Backprop;

namespace Obando_BackPropagation
{
    public partial class Form1 : Form
    {
        NeuralNet nnOr, nnAnd;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nnOr = new NeuralNet(2, 100, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                nnOr.setInputs(0, 0);
                nnOr.setInputs(1, 0);
                nnOr.setDesiredOutput(0, 0);
                nnOr.learn();

                nnOr.setInputs(0, 0);
                nnOr.setInputs(1, 1);
                nnOr.setDesiredOutput(0, 1);
                nnOr.learn();

                nnOr.setInputs(0, 1);
                nnOr.setInputs(1, 0);
                nnOr.setDesiredOutput(0, 1);
                nnOr.learn();

                nnOr.setInputs(0, 1);
                nnOr.setInputs(1, 1);
                nnOr.setDesiredOutput(0, 1);
                nnOr.learn();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nnOr.setInputs(0, Convert.ToDouble(textBox3.Text));
            nnOr.setInputs(1, Convert.ToDouble(textBox4.Text));
            nnOr.run();

            double output = nnOr.getOuputData(0);
            textBox5.Text = Math.Round(output).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nnAnd = new NeuralNet(4, 5, 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double[,] data = new double[16, 5]
            {
                {0, 0, 0, 0, 0 },
                {0, 0, 0, 1, 0 },
                {0, 0, 1, 0, 0 },
                {0, 0, 1, 1, 0 },
                {0, 1, 0, 0, 0 },
                {0, 1, 1, 1, 0 },
                {0, 1, 1, 0, 0 },
                {0, 1, 0, 1, 0 },
                {1, 0, 1, 0, 0 },
                {1, 0, 1, 1, 0 },
                {1, 0, 0, 0, 0 },
                {1, 0, 1, 1, 0 },
                {1, 1, 1, 0, 0 },
                {1, 1, 0, 1, 0 },
                {1, 1, 1, 0, 0 },
                {1, 1, 1, 1, 1 }
            };

            String result = "";

            for (int j = 0; j < 500; j++)
            {
                result += $"Epoch {j + 1}:\r\n";
                for (int i = 0; i < 16; i++)
                {
                    nnAnd.setInputs(0, data[i, 0]);
                    nnAnd.setInputs(1, data[i, 1]);
                    nnAnd.setInputs(2, data[i, 2]);
                    nnAnd.setInputs(3, data[i, 3]);
                    nnAnd.setDesiredOutput(0, data[i, 4]);
                    nnAnd.learn();
                }
                for (int i = 0; i < 16; i++)
                {
                    nnAnd.setInputs(0, data[i, 0]);
                    nnAnd.setInputs(1, data[i, 1]);
                    nnAnd.setInputs(2, data[i, 2]);
                    nnAnd.setInputs(3, data[i, 3]);
                    nnAnd.run();
                    double output = nnAnd.getOuputData(0);
                    result += $" [ {data[i, 0]}, {data[i, 1]}, {data[i, 2]}, {data[i, 3]} ] => {output.ToString("#.####")}\r\n";
                }
                result += "\r\n";
            }

            textBox16.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nnAnd.setInputs(0, Convert.ToDouble(textBox12.Text));
            nnAnd.setInputs(1, Convert.ToDouble(textBox11.Text));
            nnAnd.setInputs(2, Convert.ToDouble(textBox15.Text));
            nnAnd.setInputs(3, Convert.ToDouble(textBox14.Text));
            nnAnd.run();

            double output = nnAnd.getOuputData(0);
            textBox10.Text = Math.Round(output).ToString();
        }
    }
}
