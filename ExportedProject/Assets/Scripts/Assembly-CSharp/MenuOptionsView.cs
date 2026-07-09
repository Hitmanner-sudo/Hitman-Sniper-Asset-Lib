using System;
using Il2CppDummyDll;
using Technology.Core.Auth;
using Technology.Core.QualitySettings;
using UnityEngine;

[Token(Token = "0x20006AC")]
public class MenuOptionsView : PopupOverlayView
{
	[Token(Token = "0x4002530")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private UIGrid _settingsGrid;

	[Token(Token = "0x4002531")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private OptionsItemView _languageOption;

	[Token(Token = "0x4002532")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private OptionsItemView _musicOption;

	[Token(Token = "0x4002533")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private OptionsItemView _sfxOption;

	[Token(Token = "0x4002534")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private OptionsItemView _gameCenterLeaderboardOption;

	[Token(Token = "0x4002535")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private OptionsItemView _firstPartyLoginOption;

	[Token(Token = "0x4002536")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private OptionsItemView _cloudSaveOption;

	[Token(Token = "0x4002537")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private OptionsItemView _facebookOption;

	[Token(Token = "0x4002538")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	private OptionsItemView _qualityOption;

	[Token(Token = "0x4002539")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private GameObject _helpshiftNotificationCountObject;

	[Token(Token = "0x400253A")]
	[FieldOffset(Offset = "0x150")]
	private readonly string _originalDynamicQualitySetting;

	[Token(Token = "0x6002BB9")]
	[Address(RVA = "0x9BEB44", Offset = "0x9BEB44", VA = "0x9BEB44")]
	public void SetupPopupOverlay(Action cancelCallback, Action exitCallback)
	{
	}

	[Token(Token = "0x6002BBA")]
	[Address(RVA = "0x9BEC7C", Offset = "0x9BEC7C", VA = "0x9BEC7C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002BBB")]
	[Address(RVA = "0x9BF654", Offset = "0x9BF654", VA = "0x9BF654", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002BBC")]
	[Address(RVA = "0x9BF928", Offset = "0x9BF928", VA = "0x9BF928")]
	private void OnFacebookLoginEvent(object sender, AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6002BBD")]
	[Address(RVA = "0x9BFA34", Offset = "0x9BFA34", VA = "0x9BFA34")]
	private void OnLinkConfirmed(object sender, SocialManager.LinkEvent e)
	{
	}

	[Token(Token = "0x6002BBE")]
	[Address(RVA = "0x9BFA38", Offset = "0x9BFA38", VA = "0x9BFA38")]
	private static void OnLinkCancel(object sender, SocialManager.LinkEvent e)
	{
	}

	[Token(Token = "0x6002BBF")]
	[Address(RVA = "0x9BFA50", Offset = "0x9BFA50", VA = "0x9BFA50")]
	public static void OnNetworkError(SocialManager.LinkEvent.ErrorCodeEnum errorCode)
	{
	}

	[Token(Token = "0x6002BC0")]
	[Address(RVA = "0x9BEF04", Offset = "0x9BEF04", VA = "0x9BEF04")]
	public static bool IsQualityOptionEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6002BC1")]
	[Address(RVA = "0x9BFC88", Offset = "0x9BFC88", VA = "0x9BFC88")]
	public static int MapQualitySettingToOptionIndex(Quality quality)
	{
		return default(int);
	}

	[Token(Token = "0x6002BC2")]
	[Address(RVA = "0x9BF450", Offset = "0x9BF450", VA = "0x9BF450")]
	private void SetOptions()
	{
	}

	[Token(Token = "0x6002BC3")]
	[Address(RVA = "0x9BFCAC", Offset = "0x9BFCAC", VA = "0x9BFCAC")]
	private void SetLanguageItems()
	{
	}

	[Token(Token = "0x6002BC4")]
	[Address(RVA = "0x9BFE0C", Offset = "0x9BFE0C", VA = "0x9BFE0C", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002BC5")]
	[Address(RVA = "0x9BF00C", Offset = "0x9BF00C", VA = "0x9BF00C")]
	private void UpdateCloudSaveStatus()
	{
	}

	[Token(Token = "0x6002BC6")]
	[Address(RVA = "0x9BF300", Offset = "0x9BF300", VA = "0x9BF300")]
	private void UpdateFacebookStatus()
	{
	}

	[Token(Token = "0x6002BC7")]
	[Address(RVA = "0x9BFDE8", Offset = "0x9BFDE8", VA = "0x9BFDE8")]
	private void UpdateHelpshiftNotificationCount(int count)
	{
	}

	[Token(Token = "0x6002BC8")]
	[Address(RVA = "0x9BFFC0", Offset = "0x9BFFC0", VA = "0x9BFFC0")]
	public MenuOptionsView()
	{
	}
}
