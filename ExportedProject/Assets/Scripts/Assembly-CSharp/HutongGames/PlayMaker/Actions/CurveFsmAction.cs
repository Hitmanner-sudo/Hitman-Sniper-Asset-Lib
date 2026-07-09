using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EAA")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5995E0", Offset = "0x5995E0")]
	public abstract class CurveFsmAction : FsmStateAction
	{
		[Token(Token = "0x2000EAB")]
		public enum Calculation
		{
			[Token(Token = "0x4004544")]
			None = 0,
			[Token(Token = "0x4004545")]
			AddToValue = 1,
			[Token(Token = "0x4004546")]
			SubtractFromValue = 2,
			[Token(Token = "0x4004547")]
			SubtractValueFromCurve = 3,
			[Token(Token = "0x4004548")]
			MultiplyValue = 4,
			[Token(Token = "0x4004549")]
			DivideValue = 5,
			[Token(Token = "0x400454A")]
			DivideCurveByValue = 6
		}

		[Token(Token = "0x400452B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1530", Offset = "0x5C1530")]
		public FsmFloat time;

		[Token(Token = "0x400452C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1568", Offset = "0x5C1568")]
		public FsmFloat speed;

		[Token(Token = "0x400452D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C15A0", Offset = "0x5C15A0")]
		public FsmFloat delay;

		[Token(Token = "0x400452E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C15D8", Offset = "0x5C15D8")]
		public FsmBool ignoreCurveOffset;

		[Token(Token = "0x400452F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1610", Offset = "0x5C1610")]
		public FsmEvent finishEvent;

		[Token(Token = "0x4004530")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1648", Offset = "0x5C1648")]
		public bool realTime;

		[Token(Token = "0x4004531")]
		[FieldOffset(Offset = "0x7C")]
		private float startTime;

		[Token(Token = "0x4004532")]
		[FieldOffset(Offset = "0x80")]
		private float currentTime;

		[Token(Token = "0x4004533")]
		[FieldOffset(Offset = "0x88")]
		private float[] endTimes;

		[Token(Token = "0x4004534")]
		[FieldOffset(Offset = "0x90")]
		private float lastTime;

		[Token(Token = "0x4004535")]
		[FieldOffset(Offset = "0x94")]
		private float deltaTime;

		[Token(Token = "0x4004536")]
		[FieldOffset(Offset = "0x98")]
		private float delayTime;

		[Token(Token = "0x4004537")]
		[FieldOffset(Offset = "0xA0")]
		private float[] keyOffsets;

		[Token(Token = "0x4004538")]
		[FieldOffset(Offset = "0xA8")]
		protected AnimationCurve[] curves;

		[Token(Token = "0x4004539")]
		[FieldOffset(Offset = "0xB0")]
		protected Calculation[] calculations;

		[Token(Token = "0x400453A")]
		[FieldOffset(Offset = "0xB8")]
		protected float[] resultFloats;

		[Token(Token = "0x400453B")]
		[FieldOffset(Offset = "0xC0")]
		protected float[] fromFloats;

		[Token(Token = "0x400453C")]
		[FieldOffset(Offset = "0xC8")]
		protected float[] toFloats;

		[Token(Token = "0x400453D")]
		[FieldOffset(Offset = "0xD0")]
		private float[] distances;

		[Token(Token = "0x400453E")]
		[FieldOffset(Offset = "0xD8")]
		protected bool finishAction;

		[Token(Token = "0x400453F")]
		[FieldOffset(Offset = "0xD9")]
		protected bool isRunning;

		[Token(Token = "0x4004540")]
		[FieldOffset(Offset = "0xDA")]
		protected bool looping;

		[Token(Token = "0x4004541")]
		[FieldOffset(Offset = "0xDB")]
		private bool start;

		[Token(Token = "0x4004542")]
		[FieldOffset(Offset = "0xDC")]
		private float largestEndTime;

		[Token(Token = "0x6005AA0")]
		[Address(RVA = "0xD8B1C8", Offset = "0xD8B1C8", VA = "0xD8B1C8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005AA1")]
		[Address(RVA = "0xD8B780", Offset = "0xD8B780", VA = "0xD8B780", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005AA2")]
		[Address(RVA = "0xD8B808", Offset = "0xD8B808", VA = "0xD8B808")]
		protected void Init()
		{
		}

		[Token(Token = "0x6005AA3")]
		[Address(RVA = "0xD8BF1C", Offset = "0xD8BF1C", VA = "0xD8BF1C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005AA4")]
		[Address(RVA = "0xD8CF70", Offset = "0xD8CF70", VA = "0xD8CF70")]
		protected CurveFsmAction()
		{
		}
	}
}
