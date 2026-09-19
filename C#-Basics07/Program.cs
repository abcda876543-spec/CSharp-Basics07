namespace C__Basics07
{
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
        }
    }

}