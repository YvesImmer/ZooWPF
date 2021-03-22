using System.Collections.Generic;

namespace ZooWPF
{
    public abstract class Animal
    {
        public int ID { get; set; }
        private string name { get; set; }
        private int age { get; set; }
        private int energy { get; set; }
        private bool isSick { get; set; }
        private bool isAlive { get; set; }
        private int dailyFood { get; set; }
        private List<FoodType> edibleFoods;
        private List<EnvironmentType> environmentTypes;
        private Enclosure enclosure;
        private List<string> funFacts;

        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }

        public void setEnclosure(Enclosure enclosure)
        {
            this.enclosure = enclosure;
        }

        public List<EnvironmentType> getEnvironmentTypes()
        {
            return environmentTypes;
        }
        public void Eat()
        {
            throw new System.NotImplementedException();
        }

        public void ComputeDay()
        {

        }

        public void getFunFact()
        {
            throw new System.NotImplementedException();
        }
    }
}