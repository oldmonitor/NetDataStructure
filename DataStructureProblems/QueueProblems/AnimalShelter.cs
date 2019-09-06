using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.QueueProblems
{
    public class AnimalShelter
    {
        int counter = 0;
        Queue<Cat> CatQueue = new Queue<Cat>();
        Queue<Dog> DogQueue = new Queue<Dog>();

        public void Enqueue(Animal animal)
        {
            counter++;
            animal.ShelterAge = counter;
            if(animal.AnimalType == AnimalType.Cat)
            {
                CatQueue.Enqueue((Cat)animal);
            }

            if (animal.AnimalType == AnimalType.Dog)
            {
                DogQueue.Enqueue((Dog)animal);
            }
        }

        public Animal DequeueAny()
        {
            Animal cat = this.CatQueue.Peek();
            Animal dog = this.DogQueue.Peek();
            if(cat.ShelterAge > dog.ShelterAge)
            {
                return this.DequeuCat();
            }
            else
            {
                return this.DequeuDog();
            }
        }

        public Cat DequeuCat()
        {
            return this.CatQueue.Dequeue();
        }

        public Dog DequeuDog()
        {
            return this.DogQueue.Dequeue();
        }
    }

    public class Animal
    {

        //how long animal has been in shelter
        public int ShelterAge { get; set; }

        public AnimalType AnimalType { get; set; }

        public Animal(AnimalType animalType)
        {
            this.AnimalType = animalType;
        }
    }

    public enum AnimalType
    {
        Dog,
        Cat
    }

    public class Cat: Animal
    {
        public Cat()
            : base(AnimalType.Cat)
        {
        }
    }

    public class Dog: Animal
    {
        public Dog() : base(AnimalType.Dog) { }
    }
        
}
