namespace SkipLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------Skip---------");
            var skip = PeopleList.people.Skip(4);

            foreach (var x in skip)
            {
                Console.WriteLine( x.Age); 
            }

        }
    }
}
// Skip skipping choosed number of choosed items, for example skip first 4 ages in list and 
//showing in the input last 2 ages of the list(if it was more items in the list it showing more)
