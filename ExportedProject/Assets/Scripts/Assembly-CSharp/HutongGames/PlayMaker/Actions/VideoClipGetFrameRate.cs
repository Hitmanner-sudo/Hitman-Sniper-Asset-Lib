using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001285")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD264", Offset = "0x5AD264")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD264", Offset = "0x5AD264")]
	public class VideoClipGetFrameRate : FsmStateAction
	{
		[Token(Token = "0x400589D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C22C", Offset = "0x60C22C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60C22C", Offset = "0x60C22C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400589E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C2B0", Offset = "0x60C2B0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60C2B0", Offset = "0x60C2B0")]
		public FsmObject orVideoClip;

		[Token(Token = "0x400589F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60C300", Offset = "0x60C300")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C300", Offset = "0x60C300")]
		public FsmFloat frameRate;

		[Token(Token = "0x40058A0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C350", Offset = "0x60C350")]
		public bool everyFrame;

		[Token(Token = "0x40058A1")]
		[FieldOffset(Offset = "0x70")]
		private GameObject go;

		[Token(Token = "0x40058A2")]
		[FieldOffset(Offset = "0x78")]
		private VideoPlayer _vp;

		[Token(Token = "0x40058A3")]
		[FieldOffset(Offset = "0x80")]
		private VideoClip _vc;

		[Token(Token = "0x6006C1B")]
		[Address(RVA = "0x13CA694", Offset = "0x13CA694", VA = "0x13CA694", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C1C")]
		[Address(RVA = "0x13CA708", Offset = "0x13CA708", VA = "0x13CA708", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C1D")]
		[Address(RVA = "0x13CA944", Offset = "0x13CA944", VA = "0x13CA944", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C1E")]
		[Address(RVA = "0x13CA8AC", Offset = "0x13CA8AC", VA = "0x13CA8AC")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C1F")]
		[Address(RVA = "0x13CA74C", Offset = "0x13CA74C", VA = "0x13CA74C")]
		private void GetVideoClip()
		{
		}

		[Token(Token = "0x6006C20")]
		[Address(RVA = "0x13CA968", Offset = "0x13CA968", VA = "0x13CA968")]
		public VideoClipGetFrameRate()
		{
		}
	}
}
