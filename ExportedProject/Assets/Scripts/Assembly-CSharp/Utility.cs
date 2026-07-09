using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using HutongGames.PlayMaker;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x20008BE")]
public static class Utility
{
	[Token(Token = "0x20008BF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596B7C", Offset = "0x596B7C")]
	private sealed class _003CWaitForRealSeconds_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003025")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003026")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003027")]
		[FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x4003028")]
		[FieldOffset(Offset = "0x24")]
		private float _003Cend_003E5__2;

		[Token(Token = "0x1700071F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003849")]
			[Address(RVA = "0xA405A4", Offset = "0xA405A4", VA = "0xA405A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000720")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600384B")]
			[Address(RVA = "0xA405EC", Offset = "0xA405EC", VA = "0xA405EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003846")]
		[Address(RVA = "0xA404F0", Offset = "0xA404F0", VA = "0xA404F0")]
		[DebuggerHidden]
		public _003CWaitForRealSeconds_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003847")]
		[Address(RVA = "0xA4051C", Offset = "0xA4051C", VA = "0xA4051C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003848")]
		[Address(RVA = "0xA40520", Offset = "0xA40520", VA = "0xA40520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600384A")]
		[Address(RVA = "0xA405AC", Offset = "0xA405AC", VA = "0xA405AC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20008C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596B8C", Offset = "0x596B8C")]
	private sealed class _003CWaitForGameTimeSeconds_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003029")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400302A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400302B")]
		[FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x400302C")]
		[FieldOffset(Offset = "0x24")]
		private float _003Cend_003E5__2;

		[Token(Token = "0x17000721")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600384F")]
			[Address(RVA = "0xA404A0", Offset = "0xA404A0", VA = "0xA404A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000722")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003851")]
			[Address(RVA = "0xA404E8", Offset = "0xA404E8", VA = "0xA404E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600384C")]
		[Address(RVA = "0xA402F8", Offset = "0xA402F8", VA = "0xA402F8")]
		[DebuggerHidden]
		public _003CWaitForGameTimeSeconds_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600384D")]
		[Address(RVA = "0xA40324", Offset = "0xA40324", VA = "0xA40324", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600384E")]
		[Address(RVA = "0xA40328", Offset = "0xA40328", VA = "0xA40328", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003850")]
		[Address(RVA = "0xA404A8", Offset = "0xA404A8", VA = "0xA404A8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x600383B")]
	public static string GetMemberName<T, TValue>(Expression<Func<T, TValue>> memberAccess)
	{
		return null;
	}

	[Token(Token = "0x600383C")]
	public static void AssignFSMGameObjectTable<T>(FsmGameObject[] gameObjectTable, ref T[] outTable) where T : MonoBehaviour
	{
	}

	[Token(Token = "0x600383D")]
	public static void AssignFSMGameObjectTableFromChildrens<T>(FsmGameObject[] gameObjectTable, ref T[] outTable) where T : MonoBehaviour
	{
	}

	[Token(Token = "0x600383E")]
	public static void AssignFSMGameObject<T>(FsmGameObject fsmGameObject, ref T outObject) where T : MonoBehaviour
	{
	}

	[Token(Token = "0x600383F")]
	[Address(RVA = "0xBA25B0", Offset = "0xBA25B0", VA = "0xBA25B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x623A20", Offset = "0x623A20")]
	public static IEnumerator WaitForRealSeconds(float time)
	{
		return null;
	}

	[Token(Token = "0x6003840")]
	[Address(RVA = "0xBA2624", Offset = "0xBA2624", VA = "0xBA2624")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x623A80", Offset = "0x623A80")]
	public static IEnumerator WaitForGameTimeSeconds(float time)
	{
		return null;
	}

	[Token(Token = "0x6003841")]
	[Address(RVA = "0xBA2698", Offset = "0xBA2698", VA = "0xBA2698")]
	public static List<Vector2> MapSquareOnCircle(int squareXSides, int squareYSides, float circleDiameter, bool OnGridEdge)
	{
		return null;
	}

	[Token(Token = "0x6003842")]
	public static T CopyComponent<T>(T original, GameObject destination) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6003843")]
	public static T GetCopyOf<T>(this Component comp, T other, bool useFlatten = false) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6003844")]
	public static T AddComponent<T>(this GameObject go, T toAdd) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6003845")]
	[Address(RVA = "0xBA287C", Offset = "0xBA287C", VA = "0xBA287C")]
	public static bool SamplePositionIteratif(Vector3 sourcePosition, out NavMeshHit hit, int areaMask, float startingValue = 0.5f, uint nbExtraIterations = 5u)
	{
		return default(bool);
	}
}
