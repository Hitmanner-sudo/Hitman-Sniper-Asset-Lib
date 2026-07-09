using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.Android
{
	[Token(Token = "0x2000993")]
	internal class AndroidEventsClient : IEventsClient
	{
		[Token(Token = "0x2000994")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59744C", Offset = "0x59744C")]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x400338B")]
			[FieldOffset(Offset = "0x10")]
			public Action<ResponseStatus, List<IEvent>> callback;

			[Token(Token = "0x6003D47")]
			[Address(RVA = "0x91912C", Offset = "0x91912C", VA = "0x91912C")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6003D48")]
			[Address(RVA = "0x919134", Offset = "0x919134", VA = "0x919134")]
			internal void _003CFetchAllEvents_003Eb__0(AndroidJavaObject annotatedData)
			{
			}

			[Token(Token = "0x6003D49")]
			[Address(RVA = "0x919850", Offset = "0x919850", VA = "0x919850")]
			internal void _003CFetchAllEvents_003Eb__1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x2000995")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59745C", Offset = "0x59745C")]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			[Token(Token = "0x400338C")]
			[FieldOffset(Offset = "0x10")]
			public Action<ResponseStatus, IEvent> callback;

			[Token(Token = "0x6003D4A")]
			[Address(RVA = "0x9198F8", Offset = "0x9198F8", VA = "0x9198F8")]
			public _003C_003Ec__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6003D4B")]
			[Address(RVA = "0x919900", Offset = "0x919900", VA = "0x919900")]
			internal void _003CFetchEvent_003Eb__0(AndroidJavaObject annotatedData)
			{
			}

			[Token(Token = "0x6003D4C")]
			[Address(RVA = "0x91A044", Offset = "0x91A044", VA = "0x91A044")]
			internal void _003CFetchEvent_003Eb__1(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x2000996")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59746C", Offset = "0x59746C")]
		private sealed class _003C_003Ec__DisplayClass5_0<T1, T2>
		{
			[Token(Token = "0x400338D")]
			[FieldOffset(Offset = "0x0")]
			public Action<T1, T2> toConvert;

			[Token(Token = "0x6003D4D")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6003D4E")]
			internal void _003CToOnGameThread_003Eb__0(T1 val1, T2 val2)
			{
			}
		}

		[Token(Token = "0x2000997")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59747C", Offset = "0x59747C")]
		private sealed class _003C_003Ec__DisplayClass5_1<T1, T2>
		{
			[Token(Token = "0x400338E")]
			[FieldOffset(Offset = "0x0")]
			public T1 val1;

			[Token(Token = "0x400338F")]
			[FieldOffset(Offset = "0x0")]
			public T2 val2;

			[Token(Token = "0x4003390")]
			[FieldOffset(Offset = "0x0")]
			public _003C_003Ec__DisplayClass5_0<T1, T2> CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6003D4F")]
			public _003C_003Ec__DisplayClass5_1()
			{
			}

			[Token(Token = "0x6003D50")]
			internal void _003CToOnGameThread_003Eb__1()
			{
			}
		}

		[Token(Token = "0x400338A")]
		[FieldOffset(Offset = "0x10")]
		private AndroidJavaObject mEventsClient;

		[Token(Token = "0x6003D41")]
		[Address(RVA = "0xD6AA08", Offset = "0xD6AA08", VA = "0xD6AA08")]
		public AndroidEventsClient(AndroidJavaObject account)
		{
		}

		[Token(Token = "0x6003D42")]
		[Address(RVA = "0xD6C524", Offset = "0xD6C524", VA = "0xD6C524", Slot = "4")]
		public void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback)
		{
		}

		[Token(Token = "0x6003D43")]
		[Address(RVA = "0xD6C850", Offset = "0xD6C850", VA = "0xD6C850", Slot = "5")]
		public void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback)
		{
		}

		[Token(Token = "0x6003D44")]
		[Address(RVA = "0xD6CBF0", Offset = "0xD6CBF0", VA = "0xD6CBF0", Slot = "6")]
		public void IncrementEvent(string eventId, uint stepsToIncrement)
		{
		}

		[Token(Token = "0x6003D45")]
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}

		[Token(Token = "0x6003D46")]
		[Address(RVA = "0xD6CD24", Offset = "0xD6CD24", VA = "0xD6CD24")]
		private static GooglePlayGames.BasicApi.Events.Event CreateEvent(AndroidJavaObject eventJava)
		{
			return null;
		}
	}
}
