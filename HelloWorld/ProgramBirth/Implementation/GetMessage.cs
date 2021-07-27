using HelloWorld.ProgramBirth.Contract;
using HelloWorld.ProgramBirth.Dependencies.Abstraction;
#if COMPILE_TESTS
using HelloWorld.ProgramBirth.Contract.Fixtures;
using HelloWorld.ProgramBirth.Implementation.Fixtures;
#endif

namespace HelloWorld.ProgramBirth.Implementation
{
	public class GetMessage : IGetMessage
	{
		private readonly IMessageRepository _messageRepository;
		public GetMessage(IMessageRepository messageRepository)
		{
			_messageRepository = messageRepository;
		}


		public IGetMessage.Output Process(IGetMessage.Input request) => new(_messageRepository.Get().Value);


#if COMPILE_TESTS
		public class Should : IGetMessage.Behavior {
			public override Fixture<IGetMessage>[] Fixtures => new [] {
				new HappyPathFixture()
			};
		}
#endif
	}
}
