using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x200133C")]
	public abstract class EventActionHandler
	{
		[Token(Token = "0x600712C")]
		internal abstract bool Handle(EventTrigger trigger, ActionStore store);

		[Token(Token = "0x600712D")]
		internal abstract string Type();

		[Token(Token = "0x600712E")]
		[Address(RVA = "0xE1726C", Offset = "0xE1726C", VA = "0xE1726C")]
		protected EventActionHandler()
		{
		}
	}
}
