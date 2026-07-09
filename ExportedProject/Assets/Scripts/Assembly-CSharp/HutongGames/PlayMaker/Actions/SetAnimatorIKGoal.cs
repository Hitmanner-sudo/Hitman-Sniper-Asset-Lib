using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EF8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59AC50", Offset = "0x59AC50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59AC50", Offset = "0x59AC50")]
	public class SetAnimatorIKGoal : ComponentAction<Animator>
	{
		[Token(Token = "0x40046D5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C83D4", Offset = "0x5C83D4")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C83D4", Offset = "0x5C83D4")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046D6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8468", Offset = "0x5C8468")]
		public AvatarIKGoal iKGoal;

		[Token(Token = "0x40046D7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C84A0", Offset = "0x5C84A0")]
		public FsmGameObject goal;

		[Token(Token = "0x40046D8")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C84D8", Offset = "0x5C84D8")]
		public FsmVector3 position;

		[Token(Token = "0x40046D9")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8510", Offset = "0x5C8510")]
		public FsmQuaternion rotation;

		[Token(Token = "0x40046DA")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5C8548", Offset = "0x5C8548")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8548", Offset = "0x5C8548")]
		public FsmFloat positionWeight;

		[Token(Token = "0x40046DB")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5C859C", Offset = "0x5C859C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C859C", Offset = "0x5C859C")]
		public FsmFloat rotationWeight;

		[Token(Token = "0x40046DC")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C85F0", Offset = "0x5C85F0")]
		public bool everyFrame;

		[Token(Token = "0x40046DD")]
		[FieldOffset(Offset = "0xA8")]
		private GameObject cachedGoal;

		[Token(Token = "0x40046DE")]
		[FieldOffset(Offset = "0xB0")]
		private Transform _transform;

		[Token(Token = "0x17000C1E")]
		private Animator animator
		{
			[Token(Token = "0x6005C30")]
			[Address(RVA = "0x1035DAC", Offset = "0x1035DAC", VA = "0x1035DAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005C31")]
		[Address(RVA = "0x1035DB4", Offset = "0x1035DB4", VA = "0x1035DB4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C32")]
		[Address(RVA = "0x1035E94", Offset = "0x1035E94", VA = "0x1035E94", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6005C33")]
		[Address(RVA = "0x1035EB4", Offset = "0x1035EB4", VA = "0x1035EB4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C34")]
		[Address(RVA = "0x1035EB8", Offset = "0x1035EB8", VA = "0x1035EB8", Slot = "60")]
		public override void DoAnimatorIK(int layerIndex)
		{
		}

		[Token(Token = "0x6005C35")]
		[Address(RVA = "0x1035EF4", Offset = "0x1035EF4", VA = "0x1035EF4")]
		private void DoSetIKGoal()
		{
		}

		[Token(Token = "0x6005C36")]
		[Address(RVA = "0x103627C", Offset = "0x103627C", VA = "0x103627C")]
		public SetAnimatorIKGoal()
		{
		}
	}
}
