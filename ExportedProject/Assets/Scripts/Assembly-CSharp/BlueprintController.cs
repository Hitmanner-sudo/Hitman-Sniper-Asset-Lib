using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200054E")]
public class BlueprintController : UIController
{
	[Token(Token = "0x4001C21")]
	[FieldOffset(Offset = "0x50")]
	public UICenterOnChild CenterOnChildComponent;

	[Token(Token = "0x4001C22")]
	private const float MIN_SQR_MAG_OFFSET = 22500f;

	[Token(Token = "0x600214C")]
	[Address(RVA = "0xC69DE8", Offset = "0xC69DE8", VA = "0xC69DE8", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600214D")]
	[Address(RVA = "0xC69EB4", Offset = "0xC69EB4", VA = "0xC69EB4", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600214E")]
	[Address(RVA = "0xC69FCC", Offset = "0xC69FCC", VA = "0xC69FCC")]
	private void OnCenterChanged(Vector3 offset)
	{
	}

	[Token(Token = "0x600214F")]
	[Address(RVA = "0xC6A174", Offset = "0xC6A174", VA = "0xC6A174")]
	public BlueprintController()
	{
	}
}
