using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestaurantManager.Models;
using RestaurantManager.Presenters;
using RestaurantManager.Views;

namespace RestaurantManager
{
    public partial class MainForm : Form, IMainView
    {
        private MainPresenter presenter;

        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }

        public void DisplayData(List<Ingredient> data)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            presenter.Load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                presenter.AddIngredient(form.NewIngredient);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}