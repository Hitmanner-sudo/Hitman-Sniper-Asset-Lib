using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007A6")]
public class UIPropogateColor : UIWidget
{
	[Token(Token = "0x4002B11")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private UIWidget[] _targets;

	[Token(Token = "0x17000679")]
	public override Color color
	{
		[Token(Token = "0x600328C")]
		[Address(RVA = "0x142CE60", Offset = "0x142CE60", VA = "0x142CE60", Slot = "4")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600328D")]
		[Address(RVA = "0x142CE6C", Offset = "0x142CE6C", VA = "0x142CE6C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x600328E")]
	[Address(RVA = "0x142CF14", Offset = "0x142CF14", VA = "0x142CF14")]
	public UIPropogateColor()
	{
	}
}
