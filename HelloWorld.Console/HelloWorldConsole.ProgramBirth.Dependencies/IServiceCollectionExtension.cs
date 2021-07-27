using HelloWorld.ProgramBirth.Dependencies.Abstraction;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorldConsole.ProgramBirth.Dependencies {
	public static class IServiceCollectionExtension {
		public static IServiceCollection ConfigureUseCaseProgramBirthDependencies(this IServiceCollection collection) {
			return collection
				.AddSingleton<IMessageRepository, MessageRepository>();
		}
	}
}
