using csfd.BussinessLayer.Services;

namespace Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetAllCustomers_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Name");

            var service = new CustomerService();

            var customers = service.GetAllCustomers();

            foreach (var customer in customers)
            {
                listView1.Items.Add(new ListViewItem(new string[] { customer.Id.ToString(), customer.Firstname }));
            }

            listView1.Visible = true;
        }

        private void btnGetPayments_Click(object sender, EventArgs e)
        {
            var paymentService = new PaymentService();

            var customerId = int.Parse(textBox1.Text);

            var payments = paymentService.GetPaymentsForCustomer(customerId);

            listView2.View = View.Details;
            listView2.Columns.Add("ID");
            listView2.Columns.Add("Amount");

            foreach (var payment in payments.Payments)
            {
                listView2.Items.Add(new ListViewItem(new string[] { payment.Id.ToString(), payment.Amount.ToString() }));
            }

            label1.Text = payments.PayAmount.ToString();
        }
    }
}