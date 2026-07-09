using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012A9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADDA4", Offset = "0x5ADDA4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADDA4", Offset = "0x5ADDA4")]
	public class VideoPlayerGetUrl : FsmStateAction
	{
		[Token(Token = "0x4005975")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F228", Offset = "0x60F228")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60F228", Offset = "0x60F228")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005976")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60F2BC", Offset = "0x60F2BC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F2BC", Offset = "0x60F2BC")]
		[RequiredField]
		public FsmString url;

		[Token(Token = "0x4005977")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F31C", Offset = "0x60F31C")]
		public bool everyFrame;

		[Token(Token = "0x4005978")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x4005979")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006CF2")]
		[Address(RVA = "0x13CF118", Offset = "0x13CF118", VA = "0x13CF118", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CF3")]
		[Address(RVA = "0x13CF124", Offset = "0x13CF124", VA = "0x13CF124", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CF4")]
		[Address(RVA = "0x13CF2B4", Offset = "0x13CF2B4", VA = "0x13CF2B4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CF5")]
		[Address(RVA = "0x13CF220", Offset = "0x13CF220", VA = "0x13CF220")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CF6")]
		[Address(RVA = "0x13CF168", Offset = "0x13CF168", VA = "0x13CF168")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CF7")]
		[Address(RVA = "0x13CF2B8", Offset = "0x13CF2B8", VA = "0x13CF2B8")]
		public VideoPlayerGetUrl()
		{
		}
	}
}
