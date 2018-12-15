using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maxtrain.MaxCoin.Models {
    public class Transaction {

        public int Id { get; set; }
        public int Version { get; private set; } = 1;
        public string Flag { get; private set; } = "0001";
        public int InCounter { get; set; } = 0;
        public string Inputs { get; set; }
        public int OutCounter { get; set; } = 0;
        public string Outputs { get; set; }
        public string Witnesses { get; set; }
        public DateTime? LockTime { get; set; } = null;

        public Transaction() { }
    }
}
