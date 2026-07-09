using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012A4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADC14", Offset = "0x5ADC14")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADC14", Offset = "0x5ADC14")]
	public class VideoPlayerGetTargetMaterialProperty : FsmStateAction
	{
		[Token(Token = "0x400595C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60EC04", Offset = "0x60EC04")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60EC04", Offset = "0x60EC04")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400595D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60EC98", Offset = "0x60EC98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60EC98", Offset = "0x60EC98")]
		[RequiredField]
		public FsmString property;

		[Token(Token = "0x400595E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60ECF8", Offset = "0x60ECF8")]
		public bool everyFrame;

		[Token(Token = "0x400595F")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x4005960")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006CD4")]
		[Address(RVA = "0x13CE868", Offset = "0x13CE868", VA = "0x13CE868", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CD5")]
		[Address(RVA = "0x13CE874", Offset = "0x13CE874", VA = "0x13CE874", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CD6")]
		[Address(RVA = "0x13CEA04", Offset = "0x13CEA04", VA = "0x13CEA04", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CD7")]
		[Address(RVA = "0x13CE970", Offset = "0x13CE970", VA = "0x13CE970")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CD8")]
		[Address(RVA = "0x13CE8B8", Offset = "0x13CE8B8", VA = "0x13CE8B8")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CD9")]
		[Address(RVA = "0x13CEA08", Offset = "0x13CEA08", VA = "0x13CEA08")]
		public VideoPlayerGetTargetMaterialProperty()
		{
		}
	}
}
