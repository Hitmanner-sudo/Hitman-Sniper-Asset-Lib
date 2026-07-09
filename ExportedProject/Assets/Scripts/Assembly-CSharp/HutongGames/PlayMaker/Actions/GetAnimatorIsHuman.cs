using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EE0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A4D0", Offset = "0x59A4D0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A4D0", Offset = "0x59A4D0")]
	public class GetAnimatorIsHuman : ComponentAction<Animator>
	{
		[Token(Token = "0x4004671")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C61F4", Offset = "0x5C61F4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C61F4", Offset = "0x5C61F4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004672")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6288", Offset = "0x5C6288")]
		[Attribute(Name = "ActionSection", RVA = "0x5C6288", Offset = "0x5C6288")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C6288", Offset = "0x5C6288")]
		public FsmBool isHuman;

		[Token(Token = "0x4004673")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C62FC", Offset = "0x5C62FC")]
		public FsmEvent isHumanEvent;

		[Token(Token = "0x4004674")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6334", Offset = "0x5C6334")]
		public FsmEvent isGenericEvent;

		[Token(Token = "0x6005BBB")]
		[Address(RVA = "0xDA3DF8", Offset = "0xDA3DF8", VA = "0xDA3DF8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BBC")]
		[Address(RVA = "0xDA3E08", Offset = "0xDA3E08", VA = "0xDA3E08", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BBD")]
		[Address(RVA = "0xDA3EE0", Offset = "0xDA3EE0", VA = "0xDA3EE0")]
		public GetAnimatorIsHuman()
		{
		}
	}
}
