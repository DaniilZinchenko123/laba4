namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ecosystem = new Ecosystem();

            var lion = new Animal();
            var tree = new Plant();
            var bacteria = new Microorganism();

            ecosystem.AddOrganism(lion);
            ecosystem.AddOrganism(tree);
            ecosystem.AddOrganism(bacteria);

            ecosystem.SimulateInteractions();
        }
    }
}