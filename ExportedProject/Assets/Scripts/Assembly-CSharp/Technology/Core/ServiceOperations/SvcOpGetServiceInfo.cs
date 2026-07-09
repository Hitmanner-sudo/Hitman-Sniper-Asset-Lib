using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CF6")]
	public class SvcOpGetServiceInfo : SvcOpGet
	{
		[Token(Token = "0x17000A93")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6005025")]
			[Address(RVA = "0xD3A1DC", Offset = "0xD3A1DC", VA = "0xD3A1DC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005024")]
		[Address(RVA = "0xD3A1CC", Offset = "0xD3A1CC", VA = "0xD3A1CC")]
		public SvcOpGetServiceInfo([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6005026")]
		[Address(RVA = "0xD3A220", Offset = "0xD3A220", VA = "0xD3A220")]
		public new void Get()
		{
		}
	}
}
