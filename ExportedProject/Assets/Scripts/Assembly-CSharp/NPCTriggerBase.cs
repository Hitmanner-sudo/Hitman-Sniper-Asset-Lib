using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x2000126")]
public abstract class NPCTriggerBase : GameMonoBehaviour
{
	[Token(Token = "0x2000127")]
	public class NPCTriggerEventArgs : EventArgs
	{
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B07FC", Offset = "0x5B07FC")]
		private AIController _003CAI_003Ek__BackingField;

		[Token(Token = "0x17000152")]
		public AIController AI
		{
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x8C9430", Offset = "0x8C9430", VA = "0x8C9430")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612550", Offset = "0x612550")]
			get
			{
				return null;
			}
			[Token(Token = "0x600080A")]
			[Address(RVA = "0x8C9438", Offset = "0x8C9438", VA = "0x8C9438")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612560", Offset = "0x612560")]
			set
			{
			}
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x8C9440", Offset = "0x8C9440", VA = "0x8C9440")]
		public NPCTriggerEventArgs()
		{
		}
	}

	[Token(Token = "0x4000669")]
	[FieldOffset(Offset = "0x48")]
	public NPCFilter Filter;

	[NonSerialized]
	[Token(Token = "0x400066C")]
	[FieldOffset(Offset = "0x60")]
	public List<AIController> Inside;

	[Token(Token = "0x14000010")]
	public event EventHandler<NPCTriggerEventArgs> OnEnterCallback
	{
		[Token(Token = "0x6000800")]
		[Address(RVA = "0xC53AB0", Offset = "0xC53AB0", VA = "0xC53AB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612510", Offset = "0x612510")]
		add
		{
		}
		[Token(Token = "0x6000801")]
		[Address(RVA = "0xC53B50", Offset = "0xC53B50", VA = "0xC53B50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612520", Offset = "0x612520")]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	public event EventHandler<NPCTriggerEventArgs> OnExitCallback
	{
		[Token(Token = "0x6000802")]
		[Address(RVA = "0xC53BF0", Offset = "0xC53BF0", VA = "0xC53BF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612530", Offset = "0x612530")]
		add
		{
		}
		[Token(Token = "0x6000803")]
		[Address(RVA = "0xC53C90", Offset = "0xC53C90", VA = "0xC53C90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612540", Offset = "0x612540")]
		remove
		{
		}
	}

	[Token(Token = "0x6000804")]
	[Address(RVA = "0xC53D30", Offset = "0xC53D30", VA = "0xC53D30", Slot = "14")]
	protected virtual bool OnEnter(AIController ai)
	{
		return default(bool);
	}

	[Token(Token = "0x6000805")]
	[Address(RVA = "0xC52750", Offset = "0xC52750", VA = "0xC52750", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6000806")]
	[Address(RVA = "0xC53E2C", Offset = "0xC53E2C", VA = "0xC53E2C")]
	public void CleanUp()
	{
	}

	[Token(Token = "0x6000807")]
	[Address(RVA = "0xC53EF8", Offset = "0xC53EF8", VA = "0xC53EF8", Slot = "15")]
	protected virtual bool OnExit(AIController ai)
	{
		return default(bool);
	}

	[Token(Token = "0x6000808")]
	[Address(RVA = "0xC53050", Offset = "0xC53050", VA = "0xC53050")]
	protected NPCTriggerBase()
	{
	}
}
