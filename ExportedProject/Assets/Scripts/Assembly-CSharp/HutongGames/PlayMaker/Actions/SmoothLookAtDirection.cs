using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011B6")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9518", Offset = "0x5A9518")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9518", Offset = "0x5A9518")]
	public class SmoothLookAtDirection : FsmStateAction
	{
		[Token(Token = "0x400548C")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDD0C", Offset = "0x5FDD0C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400548D")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDD58", Offset = "0x5FDD58")]
		public FsmVector3 targetDirection;

		[Token(Token = "0x400548E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDDA4", Offset = "0x5FDDA4")]
		public FsmFloat minMagnitude;

		[Token(Token = "0x400548F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDDDC", Offset = "0x5FDDDC")]
		public FsmVector3 upVector;

		[Token(Token = "0x4005490")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDE14", Offset = "0x5FDE14")]
		[RequiredField]
		public FsmBool keepVertical;

		[Token(Token = "0x4005491")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5FDE60", Offset = "0x5FDE60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDE60", Offset = "0x5FDE60")]
		[RequiredField]
		public FsmFloat speed;

		[Token(Token = "0x4005492")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDEC4", Offset = "0x5FDEC4")]
		public bool lateUpdate;

		[Token(Token = "0x4005493")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDEFC", Offset = "0x5FDEFC")]
		public FsmEvent finishEvent;

		[Token(Token = "0x4005494")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDF34", Offset = "0x5FDF34")]
		public FsmBool finish;

		[Token(Token = "0x4005495")]
		[FieldOffset(Offset = "0x98")]
		private GameObject previousGo;

		[Token(Token = "0x4005496")]
		[FieldOffset(Offset = "0xA0")]
		private Quaternion lastRotation;

		[Token(Token = "0x4005497")]
		[FieldOffset(Offset = "0xB0")]
		private Quaternion desiredRotation;

		[Token(Token = "0x600684B")]
		[Address(RVA = "0x849218", Offset = "0x849218", VA = "0x849218", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600684C")]
		[Address(RVA = "0x8492EC", Offset = "0x8492EC", VA = "0x8492EC", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x600684D")]
		[Address(RVA = "0x84930C", Offset = "0x84930C", VA = "0x84930C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600684E")]
		[Address(RVA = "0x849314", Offset = "0x849314", VA = "0x849314", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600684F")]
		[Address(RVA = "0x8495E8", Offset = "0x8495E8", VA = "0x8495E8", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006850")]
		[Address(RVA = "0x849324", Offset = "0x849324", VA = "0x849324")]
		private void DoSmoothLookAtDirection()
		{
		}

		[Token(Token = "0x6006851")]
		[Address(RVA = "0x8495F8", Offset = "0x8495F8", VA = "0x8495F8")]
		public SmoothLookAtDirection()
		{
		}
	}
}
