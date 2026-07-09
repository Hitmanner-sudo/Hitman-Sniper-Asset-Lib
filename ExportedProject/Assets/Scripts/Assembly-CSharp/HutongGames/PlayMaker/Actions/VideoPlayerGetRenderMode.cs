using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200129E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADA34", Offset = "0x5ADA34")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADA34", Offset = "0x5ADA34")]
	public class VideoPlayerGetRenderMode : FsmStateAction
	{
		[Token(Token = "0x4005938")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60E3AC", Offset = "0x60E3AC")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E3AC", Offset = "0x60E3AC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005939")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E440", Offset = "0x60E440")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x60E440", Offset = "0x60E440")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60E440", Offset = "0x60E440")]
		[RequiredField]
		public FsmEnum renderMode;

		[Token(Token = "0x400593A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E4E8", Offset = "0x60E4E8")]
		public bool everyFrame;

		[Token(Token = "0x400593B")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x400593C")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006CB0")]
		[Address(RVA = "0x13CDCE4", Offset = "0x13CDCE4", VA = "0x13CDCE4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CB1")]
		[Address(RVA = "0x13CDCF0", Offset = "0x13CDCF0", VA = "0x13CDCF0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CB2")]
		[Address(RVA = "0x13CDEBC", Offset = "0x13CDEBC", VA = "0x13CDEBC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CB3")]
		[Address(RVA = "0x13CDDEC", Offset = "0x13CDDEC", VA = "0x13CDDEC")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CB4")]
		[Address(RVA = "0x13CDD34", Offset = "0x13CDD34", VA = "0x13CDD34")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CB5")]
		[Address(RVA = "0x13CDEC0", Offset = "0x13CDEC0", VA = "0x13CDEC0")]
		public VideoPlayerGetRenderMode()
		{
		}
	}
}
