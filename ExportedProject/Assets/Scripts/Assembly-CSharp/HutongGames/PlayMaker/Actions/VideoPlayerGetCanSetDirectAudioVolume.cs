using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200128F")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD584", Offset = "0x5AD584")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD584", Offset = "0x5AD584")]
	public class VideoPlayerGetCanSetDirectAudioVolume : FsmStateAction
	{
		[Token(Token = "0x40058D7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60CEEC", Offset = "0x60CEEC")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60CEEC", Offset = "0x60CEEC")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40058D8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60CF80", Offset = "0x60CF80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60CF80", Offset = "0x60CF80")]
		public FsmBool canSetDirectAudioVolume;

		[Token(Token = "0x40058D9")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60CFD0", Offset = "0x60CFD0")]
		public FsmEvent canSetDirectAudioVolumeEvent;

		[Token(Token = "0x40058DA")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D008", Offset = "0x60D008")]
		public FsmEvent canNotSetDirectAudioVolumeEvent;

		[Token(Token = "0x40058DB")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60D040", Offset = "0x60D040")]
		public bool everyFrame;

		[Token(Token = "0x40058DC")]
		[FieldOffset(Offset = "0x78")]
		private GameObject go;

		[Token(Token = "0x40058DD")]
		[FieldOffset(Offset = "0x80")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006C57")]
		[Address(RVA = "0x13CC2A8", Offset = "0x13CC2A8", VA = "0x13CC2A8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C58")]
		[Address(RVA = "0x13CC2B8", Offset = "0x13CC2B8", VA = "0x13CC2B8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C59")]
		[Address(RVA = "0x13CC48C", Offset = "0x13CC48C", VA = "0x13CC48C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C5A")]
		[Address(RVA = "0x13CC3B4", Offset = "0x13CC3B4", VA = "0x13CC3B4")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C5B")]
		[Address(RVA = "0x13CC2FC", Offset = "0x13CC2FC", VA = "0x13CC2FC")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C5C")]
		[Address(RVA = "0x13CC490", Offset = "0x13CC490", VA = "0x13CC490")]
		public VideoPlayerGetCanSetDirectAudioVolume()
		{
		}
	}
}
