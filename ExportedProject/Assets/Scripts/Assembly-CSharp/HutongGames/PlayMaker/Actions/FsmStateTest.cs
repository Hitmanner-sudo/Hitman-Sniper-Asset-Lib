using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001027")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A0A88", Offset = "0x5A0A88")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0A88", Offset = "0x5A0A88")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0A88", Offset = "0x5A0A88")]
	public class FsmStateTest : FsmStateAction
	{
		[Token(Token = "0x4004BD2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC0D8", Offset = "0x5DC0D8")]
		[RequiredField]
		public FsmGameObject gameObject;

		[Token(Token = "0x4004BD3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC124", Offset = "0x5DC124")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DC124", Offset = "0x5DC124")]
		public FsmString fsmName;

		[Token(Token = "0x4004BD4")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC174", Offset = "0x5DC174")]
		public FsmString stateName;

		[Token(Token = "0x4004BD5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC1C0", Offset = "0x5DC1C0")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004BD6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC1F8", Offset = "0x5DC1F8")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004BD7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DC230", Offset = "0x5DC230")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC230", Offset = "0x5DC230")]
		public FsmBool storeResult;

		[Token(Token = "0x4004BD8")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC280", Offset = "0x5DC280")]
		public bool everyFrame;

		[Token(Token = "0x4004BD9")]
		[FieldOffset(Offset = "0x88")]
		private GameObject previousGo;

		[Token(Token = "0x4004BDA")]
		[FieldOffset(Offset = "0x90")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x60060E4")]
		[Address(RVA = "0x95D734", Offset = "0x95D734", VA = "0x95D734", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060E5")]
		[Address(RVA = "0x95D748", Offset = "0x95D748", VA = "0x95D748", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060E6")]
		[Address(RVA = "0x95D938", Offset = "0x95D938", VA = "0x95D938", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060E7")]
		[Address(RVA = "0x95D784", Offset = "0x95D784", VA = "0x95D784")]
		private void DoFsmStateTest()
		{
		}

		[Token(Token = "0x60060E8")]
		[Address(RVA = "0x95D93C", Offset = "0x95D93C", VA = "0x95D93C")]
		public FsmStateTest()
		{
		}
	}
}
