using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001292")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD674", Offset = "0x5AD674")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD674", Offset = "0x5AD674")]
	public class VideoPlayerGetCanSetTime : FsmStateAction
	{
		[Token(Token = "0x40058ED")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D390", Offset = "0x60D390")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60D390", Offset = "0x60D390")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40058EE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60D424", Offset = "0x60D424")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D424", Offset = "0x60D424")]
		public FsmBool canSetTime;

		[Token(Token = "0x40058EF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D474", Offset = "0x60D474")]
		public FsmEvent canSetTimeEvent;

		[Token(Token = "0x40058F0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D4AC", Offset = "0x60D4AC")]
		public FsmEvent canNotSetTimeEvent;

		[Token(Token = "0x40058F1")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D4E4", Offset = "0x60D4E4")]
		public bool everyFrame;

		[Token(Token = "0x40058F2")]
		[FieldOffset(Offset = "0x78")]
		private GameObject go;

		[Token(Token = "0x40058F3")]
		[FieldOffset(Offset = "0x80")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006C69")]
		[Address(RVA = "0x13CC688", Offset = "0x13CC688", VA = "0x13CC688", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C6A")]
		[Address(RVA = "0x13CC698", Offset = "0x13CC698", VA = "0x13CC698", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C6B")]
		[Address(RVA = "0x13CC86C", Offset = "0x13CC86C", VA = "0x13CC86C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C6C")]
		[Address(RVA = "0x13CC794", Offset = "0x13CC794", VA = "0x13CC794")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C6D")]
		[Address(RVA = "0x13CC6DC", Offset = "0x13CC6DC", VA = "0x13CC6DC")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C6E")]
		[Address(RVA = "0x13CC870", Offset = "0x13CC870", VA = "0x13CC870")]
		public VideoPlayerGetCanSetTime()
		{
		}
	}
}
