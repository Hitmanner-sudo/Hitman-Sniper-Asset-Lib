using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200129C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD994", Offset = "0x5AD994")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD994", Offset = "0x5AD994")]
	public class VideoPlayerGetPlayOnAwake : FsmStateAction
	{
		[Token(Token = "0x400592B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E0F4", Offset = "0x60E0F4")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60E0F4", Offset = "0x60E0F4")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400592C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E188", Offset = "0x60E188")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60E188", Offset = "0x60E188")]
		public FsmBool isPlayingOnAwake;

		[Token(Token = "0x400592D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E1D8", Offset = "0x60E1D8")]
		public FsmEvent isPlayingOnAwakeEvent;

		[Token(Token = "0x400592E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E210", Offset = "0x60E210")]
		public FsmEvent isNotPlayingOnAwakeEvent;

		[Token(Token = "0x400592F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E248", Offset = "0x60E248")]
		public bool everyframe;

		[Token(Token = "0x4005930")]
		[FieldOffset(Offset = "0x78")]
		private GameObject go;

		[Token(Token = "0x4005931")]
		[FieldOffset(Offset = "0x80")]
		private VideoPlayer _vp;

		[Token(Token = "0x4005932")]
		[FieldOffset(Offset = "0x88")]
		private int _isPlayingOnAwake;

		[Token(Token = "0x6006CA4")]
		[Address(RVA = "0x13CD934", Offset = "0x13CD934", VA = "0x13CD934", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CA5")]
		[Address(RVA = "0x13CD944", Offset = "0x13CD944", VA = "0x13CD944", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CA6")]
		[Address(RVA = "0x13CDB28", Offset = "0x13CDB28", VA = "0x13CDB28", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CA7")]
		[Address(RVA = "0x13CDA40", Offset = "0x13CDA40", VA = "0x13CDA40")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CA8")]
		[Address(RVA = "0x13CD988", Offset = "0x13CD988", VA = "0x13CD988")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CA9")]
		[Address(RVA = "0x13CDB2C", Offset = "0x13CDB2C", VA = "0x13CDB2C")]
		public VideoPlayerGetPlayOnAwake()
		{
		}
	}
}
