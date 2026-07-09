using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000ED6")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A1B0", Offset = "0x59A1B0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A1B0", Offset = "0x59A1B0")]
	public class GetAnimatorCurrentTransitionInfo : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x4004642")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C520C", Offset = "0x5C520C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C520C", Offset = "0x5C520C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004643")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C52A0", Offset = "0x5C52A0")]
		public FsmInt layerIndex;

		[Token(Token = "0x4004644")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C52EC", Offset = "0x5C52EC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C52EC", Offset = "0x5C52EC")]
		[Attribute(Name = "ActionSection", RVA = "0x5C52EC", Offset = "0x5C52EC")]
		public FsmString name;

		[Token(Token = "0x4004645")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C5360", Offset = "0x5C5360")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5360", Offset = "0x5C5360")]
		public FsmInt nameHash;

		[Token(Token = "0x4004646")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C53B0", Offset = "0x5C53B0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C53B0", Offset = "0x5C53B0")]
		public FsmInt userNameHash;

		[Token(Token = "0x4004647")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C5400", Offset = "0x5C5400")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5400", Offset = "0x5C5400")]
		public FsmFloat normalizedTime;

		[Token(Token = "0x17000C0B")]
		private Animator animator
		{
			[Token(Token = "0x6005B85")]
			[Address(RVA = "0xDA2DE0", Offset = "0xDA2DE0", VA = "0xDA2DE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B86")]
		[Address(RVA = "0xDA2DE8", Offset = "0xDA2DE8", VA = "0xDA2DE8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B87")]
		[Address(RVA = "0xDA2E1C", Offset = "0xDA2E1C", VA = "0xDA2E1C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B88")]
		[Address(RVA = "0xDA2FF0", Offset = "0xDA2FF0", VA = "0xDA2FF0", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005B89")]
		[Address(RVA = "0xDA2E58", Offset = "0xDA2E58", VA = "0xDA2E58")]
		private void GetTransitionInfo()
		{
		}

		[Token(Token = "0x6005B8A")]
		[Address(RVA = "0xDA2FF4", Offset = "0xDA2FF4", VA = "0xDA2FF4")]
		public GetAnimatorCurrentTransitionInfo()
		{
		}
	}
}
