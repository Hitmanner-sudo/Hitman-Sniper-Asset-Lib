using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000319")]
public class TriggerForceIdleState : GameMonoBehaviour
{
	[Token(Token = "0x4001152")]
	[FieldOffset(Offset = "0x48")]
	public AnimationConfig.IdleType IdleType;

	[Token(Token = "0x4001153")]
	[FieldOffset(Offset = "0x50")]
	public Faction Faction;

	[Token(Token = "0x4001154")]
	[FieldOffset(Offset = "0x58")]
	private List<ThirdPersonCharacter> CollidingCharacters;

	[Token(Token = "0x6001306")]
	[Address(RVA = "0xC9EBDC", Offset = "0xC9EBDC", VA = "0xC9EBDC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001307")]
	[Address(RVA = "0xC9EDD4", Offset = "0xC9EDD4", VA = "0xC9EDD4")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6001308")]
	[Address(RVA = "0xC9EF6C", Offset = "0xC9EF6C", VA = "0xC9EF6C")]
	private void AddForceIdle(ThirdPersonCharacter character)
	{
	}

	[Token(Token = "0x6001309")]
	[Address(RVA = "0xC9EE88", Offset = "0xC9EE88", VA = "0xC9EE88")]
	private void RemoveForceIdle(ThirdPersonCharacter character)
	{
	}

	[Token(Token = "0x600130A")]
	[Address(RVA = "0xC9ED1C", Offset = "0xC9ED1C", VA = "0xC9ED1C")]
	private bool IsCharacterValid(ThirdPersonCharacter character)
	{
		return default(bool);
	}

	[Token(Token = "0x600130B")]
	[Address(RVA = "0xC9F044", Offset = "0xC9F044", VA = "0xC9F044", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600130C")]
	[Address(RVA = "0xC9F158", Offset = "0xC9F158", VA = "0xC9F158")]
	public TriggerForceIdleState()
	{
	}
}
