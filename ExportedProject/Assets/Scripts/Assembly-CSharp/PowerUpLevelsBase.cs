using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000358")]
public class PowerUpLevelsBase
{
	[Token(Token = "0x400125A")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private int NormalCost;

	[Token(Token = "0x400125B")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	private int HardCost;

	[Token(Token = "0x400125C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int ExpertCost;

	[Token(Token = "0x170002FC")]
	public int CostToBuy
	{
		[Token(Token = "0x600143E")]
		[Address(RVA = "0x945900", Offset = "0x945900", VA = "0x945900")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600143F")]
	[Address(RVA = "0x945A00", Offset = "0x945A00", VA = "0x945A00")]
	public PowerUpLevelsBase()
	{
	}
}
