using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001025")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0920", Offset = "0x5A0920")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A0920", Offset = "0x5A0920")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0920", Offset = "0x5A0920")]
	public class FsmHasVariable : FsmStateAction
	{
		[Token(Token = "0x4004BC2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBD5C", Offset = "0x5DBD5C")]
		[RequiredField]
		public FsmGameObject gameObject;

		[Token(Token = "0x4004BC3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DBDA8", Offset = "0x5DBDA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBDA8", Offset = "0x5DBDA8")]
		public FsmString fsmName;

		[Token(Token = "0x4004BC4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBDF8", Offset = "0x5DBDF8")]
		[RequiredField]
		public FsmString variableName;

		[Token(Token = "0x4004BC5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBE44", Offset = "0x5DBE44")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004BC6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBE7C", Offset = "0x5DBE7C")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004BC7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DBEB4", Offset = "0x5DBEB4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBEB4", Offset = "0x5DBEB4")]
		public FsmBool storeResult;

		[Token(Token = "0x4004BC8")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBF04", Offset = "0x5DBF04")]
		public bool everyFrame;

		[Token(Token = "0x4004BC9")]
		[FieldOffset(Offset = "0x88")]
		private GameObject previousGo;

		[Token(Token = "0x4004BCA")]
		[FieldOffset(Offset = "0x90")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x60060DA")]
		[Address(RVA = "0x95C814", Offset = "0x95C814", VA = "0x95C814", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060DB")]
		[Address(RVA = "0x95C828", Offset = "0x95C828", VA = "0x95C828", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060DC")]
		[Address(RVA = "0x95CA1C", Offset = "0x95CA1C", VA = "0x95CA1C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060DD")]
		[Address(RVA = "0x95C864", Offset = "0x95C864", VA = "0x95C864")]
		private void DoFsmVariableTest()
		{
		}

		[Token(Token = "0x60060DE")]
		[Address(RVA = "0x95CA20", Offset = "0x95CA20", VA = "0x95CA20")]
		public FsmHasVariable()
		{
		}
	}
}
