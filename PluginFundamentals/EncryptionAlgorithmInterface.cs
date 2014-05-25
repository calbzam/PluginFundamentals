using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFundamentals
{
  interface IEncryptionAlgorithm
  {
    string Encrypt(string input);
  }
}
