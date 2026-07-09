using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001173")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7AB8", Offset = "0x5A7AB8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7AB8", Offset = "0x5A7AB8")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x5A7AB8", Offset = "0x5A7AB8")]
	public class SendEventToFsm : FsmStateAction
	{
		[Token(Token = "0x40052D9")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F832C", Offset = "0x5F832C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40052DA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8378", Offset = "0x5F8378")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F8378", Offset = "0x5F8378")]
		public FsmString fsmName;

		[Token(Token = "0x40052DB")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F83C8", Offset = "0x5F83C8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F83C8", Offset = "0x5F83C8")]
		public FsmString sendEvent;

		[Token(Token = "0x40052DC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8428", Offset = "0x5F8428")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5F8428", Offset = "0x5F8428")]
		public FsmFloat delay;

		[Token(Token = "0x40052DD")]
		[FieldOffset(Offset = "0x70")]
		private bool requireReceiver;

		[Token(Token = "0x40052DE")]
		[FieldOffset(Offset = "0x78")]
		private GameObject go;

		[Token(Token = "0x40052DF")]
		[FieldOffset(Offset = "0x80")]
		private DelayedEvent delayedEvent;

		[Token(Token = "0x6006705")]
		[Address(RVA = "0xB70DC0", Offset = "0xB70DC0", VA = "0xB70DC0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006706")]
		[Address(RVA = "0xB70DD0", Offset = "0xB70DD0", VA = "0xB70DD0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006707")]
		[Address(RVA = "0xB7104C", Offset = "0xB7104C", VA = "0xB7104C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006708")]
		[Address(RVA = "0xB7108C", Offset = "0xB7108C", VA = "0xB7108C")]
		public SendEventToFsm()
		{
		}
	}
}
