using System;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E59")]
	public interface IAnalyticModule
	{
		[Token(Token = "0x6005866")]
		void SendEvent(EventKey eventKey, EventAttribute[] attributes, Action<EventAttribute> additionalAction);

		[Token(Token = "0x6005867")]
		bool IsInitialized();

		[Token(Token = "0x6005868")]
		void Initialize(ISvcOpConfig OSGameConfig, IPersistanceServices persistanceServices);

		[Token(Token = "0x6005869")]
		void Destroy();

		[Token(Token = "0x600586A")]
		void Flush(bool isAsync);

		[Token(Token = "0x600586B")]
		void Reset(ISvcOpConfig OSGameConfig, IPersistanceServices persistanceServices, bool isAsync = true);

		[Token(Token = "0x600586C")]
		void OnApplicationPause();

		[Token(Token = "0x600586D")]
		void OnApplicationResume();

		[Token(Token = "0x600586E")]
		void OnApplicationQuit();

		[Token(Token = "0x600586F")]
		void OnUpdate();
	}
}
