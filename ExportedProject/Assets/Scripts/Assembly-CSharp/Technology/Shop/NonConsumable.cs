using System;
using Il2CppDummyDll;
using Technology.Security;
using UnityEngine;

namespace Technology.Shop
{
	[Serializable]
	[Token(Token = "0x2000B06")]
	public class NonConsumable : Item, ISerializationCallbackReceiver
	{
		[Token(Token = "0x60044DE")]
		[Address(RVA = "0xC5E274", Offset = "0xC5E274", VA = "0xC5E274")]
		public NonConsumable(string id)
		{
		}

		[Token(Token = "0x60044DF")]
		[Address(RVA = "0xC5E310", Offset = "0xC5E310", VA = "0xC5E310")]
		public NonConsumable(string id, SecureLocalInt quantity)
		{
		}

		[Token(Token = "0x60044E0")]
		[Address(RVA = "0xC5E384", Offset = "0xC5E384", VA = "0xC5E384")]
		public NonConsumable(NonConsumable nonconsumable)
		{
		}

		[Token(Token = "0x60044E1")]
		[Address(RVA = "0xC5E3E8", Offset = "0xC5E3E8", VA = "0xC5E3E8", Slot = "4")]
		public override Item DeepCopy()
		{
			return null;
		}

		[Token(Token = "0x60044E2")]
		[Address(RVA = "0xC5E444", Offset = "0xC5E444", VA = "0xC5E444", Slot = "9")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60044E3")]
		[Address(RVA = "0xC5E448", Offset = "0xC5E448", VA = "0xC5E448", Slot = "10")]
		public void OnAfterDeserialize()
		{
		}
	}
}
