using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011A0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8E64", Offset = "0x5A8E64")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8E64", Offset = "0x5A8E64")]
	public class ClampRotation : FsmStateAction
	{
		[Token(Token = "0x20011A1")]
		public enum ConstraintAxis
		{
			[Token(Token = "0x40053EC")]
			x = 0,
			[Token(Token = "0x40053ED")]
			y = 1,
			[Token(Token = "0x40053EE")]
			z = 2
		}

		[Token(Token = "0x40053DA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB764", Offset = "0x5FB764")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40053DB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB7B0", Offset = "0x5FB7B0")]
		public FsmVector3 defaultRotation;

		[Token(Token = "0x40053DC")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5FB7E8", Offset = "0x5FB7E8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB7E8", Offset = "0x5FB7E8")]
		public FsmEnum constraintAxis;

		[Token(Token = "0x40053DD")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB86C", Offset = "0x5FB86C")]
		public FsmFloat minAngle;

		[Token(Token = "0x40053DE")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB8A4", Offset = "0x5FB8A4")]
		public FsmFloat maxAngle;

		[Token(Token = "0x40053DF")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB8DC", Offset = "0x5FB8DC")]
		public bool everyFrame;

		[Token(Token = "0x40053E0")]
		[FieldOffset(Offset = "0x7C")]
		private float angleFromMin;

		[Token(Token = "0x40053E1")]
		[FieldOffset(Offset = "0x80")]
		private float angleFromMax;

		[Token(Token = "0x40053E2")]
		[FieldOffset(Offset = "0x88")]
		private Transform thisTransform;

		[Token(Token = "0x40053E3")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 rotateAround;

		[Token(Token = "0x40053E4")]
		[FieldOffset(Offset = "0x9C")]
		private Quaternion minQuaternion;

		[Token(Token = "0x40053E5")]
		[FieldOffset(Offset = "0xAC")]
		private Quaternion maxQuaternion;

		[Token(Token = "0x40053E6")]
		[FieldOffset(Offset = "0xBC")]
		private float range;

		[Token(Token = "0x40053E7")]
		[FieldOffset(Offset = "0xC0")]
		private ConstraintAxis axis;

		[Token(Token = "0x40053E8")]
		[FieldOffset(Offset = "0xC4")]
		private int axisIndex;

		[Token(Token = "0x40053E9")]
		[FieldOffset(Offset = "0xC8")]
		private Quaternion axisRotation;

		[Token(Token = "0x40053EA")]
		[FieldOffset(Offset = "0xD8")]
		private Vector3 _defaultRotation;

		[Token(Token = "0x60067CC")]
		[Address(RVA = "0xB019A0", Offset = "0xB019A0", VA = "0xB019A0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067CD")]
		[Address(RVA = "0xB01A3C", Offset = "0xB01A3C", VA = "0xB01A3C", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60067CE")]
		[Address(RVA = "0xB01A40", Offset = "0xB01A40", VA = "0xB01A40", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067CF")]
		[Address(RVA = "0xB01D40", Offset = "0xB01D40", VA = "0xB01D40", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60067D0")]
		[Address(RVA = "0xB01D7C", Offset = "0xB01D7C", VA = "0xB01D7C")]
		private void DoClampRotation()
		{
		}

		[Token(Token = "0x60067D1")]
		[Address(RVA = "0xB01BDC", Offset = "0xB01BDC", VA = "0xB01BDC")]
		private void ComputeRange()
		{
		}

		[Token(Token = "0x60067D2")]
		[Address(RVA = "0xB0205C", Offset = "0xB0205C", VA = "0xB0205C")]
		public ClampRotation()
		{
		}
	}
}
