using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000942")]
public static class Extensions
{
	[Token(Token = "0x2000943")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5970B0", Offset = "0x5970B0")]
	private sealed class _003C_003Ec__DisplayClass7_0<T> where T : struct
	{
		[Token(Token = "0x400324A")]
		[FieldOffset(Offset = "0x0")]
		public T start;

		[Token(Token = "0x6003AAF")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6003AB0")]
		internal bool _003CRange_003Eb__0(T v)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000944")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5970C0", Offset = "0x5970C0")]
	private sealed class _003C_003Ec__DisplayClass8_0<T> where T : struct
	{
		[Token(Token = "0x400324B")]
		[FieldOffset(Offset = "0x0")]
		public T end;

		[Token(Token = "0x6003AB1")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6003AB2")]
		internal bool _003CRange_003Eb__0(T v)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000945")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5970D0", Offset = "0x5970D0")]
	private sealed class _003CDelayNextFrameEnum_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400324C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400324D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400324E")]
		[FieldOffset(Offset = "0x20")]
		public Action action;

		[Token(Token = "0x17000769")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003AB6")]
			[Address(RVA = "0x870150", Offset = "0x870150", VA = "0x870150", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700076A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003AB8")]
			[Address(RVA = "0x870198", Offset = "0x870198", VA = "0x870198", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003AB3")]
		[Address(RVA = "0x8700C4", Offset = "0x8700C4", VA = "0x8700C4")]
		[DebuggerHidden]
		public _003CDelayNextFrameEnum_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003AB4")]
		[Address(RVA = "0x8700F0", Offset = "0x8700F0", VA = "0x8700F0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003AB5")]
		[Address(RVA = "0x8700F4", Offset = "0x8700F4", VA = "0x8700F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003AB7")]
		[Address(RVA = "0x870158", Offset = "0x870158", VA = "0x870158", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x6003AA4")]
	public static T GetComponentInParents<T>(this Component a_ThisComponent) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6003AA5")]
	public static T GetComponentInParents<T>(this GameObject a_ThisGameObject) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6003AA6")]
	public static T[] GetComponentsInParents<T>(this Component a_ThisComponent) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6003AA7")]
	public static T[] GetComponentsInParents<T>(this GameObject a_ThisGameObject) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6003AA8")]
	public static T First<T>(this List<T> list)
	{
		return (T)null;
	}

	[Token(Token = "0x6003AA9")]
	public static T Last<T>(this List<T> list)
	{
		return (T)null;
	}

	[Token(Token = "0x6003AAA")]
	[Address(RVA = "0x94C850", Offset = "0x94C850", VA = "0x94C850")]
	public static GameObject[] GetGameObjectsInChildren(this GameObject a_ThisGameObject)
	{
		return null;
	}

	[Token(Token = "0x6003AAB")]
	public static IEnumerable<T> Range<T>(T start) where T : struct
	{
		return null;
	}

	[Token(Token = "0x6003AAC")]
	public static IEnumerable<T> Range<T>(T start, T end) where T : struct
	{
		return null;
	}

	[Token(Token = "0x6003AAD")]
	[Address(RVA = "0x94C970", Offset = "0x94C970", VA = "0x94C970")]
	public static void DelayNextFrame(this MonoBehaviour self, Action action)
	{
	}

	[Token(Token = "0x6003AAE")]
	[Address(RVA = "0x94C9A8", Offset = "0x94C9A8", VA = "0x94C9A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x624A48", Offset = "0x624A48")]
	private static IEnumerator DelayNextFrameEnum(Action action)
	{
		return null;
	}
}
