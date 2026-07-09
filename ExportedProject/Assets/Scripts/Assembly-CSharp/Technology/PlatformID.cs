using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Serializable]
	[Token(Token = "0x2000A73")]
	public struct PlatformID
	{
		[Token(Token = "0x4003667")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string _default;

		[Token(Token = "0x4003668")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private string _ios;

		[Token(Token = "0x4003669")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _android;

		[Token(Token = "0x60041F4")]
		[Address(RVA = "0x90AE34", Offset = "0x90AE34", VA = "0x90AE34")]
		public static implicit operator string(PlatformID id)
		{
			return null;
		}
	}
}
