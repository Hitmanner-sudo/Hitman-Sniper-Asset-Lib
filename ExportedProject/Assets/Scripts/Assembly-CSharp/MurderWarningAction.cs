using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000459")]
public class MurderWarningAction : FsmStateAction
{
	[Serializable]
	[Token(Token = "0x200045A")]
	public class MurderWarningArgs : EventArgs
	{
		[Token(Token = "0x40017FC")]
		[FieldOffset(Offset = "0x10")]
		public float WarningTime;

		[Token(Token = "0x40017FD")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6754", Offset = "0x5B6754")]
		private Character _003CCharacter_003Ek__BackingField;

		[Token(Token = "0x17000425")]
		public Character Character
		{
			[Token(Token = "0x6001A67")]
			[Address(RVA = "0x8C92DC", Offset = "0x8C92DC", VA = "0x8C92DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6178F4", Offset = "0x6178F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A68")]
			[Address(RVA = "0x8C92E4", Offset = "0x8C92E4", VA = "0x8C92E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617904", Offset = "0x617904")]
			set
			{
			}
		}

		[Token(Token = "0x6001A69")]
		[Address(RVA = "0x8C92EC", Offset = "0x8C92EC", VA = "0x8C92EC")]
		public MurderWarningArgs()
		{
		}
	}

	[Token(Token = "0x40017FA")]
	[FieldOffset(Offset = "0x50")]
	public FsmGameObject CharacterGO;

	[Token(Token = "0x40017FB")]
	[FieldOffset(Offset = "0x58")]
	public MurderWarningArgs Args;

	[Token(Token = "0x14000065")]
	public static event EventHandler<MurderWarningArgs> OnMurderWarning
	{
		[Token(Token = "0x6001A63")]
		[Address(RVA = "0xA3110C", Offset = "0xA3110C", VA = "0xA3110C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6178D4", Offset = "0x6178D4")]
		add
		{
		}
		[Token(Token = "0x6001A64")]
		[Address(RVA = "0xA311C8", Offset = "0xA311C8", VA = "0xA311C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6178E4", Offset = "0x6178E4")]
		remove
		{
		}
	}

	[Token(Token = "0x6001A65")]
	[Address(RVA = "0xA31284", Offset = "0xA31284", VA = "0xA31284", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A66")]
	[Address(RVA = "0xA31340", Offset = "0xA31340", VA = "0xA31340")]
	public MurderWarningAction()
	{
	}
}
