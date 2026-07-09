using System;
using Il2CppDummyDll;
using Technology.Core.Auth;
using UnityEngine;

[Token(Token = "0x2000526")]
public class MenuOptionsController : UIController
{
	[Serializable]
	[Token(Token = "0x2000527")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595010", Offset = "0x595010")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001B40")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001B41")]
		[FieldOffset(Offset = "0x8")]
		public static Action _003C_003E9__25_0;

		[Token(Token = "0x4001B42")]
		[FieldOffset(Offset = "0x10")]
		public static Action _003C_003E9__25_1;

		[Token(Token = "0x4001B43")]
		[FieldOffset(Offset = "0x18")]
		public static Action _003C_003E9__37_0;

		[Token(Token = "0x4001B44")]
		[FieldOffset(Offset = "0x20")]
		public static Action _003C_003E9__37_1;

		[Token(Token = "0x4001B45")]
		[FieldOffset(Offset = "0x28")]
		public static Action _003C_003E9__38_2;

		[Token(Token = "0x4001B46")]
		[FieldOffset(Offset = "0x30")]
		public static Action<BlockingOnlineRequestManager.ReqHandle> _003C_003E9__38_0;

		[Token(Token = "0x4001B47")]
		[FieldOffset(Offset = "0x38")]
		public static Action<BlockingOnlineRequestManager.ReqHandle> _003C_003E9__38_1;

		[Token(Token = "0x6002006")]
		[Address(RVA = "0x8C7148", Offset = "0x8C7148", VA = "0x8C7148")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002007")]
		[Address(RVA = "0x8C7150", Offset = "0x8C7150", VA = "0x8C7150")]
		internal void _003COnResetMissionsProgressClicked_003Eb__25_0()
		{
		}

		[Token(Token = "0x6002008")]
		[Address(RVA = "0x8C72F4", Offset = "0x8C72F4", VA = "0x8C72F4")]
		internal void _003COnResetMissionsProgressClicked_003Eb__25_1()
		{
		}

		[Token(Token = "0x6002009")]
		[Address(RVA = "0x8C73B8", Offset = "0x8C73B8", VA = "0x8C73B8")]
		internal void _003COnCloudSave_003Eb__37_0()
		{
		}

		[Token(Token = "0x600200A")]
		[Address(RVA = "0x8C748C", Offset = "0x8C748C", VA = "0x8C748C")]
		internal void _003COnCloudSave_003Eb__37_1()
		{
		}

		[Token(Token = "0x600200B")]
		[Address(RVA = "0x8C750C", Offset = "0x8C750C", VA = "0x8C750C")]
		internal void _003COnFacebookLogin_003Eb__38_0(BlockingOnlineRequestManager.ReqHandle h)
		{
		}

		[Token(Token = "0x600200C")]
		[Address(RVA = "0x8C76B8", Offset = "0x8C76B8", VA = "0x8C76B8")]
		internal void _003COnFacebookLogin_003Eb__38_2()
		{
		}

		[Token(Token = "0x600200D")]
		[Address(RVA = "0x8C76BC", Offset = "0x8C76BC", VA = "0x8C76BC")]
		internal void _003COnFacebookLogin_003Eb__38_1(BlockingOnlineRequestManager.ReqHandle h)
		{
		}
	}

	[Token(Token = "0x2000528")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595020", Offset = "0x595020")]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[Token(Token = "0x4001B48")]
		[FieldOffset(Offset = "0x10")]
		public ModeView modeView;

		[Token(Token = "0x4001B49")]
		[FieldOffset(Offset = "0x18")]
		public EventHandler<View.ViewChangeEventArgs> callback;

		[Token(Token = "0x600200E")]
		[Address(RVA = "0x8C76C8", Offset = "0x8C76C8", VA = "0x8C76C8")]
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		[Token(Token = "0x600200F")]
		[Address(RVA = "0x8C76D0", Offset = "0x8C76D0", VA = "0x8C76D0")]
		internal void _003COnRestorePurchasesCompleted_003Eb__0(object s, View.ViewChangeEventArgs a)
		{
		}
	}

