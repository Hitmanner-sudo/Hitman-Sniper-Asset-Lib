using System;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x20000B7")]
public class PlaySoundOnLoad : GameMonoBehaviour
{
	[Token(Token = "0x4000450")]
	[FieldOffset(Offset = "0x48")]
	public SoundContainer Sound;

	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0x50")]
	public bool StopSoundOnGameEnd;

	[Token(Token = "0x4000452")]
	[FieldOffset(Offset = "0x58")]
	private PlayingSoundContainer _playingContainer;

	[Token(Token = "0x6000592")]
	[Address(RVA = "0xB81ADC", Offset = "0xB81ADC", VA = "0xB81ADC", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0xB81CD0", Offset = "0xB81CD0", VA = "0xB81CD0", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0xB81DF4", Offset = "0xB81DF4", VA = "0xB81DF4")]
	private void OnLoadingViewDisable(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0xB81F4C", Offset = "0xB81F4C", VA = "0xB81F4C")]
	private void OnGameEnded(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0xB81F64", Offset = "0xB81F64", VA = "0xB81F64")]
	public PlaySoundOnLoad()
	{
	}
}
