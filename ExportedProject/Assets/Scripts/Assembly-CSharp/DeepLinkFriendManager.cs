using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core;
using Technology.Social;
using UnityEngine;

[Token(Token = "0x2000498")]
[AttributeAttribute(Name = "ResourcePathAttribute", RVA = "0x594BE0", Offset = "0x594BE0")]
public class DeepLinkFriendManager : ScriptableSingleton<DeepLinkFriendManager>
{
	[Token(Token = "0x2000499")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594C18", Offset = "0x594C18")]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		[Token(Token = "0x40018E7")]
		[FieldOffset(Offset = "0x10")]
		public PopupManager pm;

		[Token(Token = "0x40018E8")]
		[FieldOffset(Offset = "0x18")]
		public DeepLinkFriendManager _003C_003E4__this;

		[Token(Token = "0x40018E9")]
		[FieldOffset(Offset = "0x20")]
		public PopupFriendManagement.Info info;

		[Token(Token = "0x6001BFD")]
		[Address(RVA = "0x86B6D4", Offset = "0x86B6D4", VA = "0x86B6D4")]
		public _003C_003Ec__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6001BFE")]
		[Address(RVA = "0x86B6DC", Offset = "0x86B6DC", VA = "0x86B6DC")]
		internal void _003CShowInfoPopup_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200049A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594C28", Offset = "0x594C28")]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		[Token(Token = "0x40018EA")]
		[FieldOffset(Offset = "0x10")]
		public PopupManager pm;

		[Token(Token = "0x40018EB")]
		[FieldOffset(Offset = "0x18")]
		public DeepLinkFriendManager _003C_003E4__this;

		[Token(Token = "0x40018EC")]
		[FieldOffset(Offset = "0x20")]
		public PopupFriendManagement.Info info;

		[Token(Token = "0x40018ED")]
		[FieldOffset(Offset = "0x28")]
		public Action onConfirm;

		[Token(Token = "0x40018EE")]
		[FieldOffset(Offset = "0x30")]
		public Action onCancel;

		[Token(Token = "0x40018EF")]
		[FieldOffset(Offset = "0x38")]
		public LeaderboardRecord record;

		[Token(Token = "0x6001BFF")]
		[Address(RVA = "0x86B850", Offset = "0x86B850", VA = "0x86B850")]
		public _003C_003Ec__DisplayClass41_0()
		{
		}

		[Token(Token = "0x6001C00")]
		[Address(RVA = "0x86B858", Offset = "0x86B858", VA = "0x86B858")]
		internal void _003CShowConfirmPopup_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200049B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594C38", Offset = "0x594C38")]
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		[Token(Token = "0x40018F0")]
		[FieldOffset(Offset = "0x10")]
		public PopupManager pm;

		[Token(Token = "0x40018F1")]
		[FieldOffset(Offset = "0x18")]
		public PopupOverlayViewBase previousPopup;

		[Token(Token = "0x6001C01")]
		[Address(RVA = "0x86B9B4", Offset = "0x86B9B4", VA = "0x86B9B4")]
		public _003C_003Ec__DisplayClass42_0()
		{
		}

		[Token(Token = "0x6001C02")]
		[Address(RVA = "0x86B9BC", Offset = "0x86B9BC", VA = "0x86B9BC")]
		internal void _003CTryShowShareLinkInfoPopup_003Eb__0()
		{
		}
	}

	[Token(Token = "0x40018D7")]
	private const string REFERRER_KEY = "referrer";

