using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200037E")]
public class PropagateEffect : MonoBehaviour
{
	[Token(Token = "0x4001373")]
	[FieldOffset(Offset = "0x18")]
	public PropagateObject ObjectsToSpawn;

	[Token(Token = "0x4001374")]
	[FieldOffset(Offset = "0x20")]
	public int EffectCount;

	[Token(Token = "0x4001375")]
	[FieldOffset(Offset = "0x24")]
	public float Distance;

	[Token(Token = "0x4001376")]
	[FieldOffset(Offset = "0x28")]
	public float Angle;

	[Token(Token = "0x4001377")]
	[FieldOffset(Offset = "0x2C")]
	private float _duration;

	[NonSerialized]
	[Token(Token = "0x4001378")]
	[FieldOffset(Offset = "0x30")]
	public long BulletID;

	[Token(Token = "0x4001379")]
	[FieldOffset(Offset = "0x38")]
	private float _destroyOnTime;

	[Token(Token = "0x17000331")]
	public float Duration
	{
		[Token(Token = "0x600154C")]
		[Address(RVA = "0xB3A71C", Offset = "0xB3A71C", VA = "0xB3A71C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600154D")]
		[Address(RVA = "0xB3A724", Offset = "0xB3A724", VA = "0xB3A724")]
		set
		{
		}
	}

	[Token(Token = "0x600154E")]
	[Address(RVA = "0xB3A7F4", Offset = "0xB3A7F4", VA = "0xB3A7F4")]
	private void Start()
	{
	}

	[Token(Token = "0x600154F")]
	[Address(RVA = "0xB3ABD4", Offset = "0xB3ABD4", VA = "0xB3ABD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001550")]
	[Address(RVA = "0xB3AC94", Offset = "0xB3AC94", VA = "0xB3AC94")]
	private void Update()
	{
	}

	[Token(Token = "0x6001551")]
	[Address(RVA = "0xB3A9FC", Offset = "0xB3A9FC", VA = "0xB3A9FC")]
	private void AddEffect(Vector3 force)
	{
	}

	[Token(Token = "0x6001552")]
	[Address(RVA = "0xB3AE88", Offset = "0xB3AE88", VA = "0xB3AE88")]
	public void SetPropagateData(float radius, float duration)
	{
	}

	[Token(Token = "0x6001553")]
	[Address(RVA = "0xB3AE94", Offset = "0xB3AE94", VA = "0xB3AE94")]
	public PropagateEffect()
	{
	}
}
