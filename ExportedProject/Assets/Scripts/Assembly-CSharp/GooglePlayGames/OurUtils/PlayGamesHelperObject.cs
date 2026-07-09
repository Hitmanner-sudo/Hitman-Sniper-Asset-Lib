using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.OurUtils
{
	[Token(Token = "0x20009D9")]
	public class PlayGamesHelperObject : MonoBehaviour
	{
		[Token(Token = "0x20009DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59771C", Offset = "0x59771C")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x4003422")]
			[FieldOffset(Offset = "0x10")]
			public IEnumerator action;

			[Token(Token = "0x6003E6E")]
			[Address(RVA = "0x8D15B4", Offset = "0x8D15B4", VA = "0x8D15B4")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6003E6F")]
			[Address(RVA = "0x8D15BC", Offset = "0x8D15BC", VA = "0x8D15BC")]
			internal void _003CRunCoroutine_003Eb__0()
			{
			}
		}

		[Token(Token = "0x400341B")]
		[FieldOffset(Offset = "0x0")]
		private static PlayGamesHelperObject instance;

		[Token(Token = "0x400341C")]
		[FieldOffset(Offset = "0x8")]
		private static bool sIsDummy;

		[Token(Token = "0x400341D")]
		[FieldOffset(Offset = "0x10")]
		private static List<Action> sQueue;

		[Token(Token = "0x400341E")]
		[FieldOffset(Offset = "0x18")]
		private List<Action> localQueue;

		[Token(Token = "0x400341F")]
		[FieldOffset(Offset = "0x18")]
		private static bool sQueueEmpty;

		[Token(Token = "0x4003420")]
		[FieldOffset(Offset = "0x20")]
		private static List<Action<bool>> sPauseCallbackList;

		[Token(Token = "0x4003421")]
		[FieldOffset(Offset = "0x28")]
		private static List<Action<bool>> sFocusCallbackList;

		[Token(Token = "0x6003E60")]
		[Address(RVA = "0xB75C64", Offset = "0xB75C64", VA = "0xB75C64")]
		public static void CreateObject()
		{
		}

		[Token(Token = "0x6003E61")]
		[Address(RVA = "0xB75E98", Offset = "0xB75E98", VA = "0xB75E98")]
		public void Awake()
		{
		}

		[Token(Token = "0x6003E62")]
		[Address(RVA = "0xB75F10", Offset = "0xB75F10", VA = "0xB75F10")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6003E63")]
		[Address(RVA = "0xB75FE8", Offset = "0xB75FE8", VA = "0xB75FE8")]
		public static void RunCoroutine(IEnumerator action)
		{
		}

		[Token(Token = "0x6003E64")]
		[Address(RVA = "0xB76140", Offset = "0xB76140", VA = "0xB76140")]
		public static void RunOnGameThread(Action action)
		{
		}

		[Token(Token = "0x6003E65")]
		[Address(RVA = "0xB7631C", Offset = "0xB7631C", VA = "0xB7631C")]
		public void Update()
		{
		}

		[Token(Token = "0x6003E66")]
		[Address(RVA = "0xB76590", Offset = "0xB76590", VA = "0xB76590")]
		public void OnApplicationFocus(bool focused)
		{
		}

		[Token(Token = "0x6003E67")]
		[Address(RVA = "0xB768CC", Offset = "0xB768CC", VA = "0xB768CC")]
		public void OnApplicationPause(bool paused)
		{
		}

		[Token(Token = "0x6003E68")]
		[Address(RVA = "0xB76C08", Offset = "0xB76C08", VA = "0xB76C08")]
		public static void AddFocusCallback(Action<bool> callback)
		{
		}

		[Token(Token = "0x6003E69")]
		[Address(RVA = "0xB76CEC", Offset = "0xB76CEC", VA = "0xB76CEC")]
		public static bool RemoveFocusCallback(Action<bool> callback)
		{
			return default(bool);
		}

		[Token(Token = "0x6003E6A")]
		[Address(RVA = "0xB76D78", Offset = "0xB76D78", VA = "0xB76D78")]
		public static void AddPauseCallback(Action<bool> callback)
		{
		}

		[Token(Token = "0x6003E6B")]
		[Address(RVA = "0xB76E5C", Offset = "0xB76E5C", VA = "0xB76E5C")]
		public static bool RemovePauseCallback(Action<bool> callback)
		{
			return default(bool);
		}

		[Token(Token = "0x6003E6C")]
		[Address(RVA = "0xB75E20", Offset = "0xB75E20", VA = "0xB75E20")]
		public PlayGamesHelperObject()
		{
		}
	}
}
