using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DA8")]
	public class FacebookMigrationData
	{
		[Token(Token = "0x400410A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BE884", Offset = "0x5BE884")]
		public string Error;

		[Token(Token = "0x400410B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BE8BC", Offset = "0x5BE8BC")]
		public int ErrorCode;

		[Token(Token = "0x400410C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BE8F4", Offset = "0x5BE8F4")]
		public Dictionary<string, object> Payload;

		[Token(Token = "0x600542B")]
		[Address(RVA = "0x950988", Offset = "0x950988", VA = "0x950988")]
		public FacebookMigrationData()
		{
		}
	}
}
