using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000780")]
public class CalenderGameObjectActivator : MonoBehaviour
{
	[Token(Token = "0x4002A62")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<string> _eventNames;

	[Token(Token = "0x4002A63")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _activate;

	[Token(Token = "0x4002A64")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool _destroyObjet;

	[Token(Token = "0x4002A65")]
	[FieldOffset(Offset = "0x22")]
	[SerializeField]
	private bool _doIfEventNotEventName;

	[Token(Token = "0x60031DB")]
	[Address(RVA = "0xA8C7D0", Offset = "0xA8C7D0", VA = "0xA8C7D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60031DC")]
	[Address(RVA = "0xA8C954", Offset = "0xA8C954", VA = "0xA8C954")]
	public CalenderGameObjectActivator()
	{
	}
}
