using Il2CppDummyDll;

namespace Technology.Distribution
{
	[Token(Token = "0x2000C03")]
	public class ValidatorState
	{
		[Token(Token = "0x4003BF9")]
		[FieldOffset(Offset = "0x10")]
		public string Error;

		[Token(Token = "0x4003BFA")]
		[FieldOffset(Offset = "0x18")]
		public ValidatorStates State;

		[Token(Token = "0x6004BFB")]
		[Address(RVA = "0x13C5BD0", Offset = "0x13C5BD0", VA = "0x13C5BD0")]
		public ValidatorState(ValidatorStates state, string error = "")
		{
		}

		[Token(Token = "0x6004BFC")]
		[Address(RVA = "0x13C5C0C", Offset = "0x13C5C0C", VA = "0x13C5C0C")]
		public bool IsValid()
		{
			return default(bool);
		}
	}
}
