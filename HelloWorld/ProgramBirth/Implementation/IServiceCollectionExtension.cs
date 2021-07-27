using HelloWorld.ProgramBirth.Contract;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorld.ProgramBirth.Implementation {
	public static class IServiceCollectionExtension {
		public static IServiceCollection ConfigureUseCaseProgramBirth(this IServiceCollection collection) {
			return collection
				.AddSingleton<IGetMessage, GetMessage>();
		}
	}
}
