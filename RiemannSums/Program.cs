// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Security.Cryptography.X509Certificates;

class RiemannSum
{
   static void Main()
   {
      // Initialize all variables
      int a;                              //lower limit of interval
      int b;                               //upper limit of interval
      float DeltaX;                          // partition width
      int n;                                  // number of partitions
      float Sum1 = 0;                        //Running sum for Left side partition
      float Sum2 = 0;                        //Running sum for Mid Point partition
      float Sum3 = 0;                        //Running sum for Right side partition
      float A1 = 0;                          //Area for Left side partition
      float A2 = 0;                          //Area for Mid Point partition
      float A3 = 0;                          //Area for Right side partition
      float x;                               //lower limit of partition


      Console.WriteLine("Please Enter the number of partitions you wish to use to approximate the Riemann Sum:");

      //n = int.TryParse(Console.ReadLine());                                                           // Recieve n, number of partitions, from user
      while ((!int.TryParse(Console.ReadLine(), out n)) & n <= 0)                                        // STOP if n <= 0 because we use n as a denominator for DeltaX later
      {
         Console.WriteLine("That was invalid. Enter an integer value greater than 0 for the number of partitions.");
      }

      Console.WriteLine($" The number of partitions you requested was: {n} ");

      Console.WriteLine("Please Enter the A value, the left end of the interval");

      while (!int.TryParse(Console.ReadLine(), out a))                                          // Recieve a, beginning of interval, from user
      {
         Console.WriteLine("That was invalid. Enter an integer value for the left side of the interval.");
      }

      Console.WriteLine("Please Enter the B value, the right end of the interval");

      while (!int.TryParse(Console.ReadLine(), out b))                                          // Recieve b, end of interval, from user
      {
         Console.WriteLine("That was invalid. Enter an integer value for the right side of the interval.");
      }

      DeltaX = (b - a) / ((float)n);                                                          // Calculate delta X, as b-a divided by the number of partitions: N must become a float value to calculate the float DeltaX

      Console.WriteLine($"DeltaX is {DeltaX}");                                                 // Present DeltaX to user for testing purposes

      for (int i = 0; i < n; i++)
      {
         x = a + ((float)i * DeltaX);

         Sum1 += F(x);
         Sum2 += F(x + DeltaX / 2);
         Sum3 += F(x + DeltaX);
      }

      A1 = (DeltaX * Sum1);
      A2 = (DeltaX * Sum2);
      A3 = (DeltaX * Sum3);

      Console.WriteLine($"The Area under the curve F(x) = x^2 between {a} and {b} using a Left Side Riemann Sum is: {A1}");
      Console.WriteLine($"The Area under the curve F(x) = x^2 between {a} and {b} using a Mid Point Riemann Sum is: {A2}");
      Console.WriteLine($"The Area under the curve F(x) = x^2 between {a} and {b} using a Right Side Riemann Sum is: {A3}");

   }
   static float F(float x)
   {
      float y = x * x;               // Initialize the function to be used in the calculation. Easy to change by altering right side of =. 
      return y;
   }

}
