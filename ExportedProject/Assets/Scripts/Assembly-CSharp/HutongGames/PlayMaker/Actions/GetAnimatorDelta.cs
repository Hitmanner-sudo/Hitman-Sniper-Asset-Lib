using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000ED9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A2A0", Offset = "0x59A2A0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A2A0", Offset = "0x59A2A0")]
	public class GetAnimatorDelta : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x4004654")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C5848", Offset = "0x5C5848")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5848", Offset = "0x5C5848")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004655")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C58DC", Offset = "0x5C58DC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C58DC", Offset = "0x5C58DC")]
		public FsmVector3 deltaPosition;

		[Token(Token = "0x4004656")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C592C", Offset = "0x5C592C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C592C", Offset = "0x5C592C")]
		public FsmQuaternion deltaRotation;

		[Token(Token = "0x17000C0E")]
		private Animator animator
		{
			[Token(Token = "0x6005B97")]
			[Address(RVA = "0xDA3358", Offset = "0xDA3358", VA = "0xDA3358")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B98")]
		[Address(RVA = "0xDA3360", Offset = "0xDA3360", VA = "0xDA3360", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B99")]
		[Address(RVA = "0xDA338C", Offset = "0xDA338C", VA = "0xDA338C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B9A")]
		[Address(RVA = "0xDA348C", Offset = "0xDA348C", VA = "0xDA348C", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005B9B")]
		[Address(RVA = "0xDA33C8", Offset = "0xDA33C8", VA = "0xDA33C8")]
		private void DoGetDeltaPosition()
		{
		}

		[Token(Token = "0x6005B9C")]
		[Address(RVA = "0xDA3490", Offset = "0xDA3490", VA = "0xDA3490")]
		public GetAnimatorDelta()
		{
		}
	}
}
