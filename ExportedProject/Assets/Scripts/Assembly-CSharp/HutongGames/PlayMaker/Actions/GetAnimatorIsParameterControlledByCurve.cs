using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EE3")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A5C0", Offset = "0x59A5C0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A5C0", Offset = "0x59A5C0")]
	public class GetAnimatorIsParameterControlledByCurve : ComponentAction<Animator>
	{
		[Token(Token = "0x400467E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C66A8", Offset = "0x5C66A8")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C66A8", Offset = "0x5C66A8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400467F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C673C", Offset = "0x5C673C")]
		public FsmString parameterName;

		[Token(Token = "0x4004680")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C6774", Offset = "0x5C6774")]
		[Attribute(Name = "ActionSection", RVA = "0x5C6774", Offset = "0x5C6774")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6774", Offset = "0x5C6774")]
		public FsmBool isControlledByCurve;

		[Token(Token = "0x4004681")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C67E8", Offset = "0x5C67E8")]
		public FsmEvent isControlledByCurveEvent;

		[Token(Token = "0x4004682")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6820", Offset = "0x5C6820")]
		public FsmEvent isNotControlledByCurveEvent;

		[Token(Token = "0x6005BCA")]
		[Address(RVA = "0x105AF5C", Offset = "0x105AF5C", VA = "0x105AF5C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BCB")]
		[Address(RVA = "0x105AF70", Offset = "0x105AF70", VA = "0x105AF70", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BCC")]
		[Address(RVA = "0x105B048", Offset = "0x105B048", VA = "0x105B048")]
		public GetAnimatorIsParameterControlledByCurve()
		{
		}
	}
}
