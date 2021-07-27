using HelloWorld.ProgramBirth.Dependencies.Abstraction;
using Domain.ProgramBirth;

namespace HelloWorldConsole.ProgramBirth.Dependencies {
	public class MessageRepository : IMessageRepository {
		public Message Get() => Message.Create("Hello World!");
	}
}
