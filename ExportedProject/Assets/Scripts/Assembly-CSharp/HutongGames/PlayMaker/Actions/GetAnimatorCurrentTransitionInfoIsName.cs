using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000ED7")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A200", Offset = "0x59A200")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A200", Offset = "0x59A200")]
	public class GetAnimatorCurrentTransitionInfoIsName : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x4004648")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5450", Offset = "0x5C5450")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C5450", Offset = "0x5C5450")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004649")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C54E4", Offset = "0x5C54E4")]
		public FsmInt layerIndex;

		[Token(Token = "0x400464A")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5530", Offset = "0x5C5530")]
		public FsmString name;

		[Token(Token = "0x400464B")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ActionSection", RVA = "0x5C5568", Offset = "0x5C5568")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C5568", Offset = "0x5C5568")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5568", Offset = "0x5C5568")]
		public FsmBool nameMatch;

		[Token(Token = "0x400464C")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C55DC", Offset = "0x5C55DC")]
		public FsmEvent nameMatchEvent;

		[Token(Token = "0x400464D")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5614", Offset = "0x5C5614")]
		public FsmEvent nameDoNotMatchEvent;

		[Token(Token = "0x17000C0C")]
		private Animator animator
		{
			[Token(Token = "0x6005B8B")]
			[Address(RVA = "0xDA2FFC", Offset = "0xDA2FFC", VA = "0xDA2FFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B8C")]
		[Address(RVA = "0xDA3004", Offset = "0xDA3004", VA = "0xDA3004", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B8D")]
		[Address(RVA = "0xDA3038", Offset = "0xDA3038", VA = "0xDA3038", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B8E")]
		[Address(RVA = "0xDA3194", Offset = "0xDA3194", VA = "0xDA3194", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005B8F")]
		[Address(RVA = "0xDA3074", Offset = "0xDA3074", VA = "0xDA3074")]
		private void IsName()
		{
		}

		[Token(Token = "0x6005B90")]
		[Address(RVA = "0xDA3198", Offset = "0xDA3198", VA = "0xDA3198")]
		public GetAnimatorCurrentTransitionInfoIsName()
		{
		}
	}
}
