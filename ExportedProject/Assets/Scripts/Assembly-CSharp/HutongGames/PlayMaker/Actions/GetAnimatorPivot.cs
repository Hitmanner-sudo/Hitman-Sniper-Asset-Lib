using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EEA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A7F0", Offset = "0x59A7F0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A7F0", Offset = "0x59A7F0")]
	public class GetAnimatorPivot : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x400469E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C7334", Offset = "0x5C7334")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7334", Offset = "0x5C7334")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400469F")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ActionSection", RVA = "0x5C73C8", Offset = "0x5C73C8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C73C8", Offset = "0x5C73C8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C73C8", Offset = "0x5C73C8")]
		public FsmFloat pivotWeight;

		[Token(Token = "0x40046A0")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C743C", Offset = "0x5C743C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C743C", Offset = "0x5C743C")]
		public FsmVector3 pivotPosition;

		[Token(Token = "0x17000C17")]
		private Animator animator
		{
			[Token(Token = "0x6005BE8")]
			[Address(RVA = "0x105B9CC", Offset = "0x105B9CC", VA = "0x105B9CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005BE9")]
		[Address(RVA = "0x105B9D4", Offset = "0x105B9D4", VA = "0x105B9D4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BEA")]
		[Address(RVA = "0x105BA00", Offset = "0x105BA00", VA = "0x105BA00", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BEB")]
		[Address(RVA = "0x105BB24", Offset = "0x105BB24", VA = "0x105BB24", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005BEC")]
		[Address(RVA = "0x105BA3C", Offset = "0x105BA3C", VA = "0x105BA3C")]
		private void DoCheckPivot()
		{
		}

		[Token(Token = "0x6005BED")]
		[Address(RVA = "0x105BB28", Offset = "0x105BB28", VA = "0x105BB28")]
		public GetAnimatorPivot()
		{
		}
	}
}
