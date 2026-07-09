using System;
using Il2CppDummyDll;
using Technology;
using Technology.Social;
using UnityEngine;

[Token(Token = "0x2000520")]
public class LeaderboardController : UIController
{
	[Token(Token = "0x2000521")]
	private class FacebookIncentiveState
	{
		[Token(Token = "0x4001B1C")]
		[FieldOffset(Offset = "0x0")]
		public static FacebookIncentiveState Instance;

		[Token(Token = "0x4001B1D")]
		[FieldOffset(Offset = "0x10")]
		public bool ExplicitLogin;

		[Token(Token = "0x4001B1E")]
		[FieldOffset(Offset = "0x18")]
		public Wallet.CurrencyAmount CurrencyAmount;

		[Token(Token = "0x6001FCF")]
		[Address(RVA = "0xB2EE54", Offset = "0xB2EE54", VA = "0xB2EE54")]
		public void TryLogin()
		{
		}

		[Token(Token = "0x6001FD0")]
		[Address(RVA = "0xB2F25C", Offset = "0xB2F25C", VA = "0xB2F25C")]
		private void ShowPander()
		{
		}

		[Token(Token = "0x6001FD1")]
		[Address(RVA = "0xB2F464", Offset = "0xB2F464", VA = "0xB2F464")]
		private void BeginLogin()
		{
		}

		[Token(Token = "0x6001FD2")]
		[Address(RVA = "0xB2F170", Offset = "0xB2F170", VA = "0xB2F170")]
		private void BeginLogin(bool clearPopup)
		{
		}

		[Token(Token = "0x6001FD3")]
		[Address(RVA = "0xB2F46C", Offset = "0xB2F46C", VA = "0xB2F46C")]
		public FacebookIncentiveState()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000522")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594FF0", Offset = "0x594FF0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001B1F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001B20")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LeaderboardRecord, bool> _003C_003E9__27_0;

		[Token(Token = "0x4001B21")]
		[FieldOffset(Offset = "0x10")]
		public static Func<LeaderboardRecord, string> _003C_003E9__27_1;

		[Token(Token = "0x4001B22")]
		[FieldOffset(Offset = "0x18")]
		public static Action _003C_003E9__34_2;

		[Token(Token = "0x4001B23")]
		[FieldOffset(Offset = "0x20")]
		public static Action<BlockingOnlineRequestManager.ReqHandle> _003C_003E9__34_0;

		[Token(Token = "0x4001B24")]
		[FieldOffset(Offset = "0x28")]
		public static Action<BlockingOnlineRequestManager.ReqHandle> _003C_003E9__34_1;

		[Token(Token = "0x4001B25")]
		[FieldOffset(Offset = "0x30")]
		public static Predicate<LeaderboardRecord> _003C_003E9__40_0;

		[Token(Token = "0x6001FD5")]
		[Address(RVA = "0xB2EC1C", Offset = "0xB2EC1C", VA = "0xB2EC1C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001FD6")]
		[Address(RVA = "0xB2EC24", Offset = "0xB2EC24", VA = "0xB2EC24")]
		internal bool _003CUpdate_003Eb__27_0(LeaderboardRecord r)
		{
			return default(bool);
		}

		[Token(Token = "0x6001FD7")]
		[Address(RVA = "0xB2EC50", Offset = "0xB2EC50", VA = "0xB2EC50")]
		internal string _003CUpdate_003Eb__27_1(LeaderboardRecord r)
		{
			return null;
		}

		[Token(Token = "0x6001FD8")]
		[Address(RVA = "0xB2EC68", Offset = "0xB2EC68", VA = "0xB2EC68")]
		internal void _003CLoginToFacebook_003Eb__34_0(BlockingOnlineRequestManager.ReqHandle h)
		{
		}

		[Token(Token = "0x6001FD9")]
		[Address(RVA = "0xB2EE18", Offset = "0xB2EE18", VA = "0xB2EE18")]
		internal void _003CLoginToFacebook_003Eb__34_2()
		{
		}

		[Token(Token = "0x6001FDA")]
		[Address(RVA = "0xB2EE1C", Offset = "0xB2EE1C", VA = "0xB2EE1C")]
		internal void _003CLoginToFacebook_003Eb__34_1(BlockingOnlineRequestManager.ReqHandle h)
		{
		}

