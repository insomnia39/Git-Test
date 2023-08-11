namespace Git_Test
{
    public class Controller2
    {
        public Controller2(String args)
        {
            Console.WriteLine("Hello");
        }

        public void ReadFromDB(int a, int b)
        {
            int total = Logic.Add(a, b);
            int least = Logic.Substract(a, b);
        }

        public void RemoveFromDB(int a, int b)
        {
            int total = Logic.Substract(a, b);
        }
    }
}
