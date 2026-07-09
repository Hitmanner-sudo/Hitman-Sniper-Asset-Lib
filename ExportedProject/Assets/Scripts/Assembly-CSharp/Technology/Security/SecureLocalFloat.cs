using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C47")]
	public class SecureLocalFloat : SecureLocalDataType4Bytes
	{
		[Token(Token = "0x4003C98")]
		[FieldOffset(Offset = "0x14")]
		private FloatUIntUnion _union;

		[Token(Token = "0x170009CF")]
		public float Value
		{
			[Token(Token = "0x6004D1F")]
			[Address(RVA = "0xB6832C", Offset = "0xB6832C", VA = "0xB6832C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6004D20")]
			[Address(RVA = "0xB68D98", Offset = "0xB68D98", VA = "0xB68D98")]
			set
			{
			}
		}

		[Token(Token = "0x6004D21")]
		[Address(RVA = "0xB682B8", Offset = "0xB682B8", VA = "0xB682B8")]
		public SecureLocalFloat(float value = 0f)
		{
		}

		[Token(Token = "0x6004D22")]
		[Address(RVA = "0xB68DA4", Offset = "0xB68DA4", VA = "0xB68DA4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
