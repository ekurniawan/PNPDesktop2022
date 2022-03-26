namespace POSApplication.FrontEnd
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
            btnHitungLuasSegitiga.Click += BtnHitungLuasSegitiga_Click;
        }

        private void BtnHitungLuasSegitiga_Click(object? sender, EventArgs e)
        {
            double alas = Convert.ToDouble(txtAlas.Text);
            double tinggi = Convert.ToDouble(txtTinggi.Text);
            double luasSegitiga = 0.5 * alas * tinggi;
            txtLuasSegitiga.Text = luasSegitiga.ToString();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hello World !!";
            MessageBox.Show("Hello .NET Core Desktop");
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            //konversi dari tipe text ke tipe double
            double dblBil1 = Convert.ToDouble(txtBil1.Text);
            double dblBil2 = Convert.ToDouble(txtBil2.Text);
            double hasil = 0.0;

            if(rdTambah.Checked)
            {
                hasil = dblBil1 + dblBil2;
            }
            else if(rdKurang.Checked)
            {
                hasil = dblBil1 - dblBil2;
            }
            else if(rdKali.Checked)
            {
                hasil = dblBil1 * dblBil2;
            }
            else
            {
                hasil = dblBil1 / dblBil2;
            }


            txtHasil.Text = hasil.ToString();
        }
    }
}