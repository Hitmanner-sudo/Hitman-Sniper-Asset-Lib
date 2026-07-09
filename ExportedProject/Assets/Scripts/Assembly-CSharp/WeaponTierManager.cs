using Il2CppDummyDll;
using Technology.Core;
using UnityEngine;

[Token(Token = "0x20007C2")]
[Attribute(Name = "ResourcePathAttribute", RVA = "0x596244", Offset = "0x596244")]
public class WeaponTierManager : ScriptableSingleton<WeaponTierManager>
{
	[Token(Token = "0x4002B86")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private WeaponTier[] _tiers;

	[Token(Token = "0x17000694")]
	public WeaponTier[] Tiers
	{
		[Token(Token = "0x6003317")]
		[Address(RVA = "0x8793FC", Offset = "0x8793FC", VA = "0x8793FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003318")]
	[Address(RVA = "0x879404", Offset = "0x879404", VA = "0x879404")]
	public WeaponTier GetTierForLazyWeapon(LazyWeaponUnlockable weapon)
	{
		return null;
	}

	[Token(Token = "0x6003319")]
	[Address(RVA = "0x8794CC", Offset = "0x8794CC", VA = "0x8794CC")]
	public float GetCurrentFullyMasteredScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x600331A")]
	[Address(RVA = "0x879560", Offset = "0x879560", VA = "0x879560")]
	public float GetMaxFullyMasteredScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x600331B")]
	[Address(RVA = "0x8795CC", Offset = "0x8795CC", VA = "0x8795CC")]
	public WeaponTierManager()
	{
	}
}
