namespace Chapter2
{
    /// <summary>
    /// LISTING 2-40 Implementing an interface explicitly
    /// </summary>
    interface ILeft
    {
        void Move();
    }

    interface IRight
    {
        void Mode();
    }

    class MoveableObject : ILeft, IRight
    {
        void ILeft.Move() { }
        void IRight.Mode() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
