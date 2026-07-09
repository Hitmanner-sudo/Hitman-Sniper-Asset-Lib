using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200129D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD9E4", Offset = "0x5AD9E4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD9E4", Offset = "0x5AD9E4")]
	public class VideoPlayerGetPlaybackSpeed : FsmStateAction
	{
		[Token(Token = "0x4005933")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60E280", Offset = "0x60E280")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E280", Offset = "0x60E280")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005934")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60E314", Offset = "0x60E314")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E314", Offset = "0x60E314")]
		public FsmFloat playbackSpeed;

		[Token(Token = "0x4005935")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E374", Offset = "0x60E374")]
		public bool everyFrame;

		[Token(Token = "0x4005936")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x4005937")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006CAA")]
		[Address(RVA = "0x13CDB3C", Offset = "0x13CDB3C", VA = "0x13CDB3C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CAB")]
		[Address(RVA = "0x13CDB48", Offset = "0x13CDB48", VA = "0x13CDB48", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CAC")]
		[Address(RVA = "0x13CDCD8", Offset = "0x13CDCD8", VA = "0x13CDCD8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CAD")]
		[Address(RVA = "0x13CDC44", Offset = "0x13CDC44", VA = "0x13CDC44")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CAE")]
		[Address(RVA = "0x13CDB8C", Offset = "0x13CDB8C", VA = "0x13CDB8C")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CAF")]
		[Address(RVA = "0x13CDCDC", Offset = "0x13CDCDC", VA = "0x13CDCDC")]
		public VideoPlayerGetPlaybackSpeed()
		{
		}
	}
}
