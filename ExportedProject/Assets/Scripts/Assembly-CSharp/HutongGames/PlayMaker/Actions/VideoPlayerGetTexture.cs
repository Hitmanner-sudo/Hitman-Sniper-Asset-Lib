using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012A6")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADCB4", Offset = "0x5ADCB4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADCB4", Offset = "0x5ADCB4")]
	public class VideoPlayerGetTexture : FsmStateAction
	{
		[Token(Token = "0x4005966")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60EE5C", Offset = "0x60EE5C")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60EE5C", Offset = "0x60EE5C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005967")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60EEF0", Offset = "0x60EEF0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60EEF0", Offset = "0x60EEF0")]
		public FsmTexture texture;

		[Token(Token = "0x4005968")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60EF50", Offset = "0x60EF50")]
		public bool everyFrame;

		[Token(Token = "0x4005969")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x400596A")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006CE0")]
		[Address(RVA = "0x13CEBCC", Offset = "0x13CEBCC", VA = "0x13CEBCC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CE1")]
		[Address(RVA = "0x13CEBD8", Offset = "0x13CEBD8", VA = "0x13CEBD8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CE2")]
		[Address(RVA = "0x13CED7C", Offset = "0x13CED7C", VA = "0x13CED7C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CE3")]
		[Address(RVA = "0x13CECD4", Offset = "0x13CECD4", VA = "0x13CECD4")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CE4")]
		[Address(RVA = "0x13CEC1C", Offset = "0x13CEC1C", VA = "0x13CEC1C")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CE5")]
		[Address(RVA = "0x13CED80", Offset = "0x13CED80", VA = "0x13CED80")]
		public VideoPlayerGetTexture()
		{
		}
	}
}
