using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BE1")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x59848C", Offset = "0x59848C")]
	public class ManifestConfiguration
	{
		[Token(Token = "0x2000BE2")]
		public static class Schema
		{
			[Token(Token = "0x4003B83")]
			[FieldOffset(Offset = "0x0")]
			public static readonly string ROOT_NODE;
		}

		[Token(Token = "0x4003B82")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, Bundle> _manifest;

		[Token(Token = "0x1700098A")]
		public Bundle Item
		{
			[Token(Token = "0x6004B48")]
			[Address(RVA = "0x9AEDF4", Offset = "0x9AEDF4", VA = "0x9AEDF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004B49")]
		[Address(RVA = "0x9AEE58", Offset = "0x9AEE58", VA = "0x9AEE58")]
		public ManifestConfiguration()
		{
		}

		[Token(Token = "0x6004B4A")]
		[Address(RVA = "0x9AEED4", Offset = "0x9AEED4", VA = "0x9AEED4")]
		public void Parse(string content, Uri uri)
		{
		}

		[Token(Token = "0x6004B4B")]
		[Address(RVA = "0x9AF710", Offset = "0x9AF710", VA = "0x9AF710")]
		public void Parse(Bundle bundle)
		{
		}

		[Token(Token = "0x6004B4C")]
		[Address(RVA = "0x9AF664", Offset = "0x9AF664", VA = "0x9AF664")]
		public void Add(Bundle bundle)
		{
		}

		[Token(Token = "0x6004B4D")]
		[Address(RVA = "0x9AED8C", Offset = "0x9AED8C", VA = "0x9AED8C")]
		public bool Contains(Bundle bundle)
		{
			return default(bool);
		}

		[Token(Token = "0x6004B4E")]
		[Address(RVA = "0x9AF7D4", Offset = "0x9AF7D4", VA = "0x9AF7D4")]
		public bool Contains(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6004B4F")]
		[Address(RVA = "0x9AF838", Offset = "0x9AF838", VA = "0x9AF838", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004B50")]
		[Address(RVA = "0x9AF85C", Offset = "0x9AF85C", VA = "0x9AF85C")]
		public JSONNode ToJSON()
		{
			return null;
		}
	}
}
