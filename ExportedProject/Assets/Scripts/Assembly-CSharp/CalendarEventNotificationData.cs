using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000225")]
public class CalendarEventNotificationData : LocalNotificationData
{
	[Token(Token = "0x4000C2B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string _body;

	[Token(Token = "0x17000209")]
	public override string Body
	{
		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0xA8C7C0", Offset = "0xA8C7C0", VA = "0xA8C7C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000CD8")]
	[Address(RVA = "0xA8C7C8", Offset = "0xA8C7C8", VA = "0xA8C7C8")]
	public CalendarEventNotificationData()
	{
	}
}
