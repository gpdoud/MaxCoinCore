using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxtrain.MaxCoin.Models {
    public class TxIn {

        public int Id { get; set; }
        public int UserKey { get; set; }
        public decimal Value { get; set; }
        public string Hash { get; set; }

        public override string ToString() {
            var sb = new StringBuilder();
            sb.Append(UserKey.ToString());
            sb.Append(Value.ToString());
            sb.Append(Hash);
            return sb.ToString();
        }

        public TxIn() { }
    }
}
