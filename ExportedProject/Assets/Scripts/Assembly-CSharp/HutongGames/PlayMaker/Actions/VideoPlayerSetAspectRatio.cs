using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012B2")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE074", Offset = "0x5AE074")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE074", Offset = "0x5AE074")]
	public class VideoPlayerSetAspectRatio : FsmStateAction
	{
		[Token(Token = "0x400599C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60FA2C", Offset = "0x60FA2C")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60FA2C", Offset = "0x60FA2C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400599D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x60FAC0", Offset = "0x60FAC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60FAC0", Offset = "0x60FAC0")]
		[RequiredField]
		public FsmEnum aspectRatio;

		[Token(Token = "0x400599E")]
		[FieldOffset(Offset = "0x60")]
		private GameObject go;

		[Token(Token = "0x400599F")]
		[FieldOffset(Offset = "0x68")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D22")]
		[Address(RVA = "0x13D0450", Offset = "0x13D0450", VA = "0x13D0450", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D23")]
		[Address(RVA = "0x13D04BC", Offset = "0x13D04BC", VA = "0x13D04BC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D24")]
		[Address(RVA = "0x13D05A4", Offset = "0x13D05A4", VA = "0x13D05A4")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D25")]
		[Address(RVA = "0x13D04EC", Offset = "0x13D04EC", VA = "0x13D04EC")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D26")]
		[Address(RVA = "0x13D0684", Offset = "0x13D0684", VA = "0x13D0684")]
		public VideoPlayerSetAspectRatio()
		{
		}
	}
}
