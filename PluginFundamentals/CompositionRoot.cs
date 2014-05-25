﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using Ninject;
using Ninject.Extensions.Conventions;
using PluginFundamentals.Abstraction;

namespace PluginFundamentals
{
  public class CompositionRoot
  {
    private IKernel container;

    public CompositionRoot()
    {
      container = new StandardKernel();

      // Doesn't work! No reference to Rot13 anywhere.
      //container.Bind<IEncryptionAlgorithm>().To<Rot13>();
      //container.Bind<IEncryptionAlgorithm>().To<Leet>();
      //container.Bind<IEncryptionAlgorithm>().To<Another>();
      //container.Bind<IEncryptionAlgorithm>().To<Fourth>();

      string pluginsPath = Path.Combine(Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath), "plugins\\");

      if (!Directory.Exists(pluginsPath)) Directory.CreateDirectory(pluginsPath);
      // Requires Ninject.Extensions.Conventions

      container.Bind(x => x.FromAssembliesInPath(pluginsPath)
        // For each assembly (.dll/.exe) in folder
          .SelectAllClasses()
        // Select every class in every assembly
          .InheritedFrom<IEncryptionAlgorithm>()
        // And for any classes that implement IEncryptionAlgorithm
          .BindAllInterfaces()
        // do Bind<IEncryptionAlgorithm>().To<ThoseClasses>();
      );

      List<IEncryptionAlgorithm> allPlugins = container.GetAll<IEncryptionAlgorithm>().ToList();
      IEncryptionAlgorithm firstPlugin = allPlugins.First();
      container.Rebind<IEncryptionAlgorithm>().ToConstant(firstPlugin);
    }

    public ConsoleEncrypter GetConsoleEncrypter()
    {
      return container.Get<ConsoleEncrypter>();
    }
  }

}
