﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maxtrain.MaxCoin.Models {

    public class User {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Key { get; set; }

        public User() { }
    }
}
