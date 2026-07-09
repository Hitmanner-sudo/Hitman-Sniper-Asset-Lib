using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Shop;

[Token(Token = "0x20002A8")]
public class StarterPackInfo
{
	[Serializable]
	[Token(Token = "0x20002A9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5930C0", Offset = "0x5930C0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000EF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000EF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Credit, string> _003C_003E9__23_0;

		[Token(Token = "0x4000EF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<Credit, int> _003C_003E9__23_1;

		[Token(Token = "0x4000EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<KeyValuePair<string, object>, Credit> _003C_003E9__24_0;

		[Token(Token = "0x6001042")]
		[Address(RVA = "0xA5338C", Offset = "0xA5338C", VA = "0xA5338C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001043")]
		[Address(RVA = "0xA53394", Offset = "0xA53394", VA = "0xA53394")]
		internal string _003CSerialize_003Eb__23_0(Credit credit)
		{
			return null;
		}

		[Token(Token = "0x6001044")]
		[Address(RVA = "0xA533AC", Offset = "0xA533AC", VA = "0xA533AC")]
		internal int _003CSerialize_003Eb__23_1(Credit credit)
		{
			return default(int);
		}

		[Token(Token = "0x6001045")]
		[Address(RVA = "0xA533C8", Offset = "0xA533C8", VA = "0xA533C8")]
		internal Credit _003CDeserialize_003Eb__24_0(KeyValuePair<string, object> creditInfo)
		{
			return null;
		}
	}

	[Token(Token = "0x4000EED")]
	private const string CREDITS_KEY = "credits";

	[Token(Token = "0x4000EEE")]
	private const string END_DATE_TIME_KEY = "endDateTime";

	[Token(Token = "0x4000EEF")]
	private const string DISCOUNT_KEY = "discount";

	[Token(Token = "0x4000EF0")]
	private const float DEFAULT_DISCOUNT = 0.9f;

	[Token(Token = "0x4000EF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private DateTime _endDateTime;

	[Token(Token = "0x4000EF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<Credit> _credits;

	[Token(Token = "0x4000EF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float _discount;

	[Token(Token = "0x17000279")]
	public DateTime EndDateTime
	{
		[Token(Token = "0x6001035")]
		[Address(RVA = "0xD28D1C", Offset = "0xD28D1C", VA = "0xD28D1C")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6001036")]
		[Address(RVA = "0xD28D24", Offset = "0xD28D24", VA = "0xD28D24")]
		private set
		{
		}
	}

	[Token(Token = "0x1700027A")]
	public bool IsActive
	{
		[Token(Token = "0x6001037")]
		[Address(RVA = "0xD28D2C", Offset = "0xD28D2C", VA = "0xD28D2C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700027B")]
	public TimeSpan TimeRemaining
	{
		[Token(Token = "0x6001038")]
		[Address(RVA = "0xD28DD4", Offset = "0xD28DD4", VA = "0xD28DD4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Token(Token = "0x1700027C")]
	public List<Credit> Credits
	{
		[Token(Token = "0x6001039")]
		[Address(RVA = "0xD28ECC", Offset = "0xD28ECC", VA = "0xD28ECC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600103A")]
		[Address(RVA = "0xD28ED4", Offset = "0xD28ED4", VA = "0xD28ED4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700027D")]
	public bool HasCredits
	{
		[Token(Token = "0x600103B")]
		[Address(RVA = "0xD28EDC", Offset = "0xD28EDC", VA = "0xD28EDC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700027E")]
	public float Discount
	{
		[Token(Token = "0x600103C")]
		[Address(RVA = "0xD28F34", Offset = "0xD28F34", VA = "0xD28F34")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600103D")]
		[Address(RVA = "0xD28F3C", Offset = "0xD28F3C", VA = "0xD28F3C")]
		private set
		{
		}
	}

	[Token(Token = "0x600103E")]
	[Address(RVA = "0xD28F44", Offset = "0xD28F44", VA = "0xD28F44")]
	public StarterPackInfo(DateTime endDateTime, [Optional] List<Credit> credits, float discount = 0.9f)
	{
	}

	[Token(Token = "0x600103F")]
	[Address(RVA = "0xD28F8C", Offset = "0xD28F8C", VA = "0xD28F8C")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001040")]
	[Address(RVA = "0xD292B8", Offset = "0xD292B8", VA = "0xD292B8")]
	public static StarterPackInfo Deserialize(string jsonString)
	{
		return null;
	}
}
