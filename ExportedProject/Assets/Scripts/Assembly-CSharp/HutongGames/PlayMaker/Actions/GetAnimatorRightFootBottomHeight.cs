using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EED")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A8E0", Offset = "0x59A8E0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A8E0", Offset = "0x59A8E0")]
	public class GetAnimatorRightFootBottomHeight : ComponentAction<Animator>
	{
		[Token(Token = "0x40046A7")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7708", Offset = "0x5C7708")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C7708", Offset = "0x5C7708")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046A8")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C779C", Offset = "0x5C779C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C779C", Offset = "0x5C779C")]
		[Attribute(Name = "ActionSection", RVA = "0x5C779C", Offset = "0x5C779C")]
		[RequiredField]
		public FsmFloat rightFootHeight;

		[Token(Token = "0x40046A9")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7820", Offset = "0x5C7820")]
		public bool everyFrame;

		[Token(Token = "0x6005BF8")]
		[Address(RVA = "0x105C200", Offset = "0x105C200", VA = "0x105C200", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BF9")]
		[Address(RVA = "0x105C22C", Offset = "0x105C22C", VA = "0x105C22C", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6005BFA")]
		[Address(RVA = "0x105C24C", Offset = "0x105C24C", VA = "0x105C24C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BFB")]
		[Address(RVA = "0x105C314", Offset = "0x105C314", VA = "0x105C314", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6005BFC")]
		[Address(RVA = "0x105C288", Offset = "0x105C288", VA = "0x105C288")]
		private void GetRightFootBottomHeight()
		{
		}

		[Token(Token = "0x6005BFD")]
		[Address(RVA = "0x105C318", Offset = "0x105C318", VA = "0x105C318")]
		public GetAnimatorRightFootBottomHeight()
		{
		}
	}
}
