using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D1F")]
	public class SvcOpUpdateGlobalItem : SvcOpPost
	{
		[Token(Token = "0x4003EC2")]
		private const string SVCOPNAME = "os_UpdateGlobalItem";

		[Token(Token = "0x4003EC3")]
		private const string GLOBAL_ITEM_ID = "i64_globalItemId";

		[Token(Token = "0x17000AB0")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60050F3")]
			[Address(RVA = "0xB48810", Offset = "0xB48810", VA = "0xB48810", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60050F2")]
		[Address(RVA = "0xB48790", Offset = "0xB48790", VA = "0xB48790")]
		public SvcOpUpdateGlobalItem([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60050F4")]
		[Address(RVA = "0xB48854", Offset = "0xB48854", VA = "0xB48854")]
		public void Post(string jsonBody, ulong globalItemID)
		{
		}
	}
}
