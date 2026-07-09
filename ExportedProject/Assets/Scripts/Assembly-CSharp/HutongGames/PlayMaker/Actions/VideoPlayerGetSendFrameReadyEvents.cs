using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200129F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADA84", Offset = "0x5ADA84")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADA84", Offset = "0x5ADA84")]
	public class VideoPlayerGetSendFrameReadyEvents : FsmStateAction
	{
		[Token(Token = "0x400593D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E520", Offset = "0x60E520")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60E520", Offset = "0x60E520")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400593E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60E5B4", Offset = "0x60E5B4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E5B4", Offset = "0x60E5B4")]
		public FsmBool isSendingFrameReadyEvents;

		[Token(Token = "0x400593F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E604", Offset = "0x60E604")]
		public FsmEvent isSendingFrameReadyEventsEvent;

		[Token(Token = "0x4005940")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E63C", Offset = "0x60E63C")]
		public FsmEvent isNotSendingFrameReadyEventsEvent;

		[Token(Token = "0x4005941")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E674", Offset = "0x60E674")]
		public bool everyframe;

		[Token(Token = "0x4005942")]
		[FieldOffset(Offset = "0x78")]
		private GameObject go;

		[Token(Token = "0x4005943")]
		[FieldOffset(Offset = "0x80")]
		private VideoPlayer _vp;

		[Token(Token = "0x4005944")]
		[FieldOffset(Offset = "0x88")]
		private int _isSendingFrameReadyEvents;

		[Token(Token = "0x6006CB6")]
		[Address(RVA = "0x13CDEC8", Offset = "0x13CDEC8", VA = "0x13CDEC8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CB7")]
		[Address(RVA = "0x13CDED4", Offset = "0x13CDED4", VA = "0x13CDED4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CB8")]
		[Address(RVA = "0x13CE098", Offset = "0x13CE098", VA = "0x13CE098", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CB9")]
		[Address(RVA = "0x13CDFB0", Offset = "0x13CDFB0", VA = "0x13CDFB0")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CBA")]
		[Address(RVA = "0x13CDEF8", Offset = "0x13CDEF8", VA = "0x13CDEF8")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CBB")]
		[Address(RVA = "0x13CE09C", Offset = "0x13CE09C", VA = "0x13CE09C")]
		public VideoPlayerGetSendFrameReadyEvents()
		{
		}
	}
}
