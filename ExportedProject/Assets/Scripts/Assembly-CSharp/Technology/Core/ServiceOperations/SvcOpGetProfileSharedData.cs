using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CA5")]
	public class SvcOpGetProfileSharedData : SvcOpGet
	{
		[Token(Token = "0x170009F8")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004E52")]
			[Address(RVA = "0xD39B9C", Offset = "0xD39B9C", VA = "0xD39B9C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004E53")]
		[Address(RVA = "0xD39BE0", Offset = "0xD39BE0", VA = "0xD39BE0")]
		public SvcOpGetProfileSharedData([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x6004E54")]
		[Address(RVA = "0xD39BF0", Offset = "0xD39BF0", VA = "0xD39BF0")]
		public void Get(string uid)
		{
		}
	}
}
