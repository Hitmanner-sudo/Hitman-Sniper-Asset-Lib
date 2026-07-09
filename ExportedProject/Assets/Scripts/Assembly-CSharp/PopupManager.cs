using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology;
using Technology.Social;
using UnityEngine;

[Token(Token = "0x2000612")]
[Scope]
public class PopupManager : GameSingleton<PopupManager>
{
	[Token(Token = "0x2000613")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5955D0", Offset = "0x5955D0")]
	private sealed class _003CWaitForPopupClosed_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupManager _003C_003E4__this;

		[Token(Token = "0x4002183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action thenDo;

		[Token(Token = "0x17000529")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600276B")]
			[Address(RVA = "0x8AF4C0", Offset = "0x8AF4C0", VA = "0x8AF4C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700052A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600276D")]
			[Address(RVA = "0x8AF508", Offset = "0x8AF508", VA = "0x8AF508", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002768")]
		[Address(RVA = "0x8AF34C", Offset = "0x8AF34C", VA = "0x8AF34C")]
		[DebuggerHidden]
		public _003CWaitForPopupClosed_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002769")]
		[Address(RVA = "0x8AF378", Offset = "0x8AF378", VA = "0x8AF378", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600276A")]
		[Address(RVA = "0x8AF37C", Offset = "0x8AF37C", VA = "0x8AF37C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600276C")]
		[Address(RVA = "0x8AF4C8", Offset = "0x8AF4C8", VA = "0x8AF4C8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000614")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5955E0", Offset = "0x5955E0")]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[Token(Token = "0x4002184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action onOkAction;

		[Token(Token = "0x4002185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PopupManager _003C_003E4__this;

		[Token(Token = "0x4002186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupOverlayViewBase previousPopup;

		[Token(Token = "0x600276E")]
		[Address(RVA = "0x8AF270", Offset = "0x8AF270", VA = "0x8AF270")]
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		[Token(Token = "0x600276F")]
		[Address(RVA = "0x8AF278", Offset = "0x8AF278", VA = "0x8AF278")]
		internal void _003CShowNoNetworkPopUp_003Eb__0()
		{
		}
	}

	[Token(Token = "0x400217B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LazyPopupOverlayView _popupPrefab;

	[Token(Token = "0x400217C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private LazyPopupOverlayView _textOnlyPrefab;

	[Token(Token = "0x400217D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private LazyPopupSendFriendInvite _popupSendFriendInvitePrefab;

	[Token(Token = "0x400217E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool ExitPopupOpened;

	[Token(Token = "0x400217F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B830C", Offset = "0x5B830C")]
	private PopupOverlayViewBase _003CCurrentPopup_003Ek__BackingField;

	[Token(Token = "0x17000526")]
	public PopupOverlayViewBase CurrentPopup
	{
		[Token(Token = "0x6002752")]
		[Address(RVA = "0x937560", Offset = "0x937560", VA = "0x937560")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D100", Offset = "0x61D100")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002753")]
		[Address(RVA = "0x937568", Offset = "0x937568", VA = "0x937568")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D110", Offset = "0x61D110")]
		private set
		{
		}
	}

	[Token(Token = "0x17000527")]
	public static Transform PopupRoot
	{
		[Token(Token = "0x6002754")]
		[Address(RVA = "0x92D128", Offset = "0x92D128", VA = "0x92D128")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000528")]
	public bool IsShowingPopup
	{
		[Token(Token = "0x6002755")]
		[Address(RVA = "0x937570", Offset = "0x937570", VA = "0x937570")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002756")]
	[Address(RVA = "0x930B58", Offset = "0x930B58", VA = "0x930B58")]
	public void WhenNotShowingPopup(Action thenDo)
	{
	}

	[Token(Token = "0x6002757")]
	[Address(RVA = "0x937688", Offset = "0x937688", VA = "0x937688")]
	public void ForcePopupCancelButtonClick()
	{
	}

	[Token(Token = "0x6002758")]
	[Address(RVA = "0x937610", Offset = "0x937610", VA = "0x937610")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61D120", Offset = "0x61D120")]
	private IEnumerator WaitForPopupClosed(Action thenDo)
	{
		return null;
	}

	[Token(Token = "0x6002759")]
	[Address(RVA = "0x93456C", Offset = "0x93456C", VA = "0x93456C")]
	public bool CreatePopup(string title, string message, Action onOk, string okText, [Optional] Action onCancel, [Optional] string cancelText)
	{
		return default(bool);
	}

	[Token(Token = "0x600275A")]
	[Address(RVA = "0x937A8C", Offset = "0x937A8C", VA = "0x937A8C")]
	public bool CreatePopup(string title, string message, Action onOk, string okText, Action onCancel, string cancelText, WeaponUnlockable weaponUnlockable, bool showRedLight = false, int descriptionPosYOffset = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x600275B")]
	[Address(RVA = "0x937DB4", Offset = "0x937DB4", VA = "0x937DB4")]
	public bool CreatePopup(string title, string message, Action onOk, string okText, Action onCancel, string cancelText, Texture texture, [Optional][DefaultParameterValue(0)] int width, [Optional][DefaultParameterValue(0)] int height, [Optional][DefaultParameterValue(0)] int descriptionPosYOffset, [Optional][DefaultParameterValue(0)] int imagePosYOffset, [Optional] Texture background, bool showBackground = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600275C")]
	public T CreatePopup<T>(T prefab, bool setLayer = true) where T : PopupOverlayViewBase
	{
		return null;
	}

	[Token(Token = "0x600275D")]
	[Address(RVA = "0x92EB84", Offset = "0x92EB84", VA = "0x92EB84")]
	public void ClearPopup()
	{
	}

	[Token(Token = "0x600275E")]
	[Address(RVA = "0x9377C8", Offset = "0x9377C8", VA = "0x9377C8")]
	private bool CreateNewPopup(LazyPopupOverlayView prefab)
	{
		return default(bool);
	}

	[Token(Token = "0x600275F")]
	[Address(RVA = "0x937F98", Offset = "0x937F98", VA = "0x937F98")]
	public void CreatePurchaseInfoPopup(int purchasePrice, string purchaseCurrency, Action onEnoughFunds)
	{
	}

	[Token(Token = "0x6002760")]
	[Address(RVA = "0x938054", Offset = "0x938054", VA = "0x938054")]
	public void CreatePurchaseInfoPopup(Wallet.CurrencyAmount cost, Action<Wallet.CurrencyAmount> onEnoughFunds)
	{
	}

	[Token(Token = "0x6002761")]
	[Address(RVA = "0x938184", Offset = "0x938184", VA = "0x938184")]
	public void CreateReceiveRequestFriendPopup(InboxItem inboxItem, Action onAcceptCallBack, Action onDeclineCallBack, Action onCancelCallBack)
	{
	}

	[Token(Token = "0x6002762")]
	[Address(RVA = "0x932010", Offset = "0x932010", VA = "0x932010")]
	public void CreateSendRequestFriendPopup(LeaderboardRecord record, Action onSendCallBack, Action onCancelCallBack)
	{
	}

	[Token(Token = "0x6002763")]
	[Address(RVA = "0x9387C8", Offset = "0x9387C8", VA = "0x9387C8")]
	public void ReshowPopup(PopupOverlayViewBase popup)
	{
	}

	[Token(Token = "0x6002764")]
	[Address(RVA = "0x937088", Offset = "0x937088", VA = "0x937088")]
	public PopupOverlayViewBase HideCurrentPopup()
	{
		return null;
	}

	[Token(Token = "0x6002765")]
	[Address(RVA = "0x9387D0", Offset = "0x9387D0", VA = "0x9387D0")]
	public void ShowNoNetworkPopUp(bool isBlockingRequirement, [Optional] Action onOkAction)
	{
	}

	[Token(Token = "0x6002766")]
	[Address(RVA = "0x9388DC", Offset = "0x9388DC", VA = "0x9388DC")]
	public void ShowNoNetworkPopUp([Optional][DefaultParameterValue("LOC_NoNetworkErrorTitle")] string titleKey, [Optional][DefaultParameterValue("LOC_NoNetworkErrorMessage")] string messageKey, [Optional][DefaultParameterValue("LOC_ButtonOK")] string okTextKey, [Optional] Action onOkAction)
	{
	}

	[Token(Token = "0x6002767")]
	[Address(RVA = "0x938A2C", Offset = "0x938A2C", VA = "0x938A2C")]
	public PopupManager()
	{
	}
}
