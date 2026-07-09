using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000509")]
public class ContractRewardStar : MonoBehaviour
{
	[Token(Token = "0x4001AC3")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Star;

	[Token(Token = "0x4001AC4")]
	[FieldOffset(Offset = "0x20")]
	public UISprite StarBG;

	[Token(Token = "0x4001AC5")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Glow;

	[Token(Token = "0x6001EF6")]
	[Address(RVA = "0xD7BA94", Offset = "0xD7BA94", VA = "0xD7BA94")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6001EF7")]
	[Address(RVA = "0xD7BAF0", Offset = "0xD7BAF0", VA = "0xD7BAF0")]
	public void SetStarVisibility(bool isVisible)
	{
	}

	[Token(Token = "0x6001EF8")]
	[Address(RVA = "0xD7BB3C", Offset = "0xD7BB3C", VA = "0xD7BB3C")]
	public ContractRewardStar()
	{
	}
}
