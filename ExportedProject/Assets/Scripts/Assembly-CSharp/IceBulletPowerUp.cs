using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200033B")]
public class IceBulletPowerUp : PowerUp
{
	[Token(Token = "0x40011E8")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private LazyGameObject _projectileEffectToAdd;

	[Token(Token = "0x60013AE")]
	[Address(RVA = "0xA1631C", Offset = "0xA1631C", VA = "0xA1631C", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x60013AF")]
	[Address(RVA = "0xA16468", Offset = "0xA16468", VA = "0xA16468", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x60013B0")]
	[Address(RVA = "0xA165AC", Offset = "0xA165AC", VA = "0xA165AC")]
	public IceBulletPowerUp()
	{
	}
}
