using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012BA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE2F4", Offset = "0x5AE2F4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE2F4", Offset = "0x5AE2F4")]
	public class VideoPlayerSetTargetCamera : FsmStateAction
	{
		[Token(Token = "0x40059C2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610388", Offset = "0x610388")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x610388", Offset = "0x610388")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059C3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x61041C", Offset = "0x61041C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x61041C", Offset = "0x61041C")]
		[RequiredField]
		public FsmGameObject targetCamera;

		[Token(Token = "0x40059C4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6104B0", Offset = "0x6104B0")]
		public bool everyFrame;

		[Token(Token = "0x40059C5")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x40059C6")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D50")]
		[Address(RVA = "0x13D137C", Offset = "0x13D137C", VA = "0x13D137C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D51")]
		[Address(RVA = "0x13D1388", Offset = "0x13D1388", VA = "0x13D1388", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D52")]
		[Address(RVA = "0x13D159C", Offset = "0x13D159C", VA = "0x13D159C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006D53")]
		[Address(RVA = "0x13D1484", Offset = "0x13D1484", VA = "0x13D1484")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D54")]
		[Address(RVA = "0x13D13CC", Offset = "0x13D13CC", VA = "0x13D13CC")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D55")]
		[Address(RVA = "0x13D15A0", Offset = "0x13D15A0", VA = "0x13D15A0")]
		public VideoPlayerSetTargetCamera()
		{
		}
	}
}
