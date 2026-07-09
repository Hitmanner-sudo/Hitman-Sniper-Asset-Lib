using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EF0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A9D0", Offset = "0x59A9D0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A9D0", Offset = "0x59A9D0")]
	public class GetAnimatorTarget : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x40046B2")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7ADC", Offset = "0x5C7ADC")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C7ADC", Offset = "0x5C7ADC")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046B3")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ActionSection", RVA = "0x5C7B70", Offset = "0x5C7B70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C7B70", Offset = "0x5C7B70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7B70", Offset = "0x5C7B70")]
		public FsmVector3 targetPosition;

		[Token(Token = "0x40046B4")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C7BE4", Offset = "0x5C7BE4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7BE4", Offset = "0x5C7BE4")]
		public FsmQuaternion targetRotation;

		[Token(Token = "0x40046B5")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7C34", Offset = "0x5C7C34")]
		public FsmGameObject targetGameObject;

		[Token(Token = "0x40046B6")]
		[FieldOffset(Offset = "0x98")]
		private GameObject cachedTargetGameObject;

		[Token(Token = "0x40046B7")]
		[FieldOffset(Offset = "0xA0")]
		private Transform _transform;

		[Token(Token = "0x17000C1A")]
		private Animator animator
		{
			[Token(Token = "0x6005C0A")]
			[Address(RVA = "0x105C710", Offset = "0x105C710", VA = "0x105C710")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005C0B")]
		[Address(RVA = "0x105C718", Offset = "0x105C718", VA = "0x105C718", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C0C")]
		[Address(RVA = "0x105C748", Offset = "0x105C748", VA = "0x105C748", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C0D")]
		[Address(RVA = "0x105C994", Offset = "0x105C994", VA = "0x105C994", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005C0E")]
		[Address(RVA = "0x105C784", Offset = "0x105C784", VA = "0x105C784")]
		private void DoGetTarget()
		{
		}

		[Token(Token = "0x6005C0F")]
		[Address(RVA = "0x105C998", Offset = "0x105C998", VA = "0x105C998")]
		public GetAnimatorTarget()
		{
		}
	}
}
