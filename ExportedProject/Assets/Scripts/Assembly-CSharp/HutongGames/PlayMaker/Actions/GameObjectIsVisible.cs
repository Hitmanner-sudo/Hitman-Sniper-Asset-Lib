using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200102E")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A0D20", Offset = "0x5A0D20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0D20", Offset = "0x5A0D20")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0D20", Offset = "0x5A0D20")]
	public class GameObjectIsVisible : ComponentAction<Renderer>
	{
		[Token(Token = "0x4004BFA")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCB10", Offset = "0x5DCB10")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DCB10", Offset = "0x5DCB10")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004BFB")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCBA4", Offset = "0x5DCBA4")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004BFC")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCBDC", Offset = "0x5DCBDC")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004BFD")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCC14", Offset = "0x5DCC14")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DCC14", Offset = "0x5DCC14")]
		public FsmBool storeResult;

		[Token(Token = "0x4004BFE")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DCC64", Offset = "0x5DCC64")]
		public bool everyFrame;

		[Token(Token = "0x6006105")]
		[Address(RVA = "0xD99E98", Offset = "0xD99E98", VA = "0xD99E98", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006106")]
		[Address(RVA = "0xD99EAC", Offset = "0xD99EAC", VA = "0xD99EAC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006107")]
		[Address(RVA = "0xD99FC4", Offset = "0xD99FC4", VA = "0xD99FC4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006108")]
		[Address(RVA = "0xD99EE8", Offset = "0xD99EE8", VA = "0xD99EE8")]
		private void DoIsVisible()
		{
		}

		[Token(Token = "0x6006109")]
		[Address(RVA = "0xD99FC8", Offset = "0xD99FC8", VA = "0xD99FC8")]
		public GameObjectIsVisible()
		{
		}
	}
}
