using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorandIPv4.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Key { get; set; }
        public string Ipv4 { get; set; }
        public int Algos { get; set; }
        public string ReceiverAddress { get; set; }
    }
}
