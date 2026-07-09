using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Prime31;

[Token(Token = "0x200000E")]
public class GoogleCloudMessagingManager : AbstractManager
{
	[Token(Token = "0x14000018")]
	public static event Action<Dictionary<string, object>> notificationReceivedEvent
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x10E94A0", Offset = "0x10E94A0", VA = "0x10E94A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9C30", Offset = "0x6F9C30")]
		add
		{
		}
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x10E9594", Offset = "0x10E9594", VA = "0x10E9594")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9C40", Offset = "0x6F9C40")]
		remove
		{
		}
	}

	[Token(Token = "0x14000019")]
	public static event Action<string> registrationSucceededEvent
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x10E9688", Offset = "0x10E9688", VA = "0x10E9688")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9C50", Offset = "0x6F9C50")]
		add
		{
		}
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x10E9780", Offset = "0x10E9780", VA = "0x10E9780")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9C60", Offset = "0x6F9C60")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001A")]
	public static event Action<string> registrationFailedEvent
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x10E9878", Offset = "0x10E9878", VA = "0x10E9878")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9C70", Offset = "0x6F9C70")]
		add
		{
		}
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x10E9970", Offset = "0x10E9970", VA = "0x10E9970")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9C80", Offset = "0x6F9C80")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001B")]
	public static event Action unregistrationSucceededEvent
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x10E9A68", Offset = "0x10E9A68", VA = "0x10E9A68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9C90", Offset = "0x6F9C90")]
		add
		{
		}
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x10E9B60", Offset = "0x10E9B60", VA = "0x10E9B60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9CA0", Offset = "0x6F9CA0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001C")]
	public static event Action<string> unregistrationFailedEvent
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x10E9C58", Offset = "0x10E9C58", VA = "0x10E9C58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9CB0", Offset = "0x6F9CB0")]
		add
		{
		}
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x10E9D50", Offset = "0x10E9D50", VA = "0x10E9D50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9CC0", Offset = "0x6F9CC0")]
		remove
		{
		}
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x10E9E48", Offset = "0x10E9E48", VA = "0x10E9E48")]
	static GoogleCloudMessagingManager()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x10E9EC8", Offset = "0x10E9EC8", VA = "0x10E9EC8")]
	public void notificationReceived(string json)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x10E9F5C", Offset = "0x10E9F5C", VA = "0x10E9F5C")]
	public void registrationSucceeded(string registrationId)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x10E9FE0", Offset = "0x10E9FE0", VA = "0x10E9FE0")]
	public void unregistrationFailed(string param)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x10EA064", Offset = "0x10EA064", VA = "0x10EA064")]
	public void registrationFailed(string error)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x10EA0E8", Offset = "0x10EA0E8", VA = "0x10EA0E8")]
	public void unregistrationSucceeded(string empty)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x10EA150", Offset = "0x10EA150", VA = "0x10EA150")]
	public GoogleCloudMessagingManager()
	{
	}
}
