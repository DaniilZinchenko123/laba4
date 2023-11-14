namespace Task1
{
    using System;

    public class Animal : LivingOrganism, IReproducible, IPredator
    {
        public void Reproduce()
        {
            Console.WriteLine("Animal is reproducing.");
        }

        public void Hunt()
        {
            Console.WriteLine("Animal is hunting.");
        }
    }
}