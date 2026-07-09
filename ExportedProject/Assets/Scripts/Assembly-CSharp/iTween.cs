using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000949")]
public class iTween : MonoBehaviour
{
	[Token(Token = "0x200094A")]
	private delegate float EasingFunction(float start, float end, float Value);

	[Token(Token = "0x200094B")]
	private delegate void ApplyTween();

	[Token(Token = "0x200094C")]
	public enum EaseType
	{
		[Token(Token = "0x4003293")]
		easeInQuad = 0,
		[Token(Token = "0x4003294")]
		easeOutQuad = 1,
		[Token(Token = "0x4003295")]
		easeInOutQuad = 2,
		[Token(Token = "0x4003296")]
		easeInCubic = 3,
		[Token(Token = "0x4003297")]
		easeOutCubic = 4,
		[Token(Token = "0x4003298")]
		easeInOutCubic = 5,
		[Token(Token = "0x4003299")]
		easeInQuart = 6,
		[Token(Token = "0x400329A")]
		easeOutQuart = 7,
		[Token(Token = "0x400329B")]
		easeInOutQuart = 8,
		[Token(Token = "0x400329C")]
		easeInQuint = 9,
		[Token(Token = "0x400329D")]
		easeOutQuint = 10,
		[Token(Token = "0x400329E")]
		easeInOutQuint = 11,
		[Token(Token = "0x400329F")]
		easeInSine = 12,
		[Token(Token = "0x40032A0")]
		easeOutSine = 13,
		[Token(Token = "0x40032A1")]
		easeInOutSine = 14,
		[Token(Token = "0x40032A2")]
		easeInExpo = 15,
		[Token(Token = "0x40032A3")]
		easeOutExpo = 16,
		[Token(Token = "0x40032A4")]
		easeInOutExpo = 17,
		[Token(Token = "0x40032A5")]
		easeInCirc = 18,
		[Token(Token = "0x40032A6")]
		easeOutCirc = 19,
		[Token(Token = "0x40032A7")]
		easeInOutCirc = 20,
		[Token(Token = "0x40032A8")]
		linear = 21,
		[Token(Token = "0x40032A9")]
		spring = 22,
		[Token(Token = "0x40032AA")]
		easeInBounce = 23,
		[Token(Token = "0x40032AB")]
		easeOutBounce = 24,
		[Token(Token = "0x40032AC")]
		easeInOutBounce = 25,
		[Token(Token = "0x40032AD")]
		easeInBack = 26,
		[Token(Token = "0x40032AE")]
		easeOutBack = 27,
		[Token(Token = "0x40032AF")]
		easeInOutBack = 28,
		[Token(Token = "0x40032B0")]
		easeInElastic = 29,
		[Token(Token = "0x40032B1")]
		easeOutElastic = 30,
		[Token(Token = "0x40032B2")]
		easeInOutElastic = 31,
		[Token(Token = "0x40032B3")]
		punch = 32
	}

	[Token(Token = "0x200094D")]
	public enum LoopType
	{
		[Token(Token = "0x40032B5")]
		none = 0,
		[Token(Token = "0x40032B6")]
		loop = 1,
		[Token(Token = "0x40032B7")]
		pingPong = 2
	}

	[Token(Token = "0x200094E")]
	public enum NamedValueColor
	{
		[Token(Token = "0x40032B9")]
		_Color = 0,
		[Token(Token = "0x40032BA")]
		_SpecColor = 1,
		[Token(Token = "0x40032BB")]
		_Emission = 2,
		[Token(Token = "0x40032BC")]
		_ReflectColor = 3
	}

	[Token(Token = "0x200094F")]
	public static class Defaults
	{
		[Token(Token = "0x40032BD")]
		[FieldOffset(Offset = "0x0")]
		public static float time;

		[Token(Token = "0x40032BE")]
		[FieldOffset(Offset = "0x4")]
		public static float delay;

		[Token(Token = "0x40032BF")]
		[FieldOffset(Offset = "0x8")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x40032C0")]
		[FieldOffset(Offset = "0xC")]
		public static LoopType loopType;

		[Token(Token = "0x40032C1")]
		[FieldOffset(Offset = "0x10")]
		public static EaseType easeType;

		[Token(Token = "0x40032C2")]
		[FieldOffset(Offset = "0x14")]
		public static float lookSpeed;

		[Token(Token = "0x40032C3")]
		[FieldOffset(Offset = "0x18")]
		public static bool isLocal;

		[Token(Token = "0x40032C4")]
		[FieldOffset(Offset = "0x1C")]
		public static Space space;

		[Token(Token = "0x40032C5")]
		[FieldOffset(Offset = "0x20")]
		public static bool orientToPath;

		[Token(Token = "0x40032C6")]
		[FieldOffset(Offset = "0x24")]
		public static Color color;

		[Token(Token = "0x40032C7")]
		[FieldOffset(Offset = "0x34")]
		public static float updateTimePercentage;

		[Token(Token = "0x40032C8")]
		[FieldOffset(Offset = "0x38")]
		public static float updateTime;

		[Token(Token = "0x40032C9")]
		[FieldOffset(Offset = "0x3C")]
		public static float lookAhead;

		[Token(Token = "0x40032CA")]
		[FieldOffset(Offset = "0x40")]
		public static bool useRealTime;

		[Token(Token = "0x40032CB")]
		[FieldOffset(Offset = "0x44")]
		public static Vector3 up;
	}

