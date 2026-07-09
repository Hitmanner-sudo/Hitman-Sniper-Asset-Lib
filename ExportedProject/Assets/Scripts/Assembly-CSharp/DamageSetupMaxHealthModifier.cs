using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001AF")]
public class DamageSetupMaxHealthModifier : MonoBehaviour
{
	[Token(Token = "0x4000947")]
	[FieldOffset(Offset = "0x18")]
	public ZombieGameplayConfig.DamageSetupType DamageSetupType;

	[Token(Token = "0x6000B49")]
	[Address(RVA = "0xAE24FC", Offset = "0xAE24FC", VA = "0xAE24FC")]
	public float GetDamageSetupHealthMofication()
	{
		return default(float);
	}

	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0xAE2EA8", Offset = "0xAE2EA8", VA = "0xAE2EA8")]
	public DamageSetupMaxHealthModifier()
	{
	}
}
