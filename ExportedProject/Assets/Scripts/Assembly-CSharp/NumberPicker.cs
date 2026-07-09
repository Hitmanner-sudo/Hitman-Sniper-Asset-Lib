using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200078F")]
public class NumberPicker : MonoBehaviour
{
	[Token(Token = "0x2000790")]
	public class ValueChangedArgs : EventArgs
	{
		[Token(Token = "0x4002A93")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BAA58", Offset = "0x5BAA58")]
		private int _003CPreviousValue_003Ek__BackingField;

		[Token(Token = "0x4002A94")]
		[FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BAA68", Offset = "0x5BAA68")]
		private int _003CNewValue_003Ek__BackingField;

		[Token(Token = "0x17000667")]
		public int PreviousValue
		{
			[Token(Token = "0x6003215")]
			[Address(RVA = "0x8CCAF8", Offset = "0x8CCAF8", VA = "0x8CCAF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622400", Offset = "0x622400")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6003216")]
			[Address(RVA = "0x8CCB00", Offset = "0x8CCB00", VA = "0x8CCB00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622410", Offset = "0x622410")]
			set
			{
			}
		}

		[Token(Token = "0x17000668")]
		public int NewValue
		{
			[Token(Token = "0x6003217")]
			[Address(RVA = "0x8CCB08", Offset = "0x8CCB08", VA = "0x8CCB08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622420", Offset = "0x622420")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6003218")]
			[Address(RVA = "0x8CCB10", Offset = "0x8CCB10", VA = "0x8CCB10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622430", Offset = "0x622430")]
			set
			{
			}
		}

		[Token(Token = "0x6003219")]
		[Address(RVA = "0x8CCB18", Offset = "0x8CCB18", VA = "0x8CCB18")]
		public ValueChangedArgs()
		{
		}
	}

	[Token(Token = "0x4002A8F")]
	[FieldOffset(Offset = "0x20")]
	private int _value;

	[Token(Token = "0x4002A90")]
	[FieldOffset(Offset = "0x28")]
	public ButtonHandler MinusButton;

	[Token(Token = "0x4002A91")]
	[FieldOffset(Offset = "0x30")]
	public ButtonHandler PlusButton;

	[Token(Token = "0x4002A92")]
	[FieldOffset(Offset = "0x38")]
	public UIInput Input;

	[Token(Token = "0x17000666")]
	public int Value
	{
		[Token(Token = "0x600320E")]
		[Address(RVA = "0x9E8270", Offset = "0x9E8270", VA = "0x9E8270")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600320F")]
		[Address(RVA = "0x9E8278", Offset = "0x9E8278", VA = "0x9E8278")]
		set
		{
		}
	}

	[Token(Token = "0x140000A8")]
	public event EventHandler<ValueChangedArgs> OnValueChanged
	{
		[Token(Token = "0x600320C")]
		[Address(RVA = "0x9E8130", Offset = "0x9E8130", VA = "0x9E8130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6223E0", Offset = "0x6223E0")]
		add
		{
		}
		[Token(Token = "0x600320D")]
		[Address(RVA = "0x9E81D0", Offset = "0x9E81D0", VA = "0x9E81D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6223F0", Offset = "0x6223F0")]
		remove
		{
		}
	}

	[Token(Token = "0x6003210")]
	[Address(RVA = "0x9E8390", Offset = "0x9E8390", VA = "0x9E8390")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003211")]
	[Address(RVA = "0x9E852C", Offset = "0x9E852C", VA = "0x9E852C")]
	private void OnSubmit()
	{
	}

	[Token(Token = "0x6003212")]
	[Address(RVA = "0x9E8604", Offset = "0x9E8604", VA = "0x9E8604")]
	private void OnMinusButtonClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6003213")]
	[Address(RVA = "0x9E8610", Offset = "0x9E8610", VA = "0x9E8610")]
	private void OnPlusButtonClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6003214")]
	[Address(RVA = "0x9E861C", Offset = "0x9E861C", VA = "0x9E861C")]
	public NumberPicker()
	{
	}
}
