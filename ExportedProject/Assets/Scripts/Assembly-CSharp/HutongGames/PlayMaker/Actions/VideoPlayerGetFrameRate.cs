using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001298")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD854", Offset = "0x5AD854")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD854", Offset = "0x5AD854")]
	public class VideoPlayerGetFrameRate : FsmStateAction
	{
		[Token(Token = "0x400590E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DB24", Offset = "0x60DB24")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60DB24", Offset = "0x60DB24")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400590F")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DBB8", Offset = "0x60DBB8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60DBB8", Offset = "0x60DBB8")]
		public FsmFloat frameRate;

		[Token(Token = "0x4005910")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DC18", Offset = "0x60DC18")]
		public bool everyFrame;

		[Token(Token = "0x4005911")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x4005912")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006C8C")]
		[Address(RVA = "0x13CD1E0", Offset = "0x13CD1E0", VA = "0x13CD1E0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C8D")]
		[Address(RVA = "0x13CD1EC", Offset = "0x13CD1EC", VA = "0x13CD1EC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C8E")]
		[Address(RVA = "0x13CD37C", Offset = "0x13CD37C", VA = "0x13CD37C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C8F")]
		[Address(RVA = "0x13CD2E8", Offset = "0x13CD2E8", VA = "0x13CD2E8")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C90")]
		[Address(RVA = "0x13CD230", Offset = "0x13CD230", VA = "0x13CD230")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C91")]
		[Address(RVA = "0x13CD380", Offset = "0x13CD380", VA = "0x13CD380")]
		public VideoPlayerGetFrameRate()
		{
		}
	}
}
