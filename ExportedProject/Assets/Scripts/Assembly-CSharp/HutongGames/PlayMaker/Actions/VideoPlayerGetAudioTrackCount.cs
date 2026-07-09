using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200128E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD534", Offset = "0x5AD534")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD534", Offset = "0x5AD534")]
	public class VideoPlayerGetAudioTrackCount : FsmStateAction
	{
		[Token(Token = "0x40058D1")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60CD88", Offset = "0x60CD88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60CD88", Offset = "0x60CD88")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40058D2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60CE1C", Offset = "0x60CE1C")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60CE1C", Offset = "0x60CE1C")]
		public FsmInt audioTrackCount;

		[Token(Token = "0x40058D3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60CE7C", Offset = "0x60CE7C")]
		public FsmEvent isNotPrepared;

		[Token(Token = "0x40058D4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60CEB4", Offset = "0x60CEB4")]
		public bool everyFrame;

		[Token(Token = "0x40058D5")]
		[FieldOffset(Offset = "0x70")]
		private GameObject go;

		[Token(Token = "0x40058D6")]
		[FieldOffset(Offset = "0x78")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006C51")]
		[Address(RVA = "0x13CC0C4", Offset = "0x13CC0C4", VA = "0x13CC0C4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C52")]
		[Address(RVA = "0x13CC0D0", Offset = "0x13CC0D0", VA = "0x13CC0D0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C53")]
		[Address(RVA = "0x13CC29C", Offset = "0x13CC29C", VA = "0x13CC29C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C54")]
		[Address(RVA = "0x13CC1CC", Offset = "0x13CC1CC", VA = "0x13CC1CC")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C55")]
		[Address(RVA = "0x13CC114", Offset = "0x13CC114", VA = "0x13CC114")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006C56")]
		[Address(RVA = "0x13CC2A0", Offset = "0x13CC2A0", VA = "0x13CC2A0")]
		public VideoPlayerGetAudioTrackCount()
		{
		}
	}
}
