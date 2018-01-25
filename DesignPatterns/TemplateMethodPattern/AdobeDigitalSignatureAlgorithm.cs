using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class AdobeDigitalSignatureAlgorithm : DigitalSignature
    {
        public override void HashText()
        {
            Console.WriteLine("Hash message using Sha256 algorithm");
        }

        public override void EncryptText()
        {
            Console.WriteLine("Encrypt message using symmetric algorithm");
        }
    }
}
