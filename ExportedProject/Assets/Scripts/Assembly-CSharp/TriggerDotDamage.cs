using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000318")]
public class TriggerDotDamage : MonoBehaviour
{
	[Token(Token = "0x4001150")]
	[FieldOffset(Offset = "0x18")]
	public DamageOverTime _damageOverTime;

	[NonSerialized]
	[Token(Token = "0x4001151")]
	[FieldOffset(Offset = "0x20")]
	public long BulletID;

	[Token(Token = "0x6001304")]
	[Address(RVA = "0xC9DB5C", Offset = "0xC9DB5C", VA = "0xC9DB5C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001305")]
	[Address(RVA = "0xC9DE34", Offset = "0xC9DE34", VA = "0xC9DE34")]
	public TriggerDotDamage()
	{
	}
}
