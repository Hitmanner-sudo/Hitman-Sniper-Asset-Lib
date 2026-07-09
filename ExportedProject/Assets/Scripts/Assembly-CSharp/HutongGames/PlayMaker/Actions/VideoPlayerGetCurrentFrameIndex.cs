using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001296")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD7B4", Offset = "0x5AD7B4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD7B4", Offset = "0x5AD7B4")]
	public class VideoPlayerGetCurrentFrameIndex : FsmStateAction
	{
		[Token(Token = "0x4005904")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60D8CC", Offset = "0x60D8CC")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D8CC", Offset = "0x60D8CC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005905")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60D960", Offset = "0x60D960")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D960", Offset = "0x60D960")]
		public FsmInt frameIndex;

		[Token(Token = "0x4005906")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D9C0", Offset = "0x60D9C0")]
		public bool everyFrame;

		[Token(Token = "0x4005907")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x4005908")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006C80")]
		[Address(RVA = "0x13CCE90", Offset = "0x13CCE90", VA = "0x13CCE90", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C81")]
		[Address(RVA = "0x13CCE9C", Offset = "0x13CCE9C", VA = "0x13CCE9C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C82")]
		[Address(RVA = "0x13CD02C", Offset = "0x13CD02C", VA = "0x13CD02C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C83")]
		[Address(RVA = "0x13CCF98", Offset = "0x13CCF98", VA = "0x13CCF98")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C84")]
		[Address(RVA = "0x13CCEE0", Offset = "0x13CCEE0", VA = "0x13CCEE0")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C85")]
		[Address(RVA = "0x13CD030", Offset = "0x13CD030", VA = "0x13CD030")]
		public VideoPlayerGetCurrentFrameIndex()
		{
		}
	}
}
