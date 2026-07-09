using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001297")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD804", Offset = "0x5AD804")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD804", Offset = "0x5AD804")]
	public class VideoPlayerGetFrameCount : FsmStateAction
	{
		[Token(Token = "0x4005909")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D9F8", Offset = "0x60D9F8")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60D9F8", Offset = "0x60D9F8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400590A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60DA8C", Offset = "0x60DA8C")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DA8C", Offset = "0x60DA8C")]
		public FsmInt frameCount;

		[Token(Token = "0x400590B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DAEC", Offset = "0x60DAEC")]
		public bool everyFrame;

		[Token(Token = "0x400590C")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x400590D")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006C86")]
		[Address(RVA = "0x13CD038", Offset = "0x13CD038", VA = "0x13CD038", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C87")]
		[Address(RVA = "0x13CD044", Offset = "0x13CD044", VA = "0x13CD044", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C88")]
		[Address(RVA = "0x13CD1D4", Offset = "0x13CD1D4", VA = "0x13CD1D4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C89")]
		[Address(RVA = "0x13CD140", Offset = "0x13CD140", VA = "0x13CD140")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C8A")]
		[Address(RVA = "0x13CD088", Offset = "0x13CD088", VA = "0x13CD088")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C8B")]
		[Address(RVA = "0x13CD1D8", Offset = "0x13CD1D8", VA = "0x13CD1D8")]
		public VideoPlayerGetFrameCount()
		{
		}
	}
}