	[Token(Token = "0x2000950")]
	private class CRSpline
	{
		[Token(Token = "0x40032CC")]
		[FieldOffset(Offset = "0x10")]
		public Vector3[] pts;

		[Token(Token = "0x6003BC1")]
		[Address(RVA = "0xA445C4", Offset = "0xA445C4", VA = "0xA445C4")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x6003BC2")]
		[Address(RVA = "0xA44648", Offset = "0xA44648", VA = "0xA44648")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000951")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5970E0", Offset = "0x5970E0")]
	private sealed class _003CTweenDelay_003Ed__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40032CD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40032CE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40032CF")]
		[FieldOffset(Offset = "0x20")]
		public iTween _003C_003E4__this;

		[Token(Token = "0x1700076B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003BC6")]
			[Address(RVA = "0xA44178", Offset = "0xA44178", VA = "0xA44178", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700076C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003BC8")]
			[Address(RVA = "0xA441C0", Offset = "0xA441C0", VA = "0xA441C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003BC3")]
		[Address(RVA = "0xA44078", Offset = "0xA44078", VA = "0xA44078")]
		[DebuggerHidden]
		public _003CTweenDelay_003Ed__145(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003BC4")]
		[Address(RVA = "0xA440A4", Offset = "0xA440A4", VA = "0xA440A4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003BC5")]
		[Address(RVA = "0xA440A8", Offset = "0xA440A8", VA = "0xA440A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003BC7")]
		[Address(RVA = "0xA44180", Offset = "0xA44180", VA = "0xA44180", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000952")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5970F0", Offset = "0x5970F0")]
	private sealed class _003CTweenRestart_003Ed__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40032D0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40032D1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40032D2")]
		[FieldOffset(Offset = "0x20")]
		public iTween _003C_003E4__this;

		[Token(Token = "0x1700076D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003BCC")]
			[Address(RVA = "0xA442D0", Offset = "0xA442D0", VA = "0xA442D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700076E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003BCE")]
			[Address(RVA = "0xA44318", Offset = "0xA44318", VA = "0xA44318", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003BC9")]
		[Address(RVA = "0xA441C8", Offset = "0xA441C8", VA = "0xA441C8")]
		[DebuggerHidden]
		public _003CTweenRestart_003Ed__147(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003BCA")]
		[Address(RVA = "0xA441F4", Offset = "0xA441F4", VA = "0xA441F4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003BCB")]
		[Address(RVA = "0xA441F8", Offset = "0xA441F8", VA = "0xA441F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003BCD")]
		[Address(RVA = "0xA442D8", Offset = "0xA442D8", VA = "0xA442D8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000953")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597100", Offset = "0x597100")]
	private sealed class _003CStart_003Ed__229 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40032D3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40032D4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40032D5")]
		[FieldOffset(Offset = "0x20")]
		public iTween _003C_003E4__this;

		[Token(Token = "0x1700076F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003BD2")]
			[Address(RVA = "0xA44028", Offset = "0xA44028", VA = "0xA44028", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000770")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003BD4")]
			[Address(RVA = "0xA44070", Offset = "0xA44070", VA = "0xA44070", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003BCF")]
		[Address(RVA = "0xA43F50", Offset = "0xA43F50", VA = "0xA43F50")]
		[DebuggerHidden]
		public _003CStart_003Ed__229(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003BD0")]
		[Address(RVA = "0xA43F7C", Offset = "0xA43F7C", VA = "0xA43F7C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003BD1")]
		[Address(RVA = "0xA43F80", Offset = "0xA43F80", VA = "0xA43F80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003BD3")]
		[Address(RVA = "0xA44030", Offset = "0xA44030", VA = "0xA44030", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400326D")]
	[FieldOffset(Offset = "0x0")]
	public static List<Hashtable> tweens;

	[Token(Token = "0x400326E")]
	[FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x400326F")]
	[FieldOffset(Offset = "0x20")]
	public string type;

	[Token(Token = "0x4003270")]
	[FieldOffset(Offset = "0x28")]
	public string method;

	[Token(Token = "0x4003271")]
	[FieldOffset(Offset = "0x30")]
	public EaseType easeType;

	[Token(Token = "0x4003272")]
	[FieldOffset(Offset = "0x34")]
	public float time;

	[Token(Token = "0x4003273")]
	[FieldOffset(Offset = "0x38")]
	public float delay;

	[Token(Token = "0x4003274")]
	[FieldOffset(Offset = "0x3C")]
	public LoopType loopType;

	[Token(Token = "0x4003275")]
	[FieldOffset(Offset = "0x40")]
	public bool isRunning;

	[Token(Token = "0x4003276")]
	[FieldOffset(Offset = "0x41")]
	public bool isPaused;

	[Token(Token = "0x4003277")]
	[FieldOffset(Offset = "0x48")]
	public string _name;

	[Token(Token = "0x4003278")]
	[FieldOffset(Offset = "0x50")]
	private float runningTime;

	[Token(Token = "0x4003279")]
	[FieldOffset(Offset = "0x54")]
	private float percentage;

	[Token(Token = "0x400327A")]
	[FieldOffset(Offset = "0x58")]
	private float delayStarted;

	[Token(Token = "0x400327B")]
	[FieldOffset(Offset = "0x5C")]
	private bool kinematic;

	[Token(Token = "0x400327C")]
	[FieldOffset(Offset = "0x5D")]
	private bool isLocal;

	[Token(Token = "0x400327D")]
	[FieldOffset(Offset = "0x5E")]
	private bool loop;

	[Token(Token = "0x400327E")]
	[FieldOffset(Offset = "0x5F")]
	private bool reverse;

	[Token(Token = "0x400327F")]
	[FieldOffset(Offset = "0x60")]
	private bool wasPaused;

	[Token(Token = "0x4003280")]
	[FieldOffset(Offset = "0x61")]
	private bool physics;

	[Token(Token = "0x4003281")]
	[FieldOffset(Offset = "0x68")]
	private Hashtable tweenArguments;

	[Token(Token = "0x4003282")]
	[FieldOffset(Offset = "0x70")]
	private Space space;

	[Token(Token = "0x4003283")]
	[FieldOffset(Offset = "0x78")]
	private EasingFunction ease;

	[Token(Token = "0x4003284")]
	[FieldOffset(Offset = "0x80")]
	private ApplyTween apply;

	[Token(Token = "0x4003285")]
	[FieldOffset(Offset = "0x88")]
	private AudioSource audioSource;

	[Token(Token = "0x4003286")]
	[FieldOffset(Offset = "0x90")]
	private Vector3[] vector3s;

	[Token(Token = "0x4003287")]
	[FieldOffset(Offset = "0x98")]
	private Vector2[] vector2s;

	[Token(Token = "0x4003288")]
	[FieldOffset(Offset = "0xA0")]
	private Color[,] colors;

	[Token(Token = "0x4003289")]
	[FieldOffset(Offset = "0xA8")]
	private float[] floats;

	[Token(Token = "0x400328A")]
	[FieldOffset(Offset = "0xB0")]
	private Rect[] rects;

	[Token(Token = "0x400328B")]
	[FieldOffset(Offset = "0xB8")]
	private CRSpline path;

	[Token(Token = "0x400328C")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 preUpdate;

	[Token(Token = "0x400328D")]
	[FieldOffset(Offset = "0xCC")]
	private Vector3 postUpdate;

	[Token(Token = "0x400328E")]
	[FieldOffset(Offset = "0xD8")]
	private NamedValueColor namedcolorvalue;

	[Token(Token = "0x400328F")]
	[FieldOffset(Offset = "0xDC")]
	private float lastRealTime;

	[Token(Token = "0x4003290")]
	[FieldOffset(Offset = "0xE0")]
	private bool useRealTime;

	[Token(Token = "0x4003291")]
	[FieldOffset(Offset = "0xE8")]
	private Transform thisTransform;

	[Token(Token = "0x6003AC5")]
	[Address(RVA = "0x888D4C", Offset = "0x888D4C", VA = "0x888D4C")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x6003AC6")]
	[Address(RVA = "0x888FE4", Offset = "0x888FE4", VA = "0x888FE4")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AC7")]
	[Address(RVA = "0x88A160", Offset = "0x88A160", VA = "0x88A160")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6003AC8")]
	[Address(RVA = "0x88A480", Offset = "0x88A480", VA = "0x88A480")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AC9")]
	[Address(RVA = "0x88B020", Offset = "0x88B020", VA = "0x88B020")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6003ACA")]
	[Address(RVA = "0x88B1FC", Offset = "0x88B1FC", VA = "0x88B1FC")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003ACB")]
	[Address(RVA = "0x88B820", Offset = "0x88B820", VA = "0x88B820")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6003ACC")]
	[Address(RVA = "0x88A4F0", Offset = "0x88A4F0", VA = "0x88A4F0")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003ACD")]
	[Address(RVA = "0x88BA34", Offset = "0x88BA34", VA = "0x88BA34")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6003ACE")]
	[Address(RVA = "0x88B26C", Offset = "0x88B26C", VA = "0x88B26C")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003ACF")]
	[Address(RVA = "0x88BC48", Offset = "0x88BC48", VA = "0x88BC48")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6003AD0")]
	[Address(RVA = "0x88BEAC", Offset = "0x88BEAC", VA = "0x88BEAC")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AD1")]
	[Address(RVA = "0x88C364", Offset = "0x88C364", VA = "0x88C364")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6003AD2")]
	[Address(RVA = "0x88C5C8", Offset = "0x88C5C8", VA = "0x88C5C8")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AD3")]
	[Address(RVA = "0x88C768", Offset = "0x88C768", VA = "0x88C768")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x6003AD4")]
	[Address(RVA = "0x88C928", Offset = "0x88C928", VA = "0x88C928")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AD5")]
	[Address(RVA = "0x88C9EC", Offset = "0x88C9EC", VA = "0x88C9EC")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6003AD6")]
	[Address(RVA = "0x88CBF0", Offset = "0x88CBF0", VA = "0x88CBF0")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AD7")]
	[Address(RVA = "0x88D370", Offset = "0x88D370", VA = "0x88D370")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6003AD8")]
	[Address(RVA = "0x88D574", Offset = "0x88D574", VA = "0x88D574")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AD9")]
	[Address(RVA = "0x88D8CC", Offset = "0x88D8CC", VA = "0x88D8CC")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6003ADA")]
	[Address(RVA = "0x88DAD0", Offset = "0x88DAD0", VA = "0x88DAD0")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003ADB")]
	[Address(RVA = "0x88DE84", Offset = "0x88DE84", VA = "0x88DE84")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6003ADC")]
	[Address(RVA = "0x88E088", Offset = "0x88E088", VA = "0x88E088")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003ADD")]
	[Address(RVA = "0x88EA54", Offset = "0x88EA54", VA = "0x88EA54")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6003ADE")]
	[Address(RVA = "0x88EC58", Offset = "0x88EC58", VA = "0x88EC58")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003ADF")]
	[Address(RVA = "0x888DE0", Offset = "0x888DE0", VA = "0x888DE0")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6003AE0")]
	[Address(RVA = "0x88ED60", Offset = "0x88ED60", VA = "0x88ED60")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AE1")]
	[Address(RVA = "0x88EE68", Offset = "0x88EE68", VA = "0x88EE68")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6003AE2")]
	[Address(RVA = "0x88F06C", Offset = "0x88F06C", VA = "0x88F06C")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AE3")]
	[Address(RVA = "0x88F40C", Offset = "0x88F40C", VA = "0x88F40C")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6003AE4")]
	[Address(RVA = "0x88F610", Offset = "0x88F610", VA = "0x88F610")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AE5")]
	[Address(RVA = "0x88FB54", Offset = "0x88FB54", VA = "0x88FB54")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6003AE6")]
	[Address(RVA = "0x88FD58", Offset = "0x88FD58", VA = "0x88FD58")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AE7")]
	[Address(RVA = "0x88FE60", Offset = "0x88FE60", VA = "0x88FE60")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6003AE8")]
	[Address(RVA = "0x890064", Offset = "0x890064", VA = "0x890064")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AE9")]
	[Address(RVA = "0x89016C", Offset = "0x89016C", VA = "0x89016C")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6003AEA")]
	[Address(RVA = "0x890370", Offset = "0x890370", VA = "0x890370")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AEB")]
	[Address(RVA = "0x890724", Offset = "0x890724", VA = "0x890724")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6003AEC")]
	[Address(RVA = "0x890928", Offset = "0x890928", VA = "0x890928")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AED")]
	[Address(RVA = "0x890F54", Offset = "0x890F54", VA = "0x890F54")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6003AEE")]
	[Address(RVA = "0x891158", Offset = "0x891158", VA = "0x891158")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AEF")]
	[Address(RVA = "0x891260", Offset = "0x891260", VA = "0x891260")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6003AF0")]
	[Address(RVA = "0x891464", Offset = "0x891464", VA = "0x891464")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AF1")]
	[Address(RVA = "0x89156C", Offset = "0x89156C", VA = "0x89156C")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6003AF2")]
	[Address(RVA = "0x891770", Offset = "0x891770", VA = "0x891770")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AF3")]
	[Address(RVA = "0x891878", Offset = "0x891878", VA = "0x891878")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6003AF4")]
	[Address(RVA = "0x891A7C", Offset = "0x891A7C", VA = "0x891A7C")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AF5")]
	[Address(RVA = "0x891B84", Offset = "0x891B84", VA = "0x891B84")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6003AF6")]
	[Address(RVA = "0x891D88", Offset = "0x891D88", VA = "0x891D88")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AF7")]
	[Address(RVA = "0x891E90", Offset = "0x891E90", VA = "0x891E90")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6003AF8")]
	[Address(RVA = "0x892094", Offset = "0x892094", VA = "0x892094")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AF9")]
	[Address(RVA = "0x8921F8", Offset = "0x8921F8", VA = "0x8921F8")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6003AFA")]
	[Address(RVA = "0x8923FC", Offset = "0x8923FC", VA = "0x8923FC")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AFB")]
	[Address(RVA = "0x892560", Offset = "0x892560", VA = "0x892560")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6003AFC")]
	[Address(RVA = "0x892764", Offset = "0x892764", VA = "0x892764")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003AFD")]
	[Address(RVA = "0x8928C8", Offset = "0x8928C8", VA = "0x8928C8")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x6003AFE")]
	[Address(RVA = "0x893B78", Offset = "0x893B78", VA = "0x893B78")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x6003AFF")]
	[Address(RVA = "0x8939EC", Offset = "0x8939EC", VA = "0x8939EC")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x6003B00")]
	[Address(RVA = "0x893788", Offset = "0x893788", VA = "0x893788")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x6003B01")]
	[Address(RVA = "0x893530", Offset = "0x893530", VA = "0x893530")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x6003B02")]
	[Address(RVA = "0x893304", Offset = "0x893304", VA = "0x893304")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x6003B03")]
	[Address(RVA = "0x893CD4", Offset = "0x893CD4", VA = "0x893CD4")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x6003B04")]
	[Address(RVA = "0x8946C4", Offset = "0x8946C4", VA = "0x8946C4")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x6003B05")]
	[Address(RVA = "0x8997A4", Offset = "0x8997A4", VA = "0x8997A4")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x6003B06")]
	[Address(RVA = "0x898E54", Offset = "0x898E54", VA = "0x898E54")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x6003B07")]
	[Address(RVA = "0x894A14", Offset = "0x894A14", VA = "0x894A14")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x6003B08")]
	[Address(RVA = "0x895104", Offset = "0x895104", VA = "0x895104")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x6003B09")]
	[Address(RVA = "0x8957B8", Offset = "0x8957B8", VA = "0x8957B8")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x6003B0A")]
	[Address(RVA = "0x895DBC", Offset = "0x895DBC", VA = "0x895DBC")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x6003B0B")]
	[Address(RVA = "0x896350", Offset = "0x896350", VA = "0x896350")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x6003B0C")]
	[Address(RVA = "0x896788", Offset = "0x896788", VA = "0x896788")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x6003B0D")]
	[Address(RVA = "0x896BB4", Offset = "0x896BB4", VA = "0x896BB4")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x6003B0E")]
	[Address(RVA = "0x897294", Offset = "0x897294", VA = "0x897294")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x6003B0F")]
	[Address(RVA = "0x8976C8", Offset = "0x8976C8", VA = "0x8976C8")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x6003B10")]
	[Address(RVA = "0x897B38", Offset = "0x897B38", VA = "0x897B38")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x6003B11")]
	[Address(RVA = "0x897E70", Offset = "0x897E70", VA = "0x897E70")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x6003B12")]
	[Address(RVA = "0x89817C", Offset = "0x89817C", VA = "0x89817C")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x6003B13")]
	[Address(RVA = "0x898488", Offset = "0x898488", VA = "0x898488")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6003B14")]
	[Address(RVA = "0x8987EC", Offset = "0x8987EC", VA = "0x8987EC")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6003B15")]
	[Address(RVA = "0x898B24", Offset = "0x898B24", VA = "0x898B24")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x6003B16")]
	[Address(RVA = "0x899EB4", Offset = "0x899EB4", VA = "0x899EB4")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x6003B17")]
	[Address(RVA = "0x89A1BC", Offset = "0x89A1BC", VA = "0x89A1BC")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x6003B18")]
	[Address(RVA = "0x89A3F4", Offset = "0x89A3F4", VA = "0x89A3F4")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x6003B19")]
	[Address(RVA = "0x89A5F0", Offset = "0x89A5F0", VA = "0x89A5F0")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x6003B1A")]
	[Address(RVA = "0x89A798", Offset = "0x89A798", VA = "0x89A798")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x6003B1B")]
	[Address(RVA = "0x89A8F8", Offset = "0x89A8F8", VA = "0x89A8F8")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x6003B1C")]
	[Address(RVA = "0x89AE78", Offset = "0x89AE78", VA = "0x89AE78")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x6003B1D")]
	[Address(RVA = "0x89AFE4", Offset = "0x89AFE4", VA = "0x89AFE4")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x6003B1E")]
	[Address(RVA = "0x89AFE8", Offset = "0x89AFE8", VA = "0x89AFE8")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x6003B1F")]
	[Address(RVA = "0x89B318", Offset = "0x89B318", VA = "0x89B318")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x6003B20")]
	[Address(RVA = "0x89B520", Offset = "0x89B520", VA = "0x89B520")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x6003B21")]
	[Address(RVA = "0x89B80C", Offset = "0x89B80C", VA = "0x89B80C")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x6003B22")]
	[Address(RVA = "0x89B974", Offset = "0x89B974", VA = "0x89B974")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x6003B23")]
	[Address(RVA = "0x89BAB4", Offset = "0x89BAB4", VA = "0x89BAB4")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x6003B24")]
	[Address(RVA = "0x89BCF0", Offset = "0x89BCF0", VA = "0x89BCF0")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x6003B25")]
	[Address(RVA = "0x89BEF8", Offset = "0x89BEF8", VA = "0x89BEF8")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x6003B26")]
	[Address(RVA = "0x89C270", Offset = "0x89C270", VA = "0x89C270")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x6003B27")]
	[Address(RVA = "0x89C410", Offset = "0x89C410", VA = "0x89C410")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x6003B28")]
	[Address(RVA = "0x89C640", Offset = "0x89C640", VA = "0x89C640")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x6003B29")]
	[Address(RVA = "0x89CBA4", Offset = "0x89CBA4", VA = "0x89CBA4")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x6003B2A")]
	[Address(RVA = "0x89CFBC", Offset = "0x89CFBC", VA = "0x89CFBC")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x6003B2B")]
	[Address(RVA = "0x89D2FC", Offset = "0x89D2FC", VA = "0x89D2FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x624AF8", Offset = "0x624AF8")]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x6003B2C")]
	[Address(RVA = "0x89D368", Offset = "0x89D368", VA = "0x89D368")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x6003B2D")]
	[Address(RVA = "0x89DDF8", Offset = "0x89DDF8", VA = "0x89DDF8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x624B58", Offset = "0x624B58")]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x6003B2E")]
	[Address(RVA = "0x89DE64", Offset = "0x89DE64", VA = "0x89DE64")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x6003B2F")]
	[Address(RVA = "0x89DF44", Offset = "0x89DF44", VA = "0x89DF44")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x6003B30")]
	[Address(RVA = "0x89E028", Offset = "0x89E028", VA = "0x89E028")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x6003B31")]
	[Address(RVA = "0x89E0C8", Offset = "0x89E0C8", VA = "0x89E0C8")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x6003B32")]
	[Address(RVA = "0x89E28C", Offset = "0x89E28C", VA = "0x89E28C")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6003B33")]
	[Address(RVA = "0x89E2F8", Offset = "0x89E2F8", VA = "0x89E2F8")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6003B34")]
	[Address(RVA = "0x89E24C", Offset = "0x89E24C", VA = "0x89E24C")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x6003B35")]
	[Address(RVA = "0x89E348", Offset = "0x89E348", VA = "0x89E348")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003B36")]
	[Address(RVA = "0x89EE7C", Offset = "0x89EE7C", VA = "0x89EE7C")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6003B37")]
	[Address(RVA = "0x89E41C", Offset = "0x89E41C", VA = "0x89E41C")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003B38")]
	[Address(RVA = "0x89F058", Offset = "0x89F058", VA = "0x89F058")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6003B39")]
	[Address(RVA = "0x89F26C", Offset = "0x89F26C", VA = "0x89F26C")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003B3A")]
	[Address(RVA = "0x89F748", Offset = "0x89F748", VA = "0x89F748")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6003B3B")]
	[Address(RVA = "0x89F9AC", Offset = "0x89F9AC", VA = "0x89F9AC")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003B3C")]
	[Address(RVA = "0x8A002C", Offset = "0x8A002C", VA = "0x8A002C")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6003B3D")]
	[Address(RVA = "0x8A0230", Offset = "0x8A0230", VA = "0x8A0230")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003B3E")]
	[Address(RVA = "0x8A0880", Offset = "0x8A0880", VA = "0x8A0880")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6003B3F")]
	[Address(RVA = "0x8A0A84", Offset = "0x8A0A84", VA = "0x8A0A84")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003B40")]
	[Address(RVA = "0x8A1D7C", Offset = "0x8A1D7C", VA = "0x8A1D7C")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6003B41")]
	[Address(RVA = "0x8A13A0", Offset = "0x8A13A0", VA = "0x8A13A0")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003B42")]
	[Address(RVA = "0x8A1F80", Offset = "0x8A1F80", VA = "0x8A1F80")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6003B43")]
	[Address(RVA = "0x8A2184", Offset = "0x8A2184", VA = "0x8A2184")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6003B44")]
	[Address(RVA = "0x899D6C", Offset = "0x899D6C", VA = "0x899D6C")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6003B45")]
	[Address(RVA = "0x8A2720", Offset = "0x8A2720", VA = "0x8A2720")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6003B46")]
	[Address(RVA = "0x8A27CC", Offset = "0x8A27CC", VA = "0x8A27CC")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6003B47")]
	[Address(RVA = "0x8A2860", Offset = "0x8A2860", VA = "0x8A2860")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6003B48")]
	[Address(RVA = "0x8A29A0", Offset = "0x8A29A0", VA = "0x8A29A0")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6003B49")]
	[Address(RVA = "0x8A2AC8", Offset = "0x8A2AC8", VA = "0x8A2AC8")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6003B4A")]
	[Address(RVA = "0x8A2BDC", Offset = "0x8A2BDC", VA = "0x8A2BDC")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x6003B4B")]
	[Address(RVA = "0x8A2E74", Offset = "0x8A2E74", VA = "0x8A2E74")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6003B4C")]
	[Address(RVA = "0x8A2F40", Offset = "0x8A2F40", VA = "0x8A2F40")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x6003B4D")]
	[Address(RVA = "0x8A30D4", Offset = "0x8A30D4", VA = "0x8A30D4")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6003B4E")]
	[Address(RVA = "0x8A323C", Offset = "0x8A323C", VA = "0x8A323C")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x6003B4F")]
	[Address(RVA = "0x8A3334", Offset = "0x8A3334", VA = "0x8A3334")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6003B50")]
	[Address(RVA = "0x8A3400", Offset = "0x8A3400", VA = "0x8A3400")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x6003B51")]
	[Address(RVA = "0x8A3594", Offset = "0x8A3594", VA = "0x8A3594")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6003B52")]
	[Address(RVA = "0x8A36FC", Offset = "0x8A36FC", VA = "0x8A36FC")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x6003B53")]
	[Address(RVA = "0x8A37F4", Offset = "0x8A37F4", VA = "0x8A37F4")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6003B54")]
	[Address(RVA = "0x8A38C0", Offset = "0x8A38C0", VA = "0x8A38C0")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x6003B55")]
	[Address(RVA = "0x8A3A54", Offset = "0x8A3A54", VA = "0x8A3A54")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6003B56")]
	[Address(RVA = "0x8A3BBC", Offset = "0x8A3BBC", VA = "0x8A3BBC")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6003B57")]
	[Address(RVA = "0x8A3C30", Offset = "0x8A3C30", VA = "0x8A3C30")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x6003B58")]
	[Address(RVA = "0x8A3F48", Offset = "0x8A3F48", VA = "0x8A3F48")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6003B59")]
	[Address(RVA = "0x8A4014", Offset = "0x8A4014", VA = "0x8A4014")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x6003B5A")]
	[Address(RVA = "0x8A41A8", Offset = "0x8A41A8", VA = "0x8A41A8")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6003B5B")]
	[Address(RVA = "0x8A4310", Offset = "0x8A4310", VA = "0x8A4310")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x6003B5C")]
	[Address(RVA = "0x8A4408", Offset = "0x8A4408", VA = "0x8A4408")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6003B5D")]
	[Address(RVA = "0x8A44D4", Offset = "0x8A44D4", VA = "0x8A44D4")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x6003B5E")]
	[Address(RVA = "0x8A4668", Offset = "0x8A4668", VA = "0x8A4668")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6003B5F")]
	[Address(RVA = "0x8A47D0", Offset = "0x8A47D0", VA = "0x8A47D0")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x6003B60")]
	[Address(RVA = "0x8A48C8", Offset = "0x8A48C8", VA = "0x8A48C8")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6003B61")]
	[Address(RVA = "0x8A4994", Offset = "0x8A4994", VA = "0x8A4994")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x6003B62")]
	[Address(RVA = "0x8A4B28", Offset = "0x8A4B28", VA = "0x8A4B28")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6003B63")]
	[Address(RVA = "0x8A4C90", Offset = "0x8A4C90", VA = "0x8A4C90")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x6003B64")]
	[Address(RVA = "0x8A4D88", Offset = "0x8A4D88", VA = "0x8A4D88")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x6003B65")]
	[Address(RVA = "0x8A5088", Offset = "0x8A5088", VA = "0x8A5088")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x6003B66")]
	[Address(RVA = "0x8A51E8", Offset = "0x8A51E8", VA = "0x8A51E8")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x6003B67")]
	[Address(RVA = "0x8A55EC", Offset = "0x8A55EC", VA = "0x8A55EC")]
	public static void Resume()
	{
	}

	[Token(Token = "0x6003B68")]
	[Address(RVA = "0x8A5738", Offset = "0x8A5738", VA = "0x8A5738")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x6003B69")]
	[Address(RVA = "0x8A59A0", Offset = "0x8A59A0", VA = "0x8A59A0")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x6003B6A")]
	[Address(RVA = "0x8A5B00", Offset = "0x8A5B00", VA = "0x8A5B00")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x6003B6B")]
	[Address(RVA = "0x8A5E00", Offset = "0x8A5E00", VA = "0x8A5E00")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x6003B6C")]
	[Address(RVA = "0x8A5FC0", Offset = "0x8A5FC0", VA = "0x8A5FC0")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x6003B6D")]
	[Address(RVA = "0x8A641C", Offset = "0x8A641C", VA = "0x8A641C")]
	public static void Pause()
	{
	}

	[Token(Token = "0x6003B6E")]
	[Address(RVA = "0x8A6568", Offset = "0x8A6568", VA = "0x8A6568")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x6003B6F")]
	[Address(RVA = "0x8A67D0", Offset = "0x8A67D0", VA = "0x8A67D0")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x6003B70")]
	[Address(RVA = "0x8A684C", Offset = "0x8A684C", VA = "0x8A684C")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x6003B71")]
	[Address(RVA = "0x8A6A60", Offset = "0x8A6A60", VA = "0x8A6A60")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x6003B72")]
	[Address(RVA = "0x8A6AC0", Offset = "0x8A6AC0", VA = "0x8A6AC0")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x6003B73")]
	[Address(RVA = "0x8A6C24", Offset = "0x8A6C24", VA = "0x8A6C24")]
	public static void Stop()
	{
	}

	[Token(Token = "0x6003B74")]
	[Address(RVA = "0x8A6E9C", Offset = "0x8A6E9C", VA = "0x8A6E9C")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x6003B75")]
	[Address(RVA = "0x8A725C", Offset = "0x8A725C", VA = "0x8A725C")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x6003B76")]
	[Address(RVA = "0x8A6DAC", Offset = "0x8A6DAC", VA = "0x8A6DAC")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x6003B77")]
	[Address(RVA = "0x8A75DC", Offset = "0x8A75DC", VA = "0x8A75DC")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x6003B78")]
	[Address(RVA = "0x8A7104", Offset = "0x8A7104", VA = "0x8A7104")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x6003B79")]
	[Address(RVA = "0x8A74C4", Offset = "0x8A74C4", VA = "0x8A74C4")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x6003B7A")]
	[Address(RVA = "0x8A78DC", Offset = "0x8A78DC", VA = "0x8A78DC")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x6003B7B")]
	[Address(RVA = "0x8A7CD8", Offset = "0x8A7CD8", VA = "0x8A7CD8")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x6003B7C")]
	[Address(RVA = "0x88A33C", Offset = "0x88A33C", VA = "0x88A33C")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x6003B7D")]
	[Address(RVA = "0x8A808C", Offset = "0x8A808C", VA = "0x8A808C")]
	private iTween(Hashtable h)
	{
	}

	[Token(Token = "0x6003B7E")]
	[Address(RVA = "0x8A80B8", Offset = "0x8A80B8", VA = "0x8A80B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003B7F")]
	[Address(RVA = "0x8A9440", Offset = "0x8A9440", VA = "0x8A9440")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x624BB8", Offset = "0x624BB8")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6003B80")]
	[Address(RVA = "0x8A94AC", Offset = "0x8A94AC", VA = "0x8A94AC")]
	private void Update()
	{
	}

	[Token(Token = "0x6003B81")]
	[Address(RVA = "0x8A94EC", Offset = "0x8A94EC", VA = "0x8A94EC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003B82")]
	[Address(RVA = "0x8A952C", Offset = "0x8A952C", VA = "0x8A952C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6003B83")]
	[Address(RVA = "0x8A966C", Offset = "0x8A966C", VA = "0x8A966C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003B84")]
	[Address(RVA = "0x8A96E4", Offset = "0x8A96E4", VA = "0x8A96E4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6003B85")]
	[Address(RVA = "0x8A2CD4", Offset = "0x8A2CD4", VA = "0x8A2CD4")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x6003B86")]
	[Address(RVA = "0x8A3D28", Offset = "0x8A3D28", VA = "0x8A3D28")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x6003B87")]
	[Address(RVA = "0x8A235C", Offset = "0x8A235C", VA = "0x8A235C")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x6003B88")]
	[Address(RVA = "0x8A256C", Offset = "0x8A256C", VA = "0x8A256C")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6003B89")]
	[Address(RVA = "0x889FE0", Offset = "0x889FE0", VA = "0x889FE0")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6003B8A")]
	[Address(RVA = "0x8895C4", Offset = "0x8895C4", VA = "0x8895C4")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x6003B8B")]
	[Address(RVA = "0x8A96E8", Offset = "0x8A96E8", VA = "0x8A96E8")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x6003B8C")]
	[Address(RVA = "0x8A80F4", Offset = "0x8A80F4", VA = "0x8A80F4")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x6003B8D")]
	[Address(RVA = "0x8A9764", Offset = "0x8A9764", VA = "0x8A9764")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x6003B8E")]
	[Address(RVA = "0x89DECC", Offset = "0x89DECC", VA = "0x89DECC")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x6003B8F")]
	[Address(RVA = "0x89D53C", Offset = "0x89D53C", VA = "0x89D53C")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x6003B90")]
	[Address(RVA = "0x899B28", Offset = "0x899B28", VA = "0x899B28")]
	private void Dispose()
	{
	}

	[Token(Token = "0x6003B91")]
	[Address(RVA = "0x89D87C", Offset = "0x89D87C", VA = "0x89D87C")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x6003B92")]
	[Address(RVA = "0x89DDF4", Offset = "0x89DDF4", VA = "0x89DDF4")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x6003B93")]
	[Address(RVA = "0x89E0C4", Offset = "0x89E0C4", VA = "0x89E0C4")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x6003B94")]
	[Address(RVA = "0x8A9694", Offset = "0x8A9694", VA = "0x8A9694")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x6003B95")]
	[Address(RVA = "0x8A9CD4", Offset = "0x8A9CD4", VA = "0x8A9CD4")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003B96")]
	[Address(RVA = "0x899D08", Offset = "0x899D08", VA = "0x899D08")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003B97")]
	[Address(RVA = "0x8A9CDC", Offset = "0x8A9CDC", VA = "0x8A9CDC")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003B98")]
	[Address(RVA = "0x8A9D90", Offset = "0x8A9D90", VA = "0x8A9D90")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003B99")]
	[Address(RVA = "0x8A9DA4", Offset = "0x8A9DA4", VA = "0x8A9DA4")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003B9A")]
	[Address(RVA = "0x8A9DC0", Offset = "0x8A9DC0", VA = "0x8A9DC0")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003B9B")]
	[Address(RVA = "0x8A9E14", Offset = "0x8A9E14", VA = "0x8A9E14")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003B9C")]
	[Address(RVA = "0x8A9E2C", Offset = "0x8A9E2C", VA = "0x8A9E2C")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003B9D")]
	[Address(RVA = "0x8A9E54", Offset = "0x8A9E54", VA = "0x8A9E54")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003B9E")]
	[Address(RVA = "0x8A9EAC", Offset = "0x8A9EAC", VA = "0x8A9EAC")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003B9F")]
	[Address(RVA = "0x8A9EC8", Offset = "0x8A9EC8", VA = "0x8A9EC8")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BA0")]
	[Address(RVA = "0x8A9EF0", Offset = "0x8A9EF0", VA = "0x8A9EF0")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BA1")]
	[Address(RVA = "0x8A9F4C", Offset = "0x8A9F4C", VA = "0x8A9F4C")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BA2")]
	[Address(RVA = "0x8A9F6C", Offset = "0x8A9F6C", VA = "0x8A9F6C")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BA3")]
	[Address(RVA = "0x8A9F9C", Offset = "0x8A9F9C", VA = "0x8A9F9C")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BA4")]
	[Address(RVA = "0x8AA004", Offset = "0x8AA004", VA = "0x8AA004")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BA5")]
	[Address(RVA = "0x8AA040", Offset = "0x8AA040", VA = "0x8AA040")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BA6")]
	[Address(RVA = "0x8AA078", Offset = "0x8AA078", VA = "0x8AA078")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BA7")]
	[Address(RVA = "0x8AA0C0", Offset = "0x8AA0C0", VA = "0x8AA0C0")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BA8")]
	[Address(RVA = "0x8AA0FC", Offset = "0x8AA0FC", VA = "0x8AA0FC")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BA9")]
	[Address(RVA = "0x8AA138", Offset = "0x8AA138", VA = "0x8AA138")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BAA")]
	[Address(RVA = "0x8AA1AC", Offset = "0x8AA1AC", VA = "0x8AA1AC")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BAB")]
	[Address(RVA = "0x8AA1FC", Offset = "0x8AA1FC", VA = "0x8AA1FC")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BAC")]
	[Address(RVA = "0x8AA24C", Offset = "0x8AA24C", VA = "0x8AA24C")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BAD")]
	[Address(RVA = "0x8AA2D0", Offset = "0x8AA2D0", VA = "0x8AA2D0")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BAE")]
	[Address(RVA = "0x8AA30C", Offset = "0x8AA30C", VA = "0x8AA30C")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BAF")]
	[Address(RVA = "0x8AA3D8", Offset = "0x8AA3D8", VA = "0x8AA3D8")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BB0")]
	[Address(RVA = "0x8AA45C", Offset = "0x8AA45C", VA = "0x8AA45C")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BB1")]
	[Address(RVA = "0x8AA48C", Offset = "0x8AA48C", VA = "0x8AA48C")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BB2")]
	[Address(RVA = "0x8AA4CC", Offset = "0x8AA4CC", VA = "0x8AA4CC")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BB3")]
	[Address(RVA = "0x89CB30", Offset = "0x89CB30", VA = "0x89CB30")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BB4")]
	[Address(RVA = "0x8AA550", Offset = "0x8AA550", VA = "0x8AA550")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BB5")]
	[Address(RVA = "0x8AA5E4", Offset = "0x8AA5E4", VA = "0x8AA5E4")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003BB6")]
	[Address(RVA = "0x8AA678", Offset = "0x8AA678", VA = "0x8AA678")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
