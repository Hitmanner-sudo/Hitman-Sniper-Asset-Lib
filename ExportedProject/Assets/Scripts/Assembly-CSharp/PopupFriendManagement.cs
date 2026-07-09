using System;
using Il2CppDummyDll;
using Technology.Social;
using UnityEngine;

[Token(Token = "0x200072A")]
public class PopupFriendManagement : PopupOverlayView
{
	[Serializable]
	[Token(Token = "0x200072B")]
	public class Info
	{
		[Token(Token = "0x4002891")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _title;

		[Token(Token = "0x4002892")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _description;

		[Token(Token = "0x4002893")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _confirmText;

		[Token(Token = "0x4002894")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _cancelText;

		[Token(Token = "0x17000628")]
		public string Title
		{
			[Token(Token = "0x6002FD0")]
			[Address(RVA = "0x8AE968", Offset = "0x8AE968", VA = "0x8AE968")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000629")]
		public string Description
		{
			[Token(Token = "0x6002FD1")]
			[Address(RVA = "0x8AE9D0", Offset = "0x8AE9D0", VA = "0x8AE9D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700062A")]
		public string ConfirmText
		{
			[Token(Token = "0x6002FD2")]
			[Address(RVA = "0x8AEA38", Offset = "0x8AEA38", VA = "0x8AEA38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700062B")]
		public string CancelText
		{
			[Token(Token = "0x6002FD3")]
			[Address(RVA = "0x8AEAB0", Offset = "0x8AEAB0", VA = "0x8AEAB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002FD4")]
		[Address(RVA = "0x8AEB28", Offset = "0x8AEB28", VA = "0x8AEB28")]
		public Info()
		{
		}
	}

	[Token(Token = "0x4002886")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private LeaderboardItem _leaderboardItem;

	[Token(Token = "0x4002887")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private Transform _infoConfirmAnchor;

	[Token(Token = "0x4002888")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private Transform _confirmationConfirmAnchor;

	[Token(Token = "0x4002889")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private Transform _infoTitleAnchor;

	[Token(Token = "0x400288A")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private Transform _confirmationTitleAnchor;

	[Token(Token = "0x400288B")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private UIAtlas _inGameAtlas;

	[Token(Token = "0x400288C")]
	[FieldOffset(Offset = "0x130")]
	private string _title;

	[Token(Token = "0x400288D")]
	[FieldOffset(Offset = "0x138")]
	private string _description;

	[Token(Token = "0x400288E")]
	[FieldOffset(Offset = "0x140")]
	private PopupButton _confirm;

	[Token(Token = "0x400288F")]
	[FieldOffset(Offset = "0x158")]
	private PopupButton _cancel;

	[Token(Token = "0x4002890")]
	[FieldOffset(Offset = "0x170")]
	private LeaderboardRecord _record;

	[Token(Token = "0x6002FC7")]
	[Address(RVA = "0x932510", Offset = "0x932510", VA = "0x932510")]
	public void Setup()
	{
	}

	[Token(Token = "0x6002FC8")]
	[Address(RVA = "0x932A80", Offset = "0x932A80", VA = "0x932A80")]
	public PopupFriendManagement TitleText(string title)
	{
		return null;
	}

	[Token(Token = "0x6002FC9")]
	[Address(RVA = "0x932A88", Offset = "0x932A88", VA = "0x932A88")]
	public PopupFriendManagement DescriptionText(string description)
	{
		return null;
	}

	[Token(Token = "0x6002FCA")]
	[Address(RVA = "0x932A90", Offset = "0x932A90", VA = "0x932A90")]
	public PopupFriendManagement Confirm(string text, Action onClick)
	{
		return null;
	}

	[Token(Token = "0x6002FCB")]
	[Address(RVA = "0x932A9C", Offset = "0x932A9C", VA = "0x932A9C")]
	public PopupFriendManagement Cancel(string text, Action onClick)
	{
		return null;
	}

	[Token(Token = "0x6002FCC")]
	[Address(RVA = "0x932AA8", Offset = "0x932AA8", VA = "0x932AA8")]
	public PopupFriendManagement Record(LeaderboardRecord record)
	{
		return null;
	}

	[Token(Token = "0x6002FCD")]
	[Address(RVA = "0x932718", Offset = "0x932718", VA = "0x932718")]
	private void SetAnchors()
	{
	}

	[Token(Token = "0x6002FCE")]
	[Address(RVA = "0x9328A8", Offset = "0x9328A8", VA = "0x9328A8")]
	private void SetupLeadeboardItem()
	{
	}

	[Token(Token = "0x6002FCF")]
	[Address(RVA = "0x932AB0", Offset = "0x932AB0", VA = "0x932AB0")]
	public PopupFriendManagement()
	{
	}
}
