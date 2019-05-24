using System;
using System.Collections;
using System.Collections.Generic;

namespace Street_Parade_Problem_algorithm
{
    class Program
    {
        static Queue<int> qWe;
        static Queue<int> qWy;
        static Stack<int> stack;

        static Queue<int> ReadCase()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0) return null;

            Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse );
            Queue<int> q = new Queue<int>( tab) ;

            return q;
        }

        static void Main(string[] args)
        {
          while (qWe != null)
            {
                Queue<int> qWy = new Queue<int>();

                var Stack = new Stack<int>();

                string response = "";

                int expected = 1;            
                
                while ( qWe.Count > 0 || stack.Count > 0)
                {
                    int truck = qWe.Peek();  //Nie bedzie wyjatku

                    if ( truck == expected )
                    {
                        truck = qWe.Dequeue(); //Nie bedzie wyjatku

                        qWy.Enqueue(truck);

                        expected++;
                    }
                    else if (stack.Count > 0 && stack.Peek() == expected)
                    {
                        truck = stack.Pop();

                        qWy.Enqueue(truck);

                        expected++;
                    }
                    else
                    {
                        truck = qWe.Dequeue();
                        stack.Push(truck);
                    }

                }

                if (stack.Count == 0)
                    response = "Yes";
                else
                    response = "No";

                Console.WriteLine(response);

            }
        }
    }
}
