using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FD8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F170", Offset = "0x59F170")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F170", Offset = "0x59F170")]
	public class GetChild : FsmStateAction
	{
		[Token(Token = "0x4004A89")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6C10", Offset = "0x5D6C10")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004A8A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6C5C", Offset = "0x5D6C5C")]
		public FsmString childName;

		[Token(Token = "0x4004A8B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D6C94", Offset = "0x5D6C94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6C94", Offset = "0x5D6C94")]
		public FsmString withTag;

		[Token(Token = "0x4004A8C")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D6CE4", Offset = "0x5D6CE4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6CE4", Offset = "0x5D6CE4")]
		public FsmGameObject storeResult;

		[Token(Token = "0x6005F98")]
		[Address(RVA = "0x105DB58", Offset = "0x105DB58", VA = "0x105DB58", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F99")]
		[Address(RVA = "0x105DBD4", Offset = "0x105DBD4", VA = "0x105DBD4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F9A")]
		[Address(RVA = "0x105DC70", Offset = "0x105DC70", VA = "0x105DC70")]
		private static GameObject DoGetChildByName(GameObject root, string name, string tag)
		{
			return null;
		}

		[Token(Token = "0x6005F9B")]
		[Address(RVA = "0x105E100", Offset = "0x105E100", VA = "0x105E100", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x6005F9C")]
		[Address(RVA = "0x105E190", Offset = "0x105E190", VA = "0x105E190")]
		public GetChild()
		{
		}
	}
}
