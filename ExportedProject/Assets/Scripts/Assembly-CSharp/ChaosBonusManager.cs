using System;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000226")]
public static class ChaosBonusManager
{
	[Token(Token = "0x2000227")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592BB0", Offset = "0x592BB0")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x4000C2F")]
		[FieldOffset(Offset = "0x10")]
		public LazyGameObject originalGo;

		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x861844", Offset = "0x861844", VA = "0x861844")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x86184C", Offset = "0x86184C", VA = "0x86184C")]
		internal bool _003CGetChaosGameObject_003Eb__0(AlternateGameObject go)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000C2C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ChaosBonusConfig _config;

	[Token(Token = "0x4000C2D")]
	[FieldOffset(Offset = "0x8")]
	private static int _weaponIdx;

	[Token(Token = "0x4000C2E")]
	[FieldOffset(Offset = "0xC")]
	private static bool _hasChaosBonus;

	[Token(Token = "0x6000CD9")]
	[Address(RVA = "0xAF91EC", Offset = "0xAF91EC", VA = "0xAF91EC")]
	static ChaosBonusManager()
	{
	}

	[Token(Token = "0x6000CDA")]
	[Address(RVA = "0xAF9320", Offset = "0xAF9320", VA = "0xAF9320")]
	public static bool ShouldReplace()
	{
		return default(bool);
	}

	[Token(Token = "0x6000CDB")]
	[Address(RVA = "0xAF990C", Offset = "0xAF990C", VA = "0xAF990C")]
	private static bool IsEventActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000CDC")]
	[Address(RVA = "0xAF93AC", Offset = "0xAF93AC", VA = "0xAF93AC")]
	private static bool IsChaosPerkEquiped()
	{
		return default(bool);
	}

	[Token(Token = "0x6000CDD")]
	[Address(RVA = "0xAF9A18", Offset = "0xAF9A18", VA = "0xAF9A18")]
	public static LazyGameObject GetChaosGameObject(LazyGameObject originalGo)
	{
		return null;
	}

	[Token(Token = "0x6000CDE")]
	[Address(RVA = "0xAEF884", Offset = "0xAEF884", VA = "0xAEF884")]
	public static CalenderModel.AlternateTexture? GetChaosTexture(Texture texture)
	{
		return null;
	}

	[Token(Token = "0x6000CDF")]
	[Address(RVA = "0xAF9BC0", Offset = "0xAF9BC0", VA = "0xAF9BC0")]
	public static LazyMaterial GetChaosMaterial(Material sharedMaterial)
	{
		return null;
	}

	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0xAF9C6C", Offset = "0xAF9C6C", VA = "0xAF9C6C")]
	public static SoundContainer GetChaosSoundContainer(SoundContainer soundContainer)
	{
		return null;
	}

	[Token(Token = "0x6000CE1")]
	[Address(RVA = "0xAF9D18", Offset = "0xAF9D18", VA = "0xAF9D18")]
	private static void OnLoadingViewEnabled(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6000CE2")]
	private static T SafeIndex<T>(T[] array, int idx)
	{
		return (T)null;
	}
}
