using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maxtrain.MaxCoinLib.Models {

    public class Witness {

        public int Id { get; set; }

        public override string ToString() {
            return $"{Id}";
        }
    }
}
