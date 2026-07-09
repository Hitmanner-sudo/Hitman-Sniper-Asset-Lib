using System.Runtime.InteropServices;
using System.Xml;
using Il2CppDummyDll;

namespace Technology.Core.Build.XCode
{
	[Token(Token = "0x2000D84")]
	public abstract class XmlDoc
	{
		[Token(Token = "0x2000D85")]
		public enum UpdateXMLType
		{
			[Token(Token = "0x4004099")]
			IsNestedType = 0,
			[Token(Token = "0x400409A")]
			IsNotNestedType = 1,
			[Token(Token = "0x400409B")]
			IsValidXMLType = 2
		}

		[Token(Token = "0x4004097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected XmlDocument _doc;

		[Token(Token = "0x600535B")]
		public abstract string Filename();

		[Token(Token = "0x600535C")]
		[Address(RVA = "0x8805FC", Offset = "0x8805FC", VA = "0x8805FC")]
		public void Load(string path)
		{
		}

		[Token(Token = "0x600535D")]
		[Address(RVA = "0x880880", Offset = "0x880880", VA = "0x880880")]
		public void Save(string path)
		{
		}

		[Token(Token = "0x600535E")]
		[Address(RVA = "0x880AB4", Offset = "0x880AB4", VA = "0x880AB4")]
		protected XmlNode FindNode(XmlNode dict, string keyName)
		{
			return null;
		}

		[Token(Token = "0x600535F")]
		[Address(RVA = "0x880B94", Offset = "0x880B94", VA = "0x880B94")]
		protected XmlElement AddChildElement(XmlNode parent, string elementName, [Optional] string innerText)
		{
			return null;
		}

		[Token(Token = "0x6005360")]
		[Address(RVA = "0x880C24", Offset = "0x880C24", VA = "0x880C24")]
		protected bool HasKey(XmlNode dict, string keyName)
		{
			return default(bool);
		}

		[Token(Token = "0x6005361")]
		[Address(RVA = "0x880D08", Offset = "0x880D08", VA = "0x880D08")]
		protected void UpdateXmlDoc(XmlNode dict, XCodeKeyValue[] pairs, UpdateXMLType updateXMLType)
		{
		}

		[Token(Token = "0x6005362")]
		[Address(RVA = "0x8810A0", Offset = "0x8810A0", VA = "0x8810A0")]
		protected XmlDoc()
		{
		}
	}
}
