using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D20")]
	internal class SvcOpGetDatabase : SvcOpGet
	{
		[Token(Token = "0x4003EC4")]
		private const string QUERYSTRING_PARAM_DATABASE_ID_KEY = "id";

		[Token(Token = "0x4003EC5")]
		private const string SVCOPNAME = "GlobalConfig_get";

		[Token(Token = "0x17000AB1")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60050F6")]
			[Address(RVA = "0xD3789C", Offset = "0xD3789C", VA = "0xD3789C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60050F5")]
		[Address(RVA = "0xD3788C", Offset = "0xD3788C", VA = "0xD3788C")]
		public SvcOpGetDatabase([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x60050F7")]
		[Address(RVA = "0xD378E0", Offset = "0xD378E0", VA = "0xD378E0")]
		public void Get(string databaseId)
		{
		}
	}
}
