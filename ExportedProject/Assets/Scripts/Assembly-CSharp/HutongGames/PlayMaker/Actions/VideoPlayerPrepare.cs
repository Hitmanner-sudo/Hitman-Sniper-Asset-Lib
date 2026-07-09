using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012AF")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADF84", Offset = "0x5ADF84")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADF84", Offset = "0x5ADF84")]
	public class VideoPlayerPrepare : FsmStateAction
	{
		[Token(Token = "0x4005991")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60F800", Offset = "0x60F800")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F800", Offset = "0x60F800")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005992")]
		[FieldOffset(Offset = "0x58")]
		private GameObject go;

		[Token(Token = "0x4005993")]
		[FieldOffset(Offset = "0x60")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D12")]
		[Address(RVA = "0x13CFC70", Offset = "0x13CFC70", VA = "0x13CFC70", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D13")]
		[Address(RVA = "0x13CFC78", Offset = "0x13CFC78", VA = "0x13CFC78", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D14")]
		[Address(RVA = "0x13CFD10", Offset = "0x13CFD10", VA = "0x13CFD10")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D15")]
		[Address(RVA = "0x13CFDC8", Offset = "0x13CFDC8", VA = "0x13CFDC8")]
		public VideoPlayerPrepare()
		{
		}
	}
}
