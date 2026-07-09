using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000A75")]
	public class GameCoroutine : IEnumerator
	{
		[Token(Token = "0x400366A")]
		[FieldOffset(Offset = "0x10")]
		private IEnumerator _enumerator;

		[Token(Token = "0x400366B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBF88", Offset = "0x5BBF88")]
		private bool _003CIsPausable_003Ek__BackingField;

		[Token(Token = "0x400366C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBF98", Offset = "0x5BBF98")]
		private Coroutine _003CCoroutine_003Ek__BackingField;

		[Token(Token = "0x400366D")]
		[FieldOffset(Offset = "0x28")]
		private bool _stop;

		[Token(Token = "0x400366E")]
		[FieldOffset(Offset = "0x29")]
		private bool _pause;

		[Token(Token = "0x17000875")]
		public bool IsPausable
		{
			[Token(Token = "0x60041F6")]
			[Address(RVA = "0xD95474", Offset = "0xD95474", VA = "0xD95474")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x625B38", Offset = "0x625B38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60041F7")]
			[Address(RVA = "0xD9547C", Offset = "0xD9547C", VA = "0xD9547C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x625B48", Offset = "0x625B48")]
			set
			{
			}
		}

		[Token(Token = "0x17000876")]
		public Coroutine Coroutine
		{
			[Token(Token = "0x60041F8")]
			[Address(RVA = "0xD95488", Offset = "0xD95488", VA = "0xD95488")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x625B58", Offset = "0x625B58")]
			get
			{
				return null;
			}
			[Token(Token = "0x60041F9")]
			[Address(RVA = "0xD95490", Offset = "0xD95490", VA = "0xD95490")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x625B68", Offset = "0x625B68")]
			private set
			{
			}
		}

		[Token(Token = "0x17000877")]
		public object Current
		{
			[Token(Token = "0x60041FB")]
			[Address(RVA = "0xD954F8", Offset = "0xD954F8", VA = "0xD954F8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60041FA")]
		[Address(RVA = "0xD95498", Offset = "0xD95498", VA = "0xD95498")]
		public GameCoroutine(MonoBehaviour behaviour, IEnumerator enumerator, bool isPausable)
		{
		}

		[Token(Token = "0x60041FC")]
		[Address(RVA = "0xD955A8", Offset = "0xD955A8", VA = "0xD955A8", Slot = "6")]
		public void Reset()
		{
		}

		[Token(Token = "0x60041FD")]
		[Address(RVA = "0xD95658", Offset = "0xD95658", VA = "0xD95658", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60041FE")]
		[Address(RVA = "0xD95770", Offset = "0xD95770", VA = "0xD95770")]
		public void Stop()
		{
		}

		[Token(Token = "0x60041FF")]
		[Address(RVA = "0xD9577C", Offset = "0xD9577C", VA = "0xD9577C")]
		public void Pause()
		{
		}

		[Token(Token = "0x6004200")]
		[Address(RVA = "0xD95788", Offset = "0xD95788", VA = "0xD95788")]
		public void Resume()
		{
		}
	}
}
