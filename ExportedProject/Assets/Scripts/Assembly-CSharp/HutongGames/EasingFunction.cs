using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames
{
	[Token(Token = "0x2000E7F")]
	public class EasingFunction
	{
		[Token(Token = "0x2000E80")]
		public enum Ease
		{
			[Token(Token = "0x400443A")]
			EaseInQuad = 0,
			[Token(Token = "0x400443B")]
			EaseOutQuad = 1,
			[Token(Token = "0x400443C")]
			EaseInOutQuad = 2,
			[Token(Token = "0x400443D")]
			EaseInCubic = 3,
			[Token(Token = "0x400443E")]
			EaseOutCubic = 4,
			[Token(Token = "0x400443F")]
			EaseInOutCubic = 5,
			[Token(Token = "0x4004440")]
			EaseInQuart = 6,
			[Token(Token = "0x4004441")]
			EaseOutQuart = 7,
			[Token(Token = "0x4004442")]
			EaseInOutQuart = 8,
			[Token(Token = "0x4004443")]
			EaseInQuint = 9,
			[Token(Token = "0x4004444")]
			EaseOutQuint = 10,
			[Token(Token = "0x4004445")]
			EaseInOutQuint = 11,
			[Token(Token = "0x4004446")]
			EaseInSine = 12,
			[Token(Token = "0x4004447")]
			EaseOutSine = 13,
			[Token(Token = "0x4004448")]
			EaseInOutSine = 14,
			[Token(Token = "0x4004449")]
			EaseInExpo = 15,
			[Token(Token = "0x400444A")]
			EaseOutExpo = 16,
			[Token(Token = "0x400444B")]
			EaseInOutExpo = 17,
			[Token(Token = "0x400444C")]
			EaseInCirc = 18,
			[Token(Token = "0x400444D")]
			EaseOutCirc = 19,
			[Token(Token = "0x400444E")]
			EaseInOutCirc = 20,
			[Token(Token = "0x400444F")]
			Linear = 21,
			[Token(Token = "0x4004450")]
			Spring = 22,
			[Token(Token = "0x4004451")]
			EaseInBounce = 23,
			[Token(Token = "0x4004452")]
			EaseOutBounce = 24,
			[Token(Token = "0x4004453")]
			EaseInOutBounce = 25,
			[Token(Token = "0x4004454")]
			EaseInBack = 26,
			[Token(Token = "0x4004455")]
			EaseOutBack = 27,
			[Token(Token = "0x4004456")]
			EaseInOutBack = 28,
			[Token(Token = "0x4004457")]
			EaseInElastic = 29,
			[Token(Token = "0x4004458")]
			EaseOutElastic = 30,
			[Token(Token = "0x4004459")]
			EaseInOutElastic = 31,
			[Token(Token = "0x400445A")]
			CustomCurve = 32,
			[Token(Token = "0x400445B")]
			Punch = 33
		}

		[Token(Token = "0x2000E81")]
		public delegate float Function(float s, float e, float v);

		[Token(Token = "0x4004437")]
		private const float NATURAL_LOG_OF_2 = 0.6931472f;

		[Token(Token = "0x4004438")]
		[FieldOffset(Offset = "0x0")]
		public static AnimationCurve AnimationCurve;

		[Token(Token = "0x600599B")]
		[Address(RVA = "0xC24DE0", Offset = "0xC24DE0", VA = "0xC24DE0")]
		public static float Linear(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600599C")]
		[Address(RVA = "0xC24DE8", Offset = "0xC24DE8", VA = "0xC24DE8")]
		public static float Spring(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600599D")]
		[Address(RVA = "0xC24E9C", Offset = "0xC24E9C", VA = "0xC24E9C")]
		public static float EaseInQuad(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600599E")]
		[Address(RVA = "0xC24EB0", Offset = "0xC24EB0", VA = "0xC24EB0")]
		public static float EaseOutQuad(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600599F")]
		[Address(RVA = "0xC24ECC", Offset = "0xC24ECC", VA = "0xC24ECC")]
		public static float EaseInOutQuad(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059A0")]
		[Address(RVA = "0xC24F20", Offset = "0xC24F20", VA = "0xC24F20")]
		public static float EaseInCubic(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059A1")]
		[Address(RVA = "0xC24F38", Offset = "0xC24F38", VA = "0xC24F38")]
		public static float EaseOutCubic(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059A2")]
		[Address(RVA = "0xC24F60", Offset = "0xC24F60", VA = "0xC24F60")]
		public static float EaseInOutCubic(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059A3")]
		[Address(RVA = "0xC24FB8", Offset = "0xC24FB8", VA = "0xC24FB8")]
		public static float EaseInQuart(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059A4")]
		[Address(RVA = "0xC24FD4", Offset = "0xC24FD4", VA = "0xC24FD4")]
		public static float EaseOutQuart(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059A5")]
		[Address(RVA = "0xC24FFC", Offset = "0xC24FFC", VA = "0xC24FFC")]
		public static float EaseInOutQuart(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059A6")]
		[Address(RVA = "0xC25058", Offset = "0xC25058", VA = "0xC25058")]
		public static float EaseInQuint(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059A7")]
		[Address(RVA = "0xC25078", Offset = "0xC25078", VA = "0xC25078")]
		public static float EaseOutQuint(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059A8")]
		[Address(RVA = "0xC250A8", Offset = "0xC250A8", VA = "0xC250A8")]
		public static float EaseInOutQuint(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059A9")]
		[Address(RVA = "0xC25110", Offset = "0xC25110", VA = "0xC25110")]
		public static float EaseInSine(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059AA")]
		[Address(RVA = "0xC2514C", Offset = "0xC2514C", VA = "0xC2514C")]
		public static float EaseOutSine(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059AB")]
		[Address(RVA = "0xC25184", Offset = "0xC25184", VA = "0xC25184")]
		public static float EaseInOutSine(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059AC")]
		[Address(RVA = "0xC251CC", Offset = "0xC251CC", VA = "0xC251CC")]
		public static float EaseInExpo(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059AD")]
		[Address(RVA = "0xC25208", Offset = "0xC25208", VA = "0xC25208")]
		public static float EaseOutExpo(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059AE")]
		[Address(RVA = "0xC25244", Offset = "0xC25244", VA = "0xC25244")]
		public static float EaseInOutExpo(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059AF")]
		[Address(RVA = "0xC252B8", Offset = "0xC252B8", VA = "0xC252B8")]
		public static float EaseInCirc(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059B0")]
		[Address(RVA = "0xC25308", Offset = "0xC25308", VA = "0xC25308")]
		public static float EaseOutCirc(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059B1")]
		[Address(RVA = "0xC25358", Offset = "0xC25358", VA = "0xC25358")]
		public static float EaseInOutCirc(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059B2")]
		[Address(RVA = "0xC253DC", Offset = "0xC253DC", VA = "0xC253DC")]
		public static float EaseInBounce(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059B3")]
		[Address(RVA = "0xC25418", Offset = "0xC25418", VA = "0xC25418")]
		public static float EaseOutBounce(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059B4")]
		[Address(RVA = "0xC254E4", Offset = "0xC254E4", VA = "0xC254E4")]
		public static float EaseInOutBounce(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059B5")]
		[Address(RVA = "0xC25568", Offset = "0xC25568", VA = "0xC25568")]
		public static float EaseInBack(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059B6")]
		[Address(RVA = "0xC25598", Offset = "0xC25598", VA = "0xC25598")]
		public static float EaseOutBack(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059B7")]
		[Address(RVA = "0xC255D8", Offset = "0xC255D8", VA = "0xC255D8")]
		public static float EaseInOutBack(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059B8")]
		[Address(RVA = "0xC2565C", Offset = "0xC2565C", VA = "0xC2565C")]
		public static float EaseInElastic(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059B9")]
		[Address(RVA = "0xC256F0", Offset = "0xC256F0", VA = "0xC256F0")]
		public static float EaseOutElastic(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059BA")]
		[Address(RVA = "0xC25784", Offset = "0xC25784", VA = "0xC25784")]
		public static float EaseInOutElastic(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059BB")]
		[Address(RVA = "0xC25884", Offset = "0xC25884", VA = "0xC25884")]
		public static float LinearD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059BC")]
		[Address(RVA = "0xC2588C", Offset = "0xC2588C", VA = "0xC2588C")]
		public static float EaseInQuadD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059BD")]
		[Address(RVA = "0xC2589C", Offset = "0xC2589C", VA = "0xC2589C")]
		public static float EaseOutQuadD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059BE")]
		[Address(RVA = "0xC258B8", Offset = "0xC258B8", VA = "0xC258B8")]
		public static float EaseInOutQuadD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059BF")]
		[Address(RVA = "0xC258E0", Offset = "0xC258E0", VA = "0xC258E0")]
		public static float EaseInCubicD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059C0")]
		[Address(RVA = "0xC258F8", Offset = "0xC258F8", VA = "0xC258F8")]
		public static float EaseOutCubicD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059C1")]
		[Address(RVA = "0xC25918", Offset = "0xC25918", VA = "0xC25918")]
		public static float EaseInOutCubicD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059C2")]
		[Address(RVA = "0xC25948", Offset = "0xC25948", VA = "0xC25948")]
		public static float EaseInQuartD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059C3")]
		[Address(RVA = "0xC25964", Offset = "0xC25964", VA = "0xC25964")]
		public static float EaseOutQuartD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059C4")]
		[Address(RVA = "0xC25988", Offset = "0xC25988", VA = "0xC25988")]
		public static float EaseInOutQuartD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059C5")]
		[Address(RVA = "0xC259C0", Offset = "0xC259C0", VA = "0xC259C0")]
		public static float EaseInQuintD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059C6")]
		[Address(RVA = "0xC259E0", Offset = "0xC259E0", VA = "0xC259E0")]
		public static float EaseOutQuintD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059C7")]
		[Address(RVA = "0xC25A08", Offset = "0xC25A08", VA = "0xC25A08")]
		public static float EaseInOutQuintD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059C8")]
		[Address(RVA = "0xC25A40", Offset = "0xC25A40", VA = "0xC25A40")]
		public static float EaseInSineD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059C9")]
		[Address(RVA = "0xC25A8C", Offset = "0xC25A8C", VA = "0xC25A8C")]
		public static float EaseOutSineD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059CA")]
		[Address(RVA = "0xC25AC0", Offset = "0xC25AC0", VA = "0xC25AC0")]
		public static float EaseInOutSineD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059CB")]
		[Address(RVA = "0xC25AFC", Offset = "0xC25AFC", VA = "0xC25AFC")]
		public static float EaseInExpoD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059CC")]
		[Address(RVA = "0xC25B44", Offset = "0xC25B44", VA = "0xC25B44")]
		public static float EaseOutExpoD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059CD")]
		[Address(RVA = "0xC25B84", Offset = "0xC25B84", VA = "0xC25B84")]
		public static float EaseInOutExpoD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059CE")]
		[Address(RVA = "0xC25BDC", Offset = "0xC25BDC", VA = "0xC25BDC")]
		public static float EaseInCircD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059CF")]
		[Address(RVA = "0xC25C38", Offset = "0xC25C38", VA = "0xC25C38")]
		public static float EaseOutCircD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059D0")]
		[Address(RVA = "0xC25C88", Offset = "0xC25C88", VA = "0xC25C88")]
		public static float EaseInOutCircD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059D1")]
		[Address(RVA = "0xC25D08", Offset = "0xC25D08", VA = "0xC25D08")]
		public static float EaseInBounceD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059D2")]
		[Address(RVA = "0xC25D1C", Offset = "0xC25D1C", VA = "0xC25D1C")]
		public static float EaseOutBounceD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059D3")]
		[Address(RVA = "0xC25DA4", Offset = "0xC25DA4", VA = "0xC25DA4")]
		public static float EaseInOutBounceD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059D4")]
		[Address(RVA = "0xC25DF0", Offset = "0xC25DF0", VA = "0xC25DF0")]
		public static float EaseInBackD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059D5")]
		[Address(RVA = "0xC25E20", Offset = "0xC25E20", VA = "0xC25E20")]
		public static float EaseOutBackD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059D6")]
		[Address(RVA = "0xC25E5C", Offset = "0xC25E5C", VA = "0xC25E5C")]
		public static float EaseInOutBackD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059D7")]
		[Address(RVA = "0xC25EEC", Offset = "0xC25EEC", VA = "0xC25EEC")]
		public static float EaseInElasticD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059D8")]
		[Address(RVA = "0xC25F9C", Offset = "0xC25F9C", VA = "0xC25F9C")]
		public static float EaseOutElasticD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059D9")]
		[Address(RVA = "0xC2604C", Offset = "0xC2604C", VA = "0xC2604C")]
		public static float EaseInOutElasticD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059DA")]
		[Address(RVA = "0xC2617C", Offset = "0xC2617C", VA = "0xC2617C")]
		public static float SpringD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059DB")]
		[Address(RVA = "0xC262E0", Offset = "0xC262E0", VA = "0xC262E0")]
		public static float CustomCurve(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059DC")]
		[Address(RVA = "0xC2636C", Offset = "0xC2636C", VA = "0xC2636C")]
		public static float Punch(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059DD")]
		[Address(RVA = "0xC263CC", Offset = "0xC263CC", VA = "0xC263CC")]
		public static float PunchD(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60059DE")]
		[Address(RVA = "0xC26450", Offset = "0xC26450", VA = "0xC26450")]
		public static Function GetEasingFunction(Ease easingFunction)
		{
			return null;
		}

		[Token(Token = "0x60059DF")]
		[Address(RVA = "0xC26A18", Offset = "0xC26A18", VA = "0xC26A18")]
		public static Function GetEasingFunctionDerivative(Ease easingFunction)
		{
			return null;
		}

		[Token(Token = "0x60059E0")]
		[Address(RVA = "0xC26FB4", Offset = "0xC26FB4", VA = "0xC26FB4")]
		public EasingFunction()
		{
		}
	}
}