	[Token(Token = "0x4001B2C")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UIGrid _settingsGrid;

	[Token(Token = "0x4001B2D")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private OptionsItemView _languageOption;

	[Token(Token = "0x4001B2E")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private OptionsItemView _restorePurchasesOption;

	[Token(Token = "0x4001B2F")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private OptionsItemView _creditsOption;

	[Token(Token = "0x4001B30")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private OptionsItemView _musicOption;

	[Token(Token = "0x4001B31")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private OptionsItemView _sfxOption;

	[Token(Token = "0x4001B32")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private OptionsItemView _feedbackOption;

	[Token(Token = "0x4001B33")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private OptionsItemView _gameCenterLeaderboardOption;

	[Token(Token = "0x4001B34")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private OptionsItemView _firstPartLoginOption;

	[Token(Token = "0x4001B35")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private OptionsItemView _cloudSaveOption;

	[Token(Token = "0x4001B36")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private OptionsItemView _facebookOption;

	[Token(Token = "0x4001B37")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private OptionsItemView _eula;

	[Token(Token = "0x4001B38")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private OptionsItemView _privacyPolicy;

	[Token(Token = "0x4001B39")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private OptionsItemView _qualityOption;

	[Token(Token = "0x4001B3A")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private OptionsItemView _resetMissionsProgressOption;

	[Token(Token = "0x4001B3B")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private CreditsView _creditsView;

	[Token(Token = "0x4001B3C")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private GameObject _settingsView;

	[Token(Token = "0x4001B3D")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private PopupOptionConfirmation _resetMissionsConfirmationPopupPrefab;

	[Token(Token = "0x4001B3E")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private PopupClientInfo _clientInfoPopupPrefab;

	[Token(Token = "0x4001B3F")]
	[FieldOffset(Offset = "0xE8")]
	private readonly RestorePurchaseController _restorePurchaseController;

	[Token(Token = "0x6001FE8")]
	[Address(RVA = "0x9BBDC0", Offset = "0x9BBDC0", VA = "0x9BBDC0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001FE9")]
	[Address(RVA = "0x9BC680", Offset = "0x9BC680", VA = "0x9BC680", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001FEA")]
	[Address(RVA = "0x9BCCA8", Offset = "0x9BCCA8", VA = "0x9BCCA8")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs e)
	{
	}

	[Token(Token = "0x6001FEB")]
	[Address(RVA = "0x9BC628", Offset = "0x9BC628", VA = "0x9BC628")]
	private void OnShowCreditsChanged(bool show)
	{
	}

	[Token(Token = "0x6001FEC")]
	[Address(RVA = "0x9BCD98", Offset = "0x9BCD98", VA = "0x9BCD98")]
	private void OnQualityChanged(int itemIndex, string itemName)
	{
	}

	[Token(Token = "0x6001FED")]
	[Address(RVA = "0x9BCE48", Offset = "0x9BCE48", VA = "0x9BCE48")]
	private void OnResetMissionsProgressClicked()
	{
	}

	[Token(Token = "0x6001FEE")]
	[Address(RVA = "0x9BD324", Offset = "0x9BD324", VA = "0x9BD324")]
	private static void OnLanguageChanged(int itemIndex, string itemName)
	{
	}

	[Token(Token = "0x6001FEF")]
	[Address(RVA = "0x9BD388", Offset = "0x9BD388", VA = "0x9BD388")]
	private int OnLanguageGetNewItemIndex(int delta)
	{
		return default(int);
	}

	[Token(Token = "0x6001FF0")]
	[Address(RVA = "0x9BD44C", Offset = "0x9BD44C", VA = "0x9BD44C")]
	private static void OnRestorePurchasesCompleted()
	{
	}

	[Token(Token = "0x6001FF1")]
	[Address(RVA = "0x9BD604", Offset = "0x9BD604", VA = "0x9BD604")]
	private static void OnGameCenterLeaderboard()
	{
	}

	[Token(Token = "0x6001FF2")]
	[Address(RVA = "0x9BD608", Offset = "0x9BD608", VA = "0x9BD608")]
	private void OnFirstPartyLogin()
	{
	}

	[Token(Token = "0x6001FF3")]
	[Address(RVA = "0x9BD60C", Offset = "0x9BD60C", VA = "0x9BD60C")]
	private void OnPlayGameServicesToggle()
	{
	}

	[Token(Token = "0x6001FF4")]
	[Address(RVA = "0x9BD6F8", Offset = "0x9BD6F8", VA = "0x9BD6F8")]
	private void AddGooglePlayServicesListeners()
	{
	}

	[Token(Token = "0x6001FF5")]
	[Address(RVA = "0x9BD7F8", Offset = "0x9BD7F8", VA = "0x9BD7F8")]
	private void RemoveGooglePlayServicesListeners()
	{
	}

	[Token(Token = "0x6001FF6")]
	[Address(RVA = "0x9BD8F8", Offset = "0x9BD8F8", VA = "0x9BD8F8")]
	private void OnGooglePlayServicesLoginEvent(object sender, AuthenticationEvent args)
	{
	}

	[Token(Token = "0x6001FF7")]
	[Address(RVA = "0x9BD990", Offset = "0x9BD990", VA = "0x9BD990")]
	private void OnGooglePlayServicesDisconnectEvent(object sender, AuthenticationEvent args)
	{
	}

	[Token(Token = "0x6001FF8")]
	[Address(RVA = "0x9BC4D8", Offset = "0x9BC4D8", VA = "0x9BC4D8")]
	private void UpdatePlayGameServiceLoginValue()
	{
	}

	[Token(Token = "0x6001FF9")]
	[Address(RVA = "0x9BDA28", Offset = "0x9BDA28", VA = "0x9BDA28")]
	private static void OnCloudSave()
	{
	}

	[Token(Token = "0x6001FFA")]
	[Address(RVA = "0x9BDE54", Offset = "0x9BDE54", VA = "0x9BDE54")]
	private static void OnFacebookLogin()
	{
	}

	[Token(Token = "0x6001FFB")]
	[Address(RVA = "0x9BE1C8", Offset = "0x9BE1C8", VA = "0x9BE1C8")]
	public static void OnMusicVolumeChanged(int itemIndex, string itemName)
	{
	}

	[Token(Token = "0x6001FFC")]
	[Address(RVA = "0x9BE310", Offset = "0x9BE310", VA = "0x9BE310")]
	public static void OnSFXVolumeChanged(int itemIndex, string itemName)
	{
	}

	[Token(Token = "0x6001FFD")]
	[Address(RVA = "0x9BE4E4", Offset = "0x9BE4E4", VA = "0x9BE4E4")]
	private static void OnPrivacyPolicyClicked()
	{
	}

	[Token(Token = "0x6001FFE")]
	[Address(RVA = "0x9BE574", Offset = "0x9BE574", VA = "0x9BE574")]
	private static void OnTermsOfServiceClicked()
	{
	}

	[Token(Token = "0x6001FFF")]
	[Address(RVA = "0x9BE604", Offset = "0x9BE604", VA = "0x9BE604")]
	private static void OnFeedbackClicked()
	{
	}

	[Token(Token = "0x6002000")]
	[Address(RVA = "0x9BE684", Offset = "0x9BE684", VA = "0x9BE684")]
	private void OnFeedbackLongPress()
	{
	}

	[Token(Token = "0x6002001")]
	[Address(RVA = "0x9BE750", Offset = "0x9BE750", VA = "0x9BE750")]
	private void OnCreditsClicked()
	{
	}

	[Token(Token = "0x6002002")]
	[Address(RVA = "0x9BDDE8", Offset = "0x9BDDE8", VA = "0x9BDDE8")]
	public static bool CanCloudSync()
	{
		return default(bool);
	}

	[Token(Token = "0x6002003")]
	[Address(RVA = "0x9BCE2C", Offset = "0x9BCE2C", VA = "0x9BCE2C")]
	private static int MapOptionIndexToQualitySetting(int itemIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6002004")]
	[Address(RVA = "0x9BE7C4", Offset = "0x9BE7C4", VA = "0x9BE7C4")]
	public MenuOptionsController()
	{
	}
}
