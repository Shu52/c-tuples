using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            
            (string product, double amount, int quantity) hammer =("Hammer", 19.99, 25);
            (string product, double amount, int quantity) nails=("Nails", 19.99, 25);
            (string product, double amount, int quantity) nailgun=("Nailgun", 19.99, 25);
            (string product, double amount, int quantity) bandaids=("Bandaids", 19.99, 25);
        }
    }
}
