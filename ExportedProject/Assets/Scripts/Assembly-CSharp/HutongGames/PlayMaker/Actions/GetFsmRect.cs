using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200115C")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A6FCC", Offset = "0x5A6FCC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6FCC", Offset = "0x5A6FCC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6FCC", Offset = "0x5A6FCC")]
	public class GetFsmRect : FsmStateAction
	{
		[Token(Token = "0x400526C")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F6FEC", Offset = "0x5F6FEC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400526D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7038", Offset = "0x5F7038")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7038", Offset = "0x5F7038")]
		public FsmString fsmName;

		[Token(Token = "0x400526E")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7088", Offset = "0x5F7088")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7088", Offset = "0x5F7088")]
		public FsmString variableName;

		[Token(Token = "0x400526F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F70E8", Offset = "0x5F70E8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F70E8", Offset = "0x5F70E8")]
		[RequiredField]
		public FsmRect storeValue;

		[Token(Token = "0x4005270")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7148", Offset = "0x5F7148")]
		public bool everyFrame;

		[Token(Token = "0x4005271")]
		[FieldOffset(Offset = "0x78")]
		private GameObject goLastFrame;

		[Token(Token = "0x4005272")]
		[FieldOffset(Offset = "0x80")]
		private string fsmNameLastFrame;

		[Token(Token = "0x4005273")]
		[FieldOffset(Offset = "0x88")]
		protected PlayMakerFSM fsm;

		[Token(Token = "0x6006690")]
		[Address(RVA = "0x10621B8", Offset = "0x10621B8", VA = "0x10621B8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006691")]
		[Address(RVA = "0x1062224", Offset = "0x1062224", VA = "0x1062224", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006692")]
		[Address(RVA = "0x1062420", Offset = "0x1062420", VA = "0x1062420", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006693")]
		[Address(RVA = "0x1062260", Offset = "0x1062260", VA = "0x1062260")]
		private void DoGetFsmVariable()
		{
		}

		[Token(Token = "0x6006694")]
		[Address(RVA = "0x1062424", Offset = "0x1062424", VA = "0x1062424")]
		public GetFsmRect()
		{
		}
	}
}
