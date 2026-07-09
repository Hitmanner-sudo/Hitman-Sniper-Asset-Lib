using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002B0")]
public class TargetsTutorialEntryPoint : TutorialEntryPoint
{
	[Token(Token = "0x20002B1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593100", Offset = "0x593100")]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		[Token(Token = "0x4000F1A")]
		[FieldOffset(Offset = "0x10")]
		public LazyReferenceUsageWrapper<PlayerProgressionData> progressionDataWrapper;

		[Token(Token = "0x6001078")]
		[Address(RVA = "0xA55608", Offset = "0xA55608", VA = "0xA55608")]
		public _003C_003Ec__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6001079")]
		[Address(RVA = "0xA55610", Offset = "0xA55610", VA = "0xA55610")]
		internal bool _003CTutorialShouldHappen_003Eb__0(LootBox lootBox)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x20002B2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593110", Offset = "0x593110")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000F1B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000F1C")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LootBox, string> _003C_003E9__1_1;

		[Token(Token = "0x600107B")]
		[Address(RVA = "0xA555E4", Offset = "0xA555E4", VA = "0xA555E4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600107C")]
		[Address(RVA = "0xA555EC", Offset = "0xA555EC", VA = "0xA555EC")]
		internal string _003CTutorialShouldHappen_003Eb__1_1(LootBox lootBox)
		{
			return null;
		}
	}

	[Token(Token = "0x4000F19")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SaveGameManager.SaveGameFlags _tutorialFlag;

	[Token(Token = "0x6001076")]
	[Address(RVA = "0xB54D1C", Offset = "0xB54D1C", VA = "0xB54D1C", Slot = "4")]
	public override bool TutorialShouldHappen()
	{
		return default(bool);
	}

	[Token(Token = "0x6001077")]
	[Address(RVA = "0xB5527C", Offset = "0xB5527C", VA = "0xB5527C")]
	public TargetsTutorialEntryPoint()
	{
	}
}
