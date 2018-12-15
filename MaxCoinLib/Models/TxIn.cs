using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maxtrain.MaxCoinLib.Models {

    public class TxIn {

        public int Id { get; set; }
        public int TransactionId { get; set; }
        public string PrevTxHash { get; set; }
        public int PrevTxoutIndex { get; set; } = -1;
        public int TxinScriptLength { get; set; } = -1;
        public string TxinScript { get; set; }
        public int SequenceNbr { get; set; } = -1;

        public TxIn() { }

        public override string ToString() {
            return $"{Id}{TransactionId}{PrevTxHash}{PrevTxoutIndex}{TxinScriptLength}{TxinScript}{SequenceNbr}";
        }
    }
}
