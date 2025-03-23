using System.Diagnostics;

namespace Multiwindowsforms
{
    public partial class Form1 : Form
        private NewCustomerform _customerForm;
        private List,Customer> _customerList;
    {
        public Form1()
        {
            InitializeComponent();
            _customerForm = new NewCustomerform();
        _customerList = new List<Customer>();
        }

        private void BtnNew_Click(object sender, EventArgs e) 
        {
            
        NewCustomerform customerform = new NewCustomerform();
            
            _customerform.ShowDialog();
        }
        public void AddCustomer(Customer customer)
        {
        _customerList.Add(customer);   
        
        }
    }
