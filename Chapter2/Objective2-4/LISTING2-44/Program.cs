namespace Chapter2
{
    /// <summary>
    /// LISTING 2-44 Instantiating a concrete type that implements an interface
    /// </summary>
    interface IAnimal
    {
        void Move();
    }

    class Dog : IAnimal
    {
        public void Move() { }
        public void Bark() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Dog();
        }
    }
}
