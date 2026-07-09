using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012A1")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADB24", Offset = "0x5ADB24")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADB24", Offset = "0x5ADB24")]
	public class VideoPlayerGetSource : FsmStateAction
	{
		[Token(Token = "0x400594D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E838", Offset = "0x60E838")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60E838", Offset = "0x60E838")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400594E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x60E8CC", Offset = "0x60E8CC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60E8CC", Offset = "0x60E8CC")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E8CC", Offset = "0x60E8CC")]
		public FsmEnum source;

		[Token(Token = "0x400594F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E974", Offset = "0x60E974")]
		public bool everyFrame;

		[Token(Token = "0x4005950")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x4005951")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006CC2")]
		[Address(RVA = "0x13CE2B4", Offset = "0x13CE2B4", VA = "0x13CE2B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CC3")]
		[Address(RVA = "0x13CE2C0", Offset = "0x13CE2C0", VA = "0x13CE2C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CC4")]
		[Address(RVA = "0x13CE48C", Offset = "0x13CE48C", VA = "0x13CE48C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CC5")]
		[Address(RVA = "0x13CE3BC", Offset = "0x13CE3BC", VA = "0x13CE3BC")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CC6")]
		[Address(RVA = "0x13CE304", Offset = "0x13CE304", VA = "0x13CE304")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CC7")]
		[Address(RVA = "0x13CE490", Offset = "0x13CE490", VA = "0x13CE490")]
		public VideoPlayerGetSource()
		{
		}
	}
}
