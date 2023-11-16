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

        private void btnSarý_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void btnKýrmýzý_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Red;
        }

        private void btnYesil_Click(object sender, EventArgs e)
        {
            this.BackColor=btnYesil.BackColor;
        }
    }
}