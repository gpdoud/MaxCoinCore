using System;
using System.Collections.Generic;
using System.Text;
using Maxtrain.MaxCoinLib.Utility;

namespace Maxtrain.MaxCoinLib.Models {

    public class Block {

        public int Index { get; internal set; }
        public DateTime Timestamp { get; private set; }
        public string Hash { get; private set; }
        public string PrevHash { get; private set; }
        public string Data { get; set; }
        public int Nonce { get; private set; }

        public string ToHashString() {
            return $"{Index}{Timestamp.ToString()}{PrevHash}{Nonce.ToString()}{Data}";
        }

        public static Block CreateGenesisBlock() {
            var genesis = new Block {
                Index = 1,
                Timestamp = DateTime.Now,
                PrevHash = string.Empty,
                Data = "Genesis Block",
                Nonce = 0
            };
            var blockDataToHash = genesis.ToHashString();
            var hash = Sha256.Hash(blockDataToHash);
            genesis.Hash = hash;
            return genesis;
        }

        public Block() { }
    }
}
