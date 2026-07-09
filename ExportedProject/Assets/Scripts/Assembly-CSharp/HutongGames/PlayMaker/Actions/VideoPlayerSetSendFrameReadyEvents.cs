using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012B7")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE204", Offset = "0x5AE204")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE204", Offset = "0x5AE204")]
	public class VideoPlayerSetSendFrameReadyEvents : FsmStateAction
	{
		[Token(Token = "0x40059B3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60FFF8", Offset = "0x60FFF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60FFF8", Offset = "0x60FFF8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059B4")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x61008C", Offset = "0x61008C")]
		public FsmBool sendFrameReadyEvents;

		[Token(Token = "0x40059B5")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6100D8", Offset = "0x6100D8")]
		public bool everyframe;

		[Token(Token = "0x40059B6")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x40059B7")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D3E")]
		[Address(RVA = "0x13D0E34", Offset = "0x13D0E34", VA = "0x13D0E34", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D3F")]
		[Address(RVA = "0x13D0E3C", Offset = "0x13D0E3C", VA = "0x13D0E3C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D40")]
		[Address(RVA = "0x13D0FC0", Offset = "0x13D0FC0", VA = "0x13D0FC0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006D41")]
		[Address(RVA = "0x13D0F18", Offset = "0x13D0F18", VA = "0x13D0F18")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D42")]
		[Address(RVA = "0x13D0E60", Offset = "0x13D0E60", VA = "0x13D0E60")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D43")]
		[Address(RVA = "0x13D0FC4", Offset = "0x13D0FC4", VA = "0x13D0FC4")]
		public VideoPlayerSetSendFrameReadyEvents()
		{
		}
	}
}
