
class Program
{
    public class Books
    {
        public string title { set; get; }
        public string author { set; get; }
        public string publication_year { set; get; }
        public Books(string title, string author, string publication_year)
        {
            this.title = title;
            this.author = author;
            this.publication_year = publication_year;
        }   
        public void Display_objects()
        {
            Console.WriteLine ($"Title is: {title}, author is: {author}, Publication year is: {publication_year}");
        }
    }

    static void Main(string[] args)
    {
        
        List<Books> books2 = new List<Books>();
        Books Animals = new Books("Zoo","Mohamed","2002");
        Books Job = new Books("Office", "Ahmed", "2005");
        books2.Add(Animals);
        books2.Add(Job);
        string search_item ;
        Console.WriteLine("Please enter the title or author you want to search for");
        search_item = Convert.ToString(Console.ReadLine());
        for (int i = 0; i < books2.Count; i++)
        {

            if (books2[i].title == search_item)
            {
                books2[i].Display_objects();
                break;
            }
            else if (books2[i].author == search_item) { 
                books2[i].Display_objects();
                break;
            }

            if (i ==( books2.Count - 1))
            {
                Console.WriteLine("The item not found");
            }

        }
        Console.WriteLine("Enter the title of the book you want to remove");
        string removed_item_title = Convert.ToString(Console.ReadLine());
        for (int i = 0; i < books2.Count; i++)
        {
            if (books2[i].title == removed_item_title)
            {
                books2.RemoveAt(i);
                Console.WriteLine("Book is removed");
                break;
            }
        }

    }

}