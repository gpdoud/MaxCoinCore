using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maxtrain.MaxCoinLib.Models {

    public class TxOut {

        public int Id { get; set; }
        public int TransactionId { get; set; }
        public long Value { get; private set; } // nbr of Satoshis(BTC/10^8)
        public int TxoutScriptLength { get; set; } = -1;
        public string TxoutScript { get; set; }

        public void SetBitcoins(int bitcoins) {
            this.Value = bitcoins * 10 ^ 8;
        }
        public void SetSatoshis(long satoshis) {
            this.Value = satoshis;
        }

        public TxOut() { }

        public override string ToString() {
            return $"{Id}{TransactionId}{Value}{TxoutScriptLength}{TxoutScript}";
        }
    }
}
