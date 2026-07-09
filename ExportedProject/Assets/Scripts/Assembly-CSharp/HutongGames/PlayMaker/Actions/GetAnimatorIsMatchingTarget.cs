using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EE2")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A570", Offset = "0x59A570")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A570", Offset = "0x59A570")]
	public class GetAnimatorIsMatchingTarget : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x400467A")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6530", Offset = "0x5C6530")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C6530", Offset = "0x5C6530")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400467B")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C65C4", Offset = "0x5C65C4")]
		[Attribute(Name = "ActionSection", RVA = "0x5C65C4", Offset = "0x5C65C4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C65C4", Offset = "0x5C65C4")]
		public FsmBool isMatchingActive;

		[Token(Token = "0x400467C")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6638", Offset = "0x5C6638")]
		public FsmEvent matchingActivatedEvent;

		[Token(Token = "0x400467D")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6670", Offset = "0x5C6670")]
		public FsmEvent matchingDeactivedEvent;

		[Token(Token = "0x17000C14")]
		private Animator animator
		{
			[Token(Token = "0x6005BC4")]
			[Address(RVA = "0x105AE14", Offset = "0x105AE14", VA = "0x105AE14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005BC5")]
		[Address(RVA = "0x105AE1C", Offset = "0x105AE1C", VA = "0x105AE1C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BC6")]
		[Address(RVA = "0x105AE4C", Offset = "0x105AE4C", VA = "0x105AE4C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BC7")]
		[Address(RVA = "0x105AF50", Offset = "0x105AF50", VA = "0x105AF50", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005BC8")]
		[Address(RVA = "0x105AE88", Offset = "0x105AE88", VA = "0x105AE88")]
		private void DoCheckIsMatchingActive()
		{
		}

		[Token(Token = "0x6005BC9")]
		[Address(RVA = "0x105AF54", Offset = "0x105AF54", VA = "0x105AF54")]
		public GetAnimatorIsMatchingTarget()
		{
		}
	}
}
