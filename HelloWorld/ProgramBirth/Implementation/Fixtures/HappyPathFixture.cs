using HelloWorld.ProgramBirth.Contract;
using HelloWorld.ProgramBirth.Contract.Fixtures;
using HelloWorld.ProgramBirth.Dependencies.InMemoryImplementations;

namespace HelloWorld.ProgramBirth.Implementation.Fixtures
{
	public record HappyPathFixture : Fixture<IGetMessage>
	{
		public HappyPathFixture()
		{
			MessageInsideRepository = "foo bar baz";
		}
		public override IGetMessage SystemUnderTest => new GetMessage(InMemoryMessageRepository.CreateFromContent(MessageInsideRepository));
	}
}
