using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006BD")]
public class PlayButtonDownloadView : View
{
	[Token(Token = "0x40025C3")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform _loadingHolder;

	[Token(Token = "0x40025C4")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Transform _readyHolder;

	[Token(Token = "0x40025C5")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform _cancelledHolder;

	[Token(Token = "0x40025C6")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UISlider _progressBar;

	[Token(Token = "0x40025C7")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UILabel _progressLabel;

	[Token(Token = "0x40025C8")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Collider _downloadButton;

	[Token(Token = "0x40025C9")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UISprite _downloadButtonBackground;

	[Token(Token = "0x40025CA")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private UILabel _downloadButtonLabel;

	[Token(Token = "0x6002C56")]
	[Address(RVA = "0xB7474C", Offset = "0xB7474C", VA = "0xB7474C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002C57")]
	[Address(RVA = "0xB74B4C", Offset = "0xB74B4C", VA = "0xB74B4C", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002C58")]
	[Address(RVA = "0xB747F4", Offset = "0xB747F4", VA = "0xB747F4")]
	private void OnIsOnlineChanged(bool isOnline)
	{
	}

	[Token(Token = "0x6002C59")]
	[Address(RVA = "0xB7488C", Offset = "0xB7488C", VA = "0xB7488C")]
	private void OnProgressChanged(float progress)
	{
	}

	[Token(Token = "0x6002C5A")]
	[Address(RVA = "0xB74D8C", Offset = "0xB74D8C", VA = "0xB74D8C")]
	private void OnDownloadSizeChanged(long size)
	{
	}

	[Token(Token = "0x6002C5B")]
	[Address(RVA = "0xB74EC0", Offset = "0xB74EC0", VA = "0xB74EC0")]
	public PlayButtonDownloadView()
	{
	}
}
