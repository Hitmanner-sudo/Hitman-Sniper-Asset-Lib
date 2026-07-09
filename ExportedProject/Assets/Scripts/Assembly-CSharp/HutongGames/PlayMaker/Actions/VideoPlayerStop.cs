using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012C5")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE664", Offset = "0x5AE664")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE664", Offset = "0x5AE664")]
	public class VideoPlayerStop : FsmStateAction
	{
		[Token(Token = "0x40059F3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610EE4", Offset = "0x610EE4")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x610EE4", Offset = "0x610EE4")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059F4")]
		[FieldOffset(Offset = "0x58")]
		private GameObject go;

		[Token(Token = "0x40059F5")]
		[FieldOffset(Offset = "0x60")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D8A")]
		[Address(RVA = "0x9786BC", Offset = "0x9786BC", VA = "0x9786BC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D8B")]
		[Address(RVA = "0x9786C4", Offset = "0x9786C4", VA = "0x9786C4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D8C")]
		[Address(RVA = "0x97875C", Offset = "0x97875C", VA = "0x97875C")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D8D")]
		[Address(RVA = "0x978814", Offset = "0x978814", VA = "0x978814")]
		public VideoPlayerStop()
		{
		}
	}
}
