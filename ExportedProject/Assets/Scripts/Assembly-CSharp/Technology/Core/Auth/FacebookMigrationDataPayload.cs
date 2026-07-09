using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DA9")]
	public class FacebookMigrationDataPayload
	{
		[Token(Token = "0x400410D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BE92C", Offset = "0x5BE92C")]
		public string RemoteID;

		[Token(Token = "0x400410E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BE964", Offset = "0x5BE964")]
		public string Savegame;

		[Token(Token = "0x600542C")]
		[Address(RVA = "0x950990", Offset = "0x950990", VA = "0x950990")]
		public FacebookMigrationDataPayload()
		{
		}
	}
}
