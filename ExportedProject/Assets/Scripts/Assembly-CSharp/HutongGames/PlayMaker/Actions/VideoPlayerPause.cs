using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012AD")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADEE4", Offset = "0x5ADEE4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADEE4", Offset = "0x5ADEE4")]
	public class VideoPlayerPause : FsmStateAction
	{
		[Token(Token = "0x400598B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F6D8", Offset = "0x60F6D8")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60F6D8", Offset = "0x60F6D8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400598C")]
		[FieldOffset(Offset = "0x58")]
		private GameObject go;

		[Token(Token = "0x400598D")]
		[FieldOffset(Offset = "0x60")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D0A")]
		[Address(RVA = "0x13CF9B0", Offset = "0x13CF9B0", VA = "0x13CF9B0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D0B")]
		[Address(RVA = "0x13CF9B8", Offset = "0x13CF9B8", VA = "0x13CF9B8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D0C")]
		[Address(RVA = "0x13CFA50", Offset = "0x13CFA50", VA = "0x13CFA50")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D0D")]
		[Address(RVA = "0x13CFB08", Offset = "0x13CFB08", VA = "0x13CFB08")]
		public VideoPlayerPause()
		{
		}
	}
}
