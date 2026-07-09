using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D21")]
	internal class SvcOpPostDatabase : SvcOpPost
	{
		[Token(Token = "0x4003EC6")]
		private const string QUERYSTRING_PARAM_DATABASE_ID_KEY = "id";

		[Token(Token = "0x4003EC7")]
		private const string SVCOPNAME = "GlobalConfig_put";

		[Token(Token = "0x17000AB2")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60050F9")]
			[Address(RVA = "0xD3CEA0", Offset = "0xD3CEA0", VA = "0xD3CEA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60050F8")]
		[Address(RVA = "0xD3CE90", Offset = "0xD3CE90", VA = "0xD3CE90")]
		public SvcOpPostDatabase([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x60050FA")]
		[Address(RVA = "0xD3CEE4", Offset = "0xD3CEE4", VA = "0xD3CEE4")]
		public void Post(string databaseId, string body)
		{
		}
	}
}
