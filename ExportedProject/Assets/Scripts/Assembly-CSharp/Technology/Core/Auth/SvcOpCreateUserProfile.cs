using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DBF")]
	public sealed class SvcOpCreateUserProfile : SvcOpPost
	{
		[Token(Token = "0x40041B3")]
		private const string SVCOPNAME = "CreateUserProfile";

		[Token(Token = "0x17000B3B")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x60054B9")]
			[Address(RVA = "0xD366E0", Offset = "0xD366E0", VA = "0xD366E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054B8")]
		[Address(RVA = "0xD366D0", Offset = "0xD366D0", VA = "0xD366D0")]
		public SvcOpCreateUserProfile([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x60054BA")]
		[Address(RVA = "0xD36724", Offset = "0xD36724", VA = "0xD36724")]
		public new void Post()
		{
		}
	}
}
