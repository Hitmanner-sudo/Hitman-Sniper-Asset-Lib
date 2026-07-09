using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EC5")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599D00", Offset = "0x599D00")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599D00", Offset = "0x599D00")]
	public class AnimatorInterruptMatchTarget : ComponentAction<Animator>
	{
		[Token(Token = "0x40045F2")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C39D4", Offset = "0x5C39D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C39D4", Offset = "0x5C39D4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045F3")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3A68", Offset = "0x5C3A68")]
		public FsmBool completeMatch;

		[Token(Token = "0x6005B3B")]
		[Address(RVA = "0xD47188", Offset = "0xD47188", VA = "0xD47188", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B3C")]
		[Address(RVA = "0xD471B8", Offset = "0xD471B8", VA = "0xD471B8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B3D")]
		[Address(RVA = "0xD47258", Offset = "0xD47258", VA = "0xD47258")]
		public AnimatorInterruptMatchTarget()
		{
		}
	}
}
