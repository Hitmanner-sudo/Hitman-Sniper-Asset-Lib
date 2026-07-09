using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200128B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD444", Offset = "0x5AD444")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD444", Offset = "0x5AD444")]
	public class VideoPlayerFrameReadyEvent : FsmStateAction
	{
		[Token(Token = "0x40058C3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60C9D4", Offset = "0x60C9D4")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C9D4", Offset = "0x60C9D4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40058C4")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60CA68", Offset = "0x60CA68")]
		public FsmEvent onFrameReadyEvent;

		[Token(Token = "0x40058C5")]
		[FieldOffset(Offset = "0x60")]
		private GameObject go;

		[Token(Token = "0x40058C6")]
		[FieldOffset(Offset = "0x68")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006C3F")]
		[Address(RVA = "0x13CB934", Offset = "0x13CB934", VA = "0x13CB934", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C40")]
		[Address(RVA = "0x13CB93C", Offset = "0x13CB93C", VA = "0x13CB93C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C41")]
		[Address(RVA = "0x13CBAE4", Offset = "0x13CBAE4", VA = "0x13CBAE4", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006C42")]
		[Address(RVA = "0x13CBBCC", Offset = "0x13CBBCC", VA = "0x13CBBCC")]
		private void OnFrameReady(VideoPlayer source, long frameIndex)
		{
		}

		[Token(Token = "0x6006C43")]
		[Address(RVA = "0x13CBA2C", Offset = "0x13CBA2C", VA = "0x13CBA2C")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C44")]
		[Address(RVA = "0x13CBC8C", Offset = "0x13CBC8C", VA = "0x13CBC8C")]
		public VideoPlayerFrameReadyEvent()
		{
		}
	}
}
