using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001026")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A09D8", Offset = "0x5A09D8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A09D8", Offset = "0x5A09D8")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A09D8", Offset = "0x5A09D8")]
	public class FsmStateSwitch : FsmStateAction
	{
		[Token(Token = "0x4004BCB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBF3C", Offset = "0x5DBF3C")]
		[RequiredField]
		public FsmGameObject gameObject;

		[Token(Token = "0x4004BCC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DBF88", Offset = "0x5DBF88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBF88", Offset = "0x5DBF88")]
		public FsmString fsmName;

		[Token(Token = "0x4004BCD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBFD8", Offset = "0x5DBFD8")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5DBFD8", Offset = "0x5DBFD8")]
		public FsmString[] compareTo;

		[Token(Token = "0x4004BCE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC068", Offset = "0x5DC068")]
		public FsmEvent[] sendEvent;

		[Token(Token = "0x4004BCF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DC0A0", Offset = "0x5DC0A0")]
		public bool everyFrame;

		[Token(Token = "0x4004BD0")]
		[FieldOffset(Offset = "0x78")]
		private GameObject previousGo;

		[Token(Token = "0x4004BD1")]
		[FieldOffset(Offset = "0x80")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x60060DF")]
		[Address(RVA = "0x95D48C", Offset = "0x95D48C", VA = "0x95D48C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060E0")]
		[Address(RVA = "0x95D50C", Offset = "0x95D50C", VA = "0x95D50C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060E1")]
		[Address(RVA = "0x95D728", Offset = "0x95D728", VA = "0x95D728", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060E2")]
		[Address(RVA = "0x95D548", Offset = "0x95D548", VA = "0x95D548")]
		private void DoFsmStateSwitch()
		{
		}

		[Token(Token = "0x60060E3")]
		[Address(RVA = "0x95D72C", Offset = "0x95D72C", VA = "0x95D72C")]
		public FsmStateSwitch()
		{
		}
	}
}
