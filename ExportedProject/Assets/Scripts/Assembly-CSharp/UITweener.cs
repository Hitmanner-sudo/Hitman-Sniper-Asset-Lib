using System.Collections.Generic;
using AnimationOrTween;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000079")]
public abstract class UITweener : MonoBehaviour
{
	[Token(Token = "0x200007A")]
	public enum Method
	{
		[Token(Token = "0x4000285")]
		Linear = 0,
		[Token(Token = "0x4000286")]
		EaseIn = 1,
		[Token(Token = "0x4000287")]
		EaseOut = 2,
		[Token(Token = "0x4000288")]
		EaseInOut = 3,
		[Token(Token = "0x4000289")]
		BounceIn = 4,
		[Token(Token = "0x400028A")]
		BounceOut = 5
	}

	[Token(Token = "0x200007B")]
	public enum Style
	{
		[Token(Token = "0x400028C")]
		Once = 0,
		[Token(Token = "0x400028D")]
		Loop = 1,
		[Token(Token = "0x400028E")]
		PingPong = 2
	}

	[Token(Token = "0x200007C")]
	public enum TimerType
	{
		[Token(Token = "0x4000290")]
		InputTime = 0,
		[Token(Token = "0x4000291")]
		GameTime = 1,
		[Token(Token = "0x4000292")]
		GameRealTime = 2
	}

	[Token(Token = "0x400026B")]
	[FieldOffset(Offset = "0x0")]
	public static UITweener current;

	[Token(Token = "0x400026C")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Method method;

	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public Style style;

	[Token(Token = "0x400026E")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public AnimationCurve animationCurve;

	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public bool ignoreTimeScale;

	[Token(Token = "0x4000270")]
	[FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public float delay;

	[Token(Token = "0x4000271")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public bool randomDelay;

	[Token(Token = "0x4000272")]
	[FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public float minDelay;

	[Token(Token = "0x4000273")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public float maxDelay;

	[Token(Token = "0x4000274")]
	[FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public float duration;

	[Token(Token = "0x4000275")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public bool randomDuration;

	[Token(Token = "0x4000276")]
	[FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public float minDuration;

	[Token(Token = "0x4000277")]
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public float maxDuration;

	[Token(Token = "0x4000278")]
	[FieldOffset(Offset = "0x4C")]
	[HideInInspector]
	public bool steeperCurves;

	[Token(Token = "0x4000279")]
	[FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public int tweenGroup;

	[Token(Token = "0x400027A")]
	[FieldOffset(Offset = "0x54")]
	public bool UseGlobalTimer;

	[Token(Token = "0x400027B")]
	[FieldOffset(Offset = "0x58")]
	public TimerType Timer;

	[Token(Token = "0x400027C")]
	[FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public List<EventDelegate> onFinished;

	[Token(Token = "0x400027D")]
	[FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public GameObject eventReceiver;

	[Token(Token = "0x400027E")]
	[FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public string callWhenFinished;

	[Token(Token = "0x400027F")]
	[FieldOffset(Offset = "0x78")]
	private bool mStarted;

	[Token(Token = "0x4000280")]
	[FieldOffset(Offset = "0x7C")]
	private float mStartTime;

	[Token(Token = "0x4000281")]
	[FieldOffset(Offset = "0x80")]
	private float mDuration;

	[Token(Token = "0x4000282")]
	[FieldOffset(Offset = "0x84")]
	private float mAmountPerDelta;

	[Token(Token = "0x4000283")]
	[FieldOffset(Offset = "0x88")]
	private float mFactor;

	[Token(Token = "0x1700009C")]
	public float amountPerDelta
	{
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1170C18", Offset = "0x1170C18", VA = "0x1170C18")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700009D")]
	public float tweenFactor
	{
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1170C54", Offset = "0x1170C54", VA = "0x1170C54")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1170C5C", Offset = "0x1170C5C", VA = "0x1170C5C")]
		set
		{
		}
	}

	[Token(Token = "0x1700009E")]
	public Direction direction
	{
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1170C84", Offset = "0x1170C84", VA = "0x1170C84")]
		get
		{
			return default(Direction);
		}
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x1170C98", Offset = "0x1170C98", VA = "0x1170C98")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x1170CE4", Offset = "0x1170CE4", VA = "0x1170CE4")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x1170CE8", Offset = "0x1170CE8", VA = "0x1170CE8")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x11712D4", Offset = "0x11712D4", VA = "0x11712D4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x1171170", Offset = "0x1171170", VA = "0x1171170")]
	public void Sample(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x1171344", Offset = "0x1171344", VA = "0x1171344")]
	private float BounceLogic(float val)
	{
		return default(float);
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x1171404", Offset = "0x1171404", VA = "0x1171404")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x611B48", Offset = "0x611B48")]
	public void Play()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x1171488", Offset = "0x1171488", VA = "0x1171488")]
	public void PlayForward()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x1171490", Offset = "0x1171490", VA = "0x1171490")]
	public void PlayReverse()
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x117140C", Offset = "0x117140C", VA = "0x117140C")]
	public void Play(bool forward)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x1171498", Offset = "0x1171498", VA = "0x1171498")]
	public void Reset()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x11714CC", Offset = "0x11714CC", VA = "0x11714CC")]
	public void Toggle()
	{
	}

	[Token(Token = "0x60003BC")]
	protected abstract void OnUpdate(float factor, bool isFinished);

	[Token(Token = "0x60003BD")]
	public static T Begin<T>(GameObject go, float duration) where T : UITweener
	{
		return null;
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x1171528", Offset = "0x1171528", VA = "0x1171528")]
	protected UITweener()
	{
	}
}
