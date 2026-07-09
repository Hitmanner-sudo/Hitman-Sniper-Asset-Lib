using Il2CppDummyDll;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C05")]
	public class CrossPromotionRecord
	{
		[Token(Token = "0x4003BFD")]
		[FieldOffset(Offset = "0x10")]
		public string PictureUrl;

		[Token(Token = "0x4003BFE")]
		[FieldOffset(Offset = "0x18")]
		public string ApplicationAppleUrl;

		[Token(Token = "0x4003BFF")]
		[FieldOffset(Offset = "0x20")]
		public string ApplicationAndroidUrl;

		[Token(Token = "0x6004BFD")]
		[Address(RVA = "0xD87C1C", Offset = "0xD87C1C", VA = "0xD87C1C")]
		public CrossPromotionRecord()
		{
		}
	}
}
