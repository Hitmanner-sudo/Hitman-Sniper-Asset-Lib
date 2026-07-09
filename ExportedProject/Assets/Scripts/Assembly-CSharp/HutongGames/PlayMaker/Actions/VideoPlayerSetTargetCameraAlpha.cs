using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012BB")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE344", Offset = "0x5AE344")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE344", Offset = "0x5AE344")]
	public class VideoPlayerSetTargetCameraAlpha : FsmStateAction
	{
		[Token(Token = "0x40059C7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6104E8", Offset = "0x6104E8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6104E8", Offset = "0x6104E8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059C8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x61057C", Offset = "0x61057C")]
		[RequiredField]
		public FsmFloat alpha;

		[Token(Token = "0x40059C9")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6105C8", Offset = "0x6105C8")]
		public bool everyFrame;

		[Token(Token = "0x40059CA")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x40059CB")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D56")]
		[Address(RVA = "0x13D15A8", Offset = "0x13D15A8", VA = "0x13D15A8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D57")]
		[Address(RVA = "0x13D15B4", Offset = "0x13D15B4", VA = "0x13D15B4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D58")]
		[Address(RVA = "0x13D1754", Offset = "0x13D1754", VA = "0x13D1754", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006D59")]
		[Address(RVA = "0x13D16B0", Offset = "0x13D16B0", VA = "0x13D16B0")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D5A")]
		[Address(RVA = "0x13D15F8", Offset = "0x13D15F8", VA = "0x13D15F8")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D5B")]
		[Address(RVA = "0x13D1758", Offset = "0x13D1758", VA = "0x13D1758")]
		public VideoPlayerSetTargetCameraAlpha()
		{
		}
	}
}
