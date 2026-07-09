using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001163")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A74C4", Offset = "0x5A74C4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A74C4", Offset = "0x5A74C4")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A74C4", Offset = "0x5A74C4")]
	public class GetFsmVector3 : FsmStateAction
	{
		[Token(Token = "0x40052A4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7A1C", Offset = "0x5F7A1C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40052A5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7A68", Offset = "0x5F7A68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7A68", Offset = "0x5F7A68")]
		public FsmString fsmName;

		[Token(Token = "0x40052A6")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7AB8", Offset = "0x5F7AB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7AB8", Offset = "0x5F7AB8")]
		public FsmString variableName;

		[Token(Token = "0x40052A7")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7B18", Offset = "0x5F7B18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7B18", Offset = "0x5F7B18")]
		public FsmVector3 storeValue;

		[Token(Token = "0x40052A8")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7B78", Offset = "0x5F7B78")]
		public bool everyFrame;

		[Token(Token = "0x40052A9")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x40052AA")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x40052AB")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x60066B5")]
		[Address(RVA = "0x10635C8", Offset = "0x10635C8", VA = "0x10635C8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60066B6")]
		[Address(RVA = "0x1063624", Offset = "0x1063624", VA = "0x1063624", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60066B7")]
		[Address(RVA = "0x1063828", Offset = "0x1063828", VA = "0x1063828", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60066B8")]
		[Address(RVA = "0x1063660", Offset = "0x1063660", VA = "0x1063660")]
		private void DoGetFsmVector3()
		{
		}

		[Token(Token = "0x60066B9")]
		[Address(RVA = "0x106382C", Offset = "0x106382C", VA = "0x106382C")]
		public GetFsmVector3()
		{
		}
	}
}
