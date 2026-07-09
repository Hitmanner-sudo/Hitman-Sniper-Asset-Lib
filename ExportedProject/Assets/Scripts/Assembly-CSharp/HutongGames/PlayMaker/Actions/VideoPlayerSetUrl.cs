using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012C0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE4D4", Offset = "0x5AE4D4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE4D4", Offset = "0x5AE4D4")]
	public class VideoPlayerSetUrl : FsmStateAction
	{
		[Token(Token = "0x40059E0")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x610AA8", Offset = "0x610AA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610AA8", Offset = "0x610AA8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059E1")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610B3C", Offset = "0x610B3C")]
		public FsmString url;

		[Token(Token = "0x40059E2")]
		[FieldOffset(Offset = "0x60")]
		private GameObject go;

		[Token(Token = "0x40059E3")]
		[FieldOffset(Offset = "0x68")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D72")]
		[Address(RVA = "0x13D2048", Offset = "0x13D2048", VA = "0x13D2048", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D73")]
		[Address(RVA = "0x13D2050", Offset = "0x13D2050", VA = "0x13D2050", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D74")]
		[Address(RVA = "0x13D2138", Offset = "0x13D2138", VA = "0x13D2138")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D75")]
		[Address(RVA = "0x13D2080", Offset = "0x13D2080", VA = "0x13D2080")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D76")]
		[Address(RVA = "0x13D21E0", Offset = "0x13D21E0", VA = "0x13D21E0")]
		public VideoPlayerSetUrl()
		{
		}
	}
}
