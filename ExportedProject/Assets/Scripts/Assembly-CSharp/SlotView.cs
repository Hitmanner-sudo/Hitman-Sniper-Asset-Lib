using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000707")]
public abstract class SlotView : View
{
	[Token(Token = "0x2000708")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x595DB8", Offset = "0x595DB8")]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		[Token(Token = "0x40027CF")]
		[FieldOffset(Offset = "0x10")]
		public SlotView _003C_003E4__this;

		[Token(Token = "0x40027D0")]
		[FieldOffset(Offset = "0x18")]
		public TweenScale tween;

		[Token(Token = "0x6002ECC")]
		[Address(RVA = "0x8C0020", Offset = "0x8C0020", VA = "0x8C0020")]
		public _003C_003Ec__DisplayClass18_0()
		{
		}

		[Token(Token = "0x6002ECD")]
		[Address(RVA = "0x8C0028", Offset = "0x8C0028", VA = "0x8C0028")]
		internal void _003COnSelfClicked_003Eb__0()
		{
		}
	}

	[Token(Token = "0x40027C3")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UITexture _mainTexture;

	[Token(Token = "0x40027C4")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UISprite _background;

	[Token(Token = "0x40027C5")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UISprite _emptyIcon;

	[Token(Token = "0x40027C6")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private ButtonHandler _button;

	[Token(Token = "0x40027C7")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private string _emptySpriteName;

	[Token(Token = "0x40027C8")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private string _lockedSpriteName;

	[Token(Token = "0x40027C9")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private float _backgroundLockedAlpha;

	[Token(Token = "0x40027CA")]
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	private ColorModel.ColorModelEnum _unselectedColor;

	[Token(Token = "0x40027CB")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private ColorModel.ColorModelEnum _selectedColor;

	[Token(Token = "0x40027CC")]
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	private float _selectedSizeMultiplier;

	[Token(Token = "0x40027CD")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private float _unselectedSizeMultiplier;

	[Token(Token = "0x40027CE")]
	[FieldOffset(Offset = "0xA4")]
	private bool _isSelected;

	[Token(Token = "0x1700060A")]
	public int AttachmentIndex
	{
		[Token(Token = "0x6002EC1")]
		[Address(RVA = "0x846D9C", Offset = "0x846D9C", VA = "0x846D9C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700060B")]
	protected abstract WeaponUnlockableSaveData.AttachmentSlot[] Attachments
	{
		[Token(Token = "0x6002EC7")]
		get;
	}

	[Token(Token = "0x6002EC2")]
	[Address(RVA = "0x846E58", Offset = "0x846E58", VA = "0x846E58", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002EC3")]
	[Address(RVA = "0x846F50", Offset = "0x846F50", VA = "0x846F50", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002EC4")]
	[Address(RVA = "0x847004", Offset = "0x847004", VA = "0x847004", Slot = "15")]
	public virtual void UpdateIcon()
	{
	}

	[Token(Token = "0x6002EC5")]
	[Address(RVA = "0x8472DC", Offset = "0x8472DC", VA = "0x8472DC")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6002EC6")]
	[Address(RVA = "0x847420", Offset = "0x847420", VA = "0x847420")]
	private void OnSelfClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002EC8")]
	protected abstract AttachmentsUnlockable Load(int idx);

	[Token(Token = "0x6002EC9")]
	protected abstract void Unload(AttachmentsUnlockable attachment);

	[Token(Token = "0x6002ECA")]
	protected abstract void SetBackgroundOutlineColor(Color color);

	[Token(Token = "0x6002ECB")]
	[Address(RVA = "0x8476A0", Offset = "0x8476A0", VA = "0x8476A0")]
	protected SlotView()
	{
	}
}
