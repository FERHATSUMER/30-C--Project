namespace FormsChangeBackground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMavi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btnSar�_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void btnK�rm�z�_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Red;
        }

        private void btnYesil_Click(object sender, EventArgs e)
        {
            this.BackColor=btnYesil.BackColor;
        }
    }
}