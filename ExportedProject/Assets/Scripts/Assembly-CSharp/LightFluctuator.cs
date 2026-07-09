using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001B9")]
public class LightFluctuator : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20001BA")]
	public class IntensitySetting : BaseSetting<float>
	{
		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x3C")]
		public float TargetedIntensity;

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x8C1698", Offset = "0x8C1698", VA = "0x8C1698", Slot = "4")]
		protected override void SetStartingValue(Light[] lights)
		{
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x8C16E4", Offset = "0x8C16E4", VA = "0x8C16E4", Slot = "5")]
		protected override void ApplyEffect(Light[] lights, float ratio)
		{
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x8C1774", Offset = "0x8C1774", VA = "0x8C1774")]
		public IntensitySetting()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001BB")]
	public class ColorSetting : BaseSetting<Color>
	{
		[Token(Token = "0x4000971")]
		[FieldOffset(Offset = "0x44")]
		public Color TargetedColor;

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x8C1538", Offset = "0x8C1538", VA = "0x8C1538", Slot = "4")]
		protected override void SetStartingValue(Light[] lights)
		{
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x8C1588", Offset = "0x8C1588", VA = "0x8C1588", Slot = "5")]
		protected override void ApplyEffect(Light[] lights, float ratio)
		{
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x8C164C", Offset = "0x8C164C", VA = "0x8C164C")]
		public ColorSetting()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001BC")]
	public abstract class BaseSetting<T>
	{
		[Token(Token = "0x20001BD")]
		private enum State
		{
			[Token(Token = "0x4000979")]
			NotStarted = 0,
			[Token(Token = "0x400097A")]
			ApplyEffect = 1,
			[Token(Token = "0x400097B")]
			Stay = 2
		}

		[Token(Token = "0x4000972")]
		[FieldOffset(Offset = "0x0")]
		public MinMaxValue ApplyEffectTime;

		[Token(Token = "0x4000973")]
		[FieldOffset(Offset = "0x0")]
		public MinMaxValue StayTime;

		[Token(Token = "0x4000974")]
		[FieldOffset(Offset = "0x0")]
		public AnimationCurve AnimationCurve;

		[Token(Token = "0x4000975")]
		[FieldOffset(Offset = "0x0")]
		protected T _startingValue;

		[Token(Token = "0x4000976")]
		[FieldOffset(Offset = "0x0")]
		private GameTimer _timer;

		[Token(Token = "0x4000977")]
		[FieldOffset(Offset = "0x0")]
		private State _state;

		[Token(Token = "0x6000B8C")]
		protected abstract void SetStartingValue(Light[] lights);

		[Token(Token = "0x6000B8D")]
		protected abstract void ApplyEffect(Light[] lights, float ratio);

		[Token(Token = "0x6000B8E")]
		public bool DoUpdate(Light[] lights)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B8F")]
		protected BaseSetting()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001BE")]
	public struct MinMaxValue
	{
		[Token(Token = "0x400097C")]
		[FieldOffset(Offset = "0x0")]
		public float Min;

		[Token(Token = "0x400097D")]
		[FieldOffset(Offset = "0x4")]
		public float Max;
	}

	[Token(Token = "0x400096B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Light[] _lights;

	[Token(Token = "0x400096C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private IntensitySetting[] _intensitySettings;

	[Token(Token = "0x400096D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ColorSetting[] _colorSettings;

	[Token(Token = "0x400096E")]
	[FieldOffset(Offset = "0x30")]
	private int _currentIntensityIndex;

	[Token(Token = "0x400096F")]
	[FieldOffset(Offset = "0x34")]
	private int _currentColorIndex;

	[Token(Token = "0x6000B82")]
	[Address(RVA = "0x9C8A1C", Offset = "0x9C8A1C", VA = "0x9C8A1C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000B83")]
	[Address(RVA = "0x9C8A3C", Offset = "0x9C8A3C", VA = "0x9C8A3C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000B84")]
	private void UpdateSetting<T, S>(ref int index, T[] array) where T : BaseSetting<S>
	{
	}

	[Token(Token = "0x6000B85")]
	[Address(RVA = "0x9C8AB8", Offset = "0x9C8AB8", VA = "0x9C8AB8")]
	public LightFluctuator()
	{
	}
}
