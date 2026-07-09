using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001291")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD624", Offset = "0x5AD624")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD624", Offset = "0x5AD624")]
	public class VideoPlayerGetCanSkipOnDrop : FsmStateAction
	{
		[Token(Token = "0x40058E5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60D204", Offset = "0x60D204")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D204", Offset = "0x60D204")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40058E6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60D298", Offset = "0x60D298")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D298", Offset = "0x60D298")]
		public FsmBool canSetSkipOnDrop;

		[Token(Token = "0x40058E7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D2E8", Offset = "0x60D2E8")]
		public FsmEvent canSetSkipOnDropEvent;

		[Token(Token = "0x40058E8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D320", Offset = "0x60D320")]
		public FsmEvent canNotSetSkipOnDropEvent;

		[Token(Token = "0x40058E9")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D358", Offset = "0x60D358")]
		public bool everyFrame;

		[Token(Token = "0x40058EA")]
		[FieldOffset(Offset = "0x74")]
		private int _canSetSkipOnDrop;

		[Token(Token = "0x40058EB")]
		[FieldOffset(Offset = "0x78")]
		private GameObject go;

		[Token(Token = "0x40058EC")]
		[FieldOffset(Offset = "0x80")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006C63")]
		[Address(RVA = "0x13CCA68", Offset = "0x13CCA68", VA = "0x13CCA68", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C64")]
		[Address(RVA = "0x13CCA78", Offset = "0x13CCA78", VA = "0x13CCA78", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C65")]
		[Address(RVA = "0x13CCC04", Offset = "0x13CCC04", VA = "0x13CCC04", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C66")]
		[Address(RVA = "0x13CCB74", Offset = "0x13CCB74", VA = "0x13CCB74")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C67")]
		[Address(RVA = "0x13CCABC", Offset = "0x13CCABC", VA = "0x13CCABC")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C68")]
		[Address(RVA = "0x13CCC08", Offset = "0x13CCC08", VA = "0x13CCC08")]
		public VideoPlayerGetCanSkipOnDrop()
		{
		}
	}
}
