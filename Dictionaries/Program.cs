namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dictionaries are collections of data stored as key value pairs 
             * 
             * -> provides fast data access based on a unique key 
             * 
             * 
             * 
             * dictionary Dict<key Value> = new Dictionary<>(
             * {
             * {"key", "Value}
             * }
             * */

            Dictionary<string, string> valuepairs = new Dictionary<string, string>();

            // adding value
            // to delete you set the value to a string 
            // garbage collection usetting values or deleting the memory 

            valuepairs.Add("Computer Science", "Programming");
            valuepairs.Add("Law", "Criminology");
            valuepairs.Add("Education", "Teaching Practice");

            // add via index 
            valuepairs["Engineering"] = "Mathamatics";  // use this code  to add to the dictionary 

            // set the value to "delete it " this is setting the value to null 
            valuepairs["Education"] = "";

            // printing 
            foreach (KeyValuePair<string, string> pair in valuepairs)
            {
                Console.WriteLine($"Courses: {pair.Key} | Module {pair.Value}");  
            }


            // check if a specific dict key is contained a key 
            bool containsKey = valuepairs.ContainsKey("Education");
            if (containsKey)
            {
               Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
 }
            // remove to delete 
            valuepairs.Remove("Education");
                    //printing 
                    foreach (KeyValuePair<string, string> pair in valuepairs) ;

                    //return the number of items in the dict 

                    int items = valuepairs.Count;

            Console.WriteLine(items);

            //TryGetValue to see if the value exists 
            valuepairs.Clear();

            int itemsb = valuepairs.Count;
            Console.WriteLine(items);
           
        }
    }
}
