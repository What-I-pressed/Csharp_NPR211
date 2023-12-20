namespace WinFormsApp1
{
    public partial class TxtForm : Form
    {
        public TxtForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I was pressed");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}