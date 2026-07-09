using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001299")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD8A4", Offset = "0x5AD8A4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD8A4", Offset = "0x5AD8A4")]
	public class VideoPlayerGetIsLooping : FsmStateAction
	{
		[Token(Token = "0x4005913")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DC50", Offset = "0x60DC50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60DC50", Offset = "0x60DC50")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005914")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DCE4", Offset = "0x60DCE4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60DCE4", Offset = "0x60DCE4")]
		public FsmBool isLooping;

		[Token(Token = "0x4005915")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DD34", Offset = "0x60DD34")]
		public FsmEvent isLoopingEvent;

		[Token(Token = "0x4005916")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DD6C", Offset = "0x60DD6C")]
		public FsmEvent isNotLoopingEvent;

		[Token(Token = "0x4005917")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DDA4", Offset = "0x60DDA4")]
		public bool everyframe;

		[Token(Token = "0x4005918")]
		[FieldOffset(Offset = "0x78")]
		private GameObject go;

		[Token(Token = "0x4005919")]
		[FieldOffset(Offset = "0x80")]
		private VideoPlayer _vp;

		[Token(Token = "0x400591A")]
		[FieldOffset(Offset = "0x88")]
		private int _isLooping;

		[Token(Token = "0x6006C92")]
		[Address(RVA = "0x13CD388", Offset = "0x13CD388", VA = "0x13CD388", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C93")]
		[Address(RVA = "0x13CD394", Offset = "0x13CD394", VA = "0x13CD394", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C94")]
		[Address(RVA = "0x13CD558", Offset = "0x13CD558", VA = "0x13CD558", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C95")]
		[Address(RVA = "0x13CD470", Offset = "0x13CD470", VA = "0x13CD470")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C96")]
		[Address(RVA = "0x13CD3B8", Offset = "0x13CD3B8", VA = "0x13CD3B8")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C97")]
		[Address(RVA = "0x13CD55C", Offset = "0x13CD55C", VA = "0x13CD55C")]
		public VideoPlayerGetIsLooping()
		{
		}
	}
}
