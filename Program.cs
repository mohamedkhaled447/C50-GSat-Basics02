namespace C50_GSat_Basics02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

class Book
        {
            public string Title { get; set; } = string.Empty;
            public int Pages { get; set; }
        }

        class Program
        {
            static void Main()
            {
                #region Question1
                // 1 .  Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
                ///Book book = new Book { Title = "Dune", Pages = 464 };
                ///object objBook = book;
                ///Console.WriteLine(objBook);
                #endregion

                #region Question 2
                /// Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
                ///Console.WriteLine(book.ToString());
                ///Console.WriteLine(book.Equals(book));
                ///Console.WriteLine(book.GetHashCode());
                ///Console.WriteLine(book.GetType());
                #endregion

                #region Question 3
                // Q03. Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
                // int pages = "464"; -> Compile-time error
                ///int fixedPages = 464;
                ///Console.WriteLine(fixedPages);
                #endregion

                #region Question 4
                // Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
                //int dividend = 10;
                //int divisor = 0;

                //try
                //{
                //    int result = dividend / divisor;
                //    Console.WriteLine(result);
                //}
                //catch (DivideByZeroException)
                //{
                //    Console.WriteLine("Cannot divide by zero");
                //}
                //finally
                //{
                //    Console.WriteLine("Done");
                //}
                #endregion

                #region Question 5
                // Q05. Declare an int pages = 300; then store it in a double variable without using a cast.
                //int pages = 300;
                //double doublePages = pages;
                //Console.WriteLine(doublePages);
                #endregion

                #region Question 6
                // Q06. Declare a double price = 49.99; then convert it into an int using a cast.
                //double price = 49.99;
                //int wholePrice = (int)price;
                //Console.WriteLine(wholePrice);
                #endregion

                #region Question7
                // Q07. Given string pagesText = "464";, convert it into an int using the Convert class.
                //string pagesText = "464";
                //int convertedPages = Convert.ToInt32(pagesText);
                //Console.WriteLine(convertedPages);
                #endregion

                #region Question 8
                // Q08. Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
                //string yearText = "2023";
                //int parsedYear = int.Parse(yearText);
                //Console.WriteLine(parsedYear);

                //string badText = "abc";
                //if (int.TryParse(badText, out int badNumber))
                //{
                //    Console.WriteLine(badNumber);
                //}
                //else
                //{
                //    Console.WriteLine("Invalid number");
                //}
                #endregion

                #region Question 9
                // Q09. Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
                //int bookPages = 464;
                //string pagesAsString = bookPages.ToString();
                //Console.WriteLine(pagesAsString.GetType());
                #endregion

                #region Question10
                // Q10. Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
                //int copies = 100;
                //object boxedCopies = copies;
                //int unboxedCopies = (int)boxedCopies;
                //Console.WriteLine($"Boxed: {boxedCopies}, Unboxed: {unboxedCopies}");
                #endregion

                #region Question11
                // Q11. Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.
                //int? year = null;
                //Console.WriteLine(year.HasValue);
                //year = 2023;
                //Console.WriteLine(year.Value);
                #endregion

                #region Question12
                // Q12. Declare a string? reviewer = null;. Print whether it is null.
                //string? reviewer = null;
                //Console.WriteLine(reviewer == null);
                #endregion
                #region Question12
                // Q13. Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the program, and print the result.
                Book? nullableBook = null;
                string? title = nullableBook?.Title;
                Console.WriteLine(title);
#endregion
                // Q14. Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??= to assign title the value "Untitled" only if it's still null.
                Console.WriteLine(title ?? "Untitled");

                title ??= "Untitled";
                Console.WriteLine(title);

                // Q15. Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable string confirmedName using the ! operator.
                string? name = "Ahmed";
                string confirmedName = name!;
                Console.WriteLine(confirmedName);
            }
        }









































































































    }
    }
}
