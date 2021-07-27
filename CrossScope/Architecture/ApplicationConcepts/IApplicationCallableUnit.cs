namespace CrossScope.Architecture.ApplicationConcepts {
	public interface IHelloWorldCallableUnit<TAppRequest, TAppResponse>
		where TAppRequest : HelloWorldInput
		where TAppResponse : HelloWorldOutput {
		TAppResponse Process(TAppRequest request);
	}
}
