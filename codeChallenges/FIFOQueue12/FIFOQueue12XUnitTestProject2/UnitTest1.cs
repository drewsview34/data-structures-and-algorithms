using FIFOQueue12;
using FIFOQueue12.Classes;
using Xunit;

namespace FIFOQueue12XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueWorks()
        {
            //arrange
            Animal animal = new Animal("Dog");
            Animal animal1 = new Animal("Cat");
            Animal animal2 = new Animal("Dog");
            Animal animal3 = new Animal("Cat");

            //act
            AnimalShelter primary = new AnimalShelter(animal);
            primary.Enqueue(animal1.Value);
            primary.Enqueue(animal2.Value);
            primary.Enqueue(animal3.Value);

            //assert
            Assert.Equal("Dog", primary.Front.Value);
        }

        [Fact]
        public void EnqueueWorksAgain()
        {
            //arrange
            Animal animal = new Animal("Cat");
            Animal animal1 = new Animal("Cat");
            Animal animal2 = new Animal("Dog");
            Animal animal3 = new Animal("Cat");

            //act
            AnimalShelter primary = new AnimalShelter(animal);
            primary.Enqueue(animal1.Value);
            primary.Enqueue(animal2.Value);
            primary.Enqueue(animal3.Value);

            //assert
            Assert.Equal("Cat", primary.Front.Value);
        }

        [Fact]
        public void EnqueueWorksAgains()
        {
            //arrange
            Animal animal = new Animal("Dog");
            Animal animal1 = new Animal("Dog");
            Animal animal2 = new Animal("Dog");
            Animal animal3 = new Animal("Cat");

            //act
            AnimalShelter primary = new AnimalShelter(animal);
            primary.Enqueue(animal1.Value);
            primary.Enqueue(animal2.Value);
            primary.Enqueue(animal3.Value);

            //assert
            Assert.Equal("Dog", primary.Front.Value);
        }

        [Fact]
        public void DequeueWorks()
        {
            //arrange
            Animal animal = new Animal("Dog");
            Animal animal1 = new Animal("Cat");
            Animal animal2 = new Animal("Dog");
            Animal animal3 = new Animal("Cat");
            AnimalShelter primary = new AnimalShelter(animal);
            primary.Enqueue(animal1.Value);
            primary.Enqueue(animal2.Value);
            primary.Enqueue(animal3.Value);
            //act

            Program.ShelterDequeue(primary, "Dog");
            //assert
            Assert.Equal("Cat", primary.Front.Value);
        }
    }
}