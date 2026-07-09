using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200128D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD4E4", Offset = "0x5AD4E4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD4E4", Offset = "0x5AD4E4")]
	public class VideoPlayerGetAudioOutputMode : FsmStateAction
	{
		[Token(Token = "0x40058CC")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60CC14", Offset = "0x60CC14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60CC14", Offset = "0x60CC14")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40058CD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x60CCA8", Offset = "0x60CCA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60CCA8", Offset = "0x60CCA8")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60CCA8", Offset = "0x60CCA8")]
		public FsmEnum audioOutputMode;

		[Token(Token = "0x40058CE")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60CD50", Offset = "0x60CD50")]
		public bool everyFrame;

		[Token(Token = "0x40058CF")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x40058D0")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006C4B")]
		[Address(RVA = "0x13CBE78", Offset = "0x13CBE78", VA = "0x13CBE78", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C4C")]
		[Address(RVA = "0x13CBEEC", Offset = "0x13CBEEC", VA = "0x13CBEEC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C4D")]
		[Address(RVA = "0x13CC0B8", Offset = "0x13CC0B8", VA = "0x13CC0B8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C4E")]
		[Address(RVA = "0x13CBFE8", Offset = "0x13CBFE8", VA = "0x13CBFE8")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C4F")]
		[Address(RVA = "0x13CBF30", Offset = "0x13CBF30", VA = "0x13CBF30")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C50")]
		[Address(RVA = "0x13CC0BC", Offset = "0x13CC0BC", VA = "0x13CC0BC")]
		public VideoPlayerGetAudioOutputMode()
		{
		}
	}
}
