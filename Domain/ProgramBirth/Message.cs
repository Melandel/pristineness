using CrossScope.Architecture.DomainConcepts;

namespace Domain.ProgramBirth
{
	public record Message : ValueObject
	{
		public string Value { get; init; }
		private Message(string message)
		{
			Value = message;
		}

		public static Message Create(string message)
			=> new(message);
	}
}
