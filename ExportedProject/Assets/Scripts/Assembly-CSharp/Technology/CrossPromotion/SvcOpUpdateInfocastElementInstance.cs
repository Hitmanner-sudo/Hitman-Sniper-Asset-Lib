using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C1D")]
	public class SvcOpUpdateInfocastElementInstance : SvcOpPost
	{
		[Token(Token = "0x4003C4D")]
		private const string SVCOPNAME = "UpdateInfocastElementInstance";

		[Token(Token = "0x4003C4E")]
		public const string QUERYSTRING_PARAM_INFOCASTID_KEY = "s_infocastid";

		[Token(Token = "0x170009BF")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004C81")]
			[Address(RVA = "0xB48980", Offset = "0xB48980", VA = "0xB48980", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004C80")]
		[Address(RVA = "0xB4896C", Offset = "0xB4896C", VA = "0xB4896C")]
		public SvcOpUpdateInfocastElementInstance([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004C82")]
		[Address(RVA = "0xB489C4", Offset = "0xB489C4", VA = "0xB489C4")]
		public void Post(string infocastID, string jsonParams)
		{
		}
	}
}
