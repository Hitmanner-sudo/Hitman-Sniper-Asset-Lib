using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EA0")]
	[Attribute(Name = "HelpUrlAttribute", RVA = "0x59931C", Offset = "0x59931C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59931C", Offset = "0x59931C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59931C", Offset = "0x59931C")]
	public class AnimatorFollow : FsmStateAction
	{
		[Token(Token = "0x40044C6")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C04D0", Offset = "0x5C04D0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C04D0", Offset = "0x5C04D0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40044C7")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0564", Offset = "0x5C0564")]
		public FsmGameObject target;

		[Token(Token = "0x40044C8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C05B0", Offset = "0x5C05B0")]
		public FsmFloat speed;

		[Token(Token = "0x40044C9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C05E8", Offset = "0x5C05E8")]
		public FsmFloat minimumDistance;

		[Token(Token = "0x40044CA")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0620", Offset = "0x5C0620")]
		public FsmFloat speedDampTime;

		[Token(Token = "0x40044CB")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0658", Offset = "0x5C0658")]
		public FsmFloat directionDampTime;

		[Token(Token = "0x40044CC")]
		[FieldOffset(Offset = "0x80")]
		private GameObject _go;

		[Token(Token = "0x40044CD")]
		[FieldOffset(Offset = "0x88")]
		private PlayMakerAnimatorMoveProxy _animatorProxy;

		[Token(Token = "0x40044CE")]
		[FieldOffset(Offset = "0x90")]
		private Animator avatar;

		[Token(Token = "0x40044CF")]
		[FieldOffset(Offset = "0x98")]
		private CharacterController controller;

		[Token(Token = "0x6005A6F")]
		[Address(RVA = "0xD46870", Offset = "0xD46870", VA = "0xD46870", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005A70")]
		[Address(RVA = "0xD468E0", Offset = "0xD468E0", VA = "0xD468E0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005A71")]
		[Address(RVA = "0xD46A98", Offset = "0xD46A98", VA = "0xD46A98", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005A72")]
		[Address(RVA = "0xD46EC4", Offset = "0xD46EC4", VA = "0xD46EC4", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005A73")]
		[Address(RVA = "0xD46E4C", Offset = "0xD46E4C", VA = "0xD46E4C")]
		public void OnAnimatorMoveEvent()
		{
		}

		[Token(Token = "0x6005A74")]
		[Address(RVA = "0xD46FAC", Offset = "0xD46FAC", VA = "0xD46FAC")]
		public AnimatorFollow()
		{
		}
	}
}
