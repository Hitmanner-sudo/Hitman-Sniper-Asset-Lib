using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010B2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3674", Offset = "0x5A3674")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3674", Offset = "0x5A3674")]
	public class SmoothLookAt2d : FsmStateAction
	{
		[Token(Token = "0x4004EF9")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9A20", Offset = "0x5E9A20")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004EFA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ActionSection", RVA = "0x5E9A6C", Offset = "0x5E9A6C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9A6C", Offset = "0x5E9A6C")]
		public FsmGameObject targetObject;

		[Token(Token = "0x4004EFB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9ACC", Offset = "0x5E9ACC")]
		public FsmVector2 targetPosition2d;

		[Token(Token = "0x4004EFC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9B04", Offset = "0x5E9B04")]
		public FsmVector3 targetPosition;

		[Token(Token = "0x4004EFD")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ActionSection", RVA = "0x5E9B3C", Offset = "0x5E9B3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9B3C", Offset = "0x5E9B3C")]
		public FsmFloat rotationOffset;

		[Token(Token = "0x4004EFE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5E9B9C", Offset = "0x5E9B9C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9B9C", Offset = "0x5E9B9C")]
		public FsmFloat speed;

		[Token(Token = "0x4004EFF")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9BF0", Offset = "0x5E9BF0")]
		public FsmBool useLimits;

		[Token(Token = "0x4004F00")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "HideIfAttribute", RVA = "0x5E9C28", Offset = "0x5E9C28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9C28", Offset = "0x5E9C28")]
		public FsmFloat minAngle;

		[Token(Token = "0x4004F01")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9C88", Offset = "0x5E9C88")]
		[Attribute(Name = "HideIfAttribute", RVA = "0x5E9C88", Offset = "0x5E9C88")]
		public FsmFloat maxAngle;

		[Token(Token = "0x4004F02")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9CE8", Offset = "0x5E9CE8")]
		public FsmBool debug;

		[Token(Token = "0x4004F03")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ActionSection", RVA = "0x5E9D20", Offset = "0x5E9D20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9D20", Offset = "0x5E9D20")]
		public FsmFloat finishTolerance;

		[Token(Token = "0x4004F04")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9D80", Offset = "0x5E9D80")]
		public FsmEvent finishEvent;

		[Token(Token = "0x4004F05")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9DB8", Offset = "0x5E9DB8")]
		public FsmBool finish;

		[Token(Token = "0x4004F06")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject previousGo;

		[Token(Token = "0x4004F07")]
		[FieldOffset(Offset = "0xC0")]
		private Quaternion lastRotation;

		[Token(Token = "0x4004F08")]
		[FieldOffset(Offset = "0xD0")]
		private Quaternion desiredRotation;

		[Token(Token = "0x4004F09")]
		[FieldOffset(Offset = "0xE0")]
		private Vector3 lookAtPos;

		[Token(Token = "0x600639C")]
		[Address(RVA = "0x848A40", Offset = "0x848A40", VA = "0x848A40", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600639D")]
		[Address(RVA = "0x848B28", Offset = "0x848B28", VA = "0x848B28")]
		public bool HideLimits()
		{
			return default(bool);
		}

		[Token(Token = "0x600639E")]
		[Address(RVA = "0x848B54", Offset = "0x848B54", VA = "0x848B54", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x600639F")]
		[Address(RVA = "0x848B74", Offset = "0x848B74", VA = "0x848B74", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063A0")]
		[Address(RVA = "0x848B7C", Offset = "0x848B7C", VA = "0x848B7C", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60063A1")]
		[Address(RVA = "0x848B80", Offset = "0x848B80", VA = "0x848B80")]
		private void DoSmoothLookAt()
		{
		}

		[Token(Token = "0x60063A2")]
		[Address(RVA = "0x849190", Offset = "0x849190", VA = "0x849190")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60063A3")]
		[Address(RVA = "0x849210", Offset = "0x849210", VA = "0x849210")]
		public SmoothLookAt2d()
		{
		}
	}
}
