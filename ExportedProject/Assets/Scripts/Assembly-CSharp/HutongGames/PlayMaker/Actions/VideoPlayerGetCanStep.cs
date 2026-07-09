using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001294")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD714", Offset = "0x5AD714")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD714", Offset = "0x5AD714")]
	public class VideoPlayerGetCanStep : FsmStateAction
	{
		[Token(Token = "0x40058FB")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60D6A8", Offset = "0x60D6A8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D6A8", Offset = "0x60D6A8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40058FC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D73C", Offset = "0x60D73C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60D73C", Offset = "0x60D73C")]
		public FsmBool canStep;

		[Token(Token = "0x40058FD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D78C", Offset = "0x60D78C")]
		public FsmEvent canStepEvent;

		[Token(Token = "0x40058FE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D7C4", Offset = "0x60D7C4")]
		public FsmEvent canNotStepEvent;

		[Token(Token = "0x40058FF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D7FC", Offset = "0x60D7FC")]
		public bool everyFrame;

		[Token(Token = "0x4005900")]
		[FieldOffset(Offset = "0x78")]
		private GameObject go;

		[Token(Token = "0x4005901")]
		[FieldOffset(Offset = "0x80")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006C75")]
		[Address(RVA = "0x13CCC18", Offset = "0x13CCC18", VA = "0x13CCC18", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C76")]
		[Address(RVA = "0x13CCC28", Offset = "0x13CCC28", VA = "0x13CCC28", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C77")]
		[Address(RVA = "0x13CCDFC", Offset = "0x13CCDFC", VA = "0x13CCDFC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C78")]
		[Address(RVA = "0x13CCD24", Offset = "0x13CCD24", VA = "0x13CCD24")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C79")]
		[Address(RVA = "0x13CCC6C", Offset = "0x13CCC6C", VA = "0x13CCC6C")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C7A")]
		[Address(RVA = "0x13CCE00", Offset = "0x13CCE00", VA = "0x13CCE00")]
		public VideoPlayerGetCanStep()
		{
		}
	}
}
