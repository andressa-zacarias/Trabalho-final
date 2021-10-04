using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhoFinal.Financial;

namespace TrabalhoFinal.Database
{
    public class CategoryDatabase
    {
        private int lastId = 0;
        private List<Category> dataBase = new List<Category>();
        
        public int RegisterCategory(Category category)
        {
            var newId = ++lastId;
            category.CategoryId = newId;
            dataBase.Add(category);
            return newId;

        }
        public Category SearchByCategoryId(int id)
        {
            foreach (var category in dataBase)
            {
                if (category.CategoryId == id)
                return category;
            }
            return null;
        }

        public List<Category> ListCategory()
        {
            return dataBase.ToList();
            
        }
        public bool UpdateCategory(Category category)
        {
            for (int i = 0; i < dataBase.Count; i++)
            {
                if (dataBase[i].CategoryId == category.CategoryId)
                {
                    dataBase[i] = category;
                    return true;
                }
            }
            return false;
        }
        public bool DeleteCategory(Category category)
        {
            for (int i = 0; i < dataBase.Count; i++)
            {
                if (dataBase[i].CategoryId == category.CategoryId)
                {
                    dataBase.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }