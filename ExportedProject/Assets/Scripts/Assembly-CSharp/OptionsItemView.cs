using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006B3")]
public class OptionsItemView : View
{
	[Token(Token = "0x4002564")]
	[FieldOffset(Offset = "0x60")]
	public List<string> Items;

	[Token(Token = "0x4002565")]
	[FieldOffset(Offset = "0x68")]
	public bool CycleList;

	[Token(Token = "0x4002566")]
	[FieldOffset(Offset = "0x6C")]
	private int _currentItem;

	[Token(Token = "0x4002567")]
	[FieldOffset(Offset = "0x70")]
	public BlinkButtonHandler LeftArrow;

	[Token(Token = "0x4002568")]
	[FieldOffset(Offset = "0x78")]
	public BlinkButtonHandler RightArrow;

	[Token(Token = "0x4002569")]
	[FieldOffset(Offset = "0x80")]
	public BlinkButtonHandler ConfirmButton;

	[Token(Token = "0x400256A")]
	[FieldOffset(Offset = "0x88")]
	public UILabel ConfirmItemValueLabel;

	[Token(Token = "0x400256B")]
	[FieldOffset(Offset = "0x90")]
	public UILocalize ConfirmItemValueLocalize;

	[Token(Token = "0x400256C")]
	[FieldOffset(Offset = "0x98")]
	public UILabel ListItemValueLabel;

	[Token(Token = "0x400256D")]
	[FieldOffset(Offset = "0xA0")]
	public bool Active;

	[Token(Token = "0x400256E")]
	[FieldOffset(Offset = "0xA1")]
	public bool IsList;

	[Token(Token = "0x400256F")]
	[FieldOffset(Offset = "0xA8")]
	public Transform ListGroup;

	[Token(Token = "0x4002570")]
	[FieldOffset(Offset = "0xB0")]
	public Transform ConfirmGroup;

	[Token(Token = "0x4002572")]
	[FieldOffset(Offset = "0xC0")]
	public Func<int, int> OnGetNewItemIndex;

	[Token(Token = "0x1400009E")]
	public event Action<int, string> OnItemChanged
	{
		[Token(Token = "0x6002BF2")]
		[Address(RVA = "0x9FD980", Offset = "0x9FD980", VA = "0x9FD980")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6204D8", Offset = "0x6204D8")]
		add
		{
		}
		[Token(Token = "0x6002BF3")]
		[Address(RVA = "0x9FDA20", Offset = "0x9FDA20", VA = "0x9FDA20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6204E8", Offset = "0x6204E8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400009F")]
	public event Action OnConfirm
	{
		[Token(Token = "0x6002BF4")]
		[Address(RVA = "0x9FDAC0", Offset = "0x9FDAC0", VA = "0x9FDAC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6204F8", Offset = "0x6204F8")]
		add
		{
		}
		[Token(Token = "0x6002BF5")]
		[Address(RVA = "0x9FDB60", Offset = "0x9FDB60", VA = "0x9FDB60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620508", Offset = "0x620508")]
		remove
		{
		}
	}

	[Token(Token = "0x140000A0")]
	private event Action _confirmLongPress
	{
		[Token(Token = "0x6002BF6")]
		[Address(RVA = "0x9FDC00", Offset = "0x9FDC00", VA = "0x9FDC00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620518", Offset = "0x620518")]
		add
		{
		}
		[Token(Token = "0x6002BF7")]
		[Address(RVA = "0x9FDCA0", Offset = "0x9FDCA0", VA = "0x9FDCA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620528", Offset = "0x620528")]
		remove
		{
		}
	}

	[Token(Token = "0x140000A1")]
	public event Action ConfirmLongPress
	{
		[Token(Token = "0x6002BF8")]
		[Address(RVA = "0x9FDD40", Offset = "0x9FDD40", VA = "0x9FDD40")]
		add
		{
		}
		[Token(Token = "0x6002BF9")]
		[Address(RVA = "0x9FDE28", Offset = "0x9FDE28", VA = "0x9FDE28")]
		remove
		{
		}
	}

	[Token(Token = "0x6002BFA")]
	[Address(RVA = "0x9FDEF0", Offset = "0x9FDEF0", VA = "0x9FDEF0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002BFB")]
	[Address(RVA = "0x9FE534", Offset = "0x9FE534", VA = "0x9FE534", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002BFC")]
	[Address(RVA = "0x9FE0CC", Offset = "0x9FE0CC", VA = "0x9FE0CC")]
	public void SetCurrentItemIndex(int itemIndex)
	{
	}

	[Token(Token = "0x6002BFD")]
	[Address(RVA = "0x9FE298", Offset = "0x9FE298", VA = "0x9FE298")]
	public void DisableOption()
	{
	}

	[Token(Token = "0x6002BFE")]
	[Address(RVA = "0x9FE73C", Offset = "0x9FE73C", VA = "0x9FE73C")]
	public void HideOption()
	{
	}

	[Token(Token = "0x6002BFF")]
	[Address(RVA = "0x9FE764", Offset = "0x9FE764", VA = "0x9FE764")]
	public void ShowOption()
	{
	}

	[Token(Token = "0x6002C00")]
	[Address(RVA = "0x9FE78C", Offset = "0x9FE78C", VA = "0x9FE78C")]
	private void OnLeftArrow(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002C01")]
	[Address(RVA = "0x9FE898", Offset = "0x9FE898", VA = "0x9FE898")]
	private void OnRightArrow(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002C02")]
	[Address(RVA = "0x9FE794", Offset = "0x9FE794", VA = "0x9FE794")]
	private void SetNewItemIndex(int delta)
	{
	}

	[Token(Token = "0x6002C03")]
	[Address(RVA = "0x9FE8A0", Offset = "0x9FE8A0", VA = "0x9FE8A0")]
	public int GetNewItemIndexDefault(int delta)
	{
		return default(int);
	}

	[Token(Token = "0x6002C04")]
	[Address(RVA = "0x9FE944", Offset = "0x9FE944", VA = "0x9FE944")]
	private void OnConfirmBlinkFinished(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002C05")]
	[Address(RVA = "0x9FE950", Offset = "0x9FE950", VA = "0x9FE950")]
	private void OnConfirmButtonLongPress(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6002C06")]
	[Address(RVA = "0x9FE95C", Offset = "0x9FE95C", VA = "0x9FE95C")]
	private void OnLocalizeDone(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6002C07")]
	[Address(RVA = "0x9FE388", Offset = "0x9FE388", VA = "0x9FE388")]
	private void SetButtonSounds()
	{
	}

	[Token(Token = "0x6002C08")]
	[Address(RVA = "0x9FE964", Offset = "0x9FE964", VA = "0x9FE964")]
	public OptionsItemView()
	{
	}
}
