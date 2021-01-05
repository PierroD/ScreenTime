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
        public static void AddProcessus(string CategoryName, string ProcessName)
        {
            var category = CategoryController.GetCategory(CategoryName);
            Processus newProcessus = new Processus();
            newProcessus.Name = ProcessName;
            newProcessus.AddedAt = DateTime.Now;
            if (category.Applications == null)
                category.Applications = new List<Processus>();
            category.Applications.Add(newProcessus);
            CategoryController.SaveCategories();
        }

        public static void DeleteProcessus(string CategoryName, string ProcessName)
        {
            var category = CategoryController.GetCategory(CategoryName);
            foreach (Processus processus in category.Applications.ToList())
                if (processus.Name.Equals(ProcessName))
                    category.Applications.Remove(processus);
            CategoryController.SaveCategories();
        }

    }
}
