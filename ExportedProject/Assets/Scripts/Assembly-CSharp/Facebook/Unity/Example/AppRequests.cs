using Il2CppDummyDll;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x20012DE")]
	internal class AppRequests : MenuBase
	{
		[Token(Token = "0x4005A67")]
		[FieldOffset(Offset = "0x60")]
		private string requestMessage;

		[Token(Token = "0x4005A68")]
		[FieldOffset(Offset = "0x68")]
		private string requestTo;

		[Token(Token = "0x4005A69")]
		[FieldOffset(Offset = "0x70")]
		private string requestFilter;

		[Token(Token = "0x4005A6A")]
		[FieldOffset(Offset = "0x78")]
		private string requestExcludes;

		[Token(Token = "0x4005A6B")]
		[FieldOffset(Offset = "0x80")]
		private string requestMax;

		[Token(Token = "0x4005A6C")]
		[FieldOffset(Offset = "0x88")]
		private string requestData;

		[Token(Token = "0x4005A6D")]
		[FieldOffset(Offset = "0x90")]
		private string requestTitle;

		[Token(Token = "0x4005A6E")]
		[FieldOffset(Offset = "0x98")]
		private string requestObjectID;

		[Token(Token = "0x4005A6F")]
		[FieldOffset(Offset = "0xA0")]
		private int selectedAction;

		[Token(Token = "0x4005A70")]
		[FieldOffset(Offset = "0xA8")]
		private string[] actionTypeStrings;

		[Token(Token = "0x6006E2C")]
		[Address(RVA = "0xD481D8", Offset = "0xD481D8", VA = "0xD481D8", Slot = "5")]
		protected override void GetGui()
		{
		}

		[Token(Token = "0x6006E2D")]
		[Address(RVA = "0xD48D24", Offset = "0xD48D24", VA = "0xD48D24")]
		private OGActionType? GetSelectedOGActionType()
		{
			return null;
		}

		[Token(Token = "0x6006E2E")]
		[Address(RVA = "0xD48EF4", Offset = "0xD48EF4", VA = "0xD48EF4")]
		public AppRequests()
		{
		}
	}
}
