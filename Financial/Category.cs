using System;
namespace TrabalhoFinal.Financial
{
    public class Category
    {
       public Category(int categoryid, string categoryname , DateTime categorydate, string type){
        if (categoryname == null)
                throw new System.Exception("");

            CategoryId = categoryid;
            CategoryName = categoryname;
            CategoryDate = categorydate;
            Type = type;
       }
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public DateTime CategoryDate { get; set; }

        public string Type { get; set; }

    }
       
}