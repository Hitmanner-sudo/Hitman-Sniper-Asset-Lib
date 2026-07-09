using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012B6")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE1B4", Offset = "0x5AE1B4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE1B4", Offset = "0x5AE1B4")]
	public class VideoPlayerSetRenderMode : FsmStateAction
	{
		[Token(Token = "0x40059AE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60FE98", Offset = "0x60FE98")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60FE98", Offset = "0x60FE98")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059AF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60FF2C", Offset = "0x60FF2C")]
		[RequiredField]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x60FF2C", Offset = "0x60FF2C")]
		public FsmEnum renderMode;

		[Token(Token = "0x40059B0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60FFC0", Offset = "0x60FFC0")]
		public bool everyFrame;

		[Token(Token = "0x40059B1")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x40059B2")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D38")]
		[Address(RVA = "0x13D0C40", Offset = "0x13D0C40", VA = "0x13D0C40", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D39")]
		[Address(RVA = "0x13D0C4C", Offset = "0x13D0C4C", VA = "0x13D0C4C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D3A")]
		[Address(RVA = "0x13D0E28", Offset = "0x13D0E28", VA = "0x13D0E28", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006D3B")]
		[Address(RVA = "0x13D0D48", Offset = "0x13D0D48", VA = "0x13D0D48")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D3C")]
		[Address(RVA = "0x13D0C90", Offset = "0x13D0C90", VA = "0x13D0C90")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D3D")]
		[Address(RVA = "0x13D0E2C", Offset = "0x13D0E2C", VA = "0x13D0E2C")]
		public VideoPlayerSetRenderMode()
		{
		}
	}
}
