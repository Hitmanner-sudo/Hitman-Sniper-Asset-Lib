using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Shop
{
	[Serializable]
	[Token(Token = "0x2000B2B")]
	public struct OfferID
	{
		[Token(Token = "0x40038F4")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private PlatformID _id;

		[Token(Token = "0x40038F5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _editorPrice;

		[Token(Token = "0x600462E")]
		[Address(RVA = "0x9F5894", Offset = "0x9F5894", VA = "0x9F5894")]
		public static implicit operator string(OfferID offerId)
		{
			return null;
		}

		[Token(Token = "0x600462F")]
		[Address(RVA = "0x9F58C8", Offset = "0x9F58C8", VA = "0x9F58C8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
