using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B49")]
	public class ListPopup
	{
		[Token(Token = "0x4003986")]
		[FieldOffset(Offset = "0x10")]
		private int POPUP_WIDTH;

		[Token(Token = "0x4003987")]
		[FieldOffset(Offset = "0x14")]
		private int POPUP_HEIGHT;

		[Token(Token = "0x4003988")]
		[FieldOffset(Offset = "0x18")]
		private string _title;

		[Token(Token = "0x4003989")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, string> _data;

		[Token(Token = "0x400398A")]
		[FieldOffset(Offset = "0x28")]
		private bool _isActive;

		[Token(Token = "0x400398B")]
		[FieldOffset(Offset = "0x2C")]
		private Vector2 _scrollPosition;

		[Token(Token = "0x400398C")]
		[FieldOffset(Offset = "0x38")]
		private EventHandler<ResultListPopupEvent> OnResultCallback;

		[Token(Token = "0x6004777")]
		[Address(RVA = "0x9C994C", Offset = "0x9C994C", VA = "0x9C994C")]
		public ListPopup()
		{
		}

		[Token(Token = "0x6004778")]
		[Address(RVA = "0x9C9980", Offset = "0x9C9980", VA = "0x9C9980")]
		public void Reset()
		{
		}

		[Token(Token = "0x6004779")]
		[Address(RVA = "0x9C9A04", Offset = "0x9C9A04", VA = "0x9C9A04")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x600477A")]
		[Address(RVA = "0x9C9A0C", Offset = "0x9C9A0C", VA = "0x9C9A0C")]
		public void Display(string title, Dictionary<int, string> data, EventHandler<ResultListPopupEvent> onResultCallback)
		{
		}

		[Token(Token = "0x600477B")]
		[Address(RVA = "0x9C9A2C", Offset = "0x9C9A2C", VA = "0x9C9A2C")]
		public void OnDisplay()
		{
		}
	}
}
