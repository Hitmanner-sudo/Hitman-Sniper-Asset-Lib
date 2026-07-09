using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200050A")]
public class BlueprintNavDotController : UIController
{
	[Token(Token = "0x4001AC6")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ButtonHandler _button;

	[Token(Token = "0x6001EF9")]
	[Address(RVA = "0xC796EC", Offset = "0xC796EC", VA = "0xC796EC", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001EFA")]
	[Address(RVA = "0xC79810", Offset = "0xC79810", VA = "0xC79810", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001EFB")]
	[Address(RVA = "0xC79930", Offset = "0xC79930", VA = "0xC79930")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs e)
	{
	}

	[Token(Token = "0x6001EFC")]
	[Address(RVA = "0xC79A24", Offset = "0xC79A24", VA = "0xC79A24")]
	private void OnBlueprintCompleted()
	{
	}

	[Token(Token = "0x6001EFD")]
	[Address(RVA = "0xC79A98", Offset = "0xC79A98", VA = "0xC79A98")]
	private void OnNavDotClicked(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6001EFE")]
	[Address(RVA = "0xC79C38", Offset = "0xC79C38", VA = "0xC79C38")]
	public BlueprintNavDotController()
	{
	}
}
