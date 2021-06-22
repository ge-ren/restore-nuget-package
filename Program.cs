using System;
using Prime.Services;

namespace check4prime
{
    class Program
    {
        static void Main(string[] args)
        {
	    var primeService = new PrimeService(); 
	    var result = primeService.IsPrime(4);
            Console.WriteLine(string.Format("Hello World! {0}", primeService.IsPrime(2)));
        }
    }
}
