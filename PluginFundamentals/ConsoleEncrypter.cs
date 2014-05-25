﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFundamentals
{
  public class ConsoleEncrypter
  {
    private readonly IEncryptionAlgorithm encryptionAlgorithm;

    public ConsoleEncrypter(IEncryptionAlgorithm encryptionAlgorithm)
    {
      this.encryptionAlgorithm = encryptionAlgorithm;
    }

    public void GetAndEncryptInput()
    {
      // Get input
      string input = Console.ReadLine().ToUpper();

      // "Encrypt" it
      string output = encryptionAlgorithm.Encrypt(input);

      // Write output
      Console.WriteLine(output);
    }
  }
}
