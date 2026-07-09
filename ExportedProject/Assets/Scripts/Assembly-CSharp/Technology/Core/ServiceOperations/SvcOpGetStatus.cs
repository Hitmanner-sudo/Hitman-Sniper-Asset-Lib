using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CF7")]
	public class SvcOpGetStatus : SvcOpGet
	{
		[Token(Token = "0x17000A94")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6005028")]
			[Address(RVA = "0xD3A234", Offset = "0xD3A234", VA = "0xD3A234", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005027")]
		[Address(RVA = "0xD3A224", Offset = "0xD3A224", VA = "0xD3A224")]
		public SvcOpGetStatus([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6005029")]
		[Address(RVA = "0xD3A278", Offset = "0xD3A278", VA = "0xD3A278")]
		public new void Get()
		{
		}
	}
}
