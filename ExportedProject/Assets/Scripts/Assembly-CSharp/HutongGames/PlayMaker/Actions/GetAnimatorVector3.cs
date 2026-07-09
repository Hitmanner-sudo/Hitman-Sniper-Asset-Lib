using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000E9D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599190", Offset = "0x599190")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599190", Offset = "0x599190")]
	[Attribute(Name = "HelpUrlAttribute", RVA = "0x599190", Offset = "0x599190")]
	public class GetAnimatorVector3 : FsmStateAction
	{
		[Token(Token = "0x40044B1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C00D0", Offset = "0x5C00D0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C00D0", Offset = "0x5C00D0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40044B2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0164", Offset = "0x5C0164")]
		public FsmString parameter;

		[Token(Token = "0x40044B3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C019C", Offset = "0x5C019C")]
		public bool everyFrame;

		[Token(Token = "0x40044B4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C01D4", Offset = "0x5C01D4")]
		[Attribute(Name = "ActionSection", RVA = "0x5C01D4", Offset = "0x5C01D4")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C01D4", Offset = "0x5C01D4")]
		public FsmVector3 result;

		[Token(Token = "0x40044B5")]
		[FieldOffset(Offset = "0x70")]
		private PlayMakerAnimatorMoveProxy _animatorProxy;

		[Token(Token = "0x40044B6")]
		[FieldOffset(Offset = "0x78")]
		private Animator _animator;

		[Token(Token = "0x40044B7")]
		[FieldOffset(Offset = "0x80")]
		private int _paramID;

		[Token(Token = "0x6005A5A")]
		[Address(RVA = "0x105C9A0", Offset = "0x105C9A0", VA = "0x105C9A0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005A5B")]
		[Address(RVA = "0x105C9B0", Offset = "0x105C9B0", VA = "0x105C9B0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005A5C")]
		[Address(RVA = "0x105CC30", Offset = "0x105CC30", VA = "0x105CC30")]
		public void OnAnimatorMoveEvent()
		{
		}

		[Token(Token = "0x6005A5D")]
		[Address(RVA = "0x105CCB4", Offset = "0x105CCB4", VA = "0x105CCB4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005A5E")]
		[Address(RVA = "0x105CB94", Offset = "0x105CB94", VA = "0x105CB94")]
		private void GetParameter()
		{
		}

		[Token(Token = "0x6005A5F")]
		[Address(RVA = "0x105CD38", Offset = "0x105CD38", VA = "0x105CD38", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005A60")]
		[Address(RVA = "0x105CE20", Offset = "0x105CE20", VA = "0x105CE20")]
		public GetAnimatorVector3()
		{
		}
	}
}
