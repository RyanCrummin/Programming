namespace Inheritcane_Week8
{/* name: Ryan Crumley
  * Date: 09/04/2024
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employ1 = new Employee();
            Employee employ2 = new Employee("Ryan","Male",19,"Irish");

            Console.WriteLine(employ1.ToString());
            Console.WriteLine(employ2.ToString());

            Employee employ3 = new Employee();
            employ3.Name = "john";
            employ3.Gender = "Male";
            employ3.HourlyRate = 100;
            employ3.Nationality = "American";
            
          
            Console.WriteLine(employ3);

            Console.WriteLine(employ3.CalcTax()); ;

            

        }
    }
}
