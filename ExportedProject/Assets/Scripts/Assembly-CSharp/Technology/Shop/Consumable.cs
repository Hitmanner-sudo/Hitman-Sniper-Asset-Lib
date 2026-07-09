using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Shop
{
	[Serializable]
	[Token(Token = "0x2000B05")]
	public class Consumable : Item, ISerializationCallbackReceiver
	{
		[Token(Token = "0x60044D9")]
		[Address(RVA = "0x8E32B4", Offset = "0x8E32B4", VA = "0x8E32B4")]
		public Consumable(string id)
		{
		}

		[Token(Token = "0x60044DA")]
		[Address(RVA = "0x8E3350", Offset = "0x8E3350", VA = "0x8E3350")]
		public Consumable(Consumable consumable)
		{
		}

		[Token(Token = "0x60044DB")]
		[Address(RVA = "0x8E33B4", Offset = "0x8E33B4", VA = "0x8E33B4", Slot = "4")]
		public override Item DeepCopy()
		{
			return null;
		}

		[Token(Token = "0x60044DC")]
		[Address(RVA = "0x8E3410", Offset = "0x8E3410", VA = "0x8E3410", Slot = "9")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60044DD")]
		[Address(RVA = "0x8E3414", Offset = "0x8E3414", VA = "0x8E3414", Slot = "10")]
		public void OnAfterDeserialize()
		{
		}
	}
}
