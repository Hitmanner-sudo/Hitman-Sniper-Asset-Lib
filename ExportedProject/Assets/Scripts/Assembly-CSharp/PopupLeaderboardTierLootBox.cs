using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006A9")]
public class PopupLeaderboardTierLootBox : PopupRankUpLootBox
{
	[Token(Token = "0x4002523")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private string _descLoc;

	[Token(Token = "0x6002BA5")]
	[Address(RVA = "0x9374A4", Offset = "0x9374A4", VA = "0x9374A4", Slot = "21")]
	protected override string GetDescriptionLocalization()
	{
		return null;
	}

	[Token(Token = "0x6002BA6")]
	[Address(RVA = "0x937550", Offset = "0x937550", VA = "0x937550")]
	public PopupLeaderboardTierLootBox()
	{
	}
}
