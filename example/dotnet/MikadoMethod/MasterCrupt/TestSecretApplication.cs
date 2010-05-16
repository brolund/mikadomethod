using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterCrupt
{
    [NUnit.Framework.TestFixture]
    public class TestSecretApplication
    {
        [NUnit.Framework.Test]
        public void TestSecret()
        {
            UI ui = new UI();
            NUnit.Framework.Assert.AreEqual("Encrypted: S*cr*t", ui.EncryptMessage("Secret"));
        }
    }
}
