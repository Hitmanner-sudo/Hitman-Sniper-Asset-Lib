using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x2000426")]
[Scope]
public class PerkRewards : GameSingleton<PerkRewards>
{
	[Serializable]
	[Token(Token = "0x2000427")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593BAC", Offset = "0x593BAC")]
	private sealed class _003C_003Ec__4<T>
	{
		[Token(Token = "0x400170C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec__4<T> _003C_003E9;

		[Token(Token = "0x400170D")]
		[FieldOffset(Offset = "0x0")]
		public static Predicate<PerkReward> _003C_003E9__4_0;

		[Token(Token = "0x600197E")]
		public _003C_003Ec__4()
		{
		}

		[Token(Token = "0x600197F")]
		internal bool _003CGetPerkRewards_003Eb__4_0(PerkReward x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400170B")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<PerkReward> _activePerkRewards;

	[Token(Token = "0x6001978")]
	[Address(RVA = "0x8FDBD4", Offset = "0x8FDBD4", VA = "0x8FDBD4")]
	public void AddActiveReward(PerkReward perkReward)
	{
	}

	[Token(Token = "0x6001979")]
	[Address(RVA = "0x8FDD6C", Offset = "0x8FDD6C", VA = "0x8FDD6C")]
	public void RemoveActiveReward(PerkReward perkReward)
	{
	}

	[Token(Token = "0x600197A")]
	[Address(RVA = "0x901B08", Offset = "0x901B08", VA = "0x901B08")]
	public bool IsPerkRewardEnabled(PerkReward perkReward)
	{
		return default(bool);
	}

	[Token(Token = "0x600197B")]
	public List<PerkReward> GetPerkRewards<T>()
	{
		return null;
	}

	[Token(Token = "0x600197C")]
	[Address(RVA = "0x901B74", Offset = "0x901B74", VA = "0x901B74")]
	public PerkRewards()
	{
	}
}
