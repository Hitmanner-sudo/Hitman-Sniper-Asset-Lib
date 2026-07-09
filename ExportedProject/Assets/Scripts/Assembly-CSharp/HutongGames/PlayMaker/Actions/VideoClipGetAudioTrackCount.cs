using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001283")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD1C4", Offset = "0x5AD1C4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD1C4", Offset = "0x5AD1C4")]
	public class VideoClipGetAudioTrackCount : FsmStateAction
	{
		[Token(Token = "0x400588F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60BF74", Offset = "0x60BF74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BF74", Offset = "0x60BF74")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005890")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BFF8", Offset = "0x60BFF8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60BFF8", Offset = "0x60BFF8")]
		public FsmObject orVideoClip;

		[Token(Token = "0x4005891")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60C048", Offset = "0x60C048")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C048", Offset = "0x60C048")]
		public FsmInt audioTrackCount;

		[Token(Token = "0x4005892")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C098", Offset = "0x60C098")]
		public bool everyFrame;

		[Token(Token = "0x4005893")]
		[FieldOffset(Offset = "0x70")]
		private GameObject go;

		[Token(Token = "0x4005894")]
		[FieldOffset(Offset = "0x78")]
		private VideoPlayer _vp;

		[Token(Token = "0x4005895")]
		[FieldOffset(Offset = "0x80")]
		private VideoClip _vc;

		[Token(Token = "0x6006C0F")]
		[Address(RVA = "0x13CA0E0", Offset = "0x13CA0E0", VA = "0x13CA0E0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C10")]
		[Address(RVA = "0x13CA154", Offset = "0x13CA154", VA = "0x13CA154", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C11")]
		[Address(RVA = "0x13CA390", Offset = "0x13CA390", VA = "0x13CA390", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C12")]
		[Address(RVA = "0x13CA2F8", Offset = "0x13CA2F8", VA = "0x13CA2F8")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C13")]
		[Address(RVA = "0x13CA198", Offset = "0x13CA198", VA = "0x13CA198")]
		private void GetVideoClip()
		{
		}

		[Token(Token = "0x6006C14")]
		[Address(RVA = "0x13CA3B4", Offset = "0x13CA3B4", VA = "0x13CA3B4")]
		public VideoClipGetAudioTrackCount()
		{
		}
	}
}
