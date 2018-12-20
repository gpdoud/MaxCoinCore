using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxtrain.MaxCoin.Models {
    public class TxOut {

        public int Id { get; set; }
        public string UserKey { get; set; }
        public decimal Value { get; set; }
        public string Hash { get; set; }

        public override string ToString() {
            var sb = new StringBuilder();
            sb.Append(UserKey.ToString());
            sb.Append(Value.ToString());
            sb.Append(Hash);
            return sb.ToString();
        }


        public TxOut() { }
    }
}
