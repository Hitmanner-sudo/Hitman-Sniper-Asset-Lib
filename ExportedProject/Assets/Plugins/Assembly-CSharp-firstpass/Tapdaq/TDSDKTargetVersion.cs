using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Tapdaq
{
	[Serializable]
	[Token(Token = "0x2000074")]
	public class TDSDKTargetVersion
	{
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public readonly string iOS;

		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public readonly string android;

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x18BAF18", Offset = "0x18BAF18", VA = "0x18BAF18")]
		public TDSDKTargetVersion(string iosTarget, string androidTarget)
		{
		}
	}
}
