using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FD0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59EEF0", Offset = "0x59EEF0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59EEF0", Offset = "0x59EEF0")]
	public class DestroyComponent : FsmStateAction
	{
		[Token(Token = "0x4004A6E")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D64B8", Offset = "0x5D64B8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004A6F")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6504", Offset = "0x5D6504")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D6504", Offset = "0x5D6504")]
		public FsmString component;

		[Token(Token = "0x4004A70")]
		[FieldOffset(Offset = "0x60")]
		private Component aComponent;

		[Token(Token = "0x6005F76")]
		[Address(RVA = "0xC12DC0", Offset = "0xC12DC0", VA = "0xC12DC0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F77")]
		[Address(RVA = "0xC12DCC", Offset = "0xC12DCC", VA = "0xC12DCC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F78")]
		[Address(RVA = "0xC12E28", Offset = "0xC12E28", VA = "0xC12E28")]
		private void DoDestroyComponent(GameObject go)
		{
		}

		[Token(Token = "0x6005F79")]
		[Address(RVA = "0xC12F8C", Offset = "0xC12F8C", VA = "0xC12F8C")]
		public DestroyComponent()
		{
		}
	}
}
