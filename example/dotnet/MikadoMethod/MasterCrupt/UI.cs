using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterCrupt
{
    public class UI {
        Application secretApplication = new Application(); 
        private string encrypt;
        
        public string EncryptMessage(string message) {
            secretApplication.Encrypt(message, this);
            return "Encrypted: " + encrypt;
        }

        public void SetMessage(string encrypt) {
            this.encrypt = encrypt;
        }
    }
}
