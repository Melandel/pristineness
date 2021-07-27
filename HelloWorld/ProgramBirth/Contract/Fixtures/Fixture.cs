using CrossScope.Architecture.ApplicationConcepts;

namespace HelloWorld.ProgramBirth.Contract.Fixtures
{
	public abstract record Fixture<T> : UseCaseFixture<T>
	{
		public string MessageInsideRepository { get; init; }
	}
}
