using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BB2")]
	public class ABConfiguration
	{
		[Token(Token = "0x2000BB3")]
		public static class Schema
		{
			[Token(Token = "0x4003ADB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly string SCHEME;

			[Token(Token = "0x4003ADC")]
			[FieldOffset(Offset = "0x8")]
			public static readonly string HOSTNAME;

			[Token(Token = "0x4003ADD")]
			[FieldOffset(Offset = "0x10")]
			public static readonly string PORT;

			[Token(Token = "0x4003ADE")]
			[FieldOffset(Offset = "0x18")]
			public static readonly string PATH;

			[Token(Token = "0x4003ADF")]
			[FieldOffset(Offset = "0x20")]
			public static readonly string ROOT;

			[Token(Token = "0x4003AE0")]
			[FieldOffset(Offset = "0x28")]
			public static readonly string SEED;

			[Token(Token = "0x4003AE1")]
			[FieldOffset(Offset = "0x30")]
			public static readonly string SEED_ID;

			[Token(Token = "0x4003AE2")]
			[FieldOffset(Offset = "0x38")]
			public static readonly string SEED_DEFAULT;

			[Token(Token = "0x4003AE3")]
			[FieldOffset(Offset = "0x40")]
			public static readonly string SEED_PATHSUFFIX;

			[Token(Token = "0x4003AE4")]
			[FieldOffset(Offset = "0x48")]
			public static readonly string SEED_PROBABILITY;

			[Token(Token = "0x4003AE5")]
			[FieldOffset(Offset = "0x50")]
			public static readonly string SEED_NEWUSERONLY;

			[Token(Token = "0x4003AE6")]
			[FieldOffset(Offset = "0x58")]
			public static readonly string SEED_DURATION;

			[Token(Token = "0x4003AE7")]
			[FieldOffset(Offset = "0x60")]
			public static readonly string SEED_PLATFORM;

			[Token(Token = "0x4003AE8")]
			[FieldOffset(Offset = "0x68")]
			public static readonly string SEED_DEMOGRAPHIC;

			[Token(Token = "0x4003AE9")]
			[FieldOffset(Offset = "0x70")]
			public static readonly string SEED_TERRITORY;

			[Token(Token = "0x4003AEA")]
			[FieldOffset(Offset = "0x78")]
			public static readonly char DEFAULT_SEPARATOR;
		}

		[Token(Token = "0x4003AD3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string GAMEOBJECT_PARENT_NAME;

		[Token(Token = "0x4003AD4")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string CONFIGURATION_FILE_AB_NODE;

		[Token(Token = "0x4003AD5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD694", Offset = "0x5BD694")]
		private string _003CHostname_003Ek__BackingField;

		[Token(Token = "0x4003AD6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD6A4", Offset = "0x5BD6A4")]
		private string _003CPort_003Ek__BackingField;

		[Token(Token = "0x4003AD7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD6B4", Offset = "0x5BD6B4")]
		private string _003CPath_003Ek__BackingField;

		[Token(Token = "0x4003AD8")]
		[FieldOffset(Offset = "0x28")]
		public Scheme.Enum ProtocolScheme;

		[Token(Token = "0x4003AD9")]
		[FieldOffset(Offset = "0x30")]
		private List<Seed> _seeds;

		[Token(Token = "0x4003ADA")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string INITIAL_JSON;

		[Token(Token = "0x1700095D")]
		public string Hostname
		{
			[Token(Token = "0x6004A3F")]
			[Address(RVA = "0xA8FF5C", Offset = "0xA8FF5C", VA = "0xA8FF5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6279B0", Offset = "0x6279B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A40")]
			[Address(RVA = "0xA8FF64", Offset = "0xA8FF64", VA = "0xA8FF64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6279C0", Offset = "0x6279C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700095E")]
		public string Port
		{
			[Token(Token = "0x6004A41")]
			[Address(RVA = "0xA8FF6C", Offset = "0xA8FF6C", VA = "0xA8FF6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6279D0", Offset = "0x6279D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A42")]
			[Address(RVA = "0xA8FF74", Offset = "0xA8FF74", VA = "0xA8FF74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6279E0", Offset = "0x6279E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700095F")]
		public string Path
		{
			[Token(Token = "0x6004A43")]
			[Address(RVA = "0xA8FF7C", Offset = "0xA8FF7C", VA = "0xA8FF7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6279F0", Offset = "0x6279F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A44")]
			[Address(RVA = "0xA8FF84", Offset = "0xA8FF84", VA = "0xA8FF84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627A00", Offset = "0x627A00")]
			set
			{
			}
		}

		[Token(Token = "0x17000960")]
		public List<Seed> Seeds
		{
			[Token(Token = "0x6004A45")]
			[Address(RVA = "0xA8FF8C", Offset = "0xA8FF8C", VA = "0xA8FF8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004A46")]
		[Address(RVA = "0xA8FF94", Offset = "0xA8FF94", VA = "0xA8FF94")]
		public ABConfiguration()
		{
		}

		[Token(Token = "0x6004A47")]
		[Address(RVA = "0xA9006C", Offset = "0xA9006C", VA = "0xA9006C")]
		public JSONNode ToJSON()
		{
			return null;
		}

		[Token(Token = "0x6004A48")]
		[Address(RVA = "0xA902E4", Offset = "0xA902E4", VA = "0xA902E4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004A49")]
		[Address(RVA = "0xA90308", Offset = "0xA90308", VA = "0xA90308")]
		private JSONNode ToJSON(string key, string value)
		{
			return null;
		}

		[Token(Token = "0x6004A4A")]
		[Address(RVA = "0xA904CC", Offset = "0xA904CC", VA = "0xA904CC")]
		public void Parse(JSONNode l_configNode)
		{
		}
	}
}
