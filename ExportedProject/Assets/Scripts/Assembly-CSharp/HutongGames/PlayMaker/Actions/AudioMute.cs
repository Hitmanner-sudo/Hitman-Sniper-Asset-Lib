using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F29")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59BC54", Offset = "0x59BC54")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59BC54", Offset = "0x59BC54")]
	public class AudioMute : ComponentAction<AudioSource>
	{
		[Token(Token = "0x4004796")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CB8C4", Offset = "0x5CB8C4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB8C4", Offset = "0x5CB8C4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004797")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB958", Offset = "0x5CB958")]
		public FsmBool mute;

		[Token(Token = "0x6005CF9")]
		[Address(RVA = "0xC09A00", Offset = "0xC09A00", VA = "0xC09A00", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CFA")]
		[Address(RVA = "0xC09A30", Offset = "0xC09A30", VA = "0xC09A30", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CFB")]
		[Address(RVA = "0xC09AF4", Offset = "0xC09AF4", VA = "0xC09AF4")]
		public AudioMute()
		{
		}
	}
}
