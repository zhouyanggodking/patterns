using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Test
    {
        static void Main(string[] args)
        {
            new IGTDigitalSignatureAlgorithm().Signature();
            new AdobeDigitalSignatureAlgorithm().Signature();
        }
    }
}
