using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class DigitalSignature
    {
        public abstract void HashText();
        public abstract void EncryptText();
        public void EncodingText()
        {
            Console.WriteLine("Encode message using UTF8 format");
        }
        public void AppendText()
        {
            Console.WriteLine("Append computed text to the end of message");
        }

        public void Signature()
        {
            HashText();
            EncryptText();
            EncodingText();
            AppendText();
        }
    }
}
