using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200054D")]
public class ScoreTallyRewardController : UIController
{
	[Token(Token = "0x4001C1F")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BlinkButtonHandler _openButton;

	[Token(Token = "0x4001C20")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private BlinkButtonHandler _claimButton;

	[Token(Token = "0x6002145")]
	[Address(RVA = "0xB609F0", Offset = "0xB609F0", VA = "0xB609F0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002146")]
	[Address(RVA = "0xB60AE8", Offset = "0xB60AE8", VA = "0xB60AE8", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002147")]
	[Address(RVA = "0xB60BE0", Offset = "0xB60BE0", VA = "0xB60BE0", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6002148")]
	[Address(RVA = "0xB60D9C", Offset = "0xB60D9C", VA = "0xB60D9C")]
	private void OnOpenClicked(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6002149")]
	[Address(RVA = "0xB60FA4", Offset = "0xB60FA4", VA = "0xB60FA4")]
	private void OnClaimClicked(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x600214A")]
	[Address(RVA = "0xB610E4", Offset = "0xB610E4", VA = "0xB610E4")]
	public ScoreTallyRewardController()
	{
	}

	[Token(Token = "0x600214B")]
	[Address(RVA = "0xB610EC", Offset = "0xB610EC", VA = "0xB610EC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x619898", Offset = "0x619898")]
	private void _003COnOpenClicked_003Eb__5_0()
	{
	}
}
