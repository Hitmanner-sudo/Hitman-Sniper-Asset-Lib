using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F32")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59BF98", Offset = "0x59BF98")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59BF98", Offset = "0x59BF98")]
	public class SetAudioPitch : ComponentAction<AudioSource>
	{
		[Token(Token = "0x40047B8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC268", Offset = "0x5CC268")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CC268", Offset = "0x5CC268")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40047B9")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC2FC", Offset = "0x5CC2FC")]
		public FsmFloat pitch;

		[Token(Token = "0x40047BA")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC334", Offset = "0x5CC334")]
		public bool everyFrame;

		[Token(Token = "0x6005D1B")]
		[Address(RVA = "0x1037F7C", Offset = "0x1037F7C", VA = "0x1037F7C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D1C")]
		[Address(RVA = "0x1037FB0", Offset = "0x1037FB0", VA = "0x1037FB0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D1D")]
		[Address(RVA = "0x10380C0", Offset = "0x10380C0", VA = "0x10380C0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D1E")]
		[Address(RVA = "0x1037FEC", Offset = "0x1037FEC", VA = "0x1037FEC")]
		private void DoSetAudioPitch()
		{
		}

		[Token(Token = "0x6005D1F")]
		[Address(RVA = "0x10380C4", Offset = "0x10380C4", VA = "0x10380C4")]
		public SetAudioPitch()
		{
		}
	}
}
