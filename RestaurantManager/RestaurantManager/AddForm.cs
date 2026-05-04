using System;
using System.Windows.Forms;
using RestaurantManager.Models;

namespace RestaurantManager
{
    public partial class AddForm : Form
    {
        public Ingredient NewIngredient { get; private set; }

        public AddForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewIngredient = new Ingredient
            {
                Name = txtName.Text,
                Quantity = int.Parse(txtQuantity.Text)
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}