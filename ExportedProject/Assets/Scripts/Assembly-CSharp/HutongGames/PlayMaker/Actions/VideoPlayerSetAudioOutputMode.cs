using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012B3")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE0C4", Offset = "0x5AE0C4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE0C4", Offset = "0x5AE0C4")]
	public class VideoPlayerSetAudioOutputMode : FsmStateAction
	{
		[Token(Token = "0x40059A0")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60FB54", Offset = "0x60FB54")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60FB54", Offset = "0x60FB54")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059A1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60FBE8", Offset = "0x60FBE8")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x60FBE8", Offset = "0x60FBE8")]
		[RequiredField]
		public FsmEnum audioOutputMode;

		[Token(Token = "0x40059A2")]
		[FieldOffset(Offset = "0x60")]
		private GameObject go;

		[Token(Token = "0x40059A3")]
		[FieldOffset(Offset = "0x68")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D27")]
		[Address(RVA = "0x13D068C", Offset = "0x13D068C", VA = "0x13D068C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D28")]
		[Address(RVA = "0x13D06FC", Offset = "0x13D06FC", VA = "0x13D06FC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D29")]
		[Address(RVA = "0x13D07E4", Offset = "0x13D07E4", VA = "0x13D07E4")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D2A")]
		[Address(RVA = "0x13D072C", Offset = "0x13D072C", VA = "0x13D072C")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D2B")]
		[Address(RVA = "0x13D08C4", Offset = "0x13D08C4", VA = "0x13D08C4")]
		public VideoPlayerSetAudioOutputMode()
		{
		}
	}
}