	[Token(Token = "0x40018D8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int _maxNumFriends;

	[Token(Token = "0x40018D9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PopupFriendManagement _popupPrefab;

	[Token(Token = "0x40018DA")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private PopupFriendManagement.Info _alreadyFriends;

	[Token(Token = "0x40018DB")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private PopupFriendManagement.Info _maxFriends;

	[Token(Token = "0x40018DC")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private PopupFriendManagement.Info _selfFriend;

	[Token(Token = "0x40018DD")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private PopupFriendManagement.Info _friendRequestInfo;

	[Token(Token = "0x40018DE")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private PopupFriendManagement.Info _friendDeleteInfo;

	[Token(Token = "0x40018DF")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private PopupFriendManagement.Info _playerDoesntExist;

	[Token(Token = "0x40018E0")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private PopupFriendManagement.Info _requestSendSuccess;

	[Token(Token = "0x40018E1")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private PopupFriendManagement.Info _requestSendFailure;

	[Token(Token = "0x40018E2")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private PopupFriendManagement.Info _deleteSendSuccess;

	[Token(Token = "0x40018E3")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private PopupFriendManagement.Info _deleteSendFailure;

	[Token(Token = "0x40018E4")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private PopupFriendManagement.Info _linkShareInfo;

	[Token(Token = "0x40018E5")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private LazyDataModel _modeModel;

	[Token(Token = "0x40018E6")]
	[FieldOffset(Offset = "0x88")]
	private string _lastSidClicked;

	[Token(Token = "0x1700044B")]
	public int MaxNumFriends
	{
		[Token(Token = "0x6001BDC")]
		[Address(RVA = "0xAED004", Offset = "0xAED004", VA = "0xAED004")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700044C")]
	public PopupFriendManagement.Info FriendRequestInfo
	{
		[Token(Token = "0x6001BDD")]
		[Address(RVA = "0xAED00C", Offset = "0xAED00C", VA = "0xAED00C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700044D")]
	public PopupFriendManagement.Info FriendDeleteInfo
	{
		[Token(Token = "0x6001BDE")]
		[Address(RVA = "0xAED014", Offset = "0xAED014", VA = "0xAED014")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700044E")]
	public PopupFriendManagement.Info PlayerDoenstExist
	{
		[Token(Token = "0x6001BDF")]
		[Address(RVA = "0xAED01C", Offset = "0xAED01C", VA = "0xAED01C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700044F")]
	public PopupFriendManagement.Info RequestSendSuccess
	{
		[Token(Token = "0x6001BE0")]
		[Address(RVA = "0xAED024", Offset = "0xAED024", VA = "0xAED024")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000450")]
	public PopupFriendManagement.Info RequestSendFailure
	{
		[Token(Token = "0x6001BE1")]
		[Address(RVA = "0xAED02C", Offset = "0xAED02C", VA = "0xAED02C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000451")]
	public PopupFriendManagement.Info DeleteSendSuccess
	{
		[Token(Token = "0x6001BE2")]
		[Address(RVA = "0xAED034", Offset = "0xAED034", VA = "0xAED034")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000452")]
	public PopupFriendManagement.Info DeleteSendFailure
	{
		[Token(Token = "0x6001BE3")]
		[Address(RVA = "0xAED03C", Offset = "0xAED03C", VA = "0xAED03C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000453")]
	private static DeepLinkFriendData FriendData
	{
		[Token(Token = "0x6001BE4")]
		[Address(RVA = "0xAED044", Offset = "0xAED044", VA = "0xAED044")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001BE5")]
	[Address(RVA = "0xAED0CC", Offset = "0xAED0CC", VA = "0xAED0CC", Slot = "4")]
	protected override void Initialize()
	{
	}

	[Token(Token = "0x6001BE6")]
	[Address(RVA = "0xAED388", Offset = "0xAED388", VA = "0xAED388")]
	public void StartFriendRequestSend(string friendSid)
	{
	}

	[Token(Token = "0x6001BE7")]
	[Address(RVA = "0xAED498", Offset = "0xAED498", VA = "0xAED498")]
	public void FriendRequestReceived(string friendSid)
	{
	}

	[Token(Token = "0x6001BE8")]
	[Address(RVA = "0xAED4C4", Offset = "0xAED4C4", VA = "0xAED4C4")]
	public void StartFriendDeleteSend(LeaderboardRecord record)
	{
	}

	[Token(Token = "0x6001BE9")]
	[Address(RVA = "0xAED558", Offset = "0xAED558", VA = "0xAED558")]
	public void FriendDeleted(string friendSid)
	{
	}

	[Token(Token = "0x6001BEA")]
	[Address(RVA = "0xAED584", Offset = "0xAED584", VA = "0xAED584")]
	public void TrySendPending()
	{
	}

	[Token(Token = "0x6001BEB")]
	[Address(RVA = "0xAECEF0", Offset = "0xAECEF0", VA = "0xAECEF0")]
	public void ShowInfoPopup(PopupFriendManagement.Info info)
	{
	}

	[Token(Token = "0x6001BEC")]
	[Address(RVA = "0xAED60C", Offset = "0xAED60C", VA = "0xAED60C")]
	public void ShowConfirmPopup(PopupFriendManagement.Info info, Action onConfirm, Action onCancel, LeaderboardRecord record)
	{
	}

	[Token(Token = "0x6001BED")]
	[Address(RVA = "0xAED73C", Offset = "0xAED73C", VA = "0xAED73C")]
	public void TryShowShareLinkInfoPopup()
	{
	}

	[Token(Token = "0x6001BEE")]
	[Address(RVA = "0xAEC760", Offset = "0xAEC760", VA = "0xAEC760")]
	public bool IsAtMaxFriends()
	{
		return default(bool);
	}

	[Token(Token = "0x6001BEF")]
	[Address(RVA = "0xAED930", Offset = "0xAED930", VA = "0xAED930")]
	private void OnSaveGameManagerLoadComplete(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6001BF0")]
	[Address(RVA = "0xAED9E0", Offset = "0xAED9E0", VA = "0xAED9E0")]
	private void RegisterAppsFlyerCallbacks()
	{
	}

	[Token(Token = "0x6001BF1")]
	[Address(RVA = "0xAEDC64", Offset = "0xAEDC64", VA = "0xAEDC64")]
	private void OnConversionDataChanged(Dictionary<string, string> data)
	{
	}

	[Token(Token = "0x6001BF2")]
	[Address(RVA = "0xAEDBB0", Offset = "0xAEDBB0", VA = "0xAEDBB0")]
	private void AppOpenAttributionDataChanged(Dictionary<string, string> data)
	{
	}

	[Token(Token = "0x6001BF3")]
	[Address(RVA = "0xAED5D0", Offset = "0xAED5D0", VA = "0xAED5D0")]
	private void FriendLinkClicked(string sid)
	{
	}

	[Token(Token = "0x6001BF4")]
	[Address(RVA = "0xAED480", Offset = "0xAED480", VA = "0xAED480")]
	private void ShowAlreadyFriendsPopup()
	{
	}

	[Token(Token = "0x6001BF5")]
	[Address(RVA = "0xAED488", Offset = "0xAED488", VA = "0xAED488")]
	private void ShowMaxFriendsPopup()
	{
	}

	[Token(Token = "0x6001BF6")]
	[Address(RVA = "0xAED490", Offset = "0xAED490", VA = "0xAED490")]
	private void ShowSelfFriendPopup()
	{
	}

	[Token(Token = "0x6001BF7")]
	[Address(RVA = "0xAEE068", Offset = "0xAEE068", VA = "0xAEE068")]
	private void OnLoadingViewDisabled(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6001BF8")]
	[Address(RVA = "0xAEE06C", Offset = "0xAEE06C", VA = "0xAEE06C")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs e)
	{
	}

	[Token(Token = "0x6001BF9")]
	[Address(RVA = "0xAEDDD4", Offset = "0xAEDDD4", VA = "0xAEDDD4")]
	private static bool CanShowFriendRequest()
	{
		return default(bool);
	}

	[Token(Token = "0x6001BFA")]
	[Address(RVA = "0xAEE160", Offset = "0xAEE160", VA = "0xAEE160")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6184B8", Offset = "0x6184B8")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x6001BFB")]
	[Address(RVA = "0xAEE164", Offset = "0xAEE164", VA = "0xAEE164")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6184F0", Offset = "0x6184F0")]
	private static void Logf(string fmt, params object[] args)
	{
	}

	[Token(Token = "0x6001BFC")]
	[Address(RVA = "0xAEE168", Offset = "0xAEE168", VA = "0xAEE168")]
	public DeepLinkFriendManager()
	{
	}
}
