namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_01
{
    public class Program
    {
        #region INCLUDE
        public static void Main(string[] args)
        {
            int? number = null;
            #region EXCLUDE
            if (args.Length>0)
            {
                number = args[0].Length;
            }
            #endregion
            if (number is null)
            {
                System.Console.WriteLine(
                    "'number' requires a value and cannot be null");
            }
            else
            {
                System.Console.WriteLine(
                    $"'number' doubled is { number * 2 }.");
            }
        }
        #endregion
    }
}

