using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F31")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59BF48", Offset = "0x59BF48")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59BF48", Offset = "0x59BF48")]
	public class SetAudioLoop : ComponentAction<AudioSource>
	{
		[Token(Token = "0x40047B6")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC19C", Offset = "0x5CC19C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CC19C", Offset = "0x5CC19C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40047B7")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC230", Offset = "0x5CC230")]
		public FsmBool loop;

		[Token(Token = "0x6005D18")]
		[Address(RVA = "0x1037E3C", Offset = "0x1037E3C", VA = "0x1037E3C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D19")]
		[Address(RVA = "0x1037E6C", Offset = "0x1037E6C", VA = "0x1037E6C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D1A")]
		[Address(RVA = "0x1037F30", Offset = "0x1037F30", VA = "0x1037F30")]
		public SetAudioLoop()
		{
		}
	}
}
