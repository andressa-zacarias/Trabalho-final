using TrabalhoFinal.Financial;
using TrabalhoFinal.Database;
using System.Collections.Generic;
using System;

namespace TrabalhoFinal
{
    public class CategoryProcessing
    {
        private readonly CategoryDatabase categoryDatabase;

        public CategoryProcessing(CategoryDatabase categoryDatabase)
        {
            this.categoryDatabase = categoryDatabase;
        }


        public Category RegisterCategory(int catid, string catname, DateTime catdate, string cattype)
        {
            var category = new Category(0, catname, catdate, cattype);

            int id = categoryDatabase.RegisterCategory(category);
            category.CategoryId = id;

            return category;
        }

        public List<Category> Listar(string categoryname = null)
        {
            // Recuperar o id ao cadastro no banco de dados
            // Setar o id na classe
            // pessoa.id = resultadoDoBancoDeDados;

            return new List<Category>();
        }
    }
}