namespace Dictionary2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create dictionaries with user input 

            var courses = new Dictionary<string, List<string>>();

            // accept user input 
            while (true)
            {

                Console.WriteLine("Enter Program Name or 'Stop to Exit: ");
                string key = Console.ReadLine();

                if (key?.ToLower() == "stop") break;

                Console.WriteLine($"Enter Modules for {key}: ");
                string module = Console.ReadLine();

                if (!courses.ContainsKey(key))
                {
                    courses[key] = new List<string>();
                }
                courses[key].Add(module);

                
            }
            foreach (var entry in courses)
            {
                Console.WriteLine($"Courses: {entry.Key} | Module: {string.Join(",", entry.Value)}");
            }
        }
    }
}

/* exercise 
 * create a dictionary that stores employee details as well as there id 
 * create an employee dictionary <int ID, EmpID , List<Employee>>() 
 * 
 * The dictionary will store the following details 
 *  emp number  and emp Details 
 *  
 *  
 * 1 Employee Details are from a seperate class Employee are as followes
 *      1 EmpID
 *      2 EmpName
 *      3 EmpSurname 
 *      4 EmpSalary
 *      5 EmpPosition 
 *      
 *      2 Create the method searchEmp(int EmpID)
 *      That searches for an employee using EmpID 
 *      
 *      3 create a methods searchEmpDetails(string value)
 *      that allows searching the dictionary usning employee details 
 *      this method must return all matches from the List<Employee>
 *       
 * 
 */