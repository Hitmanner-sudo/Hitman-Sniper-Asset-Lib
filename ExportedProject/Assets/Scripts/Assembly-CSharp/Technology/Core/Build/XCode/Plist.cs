using System.Xml;
using Il2CppDummyDll;

namespace Technology.Core.Build.XCode
{
	[Token(Token = "0x2000D7D")]
	public class Plist : XmlDoc
	{
		[Token(Token = "0x4004089")]
		private const string _fileName = "Info.plist";

		[Token(Token = "0x6005354")]
		[Address(RVA = "0xABFAB4", Offset = "0xABFAB4", VA = "0xABFAB4", Slot = "4")]
		public override string Filename()
		{
			return null;
		}

		[Token(Token = "0x6005355")]
		[Address(RVA = "0xABFAF8", Offset = "0xABFAF8", VA = "0xABFAF8")]
		private XmlNode FindPlistDictNode()
		{
			return null;
		}

		[Token(Token = "0x6005356")]
		[Address(RVA = "0xABFC28", Offset = "0xABFC28", VA = "0xABFC28")]
		public void Update(XCodeKeyValue[] pairs, UpdateXMLType updateXMLType)
		{
		}

		[Token(Token = "0x6005357")]
		[Address(RVA = "0xABFC98", Offset = "0xABFC98", VA = "0xABFC98")]
		public Plist()
		{
		}
	}
}
