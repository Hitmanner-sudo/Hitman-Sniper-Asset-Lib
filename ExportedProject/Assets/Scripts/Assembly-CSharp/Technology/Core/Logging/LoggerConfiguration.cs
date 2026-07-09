using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Logging
{
	[Serializable]
	[Token(Token = "0x2000D52")]
	public class LoggerConfiguration : ScriptableObject, ISerializationCallbackReceiver
	{
		[Token(Token = "0x4003F7E")]
		[FieldOffset(Offset = "0x18")]
		public int MaxEntries;

		[Token(Token = "0x4003F7F")]
		[FieldOffset(Offset = "0x20")]
		public DefaultConsoleHandler ConsoleHandler;

		[Token(Token = "0x4003F80")]
		[FieldOffset(Offset = "0x28")]
		public string[] DisabledNamespaces;

		[Token(Token = "0x4003F81")]
		[FieldOffset(Offset = "0x30")]
		public bool EnableInfoStackTraces;

		[Token(Token = "0x4003F82")]
		[FieldOffset(Offset = "0x31")]
		public bool EnableLogToFile;

		[Token(Token = "0x6005270")]
		[Address(RVA = "0x9DD9B0", Offset = "0x9DD9B0", VA = "0x9DD9B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6005271")]
		[Address(RVA = "0x9DD9B4", Offset = "0x9DD9B4", VA = "0x9DD9B4", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6005272")]
		[Address(RVA = "0x9DD9B8", Offset = "0x9DD9B8", VA = "0x9DD9B8")]
		public LoggerConfiguration()
		{
		}
	}
}
