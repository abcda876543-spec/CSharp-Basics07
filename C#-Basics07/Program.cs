
namespace C__Basics07
{
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            Book book = new Book();
            Console.WriteLine(book.password);
            //it gives a compile error because password is private and only can be accessed in Book class
            #endregion

            #region Question 2

            Console.WriteLine(book.copiesInStock);
            // it comoiles because internal allows access at the same assembly
            #endregion 

            #region Question 3
           book.Title = "c sharp basics";
            Console.WriteLine(book.Title);
            #endregion

            #region Question 4
            book.Genre = Genre.Science;
            Console.WriteLine(book.Genre);
            #endregion

            #region Question 5
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            #endregion
        }
    }

}