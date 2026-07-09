using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C36")]
	public abstract class RuntimeSecurity
	{
		[Token(Token = "0x4003C89")]
		[FieldOffset(Offset = "0x0")]
		private static RuntimeSecurity _instance;

		[Token(Token = "0x4003C8A")]
		[FieldOffset(Offset = "0x10")]
		private bool _initialized;

		[Token(Token = "0x170009C5")]
		private static RuntimeSecurity Instance
		{
			[Token(Token = "0x6004CEA")]
			[Address(RVA = "0xBA7348", Offset = "0xBA7348", VA = "0xBA7348")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004CEB")]
		[Address(RVA = "0xBA7474", Offset = "0xBA7474", VA = "0xBA7474")]
		public static void Init()
		{
		}

		[Token(Token = "0x6004CEC")]
		[Address(RVA = "0xBA73A8", Offset = "0xBA73A8", VA = "0xBA73A8")]
		private static RuntimeSecurity Create()
		{
			return null;
		}

		[Token(Token = "0x6004CED")]
		protected abstract void RegisterSecurityFilters();

		[Token(Token = "0x6004CEE")]
		[Address(RVA = "0xBA74C4", Offset = "0xBA74C4", VA = "0xBA74C4")]
		protected RuntimeSecurity()
		{
		}
	}
}
