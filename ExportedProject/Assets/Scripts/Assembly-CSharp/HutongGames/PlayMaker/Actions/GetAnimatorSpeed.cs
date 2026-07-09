using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EEF")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A980", Offset = "0x59A980")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A980", Offset = "0x59A980")]
	public class GetAnimatorSpeed : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x40046B0")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C79E8", Offset = "0x5C79E8")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C79E8", Offset = "0x5C79E8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046B1")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C7A7C", Offset = "0x5C7A7C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7A7C", Offset = "0x5C7A7C")]
		public FsmFloat speed;

		[Token(Token = "0x17000C19")]
		private Animator animator
		{
			[Token(Token = "0x6005C04")]
			[Address(RVA = "0x105C5F4", Offset = "0x105C5F4", VA = "0x105C5F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005C05")]
		[Address(RVA = "0x105C5FC", Offset = "0x105C5FC", VA = "0x105C5FC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C06")]
		[Address(RVA = "0x105C628", Offset = "0x105C628", VA = "0x105C628", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C07")]
		[Address(RVA = "0x105C704", Offset = "0x105C704", VA = "0x105C704", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005C08")]
		[Address(RVA = "0x105C664", Offset = "0x105C664", VA = "0x105C664")]
		private void GetPlaybackSpeed()
		{
		}

		[Token(Token = "0x6005C09")]
		[Address(RVA = "0x105C708", Offset = "0x105C708", VA = "0x105C708")]
		public GetAnimatorSpeed()
		{
		}
	}
}
