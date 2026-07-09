using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EFC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59AD90", Offset = "0x59AD90")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59AD90", Offset = "0x59AD90")]
	public class SetAnimatorLookAt : ComponentAction<Animator>
	{
		[Token(Token = "0x40046EA")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C8984", Offset = "0x5C8984")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8984", Offset = "0x5C8984")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046EB")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8A18", Offset = "0x5C8A18")]
		public FsmGameObject target;

		[Token(Token = "0x40046EC")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8A50", Offset = "0x5C8A50")]
		public FsmVector3 targetPosition;

		[Token(Token = "0x40046ED")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8A88", Offset = "0x5C8A88")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5C8A88", Offset = "0x5C8A88")]
		public FsmFloat weight;

		[Token(Token = "0x40046EE")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5C8ADC", Offset = "0x5C8ADC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8ADC", Offset = "0x5C8ADC")]
		public FsmFloat bodyWeight;

		[Token(Token = "0x40046EF")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8B30", Offset = "0x5C8B30")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5C8B30", Offset = "0x5C8B30")]
		public FsmFloat headWeight;

		[Token(Token = "0x40046F0")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8B84", Offset = "0x5C8B84")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5C8B84", Offset = "0x5C8B84")]
		public FsmFloat eyesWeight;

		[Token(Token = "0x40046F1")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8BD8", Offset = "0x5C8BD8")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5C8BD8", Offset = "0x5C8BD8")]
		public FsmFloat clampWeight;

		[Token(Token = "0x40046F2")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8C2C", Offset = "0x5C8C2C")]
		public bool everyFrame;

		[Token(Token = "0x40046F3")]
		[FieldOffset(Offset = "0xB0")]
		private GameObject cachedTarget;

		[Token(Token = "0x40046F4")]
		[FieldOffset(Offset = "0xB8")]
		private Transform _transform;

		[Token(Token = "0x17000C20")]
		private Animator animator
		{
			[Token(Token = "0x6005C45")]
			[Address(RVA = "0x10366A0", Offset = "0x10366A0", VA = "0x10366A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005C46")]
		[Address(RVA = "0x10366A8", Offset = "0x10366A8", VA = "0x10366A8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C47")]
		[Address(RVA = "0x1036780", Offset = "0x1036780", VA = "0x1036780", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6005C48")]
		[Address(RVA = "0x10367A0", Offset = "0x10367A0", VA = "0x10367A0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C49")]
		[Address(RVA = "0x10367A4", Offset = "0x10367A4", VA = "0x10367A4", Slot = "60")]
		public override void DoAnimatorIK(int layerIndex)
		{
		}

		[Token(Token = "0x6005C4A")]
		[Address(RVA = "0x10367E0", Offset = "0x10367E0", VA = "0x10367E0")]
		private void DoSetLookAt()
		{
		}

		[Token(Token = "0x6005C4B")]
		[Address(RVA = "0x1036C98", Offset = "0x1036C98", VA = "0x1036C98")]
		public SetAnimatorLookAt()
		{
		}
	}
}
