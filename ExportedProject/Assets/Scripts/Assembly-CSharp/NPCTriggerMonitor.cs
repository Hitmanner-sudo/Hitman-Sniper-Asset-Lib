using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200045C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x594500", Offset = "0x594500")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x594500", Offset = "0x594500")]
public class NPCTriggerMonitor : FsmStateAction
{
	[Serializable]
	[Token(Token = "0x200045D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594560", Offset = "0x594560")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001809")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400180A")]
		[FieldOffset(Offset = "0x8")]
		public static Func<AIController, ThirdPersonCharacter> _003C_003E9__8_0;

		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x8C9504", Offset = "0x8C9504", VA = "0x8C9504")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x8C950C", Offset = "0x8C950C", VA = "0x8C950C")]
		internal ThirdPersonCharacter _003COnEnter_003Eb__8_0(AIController t)
		{
			return null;
		}
	}

	[Token(Token = "0x4001802")]
	[FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5B679C", Offset = "0x5B679C")]
	public FsmGameObject Trigger;

	[Token(Token = "0x4001803")]
	[FieldOffset(Offset = "0x58")]
	private NPCTriggerBase[] _triggers;

	[Token(Token = "0x4001804")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5B67E8", Offset = "0x5B67E8")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B67E8", Offset = "0x5B67E8")]
	public FsmGameObject NPC;

	[Token(Token = "0x4001805")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent EnterEvent;

	[Token(Token = "0x4001806")]
	[FieldOffset(Offset = "0x70")]
	public FsmEvent ExitEvent;

	[Token(Token = "0x4001807")]
	[FieldOffset(Offset = "0x78")]
	public FsmEvent TriggerEmptyEvent;

	[Token(Token = "0x4001808")]
	[FieldOffset(Offset = "0x80")]
	private int _characterCount;

	[Token(Token = "0x6001A6C")]
	[Address(RVA = "0xC53FCC", Offset = "0xC53FCC", VA = "0xC53FCC", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A6D")]
	[Address(RVA = "0xC54004", Offset = "0xC54004", VA = "0xC54004", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A6E")]
	[Address(RVA = "0xC5440C", Offset = "0xC5440C", VA = "0xC5440C")]
	private void OnTriggerEnter(object sender, NPCTriggerBase.NPCTriggerEventArgs args)
	{
	}

	[Token(Token = "0x6001A6F")]
	[Address(RVA = "0xC5443C", Offset = "0xC5443C", VA = "0xC5443C")]
	private void SendEnterEvent(Character character)
	{
	}

	[Token(Token = "0x6001A70")]
	[Address(RVA = "0xC54518", Offset = "0xC54518", VA = "0xC54518")]
	private void OnTriggerExit(object sender, NPCTriggerBase.NPCTriggerEventArgs args)
	{
	}

	[Token(Token = "0x6001A71")]
	[Address(RVA = "0xC5457C", Offset = "0xC5457C", VA = "0xC5457C", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001A72")]
	[Address(RVA = "0xC546AC", Offset = "0xC546AC", VA = "0xC546AC")]
	public NPCTriggerMonitor()
	{
	}
}
