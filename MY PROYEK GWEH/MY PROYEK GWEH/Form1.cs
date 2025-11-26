using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace MY_PROYEK_GWEH
{
    public partial class FormVendingMachine : Form
    {

        public FormVendingMachine()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // jika user menekan yes maka akan membuka form pembayaran
            if (MessageBox.Show("Apakah kamu ingin membeli ini?", "button1", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormPembayaran form2 = new FormPembayaran();
                form2.Show();

            }
            //memanggil harga dari label3 ke form pembayaran






        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah kamu ingin membeli ini?", "button2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormPembayaran form2 = new FormPembayaran();
                form2.Show();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah kamu ingin membeli ini?", "button3", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormPembayaran form2 = new FormPembayaran();
                form2.Show();
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah kamu ingin membeli ini?", "button4", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormPembayaran form2 = new FormPembayaran();
                form2.Show();
            }
            ;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah kamu ingin membeli ini?", "button5", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormPembayaran form2 = new FormPembayaran();
                form2.Show();
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah kamu ingin membeli ini?", "button6", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormPembayaran form2 = new FormPembayaran();
                form2.Show();
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah kamu ingin membeli ini?", "button7", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormPembayaran form2 = new FormPembayaran();
                form2.Show();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah kamu ingin membeli ini?", "button8", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                FormPembayaran form2 = new FormPembayaran();
                form2.Show();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah kamu ingin membeli ini?", "button8", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                FormPembayaran form2 = new FormPembayaran();
                form2.Show();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FormVendingMachine_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
