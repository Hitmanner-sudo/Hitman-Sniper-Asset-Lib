using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012A2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADB74", Offset = "0x5ADB74")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADB74", Offset = "0x5ADB74")]
	public class VideoPlayerGetTargetCamera : FsmStateAction
	{
		[Token(Token = "0x4005952")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60E9AC", Offset = "0x60E9AC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E9AC", Offset = "0x60E9AC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005953")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60EA40", Offset = "0x60EA40")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60EA40", Offset = "0x60EA40")]
		public FsmGameObject targetCamera;

		[Token(Token = "0x4005954")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60EAA0", Offset = "0x60EAA0")]
		public bool everyFrame;

		[Token(Token = "0x4005955")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x4005956")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006CC8")]
		[Address(RVA = "0x13CE498", Offset = "0x13CE498", VA = "0x13CE498", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006CC9")]
		[Address(RVA = "0x13CE4A4", Offset = "0x13CE4A4", VA = "0x13CE4A4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CCA")]
		[Address(RVA = "0x13CE6B4", Offset = "0x13CE6B4", VA = "0x13CE6B4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CCB")]
		[Address(RVA = "0x13CE5A0", Offset = "0x13CE5A0", VA = "0x13CE5A0")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CCC")]
		[Address(RVA = "0x13CE4E8", Offset = "0x13CE4E8", VA = "0x13CE4E8")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CCD")]
		[Address(RVA = "0x13CE6B8", Offset = "0x13CE6B8", VA = "0x13CE6B8")]
		public VideoPlayerGetTargetCamera()
		{
		}
	}
}
