using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterCrupt
{
    public class Application {
        public void Encrypt(string message, UI ui) {
            ui.SetMessage(Encrypter.Encrypt(message));
        }
        static void Main(string[] args)
        {
            UI ui = new UI();
        }
    }
}
