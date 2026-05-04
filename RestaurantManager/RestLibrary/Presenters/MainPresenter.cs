using RestaurantManager.Models;
using RestaurantManager.Services;
using RestaurantManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView view;
        private readonly DataService service;

        public List<Ingredient> Ingredients { get; private set; }

        public MainPresenter(IMainView view)
        {
            this.view = view;
            service = new DataService();
            Load();
        }

        public void Load()
        {
            Ingredients = service.LoadData();
            view.DisplayData(Ingredients);
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
            service.SaveData(Ingredients);
            view.DisplayData(Ingredients);
        }
    }
}
