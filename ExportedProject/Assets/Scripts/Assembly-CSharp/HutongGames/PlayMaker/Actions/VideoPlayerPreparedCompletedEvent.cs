using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012B0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADFD4", Offset = "0x5ADFD4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADFD4", Offset = "0x5ADFD4")]
	public class VideoPlayerPreparedCompletedEvent : FsmStateAction
	{
		[Token(Token = "0x4005994")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F894", Offset = "0x60F894")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60F894", Offset = "0x60F894")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005995")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F928", Offset = "0x60F928")]
		public FsmEvent OnPreparedCompletedEvent;

		[Token(Token = "0x4005996")]
		[FieldOffset(Offset = "0x60")]
		private GameObject go;

		[Token(Token = "0x4005997")]
		[FieldOffset(Offset = "0x68")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D16")]
		[Address(RVA = "0x13CFDD0", Offset = "0x13CFDD0", VA = "0x13CFDD0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D17")]
		[Address(RVA = "0x13CFDD8", Offset = "0x13CFDD8", VA = "0x13CFDD8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D18")]
		[Address(RVA = "0x13CFF80", Offset = "0x13CFF80", VA = "0x13CFF80", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006D19")]
		[Address(RVA = "0x13D0068", Offset = "0x13D0068", VA = "0x13D0068")]
		private void OnPreparedCompleted(VideoPlayer source)
		{
		}

		[Token(Token = "0x6006D1A")]
		[Address(RVA = "0x13CFEC8", Offset = "0x13CFEC8", VA = "0x13CFEC8")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D1B")]
		[Address(RVA = "0x13D0108", Offset = "0x13D0108", VA = "0x13D0108")]
		public VideoPlayerPreparedCompletedEvent()
		{
		}
	}
}
