using Il2CppDummyDll;
using Technology.Security;
using UnityEngine;

[Token(Token = "0x20007BF")]
public class TechnologyHooks : MonoBehaviour
{
	[Token(Token = "0x20007C0")]
	public class SniperRuntimeSecurity : RuntimeSecurity
	{
		[Token(Token = "0x6003308")]
		[Address(RVA = "0xA556F0", Offset = "0xA556F0", VA = "0xA556F0", Slot = "4")]
		protected override void RegisterSecurityFilters()
		{
		}

		[Token(Token = "0x6003309")]
		[Address(RVA = "0xA556F8", Offset = "0xA556F8", VA = "0xA556F8")]
		public SniperRuntimeSecurity()
		{
		}
	}

	[Token(Token = "0x6003303")]
	[Address(RVA = "0xB591F8", Offset = "0xB591F8", VA = "0xB591F8")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6003304")]
	[Address(RVA = "0xB59408", Offset = "0xB59408", VA = "0xB59408")]
	private static void RegisterShopModules()
	{
	}

	[Token(Token = "0x6003305")]
	[Address(RVA = "0xB59324", Offset = "0xB59324", VA = "0xB59324")]
	private static void RegisterAuthenticationModules()
	{
	}

	[Token(Token = "0x6003306")]
	[Address(RVA = "0xB59578", Offset = "0xB59578", VA = "0xB59578")]
	private static void RegisterEncryptionModules()
	{
	}

	[Token(Token = "0x6003307")]
	[Address(RVA = "0xB597D0", Offset = "0xB597D0", VA = "0xB597D0")]
	public TechnologyHooks()
	{
	}
}
