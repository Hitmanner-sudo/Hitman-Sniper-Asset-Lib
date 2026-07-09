using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;
using UnityEngine;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B50")]
	public abstract class ToolsGUI : MonoBehaviour
	{
		[Token(Token = "0x2000B51")]
		public struct Page
		{
			[Token(Token = "0x40039B2")]
			[FieldOffset(Offset = "0x0")]
			public string Name;

			[Token(Token = "0x40039B3")]
			[FieldOffset(Offset = "0x8")]
			public Type PageType;
		}

		[Token(Token = "0x2000B52")]
		public enum Servers
		{
			[Token(Token = "0x40039B5")]
			NONE = 0,
			[Token(Token = "0x40039B6")]
			PREDEV = 1,
			[Token(Token = "0x40039B7")]
			DEV = 2,
			[Token(Token = "0x40039B8")]
			PREPROD = 3,
			[Token(Token = "0x40039B9")]
			PROD = 4
		}

		[Token(Token = "0x40039A6")]
		private const int OPTION_BUTTON_WIDTH = 100;

		[Token(Token = "0x40039A7")]
		private const int OPTION_BUTTON_HEIGHT = 40;

		[Token(Token = "0x40039A8")]
		private const int OPTION_BUTTON_SPACING = 5;

		[Token(Token = "0x40039A9")]
		[FieldOffset(Offset = "0x18")]
		private OnlineSuiteConfiguration _onlineSuiteConfiguration;

		[Token(Token = "0x40039AA")]
		[FieldOffset(Offset = "0x20")]
		private Servers _currentServer;

		[Token(Token = "0x40039AB")]
		[FieldOffset(Offset = "0x24")]
		private int _currentServerId;

		[Token(Token = "0x40039AC")]
		[FieldOffset(Offset = "0x28")]
		private BaseShopPage _currentPage;

		[Token(Token = "0x40039AD")]
		[FieldOffset(Offset = "0x0")]
		public static List<LanguageSettings> LanguageList;

		[Token(Token = "0x40039AE")]
		[FieldOffset(Offset = "0x30")]
		protected List<Page> _pagesList;

		[Token(Token = "0x40039AF")]
		[FieldOffset(Offset = "0x38")]
		private string[] _pagesListName;

		[Token(Token = "0x40039B0")]
		[FieldOffset(Offset = "0x40")]
		private List<Servers> _serverList;

		[Token(Token = "0x40039B1")]
		[FieldOffset(Offset = "0x48")]
		private GUIStyle _serverTextStyle;

		[Token(Token = "0x60047A5")]
		[Address(RVA = "0xAD53DC", Offset = "0xAD53DC", VA = "0xAD53DC")]
		public BaseShopPage GetCurrentPage()
		{
			return null;
		}

		[Token(Token = "0x60047A6")]
		[Address(RVA = "0xAD53E4", Offset = "0xAD53E4", VA = "0xAD53E4")]
		public List<Servers> GetServerList()
		{
			return null;
		}

		[Token(Token = "0x60047A7")]
		[Address(RVA = "0xAD53EC", Offset = "0xAD53EC", VA = "0xAD53EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60047A8")]
		protected abstract void AddPageList();

		[Token(Token = "0x60047A9")]
		protected abstract string GetHistoryFileName();

		[Token(Token = "0x60047AA")]
		[Address(RVA = "0xAD5ABC", Offset = "0xAD5ABC", VA = "0xAD5ABC")]
		protected void Update()
		{
		}

		[Token(Token = "0x60047AB")]
		[Address(RVA = "0xAD5AD4", Offset = "0xAD5AD4", VA = "0xAD5AD4")]
		protected void OnGUI()
		{
		}

		[Token(Token = "0x60047AC")]
		[Address(RVA = "0xAD6230", Offset = "0xAD6230", VA = "0xAD6230")]
		public Servers GetServerName()
		{
			return default(Servers);
		}

		[Token(Token = "0x60047AD")]
		[Address(RVA = "0xAD60C0", Offset = "0xAD60C0", VA = "0xAD60C0")]
		private string GetServerName(Servers server)
		{
			return null;
		}

		[Token(Token = "0x60047AE")]
		[Address(RVA = "0xAD581C", Offset = "0xAD581C", VA = "0xAD581C")]
		public void ChangeServer(Servers server)
		{
		}

		[Token(Token = "0x60047AF")]
		[Address(RVA = "0xAD615C", Offset = "0xAD615C", VA = "0xAD615C")]
		public void ChangePage(Type pageType)
		{
		}

		[Token(Token = "0x60047B0")]
		[Address(RVA = "0xAD6238", Offset = "0xAD6238", VA = "0xAD6238")]
		protected ToolsGUI()
		{
		}
	}
}
