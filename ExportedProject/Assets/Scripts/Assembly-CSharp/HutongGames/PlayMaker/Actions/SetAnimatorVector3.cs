using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000E9F")]
	[Attribute(Name = "HelpUrlAttribute", RVA = "0x599298", Offset = "0x599298")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599298", Offset = "0x599298")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599298", Offset = "0x599298")]
	public class SetAnimatorVector3 : FsmStateAction
	{
		[Token(Token = "0x40044BF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0394", Offset = "0x5C0394")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C0394", Offset = "0x5C0394")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40044C0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0428", Offset = "0x5C0428")]
		public FsmString parameter;

		[Token(Token = "0x40044C1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0460", Offset = "0x5C0460")]
		public FsmVector3 Value;

		[Token(Token = "0x40044C2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0498", Offset = "0x5C0498")]
		public bool everyFrame;

		[Token(Token = "0x40044C3")]
		[FieldOffset(Offset = "0x70")]
		private PlayMakerAnimatorMoveProxy _animatorProxy;

		[Token(Token = "0x40044C4")]
		[FieldOffset(Offset = "0x78")]
		private Animator _animator;

		[Token(Token = "0x40044C5")]
		[FieldOffset(Offset = "0x80")]
		private int _paramID;

		[Token(Token = "0x6005A68")]
		[Address(RVA = "0x1037860", Offset = "0x1037860", VA = "0x1037860", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005A69")]
		[Address(RVA = "0x1037870", Offset = "0x1037870", VA = "0x1037870", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005A6A")]
		[Address(RVA = "0x1037B00", Offset = "0x1037B00", VA = "0x1037B00")]
		public void OnAnimatorMoveEvent()
		{
		}

		[Token(Token = "0x6005A6B")]
		[Address(RVA = "0x1037B84", Offset = "0x1037B84", VA = "0x1037B84", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005A6C")]
		[Address(RVA = "0x1037A54", Offset = "0x1037A54", VA = "0x1037A54")]
		private void SetParameter()
		{
		}

		[Token(Token = "0x6005A6D")]
		[Address(RVA = "0x1037C08", Offset = "0x1037C08", VA = "0x1037C08", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005A6E")]
		[Address(RVA = "0x1037CF0", Offset = "0x1037CF0", VA = "0x1037CF0")]
		public SetAnimatorVector3()
		{
		}
	}
}
