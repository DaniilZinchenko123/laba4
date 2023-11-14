namespace Task1
{
    using System;

    public class Microorganism : LivingOrganism, IReproducible
    {
        public void Reproduce()
        {
            Console.WriteLine("Microorganism is reproducing.");
        }
    }
}