using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012C4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE614", Offset = "0x5AE614")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE614", Offset = "0x5AE614")]
	public class VideoPlayerStepForward : FsmStateAction
	{
		[Token(Token = "0x40059F0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610E50", Offset = "0x610E50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x610E50", Offset = "0x610E50")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059F1")]
		[FieldOffset(Offset = "0x58")]
		private GameObject go;

		[Token(Token = "0x40059F2")]
		[FieldOffset(Offset = "0x60")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D86")]
		[Address(RVA = "0x978554", Offset = "0x978554", VA = "0x978554", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D87")]
		[Address(RVA = "0x97855C", Offset = "0x97855C", VA = "0x97855C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D88")]
		[Address(RVA = "0x9785FC", Offset = "0x9785FC", VA = "0x9785FC")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D89")]
		[Address(RVA = "0x9786B4", Offset = "0x9786B4", VA = "0x9786B4")]
		public VideoPlayerStepForward()
		{
		}
	}
}
