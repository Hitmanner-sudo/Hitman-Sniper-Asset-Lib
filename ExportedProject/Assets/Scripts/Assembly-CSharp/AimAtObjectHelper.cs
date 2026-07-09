using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000214")]
public class AimAtObjectHelper<T> where T : Component
{
	[Token(Token = "0x2000215")]
	public delegate T ComponentGetter(RaycastHit hit);

	[Token(Token = "0x2000216")]
	public delegate bool ComponentFilter(T component);

	[Token(Token = "0x4000BEB")]
	[FieldOffset(Offset = "0x0")]
	private ComponentGetter _getter;

	[Token(Token = "0x4000BEC")]
	[FieldOffset(Offset = "0x0")]
	private ComponentFilter _filter;

	[Token(Token = "0x4000BED")]
	[FieldOffset(Offset = "0x0")]
	private Action _onTargetComplete;

	[Token(Token = "0x4000BEE")]
	[FieldOffset(Offset = "0x0")]
	private Tags.Layers _layer;

	[Token(Token = "0x4000BEF")]
	[FieldOffset(Offset = "0x0")]
	private T _lastTarget;

	[Token(Token = "0x4000BF0")]
	[FieldOffset(Offset = "0x0")]
	private Timer _targetTimer;

	[Token(Token = "0x4000BF1")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B2E28", Offset = "0x5B2E28")]
	private float _003CDuration_003Ek__BackingField;

	[Token(Token = "0x170001FE")]
	public float Duration
	{
		[Token(Token = "0x6000C8A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614374", Offset = "0x614374")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000C8B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614384", Offset = "0x614384")]
		set
		{
		}
	}

	[Token(Token = "0x6000C8C")]
	public AimAtObjectHelper(ComponentGetter getter, ComponentFilter filter, Action onTargetComplete, Tags.Layers layer)
	{
	}

	[Token(Token = "0x6000C8D")]
	public void OnPlayerAim(PlayerRootFSM.Sniping.AimInfo e)
	{
	}

	[Token(Token = "0x6000C8E")]
	public void OnUpdate()
	{
	}

	[Token(Token = "0x6000C8F")]
	private void OnTarget(T newTarget)
	{
	}
}
