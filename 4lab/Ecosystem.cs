namespace Task1
{
    public class Ecosystem
    {
        private List<LivingOrganism> organisms;

        public Ecosystem()
        {
            organisms = new List<LivingOrganism>();
        }

        public void AddOrganism(LivingOrganism organism)
        {
            organisms.Add(organism);
        }

        public void SimulateInteractions()
        {
            foreach (var organism in organisms)
            {
                if (organism is IPredator predator)
                {
                    predator.Hunt();
                }

                if (organism is IReproducible reproducible)
                {
                    reproducible.Reproduce();
                }
            }
        }
    }
}