using System;
using Il2CppDummyDll;

namespace Technology.Core.Time
{
	[Token(Token = "0x2000CA4")]
	public static class GenuineDateTimeProxy
	{
		[Token(Token = "0x4003D74")]
		[FieldOffset(Offset = "0x0")]
		private static DateTime _serverUtcAtLastSet;

		[Token(Token = "0x4003D75")]
		[FieldOffset(Offset = "0x8")]
		private static DateTime _deviceUtcAtLastSet;

		[Token(Token = "0x4003D76")]
		[FieldOffset(Offset = "0x10")]
		private static bool _setupIsDone;

		[Token(Token = "0x170009F7")]
		public static DateTime GenuineDateTime
		{
			[Token(Token = "0x6004E4F")]
			[Address(RVA = "0xD9EF84", Offset = "0xD9EF84", VA = "0xD9EF84")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004E50")]
			[Address(RVA = "0xD9ECC4", Offset = "0xD9ECC4", VA = "0xD9ECC4")]
			set
			{
			}
		}
	}
}
