using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012A3")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADBC4", Offset = "0x5ADBC4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADBC4", Offset = "0x5ADBC4")]
	public class VideoPlayerGetTargetCameraAlpha : FsmStateAction
	{
		[Token(Token = "0x4005957")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60EAD8", Offset = "0x60EAD8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60EAD8", Offset = "0x60EAD8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005958")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60EB6C", Offset = "0x60EB6C")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60EB6C", Offset = "0x60EB6C")]
		public FsmFloat alpha;

		[Token(Token = "0x4005959")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60EBCC", Offset = "0x60EBCC")]
		public bool everyFrame;

		[Token(Token = "0x400595A")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x400595B")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006CCE")]
		[Address(RVA = "0x13CE6C0", Offset = "0x13CE6C0", VA = "0x13CE6C0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CCF")]
		[Address(RVA = "0x13CE6CC", Offset = "0x13CE6CC", VA = "0x13CE6CC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CD0")]
		[Address(RVA = "0x13CE85C", Offset = "0x13CE85C", VA = "0x13CE85C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CD1")]
		[Address(RVA = "0x13CE7C8", Offset = "0x13CE7C8", VA = "0x13CE7C8")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CD2")]
		[Address(RVA = "0x13CE710", Offset = "0x13CE710", VA = "0x13CE710")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CD3")]
		[Address(RVA = "0x13CE860", Offset = "0x13CE860", VA = "0x13CE860")]
		public VideoPlayerGetTargetCameraAlpha()
		{
		}
	}
}
