using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000040")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591130", Offset = "0x591130")]
[Attribute(Name = "RequireComponent", RVA = "0x591130", Offset = "0x591130")]
public class UISoundVolume : MonoBehaviour
{
	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x18")]
	private UISlider mSlider;

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x1432734", Offset = "0x1432734", VA = "0x1432734")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1432864", Offset = "0x1432864", VA = "0x1432864")]
	private void OnChange()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x14328FC", Offset = "0x14328FC", VA = "0x14328FC")]
	public UISoundVolume()
	{
	}
}
