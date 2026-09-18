namespace C__Basics07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            Book book = new Book();
            Console.WriteLine(book.password);
            //it gives a compile error because password is peivate and only can be accessed in Book class
            #endregion
        }
    }

}
