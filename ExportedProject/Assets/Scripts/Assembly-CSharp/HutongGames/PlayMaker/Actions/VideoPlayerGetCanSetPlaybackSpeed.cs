using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001290")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD5D4", Offset = "0x5AD5D4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD5D4", Offset = "0x5AD5D4")]
	public class VideoPlayerGetCanSetPlaybackSpeed : FsmStateAction
	{
		[Token(Token = "0x40058DE")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60D078", Offset = "0x60D078")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D078", Offset = "0x60D078")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40058DF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D10C", Offset = "0x60D10C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60D10C", Offset = "0x60D10C")]
		public FsmBool canSetPlaybackSpeed;

		[Token(Token = "0x40058E0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D15C", Offset = "0x60D15C")]
		public FsmEvent canSetTimePlaybackSpeed;

		[Token(Token = "0x40058E1")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D194", Offset = "0x60D194")]
		public FsmEvent canNotSetTimePlaybackSpeed;

		[Token(Token = "0x40058E2")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D1CC", Offset = "0x60D1CC")]
		public bool everyFrame;

		[Token(Token = "0x40058E3")]
		[FieldOffset(Offset = "0x78")]
		private GameObject go;

		[Token(Token = "0x40058E4")]
		[FieldOffset(Offset = "0x80")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006C5D")]
		[Address(RVA = "0x13CC498", Offset = "0x13CC498", VA = "0x13CC498", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C5E")]
		[Address(RVA = "0x13CC4A8", Offset = "0x13CC4A8", VA = "0x13CC4A8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C5F")]
		[Address(RVA = "0x13CC67C", Offset = "0x13CC67C", VA = "0x13CC67C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C60")]
		[Address(RVA = "0x13CC5A4", Offset = "0x13CC5A4", VA = "0x13CC5A4")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C61")]
		[Address(RVA = "0x13CC4EC", Offset = "0x13CC4EC", VA = "0x13CC4EC")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C62")]
		[Address(RVA = "0x13CC680", Offset = "0x13CC680", VA = "0x13CC680")]
		public VideoPlayerGetCanSetPlaybackSpeed()
		{
		}
	}
}
