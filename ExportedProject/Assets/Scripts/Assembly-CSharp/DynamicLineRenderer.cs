using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007C6")]
public class DynamicLineRenderer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20007C7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59627C", Offset = "0x59627C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002B9C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002B9D")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Transform> _003C_003E9__6_0;

		[Token(Token = "0x600332B")]
		[Address(RVA = "0x86CA34", Offset = "0x86CA34", VA = "0x86CA34")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600332C")]
		[Address(RVA = "0x86CA3C", Offset = "0x86CA3C", VA = "0x86CA3C")]
		internal bool _003CUpdate_003Eb__6_0(Transform t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4002B9A")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> Transforms;

	[Token(Token = "0x4002B9B")]
	[FieldOffset(Offset = "0x20")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x6003324")]
	[Address(RVA = "0xC219B0", Offset = "0xC219B0", VA = "0xC219B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003325")]
	[Address(RVA = "0xC21A68", Offset = "0xC21A68", VA = "0xC21A68")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003326")]
	[Address(RVA = "0xC21AFC", Offset = "0xC21AFC", VA = "0xC21AFC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6003327")]
	[Address(RVA = "0xC21B90", Offset = "0xC21B90", VA = "0xC21B90")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003328")]
	[Address(RVA = "0xC21BE4", Offset = "0xC21BE4", VA = "0xC21BE4")]
	private void Update()
	{
	}

	[Token(Token = "0x6003329")]
	[Address(RVA = "0xC21DF8", Offset = "0xC21DF8", VA = "0xC21DF8")]
	public DynamicLineRenderer()
	{
	}
}
