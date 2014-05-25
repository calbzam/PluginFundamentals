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
      CompositionRoot compositionRoot = new CompositionRoot();

      ConsoleEncrypter consoleEncrypter = compositionRoot.GetConsoleEncrypter();
      consoleEncrypter.GetAndEncryptInput();

      Console.ReadLine();
    }
  }
}