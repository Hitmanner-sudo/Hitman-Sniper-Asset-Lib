using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Tapdaq
{
	[Serializable]
	[Token(Token = "0x200007C")]
	public class TDKeyValuePair
	{
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string key;

		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string value;

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x18BA4EC", Offset = "0x18BA4EC", VA = "0x18BA4EC")]
		public TDKeyValuePair(string key, string value)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x18BA524", Offset = "0x18BA524", VA = "0x18BA524")]
		public string getKey()
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x18BA52C", Offset = "0x18BA52C", VA = "0x18BA52C")]
		public string getValue()
		{
			return null;
		}
	}
}
