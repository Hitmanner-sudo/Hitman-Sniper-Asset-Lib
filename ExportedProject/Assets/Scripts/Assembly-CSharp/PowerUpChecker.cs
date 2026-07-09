using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000469")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x5947E8", Offset = "0x5947E8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5947E8", Offset = "0x5947E8")]
public class PowerUpChecker : FsmStateAction
{
	[Serializable]
	[Token(Token = "0x200046A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594848", Offset = "0x594848")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400182F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001830")]
		[FieldOffset(Offset = "0x8")]
		public static Func<string, bool> _003C_003E9__4_0;

		[Token(Token = "0x6001AAC")]
		[Address(RVA = "0x8B15A8", Offset = "0x8B15A8", VA = "0x8B15A8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001AAD")]
		[Address(RVA = "0x8B15B0", Offset = "0x8B15B0", VA = "0x8B15B0")]
		internal bool _003COnEnter_003Eb__4_0(string p)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400182B")]
	[FieldOffset(Offset = "0x50")]
	public string[] PowerUp;

	[Token(Token = "0x400182C")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B6A1C", Offset = "0x5B6A1C")]
	public FsmBool IsActive;

	[Token(Token = "0x400182D")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent PowerUpActive;

	[Token(Token = "0x400182E")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent PowerUpInactive;

	[Token(Token = "0x6001AA9")]
	[Address(RVA = "0x940590", Offset = "0x940590", VA = "0x940590", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001AAA")]
	[Address(RVA = "0x940708", Offset = "0x940708", VA = "0x940708")]
	public PowerUpChecker()
	{
	}
}
