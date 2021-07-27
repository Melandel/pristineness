using HelloWorld.ProgramBirth.Dependencies.Abstraction;
using Domain.ProgramBirth;
using CrossScope.LivingDocumentation;

namespace HelloWorld.ProgramBirth.Dependencies.InMemoryImplementations
{

	[GuidedTour(ListingOf.EveryTextbookSituation, "as unit test fixtures used as a base for all fixtures")]
	public class InMemoryMessageRepository : IMessageRepository
	{
		public Message Message { get; init; }
		private InMemoryMessageRepository(Message content)
		{
			Message = content;
		}

		public static InMemoryMessageRepository CreateFromContent(string repositoryContent) => new(Message.Create(repositoryContent));

		Message IMessageRepository.Get() => Message.Create(Message.Value ?? "");
	}
}
