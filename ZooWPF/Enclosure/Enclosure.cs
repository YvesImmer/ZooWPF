using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooWPF
{
    public class Enclosure
    {
        private List<Animal> animals;
        public EnvironmentType environmentType;

        public Enclosure(EnvironmentType environmentType)
        {
            this.environmentType = environmentType;
        }

        public void setAnimals(List<Animal> animals)
        {
            foreach(Animal a in animals)
            {
                addAnimal(a);
            }
        }

        public void addAnimal(Animal animal)
        {
            if (animal.getEnvironmentTypes().Contains(environmentType))
            {
                animals.Add(animal);
                animal.setEnclosure(this);
            }
            else
            {
                Console.WriteLine("Could not add animal (" + animal.GetName() + ") to enclosure: unsuitable Environment");
            }
        }

        internal IEnumerable<Animal> getAnimals()
        {
            return animals;
        }
    }
}