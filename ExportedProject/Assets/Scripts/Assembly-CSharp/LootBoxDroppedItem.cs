using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Token(Token = "0x20003C4")]
public abstract class LootBoxDroppedItem : ISaveable
{
	[Token(Token = "0x170003C8")]
	public virtual bool CanShow
	{
		[Token(Token = "0x6001775")]
		[Address(RVA = "0x9E2D7C", Offset = "0x9E2D7C", VA = "0x9E2D7C", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001776")]
	public abstract void Claim();

	[Token(Token = "0x6001777")]
	public abstract bool Merge(LootBoxDroppedItem other);

	[Token(Token = "0x6001778")]
	public abstract void OnSaveableDeserialization(JSONNode data);

	[Token(Token = "0x6001779")]
	public abstract JSONNode OnSaveableSerialization();

	[Token(Token = "0x600177A")]
	public abstract string GetAnalyticsName();

	[Token(Token = "0x600177B")]
	public abstract int GetAnalyticsQuantity();

	[Token(Token = "0x600177C")]
	[Address(RVA = "0x9E22A4", Offset = "0x9E22A4", VA = "0x9E22A4")]
	protected LootBoxDroppedItem()
	{
	}
}
