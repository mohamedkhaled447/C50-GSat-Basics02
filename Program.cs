namespace FirstApplicatin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Quesetion1
            //object objBook = new Book { Title = "C# in Depth", Pages = 464 }; [cite: 1]
            //Console.WriteLine(objBook);
            #endregion

            #region Quesetion2
            //Book book = new Book { Title = "C# in Depth", Pages = 464 }; [cite: 1]
            //Console.WriteLine(book.ToString()); [cite: 1]
            //Console.WriteLine(book.Equals(book)); [cite: 1]
            //Console.WriteLine(book.GetHashCode()); [cite: 1]
            //Console.WriteLine(book.GetType()); [cite: 1]
            #endregion

            #region Quesetion 3
            // Compile-time error[cite: 1]
            //          int pagesQ03 = int.Parse("464"); [cite: 1]
            //Console.WriteLine(pagesQ03);
            #endregion

            #region Quesetion 4
            //            try
            //            {
            //                int zero = 0;
            //                int result = 10 / zero; [cite: 1]
            //    Console.WriteLine(result);
            //            }
            //            catch (DivideByZeroException)
            //            {
            //                Console.WriteLine("Cannot divide by zero"); [cite: 1]
            //}
            //            finally
            //            {
            //                Console.WriteLine("Done"); [cite: 1]
            //}
            #endregion

            #region Quesetion 5
            //            int pagesQ05 = 300; [cite: 1]
            //double doublePages = pagesQ05; [cite: 1]
            //Console.WriteLine(doublePages);
            #endregion

            #region Q06
            double price = 49.99; [cite: 1]
int intPrice = (int)price; [cite: 1]
Console.WriteLine(intPrice);
            #endregion

            #region Q07
            string pagesText = "464"; [cite: 1]
int convertedPages = Convert.ToInt32(pagesText); [cite: 1]
Console.WriteLine(convertedPages);
            #endregion

            #region Q08
            string yearText = "2023"; [cite: 1]
int year = int.Parse(yearText); [cite: 1]
Console.WriteLine(year);

            string badText = "abc"; [cite: 1]
if (int.TryParse(badText, out int badNumber)) [cite: 1]
{
                Console.WriteLine(badNumber);
            }
else
            {
                Console.WriteLine("Invalid number"); [cite: 1]
}
            #endregion

            #region Q09
            int pagesQ09 = 464; [cite: 1]
string pagesAsString = pagesQ09.ToString(); [cite: 1]
Console.WriteLine(pagesAsString.GetType()); [cite: 1]
#endregion

#region Q10
int copies = 100; [cite: 1]
object boxedCopies = copies; [cite: 1]
int unboxedCopies = (int)boxedCopies; [cite: 1]
Console.WriteLine($"Boxed: {boxedCopies}, Unboxed: {unboxedCopies}"); [cite: 1]
#endregion

#region Q11
int? nullableYear = null; [cite: 1]
Console.WriteLine(nullableYear.HasValue); [cite: 1]

nullableYear = 2023; [cite: 1]
Console.WriteLine(nullableYear.Value); [cite: 1]
#endregion

#region Q12
string? reviewer = null; [cite: 2]
Console.WriteLine(reviewer is null); [cite: 2]
#endregion

#region Q13
Book? bookQ13 = null; [cite: 2]
string? titleQ13 = bookQ13?.Title; [cite: 2]
Console.WriteLine(titleQ13); [cite: 2]
#endregion

#region Q14
Console.WriteLine(titleQ13 ?? "Untitled"); [cite: 2]
titleQ13 ??= "Untitled"; [cite: 2]
Console.WriteLine(titleQ13);
            #endregion

            #region Q15
            string? name = "Ahmed"; [cite: 2]
string confirmedName = name!; [cite: 2]
Console.WriteLine(confirmedName);
            #endregion

































































































        }
    }
}
