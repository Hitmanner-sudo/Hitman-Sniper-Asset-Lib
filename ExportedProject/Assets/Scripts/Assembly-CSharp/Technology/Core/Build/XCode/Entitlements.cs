using System.Xml;
using Il2CppDummyDll;

namespace Technology.Core.Build.XCode
{
	[Token(Token = "0x2000D7C")]
	public class Entitlements : XmlDoc
	{
		[Token(Token = "0x4004088")]
		private const string _fileName = ".entitlements";

		[Token(Token = "0x600534F")]
		[Address(RVA = "0xE158D4", Offset = "0xE158D4", VA = "0xE158D4")]
		public static string RelativeFilePath()
		{
			return null;
		}

		[Token(Token = "0x6005350")]
		[Address(RVA = "0xE159F4", Offset = "0xE159F4", VA = "0xE159F4", Slot = "4")]
		public override string Filename()
		{
			return null;
		}

		[Token(Token = "0x6005351")]
		[Address(RVA = "0xE15B14", Offset = "0xE15B14", VA = "0xE15B14")]
		private XmlNode FindPlistDictNode()
		{
			return null;
		}

		[Token(Token = "0x6005352")]
		[Address(RVA = "0xE15C44", Offset = "0xE15C44", VA = "0xE15C44")]
		public void Update(XCodeKeyValue[] pairs, UpdateXMLType updateXMLType)
		{
		}

		[Token(Token = "0x6005353")]
		[Address(RVA = "0xE15CB4", Offset = "0xE15CB4", VA = "0xE15CB4")]
		public Entitlements()
		{
		}
	}
}
