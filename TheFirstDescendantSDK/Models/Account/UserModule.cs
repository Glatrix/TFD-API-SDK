using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TfdApiSDK.Models.Account
{

    public class UserModule
    {
        public string module_slot_id { get; set; }
        public string module_id { get; set; }
        public float module_enchant_level { get; set; }
    }
}
