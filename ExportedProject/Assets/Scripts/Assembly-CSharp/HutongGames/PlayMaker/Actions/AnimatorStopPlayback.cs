using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000ECA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599E90", Offset = "0x599E90")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599E90", Offset = "0x599E90")]
	public class AnimatorStopPlayback : ComponentAction<Animator>
	{
		[Token(Token = "0x4004609")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C4014", Offset = "0x5C4014")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C4014", Offset = "0x5C4014")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x6005B50")]
		[Address(RVA = "0xD47C10", Offset = "0xD47C10", VA = "0xD47C10", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B51")]
		[Address(RVA = "0xD47C18", Offset = "0xD47C18", VA = "0xD47C18", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B52")]
		[Address(RVA = "0xD47CA0", Offset = "0xD47CA0", VA = "0xD47CA0")]
		public AnimatorStopPlayback()
		{
		}
	}
}
