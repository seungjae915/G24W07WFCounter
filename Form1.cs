namespace G24W07WFCounter
{
    public partial class Form1 : Form
    {
        private int Count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OnAdd(object sender, EventArgs e)
        {
            //labelCount.Text = (++Count).ToString();
            //labelCount.Text = "" + ++Count;
            labelCount.Text = $"{++Count}";
        }

        private void OnSub(object sender, EventArgs e)
        {
            if(Count > 0) {
                labelCount.Text = $"{--Count}";
            }
        }
    }
}
