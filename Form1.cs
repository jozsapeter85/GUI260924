namespace GUI260924
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblbrown.Click += lblcolorinc_click;
            lblsalmon.Click += lblcolorinc_click;
            lbllyellow.Click += lblcolorinc_click;
            lblolivegreen.Click += lblcolorinc_click;

            btnexit.Click += Btnexit_Click;
            btnreset.Click += Btnreset_Click;
        }

        private void Btnreset_Click(object? sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void Btnexit_Click(object? sender, EventArgs e)
        {
           Application.Exit();
        }

        private void lblcolorinc_click(object? sender, EventArgs e)
        {
            this.BackColor = (sender as Label).BackColor;
        }
    }
}
