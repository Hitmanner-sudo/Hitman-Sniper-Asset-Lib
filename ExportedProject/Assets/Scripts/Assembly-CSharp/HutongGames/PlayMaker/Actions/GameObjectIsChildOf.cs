using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200102C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0C80", Offset = "0x5A0C80")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0C80", Offset = "0x5A0C80")]
	public class GameObjectIsChildOf : FsmStateAction
	{
		[Token(Token = "0x4004BF0")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC850", Offset = "0x5DC850")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004BF1")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC89C", Offset = "0x5DC89C")]
		public FsmGameObject isChildOf;

		[Token(Token = "0x4004BF2")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC8E8", Offset = "0x5DC8E8")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004BF3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC920", Offset = "0x5DC920")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004BF4")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DC958", Offset = "0x5DC958")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC958", Offset = "0x5DC958")]
		public FsmBool storeResult;

		[Token(Token = "0x60060FC")]
		[Address(RVA = "0xD99C10", Offset = "0xD99C10", VA = "0xD99C10", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060FD")]
		[Address(RVA = "0xD99C20", Offset = "0xD99C20", VA = "0xD99C20", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060FE")]
		[Address(RVA = "0xD99C68", Offset = "0xD99C68", VA = "0xD99C68")]
		private void DoIsChildOf(GameObject go)
		{
		}

		[Token(Token = "0x60060FF")]
		[Address(RVA = "0xD99D7C", Offset = "0xD99D7C", VA = "0xD99D7C")]
		public GameObjectIsChildOf()
		{
		}
	}
}
