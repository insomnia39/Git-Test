﻿namespace Git_Test
{
    public class Controller
    {
        public Controller(String args, int number)
        {

        }

        public void AddToDatabase(int a, int b)
        {
            double total = Logic.Multiply(Logic.Add(a, b), b);
        }
    }
}
