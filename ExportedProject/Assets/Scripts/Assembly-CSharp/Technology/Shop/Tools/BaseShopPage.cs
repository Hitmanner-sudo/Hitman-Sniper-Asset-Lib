using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B45")]
	public abstract class BaseShopPage : FSMState
	{
		[Token(Token = "0x4003966")]
		[FieldOffset(Offset = "0x18")]
		public ToolsGUI Parent;

		[Token(Token = "0x4003967")]
		[FieldOffset(Offset = "0x20")]
		protected ToolsData _sniperShopData;

		[Token(Token = "0x4003968")]
		[FieldOffset(Offset = "0x28")]
		public int ObjectPerPage;

		[Token(Token = "0x4003969")]
		[FieldOffset(Offset = "0x2C")]
		protected Vector2 scrollPosition;

		[Token(Token = "0x400396A")]
		[FieldOffset(Offset = "0x34")]
		protected int descriptionMaxHeight;

		[Token(Token = "0x400396B")]
		[FieldOffset(Offset = "0x38")]
		protected string _newObjectLabel;

		[Token(Token = "0x400396C")]
		[FieldOffset(Offset = "0x40")]
		protected string _newObjectName;

		[Token(Token = "0x400396D")]
		[FieldOffset(Offset = "0x48")]
		protected Type _newObjectType;

		[Token(Token = "0x400396E")]
		[FieldOffset(Offset = "0x50")]
		protected int _currentId;

		[Token(Token = "0x400396F")]
		[FieldOffset(Offset = "0x54")]
		protected int _currentPage;

		[Token(Token = "0x4003970")]
		[FieldOffset(Offset = "0x58")]
		protected string _currentFilter;

		[Token(Token = "0x4003971")]
		[FieldOffset(Offset = "0x60")]
		public BaseShopData _currentObject;

		[Token(Token = "0x4003972")]
		[FieldOffset(Offset = "0x68")]
		public BaseShopData _cachedObject;

		[Token(Token = "0x4003973")]
		[FieldOffset(Offset = "0x70")]
		protected List<BaseShopData> _objectsList;

		[Token(Token = "0x4003974")]
		[FieldOffset(Offset = "0x78")]
		protected List<BaseShopData> _filteredList;

		[Token(Token = "0x4003975")]
		[FieldOffset(Offset = "0x80")]
		protected bool _confirmDeletion;

		[Token(Token = "0x4003976")]
		[FieldOffset(Offset = "0x81")]
		protected bool _selectCopyToServer;

		[Token(Token = "0x4003977")]
		[FieldOffset(Offset = "0x82")]
		protected bool _objectEditEnabled;

		[Token(Token = "0x4003978")]
		[FieldOffset(Offset = "0x83")]
		protected bool _isCreatingObject;

		[Token(Token = "0x4003979")]
		[FieldOffset(Offset = "0x88")]
		protected ListPopup _listPopup;

		[Token(Token = "0x400397A")]
		[FieldOffset(Offset = "0x90")]
		protected int _currentSelectedObjectId;

		[Token(Token = "0x400397B")]
		[FieldOffset(Offset = "0x94")]
		protected bool _displaySaveConfirmation;

		[Token(Token = "0x400397C")]
		[FieldOffset(Offset = "0x95")]
		protected bool _displayCreateConfirmation;

		[Token(Token = "0x400397D")]
		[FieldOffset(Offset = "0x98")]
		private string _prodpassword;

		[Token(Token = "0x400397E")]
		[FieldOffset(Offset = "0xA0")]
		protected string _currentPasswordFieldValue;

		[Token(Token = "0x400397F")]
		[FieldOffset(Offset = "0x0")]
		public static bool DisableDeleteOption;

		[Token(Token = "0x4003980")]
		[FieldOffset(Offset = "0xA8")]
		protected string _optionSuffix;

		[Token(Token = "0x6004754")]
		[Address(RVA = "0xC0E408", Offset = "0xC0E408", VA = "0xC0E408", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6004755")]
		[Address(RVA = "0xC0E7D8", Offset = "0xC0E7D8", VA = "0xC0E7D8", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6004756")]
		[Address(RVA = "0xC0E7DC", Offset = "0xC0E7DC", VA = "0xC0E7DC", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6004757")]
		[Address(RVA = "0xC0E7E0", Offset = "0xC0E7E0", VA = "0xC0E7E0", Slot = "10")]
		public virtual void OnGUI()
		{
		}

		[Token(Token = "0x6004758")]
		[Address(RVA = "0xC0ED98", Offset = "0xC0ED98", VA = "0xC0ED98", Slot = "11")]
		public virtual void OnPopupGUI()
		{
		}

		[Token(Token = "0x6004759")]
		[Address(RVA = "0xC0E874", Offset = "0xC0E874", VA = "0xC0E874")]
		private void DisplayObjectsList()
		{
		}

		[Token(Token = "0x600475A")]
		[Address(RVA = "0xC0EDB4", Offset = "0xC0EDB4", VA = "0xC0EDB4", Slot = "12")]
		protected virtual void DisplayConfirmationMessage()
		{
		}

		[Token(Token = "0x600475B")]
		protected abstract void RequestObjectList();

		[Token(Token = "0x600475C")]
		[Address(RVA = "0xC0EDB8", Offset = "0xC0EDB8", VA = "0xC0EDB8")]
		private List<BaseShopData> GetObjectList()
		{
			return null;
		}

		[Token(Token = "0x600475D")]
		[Address(RVA = "0xC0EE24", Offset = "0xC0EE24", VA = "0xC0EE24", Slot = "14")]
		protected virtual void SelectObject(int objectId)
		{
		}

		[Token(Token = "0x600475E")]
		[Address(RVA = "0xC0EF80", Offset = "0xC0EF80", VA = "0xC0EF80", Slot = "15")]
		protected virtual void DisplayObjectOptions()
		{
		}

		[Token(Token = "0x600475F")]
		[Address(RVA = "0xC0F9B8", Offset = "0xC0F9B8", VA = "0xC0F9B8", Slot = "16")]
		protected virtual bool HasValidData()
		{
			return default(bool);
		}

		[Token(Token = "0x6004760")]
		[Address(RVA = "0xC0F9D0", Offset = "0xC0F9D0", VA = "0xC0F9D0", Slot = "17")]
		public virtual void DisplayNewObjectPage()
		{
		}

		[Token(Token = "0x6004761")]
		protected abstract void DisplayObjectInfo();

		[Token(Token = "0x6004762")]
		protected abstract void CreateObject();

		[Token(Token = "0x6004763")]
		public abstract void UpdateObject();

		[Token(Token = "0x6004764")]
		protected abstract void RemoveObject();

		[Token(Token = "0x6004765")]
		protected abstract void CopyToServer(ToolsGUI.Servers server);

		[Token(Token = "0x6004766")]
		[Address(RVA = "0xC0FAA8", Offset = "0xC0FAA8", VA = "0xC0FAA8", Slot = "23")]
		protected virtual void RevertObject()
		{
		}

		[Token(Token = "0x6004767")]
		[Address(RVA = "0xC0E514", Offset = "0xC0E514", VA = "0xC0E514")]
		protected void FilterList(string filter)
		{
		}

		[Token(Token = "0x6004768")]
		[Address(RVA = "0xC0F970", Offset = "0xC0F970", VA = "0xC0F970")]
		public bool DataAuthAccess()
		{
			return default(bool);
		}

		[Token(Token = "0x6004769")]
		[Address(RVA = "0xC0F94C", Offset = "0xC0F94C", VA = "0xC0F94C")]
		protected bool IsPasswordProtected()
		{
			return default(bool);
		}

		[Token(Token = "0x600476A")]
		[Address(RVA = "0xC0FBF4", Offset = "0xC0FBF4", VA = "0xC0FBF4")]
		protected BaseShopPage()
		{
		}
	}
}
