
namespace PriceComputingScale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FitImage(btApple);
            FitImage(btBanana);
            FitImage(btPear);
            FitImage(btOrange);
        }

        private void FitImage(Button bt)
        {
            Image imResized = new Bitmap(bt.Image, bt.Width - 5, bt.Height - 5);
            bt.Image = imResized;
        }

        private void bt_Click(object sender, EventArgs e)
        {
            
            if(!double.TryParse(tbWeight.Text, out double weight))
            {
                MessageBox.Show("Please enter a valid weight", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            double price = double.Parse(((Button)sender).Text);
            lbPrice.Text = (weight * price).ToString();
        }
    }
}
