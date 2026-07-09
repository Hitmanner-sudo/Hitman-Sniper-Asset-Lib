using Il2CppDummyDll;
using Technology.Security;

namespace Technology.Shop
{
	[Token(Token = "0x2000B01")]
	internal class InventoryEntry
	{
		[Token(Token = "0x4003841")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC3E0", Offset = "0x5BC3E0")]
		private Package _003CPackage_003Ek__BackingField;

		[Token(Token = "0x4003842")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC3F0", Offset = "0x5BC3F0")]
		private Item _003CItem_003Ek__BackingField;

		[Token(Token = "0x170008A5")]
		internal Package Package
		{
			[Token(Token = "0x60044B7")]
			[Address(RVA = "0xB1B060", Offset = "0xB1B060", VA = "0xB1B060")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x626218", Offset = "0x626218")]
			get
			{
				return null;
			}
			[Token(Token = "0x60044B8")]
			[Address(RVA = "0xB1B068", Offset = "0xB1B068", VA = "0xB1B068")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x626228", Offset = "0x626228")]
			set
			{
			}
		}

		[Token(Token = "0x170008A6")]
		internal Item Item
		{
			[Token(Token = "0x60044B9")]
			[Address(RVA = "0xB1B070", Offset = "0xB1B070", VA = "0xB1B070")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x626238", Offset = "0x626238")]
			get
			{
				return null;
			}
			[Token(Token = "0x60044BA")]
			[Address(RVA = "0xB1B078", Offset = "0xB1B078", VA = "0xB1B078")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x626248", Offset = "0x626248")]
			private set
			{
			}
		}

		[Token(Token = "0x170008A7")]
		internal SecureLocalInt Quantity
		{
			[Token(Token = "0x60044BB")]
			[Address(RVA = "0xB19418", Offset = "0xB19418", VA = "0xB19418")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60044BC")]
		[Address(RVA = "0xB18E58", Offset = "0xB18E58", VA = "0xB18E58")]
		internal InventoryEntry(Item item, int startingBalance)
		{
		}

		[Token(Token = "0x60044BD")]
		[Address(RVA = "0xB1B080", Offset = "0xB1B080", VA = "0xB1B080")]
		internal InventoryEntry(Item item, Package package)
		{
		}

		[Token(Token = "0x60044BE")]
		[Address(RVA = "0xB1B144", Offset = "0xB1B144", VA = "0xB1B144")]
		public InventoryEntry(Item item)
		{
		}

		[Token(Token = "0x60044BF")]
		[Address(RVA = "0xB1B1F0", Offset = "0xB1B1F0", VA = "0xB1B1F0")]
		internal void Show()
		{
		}

		[Token(Token = "0x60044C0")]
		[Address(RVA = "0xB1B204", Offset = "0xB1B204", VA = "0xB1B204")]
		internal bool IsGameObjectReady()
		{
			return default(bool);
		}

		[Token(Token = "0x60044C1")]
		[Address(RVA = "0xB1AD00", Offset = "0xB1AD00", VA = "0xB1AD00")]
		internal InventoryEntry DeepCopy(Package package)
		{
			return null;
		}
	}
}
