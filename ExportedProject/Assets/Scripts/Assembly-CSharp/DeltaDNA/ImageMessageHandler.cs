using System;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x200133E")]
	public class ImageMessageHandler : EventActionHandler
	{
		[Token(Token = "0x4005C26")]
		[FieldOffset(Offset = "0x10")]
		private readonly DDNA ddna;

		[Token(Token = "0x4005C27")]
		[FieldOffset(Offset = "0x18")]
		private readonly Action<ImageMessage> callback;

		[Token(Token = "0x6007132")]
		[Address(RVA = "0xA18BF4", Offset = "0xA18BF4", VA = "0xA18BF4")]
		public ImageMessageHandler(DDNA ddna, Action<ImageMessage> callback)
		{
		}

		[Token(Token = "0x6007133")]
		[Address(RVA = "0xA18C2C", Offset = "0xA18C2C", VA = "0xA18C2C", Slot = "4")]
		internal override bool Handle(EventTrigger trigger, ActionStore store)
		{
			return default(bool);
		}

		[Token(Token = "0x6007134")]
		[Address(RVA = "0xA18E38", Offset = "0xA18E38", VA = "0xA18E38", Slot = "5")]
		internal override string Type()
		{
			return null;
		}
	}
}
