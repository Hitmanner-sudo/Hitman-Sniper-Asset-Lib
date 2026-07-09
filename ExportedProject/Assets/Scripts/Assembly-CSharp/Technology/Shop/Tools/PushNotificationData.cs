using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B60")]
	public class PushNotificationData
	{
		[Token(Token = "0x2000B61")]
		public class DataKeyPair
		{
			[Token(Token = "0x40039F6")]
			[FieldOffset(Offset = "0x10")]
			public string Key;

			[Token(Token = "0x40039F7")]
			[FieldOffset(Offset = "0x18")]
			public string Value;

			[Token(Token = "0x600481D")]
			[Address(RVA = "0x8B1DFC", Offset = "0x8B1DFC", VA = "0x8B1DFC")]
			public DataKeyPair()
			{
			}
		}

		[Token(Token = "0x40039F1")]
		[FieldOffset(Offset = "0x10")]
		public int Id;

		[Token(Token = "0x40039F2")]
		[FieldOffset(Offset = "0x18")]
		public string IdList;

		[Token(Token = "0x40039F3")]
		[FieldOffset(Offset = "0x20")]
		public string Badge;

		[Token(Token = "0x40039F4")]
		[FieldOffset(Offset = "0x28")]
		public string Parameters;

		[Token(Token = "0x40039F5")]
		[FieldOffset(Offset = "0x30")]
		public List<DataKeyPair> CustomData;

		[Token(Token = "0x600481B")]
		[Address(RVA = "0xB3BBF4", Offset = "0xB3BBF4", VA = "0xB3BBF4")]
		internal static string ToJSON(PushNotificationData pushNotification)
		{
			return null;
		}

		[Token(Token = "0x600481C")]
		[Address(RVA = "0xB3C234", Offset = "0xB3C234", VA = "0xB3C234")]
		public PushNotificationData()
		{
		}
	}
}
