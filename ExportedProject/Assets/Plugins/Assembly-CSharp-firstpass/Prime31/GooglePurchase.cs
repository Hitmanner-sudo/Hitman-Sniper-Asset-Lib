using System.Collections.Generic;
using Il2CppDummyDll;

namespace Prime31
{
	[Token(Token = "0x2000081")]
	public class GooglePurchase
	{
		[Token(Token = "0x2000082")]
		public enum GooglePurchaseState
		{
			[Token(Token = "0x4000262")]
			Unspecified = 0,
			[Token(Token = "0x4000263")]
			Purchased = 1,
			[Token(Token = "0x4000264")]
			Pending = 2
		}

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F97C8", Offset = "0x6F97C8")]
		private string _003CpackageName_003Ek__BackingField;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F97D8", Offset = "0x6F97D8")]
		private string _003CorderId_003Ek__BackingField;

		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F97E8", Offset = "0x6F97E8")]
		private string _003CproductId_003Ek__BackingField;

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F97F8", Offset = "0x6F97F8")]
		private string _003CdeveloperPayload_003Ek__BackingField;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9808", Offset = "0x6F9808")]
		private string _003Ctype_003Ek__BackingField;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9818", Offset = "0x6F9818")]
		private long _003CpurchaseTime_003Ek__BackingField;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9828", Offset = "0x6F9828")]
		private GooglePurchaseState _003CpurchaseState_003Ek__BackingField;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9838", Offset = "0x6F9838")]
		private string _003CpurchaseToken_003Ek__BackingField;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9848", Offset = "0x6F9848")]
		private string _003Csignature_003Ek__BackingField;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9858", Offset = "0x6F9858")]
		private string _003CoriginalJson_003Ek__BackingField;

		[Token(Token = "0x1700002E")]
		public string packageName
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x10EEBD0", Offset = "0x10EEBD0", VA = "0x10EEBD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAE28", Offset = "0x6FAE28")]
			get
			{
				return null;
			}
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x10EEBD8", Offset = "0x10EEBD8", VA = "0x10EEBD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAE38", Offset = "0x6FAE38")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public string orderId
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x10EEBE0", Offset = "0x10EEBE0", VA = "0x10EEBE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAE48", Offset = "0x6FAE48")]
			get
			{
				return null;
			}
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x10EEBE8", Offset = "0x10EEBE8", VA = "0x10EEBE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAE58", Offset = "0x6FAE58")]
			private set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public string productId
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x10EEBF0", Offset = "0x10EEBF0", VA = "0x10EEBF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAE68", Offset = "0x6FAE68")]
			get
			{
				return null;
			}
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x10EEBF8", Offset = "0x10EEBF8", VA = "0x10EEBF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAE78", Offset = "0x6FAE78")]
			private set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public string developerPayload
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x10EEC00", Offset = "0x10EEC00", VA = "0x10EEC00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAE88", Offset = "0x6FAE88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x10EEC08", Offset = "0x10EEC08", VA = "0x10EEC08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAE98", Offset = "0x6FAE98")]
			private set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public string type
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x10EEC10", Offset = "0x10EEC10", VA = "0x10EEC10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAEA8", Offset = "0x6FAEA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x10EEC18", Offset = "0x10EEC18", VA = "0x10EEC18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAEB8", Offset = "0x6FAEB8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public long purchaseTime
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x10EEC20", Offset = "0x10EEC20", VA = "0x10EEC20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAEC8", Offset = "0x6FAEC8")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x10EEC28", Offset = "0x10EEC28", VA = "0x10EEC28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAED8", Offset = "0x6FAED8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public GooglePurchaseState purchaseState
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x10EEC30", Offset = "0x10EEC30", VA = "0x10EEC30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAEE8", Offset = "0x6FAEE8")]
			get
			{
				return default(GooglePurchaseState);
			}
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x10EEC38", Offset = "0x10EEC38", VA = "0x10EEC38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAEF8", Offset = "0x6FAEF8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public string purchaseToken
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x10EEC40", Offset = "0x10EEC40", VA = "0x10EEC40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAF08", Offset = "0x6FAF08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x10EEC48", Offset = "0x10EEC48", VA = "0x10EEC48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAF18", Offset = "0x6FAF18")]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public string signature
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x10EEC50", Offset = "0x10EEC50", VA = "0x10EEC50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAF28", Offset = "0x6FAF28")]
			get
			{
				return null;
			}
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x10EEC58", Offset = "0x10EEC58", VA = "0x10EEC58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAF38", Offset = "0x6FAF38")]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public string originalJson
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x10EEC60", Offset = "0x10EEC60", VA = "0x10EEC60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAF48", Offset = "0x6FAF48")]
			get
			{
				return null;
			}
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x10EEC68", Offset = "0x10EEC68", VA = "0x10EEC68")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAF58", Offset = "0x6FAF58")]
			private set
			{
			}
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x10EEC70", Offset = "0x10EEC70", VA = "0x10EEC70")]
		public GooglePurchase()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x10EC760", Offset = "0x10EC760", VA = "0x10EC760")]
		public static List<GooglePurchase> fromList(List<object> items)
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x10ECCD8", Offset = "0x10ECCD8", VA = "0x10ECCD8")]
		public GooglePurchase(Dictionary<string, object> dict)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x10EEC78", Offset = "0x10EEC78", VA = "0x10EEC78", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
