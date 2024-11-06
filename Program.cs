using System.Text.Json;

namespace pick_n_mix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter the student name : ");
            string name = Console.ReadLine();

            Console.Write("Enter the number of years coding : ");
            string yearsCodingInput = Console.ReadLine();
            int yearsCoding;
            int.TryParse(yearsCodingInput, out yearsCoding);

            Console.Write("Is the Student debugging True/False: ");
            string isDebuggingInput = Console.ReadLine();
            bool isDebugging;
            bool.TryParse(isDebuggingInput, out isDebugging);

            Console.Write("Enter the students coding affiliation (or press Enter to use default) : ");
            string codingAffiliation =  Console.ReadLine();
            if (string.IsNullOrEmpty(codingAffiliation))
            {
                codingAffiliation = "Northcoders";
            }
*/
            string json = @"{
            ""Name"": ""Evie Pom"",
            ""YearsCoding"": 6,
            ""IsDebugging"": false,
            ""CodingAffiliation"": ""Poms Who Code""
        }";




            NorthcodersStudent student = JsonSerializer.Deserialize<NorthcodersStudent>(json);




            /*NorthcodersStudent student = new NorthcodersStudent();
            student.Name = name;
            student.YearsCoding = yearsCoding;
            student.IsDebugging = isDebugging;
            student.CodingAffiliation = codingAffiliation;
            */


            Console.WriteLine(student.Name);
            Console.WriteLine(student.YearsCoding);
            Console.WriteLine(student.IsDebugging);
            Console.WriteLine(student.CodingAffiliation);

            student.CheckIfDebugging();
        }
    }
}
