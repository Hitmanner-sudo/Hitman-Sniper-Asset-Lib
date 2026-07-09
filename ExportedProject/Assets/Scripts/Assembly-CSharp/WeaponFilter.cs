using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000476")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x594AB0", Offset = "0x594AB0")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x594AB0", Offset = "0x594AB0")]
public class WeaponFilter : FsmStateAction
{
	[Token(Token = "0x2000477")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594B10", Offset = "0x594B10")]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x400185A")]
		[FieldOffset(Offset = "0x10")]
		public PlayerProfileData profileData;

		[Token(Token = "0x6001AE3")]
		[Address(RVA = "0xA42C4C", Offset = "0xA42C4C", VA = "0xA42C4C")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}
	}

	[Token(Token = "0x2000478")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594B20", Offset = "0x594B20")]
	private sealed class _003C_003Ec__DisplayClass5_1
	{
		[Token(Token = "0x400185B")]
		[FieldOffset(Offset = "0x10")]
		public string requiredMod;

		[Token(Token = "0x400185C")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6001AE4")]
		[Address(RVA = "0xA42C54", Offset = "0xA42C54", VA = "0xA42C54")]
		public _003C_003Ec__DisplayClass5_1()
		{
		}

		[Token(Token = "0x6001AE5")]
		[Address(RVA = "0xA42C5C", Offset = "0xA42C5C", VA = "0xA42C5C")]
		internal bool _003COnEnter_003Eb__1(WeaponUnlockableSaveData.AttachmentSlot x)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x2000479")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594B30", Offset = "0x594B30")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400185D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400185E")]
		[FieldOffset(Offset = "0x8")]
		public static Func<string, bool> _003C_003E9__5_0;

		[Token(Token = "0x6001AE7")]
		[Address(RVA = "0xA42C20", Offset = "0xA42C20", VA = "0xA42C20")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001AE8")]
		[Address(RVA = "0xA42C28", Offset = "0xA42C28", VA = "0xA42C28")]
		internal bool _003COnEnter_003Eb__5_0(string mod)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001855")]
	[FieldOffset(Offset = "0x50")]
	public string RequiredWeapon;

	[Token(Token = "0x4001856")]
	[FieldOffset(Offset = "0x58")]
	public string[] RequiredMods;

	[Token(Token = "0x4001857")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5B6AA8", Offset = "0x5B6AA8")]
	public FsmBool IsMatch;

	[Token(Token = "0x4001858")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent MatchesFilter;

	[Token(Token = "0x4001859")]
	[FieldOffset(Offset = "0x70")]
	public FsmEvent DoesNotMatchFilter;

	[Token(Token = "0x6001AE1")]
	[Address(RVA = "0x988750", Offset = "0x988750", VA = "0x988750", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001AE2")]
	[Address(RVA = "0x988BE0", Offset = "0x988BE0", VA = "0x988BE0")]
	public WeaponFilter()
	{
	}
}
