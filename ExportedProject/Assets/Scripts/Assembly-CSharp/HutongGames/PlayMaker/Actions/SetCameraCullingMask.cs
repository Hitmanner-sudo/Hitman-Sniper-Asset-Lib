using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F3F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C320", Offset = "0x59C320")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C320", Offset = "0x59C320")]
	public class SetCameraCullingMask : ComponentAction<Camera>
	{
		[Token(Token = "0x40047F1")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCEB0", Offset = "0x5CCEB0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CCEB0", Offset = "0x5CCEB0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40047F2")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCF44", Offset = "0x5CCF44")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CCF44", Offset = "0x5CCF44")]
		public FsmInt[] cullingMask;

		[Token(Token = "0x40047F3")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCF94", Offset = "0x5CCF94")]
		public FsmBool invertMask;

		[Token(Token = "0x40047F4")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCFCC", Offset = "0x5CCFCC")]
		public bool everyFrame;

		[Token(Token = "0x6005D53")]
		[Address(RVA = "0x10384CC", Offset = "0x10384CC", VA = "0x10384CC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D54")]
		[Address(RVA = "0x1038538", Offset = "0x1038538", VA = "0x1038538", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D55")]
		[Address(RVA = "0x103864C", Offset = "0x103864C", VA = "0x103864C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D56")]
		[Address(RVA = "0x1038574", Offset = "0x1038574", VA = "0x1038574")]
		private void DoSetCameraCullingMask()
		{
		}

		[Token(Token = "0x6005D57")]
		[Address(RVA = "0x1038650", Offset = "0x1038650", VA = "0x1038650")]
		public SetCameraCullingMask()
		{
		}
	}
}
