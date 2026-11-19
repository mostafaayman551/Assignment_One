namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "test book";
            book.Pages = 400;

            #region Question 1
            Object obj = book;
            Console.WriteLine(obj);
            #endregion

            #region Question 2
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            #endregion

            #region Question 3
            // int pages = "464"; // it's a compile-time error as int expects an integer value.
            #endregion

            #region Question 4
            try
            {
                int result = 10 / 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion

            #region Question 5
            int pages = 300;
            double totalPages = pages;
            Console.WriteLine(totalPages);
            #endregion

            #region Question 6
            double price = 49.99;
            int totalPrice = (int)price;
            Console.WriteLine(totalPrice);
            #endregion

            #region Question 7
            string pagesText = "464";
            int _pages = Convert.ToInt32(pagesText);
            Console.WriteLine(_pages);
            #endregion

            #region Question 8
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);

            string badText = "abc";
            bool isValid = int.TryParse(badText, out int num);
            if (isValid)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            #endregion

            #region Question 9
            int bookPages = 464;
            string bookPagesText = bookPages.ToString();
            Console.WriteLine(bookPagesText);
            Console.WriteLine(bookPagesText.GetType());
            #endregion

            #region Question 10
            int copies = 100;
            object _obj = copies;
            int newCopies = (int)_obj;
            Console.WriteLine(copies);
            Console.WriteLine(newCopies);
            #endregion

        }
    }

}
