using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;
using System.Net;
using System.Windows.Forms;

namespace DatabaseTestApp
{
    public partial class OverviewForm : Form
    {
        private DataLayer dataLayer;
        public OverviewForm()
        {
            InitializeComponent();
            customerDataGridView.Left -= 500;
            //dataLayer = new DataLayer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestDB;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            dataLayer = new DataLayer("server = 192.168.0.172; port = 3306; user = root; password = admin; database = customer");
        }

        /// <summary>
        /// Loads all customer data when users clicks the loadAllCustomersButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadAllCustomersButton_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        /// <summary>
        /// Save the customer to the database when edit of a record is ended
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerDataGridView_EndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var customer = customerDataGridView.CurrentRow.DataBoundItem as Customer;
            if (customer != null)
            {
                dataLayer.SaveCustomer(customer);
            }
        }

        /// <summary>
        /// Open a new dialog that allows to add customer details. Save and reload upon successful add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            // Open the details screen without providing customer data
            DetailForm detailForm = new DetailForm();
            var result = detailForm.ShowDialog();

            // When the user clicks the add button in the details screen, store the new customer in the database
            if (result == DialogResult.OK)
            {
                dataLayer.AddCustomer(detailForm.Customer);
                ReloadData();
            }
        }

        /// <summary>
        /// Delete the currently selected record from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            var customer = customerDataGridView.CurrentRow.DataBoundItem as Customer;
            if (customer != null )
            {
                dataLayer.DeleteCustomer(customer);
                ReloadData();
            }
        }

        /// <summary>
        /// Function to reload customer data from the database and enable buttons
        /// </summary>
        private void ReloadData()
        {
            customerDataGridView.DataSource = dataLayer.LoadAllCustomers();
            this.addButton.Enabled = true;
            this.viewButton.Enabled = true;
            this.deleteButton.Enabled = true;
            PokemonPicture.BackColor= Color.Black;
        }

        /// <summary>
        /// View the currently selected customer in a detail window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewButton_Click(object sender, EventArgs e)
        {
            // Get the currently selected customer row from the datagrid
            var customer = customerDataGridView.CurrentRow.DataBoundItem as Customer;
            
            // If the selected item is in fact a customer
            // Create the details screen providing the customer data we want to view
            if (customer != null)
            {
                PokemonTitle.Text = customer.FirstName;
                PokemonDesc.Text = customer.LastName;
                string imageUrl = customer.imgUrl;
                WebClient client = new WebClient();
                byte[] imageBytes = client.DownloadData(imageUrl);
                using (MemoryStream stream = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(stream);
                    PokemonPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    PokemonPicture.Image = image;
                }

                // this is the search function

                customerId = int.Parse(idLabel.Text);             
                foreach (DataGridViewRow row in customerDataGridView.Rows)
                { 
                    if (customer != null && customer.Id == customerId)
                    {
                        customerDataGridView.CurrentCell = row.Cells[0];
                        customer.Id = customerId;
                        break;
                    }
                }
            }
        }

        private void OverviewForm_Load(object sender, EventArgs e)
        {

        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int customerId = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            customerId += 1;

            foreach (DataGridViewRow row in customerDataGridView.Rows)
            {
                Customer customer = row.DataBoundItem as Customer;
                if (customer != null && customer.Id == customerId)
                {
                    customerDataGridView.CurrentCell = row.Cells[0];
                    break;
                }
                idLabel.Text = customerId.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            customerId -= 1; // Replace 123 with the actual customer ID you want to select

            foreach (DataGridViewRow row in customerDataGridView.Rows)
            {
                Customer customer = row.DataBoundItem as Customer;
                if (customer != null && customer.Id == customerId)
                {
                    customerDataGridView.CurrentCell = row.Cells[0];
                    break;
                }
                idLabel.Text = customerId.ToString();
            }
        }

        private void PokemonTitle_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void customerDataGridView_EndEdit(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in customerDataGridView.Rows)
            {
                var customer = row.DataBoundItem as Customer;
                if (customer != null)
                {
                    dataLayer.SaveCustomer(customer);
                }
            }
        }
    }
}