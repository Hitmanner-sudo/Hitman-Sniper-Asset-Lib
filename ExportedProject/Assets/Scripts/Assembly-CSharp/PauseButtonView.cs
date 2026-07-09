using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006B5")]
public class PauseButtonView : View
{
	[Token(Token = "0x4002575")]
	[FieldOffset(Offset = "0x60")]
	public GameObject PauseButton;

	[Token(Token = "0x6002C0A")]
	[Address(RVA = "0x8F7700", Offset = "0x8F7700", VA = "0x8F7700", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002C0B")]
	[Address(RVA = "0x8F780C", Offset = "0x8F780C", VA = "0x8F780C", Slot = "15")]
	protected virtual void PauseMenuStateChanged(HUDModel.PauseMenuState newValue)
	{
	}

	[Token(Token = "0x6002C0C")]
	[Address(RVA = "0x8F784C", Offset = "0x8F784C", VA = "0x8F784C")]
	public PauseButtonView()
	{
	}
}
