using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012AC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADE94", Offset = "0x5ADE94")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADE94", Offset = "0x5ADE94")]
	public class VideoPlayerLoopPointReachedEvent : FsmStateAction
	{
		[Token(Token = "0x4005987")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60F60C", Offset = "0x60F60C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F60C", Offset = "0x60F60C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005988")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F6A0", Offset = "0x60F6A0")]
		public FsmEvent OnLoopPointReachedEvent;

		[Token(Token = "0x4005989")]
		[FieldOffset(Offset = "0x60")]
		private GameObject go;

		[Token(Token = "0x400598A")]
		[FieldOffset(Offset = "0x68")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D04")]
		[Address(RVA = "0x13CF670", Offset = "0x13CF670", VA = "0x13CF670", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D05")]
		[Address(RVA = "0x13CF678", Offset = "0x13CF678", VA = "0x13CF678", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D06")]
		[Address(RVA = "0x13CF820", Offset = "0x13CF820", VA = "0x13CF820", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006D07")]
		[Address(RVA = "0x13CF908", Offset = "0x13CF908", VA = "0x13CF908")]
		private void OnLoopPointReached(VideoPlayer source)
		{
		}

		[Token(Token = "0x6006D08")]
		[Address(RVA = "0x13CF768", Offset = "0x13CF768", VA = "0x13CF768")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D09")]
		[Address(RVA = "0x13CF9A8", Offset = "0x13CF9A8", VA = "0x13CF9A8")]
		public VideoPlayerLoopPointReachedEvent()
		{
		}
	}
}
