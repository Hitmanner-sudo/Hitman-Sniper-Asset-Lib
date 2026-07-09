using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F30")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59BEF8", Offset = "0x59BEF8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59BEF8", Offset = "0x59BEF8")]
	public class SetAudioClip : ComponentAction<AudioSource>
	{
		[Token(Token = "0x40047B4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CC084", Offset = "0x5CC084")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC084", Offset = "0x5CC084")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40047B5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC118", Offset = "0x5CC118")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5CC118", Offset = "0x5CC118")]
		public FsmObject audioClip;

		[Token(Token = "0x6005D15")]
		[Address(RVA = "0x1037CF8", Offset = "0x1037CF8", VA = "0x1037CF8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D16")]
		[Address(RVA = "0x1037D00", Offset = "0x1037D00", VA = "0x1037D00", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D17")]
		[Address(RVA = "0x1037DF0", Offset = "0x1037DF0", VA = "0x1037DF0")]
		public SetAudioClip()
		{
		}
	}
}
