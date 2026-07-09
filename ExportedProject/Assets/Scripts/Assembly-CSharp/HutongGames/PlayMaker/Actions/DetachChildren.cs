using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FD4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F030", Offset = "0x59F030")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F030", Offset = "0x59F030")]
	public class DetachChildren : FsmStateAction
	{
		[Token(Token = "0x4004A7B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D67F0", Offset = "0x5D67F0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x6005F86")]
		[Address(RVA = "0xC13880", Offset = "0xC13880", VA = "0xC13880", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F87")]
		[Address(RVA = "0xC13888", Offset = "0xC13888", VA = "0xC13888", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F88")]
		[Address(RVA = "0xC138C8", Offset = "0xC138C8", VA = "0xC138C8")]
		private static void DoDetachChildren(GameObject go)
		{
		}

		[Token(Token = "0x6005F89")]
		[Address(RVA = "0xC13960", Offset = "0xC13960", VA = "0xC13960")]
		public DetachChildren()
		{
		}
	}
}
