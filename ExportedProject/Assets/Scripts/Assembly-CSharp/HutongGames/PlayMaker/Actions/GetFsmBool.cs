using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001153")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A695C", Offset = "0x5A695C")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A695C", Offset = "0x5A695C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A695C", Offset = "0x5A695C")]
	public class GetFsmBool : FsmStateAction
	{
		[Token(Token = "0x4005224")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F61B8", Offset = "0x5F61B8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005225")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6204", Offset = "0x5F6204")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6204", Offset = "0x5F6204")]
		public FsmString fsmName;

		[Token(Token = "0x4005226")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F6254", Offset = "0x5F6254")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6254", Offset = "0x5F6254")]
		[RequiredField]
		public FsmString variableName;

		[Token(Token = "0x4005227")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F62B4", Offset = "0x5F62B4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F62B4", Offset = "0x5F62B4")]
		[RequiredField]
		public FsmBool storeValue;

		[Token(Token = "0x4005228")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6314", Offset = "0x5F6314")]
		public bool everyFrame;

		[Token(Token = "0x4005229")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x400522A")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x400522B")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6006663")]
		[Address(RVA = "0x1060B90", Offset = "0x1060B90", VA = "0x1060B90", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006664")]
		[Address(RVA = "0x1060BEC", Offset = "0x1060BEC", VA = "0x1060BEC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006665")]
		[Address(RVA = "0x1060DF0", Offset = "0x1060DF0", VA = "0x1060DF0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006666")]
		[Address(RVA = "0x1060C28", Offset = "0x1060C28", VA = "0x1060C28")]
		private void DoGetFsmBool()
		{
		}

		[Token(Token = "0x6006667")]
		[Address(RVA = "0x1060DF4", Offset = "0x1060DF4", VA = "0x1060DF4")]
		public GetFsmBool()
		{
		}
	}
}
