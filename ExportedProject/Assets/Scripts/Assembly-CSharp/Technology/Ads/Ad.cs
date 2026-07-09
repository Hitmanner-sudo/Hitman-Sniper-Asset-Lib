using System;
using Il2CppDummyDll;

namespace Technology.Ads
{
	[Token(Token = "0x2000E66")]
	public abstract class Ad
	{
		[Token(Token = "0x17000BF3")]
		public abstract bool HasAdAvailable
		{
			[Token(Token = "0x60058BA")]
			get;
		}

		[Token(Token = "0x1400017E")]
		[method: Token(Token = "0x60058B4")]
		[method: AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BB68", Offset = "0x62BB68")]
		public abstract event Action OnAdOpened;

		[Token(Token = "0x1400017F")]
		[method: Token(Token = "0x60058B6")]
		[method: AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BB88", Offset = "0x62BB88")]
		public abstract event Action<string> OnAdFailedToOpen;

		[Token(Token = "0x14000180")]
		[method: Token(Token = "0x60058B8")]
		[method: AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BBA8", Offset = "0x62BBA8")]
		public abstract event Action<bool> OnAdClosed;

		[Token(Token = "0x60058BB")]
		public abstract void Show();

		[Token(Token = "0x60058BC")]
		[Address(RVA = "0xD5BF20", Offset = "0xD5BF20", VA = "0xD5BF20")]
		protected Ad()
		{
		}
	}
}
