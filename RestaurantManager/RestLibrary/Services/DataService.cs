using System.IO;
using RestaurantManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Services
{
    public class DataService
    {
        private string filePath = "data.csv";

        public List<Ingredient> LoadData()
        {
            var list = new List<Ingredient>();

            if (!File.Exists(filePath))
                return list;

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                list.Add(new Ingredient
                {
                    Name = parts[0],
                    Quantity = int.Parse(parts[1])
                });
            }

            return list;
        }

        public void SaveData(List<Ingredient> ingredients)
        {
            var lines = new List<string>();

            foreach (var item in ingredients)
            {
                lines.Add($"{item.Name},{item.Quantity}");
            }

            File.WriteAllLines(filePath, lines);
        }
    }
}
