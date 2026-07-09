using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000ED4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A110", Offset = "0x59A110")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A110", Offset = "0x59A110")]
	public class GetAnimatorCurrentStateInfoIsName : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x4004636")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C4E14", Offset = "0x5C4E14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4E14", Offset = "0x5C4E14")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004637")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4EA8", Offset = "0x5C4EA8")]
		public FsmInt layerIndex;

		[Token(Token = "0x4004638")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4EF4", Offset = "0x5C4EF4")]
		public FsmString name;

		[Token(Token = "0x4004639")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4F2C", Offset = "0x5C4F2C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C4F2C", Offset = "0x5C4F2C")]
		[Attribute(Name = "ActionSection", RVA = "0x5C4F2C", Offset = "0x5C4F2C")]
		public FsmBool isMatching;

		[Token(Token = "0x400463A")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4FA0", Offset = "0x5C4FA0")]
		public FsmEvent nameMatchEvent;

		[Token(Token = "0x400463B")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4FD8", Offset = "0x5C4FD8")]
		public FsmEvent nameDoNotMatchEvent;

		[Token(Token = "0x17000C09")]
		private Animator animator
		{
			[Token(Token = "0x6005B79")]
			[Address(RVA = "0xDA2A48", Offset = "0xDA2A48", VA = "0xDA2A48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B7A")]
		[Address(RVA = "0xDA2A50", Offset = "0xDA2A50", VA = "0xDA2A50", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B7B")]
		[Address(RVA = "0xDA2A84", Offset = "0xDA2A84", VA = "0xDA2A84", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B7C")]
		[Address(RVA = "0xDA2C20", Offset = "0xDA2C20", VA = "0xDA2C20", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005B7D")]
		[Address(RVA = "0xDA2AC0", Offset = "0xDA2AC0", VA = "0xDA2AC0")]
		private void IsName()
		{
		}

		[Token(Token = "0x6005B7E")]
		[Address(RVA = "0xDA2C24", Offset = "0xDA2C24", VA = "0xDA2C24")]
		public GetAnimatorCurrentStateInfoIsName()
		{
		}
	}
}
