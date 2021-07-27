namespace CrossScope.Architecture.ApplicationConcepts {
	public abstract class UseCaseBehavior<TSut, TFixture> where TFixture : UseCaseFixture<TSut> {
		public abstract TFixture[] Fixtures { get; }
		public TFixture HappyPathFixture => Fixtures[0];
	}
}

