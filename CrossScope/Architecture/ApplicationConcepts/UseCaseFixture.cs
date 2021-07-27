namespace CrossScope.Architecture.ApplicationConcepts {
	public abstract record UseCaseFixture<T> {
		public abstract T SystemUnderTest { get; }
	}
}

