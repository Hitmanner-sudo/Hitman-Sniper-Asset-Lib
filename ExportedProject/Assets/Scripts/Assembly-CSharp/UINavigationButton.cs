using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000636")]
public class UINavigationButton : GameMonoBehaviour
{
	[Token(Token = "0x4002238")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ButtonHandler _buttonHandler;

	[Token(Token = "0x4002239")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UINavigationHelper.UINavigationType _navigationType;

	[Token(Token = "0x400223A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private string _stringParameter;

	[Token(Token = "0x400223B")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private string _stringParameter2;

	[Token(Token = "0x400223C")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private string _stringParameter3;

	[Token(Token = "0x400223D")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private ModesModel.MenuPages _menuPageParameter;

	[Token(Token = "0x400223E")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private LazyWeaponUnlockable _lazyWeaponUnlockableParameter;

	[Token(Token = "0x400223F")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private bool _boolParameter;

	[Token(Token = "0x4002240")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UITexture _uiTextureParameter;

	[Token(Token = "0x6002828")]
	[Address(RVA = "0x1424750", Offset = "0x1424750", VA = "0x1424750", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002829")]
	[Address(RVA = "0x1424930", Offset = "0x1424930", VA = "0x1424930", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600282A")]
	[Address(RVA = "0x1424B40", Offset = "0x1424B40", VA = "0x1424B40")]
	private void OnClickFinished(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600282B")]
	[Address(RVA = "0x1424EE4", Offset = "0x1424EE4", VA = "0x1424EE4")]
	public UINavigationButton()
	{
	}
}
