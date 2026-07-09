using Il2CppDummyDll;
using SimpleJSON;
using UnityEngine;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BE4")]
	public class IAPBundlePrefabMeta
	{
		[Token(Token = "0x4003B88")]
		[FieldOffset(Offset = "0x10")]
		private string _id;

		[Token(Token = "0x4003B89")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD8C4", Offset = "0x5BD8C4")]
		private Object _003CPrefab_003Ek__BackingField;

		[Token(Token = "0x1700098E")]
		public string ID
		{
			[Token(Token = "0x6004B5A")]
			[Address(RVA = "0xA16208", Offset = "0xA16208", VA = "0xA16208")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700098F")]
		public Object Prefab
		{
			[Token(Token = "0x6004B5B")]
			[Address(RVA = "0xA162B4", Offset = "0xA162B4", VA = "0xA162B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x628210", Offset = "0x628210")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B5C")]
			[Address(RVA = "0xA162BC", Offset = "0xA162BC", VA = "0xA162BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x628220", Offset = "0x628220")]
			set
			{
			}
		}

		[Token(Token = "0x6004B5D")]
		[Address(RVA = "0xA162C4", Offset = "0xA162C4", VA = "0xA162C4")]
		public JSONNode ToJSON()
		{
			return null;
		}

		[Token(Token = "0x6004B5E")]
		[Address(RVA = "0xA161B8", Offset = "0xA161B8", VA = "0xA161B8")]
		public IAPBundlePrefabMeta()
		{
		}
	}
}
