using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000012")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x590888", Offset = "0x590888")]
public class WFX_BulletHoleDecal : MonoBehaviour
{
	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5908E8", Offset = "0x5908E8")]
	private sealed class _003CholeUpdate_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x20")]
		public WFX_BulletHoleDecal _003C_003E4__this;

		[Token(Token = "0x17000012")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xA413C8", Offset = "0xA413C8", VA = "0xA413C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xA41410", Offset = "0xA41410", VA = "0xA41410", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xA41294", Offset = "0xA41294", VA = "0xA41294")]
		[DebuggerHidden]
		public _003CholeUpdate_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xA412C0", Offset = "0xA412C0", VA = "0xA412C0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xA412C4", Offset = "0xA412C4", VA = "0xA412C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xA413D0", Offset = "0xA413D0", VA = "0xA413D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x0")]
	private static Vector2[] quadUVs;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x18")]
	public float lifetime;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x1C")]
	public float fadeoutpercent;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 frames;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x28")]
	public bool randomRotation;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x29")]
	public bool deactivate;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x2C")]
	private float life;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x30")]
	private float fadeout;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x34")]
	private Color color;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x44")]
	private float orgAlpha;

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x97B770", Offset = "0x97B770", VA = "0x97B770")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x97B800", Offset = "0x97B800", VA = "0x97B800")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x97B870", Offset = "0x97B870", VA = "0x97B870")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x97BB70", Offset = "0x97BB70", VA = "0x97BB70")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6117B0", Offset = "0x6117B0")]
	private IEnumerator holeUpdate()
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x97BBDC", Offset = "0x97BBDC", VA = "0x97BBDC")]
	public WFX_BulletHoleDecal()
	{
	}
}
