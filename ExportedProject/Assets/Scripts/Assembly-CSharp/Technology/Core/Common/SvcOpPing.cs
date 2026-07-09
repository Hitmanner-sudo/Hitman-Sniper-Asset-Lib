using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DF7")]
	public class SvcOpPing : SvcOpGet
	{
		[Token(Token = "0x4004238")]
		private const string SVCOPNAME = "os_Ping";

		[Token(Token = "0x17000B6B")]
		protected override bool SkipOSFailureCheck
		{
			[Token(Token = "0x60055EE")]
			[Address(RVA = "0xD3CDE4", Offset = "0xD3CDE4", VA = "0xD3CDE4", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B6C")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60055F0")]
			[Address(RVA = "0xD3CE1C", Offset = "0xD3CE1C", VA = "0xD3CE1C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60055EF")]
		[Address(RVA = "0xD3CDEC", Offset = "0xD3CDEC", VA = "0xD3CDEC")]
		public SvcOpPing([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x60055F1")]
		[Address(RVA = "0xD3CE60", Offset = "0xD3CE60", VA = "0xD3CE60")]
		public void GetPing()
		{
		}
	}
}
