using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002F7")]
public class ExplodeOnProximity : MonoBehaviour
{
	[Token(Token = "0x20002F8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5932E4", Offset = "0x5932E4")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x400104B")]
		[FieldOffset(Offset = "0x10")]
		public ThirdPersonCharacter thirdPersonCharacter;

		[Token(Token = "0x6001236")]
		[Address(RVA = "0x86FC70", Offset = "0x86FC70", VA = "0x86FC70")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6001237")]
		[Address(RVA = "0x86FC78", Offset = "0x86FC78", VA = "0x86FC78")]
		internal bool _003COnTriggerExit_003Eb__0(KeyValuePair<ThirdPersonCharacter, float> kvp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20002F9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5932F4", Offset = "0x5932F4")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x400104C")]
		[FieldOffset(Offset = "0x10")]
		public ThirdPersonCharacter character;

		[Token(Token = "0x6001238")]
		[Address(RVA = "0x86FCFC", Offset = "0x86FCFC", VA = "0x86FCFC")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6001239")]
		[Address(RVA = "0x86FD04", Offset = "0x86FD04", VA = "0x86FD04")]
		internal bool _003CIsSatisfiedByCharacter_003Eb__0(KeyValuePair<ThirdPersonCharacter, float> kvp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001047")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Health _health;

	[Token(Token = "0x4001048")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _delayBeforeExplode;

	[Token(Token = "0x4001049")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private bool _landMineTargetOnlyEnemies;

	[Token(Token = "0x400104A")]
	[FieldOffset(Offset = "0x28")]
	private List<KeyValuePair<ThirdPersonCharacter, float>> _charactersInside;

	[Token(Token = "0x600122F")]
	[Address(RVA = "0xE1ECB0", Offset = "0xE1ECB0", VA = "0xE1ECB0")]
	public void Explode()
	{
	}

	[Token(Token = "0x6001230")]
	[Address(RVA = "0xE1EE00", Offset = "0xE1EE00", VA = "0xE1EE00")]
	protected void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001231")]
	[Address(RVA = "0xE1F198", Offset = "0xE1F198", VA = "0xE1F198")]
	protected void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6001232")]
	[Address(RVA = "0xE1F35C", Offset = "0xE1F35C", VA = "0xE1F35C")]
	protected void Update()
	{
	}

	[Token(Token = "0x6001233")]
	[Address(RVA = "0xE1F43C", Offset = "0xE1F43C", VA = "0xE1F43C")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6001234")]
	[Address(RVA = "0xE1EF6C", Offset = "0xE1EF6C", VA = "0xE1EF6C")]
	private bool IsSatisfiedByCharacter(ThirdPersonCharacter character)
	{
		return default(bool);
	}

	[Token(Token = "0x6001235")]
	[Address(RVA = "0xE1F4FC", Offset = "0xE1F4FC", VA = "0xE1F4FC")]
	public ExplodeOnProximity()
	{
	}
}
