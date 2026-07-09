using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000552")]
public class WeaponCustomizationController : UIController
{
	[Token(Token = "0x4001C3D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BlinkButtonHandler _closeButton;

	[Token(Token = "0x4001C3E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private BlinkButtonHandler _leftArrow;

	[Token(Token = "0x4001C3F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private BlinkButtonHandler _rightArrow;

	[Token(Token = "0x6002184")]
	[Address(RVA = "0x9842F4", Offset = "0x9842F4", VA = "0x9842F4", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002185")]
	[Address(RVA = "0x9843D0", Offset = "0x9843D0", VA = "0x9843D0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002186")]
	[Address(RVA = "0x98453C", Offset = "0x98453C", VA = "0x98453C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002187")]
	[Address(RVA = "0x9846A0", Offset = "0x9846A0", VA = "0x9846A0")]
	private void OnCloseButtonFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002188")]
	[Address(RVA = "0x98482C", Offset = "0x98482C", VA = "0x98482C")]
	private void OnLeftArrowClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002189")]
	[Address(RVA = "0x9848A0", Offset = "0x9848A0", VA = "0x9848A0")]
	private void OnRightArrowClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600218A")]
	[Address(RVA = "0x984914", Offset = "0x984914", VA = "0x984914")]
	public void ForceClickCloseButton()
	{
	}

	[Token(Token = "0x600218B")]
	[Address(RVA = "0x98493C", Offset = "0x98493C", VA = "0x98493C")]
	public WeaponCustomizationController()
	{
	}
}
