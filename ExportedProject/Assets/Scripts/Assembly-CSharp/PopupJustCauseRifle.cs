using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000731")]
public class PopupJustCauseRifle : PopupOverlayView
{
	[Serializable]
	[Token(Token = "0x2000732")]
	private class RequirementGameObject
	{
		[Token(Token = "0x40028C9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject _notReached;

		[Token(Token = "0x40028CA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _reached;

		[Token(Token = "0x40028CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BlinkButtonHandler _buttonHandler;

		[Token(Token = "0x40028CC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIWidget _buttonWidget;

		[Token(Token = "0x40028CD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Collider _buttonCollider;

		[Token(Token = "0x40028CE")]
		[FieldOffset(Offset = "0x38")]
		private Action _onClicked;

		[Token(Token = "0x600300D")]
		[Address(RVA = "0x8AEF6C", Offset = "0x8AEF6C", VA = "0x8AEF6C")]
		public void SetReached(bool reached)
		{
		}

		[Token(Token = "0x600300E")]
		[Address(RVA = "0x8AEFB8", Offset = "0x8AEFB8", VA = "0x8AEFB8")]
		public void SetButtonCallback(Action onClicked)
		{
		}

		[Token(Token = "0x600300F")]
		[Address(RVA = "0x8AF060", Offset = "0x8AF060", VA = "0x8AF060")]
		public void CleanUp()
		{
		}

		[Token(Token = "0x6003010")]
		[Address(RVA = "0x8AF100", Offset = "0x8AF100", VA = "0x8AF100")]
		public void SetButtonEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6003011")]
		[Address(RVA = "0x8AF25C", Offset = "0x8AF25C", VA = "0x8AF25C")]
		private void OnButtonClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
		{
		}

		[Token(Token = "0x6003012")]
		[Address(RVA = "0x8AF268", Offset = "0x8AF268", VA = "0x8AF268")]
		public RequirementGameObject()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000733")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595ED8", Offset = "0x595ED8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40028CF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40028D0")]
		[FieldOffset(Offset = "0x8")]
		public static Action<string> _003C_003E9__22_1;

		[Token(Token = "0x40028D1")]
		[FieldOffset(Offset = "0x10")]
		public static Action<UIAlignedList.ListItem> _003C_003E9__26_0;

		[Token(Token = "0x6003014")]
		[Address(RVA = "0x8AEDA0", Offset = "0x8AEDA0", VA = "0x8AEDA0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003015")]
		[Address(RVA = "0x8AEDA8", Offset = "0x8AEDA8", VA = "0x8AEDA8")]
		internal void _003COnAdsClicked_003Eb__22_1(string error)
		{
		}

		[Token(Token = "0x6003016")]
		[Address(RVA = "0x8AEDAC", Offset = "0x8AEDAC", VA = "0x8AEDAC")]
		internal void _003CUpdateAdVisuals_003Eb__26_0(UIAlignedList.ListItem item)
		{
		}
	}

	[Token(Token = "0x2000734")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595EE8", Offset = "0x595EE8")]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		[Token(Token = "0x40028D2")]
		[FieldOffset(Offset = "0x10")]
		public PopupOverlayViewBase popup;

		[Token(Token = "0x40028D3")]
		[FieldOffset(Offset = "0x18")]
		public PlayerReferralData.JustCauseGunReferralData referralData;

		[Token(Token = "0x40028D4")]
		[FieldOffset(Offset = "0x20")]
		public SaveGameManager saveGameManager;

		[Token(Token = "0x6003017")]
		[Address(RVA = "0x8AEE1C", Offset = "0x8AEE1C", VA = "0x8AEE1C")]
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		[Token(Token = "0x6003018")]
		[Address(RVA = "0x8AEE24", Offset = "0x8AEE24", VA = "0x8AEE24")]
		internal void _003COnFriendsClicked_003Eb__0()
		{
		}
	}

	[Token(Token = "0x40028B7")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private RequirementGameObject _ads;

	[Token(Token = "0x40028B8")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private RequirementGameObject _rank;

	[Token(Token = "0x40028B9")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private RequirementGameObject _friends;

	[Token(Token = "0x40028BA")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private UILabel _adsRequiredLabel;

	[Token(Token = "0x40028BB")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private UILabel _rankRequiredLabel;

	[Token(Token = "0x40028BC")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private UILabel _friendsRequiredLabel;

	[Token(Token = "0x40028BD")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private string _friendsRequiredKeyPlural;

	[Token(Token = "0x40028BE")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private string _friendsRequiredKeySingular;

	[Token(Token = "0x40028BF")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	private UIResizeKeepAspect _contentContainerResize;

	[Token(Token = "0x40028C0")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private UIAlignedList _adBarsContainer;

	[Token(Token = "0x40028C1")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private UISprite _adBar;

	[Token(Token = "0x40028C2")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private UIAlignedList _rankBarsContainer;

	[Token(Token = "0x40028C3")]
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	private UITexture[] _rankBars;

	[Token(Token = "0x40028C4")]
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	private int _rankBarsPadding;

	[Token(Token = "0x40028C5")]
	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	private UIAlignedList _friendIconsContainer;

	[Token(Token = "0x40028C6")]
	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	private UITexture[] _friendIcons;

	[Token(Token = "0x40028C7")]
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	private int _friendIconsPadding;

	[Token(Token = "0x40028C8")]
	[FieldOffset(Offset = "0x188")]
	private JustCauseRifleConfig _config;

	[Token(Token = "0x6002FFE")]
	[Address(RVA = "0x935B14", Offset = "0x935B14", VA = "0x935B14")]
	public void SetupPopupOverlay(Action cancelCallback, Action exitCallback)
	{
	}

	[Token(Token = "0x6002FFF")]
	[Address(RVA = "0x9367D4", Offset = "0x9367D4", VA = "0x9367D4", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003000")]
	[Address(RVA = "0x9368E4", Offset = "0x9368E4", VA = "0x9368E4")]
	private void OnFriendCountRefreshed()
	{
	}

	[Token(Token = "0x6003001")]
	[Address(RVA = "0x936930", Offset = "0x936930", VA = "0x936930")]
	private void OnAdsClicked()
	{
	}

	[Token(Token = "0x6003002")]
	[Address(RVA = "0x936AEC", Offset = "0x936AEC", VA = "0x936AEC")]
	private void OnRankClicked()
	{
	}

	[Token(Token = "0x6003003")]
	[Address(RVA = "0x936E2C", Offset = "0x936E2C", VA = "0x936E2C")]
	private static void OnFriendsClicked()
	{
	}

	[Token(Token = "0x6003004")]
	[Address(RVA = "0x936AF0", Offset = "0x936AF0", VA = "0x936AF0")]
	private void GoToContractScreen()
	{
	}

	[Token(Token = "0x6003005")]
	[Address(RVA = "0x935EBC", Offset = "0x935EBC", VA = "0x935EBC")]
	private void UpdateAdVisuals()
	{
	}

	[Token(Token = "0x6003006")]
	[Address(RVA = "0x937140", Offset = "0x937140", VA = "0x937140")]
	private void ContinuallyUpdateAdButtonEnabled()
	{
	}

	[Token(Token = "0x6003007")]
	[Address(RVA = "0x9362CC", Offset = "0x9362CC", VA = "0x9362CC")]
	private void UpdateRankVisuals()
	{
	}

	[Token(Token = "0x6003008")]
	[Address(RVA = "0x936514", Offset = "0x936514", VA = "0x936514")]
	private void UpdateFriendsVisuals(bool useOnlineFriends)
	{
	}

	[Token(Token = "0x6003009")]
	[Address(RVA = "0x937204", Offset = "0x937204", VA = "0x937204")]
	private GameObject GetCheckMarkInGO(GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x600300A")]
	[Address(RVA = "0x937348", Offset = "0x937348", VA = "0x937348")]
	private void OnContentSizeChanged(UIResizeKeepAspect.ResizeArgs args)
	{
	}

	[Token(Token = "0x600300B")]
	[Address(RVA = "0x9373D4", Offset = "0x9373D4", VA = "0x9373D4")]
	public PopupJustCauseRifle()
	{
	}

	[Token(Token = "0x600300C")]
	[Address(RVA = "0x9373D8", Offset = "0x9373D8", VA = "0x9373D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6219B0", Offset = "0x6219B0")]
	private void _003COnAdsClicked_003Eb__22_0(bool success)
	{
	}
}
