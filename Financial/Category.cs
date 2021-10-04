namespace TrabalhoFinal
{
    public class Category
    {
        internal int CategoryId;

        public Category(int categoryid, string categoryname, string categorydate)
        {
            CategoryId = categoryid;
            CategoryName = categoryname;
            CategoryDate = categorydate;

        }
        public int IdCategory { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDate { get; set; }
    }    
}
