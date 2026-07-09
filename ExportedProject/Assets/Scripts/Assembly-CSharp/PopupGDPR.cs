using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200072C")]
public class PopupGDPR : PopupOverlayViewBase
{
	[Serializable]
	[Token(Token = "0x200072D")]
	private class HyperlinkWidget
	{
		[Token(Token = "0x400289A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UILabel _label;

		[Token(Token = "0x400289B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIWidget _underline;

		[Token(Token = "0x400289C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _locKey;

		[Token(Token = "0x400289D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonHandler _button;

		[Token(Token = "0x400289E")]
		[FieldOffset(Offset = "0x30")]
		private string _url;

		[Token(Token = "0x6002FDB")]
		[Address(RVA = "0x8AEB30", Offset = "0x8AEB30", VA = "0x8AEB30")]
		public void SetupLabel(string url)
		{
		}

		[Token(Token = "0x6002FDC")]
		[Address(RVA = "0x8AEC8C", Offset = "0x8AEC8C", VA = "0x8AEC8C")]
		public void CleanUp()
		{
		}

		[Token(Token = "0x6002FDD")]
		[Address(RVA = "0x8AED2C", Offset = "0x8AED2C", VA = "0x8AED2C")]
		private void OnHyperlinkClicked(object sender, ButtonHandler.ButtonHandlerEventArgs e)
		{
		}

		[Token(Token = "0x6002FDE")]
		[Address(RVA = "0x8AED38", Offset = "0x8AED38", VA = "0x8AED38")]
		public HyperlinkWidget()
		{
		}
	}

	[Token(Token = "0x4002895")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private CheckmarkWidget _checkmark;

	[Token(Token = "0x4002896")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Collider _acceptButtonCollider;

	[Token(Token = "0x4002897")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private UIWidget _acceptButtonBackground;

	[Token(Token = "0x4002898")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private HyperlinkWidget _privacyPolicyWidget;

	[Token(Token = "0x4002899")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private HyperlinkWidget _termsWidget;

	[Token(Token = "0x1700062C")]
	public override bool CanPressOkButton
	{
		[Token(Token = "0x6002FD5")]
		[Address(RVA = "0x932AB4", Offset = "0x932AB4", VA = "0x932AB4", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002FD6")]
	[Address(RVA = "0x932AD0", Offset = "0x932AD0", VA = "0x932AD0")]
	public void SetupPopup(Action onAccept)
	{
	}

	[Token(Token = "0x6002FD7")]
	[Address(RVA = "0x932C9C", Offset = "0x932C9C", VA = "0x932C9C", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002FD8")]
	[Address(RVA = "0x932F64", Offset = "0x932F64", VA = "0x932F64", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002FD9")]
	[Address(RVA = "0x932E9C", Offset = "0x932E9C", VA = "0x932E9C")]
	private void OnCheckStateChanged(bool isChecked)
	{
	}

	[Token(Token = "0x6002FDA")]
	[Address(RVA = "0x933074", Offset = "0x933074", VA = "0x933074")]
	public PopupGDPR()
	{
	}
}
