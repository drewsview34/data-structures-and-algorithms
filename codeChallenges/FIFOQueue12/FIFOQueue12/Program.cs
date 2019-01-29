using FIFOQueue12.Classes;
using System;

namespace FIFOQueue12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        Animal animal = new Animal("Dog");

        public void Shelter()
        {
            Animal animal = new Animal("Dog");
            Animal animal1 = new Animal("Cat");
            Animal animal2 = new Animal("Dog");
            Animal animal3 = new Animal("Cat");

            AnimalShelter primary = new AnimalShelter(animal);
            primary.Enqueue(animal1.Value);
            primary.Enqueue(animal2.Value);
            primary.Enqueue(animal3.Value);
        }

        public static void ShelterDequeue(AnimalShelter primary, string pref)
        {
            if (pref == primary.Front.Value)
            {
                primary.Dequeue();
            }
            else if (pref != primary.Front.Value)
            {
                AnimalShelter temp = new AnimalShelter(primary.Dequeue());
                while (pref != primary.Front.Value)
                {
                    temp.Enqueue(primary.Dequeue().Value);
                }

                primary.Dequeue();

                while (primary.Front != null)
                {
                    temp.Enqueue(primary.Dequeue().Value);
                }
                while (temp.Front != null)
                {

                    primary.Enqueue(temp.Dequeue().Value);
                }

            }

        }
    }
}