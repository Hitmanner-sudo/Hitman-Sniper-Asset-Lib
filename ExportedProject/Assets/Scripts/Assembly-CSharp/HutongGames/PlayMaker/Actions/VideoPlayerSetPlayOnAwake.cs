using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012B4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE114", Offset = "0x5AE114")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE114", Offset = "0x5AE114")]
	public class VideoPlayerSetPlayOnAwake : FsmStateAction
	{
		[Token(Token = "0x40059A4")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60FC7C", Offset = "0x60FC7C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60FC7C", Offset = "0x60FC7C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059A5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60FD10", Offset = "0x60FD10")]
		public FsmBool playOnAwake;

		[Token(Token = "0x40059A6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60FD48", Offset = "0x60FD48")]
		public bool everyframe;

		[Token(Token = "0x40059A7")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x40059A8")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D2C")]
		[Address(RVA = "0x13D08CC", Offset = "0x13D08CC", VA = "0x13D08CC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D2D")]
		[Address(RVA = "0x13D08D8", Offset = "0x13D08D8", VA = "0x13D08D8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D2E")]
		[Address(RVA = "0x13D0A7C", Offset = "0x13D0A7C", VA = "0x13D0A7C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006D2F")]
		[Address(RVA = "0x13D09D4", Offset = "0x13D09D4", VA = "0x13D09D4")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D30")]
		[Address(RVA = "0x13D091C", Offset = "0x13D091C", VA = "0x13D091C")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D31")]
		[Address(RVA = "0x13D0A80", Offset = "0x13D0A80", VA = "0x13D0A80")]
		public VideoPlayerSetPlayOnAwake()
		{
		}
	}
}
