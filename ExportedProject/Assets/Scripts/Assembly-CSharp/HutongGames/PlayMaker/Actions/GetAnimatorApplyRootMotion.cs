using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000ECE")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599F30", Offset = "0x599F30")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599F30", Offset = "0x599F30")]
	public class GetAnimatorApplyRootMotion : ComponentAction<Animator>
	{
		[Token(Token = "0x4004614")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C4270", Offset = "0x5C4270")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4270", Offset = "0x5C4270")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004615")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4304", Offset = "0x5C4304")]
		[Attribute(Name = "ActionSection", RVA = "0x5C4304", Offset = "0x5C4304")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C4304", Offset = "0x5C4304")]
		[RequiredField]
		public FsmBool rootMotionApplied;

		[Token(Token = "0x4004616")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4388", Offset = "0x5C4388")]
		public FsmEvent rootMotionIsAppliedEvent;

		[Token(Token = "0x4004617")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C43C0", Offset = "0x5C43C0")]
		public FsmEvent rootMotionIsNotAppliedEvent;

		[Token(Token = "0x6005B5D")]
		[Address(RVA = "0xDA1E04", Offset = "0xDA1E04", VA = "0xDA1E04", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B5E")]
		[Address(RVA = "0xDA1E14", Offset = "0xDA1E14", VA = "0xDA1E14", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B5F")]
		[Address(RVA = "0xDA1ED4", Offset = "0xDA1ED4", VA = "0xDA1ED4")]
		public GetAnimatorApplyRootMotion()
		{
		}
	}
}
