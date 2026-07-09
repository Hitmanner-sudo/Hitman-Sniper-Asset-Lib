using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000869")]
[PreserveInstanceOnDisable]
[Attribute(Name = "GameUpdateOrderAttribute", RVA = "0x596940", Offset = "0x596940")]
[Scope]
public class InputsManager : GameSingleton<InputsManager>
{
	[Token(Token = "0x200086A")]
	public enum InputHandlerPriority
	{
		[Token(Token = "0x4002F3C")]
		Gameplay = 0
	}

	[Token(Token = "0x200086B")]
	public interface IInputHandler
	{
		[Token(Token = "0x170006FF")]
		int Priority
		{
			[Token(Token = "0x6003704")]
			get;
		}

		[Token(Token = "0x6003705")]
		void HandleInputs(List<int> validTouchIDs);
	}

	[Token(Token = "0x4002F38")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<IInputHandler> _handlers;

	[Token(Token = "0x4002F39")]
	[FieldOffset(Offset = "0x50")]
	private int _nbOfDisableCalled;

	[Token(Token = "0x4002F3A")]
	[FieldOffset(Offset = "0x58")]
	private readonly List<int> _validTouchIDs;

	[Token(Token = "0x60036FC")]
	[Address(RVA = "0xB134DC", Offset = "0xB134DC", VA = "0xB134DC")]
	public int GetValidTouchIDsCount()
	{
		return default(int);
	}

	[Token(Token = "0x60036FD")]
	[Address(RVA = "0xB13528", Offset = "0xB13528", VA = "0xB13528", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60036FE")]
	[Address(RVA = "0xB1379C", Offset = "0xB1379C", VA = "0xB1379C")]
	public static void Push(IInputHandler handler)
	{
	}

	[Token(Token = "0x60036FF")]
	[Address(RVA = "0xB139F4", Offset = "0xB139F4", VA = "0xB139F4")]
	public static void Remove(IInputHandler handler)
	{
	}

	[Token(Token = "0x6003700")]
	[Address(RVA = "0xB13AE8", Offset = "0xB13AE8", VA = "0xB13AE8", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6003701")]
	[Address(RVA = "0xB13C18", Offset = "0xB13C18", VA = "0xB13C18")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6003702")]
	[Address(RVA = "0xB135D8", Offset = "0xB135D8", VA = "0xB135D8")]
	public void EnableInput(bool enable, GameObject caller)
	{
	}

	[Token(Token = "0x6003703")]
	[Address(RVA = "0xB13DA8", Offset = "0xB13DA8", VA = "0xB13DA8")]
	public InputsManager()
	{
	}
}
