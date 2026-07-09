using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000730")]
public class PopupIntelIncrease : PopupOverlayView
{
	[Token(Token = "0x40028AE")]
	[FieldOffset(Offset = "0x100")]
	public Action OnOk;

	[Token(Token = "0x40028AF")]
	[FieldOffset(Offset = "0x108")]
	public Action OnCancel;

	[Token(Token = "0x40028B0")]
	private const string DEFAULT_DESC_KEY = "LOC_IntelUnlock_Description_Default";

	[Token(Token = "0x40028B1")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private IntelIncreaseRogueIcon _iconPrefab;

	[Token(Token = "0x40028B2")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private UIGrid _iconGrid;

	[Token(Token = "0x40028B3")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private UILabel _descriptionLabel;

	[Token(Token = "0x40028B4")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private IntelIncreaseRogueIcon _rogue;

	[Token(Token = "0x40028B5")]
	[FieldOffset(Offset = "0x130")]
	private List<IntelUnlockable> _intelUnlocks;

	[Token(Token = "0x40028B6")]
	[FieldOffset(Offset = "0x138")]
	private readonly string[] _descriptionKeys;

	[Token(Token = "0x6002FF0")]
	[Address(RVA = "0x934A7C", Offset = "0x934A7C", VA = "0x934A7C")]
	public void SetIntels(List<IntelUnlockable> intels)
	{
	}

	[Token(Token = "0x6002FF1")]
	[Address(RVA = "0x9352A8", Offset = "0x9352A8", VA = "0x9352A8", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002FF2")]
	[Address(RVA = "0x935320", Offset = "0x935320", VA = "0x935320", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002FF3")]
	[Address(RVA = "0x935540", Offset = "0x935540", VA = "0x935540", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002FF4")]
	[Address(RVA = "0x934E78", Offset = "0x934E78", VA = "0x934E78")]
	private void FillGrid()
	{
	}

	[Token(Token = "0x6002FF5")]
	[Address(RVA = "0x934B3C", Offset = "0x934B3C", VA = "0x934B3C")]
	private void ClearGrid()
	{
	}

	[Token(Token = "0x6002FF6")]
	[Address(RVA = "0x93517C", Offset = "0x93517C", VA = "0x93517C")]
	private void UpdateDescription()
	{
	}

	[Token(Token = "0x6002FF7")]
	[Address(RVA = "0x93570C", Offset = "0x93570C", VA = "0x93570C")]
	private RogueData[] GetUniqueRogues()
	{
		return null;
	}

	[Token(Token = "0x6002FF8")]
	[Address(RVA = "0x9358B0", Offset = "0x9358B0", VA = "0x9358B0")]
	private string[] GetRogueNames(RogueData[] rogues)
	{
		return null;
	}

	[Token(Token = "0x6002FF9")]
	[Address(RVA = "0x9359AC", Offset = "0x9359AC", VA = "0x9359AC")]
	private void OnOkBlinkFinished(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6002FFA")]
	[Address(RVA = "0x9359C0", Offset = "0x9359C0", VA = "0x9359C0")]
	private void OnCancelBlinkFinished(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6002FFB")]
	[Address(RVA = "0x9353F0", Offset = "0x9353F0", VA = "0x9353F0")]
	private void BindEvents()
	{
	}

	[Token(Token = "0x6002FFC")]
	[Address(RVA = "0x9355C8", Offset = "0x9355C8", VA = "0x9355C8")]
	private void UnbindEvents()
	{
	}

	[Token(Token = "0x6002FFD")]
	[Address(RVA = "0x9359D4", Offset = "0x9359D4", VA = "0x9359D4")]
	public PopupIntelIncrease()
	{
	}
}
