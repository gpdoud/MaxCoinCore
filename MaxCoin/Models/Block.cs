using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Maxtrain.MaxCoinLib.Utility;

namespace Maxtrain.MaxCoin.Models {

    public class Block {

        public int Id { get; set; }
        public string Json { get; set; }

        public Block() {
        }
    }
}
