using System;
using Il2CppDummyDll;
using Technology.Security;

namespace Technology.Shop
{
	[Token(Token = "0x2000B02")]
	public abstract class Item
	{
		[Token(Token = "0x4003843")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BC400", Offset = "0x5BC400")]
		public string Id;

		[Token(Token = "0x4003844")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BC438", Offset = "0x5BC438")]
		public string GameplayContentURI;

		[Token(Token = "0x4003845")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5BC470", Offset = "0x5BC470")]
		public string OnlineSuiteKeyMap;

		[Token(Token = "0x4003846")]
		[FieldOffset(Offset = "0x28")]
		public SecureIntWrapper SecuredQuantity;

		[Token(Token = "0x4003847")]
		public const int DEFAULT_UNKNOWN_QUANTITY = -2;

		[Token(Token = "0x4003848")]
		[FieldOffset(Offset = "0x30")]
		public bool IsNotCollapsed;

		[Token(Token = "0x4003849")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC4A8", Offset = "0x5BC4A8")]
		private string _003CRemoteGameplayContentURI_003Ek__BackingField;

		[Token(Token = "0x170008A8")]
		public string RemoteGameplayContentURI
		{
			[Token(Token = "0x60044C2")]
			[Address(RVA = "0x10BF230", Offset = "0x10BF230", VA = "0x10BF230")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626258", Offset = "0x626258")]
			get
			{
				return null;
			}
			[Token(Token = "0x60044C3")]
			[Address(RVA = "0x10BF238", Offset = "0x10BF238", VA = "0x10BF238")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626268", Offset = "0x626268")]
			set
			{
			}
		}

		[Token(Token = "0x60044C4")]
		public abstract Item DeepCopy();

		[Token(Token = "0x60044C5")]
		[Address(RVA = "0x10BF240", Offset = "0x10BF240", VA = "0x10BF240")]
		protected Item(string id, int qty, string uri, string oskeymap)
		{
		}

		[Token(Token = "0x60044C6")]
		[Address(RVA = "0x10BF2D4", Offset = "0x10BF2D4", VA = "0x10BF2D4")]
		protected Item(string id, SecureLocalInt qty, string uri, string oskeymap)
		{
		}

		[Token(Token = "0x60044C7")]
		[Address(RVA = "0x10BF368", Offset = "0x10BF368", VA = "0x10BF368")]
		protected Item(SecureLocalInt qty, string uri, string oskeymap)
		{
		}

		[Token(Token = "0x60044C8")]
		[Address(RVA = "0x10BF3F4", Offset = "0x10BF3F4", VA = "0x10BF3F4")]
		public string GetURI()
		{
			return null;
		}

		[Token(Token = "0x60044C9")]
		[Address(RVA = "0x10BF76C", Offset = "0x10BF76C", VA = "0x10BF76C", Slot = "5")]
		public virtual void Serialize(string prefix)
		{
		}

		[Token(Token = "0x60044CA")]
		[Address(RVA = "0x10BF968", Offset = "0x10BF968", VA = "0x10BF968", Slot = "6")]
		public virtual void Deserialize(string prefix)
		{
		}

		[Token(Token = "0x60044CB")]
		[Address(RVA = "0x10BFC88", Offset = "0x10BFC88", VA = "0x10BFC88")]
		public static Item LoadItemType(string dkey, Item decorator, Type defaultType)
		{
			return null;
		}

		[Token(Token = "0x60044CC")]
		[Address(RVA = "0x10BFE44", Offset = "0x10BFE44", VA = "0x10BFE44", Slot = "7")]
		public virtual void Decorate(Item decoratee)
		{
		}

		[Token(Token = "0x60044CD")]
		[Address(RVA = "0x10BFE48", Offset = "0x10BFE48", VA = "0x10BFE48", Slot = "8")]
		public virtual string Print()
		{
			return null;
		}
	}
}
