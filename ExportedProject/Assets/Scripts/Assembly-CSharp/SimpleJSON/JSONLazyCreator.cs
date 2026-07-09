using System.Collections.Generic;
using Il2CppDummyDll;

namespace SimpleJSON
{
	[Token(Token = "0x2000A22")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x597874", Offset = "0x597874")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x4003548")]
		[FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x4003549")]
		[FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x1700083D")]
		public override JSONNode Item
		{
			[Token(Token = "0x600406D")]
			[Address(RVA = "0x10CED34", Offset = "0x10CED34", VA = "0x10CED34", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600406E")]
			[Address(RVA = "0x10CED94", Offset = "0x10CED94", VA = "0x10CED94", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700083E")]
		public override JSONNode Item
		{
			[Token(Token = "0x600406F")]
			[Address(RVA = "0x10CEE18", Offset = "0x10CEE18", VA = "0x10CEE18", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004070")]
			[Address(RVA = "0x10CEE84", Offset = "0x10CEE84", VA = "0x10CEE84", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700083F")]
		public override string AsString
		{
			[Token(Token = "0x6004079")]
			[Address(RVA = "0x10CF100", Offset = "0x10CF100", VA = "0x10CF100", Slot = "40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600407A")]
			[Address(RVA = "0x10CF184", Offset = "0x10CF184", VA = "0x10CF184", Slot = "41")]
			set
			{
			}
		}

		[Token(Token = "0x17000840")]
		public override int AsInt
		{
			[Token(Token = "0x600407B")]
			[Address(RVA = "0x10CF1F0", Offset = "0x10CF1F0", VA = "0x10CF1F0", Slot = "28")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600407C")]
			[Address(RVA = "0x10CF270", Offset = "0x10CF270", VA = "0x10CF270", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x17000841")]
		public override float AsFloat
		{
			[Token(Token = "0x600407D")]
			[Address(RVA = "0x10CF2F4", Offset = "0x10CF2F4", VA = "0x10CF2F4", Slot = "34")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600407E")]
			[Address(RVA = "0x10CF374", Offset = "0x10CF374", VA = "0x10CF374", Slot = "35")]
			set
			{
			}
		}

		[Token(Token = "0x17000842")]
		public override double AsDouble
		{
			[Token(Token = "0x600407F")]
			[Address(RVA = "0x10CF3F8", Offset = "0x10CF3F8", VA = "0x10CF3F8", Slot = "36")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6004080")]
			[Address(RVA = "0x10CF478", Offset = "0x10CF478", VA = "0x10CF478", Slot = "37")]
			set
			{
			}
		}

		[Token(Token = "0x17000843")]
		public override bool AsBool
		{
			[Token(Token = "0x6004081")]
			[Address(RVA = "0x10CF4FC", Offset = "0x10CF4FC", VA = "0x10CF4FC", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004082")]
			[Address(RVA = "0x10CF57C", Offset = "0x10CF57C", VA = "0x10CF57C", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x17000844")]
		public override long AsLong
		{
			[Token(Token = "0x6004083")]
			[Address(RVA = "0x10CF600", Offset = "0x10CF600", VA = "0x10CF600", Slot = "26")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6004084")]
			[Address(RVA = "0x10CF680", Offset = "0x10CF680", VA = "0x10CF680", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x17000845")]
		public override Dictionary<string, object> AsDictionary
		{
			[Token(Token = "0x6004085")]
			[Address(RVA = "0x10CF704", Offset = "0x10CF704", VA = "0x10CF704", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000846")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6004086")]
			[Address(RVA = "0x10CF770", Offset = "0x10CF770", VA = "0x10CF770", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000847")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x6004087")]
			[Address(RVA = "0x10CF7D4", Offset = "0x10CF7D4", VA = "0x10CF7D4", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600406A")]
		[Address(RVA = "0x10CABCC", Offset = "0x10CABCC", VA = "0x10CABCC")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x600406B")]
		[Address(RVA = "0x10CB794", Offset = "0x10CB794", VA = "0x10CB794")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x600406C")]
		[Address(RVA = "0x10CECD4", Offset = "0x10CECD4", VA = "0x10CECD4")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x6004071")]
		[Address(RVA = "0x10CEF10", Offset = "0x10CEF10", VA = "0x10CEF10", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6004072")]
		[Address(RVA = "0x10CEF94", Offset = "0x10CEF94", VA = "0x10CEF94", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6004073")]
		[Address(RVA = "0x10CF020", Offset = "0x10CF020", VA = "0x10CF020")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6004074")]
		[Address(RVA = "0x10CF038", Offset = "0x10CF038", VA = "0x10CF038")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6004075")]
		[Address(RVA = "0x10CF050", Offset = "0x10CF050", VA = "0x10CF050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6004076")]
		[Address(RVA = "0x10CF068", Offset = "0x10CF068", VA = "0x10CF068", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6004077")]
		[Address(RVA = "0x10CF078", Offset = "0x10CF078", VA = "0x10CF078", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004078")]
		[Address(RVA = "0x10CF0BC", Offset = "0x10CF0BC", VA = "0x10CF0BC", Slot = "18")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
}
