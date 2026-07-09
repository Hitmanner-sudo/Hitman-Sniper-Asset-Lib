using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20008A2")]
public class LazyPowerUp : TLazyScriptableObject<PowerUp>
{
	[Token(Token = "0x6003813")]
	[Address(RVA = "0x9974E8", Offset = "0x9974E8", VA = "0x9974E8", Slot = "9")]
	protected override PowerUp LoadValue(string path)
	{
		return null;
	}

	[Token(Token = "0x6003814")]
	[Address(RVA = "0x997578", Offset = "0x997578", VA = "0x997578", Slot = "10")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6003815")]
	[Address(RVA = "0x9976B8", Offset = "0x9976B8", VA = "0x9976B8")]
	public LazyPowerUp()
	{
	}
}
