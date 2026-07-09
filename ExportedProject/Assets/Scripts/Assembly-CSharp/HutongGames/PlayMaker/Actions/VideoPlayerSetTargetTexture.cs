using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012BD")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE3E4", Offset = "0x5AE3E4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE3E4", Offset = "0x5AE3E4")]
	public class VideoPlayerSetTargetTexture : FsmStateAction
	{
		[Token(Token = "0x40059D1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610718", Offset = "0x610718")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x610718", Offset = "0x610718")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059D2")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6107AC", Offset = "0x6107AC")]
		public FsmTexture targetTexture;

		[Token(Token = "0x40059D3")]
		[FieldOffset(Offset = "0x60")]
		private GameObject go;

		[Token(Token = "0x40059D4")]
		[FieldOffset(Offset = "0x68")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D62")]
		[Address(RVA = "0x13D191C", Offset = "0x13D191C", VA = "0x13D191C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D63")]
		[Address(RVA = "0x13D1924", Offset = "0x13D1924", VA = "0x13D1924", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D64")]
		[Address(RVA = "0x13D1A0C", Offset = "0x13D1A0C", VA = "0x13D1A0C")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D65")]
		[Address(RVA = "0x13D1954", Offset = "0x13D1954", VA = "0x13D1954")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D66")]
		[Address(RVA = "0x13D1B04", Offset = "0x13D1B04", VA = "0x13D1B04")]
		public VideoPlayerSetTargetTexture()
		{
		}
	}
}
