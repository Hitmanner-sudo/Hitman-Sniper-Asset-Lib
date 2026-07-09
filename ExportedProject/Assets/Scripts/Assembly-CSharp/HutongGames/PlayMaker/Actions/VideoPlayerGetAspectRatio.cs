using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200128C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD494", Offset = "0x5AD494")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD494", Offset = "0x5AD494")]
	public class VideoPlayerGetAspectRatio : FsmStateAction
	{
		[Token(Token = "0x40058C7")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60CAA0", Offset = "0x60CAA0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60CAA0", Offset = "0x60CAA0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40058C8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60CB34", Offset = "0x60CB34")]
		[RequiredField]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x60CB34", Offset = "0x60CB34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60CB34", Offset = "0x60CB34")]
		public FsmEnum aspectRatio;

		[Token(Token = "0x40058C9")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60CBDC", Offset = "0x60CBDC")]
		public bool everyFrame;

		[Token(Token = "0x40058CA")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x40058CB")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006C45")]
		[Address(RVA = "0x13CBC94", Offset = "0x13CBC94", VA = "0x13CBC94", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C46")]
		[Address(RVA = "0x13CBCA0", Offset = "0x13CBCA0", VA = "0x13CBCA0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C47")]
		[Address(RVA = "0x13CBE6C", Offset = "0x13CBE6C", VA = "0x13CBE6C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C48")]
		[Address(RVA = "0x13CBD9C", Offset = "0x13CBD9C", VA = "0x13CBD9C")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C49")]
		[Address(RVA = "0x13CBCE4", Offset = "0x13CBCE4", VA = "0x13CBCE4")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C4A")]
		[Address(RVA = "0x13CBE70", Offset = "0x13CBE70", VA = "0x13CBE70")]
		public VideoPlayerGetAspectRatio()
		{
		}
	}
}
