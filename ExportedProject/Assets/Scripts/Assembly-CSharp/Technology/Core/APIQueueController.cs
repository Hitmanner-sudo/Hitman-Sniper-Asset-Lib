using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C57")]
	public static class APIQueueController
	{
		[Token(Token = "0x2000C58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598624", Offset = "0x598624")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x4003CB5")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			[Token(Token = "0x6004D63")]
			[Address(RVA = "0x910DA8", Offset = "0x910DA8", VA = "0x910DA8")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6004D64")]
			[Address(RVA = "0x910DB0", Offset = "0x910DB0", VA = "0x910DB0")]
			internal void _003CExecute_003Eb__0(bool canExecute)
			{
			}
		}

		[Token(Token = "0x2000C59")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598634", Offset = "0x598634")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x4003CB6")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			[Token(Token = "0x4003CB7")]
			[FieldOffset(Offset = "0x18")]
			public object[] param;

			[Token(Token = "0x6004D65")]
			[Address(RVA = "0x910C50", Offset = "0x910C50", VA = "0x910C50")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6004D66")]
			[Address(RVA = "0x910C58", Offset = "0x910C58", VA = "0x910C58")]
			internal void _003CExecute_003Eb__0(bool canExecute)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000C5A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598644", Offset = "0x598644")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003CB8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003CB9")]
			[FieldOffset(Offset = "0x8")]
			public static Action _003C_003E9__14_0;

			[Token(Token = "0x6004D68")]
			[Address(RVA = "0x910BEC", Offset = "0x910BEC", VA = "0x910BEC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004D69")]
			[Address(RVA = "0x910BF4", Offset = "0x910BF4", VA = "0x910BF4")]
			internal void _003CInitialize_003Eb__14_0()
			{
			}
		}

		[Token(Token = "0x4003CAE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly IAPIControllerStrategy STRATEGY_ONLINE;

		[Token(Token = "0x4003CAF")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, KeyValuePair<Action, IAPIControllerStrategy>> _actionsVoid;

		[Token(Token = "0x4003CB0")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<string, KeyValuePair<Action<object[]>, IAPIControllerStrategy>> _actionsParams;

		[Token(Token = "0x4003CB1")]
		[FieldOffset(Offset = "0x18")]
		private static Queue<string> _actionVoidQueue;

		[Token(Token = "0x4003CB2")]
		[FieldOffset(Offset = "0x20")]
		private static Queue<KeyValuePair<string, object[]>> _actionParamsQueue;

		[Token(Token = "0x4003CB3")]
		[FieldOffset(Offset = "0x28")]
		private static bool _isInitialized;

		[Token(Token = "0x4003CB4")]
		private const int MAX_ACTIONS = 15;

		[Token(Token = "0x6004D57")]
		[Address(RVA = "0xA9A90C", Offset = "0xA9A90C", VA = "0xA9A90C")]
		public static void Register(string uid, IAPIControllerStrategy context, Action action)
		{
		}

		[Token(Token = "0x6004D58")]
		[Address(RVA = "0xA9A9E8", Offset = "0xA9A9E8", VA = "0xA9A9E8")]
		public static void Register(string uid, IAPIControllerStrategy context, Action<object[]> action)
		{
		}

		[Token(Token = "0x6004D59")]
		[Address(RVA = "0xA9AAC4", Offset = "0xA9AAC4", VA = "0xA9AAC4")]
		public static void Execute(string uid)
		{
		}

		[Token(Token = "0x6004D5A")]
		[Address(RVA = "0xA9AE50", Offset = "0xA9AE50", VA = "0xA9AE50")]
		public static void Execute(string uid, object[] param)
		{
		}

		[Token(Token = "0x6004D5B")]
		[Address(RVA = "0xA9B000", Offset = "0xA9B000", VA = "0xA9B000")]
		public static void ForceNextUpdate()
		{
		}

		[Token(Token = "0x6004D5C")]
		[Address(RVA = "0xA9B1CC", Offset = "0xA9B1CC", VA = "0xA9B1CC")]
		private static void EnqueueAction(string uid)
		{
		}

		[Token(Token = "0x6004D5D")]
		[Address(RVA = "0xA9B258", Offset = "0xA9B258", VA = "0xA9B258")]
		private static void EnqueueAction(string uid, object[] param)
		{
		}

		[Token(Token = "0x6004D5E")]
		[Address(RVA = "0xA9AC70", Offset = "0xA9AC70", VA = "0xA9AC70")]
		private static void Initialize()
		{
		}

		[Token(Token = "0x6004D5F")]
		[Address(RVA = "0xA9B058", Offset = "0xA9B058", VA = "0xA9B058")]
		private static void Update()
		{
		}

		[Token(Token = "0x6004D60")]
		[Address(RVA = "0xA9B59C", Offset = "0xA9B59C", VA = "0xA9B59C")]
		private static void Serialize()
		{
		}

		[Token(Token = "0x6004D61")]
		[Address(RVA = "0xA9B32C", Offset = "0xA9B32C", VA = "0xA9B32C")]
		private static void Deserialize()
		{
		}
	}
}
