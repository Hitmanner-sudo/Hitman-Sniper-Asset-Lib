using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EE8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A750", Offset = "0x59A750")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A750", Offset = "0x59A750")]
	public class GetAnimatorLeftFootBottomHeight : ComponentAction<Animator>
	{
		[Token(Token = "0x400468F")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C6DC0", Offset = "0x5C6DC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6DC0", Offset = "0x5C6DC0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004690")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ActionSection", RVA = "0x5C6E54", Offset = "0x5C6E54")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C6E54", Offset = "0x5C6E54")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6E54", Offset = "0x5C6E54")]
		public FsmFloat leftFootHeight;

		[Token(Token = "0x4004691")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6ED8", Offset = "0x5C6ED8")]
		public bool everyFrame;

		[Token(Token = "0x6005BDC")]
		[Address(RVA = "0x105B4D8", Offset = "0x105B4D8", VA = "0x105B4D8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BDD")]
		[Address(RVA = "0x105B4E4", Offset = "0x105B4E4", VA = "0x105B4E4", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6005BDE")]
		[Address(RVA = "0x105B504", Offset = "0x105B504", VA = "0x105B504", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BDF")]
		[Address(RVA = "0x105B5CC", Offset = "0x105B5CC", VA = "0x105B5CC", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6005BE0")]
		[Address(RVA = "0x105B540", Offset = "0x105B540", VA = "0x105B540")]
		private void GetLeftFootBottomHeight()
		{
		}

		[Token(Token = "0x6005BE1")]
		[Address(RVA = "0x105B5D0", Offset = "0x105B5D0", VA = "0x105B5D0")]
		public GetAnimatorLeftFootBottomHeight()
		{
		}
	}
}
