using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.Android
{
	[Token(Token = "0x20009BD")]
	internal class AndroidTaskUtils
	{
		[Token(Token = "0x20009BE")]
		private class TaskOnCompleteProxy<T> : AndroidJavaProxy
		{
			[Token(Token = "0x40033E3")]
			[FieldOffset(Offset = "0x0")]
			private Action<T> mCallback;

			[Token(Token = "0x6003DF4")]
			public TaskOnCompleteProxy(Action<T> callback)
			{
			}

			[Token(Token = "0x6003DF5")]
			public void onComplete(T result)
			{
			}
		}

		[Token(Token = "0x20009BF")]
		private class TaskOnSuccessProxy<T> : AndroidJavaProxy
		{
			[Token(Token = "0x40033E4")]
			[FieldOffset(Offset = "0x0")]
			private Action<T> mCallback;

			[Token(Token = "0x40033E5")]
			[FieldOffset(Offset = "0x0")]
			private bool mDisposeResult;

			[Token(Token = "0x6003DF6")]
			public TaskOnSuccessProxy(Action<T> callback, bool disposeResult)
			{
			}

			[Token(Token = "0x6003DF7")]
			public void onSuccess(T result)
			{
			}
		}

		[Token(Token = "0x20009C0")]
		private class TaskOnFailedProxy : AndroidJavaProxy
		{
			[Token(Token = "0x40033E6")]
			[FieldOffset(Offset = "0x20")]
			private Action<AndroidJavaObject> mCallback;

			[Token(Token = "0x6003DF8")]
			[Address(RVA = "0x91FC6C", Offset = "0x91FC6C", VA = "0x91FC6C")]
			public TaskOnFailedProxy(Action<AndroidJavaObject> callback)
			{
			}

			[Token(Token = "0x6003DF9")]
			[Address(RVA = "0x91FCFC", Offset = "0x91FCFC", VA = "0x91FCFC")]
			public void onFailure(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x6003DEF")]
		[Address(RVA = "0xD789A4", Offset = "0xD789A4", VA = "0xD789A4")]
		private AndroidTaskUtils()
		{
		}

		[Token(Token = "0x6003DF0")]
		public static void AddOnSuccessListener<T>(AndroidJavaObject task, Action<T> callback)
		{
		}

		[Token(Token = "0x6003DF1")]
		public static void AddOnSuccessListener<T>(AndroidJavaObject task, bool disposeResult, Action<T> callback)
		{
		}

		[Token(Token = "0x6003DF2")]
		[Address(RVA = "0xD63264", Offset = "0xD63264", VA = "0xD63264")]
		public static void AddOnFailureListener(AndroidJavaObject task, Action<AndroidJavaObject> callback)
		{
		}

		[Token(Token = "0x6003DF3")]
		public static void AddOnCompleteListener<T>(AndroidJavaObject task, Action<T> callback)
		{
		}
	}
}
