using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000AC1")]
	public static class NativeActivityManager
	{
		[Token(Token = "0x2000AC2")]
		private static class JSONSchema
		{
			[Token(Token = "0x4003727")]
			public const string GUID = "guid";

			[Token(Token = "0x4003728")]
			public const string RECEIVER = "receiver";

			[Token(Token = "0x4003729")]
			public const string PAYLOAD = "payload";
		}

		[Token(Token = "0x2000AC3")]
		public delegate void RegisterNativeDelegate(string guid, string receiverObject, string receiverName);

		[Token(Token = "0x4003721")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly string StateSuccess;

		[Token(Token = "0x4003722")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly string StateCancelled;

		[Token(Token = "0x4003723")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly string StateFailure;

		[Token(Token = "0x4003724")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Dictionary<string, AndroidJavaObject> _pluginDictionary;

		[Token(Token = "0x4003725")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Dictionary<string, NativeResponseAction> _responseDictionary;

		[Token(Token = "0x4003726")]
		[FieldOffset(Offset = "0x28")]
		private static readonly Dictionary<string, NativeResponseAction> _receiverDictionary;

		[Token(Token = "0x600432C")]
		[Address(RVA = "0xC56060", Offset = "0xC56060", VA = "0xC56060")]
		static NativeActivityManager()
		{
		}

		[Token(Token = "0x600432D")]
		[Address(RVA = "0xC56424", Offset = "0xC56424", VA = "0xC56424")]
		private static void HandleOnMessageReceived(string json)
		{
		}

		[Token(Token = "0x600432E")]
		[Address(RVA = "0xC56624", Offset = "0xC56624", VA = "0xC56624")]
		public static void RegisterReceiver(string receiverTag, NativeResponseAction responseAction)
		{
		}

		[Token(Token = "0x600432F")]
		[Address(RVA = "0xC5671C", Offset = "0xC5671C", VA = "0xC5671C")]
		public static void UnregisterReceiver(string receiverTag)
		{
		}

		[Token(Token = "0x6004330")]
		[Address(RVA = "0xC56800", Offset = "0xC56800", VA = "0xC56800")]
		public static void RegisterPlugin(string pluginClass)
		{
		}

		[Token(Token = "0x6004331")]
		[Address(RVA = "0xC569C0", Offset = "0xC569C0", VA = "0xC569C0")]
		public static void UnregisterPlugin(string pluginClass)
		{
		}

		[Token(Token = "0x6004332")]
		public static T Call<T>(string classpath, string methodName, params object[] methodParams)
		{
			return (T)null;
		}

		[Token(Token = "0x6004333")]
		[Address(RVA = "0xC56ABC", Offset = "0xC56ABC", VA = "0xC56ABC")]
		public static void Call(string classpath, string methodName, params object[] methodParams)
		{
		}

		[Token(Token = "0x6004334")]
		[Address(RVA = "0xC56D48", Offset = "0xC56D48", VA = "0xC56D48")]
		public static void Request(string classpath, string methodName, NativeResponseAction responseAction, params object[] methodParams)
		{
		}

		[Token(Token = "0x6004335")]
		[Address(RVA = "0xC5720C", Offset = "0xC5720C", VA = "0xC5720C")]
		public static void Register(RegisterNativeDelegate registerDelegate, NativeResponseAction responseAction)
		{
		}

		[Token(Token = "0x6004336")]
		[Address(RVA = "0xC571B0", Offset = "0xC571B0", VA = "0xC571B0")]
		private static Guid GetToken()
		{
			return default(Guid);
		}
	}
}
