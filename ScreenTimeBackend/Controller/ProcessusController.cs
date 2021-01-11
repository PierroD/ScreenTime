using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenTimeBackend.Model;

namespace ScreenTimeBackend.Controller
{
    public class ProcessusController
    {
        public static async void AddProcessus(string CategoryName, string ProcessName)
        {
            await Task.Run(() =>
            {
                var category = CategoryController.GetCategoryAsync(CategoryName).Result;
                Processus newProcessus = new Processus();
                newProcessus.Name = ProcessName;
                newProcessus.AddedAt = DateTime.Now;
                if (category.Applications == null)
                    category.Applications = new List<Processus>();
                category.Applications.Add(newProcessus);
                CategoryController.SaveCategoriesAsync();
            });
        }

        public static async void DeleteProcessusAsync(string CategoryName, string ProcessName)
        {
            await Task.Run(() =>
            {
                var category = CategoryController.GetCategoryAsync(CategoryName).Result;
                foreach (Processus processus in category.Applications.ToList())
                    if (processus.Name.Equals(ProcessName))
                        category.Applications.Remove(processus);
                CategoryController.SaveCategoriesAsync();
            });
        }

    }
}
