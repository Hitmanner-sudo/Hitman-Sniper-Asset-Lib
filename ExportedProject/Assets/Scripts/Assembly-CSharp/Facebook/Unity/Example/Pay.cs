using Il2CppDummyDll;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x20012E4")]
	internal class Pay : MenuBase
	{
		[Token(Token = "0x4005A8A")]
		[FieldOffset(Offset = "0x60")]
		private string payProduct;

		[Token(Token = "0x6006E44")]
		[Address(RVA = "0x8FCB64", Offset = "0x8FCB64", VA = "0x8FCB64", Slot = "5")]
		protected override void GetGui()
		{
		}

		[Token(Token = "0x6006E45")]
		[Address(RVA = "0x8FCBF4", Offset = "0x8FCBF4", VA = "0x8FCBF4")]
		private void CallFBPay()
		{
		}

		[Token(Token = "0x6006E46")]
		[Address(RVA = "0x8FCCCC", Offset = "0x8FCCCC", VA = "0x8FCCCC")]
		public Pay()
		{
		}
	}
}
