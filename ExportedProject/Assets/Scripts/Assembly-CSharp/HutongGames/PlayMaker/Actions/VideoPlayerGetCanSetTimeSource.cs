using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001293")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD6C4", Offset = "0x5AD6C4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD6C4", Offset = "0x5AD6C4")]
	public class VideoPlayerGetCanSetTimeSource : FsmStateAction
	{
		[Token(Token = "0x40058F4")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60D51C", Offset = "0x60D51C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D51C", Offset = "0x60D51C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40058F5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D5B0", Offset = "0x60D5B0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60D5B0", Offset = "0x60D5B0")]
		public FsmBool canSetTimeSource;

		[Token(Token = "0x40058F6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D600", Offset = "0x60D600")]
		public FsmEvent canSetTimeSourceEvent;

		[Token(Token = "0x40058F7")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D638", Offset = "0x60D638")]
		public FsmEvent canNotSetTimeSourceEvent;

		[Token(Token = "0x40058F8")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D670", Offset = "0x60D670")]
		public bool everyFrame;

		[Token(Token = "0x40058F9")]
		[FieldOffset(Offset = "0x78")]
		private GameObject go;

		[Token(Token = "0x40058FA")]
		[FieldOffset(Offset = "0x80")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006C6F")]
		[Address(RVA = "0x13CC878", Offset = "0x13CC878", VA = "0x13CC878", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C70")]
		[Address(RVA = "0x13CC888", Offset = "0x13CC888", VA = "0x13CC888", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C71")]
		[Address(RVA = "0x13CCA5C", Offset = "0x13CCA5C", VA = "0x13CCA5C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C72")]
		[Address(RVA = "0x13CC984", Offset = "0x13CC984", VA = "0x13CC984")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C73")]
		[Address(RVA = "0x13CC8CC", Offset = "0x13CC8CC", VA = "0x13CC8CC")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C74")]
		[Address(RVA = "0x13CCA60", Offset = "0x13CCA60", VA = "0x13CCA60")]
		public VideoPlayerGetCanSetTimeSource()
		{
		}
	}
}
