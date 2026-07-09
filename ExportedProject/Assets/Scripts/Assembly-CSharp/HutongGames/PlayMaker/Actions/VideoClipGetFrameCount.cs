using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001284")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD214", Offset = "0x5AD214")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD214", Offset = "0x5AD214")]
	public class VideoClipGetFrameCount : FsmStateAction
	{
		[Token(Token = "0x4005896")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60C0D0", Offset = "0x60C0D0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C0D0", Offset = "0x60C0D0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005897")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60C154", Offset = "0x60C154")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C154", Offset = "0x60C154")]
		public FsmObject orVideoClip;

		[Token(Token = "0x4005898")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C1A4", Offset = "0x60C1A4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60C1A4", Offset = "0x60C1A4")]
		public FsmInt frameCount;

		[Token(Token = "0x4005899")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C1F4", Offset = "0x60C1F4")]
		public bool everyFrame;

		[Token(Token = "0x400589A")]
		[FieldOffset(Offset = "0x70")]
		private GameObject go;

		[Token(Token = "0x400589B")]
		[FieldOffset(Offset = "0x78")]
		private VideoPlayer _vp;

		[Token(Token = "0x400589C")]
		[FieldOffset(Offset = "0x80")]
		private VideoClip _vc;

		[Token(Token = "0x6006C15")]
		[Address(RVA = "0x13CA3BC", Offset = "0x13CA3BC", VA = "0x13CA3BC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C16")]
		[Address(RVA = "0x13CA430", Offset = "0x13CA430", VA = "0x13CA430", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C17")]
		[Address(RVA = "0x13CA668", Offset = "0x13CA668", VA = "0x13CA668", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C18")]
		[Address(RVA = "0x13CA5D4", Offset = "0x13CA5D4", VA = "0x13CA5D4")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C19")]
		[Address(RVA = "0x13CA474", Offset = "0x13CA474", VA = "0x13CA474")]
		private void GetVideoClip()
		{
		}

		[Token(Token = "0x6006C1A")]
		[Address(RVA = "0x13CA68C", Offset = "0x13CA68C", VA = "0x13CA68C")]
		public VideoClipGetFrameCount()
		{
		}
	}
}
