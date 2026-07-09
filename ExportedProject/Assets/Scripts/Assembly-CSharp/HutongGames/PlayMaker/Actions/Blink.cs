using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F88")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D79C", Offset = "0x59D79C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D79C", Offset = "0x59D79C")]
	public class Blink : ComponentAction<Renderer>
	{
		[Token(Token = "0x400495D")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D263C", Offset = "0x5D263C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400495E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2688", Offset = "0x5D2688")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D2688", Offset = "0x5D2688")]
		public FsmFloat timeOff;

		[Token(Token = "0x400495F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D26DC", Offset = "0x5D26DC")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D26DC", Offset = "0x5D26DC")]
		public FsmFloat timeOn;

		[Token(Token = "0x4004960")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2730", Offset = "0x5D2730")]
		public FsmBool startOn;

		[Token(Token = "0x4004961")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2768", Offset = "0x5D2768")]
		public bool rendererOnly;

		[Token(Token = "0x4004962")]
		[FieldOffset(Offset = "0x89")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D27A0", Offset = "0x5D27A0")]
		public bool realTime;

		[Token(Token = "0x4004963")]
		[FieldOffset(Offset = "0x8C")]
		private float startTime;

		[Token(Token = "0x4004964")]
		[FieldOffset(Offset = "0x90")]
		private float timer;

		[Token(Token = "0x4004965")]
		[FieldOffset(Offset = "0x94")]
		private bool blinkOn;

		[Token(Token = "0x6005E84")]
		[Address(RVA = "0xC67184", Offset = "0xC67184", VA = "0xC67184", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E85")]
		[Address(RVA = "0xC671EC", Offset = "0xC671EC", VA = "0xC671EC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E86")]
		[Address(RVA = "0xC67370", Offset = "0xC67370", VA = "0xC67370", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E87")]
		[Address(RVA = "0xC67234", Offset = "0xC67234", VA = "0xC67234")]
		private void UpdateBlinkState(bool state)
		{
		}

		[Token(Token = "0x6005E88")]
		[Address(RVA = "0xC67430", Offset = "0xC67430", VA = "0xC67430")]
		public Blink()
		{
		}
	}
}
