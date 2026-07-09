using System;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DEE")]
	public class NetworkEvent : EventArgs
	{
		[Token(Token = "0x4004220")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF484", Offset = "0x5BF484")]
		private bool _003CIsReachable_003Ek__BackingField;

		[Token(Token = "0x17000B5E")]
		public bool IsReachable
		{
			[Token(Token = "0x60055B7")]
			[Address(RVA = "0xC596BC", Offset = "0xC596BC", VA = "0xC596BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AEB0", Offset = "0x62AEB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60055B8")]
			[Address(RVA = "0xC596C4", Offset = "0xC596C4", VA = "0xC596C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AEC0", Offset = "0x62AEC0")]
			private set
			{
			}
		}

		[Token(Token = "0x60055B9")]
		[Address(RVA = "0xC596D0", Offset = "0xC596D0", VA = "0xC596D0")]
		public NetworkEvent(bool state)
		{
		}
	}
}
