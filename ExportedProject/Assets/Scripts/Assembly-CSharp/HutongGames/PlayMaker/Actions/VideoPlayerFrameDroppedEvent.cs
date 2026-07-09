using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200128A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD3F4", Offset = "0x5AD3F4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD3F4", Offset = "0x5AD3F4")]
	public class VideoPlayerFrameDroppedEvent : FsmStateAction
	{
		[Token(Token = "0x40058BF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60C908", Offset = "0x60C908")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C908", Offset = "0x60C908")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40058C0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C99C", Offset = "0x60C99C")]
		public FsmEvent onFrameDroppedEvent;

		[Token(Token = "0x40058C1")]
		[FieldOffset(Offset = "0x60")]
		private GameObject go;

		[Token(Token = "0x40058C2")]
		[FieldOffset(Offset = "0x68")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006C39")]
		[Address(RVA = "0x13CB5F4", Offset = "0x13CB5F4", VA = "0x13CB5F4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C3A")]
		[Address(RVA = "0x13CB5FC", Offset = "0x13CB5FC", VA = "0x13CB5FC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C3B")]
		[Address(RVA = "0x13CB7A4", Offset = "0x13CB7A4", VA = "0x13CB7A4", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006C3C")]
		[Address(RVA = "0x13CB88C", Offset = "0x13CB88C", VA = "0x13CB88C")]
		private void OnFrameDropped(VideoPlayer source)
		{
		}

		[Token(Token = "0x6006C3D")]
		[Address(RVA = "0x13CB6EC", Offset = "0x13CB6EC", VA = "0x13CB6EC")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C3E")]
		[Address(RVA = "0x13CB92C", Offset = "0x13CB92C", VA = "0x13CB92C")]
		public VideoPlayerFrameDroppedEvent()
		{
		}
	}
}
