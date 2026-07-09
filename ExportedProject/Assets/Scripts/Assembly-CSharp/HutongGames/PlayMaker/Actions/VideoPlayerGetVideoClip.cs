using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012AA")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADDF4", Offset = "0x5ADDF4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADDF4", Offset = "0x5ADDF4")]
	public class VideoPlayerGetVideoClip : FsmStateAction
	{
		[Token(Token = "0x400597A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60F354", Offset = "0x60F354")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F354", Offset = "0x60F354")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400597B")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60F3E8", Offset = "0x60F3E8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F3E8", Offset = "0x60F3E8")]
		public FsmObject videoClip;

		[Token(Token = "0x400597C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F448", Offset = "0x60F448")]
		public bool everyFrame;

		[Token(Token = "0x400597D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x400597E")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006CF8")]
		[Address(RVA = "0x13CF2C0", Offset = "0x13CF2C0", VA = "0x13CF2C0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CF9")]
		[Address(RVA = "0x13CF2CC", Offset = "0x13CF2CC", VA = "0x13CF2CC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CFA")]
		[Address(RVA = "0x13CF45C", Offset = "0x13CF45C", VA = "0x13CF45C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CFB")]
		[Address(RVA = "0x13CF3C8", Offset = "0x13CF3C8", VA = "0x13CF3C8")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CFC")]
		[Address(RVA = "0x13CF310", Offset = "0x13CF310", VA = "0x13CF310")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CFD")]
		[Address(RVA = "0x13CF460", Offset = "0x13CF460", VA = "0x13CF460")]
		public VideoPlayerGetVideoClip()
		{
		}
	}
}
