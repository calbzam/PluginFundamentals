using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFundamentals
{
  public class CompositionRoot
  {
    public ConsoleEncrypter GetConsoleEncrypter()
    {
      IEncryptionAlgorithm encryptionAlgorithm = new Rot13();
      ConsoleEncrypter consoleEncrypter = new ConsoleEncrypter(encryptionAlgorithm);

      return consoleEncrypter;
    }
  }
}
