using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseTestApp
{
    public partial class DetailForm : Form
    {
        /// <summary>
        /// Public Customer property
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Constructor for the detailForm.
        /// </summary>
        /// <param name="customer">Default value null. When a customer is provided the textboxes are disabled</param>
        public DetailForm(Customer? customer = null)
        {
            InitializeComponent();
                if (customer != null)
                {
                    this.Customer = customer;
                    this.firstNameTextBox.Enabled = false;
                    this.lastNameTextBox.Enabled = false;
                    this.imgUrlTextBox.Enabled = false;
                    this.addButton.Visible = false;
                }
                else 
                { 
                    this.Customer = new Customer();
                    this.firstNameTextBox.Enabled = true;
                    this.lastNameTextBox.Enabled = true;
                    this.imgUrlTextBox.Enabled = true;
                    this.addButton.Visible = true;
                }
        }

        /// <summary>
        /// Set the values of the textboxes to match customer values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailForm_Load(object sender, EventArgs e)
        {
            idTextBox.Text = Customer.Id.ToString();
            firstNameTextBox.Text = Customer.FirstName;
            lastNameTextBox.Text = Customer.LastName;
            imgUrlTextBox.Text = Customer.imgUrl;
        }

        /// <summary>
        /// When first and last name are provided, stores the values in the customer property and close the screen with
        /// dialogresult OK. Otherwise dialogresult Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text.Length > 0 && lastNameTextBox.Text.Length > 0 && imgUrlTextBox.Text.Length > 0)
            {
                
                Customer.FirstName = firstNameTextBox.Text;
                Customer.LastName = lastNameTextBox.Text;
                Customer.imgUrl = imgUrlTextBox.Text;
                addButton.DialogResult = DialogResult.OK;
            }
            else
            {
                addButton.DialogResult = DialogResult.Cancel;
            }
        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
