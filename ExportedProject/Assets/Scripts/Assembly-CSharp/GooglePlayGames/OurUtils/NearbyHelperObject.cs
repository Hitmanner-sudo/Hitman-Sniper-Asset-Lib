using System;
using GooglePlayGames.BasicApi.Nearby;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.OurUtils
{
	[Token(Token = "0x20009D7")]
	public class NearbyHelperObject : MonoBehaviour
	{
		[Token(Token = "0x4003417")]
		[FieldOffset(Offset = "0x0")]
		private static NearbyHelperObject instance;

		[Token(Token = "0x4003418")]
		[FieldOffset(Offset = "0x8")]
		private static double mAdvertisingRemaining;

		[Token(Token = "0x4003419")]
		[FieldOffset(Offset = "0x10")]
		private static double mDiscoveryRemaining;

		[Token(Token = "0x400341A")]
		[FieldOffset(Offset = "0x18")]
		private static INearbyConnectionClient mClient;

		[Token(Token = "0x6003E56")]
		[Address(RVA = "0xC58E78", Offset = "0xC58E78", VA = "0xC58E78")]
		public static void CreateObject(INearbyConnectionClient client)
		{
		}

		[Token(Token = "0x6003E57")]
		[Address(RVA = "0xC59038", Offset = "0xC59038", VA = "0xC59038")]
		private static double ToSeconds(TimeSpan? span)
		{
			return default(double);
		}

		[Token(Token = "0x6003E58")]
		[Address(RVA = "0xC590F4", Offset = "0xC590F4", VA = "0xC590F4")]
		public static void StartAdvertisingTimer(TimeSpan? span)
		{
		}

		[Token(Token = "0x6003E59")]
		[Address(RVA = "0xC59174", Offset = "0xC59174", VA = "0xC59174")]
		public static void StartDiscoveryTimer(TimeSpan? span)
		{
		}

		[Token(Token = "0x6003E5A")]
		[Address(RVA = "0xC591F4", Offset = "0xC591F4", VA = "0xC591F4")]
		public void Awake()
		{
		}

		[Token(Token = "0x6003E5B")]
		[Address(RVA = "0xC5926C", Offset = "0xC5926C", VA = "0xC5926C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6003E5C")]
		[Address(RVA = "0xC59344", Offset = "0xC59344", VA = "0xC59344")]
		public void Update()
		{
		}

		[Token(Token = "0x6003E5D")]
		[Address(RVA = "0xC59030", Offset = "0xC59030", VA = "0xC59030")]
		public NearbyHelperObject()
		{
		}
	}
}
