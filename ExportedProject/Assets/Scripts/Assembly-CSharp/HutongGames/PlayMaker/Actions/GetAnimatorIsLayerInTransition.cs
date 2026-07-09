using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EE1")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A520", Offset = "0x59A520")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A520", Offset = "0x59A520")]
	public class GetAnimatorIsLayerInTransition : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x4004675")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C636C", Offset = "0x5C636C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C636C", Offset = "0x5C636C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004676")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6400", Offset = "0x5C6400")]
		[RequiredField]
		public FsmInt layerIndex;

		[Token(Token = "0x4004677")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ActionSection", RVA = "0x5C644C", Offset = "0x5C644C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C644C", Offset = "0x5C644C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C644C", Offset = "0x5C644C")]
		public FsmBool isInTransition;

		[Token(Token = "0x4004678")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C64C0", Offset = "0x5C64C0")]
		public FsmEvent isInTransitionEvent;

		[Token(Token = "0x4004679")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C64F8", Offset = "0x5C64F8")]
		public FsmEvent isNotInTransitionEvent;

		[Token(Token = "0x17000C13")]
		private Animator animator
		{
			[Token(Token = "0x6005BBE")]
			[Address(RVA = "0xDA3F2C", Offset = "0xDA3F2C", VA = "0xDA3F2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005BBF")]
		[Address(RVA = "0xDA3F34", Offset = "0xDA3F34", VA = "0xDA3F34", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BC0")]
		[Address(RVA = "0xDA3F64", Offset = "0xDA3F64", VA = "0xDA3F64", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BC1")]
		[Address(RVA = "0xDA4098", Offset = "0xDA4098", VA = "0xDA4098", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005BC2")]
		[Address(RVA = "0xDA3FA0", Offset = "0xDA3FA0", VA = "0xDA3FA0")]
		private void DoCheckIsInTransition()
		{
		}

		[Token(Token = "0x6005BC3")]
		[Address(RVA = "0xDA409C", Offset = "0xDA409C", VA = "0xDA409C")]
		public GetAnimatorIsLayerInTransition()
		{
		}
	}
}
