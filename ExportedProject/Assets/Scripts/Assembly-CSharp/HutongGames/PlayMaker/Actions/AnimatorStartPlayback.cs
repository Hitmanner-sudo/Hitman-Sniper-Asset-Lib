using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EC8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599DF0", Offset = "0x599DF0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599DF0", Offset = "0x599DF0")]
	public class AnimatorStartPlayback : ComponentAction<Animator>
	{
		[Token(Token = "0x4004606")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3EA0", Offset = "0x5C3EA0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C3EA0", Offset = "0x5C3EA0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x6005B4A")]
		[Address(RVA = "0xD47A18", Offset = "0xD47A18", VA = "0xD47A18", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B4B")]
		[Address(RVA = "0xD47A20", Offset = "0xD47A20", VA = "0xD47A20", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B4C")]
		[Address(RVA = "0xD47AA8", Offset = "0xD47AA8", VA = "0xD47AA8")]
		public AnimatorStartPlayback()
		{
		}
	}
}
