internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter the total number of student");
        int r = Convert.ToInt32(Console.ReadLine());
        string[] student = new string[r];
        Console.WriteLine("enter " + r + " student names");

        for (int i = 0; i < student.Length; i++)
        {
            student[i] = Console.ReadLine();
        }
        Console.WriteLine("----------this are the student that you have listed-------------");

        for (int i = 0; i< student.Length; i++)
        {
            Console.WriteLine(student[i]);

        }
        Console.ReadKey();
    }
}