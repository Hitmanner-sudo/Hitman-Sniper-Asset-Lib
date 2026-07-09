using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Events
{
	[Token(Token = "0x2000A13")]
	public interface IEventsClient
	{
		[Token(Token = "0x6003FB6")]
		void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback);

		[Token(Token = "0x6003FB7")]
		void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback);

		[Token(Token = "0x6003FB8")]
		void IncrementEvent(string eventId, uint stepsToIncrement);
	}
}
