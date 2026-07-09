using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EC6")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599D50", Offset = "0x599D50")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599D50", Offset = "0x599D50")]
	public class AnimatorMatchTarget : ComponentAction<Animator>
	{
		[Token(Token = "0x40045F4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3AA0", Offset = "0x5C3AA0")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C3AA0", Offset = "0x5C3AA0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045F5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3B34", Offset = "0x5C3B34")]
		public AvatarTarget bodyPart;

		[Token(Token = "0x40045F6")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3B6C", Offset = "0x5C3B6C")]
		public FsmGameObject target;

		[Token(Token = "0x40045F7")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3BA4", Offset = "0x5C3BA4")]
		public FsmVector3 targetPosition;

		[Token(Token = "0x40045F8")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3BDC", Offset = "0x5C3BDC")]
		public FsmQuaternion targetRotation;

		[Token(Token = "0x40045F9")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3C14", Offset = "0x5C3C14")]
		public FsmVector3 positionWeight;

		[Token(Token = "0x40045FA")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3C4C", Offset = "0x5C3C4C")]
		public FsmFloat rotationWeight;

		[Token(Token = "0x40045FB")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3C84", Offset = "0x5C3C84")]
		public FsmFloat startNormalizedTime;

		[Token(Token = "0x40045FC")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3CBC", Offset = "0x5C3CBC")]
		public FsmFloat targetNormalizedTime;

		[Token(Token = "0x40045FD")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3CF4", Offset = "0x5C3CF4")]
		public bool everyFrame;

		[Token(Token = "0x40045FE")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject cachedTarget;

		[Token(Token = "0x40045FF")]
		[FieldOffset(Offset = "0xC0")]
		private Transform targetTransform;

		[Token(Token = "0x4004600")]
		[FieldOffset(Offset = "0xC8")]
		private MatchTargetWeightMask weightMask;

		[Token(Token = "0x17000C04")]
		private Animator animator
		{
			[Token(Token = "0x6005B3E")]
			[Address(RVA = "0xD472A4", Offset = "0xD472A4", VA = "0xD472A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B3F")]
		[Address(RVA = "0xD472AC", Offset = "0xD472AC", VA = "0xD472AC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B40")]
		[Address(RVA = "0xD4738C", Offset = "0xD4738C", VA = "0xD4738C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B41")]
		[Address(RVA = "0xD47764", Offset = "0xD47764", VA = "0xD47764", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005B42")]
		[Address(RVA = "0xD474EC", Offset = "0xD474EC", VA = "0xD474EC")]
		private void DoMatchTarget()
		{
		}

		[Token(Token = "0x6005B43")]
		[Address(RVA = "0xD47768", Offset = "0xD47768", VA = "0xD47768")]
		public AnimatorMatchTarget()
		{
		}
	}
}
