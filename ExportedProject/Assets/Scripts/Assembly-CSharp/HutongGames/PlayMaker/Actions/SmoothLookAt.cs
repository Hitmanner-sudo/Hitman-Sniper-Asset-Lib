using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011B5")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A94C8", Offset = "0x5A94C8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A94C8", Offset = "0x5A94C8")]
	public class SmoothLookAt : FsmStateAction
	{
		[Token(Token = "0x400547F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDAE4", Offset = "0x5FDAE4")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005480")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDB30", Offset = "0x5FDB30")]
		public FsmGameObject targetObject;

		[Token(Token = "0x4005481")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDB68", Offset = "0x5FDB68")]
		public FsmVector3 targetPosition;

		[Token(Token = "0x4005482")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDBA0", Offset = "0x5FDBA0")]
		public FsmVector3 upVector;

		[Token(Token = "0x4005483")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDBD8", Offset = "0x5FDBD8")]
		public FsmBool keepVertical;

		[Token(Token = "0x4005484")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5FDC10", Offset = "0x5FDC10")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDC10", Offset = "0x5FDC10")]
		public FsmFloat speed;

		[Token(Token = "0x4005485")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDC64", Offset = "0x5FDC64")]
		public FsmBool debug;

		[Token(Token = "0x4005486")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDC9C", Offset = "0x5FDC9C")]
		public FsmFloat finishTolerance;

		[Token(Token = "0x4005487")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FDCD4", Offset = "0x5FDCD4")]
		public FsmEvent finishEvent;

		[Token(Token = "0x4005488")]
		[FieldOffset(Offset = "0x98")]
		private GameObject previousGo;

		[Token(Token = "0x4005489")]
		[FieldOffset(Offset = "0xA0")]
		private Quaternion lastRotation;

		[Token(Token = "0x400548A")]
		[FieldOffset(Offset = "0xB0")]
		private Quaternion desiredRotation;

		[Token(Token = "0x400548B")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 lookAtPos;

		[Token(Token = "0x6006845")]
		[Address(RVA = "0x848418", Offset = "0x848418", VA = "0x848418", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006846")]
		[Address(RVA = "0x8484F0", Offset = "0x8484F0", VA = "0x8484F0", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6006847")]
		[Address(RVA = "0x848510", Offset = "0x848510", VA = "0x848510", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006848")]
		[Address(RVA = "0x848518", Offset = "0x848518", VA = "0x848518", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006849")]
		[Address(RVA = "0x84851C", Offset = "0x84851C", VA = "0x84851C")]
		private void DoSmoothLookAt()
		{
		}

		[Token(Token = "0x600684A")]
		[Address(RVA = "0x848A38", Offset = "0x848A38", VA = "0x848A38")]
		public SmoothLookAt()
		{
		}
	}
}
