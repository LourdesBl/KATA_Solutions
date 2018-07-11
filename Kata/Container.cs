using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using IContainer = System.ComponentModel.IContainer;

namespace Kata
{
	public class Container
	{

		public static Autofac.IContainer ConfigureContainer()
		{
			var builder = new ContainerBuilder();

			// Register all dependencies
			builder.RegisterType<Program>().AsSelf();
			builder.RegisterType<KataSolutions>().As<IKataSolutions>();
			builder.RegisterType<MoreSolutions>().As<IMoreSolutions>();

			return builder.Build();
		}

		
	}
}
