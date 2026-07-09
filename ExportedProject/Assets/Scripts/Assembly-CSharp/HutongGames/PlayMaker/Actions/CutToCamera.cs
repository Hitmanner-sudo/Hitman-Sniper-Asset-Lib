using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F3B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C178", Offset = "0x59C178")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C178", Offset = "0x59C178")]
	public class CutToCamera : FsmStateAction
	{
		[Token(Token = "0x40047DF")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC9D4", Offset = "0x5CC9D4")]
		public Camera camera;

		[Token(Token = "0x40047E0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCA20", Offset = "0x5CCA20")]
		public bool makeMainCamera;

		[Token(Token = "0x40047E1")]
		[FieldOffset(Offset = "0x59")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCA58", Offset = "0x5CCA58")]
		public bool cutBackOnExit;

		[Token(Token = "0x40047E2")]
		[FieldOffset(Offset = "0x60")]
		private Camera oldCamera;

		[Token(Token = "0x6005D41")]
		[Address(RVA = "0xBBB5B0", Offset = "0xBBB5B0", VA = "0xBBB5B0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D42")]
		[Address(RVA = "0xBBB5C0", Offset = "0xBBB5C0", VA = "0xBBB5C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D43")]
		[Address(RVA = "0xBBB798", Offset = "0xBBB798", VA = "0xBBB798", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005D44")]
		[Address(RVA = "0xBBB6B8", Offset = "0xBBB6B8", VA = "0xBBB6B8")]
		private static void SwitchCamera(Camera camera1, Camera camera2)
		{
		}

		[Token(Token = "0x6005D45")]
		[Address(RVA = "0xBBB7B4", Offset = "0xBBB7B4", VA = "0xBBB7B4")]
		public CutToCamera()
		{
		}
	}
}
