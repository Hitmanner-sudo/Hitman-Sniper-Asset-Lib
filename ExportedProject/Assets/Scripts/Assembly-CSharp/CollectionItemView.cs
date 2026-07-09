using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006FC")]
public abstract class CollectionItemView : View
{
	[Token(Token = "0x20006FD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x595D78", Offset = "0x595D78")]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x40027AC")]
		[FieldOffset(Offset = "0x10")]
		public CollectionItemView _003C_003E4__this;

		[Token(Token = "0x40027AD")]
		[FieldOffset(Offset = "0x18")]
		public TweenScale tween;

		[Token(Token = "0x6002E8F")]
		[Address(RVA = "0x8626E8", Offset = "0x8626E8", VA = "0x8626E8")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6002E90")]
		[Address(RVA = "0x8626F0", Offset = "0x8626F0", VA = "0x8626F0")]
		internal void _003CSlotSelf_003Eb__0()
		{
		}
	}

	[Token(Token = "0x400279D")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UITexture _mainTexture;

	[Token(Token = "0x400279E")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UISprite _lockedIcon;

	[Token(Token = "0x400279F")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private ButtonHandler _button;

	[Token(Token = "0x40027A0")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private string _fallbackName;

	[Token(Token = "0x40027A1")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private string _fallbackDescription;

	[Token(Token = "0x40027A2")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject _tweenScaletarget;

	[Token(Token = "0x40027A3")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private float _highlightedSizeMultiplier;

	[Token(Token = "0x40027A4")]
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	private float _unhighlightedSizeMultiplier;

	[Token(Token = "0x40027A5")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Color _unslottedColor;

	[Token(Token = "0x40027A6")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Color _slottedColor;

	[Token(Token = "0x40027A7")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Color _lockedColor;

	[Token(Token = "0x40027A8")]
	[FieldOffset(Offset = "0xC8")]
	private AttachmentsUnlockable _attachment;

	[Token(Token = "0x40027A9")]
	[FieldOffset(Offset = "0xD0")]
	private bool _isCurrentlySlotted;

	[Token(Token = "0x40027AA")]
	[FieldOffset(Offset = "0xD1")]
	private bool _isHighlighted;

	[Token(Token = "0x40027AB")]
	[FieldOffset(Offset = "0xD4")]
	protected int _attachmentIdx;

	[Token(Token = "0x17000603")]
	public string AttachmentName
	{
		[Token(Token = "0x6002E7E")]
		[Address(RVA = "0x8D79F0", Offset = "0x8D79F0", VA = "0x8D79F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000604")]
	public string AttachmentDescription
	{
		[Token(Token = "0x6002E7F")]
		[Address(RVA = "0x8D7ABC", Offset = "0x8D7ABC", VA = "0x8D7ABC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000605")]
	public int AttachmentIndex
	{
		[Token(Token = "0x6002E80")]
		[Address(RVA = "0x8D7B88", Offset = "0x8D7B88", VA = "0x8D7B88")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002E81")]
	[Address(RVA = "0x8D7B90", Offset = "0x8D7B90", VA = "0x8D7B90", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002E82")]
	[Address(RVA = "0x8D7D6C", Offset = "0x8D7D6C", VA = "0x8D7D6C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002E83")]
	[Address(RVA = "0x8D7E2C", Offset = "0x8D7E2C", VA = "0x8D7E2C")]
	public void UpdateIcon()
	{
	}

	[Token(Token = "0x6002E84")]
	[Address(RVA = "0x8D807C", Offset = "0x8D807C", VA = "0x8D807C")]
	public bool CanSlotSelf()
	{
		return default(bool);
	}

	[Token(Token = "0x6002E85")]
	[Address(RVA = "0x8D8114", Offset = "0x8D8114", VA = "0x8D8114")]
	public void SlotSelf()
	{
	}

	[Token(Token = "0x6002E86")]
	[Address(RVA = "0x8D832C", Offset = "0x8D832C", VA = "0x8D832C")]
	public void SetHighlighted(bool isHighlighted)
	{
	}

	[Token(Token = "0x6002E87")]
	[Address(RVA = "0x8D83A8", Offset = "0x8D83A8", VA = "0x8D83A8", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002E88")]
	[Address(RVA = "0x8D7CA8", Offset = "0x8D7CA8", VA = "0x8D7CA8")]
	private void OnAttachmentChanged(string attachmentPath)
	{
	}

	[Token(Token = "0x6002E89")]
	[Address(RVA = "0x8D8494", Offset = "0x8D8494", VA = "0x8D8494")]
	private void OnSelfClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002E8A")]
	protected abstract AttachmentsUnlockable Load(string path, out int attachmentIdx);

	[Token(Token = "0x6002E8B")]
	protected abstract void Unload(AttachmentsUnlockable attachment);

	[Token(Token = "0x6002E8C")]
	protected abstract void SlotNewAttachment(SelectedSlot slot);

	[Token(Token = "0x6002E8D")]
	protected abstract bool IsCurrentlySlotted();

	[Token(Token = "0x6002E8E")]
	[Address(RVA = "0x8D8600", Offset = "0x8D8600", VA = "0x8D8600")]
	protected CollectionItemView()
	{
	}
}
