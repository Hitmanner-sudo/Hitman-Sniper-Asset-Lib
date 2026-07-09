using Il2CppDummyDll;
using Technology.Core;

namespace Technology.GooglePlayGames
{
	[Token(Token = "0x2000BA2")]
	[Attribute(Name = "ResourcePathAttribute", RVA = "0x59830C", Offset = "0x59830C")]
	public class GooglePlayGamesConfiguration : AbstractConfiguration<GooglePlayGamesConfiguration>
	{
		[Token(Token = "0x4003ABB")]
		[FieldOffset(Offset = "0x18")]
		public bool EnableGetAccountsPermission;

		[Token(Token = "0x4003ABC")]
		[FieldOffset(Offset = "0x20")]
		public string ApplicationID;

		[Token(Token = "0x4003ABD")]
		[FieldOffset(Offset = "0x28")]
		public string ClientID;

		[Token(Token = "0x4003ABE")]
		[FieldOffset(Offset = "0x30")]
		public string BundleID;

		[Token(Token = "0x4003ABF")]
		[FieldOffset(Offset = "0x38")]
		public string[] LeaderboardIds;

		[Token(Token = "0x60049F8")]
		[Address(RVA = "0xC8504C", Offset = "0xC8504C", VA = "0xC8504C")]
		public GooglePlayGamesConfiguration()
		{
		}
	}
}
