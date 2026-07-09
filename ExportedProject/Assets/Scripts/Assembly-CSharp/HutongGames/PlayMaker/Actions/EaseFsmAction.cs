using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EB0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599768", Offset = "0x599768")]
	public abstract class EaseFsmAction : FsmStateAction
	{
		[Token(Token = "0x2000EB1")]
		protected delegate float EasingFunction(float start, float end, float value);

		[Token(Token = "0x2000EB2")]
		public enum EaseType
		{
			[Token(Token = "0x4004581")]
			easeInQuad = 0,
			[Token(Token = "0x4004582")]
			easeOutQuad = 1,
			[Token(Token = "0x4004583")]
			easeInOutQuad = 2,
			[Token(Token = "0x4004584")]
			easeInCubic = 3,
			[Token(Token = "0x4004585")]
			easeOutCubic = 4,
			[Token(Token = "0x4004586")]
			easeInOutCubic = 5,
			[Token(Token = "0x4004587")]
			easeInQuart = 6,
			[Token(Token = "0x4004588")]
			easeOutQuart = 7,
			[Token(Token = "0x4004589")]
			easeInOutQuart = 8,
			[Token(Token = "0x400458A")]
			easeInQuint = 9,
			[Token(Token = "0x400458B")]
			easeOutQuint = 10,
			[Token(Token = "0x400458C")]
			easeInOutQuint = 11,
			[Token(Token = "0x400458D")]
			easeInSine = 12,
			[Token(Token = "0x400458E")]
			easeOutSine = 13,
			[Token(Token = "0x400458F")]
			easeInOutSine = 14,
			[Token(Token = "0x4004590")]
			easeInExpo = 15,
			[Token(Token = "0x4004591")]
			easeOutExpo = 16,
			[Token(Token = "0x4004592")]
			easeInOutExpo = 17,
			[Token(Token = "0x4004593")]
			easeInCirc = 18,
			[Token(Token = "0x4004594")]
			easeOutCirc = 19,
			[Token(Token = "0x4004595")]
			easeInOutCirc = 20,
			[Token(Token = "0x4004596")]
			linear = 21,
			[Token(Token = "0x4004597")]
			spring = 22,
			[Token(Token = "0x4004598")]
			bounce = 23,
			[Token(Token = "0x4004599")]
			easeInBack = 24,
			[Token(Token = "0x400459A")]
			easeOutBack = 25,
			[Token(Token = "0x400459B")]
			easeInOutBack = 26,
			[Token(Token = "0x400459C")]
			elastic = 27,
			[Token(Token = "0x400459D")]
			punch = 28
		}

		[Token(Token = "0x400456B")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1DDC", Offset = "0x5C1DDC")]
		public FsmFloat time;

		[Token(Token = "0x400456C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1E28", Offset = "0x5C1E28")]
		public FsmFloat speed;

		[Token(Token = "0x400456D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1E60", Offset = "0x5C1E60")]
		public FsmFloat delay;

		[Token(Token = "0x400456E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1E98", Offset = "0x5C1E98")]
		public EaseType easeType;

		[Token(Token = "0x400456F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1ED0", Offset = "0x5C1ED0")]
		public FsmBool reverse;

		[Token(Token = "0x4004570")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1F08", Offset = "0x5C1F08")]
		public FsmEvent finishEvent;

		[Token(Token = "0x4004571")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1F40", Offset = "0x5C1F40")]
		public bool realTime;

		[Token(Token = "0x4004572")]
		[FieldOffset(Offset = "0x88")]
		protected EasingFunction ease;

		[Token(Token = "0x4004573")]
		[FieldOffset(Offset = "0x90")]
		protected float runningTime;

		[Token(Token = "0x4004574")]
		[FieldOffset(Offset = "0x94")]
		protected float lastTime;

		[Token(Token = "0x4004575")]
		[FieldOffset(Offset = "0x98")]
		protected float startTime;

		[Token(Token = "0x4004576")]
		[FieldOffset(Offset = "0x9C")]
		protected float deltaTime;

		[Token(Token = "0x4004577")]
		[FieldOffset(Offset = "0xA0")]
		protected float delayTime;

		[Token(Token = "0x4004578")]
		[FieldOffset(Offset = "0xA4")]
		protected float percentage;

		[Token(Token = "0x4004579")]
		[FieldOffset(Offset = "0xA8")]
		protected float[] fromFloats;

		[Token(Token = "0x400457A")]
		[FieldOffset(Offset = "0xB0")]
		protected float[] toFloats;

		[Token(Token = "0x400457B")]
		[FieldOffset(Offset = "0xB8")]
		protected float[] resultFloats;

		[Token(Token = "0x400457C")]
		[FieldOffset(Offset = "0xC0")]
		protected bool finishAction;

		[Token(Token = "0x400457D")]
		[FieldOffset(Offset = "0xC1")]
		protected bool start;

		[Token(Token = "0x400457E")]
		[FieldOffset(Offset = "0xC2")]
		protected bool finished;

		[Token(Token = "0x400457F")]
		[FieldOffset(Offset = "0xC3")]
		protected bool isRunning;

		[Token(Token = "0x6005AB9")]
		[Address(RVA = "0xC229D8", Offset = "0xC229D8", VA = "0xC229D8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005ABA")]
		[Address(RVA = "0xC22D10", Offset = "0xC22D10", VA = "0xC22D10", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005ABB")]
		[Address(RVA = "0xC22DDC", Offset = "0xC22DDC", VA = "0xC22DDC", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005ABC")]
		[Address(RVA = "0xC23018", Offset = "0xC23018", VA = "0xC23018", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005ABD")]
		[Address(RVA = "0xC23A4C", Offset = "0xC23A4C", VA = "0xC23A4C")]
		protected void UpdatePercentage()
		{
		}

		[Token(Token = "0x6005ABE")]
		[Address(RVA = "0xC2357C", Offset = "0xC2357C", VA = "0xC2357C")]
		protected void SetEasingFunction()
		{
		}

		[Token(Token = "0x6005ABF")]
		[Address(RVA = "0xC23B90", Offset = "0xC23B90", VA = "0xC23B90")]
		protected float linear(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AC0")]
		[Address(RVA = "0xC23B98", Offset = "0xC23B98", VA = "0xC23B98")]
		protected float clerp(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AC1")]
		[Address(RVA = "0xC23BFC", Offset = "0xC23BFC", VA = "0xC23BFC")]
		protected float spring(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AC2")]
		[Address(RVA = "0xC23CB0", Offset = "0xC23CB0", VA = "0xC23CB0")]
		protected float easeInQuad(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AC3")]
		[Address(RVA = "0xC23CC4", Offset = "0xC23CC4", VA = "0xC23CC4")]
		protected float easeOutQuad(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AC4")]
		[Address(RVA = "0xC23CE0", Offset = "0xC23CE0", VA = "0xC23CE0")]
		protected float easeInOutQuad(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AC5")]
		[Address(RVA = "0xC23D34", Offset = "0xC23D34", VA = "0xC23D34")]
		protected float easeInCubic(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AC6")]
		[Address(RVA = "0xC23D4C", Offset = "0xC23D4C", VA = "0xC23D4C")]
		protected float easeOutCubic(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AC7")]
		[Address(RVA = "0xC23D74", Offset = "0xC23D74", VA = "0xC23D74")]
		protected float easeInOutCubic(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AC8")]
		[Address(RVA = "0xC23DCC", Offset = "0xC23DCC", VA = "0xC23DCC")]
		protected float easeInQuart(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AC9")]
		[Address(RVA = "0xC23DE8", Offset = "0xC23DE8", VA = "0xC23DE8")]
		protected float easeOutQuart(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005ACA")]
		[Address(RVA = "0xC23E10", Offset = "0xC23E10", VA = "0xC23E10")]
		protected float easeInOutQuart(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005ACB")]
		[Address(RVA = "0xC23E6C", Offset = "0xC23E6C", VA = "0xC23E6C")]
		protected float easeInQuint(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005ACC")]
		[Address(RVA = "0xC23E8C", Offset = "0xC23E8C", VA = "0xC23E8C")]
		protected float easeOutQuint(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005ACD")]
		[Address(RVA = "0xC23EBC", Offset = "0xC23EBC", VA = "0xC23EBC")]
		protected float easeInOutQuint(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005ACE")]
		[Address(RVA = "0xC23F24", Offset = "0xC23F24", VA = "0xC23F24")]
		protected float easeInSine(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005ACF")]
		[Address(RVA = "0xC23F60", Offset = "0xC23F60", VA = "0xC23F60")]
		protected float easeOutSine(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AD0")]
		[Address(RVA = "0xC23F98", Offset = "0xC23F98", VA = "0xC23F98")]
		protected float easeInOutSine(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AD1")]
		[Address(RVA = "0xC23FE0", Offset = "0xC23FE0", VA = "0xC23FE0")]
		protected float easeInExpo(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AD2")]
		[Address(RVA = "0xC2401C", Offset = "0xC2401C", VA = "0xC2401C")]
		protected float easeOutExpo(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AD3")]
		[Address(RVA = "0xC24058", Offset = "0xC24058", VA = "0xC24058")]
		protected float easeInOutExpo(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AD4")]
		[Address(RVA = "0xC240CC", Offset = "0xC240CC", VA = "0xC240CC")]
		protected float easeInCirc(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AD5")]
		[Address(RVA = "0xC2411C", Offset = "0xC2411C", VA = "0xC2411C")]
		protected float easeOutCirc(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AD6")]
		[Address(RVA = "0xC2416C", Offset = "0xC2416C", VA = "0xC2416C")]
		protected float easeInOutCirc(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AD7")]
		[Address(RVA = "0xC241F0", Offset = "0xC241F0", VA = "0xC241F0")]
		protected float bounce(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AD8")]
		[Address(RVA = "0xC242BC", Offset = "0xC242BC", VA = "0xC242BC")]
		protected float easeInBack(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005AD9")]
		[Address(RVA = "0xC242EC", Offset = "0xC242EC", VA = "0xC242EC")]
		protected float easeOutBack(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005ADA")]
		[Address(RVA = "0xC2432C", Offset = "0xC2432C", VA = "0xC2432C")]
		protected float easeInOutBack(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005ADB")]
		[Address(RVA = "0xC243B0", Offset = "0xC243B0", VA = "0xC243B0")]
		protected float punch(float amplitude, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005ADC")]
		[Address(RVA = "0xC24424", Offset = "0xC24424", VA = "0xC24424")]
		protected float elastic(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6005ADD")]
		[Address(RVA = "0xC23274", Offset = "0xC23274", VA = "0xC23274")]
		protected EaseFsmAction()
		{
		}
	}
}
