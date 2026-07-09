using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200016F")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x59268C", Offset = "0x59268C")]
public class AnimationEventRelay : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000170")]
	public struct EventMatch
	{
		[Token(Token = "0x40007A9")]
		[FieldOffset(Offset = "0x0")]
		public string OnEvent;

		[Token(Token = "0x40007AA")]
		[FieldOffset(Offset = "0x8")]
		public string SendTrigger;
	}

	[Token(Token = "0x40007A7")]
	[FieldOffset(Offset = "0x18")]
	public Animator Animator;

	[Token(Token = "0x40007A8")]
	[FieldOffset(Offset = "0x20")]
	public EventMatch[] Events;

	[Token(Token = "0x6000989")]
	[Address(RVA = "0xD45C38", Offset = "0xD45C38", VA = "0xD45C38")]
	protected void AnimEvent(AnimationEvent ev)
	{
	}

	[Token(Token = "0x600098A")]
	[Address(RVA = "0xD45D6C", Offset = "0xD45D6C", VA = "0xD45D6C")]
	public AnimationEventRelay()
	{
	}
}
