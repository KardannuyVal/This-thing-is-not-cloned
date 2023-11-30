
namespace Тумаков_12
{
    internal class Book
    {
        internal string name {  get; set; }
        internal string author { get; set; }
        internal string publishing_house {  get; set; }
        public Book(string name, string author, string publishing_house)
        {
            this.name = name;
            this.author = author;
            this.publishing_house = publishing_house;
        }
    }
}
