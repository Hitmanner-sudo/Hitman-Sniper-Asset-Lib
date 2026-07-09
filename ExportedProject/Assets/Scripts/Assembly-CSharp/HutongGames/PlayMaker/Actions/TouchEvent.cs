using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F84")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D628", Offset = "0x59D628")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D628", Offset = "0x59D628")]
	public class TouchEvent : FsmStateAction
	{
		[Token(Token = "0x400493A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1D9C", Offset = "0x5D1D9C")]
		public FsmInt fingerId;

		[Token(Token = "0x400493B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1DD4", Offset = "0x5D1DD4")]
		public TouchPhase touchPhase;

		[Token(Token = "0x400493C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1E0C", Offset = "0x5D1E0C")]
		public FsmEvent sendEvent;

		[Token(Token = "0x400493D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1E44", Offset = "0x5D1E44")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D1E44", Offset = "0x5D1E44")]
		public FsmInt storeFingerId;

		[Token(Token = "0x6005E7B")]
		[Address(RVA = "0xAD6AE4", Offset = "0xAD6AE4", VA = "0xAD6AE4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E7C")]
		[Address(RVA = "0xAD6B54", Offset = "0xAD6B54", VA = "0xAD6B54", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E7D")]
		[Address(RVA = "0xAD6C90", Offset = "0xAD6C90", VA = "0xAD6C90")]
		public TouchEvent()
		{
		}
	}
}
