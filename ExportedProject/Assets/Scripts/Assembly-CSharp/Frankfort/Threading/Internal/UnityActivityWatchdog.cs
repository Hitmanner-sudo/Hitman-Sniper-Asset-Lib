using Il2CppDummyDll;
using UnityEngine;

namespace Frankfort.Threading.Internal
{
	[Token(Token = "0x2000A44")]
	public class UnityActivityWatchdog : MonoBehaviour
	{
		[Token(Token = "0x4003589")]
		[FieldOffset(Offset = "0x0")]
		private static bool helperCreated;

		[Token(Token = "0x400358A")]
		[FieldOffset(Offset = "0x1")]
		private static bool unityRunning;

		[Token(Token = "0x400358B")]
		[FieldOffset(Offset = "0x2")]
		private static bool unityPaused;

		[Token(Token = "0x400358C")]
		[FieldOffset(Offset = "0x3")]
		private static bool unityFocused;

		[Token(Token = "0x400358D")]
		[FieldOffset(Offset = "0x4")]
		private static bool combinedActive;

		[Token(Token = "0x6004112")]
		[Address(RVA = "0xB9ABAC", Offset = "0xB9ABAC", VA = "0xB9ABAC")]
		public static bool CheckUnityActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6004113")]
		[Address(RVA = "0xB9AC9C", Offset = "0xB9AC9C", VA = "0xB9AC9C")]
		public static void SleepOrAbortIfUnityInactive()
		{
		}

		[Token(Token = "0x6004114")]
		[Address(RVA = "0xB9AC14", Offset = "0xB9AC14", VA = "0xB9AC14")]
		public static void Init()
		{
		}

		[Token(Token = "0x6004115")]
		[Address(RVA = "0xB9ADAC", Offset = "0xB9ADAC", VA = "0xB9ADAC")]
		private static void CreateHelperGameObject()
		{
		}

		[Token(Token = "0x6004116")]
		[Address(RVA = "0xB9AED4", Offset = "0xB9AED4", VA = "0xB9AED4")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6004117")]
		[Address(RVA = "0xB9B010", Offset = "0xB9B010", VA = "0xB9B010")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x6004118")]
		[Address(RVA = "0xB9B07C", Offset = "0xB9B07C", VA = "0xB9B07C")]
		private void OnApplicationFocus(bool focus)
		{
		}

		[Token(Token = "0x6004119")]
		[Address(RVA = "0xB9AF38", Offset = "0xB9AF38", VA = "0xB9AF38")]
		private static void UpdateStatus()
		{
		}

		[Token(Token = "0x600411A")]
		[Address(RVA = "0xB9B0E8", Offset = "0xB9B0E8", VA = "0xB9B0E8")]
		public UnityActivityWatchdog()
		{
		}
	}
}
