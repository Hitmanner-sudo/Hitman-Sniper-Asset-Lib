using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FE8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F670", Offset = "0x59F670")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F670", Offset = "0x59F670")]
	public class HasComponent : FsmStateAction
	{
		[Token(Token = "0x4004AC1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7BEC", Offset = "0x5D7BEC")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004AC2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D7C38", Offset = "0x5D7C38")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7C38", Offset = "0x5D7C38")]
		public FsmString component;

		[Token(Token = "0x4004AC3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7C98", Offset = "0x5D7C98")]
		public FsmBool removeOnExit;

		[Token(Token = "0x4004AC4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7CD0", Offset = "0x5D7CD0")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004AC5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7D08", Offset = "0x5D7D08")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004AC6")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7D40", Offset = "0x5D7D40")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D7D40", Offset = "0x5D7D40")]
		public FsmBool store;

		[Token(Token = "0x4004AC7")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7D90", Offset = "0x5D7D90")]
		public bool everyFrame;

		[Token(Token = "0x4004AC8")]
		[FieldOffset(Offset = "0x88")]
		private Component aComponent;

		[Token(Token = "0x6005FDF")]
		[Address(RVA = "0xA08E8C", Offset = "0xA08E8C", VA = "0xA08E8C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FE0")]
		[Address(RVA = "0xA08EA4", Offset = "0xA08EA4", VA = "0xA08EA4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FE1")]
		[Address(RVA = "0xA090D0", Offset = "0xA090D0", VA = "0xA090D0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005FE2")]
		[Address(RVA = "0xA09120", Offset = "0xA09120", VA = "0xA09120", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005FE3")]
		[Address(RVA = "0xA08F14", Offset = "0xA08F14", VA = "0xA08F14")]
		private void DoHasComponent(GameObject go)
		{
		}

		[Token(Token = "0x6005FE4")]
		[Address(RVA = "0xA091E8", Offset = "0xA091E8", VA = "0xA091E8")]
		public HasComponent()
		{
		}
	}
}
