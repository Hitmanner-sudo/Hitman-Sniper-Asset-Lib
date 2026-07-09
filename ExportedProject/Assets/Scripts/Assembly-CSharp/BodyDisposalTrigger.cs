using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200011E")]
public class BodyDisposalTrigger : NPCColliderTrigger
{
	[Token(Token = "0x4000649")]
	[FieldOffset(Offset = "0x78")]
	public NPCFilter ScoreFilter;

	[Token(Token = "0x400064A")]
	[FieldOffset(Offset = "0x0")]
	private static int BodyDisposedProperty;

	[Token(Token = "0x1400000F")]
	public static event EventHandler<NPCTriggerEventArgs> OnAnyBodyDisposedCallback
	{
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xA7E204", Offset = "0xA7E204", VA = "0xA7E204")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6124C0", Offset = "0x6124C0")]
		add
		{
		}
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xA7E2FC", Offset = "0xA7E2FC", VA = "0xA7E2FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6124D0", Offset = "0x6124D0")]
		remove
		{
		}
	}

	[Token(Token = "0x60007DE")]
	[Address(RVA = "0xA7E3F4", Offset = "0xA7E3F4", VA = "0xA7E3F4", Slot = "14")]
	protected override bool OnEnter(AIController ai)
	{
		return default(bool);
	}

	[Token(Token = "0x60007DF")]
	[Address(RVA = "0xA7E50C", Offset = "0xA7E50C", VA = "0xA7E50C")]
	public static void BodyDisposed(AIController ai, MonoBehaviour handler, NPCFilter NPCFilter)
	{
	}

	[Token(Token = "0x60007E0")]
	[Address(RVA = "0xA7E81C", Offset = "0xA7E81C", VA = "0xA7E81C")]
	public BodyDisposalTrigger()
	{
	}
}
