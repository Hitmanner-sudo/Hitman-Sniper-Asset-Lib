using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004F9")]
public class JustCauseBlueprintCustomization : BlueprintItemViewCustomization
{
	[Token(Token = "0x4001A97")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LazyGameObject _justCauseBuyButton;

	[Token(Token = "0x6001EA1")]
	[Address(RVA = "0x99202C", Offset = "0x99202C", VA = "0x99202C", Slot = "4")]
	public override void DoCustomization(BlueprintItemView view)
	{
	}

	[Token(Token = "0x6001EA2")]
	[Address(RVA = "0x9923E0", Offset = "0x9923E0", VA = "0x9923E0")]
	public JustCauseBlueprintCustomization()
	{
	}
}
