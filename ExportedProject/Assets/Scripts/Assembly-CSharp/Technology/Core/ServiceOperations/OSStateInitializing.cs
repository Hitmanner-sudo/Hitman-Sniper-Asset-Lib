using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CB1")]
	public class OSStateInitializing : IOSState
	{
		[Token(Token = "0x2000CB2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5987CC", Offset = "0x5987CC")]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			[Token(Token = "0x4003D8B")]
			[FieldOffset(Offset = "0x10")]
			public OnlineSuite os;

			[Token(Token = "0x6004E8D")]
			[Address(RVA = "0x8CCC9C", Offset = "0x8CCC9C", VA = "0x8CCC9C")]
			public _003C_003Ec__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6004E8E")]
			[Address(RVA = "0x8CCCA4", Offset = "0x8CCCA4", VA = "0x8CCCA4")]
			internal void _003CStart_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x6004E8A")]
		[Address(RVA = "0x9E949C", Offset = "0x9E949C", VA = "0x9E949C", Slot = "4")]
		public void Start(OnlineSuite os)
		{
		}

		[Token(Token = "0x6004E8B")]
		[Address(RVA = "0x9E959C", Offset = "0x9E959C", VA = "0x9E959C", Slot = "5")]
		public void HandleInitialize(OnlineSuite os)
		{
		}

		[Token(Token = "0x6004E8C")]
		[Address(RVA = "0x9E93C0", Offset = "0x9E93C0", VA = "0x9E93C0")]
		public OSStateInitializing()
		{
		}
	}
}
