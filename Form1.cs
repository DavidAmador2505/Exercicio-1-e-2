namespace Exercicio_1_e_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                textBox1.Text = "Bem vindo ao C#!";
            }
            else if (radioButton2.Checked)
            {
                textBox1.Text = "É necessário aceitar!";
            }
            else
            {
                textBox1.Text = "É obrigatorio selecionar um deles!";
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}