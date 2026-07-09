using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000810")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x59661C", Offset = "0x59661C")]
public class DDNAMapping
{
	[Serializable]
	[Token(Token = "0x2000811")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596654", Offset = "0x596654")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002CE3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002CE4")]
		[FieldOffset(Offset = "0x8")]
		public static Func<KeyValuePair<string, object>, string> _003C_003E9__13_0;

		[Token(Token = "0x4002CE5")]
		[FieldOffset(Offset = "0x10")]
		public static Func<KeyValuePair<string, object>, string> _003C_003E9__13_1;

		[Token(Token = "0x4002CE6")]
		[FieldOffset(Offset = "0x18")]
		public static Func<KeyValuePair<string, object>, string> _003C_003E9__14_0;

		[Token(Token = "0x4002CE7")]
		[FieldOffset(Offset = "0x20")]
		public static Func<KeyValuePair<string, object>, string> _003C_003E9__14_1;

		[Token(Token = "0x6003481")]
		[Address(RVA = "0x868B5C", Offset = "0x868B5C", VA = "0x868B5C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003482")]
		[Address(RVA = "0x868B64", Offset = "0x868B64", VA = "0x868B64")]
		internal string _003CLoadBaseMapping_003Eb__13_0(KeyValuePair<string, object> kvp)
		{
			return null;
		}

		[Token(Token = "0x6003483")]
		[Address(RVA = "0x868BA4", Offset = "0x868BA4", VA = "0x868BA4")]
		internal string _003CLoadBaseMapping_003Eb__13_1(KeyValuePair<string, object> kvp)
		{
			return null;
		}

		[Token(Token = "0x6003484")]
		[Address(RVA = "0x868C14", Offset = "0x868C14", VA = "0x868C14")]
		internal string _003CToStringDictionary_003Eb__14_0(KeyValuePair<string, object> kvp)
		{
			return null;
		}

		[Token(Token = "0x6003485")]
		[Address(RVA = "0x868C54", Offset = "0x868C54", VA = "0x868C54")]
		internal string _003CToStringDictionary_003Eb__14_1(KeyValuePair<string, object> kvp)
		{
			return null;
		}
	}

	[Token(Token = "0x4002CDF")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private LazyTextAsset _baseMappingText;

	[Token(Token = "0x4002CE0")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, string> _baseMapping;

	[Token(Token = "0x4002CE1")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, string> _overrideMapping;

	[Token(Token = "0x4002CE2")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, string> _mapping;

	[Token(Token = "0x170006B7")]
	private Dictionary<string, string> Mapping
	{
		[Token(Token = "0x6003476")]
		[Address(RVA = "0xBD3778", Offset = "0xBD3778", VA = "0xBD3778")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B8")]
	public string Item
	{
		[Token(Token = "0x6003477")]
		[Address(RVA = "0xBC58A0", Offset = "0xBC58A0", VA = "0xBC58A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003478")]
	[Address(RVA = "0xBC582C", Offset = "0xBC582C", VA = "0xBC582C")]
	public bool ContainsKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6003479")]
	[Address(RVA = "0xBC35D8", Offset = "0xBC35D8", VA = "0xBC35D8")]
	public bool TryGetValue(string key, out string value)
	{
		return default(bool);
	}

	[Token(Token = "0x600347A")]
	[Address(RVA = "0xBD3954", Offset = "0xBD3954", VA = "0xBD3954")]
	public void SetOverrideMapping(JSONNode overrideMapping)
	{
	}

	[Token(Token = "0x600347B")]
	[Address(RVA = "0xBD3B70", Offset = "0xBD3B70", VA = "0xBD3B70")]
	public JSONNode GetOverrideMapping()
	{
		return null;
	}

	[Token(Token = "0x600347C")]
	[Address(RVA = "0xBD37A8", Offset = "0xBD37A8", VA = "0xBD37A8")]
	private void BuildMapping()
	{
	}

	[Token(Token = "0x600347D")]
	[Address(RVA = "0xBD3BE4", Offset = "0xBD3BE4", VA = "0xBD3BE4")]
	private void LoadBaseMapping()
	{
	}

	[Token(Token = "0x600347E")]
	[Address(RVA = "0xBD39BC", Offset = "0xBD39BC", VA = "0xBD39BC")]
	private static Dictionary<string, string> ToStringDictionary(Dictionary<string, object> dict)
	{
		return null;
	}

	[Token(Token = "0x600347F")]
	[Address(RVA = "0xBD3E18", Offset = "0xBD3E18", VA = "0xBD3E18")]
	public DDNAMapping()
	{
	}
}
