using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C16")]
	public class SvcOpDeleteInfocastElementInstance : SvcOpGet
	{
		[Token(Token = "0x4003C37")]
		private const string SVCOPNAME = "DeleteInfocastElementInstance";

		[Token(Token = "0x4003C38")]
		private const string QUERYSTRING_PARAM_INFOCASTID_KEY = "s_infocastid";

		[Token(Token = "0x170009B8")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004C6C")]
			[Address(RVA = "0xD36804", Offset = "0xD36804", VA = "0xD36804", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004C6B")]
		[Address(RVA = "0xD36788", Offset = "0xD36788", VA = "0xD36788")]
		public SvcOpDeleteInfocastElementInstance([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004C6D")]
		[Address(RVA = "0xD36848", Offset = "0xD36848", VA = "0xD36848")]
		public void Get(string infocastID)
		{
		}
	}
}
