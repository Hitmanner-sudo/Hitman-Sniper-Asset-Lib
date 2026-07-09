using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000E9C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59910C", Offset = "0x59910C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59910C", Offset = "0x59910C")]
	[Attribute(Name = "HelpUrlAttribute", RVA = "0x59910C", Offset = "0x59910C")]
	public class GetAnimatorQuaternion : FsmStateAction
	{
		[Token(Token = "0x40044AA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5BFF48", Offset = "0x5BFF48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5BFF48", Offset = "0x5BFF48")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40044AB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5BFFDC", Offset = "0x5BFFDC")]
		public FsmString parameter;

		[Token(Token = "0x40044AC")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0014", Offset = "0x5C0014")]
		public bool everyFrame;

		[Token(Token = "0x40044AD")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C004C", Offset = "0x5C004C")]
		[Attribute(Name = "ActionSection", RVA = "0x5C004C", Offset = "0x5C004C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C004C", Offset = "0x5C004C")]
		[RequiredField]
		public FsmQuaternion result;

		[Token(Token = "0x40044AE")]
		[FieldOffset(Offset = "0x70")]
		private PlayMakerAnimatorMoveProxy _animatorProxy;

		[Token(Token = "0x40044AF")]
		[FieldOffset(Offset = "0x78")]
		private Animator _animator;

		[Token(Token = "0x40044B0")]
		[FieldOffset(Offset = "0x80")]
		private int _paramID;

		[Token(Token = "0x6005A53")]
		[Address(RVA = "0x105BD78", Offset = "0x105BD78", VA = "0x105BD78", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005A54")]
		[Address(RVA = "0x105BD88", Offset = "0x105BD88", VA = "0x105BD88", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005A55")]
		[Address(RVA = "0x105C008", Offset = "0x105C008", VA = "0x105C008")]
		public void OnAnimatorMoveEvent()
		{
		}

		[Token(Token = "0x6005A56")]
		[Address(RVA = "0x105C08C", Offset = "0x105C08C", VA = "0x105C08C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005A57")]
		[Address(RVA = "0x105BF6C", Offset = "0x105BF6C", VA = "0x105BF6C")]
		private void GetParameter()
		{
		}

		[Token(Token = "0x6005A58")]
		[Address(RVA = "0x105C110", Offset = "0x105C110", VA = "0x105C110", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005A59")]
		[Address(RVA = "0x105C1F8", Offset = "0x105C1F8", VA = "0x105C1F8")]
		public GetAnimatorQuaternion()
		{
		}
	}
}
