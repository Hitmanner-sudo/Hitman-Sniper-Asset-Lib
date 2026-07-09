using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012AB")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADE44", Offset = "0x5ADE44")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADE44", Offset = "0x5ADE44")]
	public class VideoPlayerGetWaitForFirstFrame : FsmStateAction
	{
		[Token(Token = "0x400597F")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60F480", Offset = "0x60F480")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F480", Offset = "0x60F480")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005980")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F514", Offset = "0x60F514")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60F514", Offset = "0x60F514")]
		public FsmBool isWaitingForFirstFrame;

		[Token(Token = "0x4005981")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F564", Offset = "0x60F564")]
		public FsmEvent isWaitingForFirstFrameEvent;

		[Token(Token = "0x4005982")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F59C", Offset = "0x60F59C")]
		public FsmEvent isNotWaitingForFirstFrameEvent;

		[Token(Token = "0x4005983")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F5D4", Offset = "0x60F5D4")]
		public bool everyframe;

		[Token(Token = "0x4005984")]
		[FieldOffset(Offset = "0x78")]
		private GameObject go;

		[Token(Token = "0x4005985")]
		[FieldOffset(Offset = "0x80")]
		private VideoPlayer _vp;

		[Token(Token = "0x4005986")]
		[FieldOffset(Offset = "0x88")]
		private int _isWaitingForFirstFrame;

		[Token(Token = "0x6006CFE")]
		[Address(RVA = "0x13CF468", Offset = "0x13CF468", VA = "0x13CF468", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CFF")]
		[Address(RVA = "0x13CF478", Offset = "0x13CF478", VA = "0x13CF478", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D00")]
		[Address(RVA = "0x13CF65C", Offset = "0x13CF65C", VA = "0x13CF65C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006D01")]
		[Address(RVA = "0x13CF574", Offset = "0x13CF574", VA = "0x13CF574")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D02")]
		[Address(RVA = "0x13CF4BC", Offset = "0x13CF4BC", VA = "0x13CF4BC")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D03")]
		[Address(RVA = "0x13CF660", Offset = "0x13CF660", VA = "0x13CF660")]
		public VideoPlayerGetWaitForFirstFrame()
		{
		}
	}
}
