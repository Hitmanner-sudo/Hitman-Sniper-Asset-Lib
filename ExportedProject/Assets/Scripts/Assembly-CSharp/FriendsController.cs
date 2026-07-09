using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200084A")]
public class FriendsController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200084B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596890", Offset = "0x596890")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002ECD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002ECE")]
		[FieldOffset(Offset = "0x8")]
		public static Func<UILabel, bool> _003C_003E9__10_0;

		[Token(Token = "0x4002ECF")]
		[FieldOffset(Offset = "0x10")]
		public static Func<UILabel, bool> _003C_003E9__12_0;

		[Token(Token = "0x6003631")]
		[Address(RVA = "0x87198C", Offset = "0x87198C", VA = "0x87198C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003632")]
		[Address(RVA = "0x871994", Offset = "0x871994", VA = "0x871994")]
		internal bool _003CCreateFriend_003Eb__10_0(UILabel l)
		{
			return default(bool);
		}

		[Token(Token = "0x6003633")]
		[Address(RVA = "0x8719F4", Offset = "0x8719F4", VA = "0x8719F4")]
		internal bool _003COnRemoveClicked_003Eb__12_0(UILabel l)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4002EC8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject FriendPrefab;

	[Token(Token = "0x4002EC9")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid FriendGrid;

	[Token(Token = "0x4002ECA")]
	[FieldOffset(Offset = "0x28")]
	public ButtonHandler Close;

	[Token(Token = "0x4002ECB")]
	[FieldOffset(Offset = "0x30")]
	public ButtonHandler ManualAdd;

	[Token(Token = "0x4002ECC")]
	[FieldOffset(Offset = "0x38")]
	public ButtonHandler ForceAdd;

	[Token(Token = "0x6003624")]
	[Address(RVA = "0x95B310", Offset = "0x95B310", VA = "0x95B310")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6003625")]
	[Address(RVA = "0x95B514", Offset = "0x95B514", VA = "0x95B514")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6003626")]
	[Address(RVA = "0x95B454", Offset = "0x95B454", VA = "0x95B454")]
	private void RefreshVisual()
	{
	}

	[Token(Token = "0x6003627")]
	[Address(RVA = "0x95B644", Offset = "0x95B644", VA = "0x95B644")]
	private void ClearGrid(UIGrid grid)
	{
	}

	[Token(Token = "0x6003628")]
	[Address(RVA = "0x95B720", Offset = "0x95B720", VA = "0x95B720")]
	private void CreateList(IEnumerable<string> sids, UIGrid grid)
	{
	}

	[Token(Token = "0x6003629")]
	[Address(RVA = "0x95B9DC", Offset = "0x95B9DC", VA = "0x95B9DC")]
	private void CreateFriend(string sid, UIGrid grid)
	{
	}

	[Token(Token = "0x600362A")]
	[Address(RVA = "0x95BCBC", Offset = "0x95BCBC", VA = "0x95BCBC")]
	private void OnCloseClicked(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x600362B")]
	[Address(RVA = "0x95BD34", Offset = "0x95BD34", VA = "0x95BD34")]
	private void OnRemoveClicked(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x600362C")]
	[Address(RVA = "0x95C084", Offset = "0x95C084", VA = "0x95C084")]
	private void OnManualAddClicked(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x600362D")]
	[Address(RVA = "0x95C194", Offset = "0x95C194", VA = "0x95C194")]
	private void OnForceAddClicked(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x600362E")]
	[Address(RVA = "0x95C288", Offset = "0x95C288", VA = "0x95C288")]
	public void OnManualAddSubmit()
	{
	}

	[Token(Token = "0x600362F")]
	[Address(RVA = "0x95C290", Offset = "0x95C290", VA = "0x95C290")]
	public FriendsController()
	{
	}
}
