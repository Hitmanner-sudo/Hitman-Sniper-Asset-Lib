using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012BF")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE484", Offset = "0x5AE484")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE484", Offset = "0x5AE484")]
	public class VideoPlayerSetTimeSource : FsmStateAction
	{
		[Token(Token = "0x40059DB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610948", Offset = "0x610948")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x610948", Offset = "0x610948")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059DC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6109DC", Offset = "0x6109DC")]
		[RequiredField]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x6109DC", Offset = "0x6109DC")]
		public FsmEnum timeSource;

		[Token(Token = "0x40059DD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610A70", Offset = "0x610A70")]
		public FsmEvent canNotSetTime;

		[Token(Token = "0x40059DE")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x40059DF")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D6D")]
		[Address(RVA = "0x13D1D6C", Offset = "0x13D1D6C", VA = "0x13D1D6C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D6E")]
		[Address(RVA = "0x13D1DD8", Offset = "0x13D1DD8", VA = "0x13D1DD8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D6F")]
		[Address(RVA = "0x13D1F4C", Offset = "0x13D1F4C", VA = "0x13D1F4C")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D70")]
		[Address(RVA = "0x13D1E94", Offset = "0x13D1E94", VA = "0x13D1E94")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D71")]
		[Address(RVA = "0x13D2040", Offset = "0x13D2040", VA = "0x13D2040")]
		public VideoPlayerSetTimeSource()
		{
		}
	}
}
