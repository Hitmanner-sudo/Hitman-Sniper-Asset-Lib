using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004F5")]
public class BlinkButtonHandler : ButtonHandler
{
	[Token(Token = "0x20004F6")]
	public class ButtonBlinkFinishedHandlerEventArgs : ButtonHandlerEventArgs
	{
		[Token(Token = "0x6001E9C")]
		[Address(RVA = "0x926174", Offset = "0x926174", VA = "0x926174")]
		public ButtonBlinkFinishedHandlerEventArgs()
		{
		}
	}

	[Token(Token = "0x4001A85")]
	[FieldOffset(Offset = "0x88")]
	public UIWidget Image;

	[Token(Token = "0x4001A86")]
	[FieldOffset(Offset = "0x90")]
	public TweenColor ColorTweener;

	[Token(Token = "0x4001A87")]
	[FieldOffset(Offset = "0x98")]
	public int BlinkCount;

	[Token(Token = "0x4001A88")]
	[FieldOffset(Offset = "0x9C")]
	public bool UseColorModel;

	[Token(Token = "0x4001A89")]
	[FieldOffset(Offset = "0x9D")]
	public bool DoPulse;

	[Token(Token = "0x4001A8A")]
	[FieldOffset(Offset = "0x9E")]
	public bool UseGlobalBlinkColor;

	[Token(Token = "0x4001A8B")]
	[FieldOffset(Offset = "0xA0")]
	public Color CustomBlinkColor;

	[Token(Token = "0x4001A8C")]
	[FieldOffset(Offset = "0xB0")]
	public bool ShowPress;

	[Token(Token = "0x4001A8D")]
	[FieldOffset(Offset = "0xB8")]
	public UIWidget OtherPulseWidget;

	[Token(Token = "0x4001A8E")]
	[FieldOffset(Offset = "0xC0")]
	public bool BlockInput;

	[Token(Token = "0x4001A8F")]
	[FieldOffset(Offset = "0xC4")]
	private int _blinkCount;

	[Token(Token = "0x4001A90")]
	[FieldOffset(Offset = "0xC8")]
	private bool _isBlinking;

	[Token(Token = "0x4001A91")]
	[FieldOffset(Offset = "0xCC")]
	private float _blinkTime;

	[Token(Token = "0x4001A92")]
	[FieldOffset(Offset = "0xD0")]
	private bool _isPressed;

	[Token(Token = "0x4001A93")]
	[FieldOffset(Offset = "0xD4")]
	private Color? _originalColor;

	[Token(Token = "0x4001A94")]
	[FieldOffset(Offset = "0xE8")]
	private Color? _colorOfOtherWidget;

	[Token(Token = "0x4001A95")]
	[FieldOffset(Offset = "0x0")]
	private static float _blinkDuration;

	[Token(Token = "0x4001A96")]
	[FieldOffset(Offset = "0x4")]
	private static float _pulseDuration;

	[Token(Token = "0x170004BA")]
	public bool IsBlinking
	{
		[Token(Token = "0x6001E86")]
		[Address(RVA = "0xC675BC", Offset = "0xC675BC", VA = "0xC675BC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001E87")]
		[Address(RVA = "0xC675C4", Offset = "0xC675C4", VA = "0xC675C4")]
		set
		{
		}
	}

	[Token(Token = "0x170004BB")]
	public Color OriginalColor
	{
		[Token(Token = "0x6001E88")]
		[Address(RVA = "0xC676E0", Offset = "0xC676E0", VA = "0xC676E0")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6001E89")]
		[Address(RVA = "0xC67738", Offset = "0xC67738", VA = "0xC67738")]
		set
		{
		}
	}

	[Token(Token = "0x170004BC")]
	public Color ColorOfOtherWidget
	{
		[Token(Token = "0x6001E8A")]
		[Address(RVA = "0xC677D8", Offset = "0xC677D8", VA = "0xC677D8")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6001E8B")]
		[Address(RVA = "0xC67830", Offset = "0xC67830", VA = "0xC67830")]
		set
		{
		}
	}

	[Token(Token = "0x1400007C")]
	public event EventHandler<ButtonBlinkFinishedHandlerEventArgs> OnButtonBlinkFinished
	{
		[Token(Token = "0x6001E84")]
		[Address(RVA = "0xC6747C", Offset = "0xC6747C", VA = "0xC6747C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618D78", Offset = "0x618D78")]
		add
		{
		}
		[Token(Token = "0x6001E85")]
		[Address(RVA = "0xC6751C", Offset = "0xC6751C", VA = "0xC6751C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618D88", Offset = "0x618D88")]
		remove
		{
		}
	}

	[Token(Token = "0x6001E8C")]
	[Address(RVA = "0xC678D0", Offset = "0xC678D0", VA = "0xC678D0", Slot = "14")]
	public override void ForceOnClick(bool fakeUserInput = true)
	{
	}

	[Token(Token = "0x6001E8D")]
	[Address(RVA = "0xC67970", Offset = "0xC67970", VA = "0xC67970", Slot = "17")]
	protected virtual void RaiseButtonBlinkFinished(object sender, ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6001E8E")]
	[Address(RVA = "0xC679D0", Offset = "0xC679D0", VA = "0xC679D0", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001E8F")]
	[Address(RVA = "0xC67B70", Offset = "0xC67B70", VA = "0xC67B70", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001E90")]
	[Address(RVA = "0xC67BB0", Offset = "0xC67BB0", VA = "0xC67BB0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001E91")]
	[Address(RVA = "0xC67E30", Offset = "0xC67E30", VA = "0xC67E30", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001E92")]
	[Address(RVA = "0xC67EBC", Offset = "0xC67EBC", VA = "0xC67EBC")]
	protected void Update()
	{
	}

	[Token(Token = "0x6001E93")]
	[Address(RVA = "0xC67BAC", Offset = "0xC67BAC", VA = "0xC67BAC")]
	public void ChangeOriginalColor(Color color)
	{
	}

	[Token(Token = "0x6001E94")]
	[Address(RVA = "0xC683B0", Offset = "0xC683B0", VA = "0xC683B0")]
	public void ResetColors()
	{
	}

	[Token(Token = "0x6001E95")]
	[Address(RVA = "0xC6849C", Offset = "0xC6849C", VA = "0xC6849C", Slot = "16")]
	protected override void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6001E96")]
	[Address(RVA = "0xC686A4", Offset = "0xC686A4", VA = "0xC686A4", Slot = "15")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x6001E97")]
	[Address(RVA = "0xC688F4", Offset = "0xC688F4", VA = "0xC688F4")]
	private void BlinkButton()
	{
	}

	[Token(Token = "0x6001E98")]
	[Address(RVA = "0xC68334", Offset = "0xC68334", VA = "0xC68334")]
	private void BlinkFinished()
	{
	}

	[Token(Token = "0x6001E99")]
	[Address(RVA = "0xC67D48", Offset = "0xC67D48", VA = "0xC67D48")]
	private Color GetColorToBlinkTo()
	{
		return default(Color);
	}

	[Token(Token = "0x6001E9A")]
	[Address(RVA = "0xC68A08", Offset = "0xC68A08", VA = "0xC68A08")]
	public void InterruptBlink()
	{
	}

	[Token(Token = "0x6001E9B")]
	[Address(RVA = "0xC68B44", Offset = "0xC68B44", VA = "0xC68B44")]
	public BlinkButtonHandler()
	{
	}
}
