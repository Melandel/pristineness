using CrossScope.Architecture.ApplicationConcepts;
using CrossScope.LivingDocumentation;
#if COMPILE_TESTS
using Xunit;
using HelloWorld.ProgramBirth.Contract.Fixtures;
#endif

namespace HelloWorld.ProgramBirth.Contract
{
	[GuidedTour(ListingOf.EveryUseCaseInTheApplication, "as filenames in this Contract folder", "ls HelloWorld/*/Contract/*.cs")]
	[GuidedTour(EvolutionOf.TheApplication, "in the version control of this folder", "git log HelloWorld/*/Contract/I*.cs", "git log -p HelloWorld/*/Contract/I*.cs")]
	public interface IGetMessage : IHelloWorldCallableUnit<IGetMessage.Input, IGetMessage.Output>
	{
		public record Input : HelloWorldInput;
		public record Output(string Message) : HelloWorldOutput;

#if COMPILE_TESTS
		[GuidedTour(SpecificationOf.TheApplicationBehavior, "as unit tests at the interface level")]
		public abstract class Behavior : UseCaseBehavior<IGetMessage, Fixture<IGetMessage>>
		{
			[Fact]
			protected virtual void ReturnTheMessage()
			{
				var fixture = HappyPathFixture;
				var result = fixture.SystemUnderTest.Process(new());
				Assert.Equal(HappyPathFixture.MessageInsideRepository, result.Message);
			}

			[Fact]
			protected virtual void ReturnEmptyString_WhenMessageIsNull()
			{
				var fixture = HappyPathFixture with
				{
					MessageInsideRepository = null
				};
				var result = fixture.SystemUnderTest.Process(new());
				Assert.Equal("", result.Message);
			}
		}
#endif
	}
}
