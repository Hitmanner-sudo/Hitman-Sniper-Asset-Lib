using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012A8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADD54", Offset = "0x5ADD54")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADD54", Offset = "0x5ADD54")]
	public class VideoPlayerGetTimeSource : FsmStateAction
	{
		[Token(Token = "0x4005970")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F0B4", Offset = "0x60F0B4")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60F0B4", Offset = "0x60F0B4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005971")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60F148", Offset = "0x60F148")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F148", Offset = "0x60F148")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x60F148", Offset = "0x60F148")]
		public FsmEnum timeSource;

		[Token(Token = "0x4005972")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F1F0", Offset = "0x60F1F0")]
		public bool everyFrame;

		[Token(Token = "0x4005973")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x4005974")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006CEC")]
		[Address(RVA = "0x13CEF34", Offset = "0x13CEF34", VA = "0x13CEF34", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CED")]
		[Address(RVA = "0x13CEF40", Offset = "0x13CEF40", VA = "0x13CEF40", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CEE")]
		[Address(RVA = "0x13CF10C", Offset = "0x13CF10C", VA = "0x13CF10C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CEF")]
		[Address(RVA = "0x13CF03C", Offset = "0x13CF03C", VA = "0x13CF03C")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CF0")]
		[Address(RVA = "0x13CEF84", Offset = "0x13CEF84", VA = "0x13CEF84")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CF1")]
		[Address(RVA = "0x13CF110", Offset = "0x13CF110", VA = "0x13CF110")]
		public VideoPlayerGetTimeSource()
		{
		}
	}
}
