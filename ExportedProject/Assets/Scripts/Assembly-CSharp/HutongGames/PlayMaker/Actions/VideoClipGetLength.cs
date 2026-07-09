using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001286")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD2B4", Offset = "0x5AD2B4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD2B4", Offset = "0x5AD2B4")]
	public class VideoClipGetLength : FsmStateAction
	{
		[Token(Token = "0x40058A4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C388", Offset = "0x60C388")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60C388", Offset = "0x60C388")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40058A5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60C40C", Offset = "0x60C40C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C40C", Offset = "0x60C40C")]
		public FsmObject orVideoClip;

		[Token(Token = "0x40058A6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60C45C", Offset = "0x60C45C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C45C", Offset = "0x60C45C")]
		public FsmFloat length;

		[Token(Token = "0x40058A7")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C4AC", Offset = "0x60C4AC")]
		public bool everyFrame;

		[Token(Token = "0x40058A8")]
		[FieldOffset(Offset = "0x70")]
		private GameObject go;

		[Token(Token = "0x40058A9")]
		[FieldOffset(Offset = "0x78")]
		private VideoPlayer _vp;

		[Token(Token = "0x40058AA")]
		[FieldOffset(Offset = "0x80")]
		private VideoClip _vc;

		[Token(Token = "0x6006C21")]
		[Address(RVA = "0x13CA970", Offset = "0x13CA970", VA = "0x13CA970", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C22")]
		[Address(RVA = "0x13CA9E4", Offset = "0x13CA9E4", VA = "0x13CA9E4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C23")]
		[Address(RVA = "0x13CAC20", Offset = "0x13CAC20", VA = "0x13CAC20", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C24")]
		[Address(RVA = "0x13CAB88", Offset = "0x13CAB88", VA = "0x13CAB88")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C25")]
		[Address(RVA = "0x13CAA28", Offset = "0x13CAA28", VA = "0x13CAA28")]
		private void GetVideoClip()
		{
		}

		[Token(Token = "0x6006C26")]
		[Address(RVA = "0x13CAC44", Offset = "0x13CAC44", VA = "0x13CAC44")]
		public VideoClipGetLength()
		{
		}
	}
}
