using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F33")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59BFE8", Offset = "0x59BFE8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59BFE8", Offset = "0x59BFE8")]
	public class SetAudioVolume : ComponentAction<AudioSource>
	{
		[Token(Token = "0x40047BB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC36C", Offset = "0x5CC36C")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CC36C", Offset = "0x5CC36C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40047BC")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC400", Offset = "0x5CC400")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5CC400", Offset = "0x5CC400")]
		public FsmFloat volume;

		[Token(Token = "0x40047BD")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC454", Offset = "0x5CC454")]
		public bool everyFrame;

		[Token(Token = "0x6005D20")]
		[Address(RVA = "0x1038110", Offset = "0x1038110", VA = "0x1038110", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D21")]
		[Address(RVA = "0x1038144", Offset = "0x1038144", VA = "0x1038144", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D22")]
		[Address(RVA = "0x1038254", Offset = "0x1038254", VA = "0x1038254", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D23")]
		[Address(RVA = "0x1038180", Offset = "0x1038180", VA = "0x1038180")]
		private void DoSetAudioVolume()
		{
		}

		[Token(Token = "0x6005D24")]
		[Address(RVA = "0x1038258", Offset = "0x1038258", VA = "0x1038258")]
		public SetAudioVolume()
		{
		}
	}
}
