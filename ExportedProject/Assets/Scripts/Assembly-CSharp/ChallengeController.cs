using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200050B")]
public class ChallengeController : UIController
{
	[Token(Token = "0x4001AC7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BlinkButtonHandler _startBlinkButtonHandler;

	[Token(Token = "0x6001EFF")]
	[Address(RVA = "0xAF2F88", Offset = "0xAF2F88", VA = "0xAF2F88", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001F00")]
	[Address(RVA = "0xAF3034", Offset = "0xAF3034", VA = "0xAF3034", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001F01")]
	[Address(RVA = "0xAF312C", Offset = "0xAF312C", VA = "0xAF312C")]
	private void StartButtonBlinkFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6001F02")]
	[Address(RVA = "0xAF31F0", Offset = "0xAF31F0", VA = "0xAF31F0")]
	private void OnInternetReachabilityTestComplete(bool isReachable)
	{
	}

	[Token(Token = "0x6001F03")]
	[Address(RVA = "0xAF336C", Offset = "0xAF336C", VA = "0xAF336C")]
	private void LoadLevel()
	{
	}

	[Token(Token = "0x6001F04")]
	[Address(RVA = "0xAF3400", Offset = "0xAF3400", VA = "0xAF3400")]
	public ChallengeController()
	{
	}
}
