using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001E8")]
public class GameplayConfig : BaseConfig<GameplayConfig>
{
	[Serializable]
	[Token(Token = "0x20001E9")]
	public class SwayGradeData
	{
		[Token(Token = "0x4000B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Amplitude;

		[Token(Token = "0x4000B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Stability;

		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x873264", Offset = "0x873264", VA = "0x873264")]
		public SwayGradeData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001EA")]
	public class FireRateGradeData
	{
		[Token(Token = "0x4000B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float ShootDelay;

		[Token(Token = "0x4000B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float RecoveryTime;

		[Token(Token = "0x4000B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float BoltCycleDelay;

		[Token(Token = "0x4000B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool IgnoreInUICalculation;

		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x8730F4", Offset = "0x8730F4", VA = "0x8730F4")]
		public FireRateGradeData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001EB")]
	public class SlowMotionSystemSettings
	{
		[Token(Token = "0x4000B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float SlowFactor;

		[Token(Token = "0x4000B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float PlayerTimeSlowFactor;

		[Token(Token = "0x4000B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float HeadShotSlowMotionDuration;

		[Token(Token = "0x4000B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SlowMotionMaxDuration;

		[Token(Token = "0x4000B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve SlowMotionRefillRateCurve;

		[Token(Token = "0x4000B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float MinimumRatioToBeActivated;

		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x873104", Offset = "0x873104", VA = "0x873104")]
		public SlowMotionSystemSettings()
		{
		}
	}

	[Token(Token = "0x20001EC")]
	public struct MinMaxValue<T>
	{
		[Token(Token = "0x4000B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Min;

		[Token(Token = "0x4000B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Max;
	}

	[Serializable]
	[Token(Token = "0x20001ED")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5929FC", Offset = "0x5929FC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<SwayGradeData, float> _003C_003E9__22_0;

		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x8730D4", Offset = "0x8730D4", VA = "0x8730D4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x8730DC", Offset = "0x8730DC", VA = "0x8730DC")]
		internal float _003CGetMinMaxStability_003Eb__22_0(SwayGradeData s)
		{
			return default(float);
		}
	}

	[Token(Token = "0x4000B07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int MissionAttemptCountBeforeCompleteButton;

	[Token(Token = "0x4000B08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int BulletImpactMaxDisplayCount;

	[Token(Token = "0x4000B09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int MissionTimerBlinkDuration;

	[Token(Token = "0x4000B0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<float> ScoreMultiplierGrades;

	[Token(Token = "0x4000B0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<int> ClipSizeGrades;

	[Token(Token = "0x4000B0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<float> MaxZoomGrades;

	[Token(Token = "0x4000B0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public SlowMotionSystemSettings SlowMotionSettings;

	[Token(Token = "0x4000B0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<SwayGradeData> SwayGrades;

	[Token(Token = "0x4000B0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<FireRateGradeData> FireRateGrades;

	[Token(Token = "0x6000C07")]
	public virtual T GetDataForGradeIndex<T>(List<T> listData, int index, T defaultData)
	{
		return (T)null;
	}

	[Token(Token = "0x6000C08")]
	[Address(RVA = "0xD9C9BC", Offset = "0xD9C9BC", VA = "0xD9C9BC", Slot = "11")]
	public virtual bool GetDamageForGrade(int index, ref int bulletDamage, int defaultData = -1)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C09")]
	[Address(RVA = "0xD9C9C4", Offset = "0xD9C9C4", VA = "0xD9C9C4", Slot = "12")]
	public virtual bool GetBulletSpeedForGrade(int index, ref float bulletSpeed, float defaultData = -1f)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C0A")]
	[Address(RVA = "0xD9C9CC", Offset = "0xD9C9CC", VA = "0xD9C9CC", Slot = "13")]
	public virtual float GetScoreMultiplierForGrade(int index, float defaultData = -1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000C0B")]
	[Address(RVA = "0xD9CA5C", Offset = "0xD9CA5C", VA = "0xD9CA5C", Slot = "14")]
	public virtual int GetClipSizeForGrade(int index, int defaultData = -1)
	{
		return default(int);
	}

	[Token(Token = "0x6000C0C")]
	[Address(RVA = "0xD9CAE4", Offset = "0xD9CAE4", VA = "0xD9CAE4", Slot = "15")]
	public virtual float GetMaxZoomForGrade(int index, float defaultData = -1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000C0D")]
	[Address(RVA = "0xD9CB74", Offset = "0xD9CB74", VA = "0xD9CB74", Slot = "16")]
	public virtual SwayGradeData GetSwayForGrade(int index, [Optional] SwayGradeData defaultData)
	{
		return null;
	}

	[Token(Token = "0x6000C0E")]
	[Address(RVA = "0xD9CBFC", Offset = "0xD9CBFC", VA = "0xD9CBFC", Slot = "17")]
	public virtual FireRateGradeData GetFireRateForGrade(int index, [Optional] FireRateGradeData defaultData)
	{
		return null;
	}

	[Token(Token = "0x6000C0F")]
	[Address(RVA = "0xD9CC84", Offset = "0xD9CC84", VA = "0xD9CC84")]
	public MinMaxValue<float> GetMinMaxScoreMultiplier()
	{
		return default(MinMaxValue<float>);
	}

	[Token(Token = "0x6000C10")]
	[Address(RVA = "0xD9CD20", Offset = "0xD9CD20", VA = "0xD9CD20")]
	public MinMaxValue<float> GetMinMaxStability()
	{
		return default(MinMaxValue<float>);
	}

	[Token(Token = "0x6000C11")]
	[Address(RVA = "0xD9D150", Offset = "0xD9D150", VA = "0xD9D150")]
	public MinMaxValue<int> GetMinMaxClipSize()
	{
		return default(MinMaxValue<int>);
	}

	[Token(Token = "0x6000C12")]
	[Address(RVA = "0xD9D1F4", Offset = "0xD9D1F4", VA = "0xD9D1F4")]
	public MinMaxValue<float> GetMinMaxMaxZoom()
	{
		return default(MinMaxValue<float>);
	}

	[Token(Token = "0x6000C13")]
	[Address(RVA = "0xD9D290", Offset = "0xD9D290", VA = "0xD9D290")]
	public MinMaxValue<int> GetMinMaxFireRate(int highestUpgrade)
	{
		return default(MinMaxValue<int>);
	}

	[Token(Token = "0x6000C14")]
	public int GetMaxLevel<T>(List<T> listData)
	{
		return default(int);
	}

	[Token(Token = "0x6000C15")]
	[Address(RVA = "0xD9D3E4", Offset = "0xD9D3E4", VA = "0xD9D3E4")]
	public GameplayConfig()
	{
	}
}
