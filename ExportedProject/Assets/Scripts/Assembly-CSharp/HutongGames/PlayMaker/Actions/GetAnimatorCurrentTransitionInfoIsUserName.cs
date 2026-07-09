using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000ED8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A250", Offset = "0x59A250")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A250", Offset = "0x59A250")]
	public class GetAnimatorCurrentTransitionInfoIsUserName : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x400464E")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C564C", Offset = "0x5C564C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C564C", Offset = "0x5C564C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400464F")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C56E0", Offset = "0x5C56E0")]
		public FsmInt layerIndex;

		[Token(Token = "0x4004650")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C572C", Offset = "0x5C572C")]
		public FsmString userName;

		[Token(Token = "0x4004651")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C5764", Offset = "0x5C5764")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5764", Offset = "0x5C5764")]
		[Attribute(Name = "ActionSection", RVA = "0x5C5764", Offset = "0x5C5764")]
		public FsmBool nameMatch;

		[Token(Token = "0x4004652")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C57D8", Offset = "0x5C57D8")]
		public FsmEvent nameMatchEvent;

		[Token(Token = "0x4004653")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5810", Offset = "0x5C5810")]
		public FsmEvent nameDoNotMatchEvent;

		[Token(Token = "0x17000C0D")]
		private Animator animator
		{
			[Token(Token = "0x6005B91")]
			[Address(RVA = "0xDA31A0", Offset = "0xDA31A0", VA = "0xDA31A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B92")]
		[Address(RVA = "0xDA31A8", Offset = "0xDA31A8", VA = "0xDA31A8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B93")]
		[Address(RVA = "0xDA31DC", Offset = "0xDA31DC", VA = "0xDA31DC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B94")]
		[Address(RVA = "0xDA334C", Offset = "0xDA334C", VA = "0xDA334C", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005B95")]
		[Address(RVA = "0xDA3218", Offset = "0xDA3218", VA = "0xDA3218")]
		private void IsName()
		{
		}

		[Token(Token = "0x6005B96")]
		[Address(RVA = "0xDA3350", Offset = "0xDA3350", VA = "0xDA3350")]
		public GetAnimatorCurrentTransitionInfoIsUserName()
		{
		}
	}
}
