using System;
using Il2CppDummyDll;
using SimpleJSON;
using UnityEngine;

[Token(Token = "0x20003D1")]
public class ProgressionLootBoxItem : LootBoxItem
{
	[Serializable]
	[Token(Token = "0x20003D2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59368C", Offset = "0x59368C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400156C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x60017B9")]
		[Address(RVA = "0x8B1C98", Offset = "0x8B1C98", VA = "0x8B1C98")]
		public _003C_003Ec()
		{
		}
	}

	[Token(Token = "0x4001569")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string PROGRESSION_FIELD_NAME;

	[Token(Token = "0x400156A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int _progression;

	[Token(Token = "0x400156B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LootBox.VisualData _failureVisual;

	[Token(Token = "0x60017B2")]
	[Address(RVA = "0xB39164", Offset = "0xB39164", VA = "0xB39164", Slot = "4")]
	public override bool IsValid(bool fromSkip = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60017B3")]
	[Address(RVA = "0xB3935C", Offset = "0xB3935C", VA = "0xB3935C", Slot = "5")]
	public override LootBoxDroppedItem[] ChooseDrop(float roll)
	{
		return null;
	}

	[Token(Token = "0x60017B4")]
	[Address(RVA = "0xB39434", Offset = "0xB39434", VA = "0xB39434", Slot = "6")]
	public override void UpdateVisualOverride(ref LootBox.VisualData data)
	{
	}

	[Token(Token = "0x60017B5")]
	[Address(RVA = "0xB39644", Offset = "0xB39644", VA = "0xB39644", Slot = "7")]
	public override void Restore(JSONNode data)
	{
	}

	[Token(Token = "0x60017B6")]
	[Address(RVA = "0xB3972C", Offset = "0xB3972C", VA = "0xB3972C")]
	public ProgressionLootBoxItem()
	{
	}
}
