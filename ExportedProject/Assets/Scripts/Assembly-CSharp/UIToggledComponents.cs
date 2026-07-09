using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000045")]
[Attribute(Name = "AddComponentMenu", RVA = "0x59124C", Offset = "0x59124C")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0x59124C", Offset = "0x59124C")]
public class UIToggledComponents : MonoBehaviour
{
	[Token(Token = "0x400017D")]
	[FieldOffset(Offset = "0x18")]
	public List<MonoBehaviour> activate;

	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x20")]
	public List<MonoBehaviour> deactivate;

	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[HideInInspector]
	private MonoBehaviour target;

	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[HideInInspector]
	private bool inverse;

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x116FB2C", Offset = "0x116FB2C", VA = "0x116FB2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x116FCB0", Offset = "0x116FCB0", VA = "0x116FCB0")]
	public void Toggle()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x116FE2C", Offset = "0x116FE2C", VA = "0x116FE2C")]
	public UIToggledComponents()
	{
	}
}
