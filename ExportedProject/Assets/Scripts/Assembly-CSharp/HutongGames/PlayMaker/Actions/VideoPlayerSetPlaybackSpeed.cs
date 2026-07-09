using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012B5")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE164", Offset = "0x5AE164")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE164", Offset = "0x5AE164")]
	public class VideoPlayerSetPlaybackSpeed : FsmStateAction
	{
		[Token(Token = "0x40059A9")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60FD80", Offset = "0x60FD80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60FD80", Offset = "0x60FD80")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059AA")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60FE14", Offset = "0x60FE14")]
		public FsmFloat playbackSpeed;

		[Token(Token = "0x40059AB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60FE60", Offset = "0x60FE60")]
		public bool everyFrame;

		[Token(Token = "0x40059AC")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x40059AD")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D32")]
		[Address(RVA = "0x13D0A88", Offset = "0x13D0A88", VA = "0x13D0A88", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D33")]
		[Address(RVA = "0x13D0A94", Offset = "0x13D0A94", VA = "0x13D0A94", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D34")]
		[Address(RVA = "0x13D0C34", Offset = "0x13D0C34", VA = "0x13D0C34", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006D35")]
		[Address(RVA = "0x13D0B90", Offset = "0x13D0B90", VA = "0x13D0B90")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D36")]
		[Address(RVA = "0x13D0AD8", Offset = "0x13D0AD8", VA = "0x13D0AD8")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D37")]
		[Address(RVA = "0x13D0C38", Offset = "0x13D0C38", VA = "0x13D0C38")]
		public VideoPlayerSetPlaybackSpeed()
		{
		}
	}
}
