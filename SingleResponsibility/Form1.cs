namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);

            ProductService productService = new ProductService();
            productService.CreateProduct(name, price);

            EmailService emailService = new EmailService();
            emailService.SendMailToVendor("info@bilmemne.com");

            //ProductService.CreateProduct(name, price);

            //EmailService.SendMailToVendor("info@bilmemne.com");
        }

        private void buttonBackcolour_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog.Color;
            }
        }

        /* 
         * Her nesnenin tek ve sadece bir sorumlulu�u olmal�d�r.
         * E�er bir nesnenin i�inde de�i�iklik yapmak (yeni fonksiyon eklemek veya fonksiyonun
         * i�eri�ini de�i�tirmek) i�in birden fazla gereksiniminiz varsa bu prensibi ihlal ediyorsunuz demektir.
         */
    }
}
