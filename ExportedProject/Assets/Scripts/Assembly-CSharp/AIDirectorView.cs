using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200063A")]
public class AIDirectorView : View
{
	[Token(Token = "0x4002246")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UILabel _nameLabel;

	[Token(Token = "0x6002832")]
	[Address(RVA = "0xA95788", Offset = "0xA95788", VA = "0xA95788", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002833")]
	[Address(RVA = "0xA957B0", Offset = "0xA957B0", VA = "0xA957B0", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002834")]
	[Address(RVA = "0xA957F0", Offset = "0xA957F0", VA = "0xA957F0")]
	private void OnVariableUpdate()
	{
	}

	[Token(Token = "0x6002835")]
	[Address(RVA = "0xA95A8C", Offset = "0xA95A8C", VA = "0xA95A8C")]
	public AIDirectorView()
	{
	}
}
