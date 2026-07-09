using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012A5")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADC64", Offset = "0x5ADC64")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADC64", Offset = "0x5ADC64")]
	public class VideoPlayerGetTargetTexture : FsmStateAction
	{
		[Token(Token = "0x4005961")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60ED30", Offset = "0x60ED30")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60ED30", Offset = "0x60ED30")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005962")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60EDC4", Offset = "0x60EDC4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60EDC4", Offset = "0x60EDC4")]
		[RequiredField]
		public FsmTexture targetTexture;

		[Token(Token = "0x4005963")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60EE24", Offset = "0x60EE24")]
		public bool everyFrame;

		[Token(Token = "0x4005964")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x4005965")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006CDA")]
		[Address(RVA = "0x13CEA10", Offset = "0x13CEA10", VA = "0x13CEA10", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CDB")]
		[Address(RVA = "0x13CEA1C", Offset = "0x13CEA1C", VA = "0x13CEA1C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CDC")]
		[Address(RVA = "0x13CEBC0", Offset = "0x13CEBC0", VA = "0x13CEBC0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CDD")]
		[Address(RVA = "0x13CEB18", Offset = "0x13CEB18", VA = "0x13CEB18")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CDE")]
		[Address(RVA = "0x13CEA60", Offset = "0x13CEA60", VA = "0x13CEA60")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CDF")]
		[Address(RVA = "0x13CEBC4", Offset = "0x13CEBC4", VA = "0x13CEBC4")]
		public VideoPlayerGetTargetTexture()
		{
		}
	}
}
