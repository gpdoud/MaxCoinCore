using System;
using System.Collections.Generic;
using System.Text;

namespace Maxtrain.MaxCoinLib.Models {

    public class Transaction {

        public int Id { get; set; }
        public int Version { get; private set; } = 1;
        public string Flag { get; private set; } = "0001";
        public int InCounter { get; set; } = 0;
        public IList<TxIn> Inputs { get; set; }
        public int OutCounter { get; set; } = 0;
        public IList<TxOut> Outputs { get; set; }
        public IList<Witness> Witnesses { get; set; }
        public DateTime? LockTime { get; set; } = null;

        public Transaction() { }
    }
}
