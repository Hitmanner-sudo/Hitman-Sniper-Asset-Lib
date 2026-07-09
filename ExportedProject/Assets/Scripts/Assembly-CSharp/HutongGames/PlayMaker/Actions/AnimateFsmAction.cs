using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EA4")]
	public abstract class AnimateFsmAction : FsmStateAction
	{
		[Token(Token = "0x2000EA5")]
		public enum Calculation
		{
			[Token(Token = "0x40044FE")]
			None = 0,
			[Token(Token = "0x40044FF")]
			SetValue = 1,
			[Token(Token = "0x4004500")]
			AddToValue = 2,
			[Token(Token = "0x4004501")]
			SubtractFromValue = 3,
			[Token(Token = "0x4004502")]
			SubtractValueFromCurve = 4,
			[Token(Token = "0x4004503")]
			MultiplyValue = 5,
			[Token(Token = "0x4004504")]
			DivideValue = 6,
			[Token(Token = "0x4004505")]
			DivideCurveByValue = 7
		}

		[Token(Token = "0x40044E6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0B00", Offset = "0x5C0B00")]
		public FsmFloat time;

		[Token(Token = "0x40044E7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0B38", Offset = "0x5C0B38")]
		public FsmFloat speed;

		[Token(Token = "0x40044E8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0B70", Offset = "0x5C0B70")]
		public FsmFloat delay;

		[Token(Token = "0x40044E9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0BA8", Offset = "0x5C0BA8")]
		public FsmBool ignoreCurveOffset;

		[Token(Token = "0x40044EA")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0BE0", Offset = "0x5C0BE0")]
		public FsmEvent finishEvent;

		[Token(Token = "0x40044EB")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0C18", Offset = "0x5C0C18")]
		public bool realTime;

		[Token(Token = "0x40044EC")]
		[FieldOffset(Offset = "0x7C")]
		private float startTime;

		[Token(Token = "0x40044ED")]
		[FieldOffset(Offset = "0x80")]
		private float currentTime;

		[Token(Token = "0x40044EE")]
		[FieldOffset(Offset = "0x88")]
		private float[] endTimes;

		[Token(Token = "0x40044EF")]
		[FieldOffset(Offset = "0x90")]
		private float lastTime;

		[Token(Token = "0x40044F0")]
		[FieldOffset(Offset = "0x94")]
		private float deltaTime;

		[Token(Token = "0x40044F1")]
		[FieldOffset(Offset = "0x98")]
		private float delayTime;

		[Token(Token = "0x40044F2")]
		[FieldOffset(Offset = "0xA0")]
		private float[] keyOffsets;

		[Token(Token = "0x40044F3")]
		[FieldOffset(Offset = "0xA8")]
		protected AnimationCurve[] curves;

		[Token(Token = "0x40044F4")]
		[FieldOffset(Offset = "0xB0")]
		protected Calculation[] calculations;

		[Token(Token = "0x40044F5")]
		[FieldOffset(Offset = "0xB8")]
		protected float[] resultFloats;

		[Token(Token = "0x40044F6")]
		[FieldOffset(Offset = "0xC0")]
		protected float[] fromFloats;

		[Token(Token = "0x40044F7")]
		[FieldOffset(Offset = "0xC8")]
		protected float[] toFloats;

		[Token(Token = "0x40044F8")]
		[FieldOffset(Offset = "0xD0")]
		protected bool finishAction;

		[Token(Token = "0x40044F9")]
		[FieldOffset(Offset = "0xD1")]
		protected bool isRunning;

		[Token(Token = "0x40044FA")]
		[FieldOffset(Offset = "0xD2")]
		protected bool looping;

		[Token(Token = "0x40044FB")]
		[FieldOffset(Offset = "0xD3")]
		private bool start;

		[Token(Token = "0x40044FC")]
		[FieldOffset(Offset = "0xD4")]
		private float largestEndTime;

		[Token(Token = "0x6005A83")]
		[Address(RVA = "0xD41FA0", Offset = "0xD41FA0", VA = "0xD41FA0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005A84")]
		[Address(RVA = "0xD424C0", Offset = "0xD424C0", VA = "0xD424C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005A85")]
		[Address(RVA = "0xD42548", Offset = "0xD42548", VA = "0xD42548")]
		protected void Init()
		{
		}

		[Token(Token = "0x6005A86")]
		[Address(RVA = "0xD42B6C", Offset = "0xD42B6C", VA = "0xD42B6C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005A87")]
		[Address(RVA = "0xD43B00", Offset = "0xD43B00", VA = "0xD43B00")]
		private void CheckStart()
		{
		}

		[Token(Token = "0x6005A88")]
		[Address(RVA = "0xD43BAC", Offset = "0xD43BAC", VA = "0xD43BAC")]
		private void UpdateTime()
		{
		}

		[Token(Token = "0x6005A89")]
		[Address(RVA = "0xD4309C", Offset = "0xD4309C", VA = "0xD4309C")]
		public void UpdateAnimation()
		{
		}

		[Token(Token = "0x6005A8A")]
		[Address(RVA = "0xD43CA8", Offset = "0xD43CA8", VA = "0xD43CA8")]
		private void CheckFinished()
		{
		}

		[Token(Token = "0x6005A8B")]
		[Address(RVA = "0xD42BBC", Offset = "0xD42BBC", VA = "0xD42BBC")]
		protected AnimateFsmAction()
		{
		}
	}
}
