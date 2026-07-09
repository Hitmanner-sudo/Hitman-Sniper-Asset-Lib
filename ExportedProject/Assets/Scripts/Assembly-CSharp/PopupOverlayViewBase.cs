using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200073A")]
public class PopupOverlayViewBase : View
{
	[Token(Token = "0x40028E9")]
	[FieldOffset(Offset = "0x60")]
	protected Action OnExit;

	[Token(Token = "0x40028EA")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BA398", Offset = "0x5BA398")]
	private DateTime _003CPopupBirthTime_003Ek__BackingField;

	[Token(Token = "0x40028EB")]
	[FieldOffset(Offset = "0x70")]
	public UILabel Title;

	[Token(Token = "0x40028EC")]
	[FieldOffset(Offset = "0x78")]
	public UILabel Description;

	[Token(Token = "0x40028ED")]
	[FieldOffset(Offset = "0x80")]
	public long CampaignID;

	[Token(Token = "0x40028EE")]
	[FieldOffset(Offset = "0x88")]
	public BlinkButtonHandler OkButton;

	[Token(Token = "0x40028EF")]
	[FieldOffset(Offset = "0x90")]
	public BlinkButtonHandler CancelButton;

	[Token(Token = "0x40028F0")]
	[FieldOffset(Offset = "0x98")]
	public ButtonHandler CloseButton;

	[Token(Token = "0x40028F1")]
	[FieldOffset(Offset = "0xA0")]
	private Action _onOk;

	[Token(Token = "0x40028F2")]
	[FieldOffset(Offset = "0xA8")]
	private Action _onCancel;

	[Token(Token = "0x40028F3")]
	[FieldOffset(Offset = "0xB0")]
	private ButtonHandler _hyperLinkButtonHandler;

	[Token(Token = "0x40028F4")]
	[FieldOffset(Offset = "0xB8")]
	private string _hyperLink;

	[Token(Token = "0x17000631")]
	protected DateTime PopupBirthTime
	{
		[Token(Token = "0x6003036")]
		[Address(RVA = "0x93971C", Offset = "0x93971C", VA = "0x93971C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621A70", Offset = "0x621A70")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6003037")]
		[Address(RVA = "0x939724", Offset = "0x939724", VA = "0x939724")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621A80", Offset = "0x621A80")]
		private set
		{
		}
	}

	[Token(Token = "0x17000632")]
	public virtual bool CanPressOkButton
	{
		[Token(Token = "0x6003038")]
		[Address(RVA = "0x93972C", Offset = "0x93972C", VA = "0x93972C", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003039")]
	[Address(RVA = "0x92EEA0", Offset = "0x92EEA0", VA = "0x92EEA0", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600303A")]
	[Address(RVA = "0x933044", Offset = "0x933044", VA = "0x933044", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600303B")]
	[Address(RVA = "0x939734", Offset = "0x939734", VA = "0x939734")]
	private void SetupButtons()
	{
	}

	[Token(Token = "0x600303C")]
	[Address(RVA = "0x939868", Offset = "0x939868", VA = "0x939868", Slot = "16")]
	protected virtual void PopupViewed(string choice)
	{
	}

	[Token(Token = "0x600303D")]
	[Address(RVA = "0x939AD8", Offset = "0x939AD8", VA = "0x939AD8")]
	private static void SetParentTransform(Transform child, Transform parent)
	{
	}

	[Token(Token = "0x600303E")]
	[Address(RVA = "0x939600", Offset = "0x939600", VA = "0x939600", Slot = "17")]
	protected virtual void InternalSetupPopupOverlay(Transform parent, string title, string message, PopupButton okButton, PopupButton cancelButton)
	{
	}

	[Token(Token = "0x600303F")]
	[Address(RVA = "0x939B3C", Offset = "0x939B3C", VA = "0x939B3C")]
	private void SetupText(string title, string message)
	{
	}

	[Token(Token = "0x6003040")]
	[Address(RVA = "0x939E3C", Offset = "0x939E3C", VA = "0x939E3C")]
	private void CheckForURL(ref string message)
	{
	}

	[Token(Token = "0x6003041")]
	[Address(RVA = "0x93A1D0", Offset = "0x93A1D0", VA = "0x93A1D0")]
	private static void RemoveRemainingFormat(ref string message)
	{
	}

	[Token(Token = "0x6003042")]
	[Address(RVA = "0x939C64", Offset = "0x939C64", VA = "0x939C64")]
	private void SetupButtons(PopupButton okButton, PopupButton cancelButton)
	{
	}

	[Token(Token = "0x6003043")]
	[Address(RVA = "0x93A308", Offset = "0x93A308", VA = "0x93A308")]
	public void SetButtonText(BlinkButtonHandler button, string okString)
	{
	}

	[Token(Token = "0x6003044")]
	[Address(RVA = "0x93A410", Offset = "0x93A410", VA = "0x93A410")]
	private void OnHyperLinkButtonClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6003045")]
	[Address(RVA = "0x93909C", Offset = "0x93909C", VA = "0x93909C", Slot = "18")]
	protected virtual void CleanUp()
	{
	}

	[Token(Token = "0x6003046")]
	[Address(RVA = "0x93A450", Offset = "0x93A450", VA = "0x93A450", Slot = "19")]
	protected virtual void OnOkClickFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6003047")]
	[Address(RVA = "0x93A5CC", Offset = "0x93A5CC", VA = "0x93A5CC", Slot = "20")]
	protected virtual void OnCancelClickFinished(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6003048")]
	[Address(RVA = "0x937A1C", Offset = "0x937A1C", VA = "0x937A1C")]
	public void SetupPopupOverlay(Transform tParent, string title, string message, PopupButton okButton, PopupButton cancelButton)
	{
	}

	[Token(Token = "0x6003049")]
	[Address(RVA = "0x9302E8", Offset = "0x9302E8", VA = "0x9302E8")]
	public PopupOverlayViewBase()
	{
	}
}
