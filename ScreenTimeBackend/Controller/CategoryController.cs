﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ScreenTimeBackend.Model;

namespace ScreenTimeBackend.Controller
{
    public class CategoryController
    {
        static List<Category> categories;
        static string categoryDirectoryPath = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) }\\Categories";
        static string categoryImagesPath = $"{categoryDirectoryPath}\\Images";
        public static async Task<bool> LoadCategoriesAsync()
        {
            return await Task.Run(async () =>
            {
                categories = new List<Category>();
                if (Directory.Exists(categoryDirectoryPath))
                    foreach (string categoryFile in Directory.GetFiles(categoryDirectoryPath))
                        categories.Add(JsonConvert.DeserializeObject<Category>(File.ReadAllText(categoryFile)));
                else
                {
                    Directory.CreateDirectory(categoryDirectoryPath);
                    await LoadCategoriesAsync();
                }
                return true;
            });
        }

        public static async void CreateCategoryAsync(string name, string description, string imagePath)
        {
            await Task.Run(() =>
            {
                Category newCategory = new Category();
                newCategory.Name = name;
                newCategory.Description = description;
                if (!Directory.Exists(categoryImagesPath))
                    Directory.CreateDirectory(categoryImagesPath);
                string newImagePath = $"{categoryImagesPath}\\{DateTime.Now.ToFileTime()}{Path.GetExtension(imagePath)}";
                File.Copy(imagePath, newImagePath, true);
                newCategory.Image = newImagePath;
                categories.Add(newCategory);
                SaveCategoriesAsync();
            });

        }

        public static void SaveCategoriesAsync()
        {

            foreach (Category category in categories)
            {
                string filePath = $"{categoryDirectoryPath}\\{category.Name}.json";
                if (File.Exists(filePath))
                    File.Delete(filePath);
                using (JsonWriter writer = new JsonTextWriter(new StreamWriter(filePath)))
                    new JsonSerializer().Serialize(writer, category);
            }

        }

        public static void DeleteCategory(string Name)
        {
            foreach (Category category in categories)
                if (category.Name.Equals(Name))
                    categories.Remove(category);
        }

        public static Task<List<Category>> GetCategoriesAsync()
        {
            return Task.Run(() => GetCategories());
        }
        public static List<Category> GetCategories()
        {
            return categories;
        }

        public static Task<Category> GetCategoryAsync(string Name)
        {
            return Task.Run(() => GetCategory(Name));
        }

        private static Category GetCategory(string Name)
        {
            foreach (Category category in categories)
                if (category.Name.Equals(Name))
                    return category;
            return null;
        }

        public static async void StepOpenTimeCategoriesAsync()
        {
            await Task.Run(() =>
            {
                foreach (Category category in categories)
                    if (category.Applications != null)
                        foreach (Processus processus in category.Applications)
                            if (processus.OpenTimes != null)
                                OpenTimeController.stepOpenTimeAsync(processus);

                SaveCategoriesAsync();
            });
        }

    }
}
