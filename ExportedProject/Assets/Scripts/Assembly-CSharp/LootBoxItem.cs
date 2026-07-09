using Il2CppDummyDll;
using SimpleJSON;
using UnityEngine;

[Token(Token = "0x20003C8")]
public abstract class LootBoxItem : ScriptableObject
{
	[Token(Token = "0x6001798")]
	public abstract bool IsValid(bool fromSkip = false);

	[Token(Token = "0x6001799")]
	public abstract LootBoxDroppedItem[] ChooseDrop(float roll);

	[Token(Token = "0x600179A")]
	[Address(RVA = "0x9E4224", Offset = "0x9E4224", VA = "0x9E4224", Slot = "6")]
	public virtual void UpdateVisualOverride(ref LootBox.VisualData data)
	{
	}

	[Token(Token = "0x600179B")]
	public abstract void Restore(JSONNode data);

	[Token(Token = "0x600179C")]
	[Address(RVA = "0x9E4228", Offset = "0x9E4228", VA = "0x9E4228")]
	protected LootBoxItem()
	{
	}
}
