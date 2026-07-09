using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200037F")]
public class PropagateObject : MonoBehaviour
{
	[Token(Token = "0x400137A")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody RigidBodyRef;

	[Token(Token = "0x400137B")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem ParticleSystemRef;

	[Token(Token = "0x400137C")]
	[FieldOffset(Offset = "0x28")]
	public StickyObject StickyObjectRef;

	[Token(Token = "0x400137D")]
	[FieldOffset(Offset = "0x30")]
	private float _duration;

	[Token(Token = "0x400137E")]
	[FieldOffset(Offset = "0x34")]
	private float _destroyOnTime;

	[Token(Token = "0x17000332")]
	public float Duration
	{
		[Token(Token = "0x6001554")]
		[Address(RVA = "0xB3AEB8", Offset = "0xB3AEB8", VA = "0xB3AEB8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001555")]
		[Address(RVA = "0xB3ADB8", Offset = "0xB3ADB8", VA = "0xB3ADB8")]
		set
		{
		}
	}

	[Token(Token = "0x6001556")]
	[Address(RVA = "0xB3AEC0", Offset = "0xB3AEC0", VA = "0xB3AEC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001557")]
	[Address(RVA = "0xB3AF80", Offset = "0xB3AF80", VA = "0xB3AF80")]
	private void Update()
	{
	}

	[Token(Token = "0x6001558")]
	[Address(RVA = "0xB3B0AC", Offset = "0xB3B0AC", VA = "0xB3B0AC")]
	private void DetachEffect()
	{
	}

	[Token(Token = "0x6001559")]
	[Address(RVA = "0xB3B164", Offset = "0xB3B164", VA = "0xB3B164")]
	public PropagateObject()
	{
	}
}
