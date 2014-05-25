﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFundamentals
{
  class Program
  {
    static void Main(string[] args)
    {
      // Set up variables
      IEncryptionAlgorithm encryptionAlgorithm = new Rot13();
      ConsoleEncrypter consoleEncrypter = new ConsoleEncrypter(encryptionAlgorithm);

      // Do the program logic
      consoleEncrypter.GetAndEncryptInput();

      Console.ReadLine();
    }
  }
}