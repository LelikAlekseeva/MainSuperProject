using RestaurantManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Views
{
    public interface IMainView
    {
        void DisplayData(List<Ingredient> data);
    }
}
