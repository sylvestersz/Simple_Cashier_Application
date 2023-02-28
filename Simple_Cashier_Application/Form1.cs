namespace Simple_Cashier_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Item.Items.Add("Makaroni Pedas");
            Item.Items.Add("Es Cincau");
            Item.Items.Add("Mie Goreng");
            Item.Items.Add("Mie Rebus");
            Item.Items.Add("Telur");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Item.Text == "Makaroni Pedas")
            {
                Harga.Text = "2000";
            }
            else if (Item.Text == "Es Cincau")
            {
                Harga.Text = "3000";
            }
            else if (Item.Text == "Mie Goreng")
            {
                Harga.Text = "6000";
            }
            else if (Item.Text == "Mie Rebus")
            {
                Harga.Text = "5000";
            }
            else if (Item.Text == "Telur")
            {
                Harga.Text = "1500";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(itemList.Text) && string.IsNullOrWhiteSpace(Harga.Text))
            {
                MessageBox.Show("Pilih Item Terlebih dahulu");
            }
            else

                itemList.Items.Add(Item.Text + " " + Harga.Text);
            itemList.Text = "";
            Item.Text = "";
            Harga.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            itemList.Items.Clear();
            itemList.Items.Add("Pesanan" + " " + " Harga ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kamu Yakin ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Sampai Jumpa");
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}