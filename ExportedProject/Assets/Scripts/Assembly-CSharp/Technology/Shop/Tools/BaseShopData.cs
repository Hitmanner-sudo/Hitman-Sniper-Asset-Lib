using System;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B44")]
	public abstract class BaseShopData
	{
		[Token(Token = "0x4003960")]
		[FieldOffset(Offset = "0x10")]
		public int Id;

		[Token(Token = "0x4003961")]
		[FieldOffset(Offset = "0x18")]
		public string _name;

		[Token(Token = "0x4003962")]
		[FieldOffset(Offset = "0x20")]
		public int CustomNumber;

		[Token(Token = "0x4003963")]
		[FieldOffset(Offset = "0x28")]
		public string CustomData;

		[Token(Token = "0x4003964")]
		[FieldOffset(Offset = "0x30")]
		public string ParentName;

		[Token(Token = "0x4003965")]
		[FieldOffset(Offset = "0x38")]
		protected string _objectName;

		[Token(Token = "0x1700090F")]
		public virtual string Name
		{
			[Token(Token = "0x6004745")]
			[Address(RVA = "0xC0DE60", Offset = "0xC0DE60", VA = "0xC0DE60", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004744")]
			[Address(RVA = "0xC0DE58", Offset = "0xC0DE58", VA = "0xC0DE58", Slot = "4")]
			set
			{
			}
		}

		[Token(Token = "0x17000910")]
		public abstract string ObjectName
		{
			[Token(Token = "0x6004749")]
			get;
		}

		[Token(Token = "0x17000911")]
		public virtual string UniqueId
		{
			[Token(Token = "0x600474A")]
			[Address(RVA = "0xC0E02C", Offset = "0xC0E02C", VA = "0xC0E02C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000912")]
		public virtual bool HasSetMandatoryValues
		{
			[Token(Token = "0x600474B")]
			[Address(RVA = "0xC0E038", Offset = "0xC0E038", VA = "0xC0E038", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004746")]
		[Address(RVA = "0xC0DE68", Offset = "0xC0DE68", VA = "0xC0DE68")]
		public BaseShopData()
		{
		}

		[Token(Token = "0x6004747")]
		[Address(RVA = "0xC0DEDC", Offset = "0xC0DEDC", VA = "0xC0DEDC")]
		public BaseShopData(BaseShopData obj)
		{
		}

		[Token(Token = "0x6004748")]
		[Address(RVA = "0xC0DFA8", Offset = "0xC0DFA8", VA = "0xC0DFA8", Slot = "6")]
		public virtual void Init()
		{
		}

		[Token(Token = "0x600474C")]
		internal abstract string ToJSON();

		[Token(Token = "0x600474D")]
		internal abstract void FromJSON(JSONNode node);

		[Token(Token = "0x600474E")]
		[Address(RVA = "0xC0E040", Offset = "0xC0E040", VA = "0xC0E040", Slot = "12")]
		public virtual bool Create()
		{
			return default(bool);
		}

		[Token(Token = "0x600474F")]
		[Address(RVA = "0xC0E080", Offset = "0xC0E080", VA = "0xC0E080", Slot = "13")]
		public virtual bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x6004750")]
		[Address(RVA = "0xC0E0C0", Offset = "0xC0E0C0", VA = "0xC0E0C0", Slot = "14")]
		public virtual bool Delete()
		{
			return default(bool);
		}

		[Token(Token = "0x6004751")]
		[Address(RVA = "0xC0E100", Offset = "0xC0E100", VA = "0xC0E100", Slot = "15")]
		internal virtual string GetObjectToString()
		{
			return null;
		}

		[Token(Token = "0x6004752")]
		[Address(RVA = "0xC0E14C", Offset = "0xC0E14C", VA = "0xC0E14C")]
		protected static string GetNodeValue(JSONNode node, string name)
		{
			return null;
		}

		[Token(Token = "0x6004753")]
		[Address(RVA = "0xC0E21C", Offset = "0xC0E21C", VA = "0xC0E21C")]
		protected static DateTime ParseDate(JSONNode node, string name, DateTime defaultDate, bool subNodeDate = false)
		{
			return default(DateTime);
		}
	}
}
