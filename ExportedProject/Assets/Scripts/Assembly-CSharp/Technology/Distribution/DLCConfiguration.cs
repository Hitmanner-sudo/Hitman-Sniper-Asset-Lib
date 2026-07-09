using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BEE")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x5984E4", Offset = "0x5984E4")]
	public class DLCConfiguration
	{
		[Token(Token = "0x2000BEF")]
		public static class Schema
		{
			[Token(Token = "0x4003BBC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly string BUNDLES;

			[Token(Token = "0x4003BBD")]
			[FieldOffset(Offset = "0x8")]
			public static readonly string ID;

			[Token(Token = "0x4003BBE")]
			[FieldOffset(Offset = "0x10")]
			public static readonly string UPDATE_TYPE;

			[Token(Token = "0x4003BBF")]
			[FieldOffset(Offset = "0x18")]
			public static readonly string LOAD_IMMEDIATELY;

			[Token(Token = "0x4003BC0")]
			[FieldOffset(Offset = "0x20")]
			public static readonly string LOAD_ORDER;

			[Token(Token = "0x4003BC1")]
			[FieldOffset(Offset = "0x28")]
			public static readonly string GROUP;

			[Token(Token = "0x4003BC2")]
			[FieldOffset(Offset = "0x30")]
			public static readonly string VERSION;

			[Token(Token = "0x4003BC3")]
			[FieldOffset(Offset = "0x38")]
			public static readonly string RELATIVE_URI;

			[Token(Token = "0x4003BC4")]
			[FieldOffset(Offset = "0x40")]
			public static readonly string BUNDLE_TYPE;

			[Token(Token = "0x4003BC5")]
			[FieldOffset(Offset = "0x48")]
			public static readonly string BUNDLE_ASSETS;

			[Token(Token = "0x4003BC6")]
			[FieldOffset(Offset = "0x50")]
			public static readonly string QUALITY_TYPE;

			[Token(Token = "0x4003BC7")]
			[FieldOffset(Offset = "0x58")]
			public static readonly string SIGNATURE;
		}

		[Token(Token = "0x4003BB8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string CONFIGURATION_FILE_DLC_NODE;

		[Token(Token = "0x4003BB9")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string DLC_HIERARCHICAL_PART;

		[Token(Token = "0x4003BBA")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string INITIAL_JSON;

		[Token(Token = "0x4003BBB")]
		[FieldOffset(Offset = "0x10")]
		private List<DLCEntry> _dlcs;

		[Token(Token = "0x170009A4")]
		public int Count
		{
			[Token(Token = "0x6004BA0")]
			[Address(RVA = "0xADA86C", Offset = "0xADA86C", VA = "0xADA86C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170009A5")]
		public DLCEntry Item
		{
			[Token(Token = "0x6004BA1")]
			[Address(RVA = "0xADA8B8", Offset = "0xADA8B8", VA = "0xADA8B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A6")]
		public DLCEntry Item
		{
			[Token(Token = "0x6004BA2")]
			[Address(RVA = "0xADA92C", Offset = "0xADA92C", VA = "0xADA92C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004BA3")]
		[Address(RVA = "0xADAA28", Offset = "0xADAA28", VA = "0xADAA28")]
		public DLCConfiguration()
		{
		}

		[Token(Token = "0x6004BA4")]
		[Address(RVA = "0xADAAA4", Offset = "0xADAAA4", VA = "0xADAAA4")]
		public void Remove(DLCEntry l_entry)
		{
		}

		[Token(Token = "0x6004BA5")]
		[Address(RVA = "0xADAB08", Offset = "0xADAB08", VA = "0xADAB08")]
		public void Add(DLCEntry l_entry)
		{
		}

		[Token(Token = "0x6004BA6")]
		[Address(RVA = "0xADAB6C", Offset = "0xADAB6C", VA = "0xADAB6C")]
		public bool Contains(string id)
		{
			return default(bool);
		}

		[Token(Token = "0x6004BA7")]
		[Address(RVA = "0xADAC3C", Offset = "0xADAC3C", VA = "0xADAC3C")]
		public void Parse(JSONNode l_confignode, ServerContext l_serverContext, LoadMeta loadMeta)
		{
		}

		[Token(Token = "0x6004BA8")]
		[Address(RVA = "0xADB560", Offset = "0xADB560", VA = "0xADB560")]
		public JSONNode ToJSON()
		{
			return null;
		}
	}
}
