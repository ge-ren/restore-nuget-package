using System;
using Prime.Services;

namespace check4prime
{
    class Program
    {
	private readonly PrimeService _primeService;

        static void Main(string[] args)
        {
	    _primeService = new PrimeService(); 	
            Console.WriteLine(string.Format("Hello World! {0}", _primeService.IsPrime(2)));
        }
    }
}
