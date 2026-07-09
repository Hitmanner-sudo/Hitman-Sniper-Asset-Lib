using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000AC5")]
	[Scope]
	[AutoInstantiate]
	public class NativeMessageReceiver : GameSingleton<NativeMessageReceiver>
	{
		[Token(Token = "0x400372A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string GAMEOBJECT_NAME;

		[Token(Token = "0x400372B")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string RECEIVE_FUNCTION;

		[Token(Token = "0x140000BA")]
		public event NativeReceiverEventHandler OnMessageReceived
		{
			[Token(Token = "0x600433F")]
			[Address(RVA = "0xC56384", Offset = "0xC56384", VA = "0xC56384")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x625DF8", Offset = "0x625DF8")]
			add
			{
			}
			[Token(Token = "0x6004340")]
			[Address(RVA = "0xC562E4", Offset = "0xC562E4", VA = "0xC562E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x625E08", Offset = "0x625E08")]
			remove
			{
			}
		}

		[Token(Token = "0x6004341")]
		[Address(RVA = "0xC5775C", Offset = "0xC5775C", VA = "0xC5775C")]
		public void Receive(string json)
		{
		}

		[Token(Token = "0x6004342")]
		[Address(RVA = "0xC57AE4", Offset = "0xC57AE4", VA = "0xC57AE4")]
		public NativeMessageReceiver()
		{
		}
	}
}
