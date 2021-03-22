using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooWPF
{
    public class Zoo

    {
        public List<Enclosure> enclosures;

        public List<Animal> getAnimals()
        {
            List<Animal> allAnimals = new List<Animal>();
            foreach ( Enclosure e in enclosures)
            {
                allAnimals.AddRange(e.getAnimals());
            }
            return allAnimals;
        }
    }
}