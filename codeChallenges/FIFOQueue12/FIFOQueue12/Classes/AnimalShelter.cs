using System;
using System.Collections.Generic;
using System.Text;
using FIFOQueue12.Classes;

namespace FIFOQueue12.Classes
{
    public class AnimalShelter
    {
        /// <summary>
        /// Sets the front node
        /// </summary>
        public Animal Front { get; set; }

        /// <summary>
        /// Sets the rear node
        /// </summary>
        public Animal Rear { get; set; }

        /// <summary>
        /// Sets the front and rear nodes of queue
        /// </summary>
        /// <param name="node">Takes in node</param>
        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
        }

        /// <summary>
        /// Enqueue add node to end and sets rear to new node
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(string type)
        {
            Animal animal = new Animal(type);
            Rear.Next = animal;
            Rear = animal;
        }

        /// <summary>
        /// Dequeue removes node from front of queue
        /// </summary>
        /// <returns>a temp node</returns>
        public Animal Dequeue()
        {
            Animal temp = Front;
            Front = Front.Next;
            temp.Next = null;

            return temp;
        }

        /// <summary>
        /// Peeks at the front node
        /// </summary>
        /// <returns></returns>
        public Animal Peek()
        {
            return Front;
        }
    }
}