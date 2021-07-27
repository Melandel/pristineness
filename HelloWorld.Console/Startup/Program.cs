using System;
using System.Threading.Tasks;
using HelloWorld.ProgramBirth.Contract;
using HelloWorld.ProgramBirth.Implementation;
using HelloWorldConsole.ProgramBirth.Dependencies;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorldConsole.Startup {
	class Program {
		public async static Task Main(string[] args) {
			await using var serviceProvider = BuildServiceProvider();
			var useCaseObject = serviceProvider.GetService<IGetMessage>();
			var input = new IGetMessage.Input();
			var output = useCaseObject.Process(input);
			Console.WriteLine(output.Message);
		}

		private static ServiceProvider BuildServiceProvider()
		=> new ServiceCollection()
			.ConfigureUseCaseProgramBirth()
			.ConfigureUseCaseProgramBirthDependencies()
			.BuildServiceProvider();
	}
}
