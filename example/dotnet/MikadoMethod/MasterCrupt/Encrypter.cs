using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterCrupt
{
    public class Encrypter {
        public static String Encrypt(string message) {
            return message.Replace('e', '*');
        }
    }
}
