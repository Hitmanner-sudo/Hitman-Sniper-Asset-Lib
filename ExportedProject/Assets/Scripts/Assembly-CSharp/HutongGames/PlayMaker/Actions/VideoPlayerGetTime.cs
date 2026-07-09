using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012A7")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADD04", Offset = "0x5ADD04")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADD04", Offset = "0x5ADD04")]
	public class VideoPlayerGetTime : FsmStateAction
	{
		[Token(Token = "0x400596B")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60EF88", Offset = "0x60EF88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60EF88", Offset = "0x60EF88")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400596C")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60F01C", Offset = "0x60F01C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F01C", Offset = "0x60F01C")]
		public FsmFloat time;

		[Token(Token = "0x400596D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F07C", Offset = "0x60F07C")]
		public bool everyFrame;

		[Token(Token = "0x400596E")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x400596F")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006CE6")]
		[Address(RVA = "0x13CED88", Offset = "0x13CED88", VA = "0x13CED88", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CE7")]
		[Address(RVA = "0x13CED94", Offset = "0x13CED94", VA = "0x13CED94", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CE8")]
		[Address(RVA = "0x13CEF28", Offset = "0x13CEF28", VA = "0x13CEF28", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CE9")]
		[Address(RVA = "0x13CEE90", Offset = "0x13CEE90", VA = "0x13CEE90")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CEA")]
		[Address(RVA = "0x13CEDD8", Offset = "0x13CEDD8", VA = "0x13CEDD8")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CEB")]
		[Address(RVA = "0x13CEF2C", Offset = "0x13CEF2C", VA = "0x13CEF2C")]
		public VideoPlayerGetTime()
		{
		}
	}
}
