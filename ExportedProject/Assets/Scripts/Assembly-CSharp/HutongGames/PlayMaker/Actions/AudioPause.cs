using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F2A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59BCA4", Offset = "0x59BCA4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59BCA4", Offset = "0x59BCA4")]
	public class AudioPause : ComponentAction<AudioSource>
	{
		[Token(Token = "0x4004798")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB9A4", Offset = "0x5CB9A4")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CB9A4", Offset = "0x5CB9A4")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x6005CFC")]
		[Address(RVA = "0xC09B40", Offset = "0xC09B40", VA = "0xC09B40", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CFD")]
		[Address(RVA = "0xC09B48", Offset = "0xC09B48", VA = "0xC09B48", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CFE")]
		[Address(RVA = "0xC09BEC", Offset = "0xC09BEC", VA = "0xC09BEC")]
		public AudioPause()
		{
		}
	}
}