		[Token(Token = "0x6001FDB")]
		[Address(RVA = "0xB2EE20", Offset = "0xB2EE20", VA = "0xB2EE20")]
		internal bool _003CUpdatePlayerTier_003Eb__40_0(LeaderboardRecord r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000523")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595000", Offset = "0x595000")]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		[Token(Token = "0x4001B26")]
		[FieldOffset(Offset = "0x10")]
		public LeaderboardConfiguration.Tier majorTier;

		[Token(Token = "0x6001FDC")]
		[Address(RVA = "0xB2EE3C", Offset = "0xB2EE3C", VA = "0xB2EE3C")]
		public _003C_003Ec__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6001FDD")]
		[Address(RVA = "0xB2EE44", Offset = "0xB2EE44", VA = "0xB2EE44")]
		internal bool _003CUpdatePlayerTier_003Eb__1(LeaderboardConfiguration.Tier x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001B0A")]
	[FieldOffset(Offset = "0x50")]
	public BlinkButtonHandler InviteButton;

	[Token(Token = "0x4001B0B")]
	[FieldOffset(Offset = "0x58")]
	public ButtonHandler GlobalFriendsCategoryButton;

	[Token(Token = "0x4001B0C")]
	[FieldOffset(Offset = "0x60")]
	public ButtonHandler FriendsTierCategoryButton;

	[Token(Token = "0x4001B0D")]
	[FieldOffset(Offset = "0x68")]
	public GameObject LoginToFacebookNoIncentive;

	[Token(Token = "0x4001B0E")]
	[FieldOffset(Offset = "0x70")]
	public GameObject LoginToFacebookIncentive;

	[Token(Token = "0x4001B0F")]
	[FieldOffset(Offset = "0x78")]
	public UILabel IncentiveAmountLabel;

	[Token(Token = "0x4001B10")]
	[FieldOffset(Offset = "0x80")]
	public GameObject NotConnectObject;

	[Token(Token = "0x4001B11")]
	[FieldOffset(Offset = "0x88")]
	public BlinkButtonHandler NotConnectedFacebookButton;

	[Token(Token = "0x4001B12")]
	[FieldOffset(Offset = "0x90")]
	public BlinkButtonHandler NotConnectedGameCenterButton;

	[Token(Token = "0x4001B13")]
	[FieldOffset(Offset = "0x98")]
	public Transform Drawer;

	[Token(Token = "0x4001B14")]
	[FieldOffset(Offset = "0xA0")]
	public float DrawerDragOpenThreshold;

	[Token(Token = "0x4001B15")]
	[FieldOffset(Offset = "0xA8")]
	public PopupFriendInvite FriendInvitePopupPrefab;

	[Token(Token = "0x4001B16")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private LeaderboardFriendManagementView _friendView;

	[Token(Token = "0x4001B17")]
	[FieldOffset(Offset = "0xB8")]
	private bool _refreshLeaderboard;

	[Token(Token = "0x4001B18")]
	[FieldOffset(Offset = "0xB9")]
	private bool _readyToShowInviteFriendDialog;

	[Token(Token = "0x4001B19")]
	[FieldOffset(Offset = "0xBA")]
	private bool _readyToShowFacebookInviteFriend;

	[Token(Token = "0x4001B1A")]
	[FieldOffset(Offset = "0xC0")]
	private LeaderboardConfiguration _leaderboardConfiguration;

	[Token(Token = "0x4001B1B")]
	[FieldOffset(Offset = "0xC8")]
	private bool _hasShownNotConnectedPopUp;

	[Token(Token = "0x6001FAF")]
	[Address(RVA = "0x999CA4", Offset = "0x999CA4", VA = "0x999CA4", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001FB0")]
	[Address(RVA = "0x999F3C", Offset = "0x999F3C", VA = "0x999F3C", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001FB1")]
	[Address(RVA = "0x99A038", Offset = "0x99A038", VA = "0x99A038", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001FB2")]
	[Address(RVA = "0x99A254", Offset = "0x99A254", VA = "0x99A254")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6001FB3")]
	[Address(RVA = "0x99ADBC", Offset = "0x99ADBC", VA = "0x99ADBC", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001FB4")]
	[Address(RVA = "0x99B5D4", Offset = "0x99B5D4", VA = "0x99B5D4", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001FB5")]
	[Address(RVA = "0x99BD30", Offset = "0x99BD30", VA = "0x99BD30")]
	private void OnCategoryClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6001FB6")]
	[Address(RVA = "0x99BDD0", Offset = "0x99BDD0", VA = "0x99BDD0")]
	private static void OnSendOrCancelClicked()
	{
	}

	[Token(Token = "0x6001FB7")]
	[Address(RVA = "0x99BE50", Offset = "0x99BE50", VA = "0x99BE50")]
	private void OnFacebookClicked()
	{
	}

	[Token(Token = "0x6001FB8")]
	[Address(RVA = "0x99BFC4", Offset = "0x99BFC4", VA = "0x99BFC4")]
	protected void Update()
	{
	}

	[Token(Token = "0x6001FB9")]
	[Address(RVA = "0x99C874", Offset = "0x99C874", VA = "0x99C874")]
	protected void OnApplicationPause(bool isPaused)
	{
	}

	[Token(Token = "0x6001FBA")]
	[Address(RVA = "0x99C884", Offset = "0x99C884", VA = "0x99C884")]
	private void OnInviteButtonClicked(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6001FBB")]
	[Address(RVA = "0x99C8AC", Offset = "0x99C8AC", VA = "0x99C8AC")]
	private static void OnLoginToFacebookClicked(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6001FBC")]
	[Address(RVA = "0x99BE78", Offset = "0x99BE78", VA = "0x99BE78")]
	public static void AttemptFacebookLogin()
	{
	}

	[Token(Token = "0x6001FBD")]
	[Address(RVA = "0x99C8B0", Offset = "0x99C8B0", VA = "0x99C8B0")]
	private static void OnLoginToFirstPartySocialClicked(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6001FBE")]
	[Address(RVA = "0x99C8B4", Offset = "0x99C8B4", VA = "0x99C8B4")]
	private static void ConnectToFirstPartySocial()
	{
	}

	[Token(Token = "0x6001FBF")]
	[Address(RVA = "0x99C934", Offset = "0x99C934", VA = "0x99C934")]
	private static void LoginToFacebook()
	{
	}

	[Token(Token = "0x6001FC0")]
	[Address(RVA = "0x999F54", Offset = "0x999F54", VA = "0x999F54")]
	private static void Autologin()
	{
	}

	[Token(Token = "0x6001FC1")]
	[Address(RVA = "0x99CB40", Offset = "0x99CB40", VA = "0x99CB40")]
	private void OnProfileRefreshed(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001FC2")]
	[Address(RVA = "0x99CB44", Offset = "0x99CB44", VA = "0x99CB44")]
	private void OnScorePosted(bool success)
	{
	}

	[Token(Token = "0x6001FC3")]
	[Address(RVA = "0x99CCB4", Offset = "0x99CCB4", VA = "0x99CCB4")]
	private void OnFirstPartySocialConfirmed(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001FC4")]
	[Address(RVA = "0x99A460", Offset = "0x99A460", VA = "0x99A460")]
	private void RefreshConnectionStatus()
	{
	}

	[Token(Token = "0x6001FC5")]
	[Address(RVA = "0x99A7D0", Offset = "0x99A7D0", VA = "0x99A7D0")]
	private void UpdatePlayerTier()
	{
	}

	[Token(Token = "0x6001FC6")]
	[Address(RVA = "0x99D104", Offset = "0x99D104", VA = "0x99D104")]
	private void SetTierInSaveGame(int index)
	{
	}

	[Token(Token = "0x6001FC7")]
	[Address(RVA = "0x99D498", Offset = "0x99D498", VA = "0x99D498")]
	private void OnSocialDialogSuccess(object sender, FacebookDialogEvent args)
	{
	}

	[Token(Token = "0x6001FC8")]
	[Address(RVA = "0x99DD98", Offset = "0x99DD98", VA = "0x99DD98")]
	private static void OnSocialDialogFailed(object sender, FacebookDialogEvent args)
	{
	}

	[Token(Token = "0x6001FC9")]
	[Address(RVA = "0x99D8AC", Offset = "0x99D8AC", VA = "0x99D8AC")]
	public void CreateFriendInviteRewardPopup(int softCount)
	{
	}

	[Token(Token = "0x6001FCA")]
	[Address(RVA = "0x99D78C", Offset = "0x99D78C", VA = "0x99D78C")]
	private static void GiveReward(int maxPlayerInvite, Wallet.CurrencyAmount reward, int totalCount, out int rewardCount)
	{
	}

	[Token(Token = "0x6001FCB")]
	[Address(RVA = "0x99DF3C", Offset = "0x99DF3C", VA = "0x99DF3C")]
	private void OnLinkConfirmed(object sender, SocialManager.LinkEvent args)
	{
	}

	[Token(Token = "0x6001FCC")]
	[Address(RVA = "0x99DF60", Offset = "0x99DF60", VA = "0x99DF60")]
	private void OnLinkCancel(object sender, SocialManager.LinkEvent args)
	{
	}

	[Token(Token = "0x6001FCD")]
	[Address(RVA = "0x99DF70", Offset = "0x99DF70", VA = "0x99DF70")]
	private void OnDeepLinkFriendCountChanged()
	{
	}

	[Token(Token = "0x6001FCE")]
	[Address(RVA = "0x99DF7C", Offset = "0x99DF7C", VA = "0x99DF7C")]
	public LeaderboardController()
	{
	}
}
