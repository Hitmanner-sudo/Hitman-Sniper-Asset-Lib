using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001289")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD3A4", Offset = "0x5AD3A4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD3A4", Offset = "0x5AD3A4")]
	public class VideoPlayerErrorEvent : FsmStateAction
	{
		[Token(Token = "0x40058BB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C83C", Offset = "0x60C83C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60C83C", Offset = "0x60C83C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40058BC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C8D0", Offset = "0x60C8D0")]
		public FsmEvent onErrorEvent;

		[Token(Token = "0x40058BD")]
		[FieldOffset(Offset = "0x60")]
		private GameObject go;

		[Token(Token = "0x40058BE")]
		[FieldOffset(Offset = "0x68")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006C33")]
		[Address(RVA = "0x13CB294", Offset = "0x13CB294", VA = "0x13CB294", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C34")]
		[Address(RVA = "0x13CB29C", Offset = "0x13CB29C", VA = "0x13CB29C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C35")]
		[Address(RVA = "0x13CB444", Offset = "0x13CB444", VA = "0x13CB444", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006C36")]
		[Address(RVA = "0x13CB52C", Offset = "0x13CB52C", VA = "0x13CB52C")]
		private void OnErrorReceived(VideoPlayer source, string errorMessage)
		{
		}

		[Token(Token = "0x6006C37")]
		[Address(RVA = "0x13CB38C", Offset = "0x13CB38C", VA = "0x13CB38C")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C38")]
		[Address(RVA = "0x13CB5EC", Offset = "0x13CB5EC", VA = "0x13CB5EC")]
		public VideoPlayerErrorEvent()
		{
		}
	}
}
