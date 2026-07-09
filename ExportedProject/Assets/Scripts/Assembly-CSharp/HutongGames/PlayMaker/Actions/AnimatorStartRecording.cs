using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EC9")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599E40", Offset = "0x599E40")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599E40", Offset = "0x599E40")]
	public class AnimatorStartRecording : ComponentAction<Animator>
	{
		[Token(Token = "0x4004607")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3F34", Offset = "0x5C3F34")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C3F34", Offset = "0x5C3F34")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004608")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3FC8", Offset = "0x5C3FC8")]
		public FsmInt frameCount;

		[Token(Token = "0x6005B4D")]
		[Address(RVA = "0xD47AF4", Offset = "0xD47AF4", VA = "0xD47AF4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B4E")]
		[Address(RVA = "0xD47B24", Offset = "0xD47B24", VA = "0xD47B24", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B4F")]
		[Address(RVA = "0xD47BC4", Offset = "0xD47BC4", VA = "0xD47BC4")]
		public AnimatorStartRecording()
		{
		}
	}
}
