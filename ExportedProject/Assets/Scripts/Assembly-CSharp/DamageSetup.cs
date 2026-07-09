using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001AD")]
public class DamageSetup : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20001AE")]
	public class DamageSpec
	{
		[Token(Token = "0x4000943")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000944")]
		[FieldOffset(Offset = "0x18")]
		public OnDamageDesc DamageDesc;

		[Token(Token = "0x4000945")]
		[FieldOffset(Offset = "0x20")]
		public string AttachTo;

		[Token(Token = "0x4000946")]
		[FieldOffset(Offset = "0x28")]
		public CollisionDetectionMode DetectionMode;

		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x86A5BC", Offset = "0x86A5BC", VA = "0x86A5BC")]
		public DamageSpec()
		{
		}
	}

	[Token(Token = "0x4000941")]
	[FieldOffset(Offset = "0x18")]
	public DamageSpec[] DamageSpecifications;

	[Token(Token = "0x4000942")]
	[FieldOffset(Offset = "0x20")]
	public float MaxHealth;

	[Token(Token = "0x6000B44")]
	[Address(RVA = "0xAE2210", Offset = "0xAE2210", VA = "0xAE2210")]
	public void ApplyToGameObject(GameObject go)
	{
	}

	[Token(Token = "0x6000B45")]
	[Address(RVA = "0xAE272C", Offset = "0xAE272C", VA = "0xAE272C")]
	private void SetupDamageHelper(Transform in_transform, DamageSpec in_dmgSpec, Health in_health)
	{
	}

	[Token(Token = "0x6000B46")]
	[Address(RVA = "0xAE28AC", Offset = "0xAE28AC", VA = "0xAE28AC")]
	private void CopyCollidersToTransform(Transform in_source, Transform in_target)
	{
	}

	[Token(Token = "0x6000B47")]
	[Address(RVA = "0xAE2EA0", Offset = "0xAE2EA0", VA = "0xAE2EA0")]
	public DamageSetup()
	{
	}
}
