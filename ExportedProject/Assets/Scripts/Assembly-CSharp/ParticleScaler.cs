using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007BA")]
[ExecuteInEditMode]
public class ParticleScaler : MonoBehaviour
{
	[Token(Token = "0x4002B65")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem ParticleSystemObject;

	[Token(Token = "0x4002B66")]
	[FieldOffset(Offset = "0x20")]
	private float _startSize;

	[Token(Token = "0x4002B67")]
	[FieldOffset(Offset = "0x24")]
	private float _gravityModifier;

	[Token(Token = "0x4002B68")]
	[FieldOffset(Offset = "0x28")]
	private float _startSpeed;

	[Token(Token = "0x4002B69")]
	[FieldOffset(Offset = "0x2C")]
	private float _startRotation;

	[Token(Token = "0x4002B6A")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 _transformScale;

	[Token(Token = "0x4002B6B")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 _lastScale;

	[Token(Token = "0x60032F7")]
	[Address(RVA = "0x8F5718", Offset = "0x8F5718", VA = "0x8F5718")]
	private void Awake()
	{
	}

	[Token(Token = "0x60032F8")]
	[Address(RVA = "0x8F5868", Offset = "0x8F5868", VA = "0x8F5868")]
	private void Update()
	{
	}

	[Token(Token = "0x60032F9")]
	[Address(RVA = "0x8F586C", Offset = "0x8F586C", VA = "0x8F586C")]
	public void UpdateParticleScale()
	{
	}

	[Token(Token = "0x60032FA")]
	[Address(RVA = "0x8F59E8", Offset = "0x8F59E8", VA = "0x8F59E8")]
	public ParticleScaler()
	{
	}
}
