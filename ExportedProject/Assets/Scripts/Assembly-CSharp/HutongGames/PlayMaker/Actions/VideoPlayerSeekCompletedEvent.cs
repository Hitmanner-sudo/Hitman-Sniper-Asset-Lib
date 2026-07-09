using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012B1")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE024", Offset = "0x5AE024")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE024", Offset = "0x5AE024")]
	public class VideoPlayerSeekCompletedEvent : FsmStateAction
	{
		[Token(Token = "0x4005998")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60F960", Offset = "0x60F960")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F960", Offset = "0x60F960")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005999")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F9F4", Offset = "0x60F9F4")]
		public FsmEvent OnSeekCompletedEvent;

		[Token(Token = "0x400599A")]
		[FieldOffset(Offset = "0x60")]
		private GameObject go;

		[Token(Token = "0x400599B")]
		[FieldOffset(Offset = "0x68")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D1C")]
		[Address(RVA = "0x13D0110", Offset = "0x13D0110", VA = "0x13D0110", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D1D")]
		[Address(RVA = "0x13D0118", Offset = "0x13D0118", VA = "0x13D0118", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D1E")]
		[Address(RVA = "0x13D02C0", Offset = "0x13D02C0", VA = "0x13D02C0", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006D1F")]
		[Address(RVA = "0x13D03A8", Offset = "0x13D03A8", VA = "0x13D03A8")]
		private void OnSeekCompleted(VideoPlayer source)
		{
		}

		[Token(Token = "0x6006D20")]
		[Address(RVA = "0x13D0208", Offset = "0x13D0208", VA = "0x13D0208")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D21")]
		[Address(RVA = "0x13D0448", Offset = "0x13D0448", VA = "0x13D0448")]
		public VideoPlayerSeekCompletedEvent()
		{
		}
	}
}
