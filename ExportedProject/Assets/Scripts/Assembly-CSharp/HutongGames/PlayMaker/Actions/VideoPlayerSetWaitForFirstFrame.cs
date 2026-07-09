using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012C2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE574", Offset = "0x5AE574")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE574", Offset = "0x5AE574")]
	public class VideoPlayerSetWaitForFirstFrame : FsmStateAction
	{
		[Token(Token = "0x40059E8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610CA0", Offset = "0x610CA0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x610CA0", Offset = "0x610CA0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059E9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x610D34", Offset = "0x610D34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610D34", Offset = "0x610D34")]
		public FsmBool waitForFirstFrame;

		[Token(Token = "0x40059EA")]
		[FieldOffset(Offset = "0x60")]
		private GameObject go;

		[Token(Token = "0x40059EB")]
		[FieldOffset(Offset = "0x68")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D7B")]
		[Address(RVA = "0x13D238C", Offset = "0x13D238C", VA = "0x13D238C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D7C")]
		[Address(RVA = "0x13D2394", Offset = "0x13D2394", VA = "0x13D2394", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D7D")]
		[Address(RVA = "0x13D247C", Offset = "0x13D247C", VA = "0x13D247C")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D7E")]
		[Address(RVA = "0x13D23C4", Offset = "0x13D23C4", VA = "0x13D23C4")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D7F")]
		[Address(RVA = "0x13D2524", Offset = "0x13D2524", VA = "0x13D2524")]
		public VideoPlayerSetWaitForFirstFrame()
		{
		}
	}
}
