using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000706")]
public class RemoveAbilityButtonView : View
{
	[Token(Token = "0x40027C2")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ButtonHandler _button;

	[Token(Token = "0x6002EBD")]
	[Address(RVA = "0x965934", Offset = "0x965934", VA = "0x965934", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002EBE")]
	[Address(RVA = "0x9659E8", Offset = "0x9659E8", VA = "0x9659E8", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002EBF")]
	[Address(RVA = "0x965A9C", Offset = "0x965A9C", VA = "0x965A9C")]
	private void OnSelfPressed(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002EC0")]
	[Address(RVA = "0x965C60", Offset = "0x965C60", VA = "0x965C60")]
	public RemoveAbilityButtonView()
	{
	}
}
