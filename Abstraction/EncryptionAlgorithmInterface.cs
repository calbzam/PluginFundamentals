using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFundamentals.Abstraction
{
  public interface IEncryptionAlgorithm
  {
    string Encrypt(string input);
  }
}
