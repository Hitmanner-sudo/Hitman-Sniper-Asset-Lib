using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core
{
	[Token(Token = "0x2000C78")]
	public class Mailbox
	{
		[Token(Token = "0x2000C79")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5986E0", Offset = "0x5986E0")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x4003CEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Mailbox _003C_003E4__this;

			[Token(Token = "0x4003CED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<bool> subscriberAction;

			[Token(Token = "0x6004DC2")]
			[Address(RVA = "0x8C5C78", Offset = "0x8C5C78", VA = "0x8C5C78")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6004DC3")]
			[Address(RVA = "0x8C5C80", Offset = "0x8C5C80", VA = "0x8C5C80")]
			internal void _003CReceive_003Eb__0(bool succeed, List<Message> messages)
			{
			}
		}

		[Token(Token = "0x4003CEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int ID;

		[Token(Token = "0x4003CEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Message> Inbox;

		[Token(Token = "0x6004DBD")]
		[Address(RVA = "0x9ABF2C", Offset = "0x9ABF2C", VA = "0x9ABF2C")]
		public void Send(Message message, [Optional] Action<bool, IResponseContext> subscriberAction)
		{
		}

		[Token(Token = "0x6004DBE")]
		[Address(RVA = "0x9ABF3C", Offset = "0x9ABF3C", VA = "0x9ABF3C")]
		public void Receive([Optional] Action<bool> subscriberAction)
		{
		}

		[Token(Token = "0x6004DBF")]
		[Address(RVA = "0x9AC01C", Offset = "0x9AC01C", VA = "0x9AC01C")]
		public void ReceiveAll([Optional] Action<bool> subscriberAction)
		{
		}

		[Token(Token = "0x6004DC0")]
		[Address(RVA = "0x9ABF44", Offset = "0x9ABF44", VA = "0x9ABF44")]
		private void Receive(Action<bool> subscriberAction, bool onlyValid)
		{
		}

		[Token(Token = "0x6004DC1")]
		[Address(RVA = "0x9AC024", Offset = "0x9AC024", VA = "0x9AC024")]
		public Mailbox()
		{
		}
	}
}
