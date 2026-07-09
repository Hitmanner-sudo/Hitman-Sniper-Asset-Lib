using Il2CppDummyDll;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B6F")]
	public class ItemTemplateSettings
	{
		[Token(Token = "0x4003A1E")]
		[FieldOffset(Offset = "0x10")]
		public int Id;

		[Token(Token = "0x4003A1F")]
		[FieldOffset(Offset = "0x14")]
		private bool _isPermanent;

		[Token(Token = "0x4003A20")]
		[FieldOffset(Offset = "0x15")]
		private bool _hasQuantity;

		[Token(Token = "0x4003A21")]
		[FieldOffset(Offset = "0x16")]
		private bool _hasDuration;

		[Token(Token = "0x4003A22")]
		[FieldOffset(Offset = "0x18")]
		private int _quantity;

		[Token(Token = "0x4003A23")]
		[FieldOffset(Offset = "0x1C")]
		private int _duration;

		[Token(Token = "0x17000924")]
		public bool IsPermanent
		{
			[Token(Token = "0x6004871")]
			[Address(RVA = "0x10C52C8", Offset = "0x10C52C8", VA = "0x10C52C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000925")]
		public bool HasQuantity
		{
			[Token(Token = "0x6004872")]
			[Address(RVA = "0x10C52D0", Offset = "0x10C52D0", VA = "0x10C52D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000926")]
		public bool HasDuration
		{
			[Token(Token = "0x6004873")]
			[Address(RVA = "0x10C52D8", Offset = "0x10C52D8", VA = "0x10C52D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000927")]
		public int Quantity
		{
			[Token(Token = "0x6004874")]
			[Address(RVA = "0x10C52E0", Offset = "0x10C52E0", VA = "0x10C52E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000928")]
		public int Duration
		{
			[Token(Token = "0x6004875")]
			[Address(RVA = "0x10C52E8", Offset = "0x10C52E8", VA = "0x10C52E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004876")]
		[Address(RVA = "0x10C29F8", Offset = "0x10C29F8", VA = "0x10C29F8")]
		public ItemTemplateSettings()
		{
		}

		[Token(Token = "0x6004877")]
		[Address(RVA = "0x10C13F0", Offset = "0x10C13F0", VA = "0x10C13F0")]
		public ItemTemplateSettings(ItemTemplateSettings obj)
		{
		}

		[Token(Token = "0x6004878")]
		[Address(RVA = "0x10C2A0C", Offset = "0x10C2A0C", VA = "0x10C2A0C")]
		public void SetIsPermanent()
		{
		}

		[Token(Token = "0x6004879")]
		[Address(RVA = "0x10C2A1C", Offset = "0x10C2A1C", VA = "0x10C2A1C")]
		public void SetHasQuantity()
		{
		}

		[Token(Token = "0x600487A")]
		[Address(RVA = "0x10C2A2C", Offset = "0x10C2A2C", VA = "0x10C2A2C")]
		public void SetHasDuration()
		{
		}

		[Token(Token = "0x600487B")]
		[Address(RVA = "0x10C52F0", Offset = "0x10C52F0", VA = "0x10C52F0")]
		public void SetQuantity(int _value)
		{
		}

		[Token(Token = "0x600487C")]
		[Address(RVA = "0x10C52F8", Offset = "0x10C52F8", VA = "0x10C52F8")]
		public void SetDuration(int _value)
		{
		}

		[Token(Token = "0x600487D")]
		[Address(RVA = "0x10C2A00", Offset = "0x10C2A00", VA = "0x10C2A00")]
		public void Reset()
		{
		}
	}
}
