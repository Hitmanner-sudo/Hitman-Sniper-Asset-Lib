using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001287")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD304", Offset = "0x5AD304")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD304", Offset = "0x5AD304")]
	public class VideoClipGetOriginalPath : FsmStateAction
	{
		[Token(Token = "0x40058AB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C4E4", Offset = "0x60C4E4")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60C4E4", Offset = "0x60C4E4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40058AC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C568", Offset = "0x60C568")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60C568", Offset = "0x60C568")]
		public FsmObject orVideoClip;

		[Token(Token = "0x40058AD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60C5B8", Offset = "0x60C5B8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C5B8", Offset = "0x60C5B8")]
		public FsmString originalPath;

		[Token(Token = "0x40058AE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C608", Offset = "0x60C608")]
		public bool everyFrame;

		[Token(Token = "0x40058AF")]
		[FieldOffset(Offset = "0x70")]
		private GameObject go;

		[Token(Token = "0x40058B0")]
		[FieldOffset(Offset = "0x78")]
		private VideoPlayer _vp;

		[Token(Token = "0x40058B1")]
		[FieldOffset(Offset = "0x80")]
		private VideoClip _vc;

		[Token(Token = "0x6006C27")]
		[Address(RVA = "0x13CAC4C", Offset = "0x13CAC4C", VA = "0x13CAC4C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C28")]
		[Address(RVA = "0x13CACC0", Offset = "0x13CACC0", VA = "0x13CACC0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C29")]
		[Address(RVA = "0x13CAEF8", Offset = "0x13CAEF8", VA = "0x13CAEF8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C2A")]
		[Address(RVA = "0x13CAE64", Offset = "0x13CAE64", VA = "0x13CAE64")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C2B")]
		[Address(RVA = "0x13CAD04", Offset = "0x13CAD04", VA = "0x13CAD04")]
		private void GetVideoClip()
		{
		}

		[Token(Token = "0x6006C2C")]
		[Address(RVA = "0x13CAF1C", Offset = "0x13CAF1C", VA = "0x13CAF1C")]
		public VideoClipGetOriginalPath()
		{
		}
	}
}
