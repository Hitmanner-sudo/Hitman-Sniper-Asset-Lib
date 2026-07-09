using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012A0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADAD4", Offset = "0x5ADAD4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADAD4", Offset = "0x5ADAD4")]
	public class VideoPlayerGetSkipOnDrop : FsmStateAction
	{
		[Token(Token = "0x4005945")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60E6AC", Offset = "0x60E6AC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E6AC", Offset = "0x60E6AC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005946")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E740", Offset = "0x60E740")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60E740", Offset = "0x60E740")]
		public FsmBool skipOnDrop;

		[Token(Token = "0x4005947")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E790", Offset = "0x60E790")]
		public FsmEvent doesSkipOnDropEvent;

		[Token(Token = "0x4005948")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E7C8", Offset = "0x60E7C8")]
		public FsmEvent DoNotSkipOnDropEvent;

		[Token(Token = "0x4005949")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E800", Offset = "0x60E800")]
		public bool everyFrame;

		[Token(Token = "0x400594A")]
		[FieldOffset(Offset = "0x74")]
		private int _canSetSkipOnDrop;

		[Token(Token = "0x400594B")]
		[FieldOffset(Offset = "0x78")]
		private GameObject go;

		[Token(Token = "0x400594C")]
		[FieldOffset(Offset = "0x80")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006CBC")]
		[Address(RVA = "0x13CE0AC", Offset = "0x13CE0AC", VA = "0x13CE0AC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CBD")]
		[Address(RVA = "0x13CE0BC", Offset = "0x13CE0BC", VA = "0x13CE0BC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CBE")]
		[Address(RVA = "0x13CE2A0", Offset = "0x13CE2A0", VA = "0x13CE2A0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CBF")]
		[Address(RVA = "0x13CE1B8", Offset = "0x13CE1B8", VA = "0x13CE1B8")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CC0")]
		[Address(RVA = "0x13CE100", Offset = "0x13CE100", VA = "0x13CE100")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CC1")]
		[Address(RVA = "0x13CE2A4", Offset = "0x13CE2A4", VA = "0x13CE2A4")]
		public VideoPlayerGetSkipOnDrop()
		{
		}
	}
}
