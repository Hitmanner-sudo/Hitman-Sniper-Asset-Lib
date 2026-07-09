using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012AE")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ADF34", Offset = "0x5ADF34")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ADF34", Offset = "0x5ADF34")]
	public class VideoPlayerPlay : FsmStateAction
	{
		[Token(Token = "0x400598E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60F76C", Offset = "0x60F76C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60F76C", Offset = "0x60F76C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400598F")]
		[FieldOffset(Offset = "0x58")]
		private GameObject go;

		[Token(Token = "0x4005990")]
		[FieldOffset(Offset = "0x60")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D0E")]
		[Address(RVA = "0x13CFB10", Offset = "0x13CFB10", VA = "0x13CFB10", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D0F")]
		[Address(RVA = "0x13CFB18", Offset = "0x13CFB18", VA = "0x13CFB18", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D10")]
		[Address(RVA = "0x13CFBB0", Offset = "0x13CFBB0", VA = "0x13CFBB0")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D11")]
		[Address(RVA = "0x13CFC68", Offset = "0x13CFC68", VA = "0x13CFC68")]
		public VideoPlayerPlay()
		{
		}
	}
}
