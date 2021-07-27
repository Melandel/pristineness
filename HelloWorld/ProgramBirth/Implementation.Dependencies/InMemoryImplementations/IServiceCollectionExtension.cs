using HelloWorld.ProgramBirth.Dependencies.Abstraction;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorld.ProgramBirth.Dependencies.InMemoryImplementations {
	public static class IServiceCollectionExtension {
		public static IServiceCollection ConfigureUseCaseProgramBirthDependencies(this IServiceCollection collection) {
			return collection
				.AddSingleton<IMessageRepository, InMemoryMessageRepository>();
		}
	}
}
