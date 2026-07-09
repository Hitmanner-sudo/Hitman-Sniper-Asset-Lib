using Il2CppDummyDll;
using SimpleJSON;

[Token(Token = "0x20003C7")]
public class LootBoxDroppedUnlockable : LootBoxDroppedItem
{
	[Token(Token = "0x400155A")]
	private const string UNLOCKABLE_NODE = "_unlockable";

	[Token(Token = "0x400155B")]
	private const string COUNT_NODE = "_count";

	[Token(Token = "0x400155C")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B4EE8", Offset = "0x5B4EE8")]
	private Unlockable _003CUnlockable_003Ek__BackingField;

	[Token(Token = "0x400155D")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B4EF8", Offset = "0x5B4EF8")]
	private int _003CCount_003Ek__BackingField;

	[Token(Token = "0x170003CB")]
	public Unlockable Unlockable
	{
		[Token(Token = "0x600178B")]
		[Address(RVA = "0x9E38F0", Offset = "0x9E38F0", VA = "0x9E38F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6174C4", Offset = "0x6174C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600178C")]
		[Address(RVA = "0x9E38F8", Offset = "0x9E38F8", VA = "0x9E38F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6174D4", Offset = "0x6174D4")]
		private set
		{
		}
	}

	[Token(Token = "0x170003CC")]
	public int Count
	{
		[Token(Token = "0x600178D")]
		[Address(RVA = "0x9E3900", Offset = "0x9E3900", VA = "0x9E3900")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6174E4", Offset = "0x6174E4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600178E")]
		[Address(RVA = "0x9E3908", Offset = "0x9E3908", VA = "0x9E3908")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6174F4", Offset = "0x6174F4")]
		private set
		{
		}
	}

	[Token(Token = "0x170003CD")]
	public override bool CanShow
	{
		[Token(Token = "0x600178F")]
		[Address(RVA = "0x9E3910", Offset = "0x9E3910", VA = "0x9E3910", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001790")]
	[Address(RVA = "0x9E3994", Offset = "0x9E3994", VA = "0x9E3994")]
	private LootBoxDroppedUnlockable()
	{
	}

	[Token(Token = "0x6001791")]
	[Address(RVA = "0x9E399C", Offset = "0x9E399C", VA = "0x9E399C")]
	public LootBoxDroppedUnlockable(Unlockable unlockable, int count = 1)
	{
	}

	[Token(Token = "0x6001792")]
	[Address(RVA = "0x9E39D8", Offset = "0x9E39D8", VA = "0x9E39D8", Slot = "7")]
	public override void Claim()
	{
	}

	[Token(Token = "0x6001793")]
	[Address(RVA = "0x9E3A2C", Offset = "0x9E3A2C", VA = "0x9E3A2C", Slot = "8")]
	public override bool Merge(LootBoxDroppedItem other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001794")]
	[Address(RVA = "0x9E3B1C", Offset = "0x9E3B1C", VA = "0x9E3B1C", Slot = "9")]
	public override void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001795")]
	[Address(RVA = "0x9E3CC0", Offset = "0x9E3CC0", VA = "0x9E3CC0", Slot = "10")]
	public override JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001796")]
	[Address(RVA = "0x9E3E3C", Offset = "0x9E3E3C", VA = "0x9E3E3C", Slot = "11")]
	public override string GetAnalyticsName()
	{
		return null;
	}

	[Token(Token = "0x6001797")]
	[Address(RVA = "0x9E3F1C", Offset = "0x9E3F1C", VA = "0x9E3F1C", Slot = "12")]
	public override int GetAnalyticsQuantity()
	{
		return default(int);
	}
}
