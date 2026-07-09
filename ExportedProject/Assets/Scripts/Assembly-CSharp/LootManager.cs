using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core;
using UnityEngine;

[Token(Token = "0x20003CA")]
public class LootManager : ScriptableSingleton<LootManager>
{
	[Token(Token = "0x20003CB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x59364C", Offset = "0x59364C")]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x4001561")]
		[FieldOffset(Offset = "0x10")]
		public LootBoxDroppedItem item;

		[Token(Token = "0x60017A4")]
		[Address(RVA = "0x8C4904", Offset = "0x8C4904", VA = "0x8C4904")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60017A5")]
		[Address(RVA = "0x8C490C", Offset = "0x8C490C", VA = "0x8C490C")]
		internal bool _003CGetDroppedItemViewPrefab_003Eb__0(LootBoxDroppedItemView v)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20003CC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x59365C", Offset = "0x59365C")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x4001562")]
		[FieldOffset(Offset = "0x10")]
		public string boxName;

		[Token(Token = "0x60017A6")]
		[Address(RVA = "0x8C4938", Offset = "0x8C4938", VA = "0x8C4938")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60017A7")]
		[Address(RVA = "0x8C4940", Offset = "0x8C4940", VA = "0x8C4940")]
		internal bool _003CDeserializeLootBox_003Eb__0(LootBox b)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20003CD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x59366C", Offset = "0x59366C")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x4001563")]
		[FieldOffset(Offset = "0x10")]
		public string boxName;

		[Token(Token = "0x60017A8")]
		[Address(RVA = "0x8C4978", Offset = "0x8C4978", VA = "0x8C4978")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60017A9")]
		[Address(RVA = "0x8C4980", Offset = "0x8C4980", VA = "0x8C4980")]
		internal bool _003CDeserializeLootBoxForDDNAUpdate_003Eb__0(LootBox b)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400155E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LootBox[] _lootBoxes;

	[Token(Token = "0x400155F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PopupClaimLootBoxView _popupClaimLootBox;

	[Token(Token = "0x4001560")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private LootBoxDroppedItemView[] _droppedItemViews;

	[Token(Token = "0x170003CE")]
	public PopupClaimLootBoxView PopupClaimLootBoxPrefab
	{
		[Token(Token = "0x600179E")]
		[Address(RVA = "0x9E4238", Offset = "0x9E4238", VA = "0x9E4238")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600179F")]
	[Address(RVA = "0x9E4240", Offset = "0x9E4240", VA = "0x9E4240")]
	public LootBoxDroppedItemView GetDroppedItemViewPrefab(LootBoxDroppedItem item)
	{
		return null;
	}

	[Token(Token = "0x60017A0")]
	[Address(RVA = "0x9E1108", Offset = "0x9E1108", VA = "0x9E1108")]
	public bool IsManagedLootBox(LootBox box)
	{
		return default(bool);
	}

	[Token(Token = "0x60017A1")]
	[Address(RVA = "0x9E432C", Offset = "0x9E432C", VA = "0x9E432C")]
	public LootBox DeserializeLootBox(JSONNode data)
	{
		return null;
	}

	[Token(Token = "0x60017A2")]
	[Address(RVA = "0x9E44E0", Offset = "0x9E44E0", VA = "0x9E44E0")]
	public void DeserializeLootBoxForDDNAUpdate(JSONNode data)
	{
	}

	[Token(Token = "0x60017A3")]
	[Address(RVA = "0x9E46B4", Offset = "0x9E46B4", VA = "0x9E46B4")]
	public LootManager()
	{
	}
}
