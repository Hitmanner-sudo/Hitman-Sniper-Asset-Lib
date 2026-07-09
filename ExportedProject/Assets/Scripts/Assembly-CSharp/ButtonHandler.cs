using System;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20004FC")]
public class ButtonHandler : GameMonoBehaviour
{
	[Token(Token = "0x20004FD")]
	public class ButtonHandlerEventArgs : EventArgs
	{
		[Token(Token = "0x4001AA8")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly ButtonHandlerEventArgs Empty;

		[Token(Token = "0x6001EBC")]
		[Address(RVA = "0x860D2C", Offset = "0x860D2C", VA = "0x860D2C")]
		public ButtonHandlerEventArgs()
		{
		}
	}

	[Token(Token = "0x20004FE")]
	public class PressButtonHandlerEventArgs : ButtonHandlerEventArgs
	{
		[Token(Token = "0x4001AA9")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B758C", Offset = "0x5B758C")]
		private bool _003CIsPressed_003Ek__BackingField;

		[Token(Token = "0x170004C2")]
		public bool IsPressed
		{
			[Token(Token = "0x6001EBE")]
			[Address(RVA = "0x860DEC", Offset = "0x860DEC", VA = "0x860DEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618E38", Offset = "0x618E38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EBF")]
			[Address(RVA = "0x860DF4", Offset = "0x860DF4", VA = "0x860DF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618E48", Offset = "0x618E48")]
			set
			{
			}
		}

		[Token(Token = "0x6001EC0")]
		[Address(RVA = "0x860E00", Offset = "0x860E00", VA = "0x860E00")]
		public PressButtonHandlerEventArgs()
		{
		}
	}

	[Token(Token = "0x4001A9F")]
	private const float LONG_PRESS_DURATION = 1.5f;

	[Token(Token = "0x4001AA0")]
	[FieldOffset(Offset = "0x48")]
	public SoundContainer OnClickSound;

	[Token(Token = "0x4001AA1")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _allowMultiPress;

	[Token(Token = "0x4001AA5")]
	[FieldOffset(Offset = "0x70")]
	private readonly Timer _longPressTimer;

	[Token(Token = "0x4001AA6")]
	[FieldOffset(Offset = "0x78")]
	private bool _longPressEventFired;

	[Token(Token = "0x4001AA7")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B757C", Offset = "0x5B757C")]
	private static ButtonHandler _003CCurrentButtonPressed_003Ek__BackingField;

	[Token(Token = "0x170004BE")]
	protected bool AllowMultiPress
	{
		[Token(Token = "0x6001EAE")]
		[Address(RVA = "0xA8A164", Offset = "0xA8A164", VA = "0xA8A164")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004BF")]
	protected static ButtonHandler CurrentButtonPressed
	{
		[Token(Token = "0x6001EAF")]
		[Address(RVA = "0xA8A16C", Offset = "0xA8A16C", VA = "0xA8A16C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618E18", Offset = "0x618E18")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001EB0")]
		[Address(RVA = "0xA8A1B8", Offset = "0xA8A1B8", VA = "0xA8A1B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618E28", Offset = "0x618E28")]
		private set
		{
		}
	}

	[Token(Token = "0x170004C0")]
	protected bool IsCurrentButtonPressed
	{
		[Token(Token = "0x6001EB1")]
		[Address(RVA = "0xA8A208", Offset = "0xA8A208", VA = "0xA8A208")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004C1")]
	protected bool IsLongPress
	{
		[Token(Token = "0x6001EB2")]
		[Address(RVA = "0xA8A2A4", Offset = "0xA8A2A4", VA = "0xA8A2A4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1400007D")]
	public event EventHandler<ButtonHandlerEventArgs> OnButtonClick
	{
		[Token(Token = "0x6001EA8")]
		[Address(RVA = "0xA89E44", Offset = "0xA89E44", VA = "0xA89E44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618DB8", Offset = "0x618DB8")]
		add
		{
		}
		[Token(Token = "0x6001EA9")]
		[Address(RVA = "0xA7B874", Offset = "0xA7B874", VA = "0xA7B874")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618DC8", Offset = "0x618DC8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400007E")]
	public event EventHandler<PressButtonHandlerEventArgs> OnButtonPress
	{
		[Token(Token = "0x6001EAA")]
		[Address(RVA = "0xA89EE4", Offset = "0xA89EE4", VA = "0xA89EE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618DD8", Offset = "0x618DD8")]
		add
		{
		}
		[Token(Token = "0x6001EAB")]
		[Address(RVA = "0xA89F84", Offset = "0xA89F84", VA = "0xA89F84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618DE8", Offset = "0x618DE8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400007F")]
	public event EventHandler<ButtonHandlerEventArgs> OnButtonLongPress
	{
		[Token(Token = "0x6001EAC")]
		[Address(RVA = "0xA8A024", Offset = "0xA8A024", VA = "0xA8A024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618DF8", Offset = "0x618DF8")]
		add
		{
		}
		[Token(Token = "0x6001EAD")]
		[Address(RVA = "0xA8A0C4", Offset = "0xA8A0C4", VA = "0xA8A0C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618E08", Offset = "0x618E08")]
		remove
		{
		}
	}

	[Token(Token = "0x6001EB3")]
	[Address(RVA = "0xA8A2F4", Offset = "0xA8A2F4", VA = "0xA8A2F4", Slot = "14")]
	public virtual void ForceOnClick(bool fakeUserInput = true)
	{
	}

	[Token(Token = "0x6001EB4")]
	[Address(RVA = "0xA8A3B0", Offset = "0xA8A3B0", VA = "0xA8A3B0", Slot = "15")]
	protected virtual void OnClick()
	{
	}

	[Token(Token = "0x6001EB5")]
	[Address(RVA = "0xA8A5F4", Offset = "0xA8A5F4", VA = "0xA8A5F4", Slot = "16")]
	protected virtual void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x6001EB6")]
	[Address(RVA = "0xA8A704", Offset = "0xA8A704", VA = "0xA8A704")]
	protected void UpdatePressedButton(bool pressed)
	{
	}

	[Token(Token = "0x6001EB7")]
	[Address(RVA = "0xA8A6B8", Offset = "0xA8A6B8", VA = "0xA8A6B8")]
	protected void UpdateLongPressStatus(bool pressed)
	{
	}

	[Token(Token = "0x6001EB8")]
	[Address(RVA = "0xA8A874", Offset = "0xA8A874", VA = "0xA8A874", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001EB9")]
	[Address(RVA = "0xA8A958", Offset = "0xA8A958", VA = "0xA8A958", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001EBA")]
	[Address(RVA = "0xA8AA3C", Offset = "0xA8AA3C", VA = "0xA8AA3C", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6001EBB")]
	[Address(RVA = "0xA8AB3C", Offset = "0xA8AB3C", VA = "0xA8AB3C")]
	public ButtonHandler()
	{
	}
}
