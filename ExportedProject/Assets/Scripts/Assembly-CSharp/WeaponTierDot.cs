using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007B2")]
public class WeaponTierDot : MonoBehaviour
{
	[Token(Token = "0x4002B55")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Active;

	[Token(Token = "0x4002B56")]
	[FieldOffset(Offset = "0x20")]
	public GameObject NotActive;

	[Token(Token = "0x4002B57")]
	[FieldOffset(Offset = "0x28")]
	public int DotTier;

	[Token(Token = "0x60032C3")]
	[Address(RVA = "0x879398", Offset = "0x879398", VA = "0x879398")]
	public void SetActiveTier(int activeTier)
	{
	}

	[Token(Token = "0x60032C4")]
	[Address(RVA = "0x8793F4", Offset = "0x8793F4", VA = "0x8793F4")]
	public WeaponTierDot()
	{
	}
}
