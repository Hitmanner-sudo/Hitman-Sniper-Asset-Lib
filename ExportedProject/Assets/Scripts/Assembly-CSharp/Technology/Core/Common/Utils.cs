using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DE5")]
	public static class Utils
	{
		[Token(Token = "0x2000DE6")]
		public delegate T CreateArgs<T>() where T : EventArgs;

		[Token(Token = "0x2000DE7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598A8C", Offset = "0x598A8C")]
		private sealed class _003CDelayedInvoke_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400420A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400420B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400420C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public YieldInstruction wait;

			[Token(Token = "0x400420D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action action;

			[Token(Token = "0x17000B56")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600559E")]
				[Address(RVA = "0xA40764", Offset = "0xA40764", VA = "0xA40764", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000B57")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60055A0")]
				[Address(RVA = "0xA407AC", Offset = "0xA407AC", VA = "0xA407AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600559B")]
			[Address(RVA = "0xA406D8", Offset = "0xA406D8", VA = "0xA406D8")]
			[DebuggerHidden]
			public _003CDelayedInvoke_003Ed__30(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600559C")]
			[Address(RVA = "0xA40704", Offset = "0xA40704", VA = "0xA40704", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600559D")]
			[Address(RVA = "0xA40708", Offset = "0xA40708", VA = "0xA40708", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600559F")]
			[Address(RVA = "0xA4076C", Offset = "0xA4076C", VA = "0xA4076C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2000DE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598A9C", Offset = "0x598A9C")]
		private sealed class _003CDelayedInvoke_003Ed__32<T> : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400420E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x400420F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object _003C_003E2__current;

			[Token(Token = "0x4004210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public YieldInstruction wait;

			[Token(Token = "0x4004211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> action;

			[Token(Token = "0x4004212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T arg0;

			[Token(Token = "0x17000B58")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60055A4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000B59")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60055A6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60055A1")]
			[DebuggerHidden]
			public _003CDelayedInvoke_003Ed__32(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60055A2")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60055A3")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60055A5")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2000DE9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598AAC", Offset = "0x598AAC")]
		private sealed class _003CDelayedFrameInvokeCoroutine_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4004213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4004214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4004215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int frameCount;

			[Token(Token = "0x4004216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action action;

			[Token(Token = "0x17000B5A")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60055AA")]
				[Address(RVA = "0xA40688", Offset = "0xA40688", VA = "0xA40688", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000B5B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60055AC")]
				[Address(RVA = "0xA406D0", Offset = "0xA406D0", VA = "0xA406D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60055A7")]
			[Address(RVA = "0xA405F4", Offset = "0xA405F4", VA = "0xA405F4")]
			[DebuggerHidden]
			public _003CDelayedFrameInvokeCoroutine_003Ed__34(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60055A8")]
			[Address(RVA = "0xA40620", Offset = "0xA40620", VA = "0xA40620", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60055A9")]
			[Address(RVA = "0xA40624", Offset = "0xA40624", VA = "0xA40624", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60055AB")]
			[Address(RVA = "0xA40690", Offset = "0xA40690", VA = "0xA40690", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2000DEA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598ABC", Offset = "0x598ABC")]
		private sealed class _003CDestroyPartcles_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4004217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4004218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4004219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject particlesObject;

			[Token(Token = "0x400421A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem _003Cparticles_003E5__2;

			[Token(Token = "0x17000B5C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60055B0")]
				[Address(RVA = "0xA409A0", Offset = "0xA409A0", VA = "0xA409A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000B5D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60055B2")]
				[Address(RVA = "0xA409E8", Offset = "0xA409E8", VA = "0xA409E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60055AD")]
			[Address(RVA = "0xA407B4", Offset = "0xA407B4", VA = "0xA407B4")]
			[DebuggerHidden]
			public _003CDestroyPartcles_003Ed__36(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60055AE")]
			[Address(RVA = "0xA407E0", Offset = "0xA407E0", VA = "0xA407E0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60055AF")]
			[Address(RVA = "0xA407E4", Offset = "0xA407E4", VA = "0xA407E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60055B1")]
			[Address(RVA = "0xA409A8", Offset = "0xA409A8", VA = "0xA409A8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2000DEB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598ACC", Offset = "0x598ACC")]
		private sealed class _003C_003Ec__DisplayClass60_0<TSource>
		{
			[Token(Token = "0x400421B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<TSource, int> selector;

			[Token(Token = "0x60055B3")]
			public _003C_003Ec__DisplayClass60_0()
			{
			}

			[Token(Token = "0x60055B4")]
			internal int _003CSum_003Eb__0(int acc, TSource cur)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000DEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598ADC", Offset = "0x598ADC")]
		private sealed class _003C_003Ec__DisplayClass62_0<TSource, TResult> where TResult : class
		{
			[Token(Token = "0x400421C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<TSource, TResult> selector;

			[Token(Token = "0x60055B5")]
			public _003C_003Ec__DisplayClass62_0()
			{
			}

			[Token(Token = "0x60055B6")]
			internal bool _003CSkipNulls_003Eb__0(TSource e)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600554D")]
		public static T Find<T>(string objectName) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600554E")]
		public static bool FindComponent<T>(ref T component, string objectName) where T : Component
		{
			return default(bool);
		}

		[Token(Token = "0x600554F")]
		public static bool RemoveComponent<T>(this GameObject go) where T : Component
		{
			return default(bool);
		}

		[Token(Token = "0x6005550")]
		public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6005551")]
		public static T GetComponentInChildren<T>(this MonoBehaviour parent, bool includeInactive) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6005552")]
		public static T GetComponentInChildren<T>(this GameObject parent, bool includeInactive) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6005553")]
		public static T GetComponentInAncestors<T>(this GameObject gameObjToSearchFrom, bool includeFirstGameObjInSearch = true) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6005554")]
		[Address(RVA = "0x13C1700", Offset = "0x13C1700", VA = "0x13C1700")]
		public static string GetFullPathName(this Transform transf)
		{
			return null;
		}

		[Token(Token = "0x6005555")]
		[Address(RVA = "0x13C1818", Offset = "0x13C1818", VA = "0x13C1818")]
		public static string GetFullPathName(this GameObject gameObj)
		{
			return null;
		}

		[Token(Token = "0x6005556")]
		[Address(RVA = "0x13C18C8", Offset = "0x13C18C8", VA = "0x13C18C8")]
		public static Vector3 AverageVector(params Vector3[] vectors)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6005557")]
		[Address(RVA = "0x13C195C", Offset = "0x13C195C", VA = "0x13C195C")]
		public static void SetCollidersEnabled(GameObject go, bool enable, bool includeTriggers)
		{
		}

		[Token(Token = "0x6005558")]
		[Address(RVA = "0x13C1CB4", Offset = "0x13C1CB4", VA = "0x13C1CB4")]
		public static void SetChildRigidbodiesEnabled(GameObject go, bool enable)
		{
		}

		[Token(Token = "0x6005559")]
		[Address(RVA = "0x13C1FE4", Offset = "0x13C1FE4", VA = "0x13C1FE4")]
		public static void SetChildRigidbodiesVelocity(GameObject ownerGo, GameObject go, Vector3 aVelocity)
		{
		}

		[Token(Token = "0x600555A")]
		[Address(RVA = "0x13C23D8", Offset = "0x13C23D8", VA = "0x13C23D8")]
		public static GameObject GetChildInHierarchy(this GameObject go, string name)
		{
			return null;
		}

		[Token(Token = "0x600555B")]
		[Address(RVA = "0x13C2560", Offset = "0x13C2560", VA = "0x13C2560")]
		public static void ShowGameObject(GameObject go)
		{
		}

		[Token(Token = "0x600555C")]
		[Address(RVA = "0x13C2568", Offset = "0x13C2568", VA = "0x13C2568")]
		public static void SetGameObjectVisible(GameObject go, bool show)
		{
		}

		[Token(Token = "0x600555D")]
		[Address(RVA = "0x13C2624", Offset = "0x13C2624", VA = "0x13C2624")]
		public static void HideGameObject(GameObject go)
		{
		}

		[Token(Token = "0x600555E")]
		public static void Increment<T>(this Dictionary<T, int> dictionary, T key)
		{
		}

		[Token(Token = "0x600555F")]
		public static string Debug<T, K>(this Dictionary<T, K> dictionary)
		{
			return null;
		}

		[Token(Token = "0x6005560")]
		[Address(RVA = "0x13C262C", Offset = "0x13C262C", VA = "0x13C262C")]
		public static float magnitudeXZ(this Vector3 v)
		{
			return default(float);
		}

		[Token(Token = "0x6005561")]
		[Address(RVA = "0x13C2654", Offset = "0x13C2654", VA = "0x13C2654")]
		public static float sqrMagnitudeXZ(this Vector3 v)
		{
			return default(float);
		}

		[Token(Token = "0x6005562")]
		[Address(RVA = "0x13C2664", Offset = "0x13C2664", VA = "0x13C2664")]
		public static Vector2 RandomOnUnitCircle()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6005563")]
		[Address(RVA = "0x13C26B0", Offset = "0x13C26B0", VA = "0x13C26B0")]
		public static Vector3 RandomVector(Vector3 min, Vector3 max)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6005564")]
		[Address(RVA = "0x13C2728", Offset = "0x13C2728", VA = "0x13C2728")]
		public static Quaternion RandomRotation(Quaternion min, Quaternion max)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6005565")]
		[Address(RVA = "0x13C27E8", Offset = "0x13C27E8", VA = "0x13C27E8")]
		public static Color InvertColor(this Color color)
		{
			return default(Color);
		}

		[Token(Token = "0x6005566")]
		[Address(RVA = "0x13C2828", Offset = "0x13C2828", VA = "0x13C2828")]
		public static Vector3 ToVector3(this Color c)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6005567")]
		[Address(RVA = "0x13C282C", Offset = "0x13C282C", VA = "0x13C282C")]
		public static Color ToColor(this Vector3 v, float alpha = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x6005568")]
		[Address(RVA = "0x13C285C", Offset = "0x13C285C", VA = "0x13C285C")]
		public static void DelayNextFrame(this MonoBehaviour owner, Action action)
		{
		}

		[Token(Token = "0x6005569")]
		[Address(RVA = "0x13C2910", Offset = "0x13C2910", VA = "0x13C2910")]
		public static void DelayEndOfFrame(this MonoBehaviour owner, Action action)
		{
		}

		[Token(Token = "0x600556A")]
		[Address(RVA = "0x13C2994", Offset = "0x13C2994", VA = "0x13C2994")]
		public static void DelayedInvoke(this MonoBehaviour owner, Action func, float time)
		{
		}

		[Token(Token = "0x600556B")]
		[Address(RVA = "0x13C2898", Offset = "0x13C2898", VA = "0x13C2898")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62AA60", Offset = "0x62AA60")]
		private static IEnumerator DelayedInvoke(Action action, [Optional] YieldInstruction wait)
		{
			return null;
		}

		[Token(Token = "0x600556C")]
		public static void DelayedInvoke<T>(this MonoBehaviour owner, Action<T> func, T arg0, float time)
		{
		}

		[Token(Token = "0x600556D")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62AAD0", Offset = "0x62AAD0")]
		private static IEnumerator DelayedInvoke<T>(Action<T> action, T arg0, [Optional] YieldInstruction wait)
		{
			return null;
		}

		[Token(Token = "0x600556E")]
		[Address(RVA = "0x13C2A28", Offset = "0x13C2A28", VA = "0x13C2A28")]
		public static void DelayedFrameInvoke(this MonoBehaviour owner, Action action, int frameCount)
		{
		}

		[Token(Token = "0x600556F")]
		[Address(RVA = "0x13C2A64", Offset = "0x13C2A64", VA = "0x13C2A64")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62AB40", Offset = "0x62AB40")]
		private static IEnumerator DelayedFrameInvokeCoroutine(Action action, int frameCount)
		{
			return null;
		}

		[Token(Token = "0x6005570")]
		[Address(RVA = "0x13C2AE0", Offset = "0x13C2AE0", VA = "0x13C2AE0")]
		public static void AutoDestroyParticles(MonoBehaviour owner, GameObject particlesObject)
		{
		}

		[Token(Token = "0x6005571")]
		[Address(RVA = "0x13C2B18", Offset = "0x13C2B18", VA = "0x13C2B18")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62ABA0", Offset = "0x62ABA0")]
		private static IEnumerator DestroyPartcles(GameObject particlesObject)
		{
			return null;
		}

		[Token(Token = "0x6005572")]
		[Address(RVA = "0x13C2B84", Offset = "0x13C2B84", VA = "0x13C2B84")]
		public static void RaiseAction(this Action handler)
		{
		}

		[Token(Token = "0x6005573")]
		public static void RaiseAction<T>(this Action<T> handler, T obj)
		{
		}

		[Token(Token = "0x6005574")]
		public static void RaiseAction<T1, T2>(this Action<T1, T2> handler, T1 obj, T2 obj2)
		{
		}

		[Token(Token = "0x6005575")]
		public static void RaiseAction<T1, T2, T3>(this Action<T1, T2, T3> handler, T1 obj, T2 obj2, T3 obj3)
		{
		}

		[Token(Token = "0x6005576")]
		public static void RaiseAction<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> handler, T1 obj, T2 obj2, T3 obj3, T4 obj4)
		{
		}

		[Token(Token = "0x6005577")]
		[Address(RVA = "0x13C2B94", Offset = "0x13C2B94", VA = "0x13C2B94")]
		public static void RaiseEvent(this EventHandler handler)
		{
		}

		[Token(Token = "0x6005578")]
		[Address(RVA = "0x13C2B9C", Offset = "0x13C2B9C", VA = "0x13C2B9C")]
		public static void RaiseEvent(this EventHandler handler, object source)
		{
		}

		[Token(Token = "0x6005579")]
		[Address(RVA = "0x13C2C34", Offset = "0x13C2C34", VA = "0x13C2C34")]
		public static void RaiseEvent(this EventHandler handler, object source, EventArgs args)
		{
		}

		[Token(Token = "0x600557A")]
		public static void RaiseEvent<T>(this EventHandler<T> handler) where T : EventArgs, new()
		{
		}

		[Token(Token = "0x600557B")]
		public static void RaiseEvent<T>(this EventHandler<T> handler, object source) where T : EventArgs, new()
		{
		}

		[Token(Token = "0x600557C")]
		public static void RaiseEvent<T>(this EventHandler<T> handler, object source, T args) where T : EventArgs
		{
		}

		[Token(Token = "0x600557D")]
		[Address(RVA = "0x13C2C44", Offset = "0x13C2C44", VA = "0x13C2C44")]
		public static void RaiseEvent(this EventHandler handler, object source, CreateArgs<EventArgs> args)
		{
		}

		[Token(Token = "0x600557E")]
		public static void RaiseEvent<T>(this EventHandler<T> handler, object source, CreateArgs<T> args) where T : EventArgs
		{
		}

		[Token(Token = "0x600557F")]
		[Address(RVA = "0x13C2CD0", Offset = "0x13C2CD0", VA = "0x13C2CD0")]
		public static Rect ProjectBoxToScreenRect(BoxCollider box, Camera camera)
		{
			return default(Rect);
		}

		[Token(Token = "0x6005580")]
		[Address(RVA = "0x13C2F6C", Offset = "0x13C2F6C", VA = "0x13C2F6C")]
		public static bool HasBool(this Animator animator, int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6005581")]
		[Address(RVA = "0x13C3028", Offset = "0x13C3028", VA = "0x13C3028")]
		public static bool HasInteger(this Animator animator, int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6005582")]
		[Address(RVA = "0x13C30E4", Offset = "0x13C30E4", VA = "0x13C30E4")]
		public static bool HasFloat(this Animator animator, int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6005583")]
		[Address(RVA = "0x13C31AC", Offset = "0x13C31AC", VA = "0x13C31AC")]
		public static Color MoveColorTowards(Color color, Color targetColor, float delta)
		{
			return default(Color);
		}

		[Token(Token = "0x6005584")]
		[Address(RVA = "0x13C3260", Offset = "0x13C3260", VA = "0x13C3260")]
		public static string UnityAbsoluteDataPath(this string source)
		{
			return null;
		}

		[Token(Token = "0x6005585")]
		[Address(RVA = "0x13C33F0", Offset = "0x13C33F0", VA = "0x13C33F0")]
		public static string UnityRelativeDataPath(this string source)
		{
			return null;
		}

		[Token(Token = "0x6005586")]
		[Address(RVA = "0x13C353C", Offset = "0x13C353C", VA = "0x13C353C")]
		public static string ToUnixSeperators(this string source)
		{
			return null;
		}

		[Token(Token = "0x6005587")]
		public static float Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
		{
			return default(float);
		}

		[Token(Token = "0x6005588")]
		public static int Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			return default(int);
		}

		[Token(Token = "0x6005589")]
		public static IEnumerable<T> SkipNulls<T>(this IEnumerable<T> source) where T : class
		{
			return null;
		}

		[Token(Token = "0x600558A")]
		public static IEnumerable<TSource> SkipNulls<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector) where TResult : class
		{
			return null;
		}

		[Token(Token = "0x600558B")]
		public static bool IsNotNull<T>(T obj) where T : class
		{
			return default(bool);
		}

		[Token(Token = "0x600558C")]
		public static void ClearEnsureCapacity<TSource>(ref List<TSource> source, int capacity)
		{
		}

		[Token(Token = "0x600558D")]
		[Address(RVA = "0x13C35E8", Offset = "0x13C35E8", VA = "0x13C35E8")]
		public static void EnableCollider(Component component, bool enabled)
		{
		}

		[Token(Token = "0x600558E")]
		[Address(RVA = "0x13C3784", Offset = "0x13C3784", VA = "0x13C3784")]
		public static void EnableColliderInChildren(Component component, bool enabled)
		{
		}

		[Token(Token = "0x600558F")]
		[Address(RVA = "0x13C368C", Offset = "0x13C368C", VA = "0x13C368C")]
		public static void EnableCollider(GameObject go, bool enabed)
		{
		}

		[Token(Token = "0x6005590")]
		[Address(RVA = "0x13C3828", Offset = "0x13C3828", VA = "0x13C3828")]
		public static void EnableColliderInChildren(GameObject go, bool enabled)
		{
		}

		[Token(Token = "0x6005591")]
		[Address(RVA = "0x13C3924", Offset = "0x13C3924", VA = "0x13C3924")]
		public static void EnableDefaultNguiCamera()
		{
		}

		[Token(Token = "0x6005592")]
		[Address(RVA = "0x13C3A94", Offset = "0x13C3A94", VA = "0x13C3A94")]
		public static void DisableDefaultNguiCamera()
		{
		}

		[Token(Token = "0x6005593")]
		[Address(RVA = "0x13C396C", Offset = "0x13C396C", VA = "0x13C396C")]
		public static bool SetNguiCameraState(bool isEnabled, string uiCameraName = "GUI Camera")
		{
			return default(bool);
		}

		[Token(Token = "0x6005594")]
		[Address(RVA = "0x13C3ADC", Offset = "0x13C3ADC", VA = "0x13C3ADC")]
		public static bool IsColliderEnabled(Component component)
		{
			return default(bool);
		}

		[Token(Token = "0x6005595")]
		[Address(RVA = "0x13C3B70", Offset = "0x13C3B70", VA = "0x13C3B70")]
		public static bool IsColliderEnabled(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6005596")]
		public static string Join<T>(T[] array, string separator)
		{
			return null;
		}
	}
}
