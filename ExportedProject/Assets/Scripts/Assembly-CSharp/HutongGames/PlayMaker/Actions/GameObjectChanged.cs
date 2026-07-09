using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001028")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0B40", Offset = "0x5A0B40")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0B40", Offset = "0x5A0B40")]
	public class GameObjectChanged : FsmStateAction
	{
		[Token(Token = "0x4004BDB")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC2B8", Offset = "0x5DC2B8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DC2B8", Offset = "0x5DC2B8")]
		public FsmGameObject gameObjectVariable;

		[Token(Token = "0x4004BDC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC318", Offset = "0x5DC318")]
		public FsmEvent changedEvent;

		[Token(Token = "0x4004BDD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC350", Offset = "0x5DC350")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DC350", Offset = "0x5DC350")]
		public FsmBool storeResult;

		[Token(Token = "0x4004BDE")]
		[FieldOffset(Offset = "0x68")]
		private GameObject previousValue;

		[Token(Token = "0x60060E9")]
		[Address(RVA = "0xD99690", Offset = "0xD99690", VA = "0xD99690", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060EA")]
		[Address(RVA = "0xD9969C", Offset = "0xD9969C", VA = "0xD9969C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060EB")]
		[Address(RVA = "0xD996F8", Offset = "0xD996F8", VA = "0xD996F8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060EC")]
		[Address(RVA = "0xD997CC", Offset = "0xD997CC", VA = "0xD997CC")]
		public GameObjectChanged()
		{
		}
	}
}
