using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200035F")]
public class SplitShotPowerUp : PowerUp
{
	[Token(Token = "0x40012AD")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private int _enemiesToTrackNumber;

	[Token(Token = "0x40012AE")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private float _enemiesToTrackDistance;

	[Token(Token = "0x40012AF")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private bool _enemiesToTrackShowHighlight;

	[Token(Token = "0x6001455")]
	[Address(RVA = "0xD24B68", Offset = "0xD24B68", VA = "0xD24B68", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001456")]
	[Address(RVA = "0xD24BE8", Offset = "0xD24BE8", VA = "0xD24BE8", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001457")]
	[Address(RVA = "0xD24C68", Offset = "0xD24C68", VA = "0xD24C68")]
	public SplitShotPowerUp()
	{
	}
}
