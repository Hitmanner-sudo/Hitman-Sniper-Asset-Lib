using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using UnityEngine;

[Serializable]
[Token(Token = "0x200057F")]
public class CalenderModel : DataModel, ISaveable
{
	[Serializable]
	[Token(Token = "0x2000580")]
	public class SerializableDate : ISaveable
	{
		[Token(Token = "0x4001D08")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7D94", Offset = "0x5B7D94")]
		public int Year;

		[Token(Token = "0x4001D09")]
		[FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7DA4", Offset = "0x5B7DA4")]
		public int Month;

		[Token(Token = "0x4001D0A")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7DB4", Offset = "0x5B7DB4")]
		public int Day;

		[Token(Token = "0x60022A6")]
		[Address(RVA = "0x86145C", Offset = "0x86145C", VA = "0x86145C")]
		public SerializableDate()
		{
		}

		[Token(Token = "0x60022A7")]
		[Address(RVA = "0x861488", Offset = "0x861488", VA = "0x861488")]
		public SerializableDate(SerializableDate date)
		{
		}

		[Token(Token = "0x60022A8")]
		[Address(RVA = "0x8614D0", Offset = "0x8614D0", VA = "0x8614D0", Slot = "6")]
		public virtual void OnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x60022A9")]
		[Address(RVA = "0x861558", Offset = "0x861558", VA = "0x861558", Slot = "7")]
		public virtual JSONNode OnSaveableSerialization()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000581")]
	public class EventActiveDate : ISaveable
	{
		[Token(Token = "0x4001D0B")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7DC4", Offset = "0x5B7DC4")]
		public SerializableDate StartDate;

		[Token(Token = "0x4001D0C")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7DD4", Offset = "0x5B7DD4")]
		public SerializableDate EndDate;

		[Token(Token = "0x60022AA")]
		[Address(RVA = "0x861344", Offset = "0x861344", VA = "0x861344", Slot = "6")]
		public virtual void OnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x60022AB")]
		[Address(RVA = "0x8613CC", Offset = "0x8613CC", VA = "0x8613CC", Slot = "7")]
		public virtual JSONNode OnSaveableSerialization()
		{
			return null;
		}

		[Token(Token = "0x60022AC")]
		[Address(RVA = "0x861444", Offset = "0x861444", VA = "0x861444")]
		public EventActiveDate()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000582")]
	public struct AlternateLevel
	{
		[Token(Token = "0x4001D0D")]
		[FieldOffset(Offset = "0x0")]
		public string Original;

		[Token(Token = "0x4001D0E")]
		[FieldOffset(Offset = "0x8")]
		public string ReplaceBy;
	}

	[Serializable]
	[Token(Token = "0x2000583")]
	public struct AlternateCharacter
	{
		[Token(Token = "0x4001D0F")]
		[FieldOffset(Offset = "0x0")]
		public LazyCharacter Original;

		[Token(Token = "0x4001D10")]
		[FieldOffset(Offset = "0x8")]
		public LazyCharacter ReplaceBy;
	}

	[Serializable]
	[Token(Token = "0x2000584")]
	public struct InventoryItemToAdd
	{
		[Token(Token = "0x4001D11")]
		[FieldOffset(Offset = "0x0")]
		public LazyInventoryItem LazyItem;

		[Token(Token = "0x4001D12")]
		[FieldOffset(Offset = "0x8")]
		public Faction[] Factions;
	}

	[Serializable]
	[Token(Token = "0x2000585")]
	public struct AlternateSoundContainer
	{
		[Token(Token = "0x4001D13")]
		[FieldOffset(Offset = "0x0")]
		public SoundContainer Original;

		[Token(Token = "0x4001D14")]
		[FieldOffset(Offset = "0x8")]
		public SoundContainer ReplaceBy;
	}

	[Serializable]
	[Token(Token = "0x2000586")]
	public struct AlternateTexture
	{
		[Token(Token = "0x4001D15")]
		[FieldOffset(Offset = "0x0")]
		public LazyTexture Original;

		[Token(Token = "0x4001D16")]
		[FieldOffset(Offset = "0x8")]
		public LazyTexture ReplaceBy;

		[Token(Token = "0x4001D17")]
		[FieldOffset(Offset = "0x10")]
		public bool ResizeWithNewSize;

		[Token(Token = "0x4001D18")]
		[FieldOffset(Offset = "0x11")]
		public bool ResizeKeepingCurrentHeight;

		[Token(Token = "0x4001D19")]
		[FieldOffset(Offset = "0x12")]
		public bool SetPositionOffsetOnPhone;

		[Token(Token = "0x4001D1A")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 PositionNewValuePhone;

		[Token(Token = "0x4001D1B")]
		[FieldOffset(Offset = "0x1C")]
		public bool SetPositionOffsetOnTablet;

		[Token(Token = "0x4001D1C")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 PositionNewValueTablet;

		[Token(Token = "0x4001D1D")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 OriginalSize;
	}

	[Serializable]
	[Token(Token = "0x2000587")]
	public struct AlternateMaterial
	{
		[Token(Token = "0x4001D1E")]
		[FieldOffset(Offset = "0x0")]
		public LazyMaterial Original;

		[Token(Token = "0x4001D1F")]
		[FieldOffset(Offset = "0x8")]
		public LazyMaterial ReplaceBy;

		[Token(Token = "0x4001D20")]
		[FieldOffset(Offset = "0x10")]
		public LazyMaterial ReplaceByLowEnd;

		[Token(Token = "0x4001D21")]
		[FieldOffset(Offset = "0x18")]
		public bool IOSOnly;
	}

	[Serializable]
	[Token(Token = "0x2000588")]
	public struct AlternateGameObject
	{
		[Token(Token = "0x4001D22")]
		[FieldOffset(Offset = "0x0")]
		public LazyGameObject Original;

		[Token(Token = "0x4001D23")]
		[FieldOffset(Offset = "0x8")]
		public LazyGameObject ReplaceBy;
	}

	[Serializable]
	[Token(Token = "0x2000589")]
	public class ScoreItemData
	{
		[Token(Token = "0x4001D24")]
		[FieldOffset(Offset = "0x10")]
		public string Title;

		[Token(Token = "0x4001D25")]
		[FieldOffset(Offset = "0x18")]
		public ScoreTallyView.TallyItem TallyItem;

		[Token(Token = "0x4001D26")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5B7DE4", Offset = "0x5B7DE4")]
		public Wallet.Currency DefaultCurrency;

		[Token(Token = "0x60022AD")]
		[Address(RVA = "0x86144C", Offset = "0x86144C", VA = "0x86144C")]
		public ScoreItemData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200058A")]
	public class CalenderEvent : ISaveable
	{
		[Token(Token = "0x4001D27")]
		[FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x4001D28")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7E1C", Offset = "0x5B7E1C")]
		public EventActiveDate[] EventActiveDate;

		[Token(Token = "0x4001D29")]
		[FieldOffset(Offset = "0x20")]
		public AlternateLevel[] AlternateLevel;

		[Token(Token = "0x4001D2A")]
		[FieldOffset(Offset = "0x28")]
		public AlternateCharacter[] AlternateCharacter;

		[Token(Token = "0x4001D2B")]
		[FieldOffset(Offset = "0x30")]
		public InventoryItemToAdd[] InventoryItemsToAdd;

		[Token(Token = "0x4001D2C")]
		[FieldOffset(Offset = "0x38")]
		public AlternateSoundContainer[] AlternateSoundContainer;

		[Token(Token = "0x4001D2D")]
		[FieldOffset(Offset = "0x40")]
		public AlternateTexture[] AlternateTexture;

		[Token(Token = "0x4001D2E")]
		[FieldOffset(Offset = "0x48")]
		public AlternateMaterial[] AlternateMaterial;

		[Token(Token = "0x4001D2F")]
		[FieldOffset(Offset = "0x50")]
		public SpecialPopup[] AlternateSpecialPopup;

		[Token(Token = "0x4001D30")]
		[FieldOffset(Offset = "0x58")]
		public LazyWeaponUnlockable[] EventSpecificLazyWeaponUnlockable;

		[Token(Token = "0x4001D31")]
		[FieldOffset(Offset = "0x60")]
		public ScoreItemData[] ExtraScoreTallyItems;

		[Token(Token = "0x4001D32")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ColorModel.ColorModelEnum _gameTimerColor;

		[Token(Token = "0x4001D33")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CalendarEventNotificationData _notificationData;

		[Token(Token = "0x170004F3")]
		public CalendarEventNotificationData NotificationData
		{
			[Token(Token = "0x60022AE")]
			[Address(RVA = "0x86122C", Offset = "0x86122C", VA = "0x86122C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F4")]
		public ColorModel.ColorModelEnum GameTimerColor
		{
			[Token(Token = "0x60022AF")]
			[Address(RVA = "0x861234", Offset = "0x861234", VA = "0x861234")]
			get
			{
				return default(ColorModel.ColorModelEnum);
			}
		}

		[Token(Token = "0x60022B0")]
		[Address(RVA = "0x86123C", Offset = "0x86123C", VA = "0x86123C", Slot = "6")]
		public virtual void OnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x60022B1")]
		[Address(RVA = "0x8612C4", Offset = "0x8612C4", VA = "0x8612C4", Slot = "7")]
		public virtual JSONNode OnSaveableSerialization()
		{
			return null;
		}

		[Token(Token = "0x60022B2")]
		[Address(RVA = "0x86133C", Offset = "0x86133C", VA = "0x86133C")]
		public CalenderEvent()
		{
		}
	}

	[Token(Token = "0x200058B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59533C", Offset = "0x59533C")]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x4001D34")]
		[FieldOffset(Offset = "0x10")]
		public DateTime now;

		[Token(Token = "0x4001D35")]
		[FieldOffset(Offset = "0x18")]
		public Func<DateTime, bool> _003C_003E9__2;

		[Token(Token = "0x60022B3")]
		[Address(RVA = "0x8611AC", Offset = "0x8611AC", VA = "0x8611AC")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60022B4")]
		[Address(RVA = "0x8611B4", Offset = "0x8611B4", VA = "0x8611B4")]
		internal bool _003CRegisterEventsNotifications_003Eb__2(DateTime d)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x200058C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59534C", Offset = "0x59534C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001D36")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001D37")]
		[FieldOffset(Offset = "0x8")]
		public static Func<EventActiveDate, DateTime> _003C_003E9__25_0;

		[Token(Token = "0x4001D38")]
		[FieldOffset(Offset = "0x10")]
		public static Func<DateTime, DateTime> _003C_003E9__25_1;

		[Token(Token = "0x4001D39")]
		[FieldOffset(Offset = "0x18")]
		public static Func<CalenderEvent, int> _003C_003E9__26_0;

		[Token(Token = "0x60022B6")]
		[Address(RVA = "0x861128", Offset = "0x861128", VA = "0x861128")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60022B7")]
		[Address(RVA = "0x861130", Offset = "0x861130", VA = "0x861130")]
		internal DateTime _003CRegisterEventsNotifications_003Eb__25_0(EventActiveDate d)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60022B8")]
		[Address(RVA = "0x861180", Offset = "0x861180", VA = "0x861180")]
		internal DateTime _003CRegisterEventsNotifications_003Eb__25_1(DateTime d)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60022B9")]
		[Address(RVA = "0x861188", Offset = "0x861188", VA = "0x861188")]
		internal int _003CUnregisterEventsNotifications_003Eb__26_0(CalenderEvent e)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4001CFF")]
	private const string NOTIFICATION_CALENDAREVENT_TYPE = "calendarevent";

	[Token(Token = "0x4001D00")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string CALENDEREVENTS;

	[Token(Token = "0x4001D01")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string DEBUGDATE;

	[Token(Token = "0x4001D02")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string USE_DEBUGDATE;

	[Token(Token = "0x4001D03")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string DISPLAY_EVENT_VISUAL;

	[Token(Token = "0x4001D04")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B7D3C", Offset = "0x5B7D3C")]
	[SerializeField]
	private CalenderEvent[] CalenderEvents;

	[Token(Token = "0x4001D05")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private SerializableDate _debugTimeDate;

	[Token(Token = "0x4001D06")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool _useDebugTimeDate;

	[NonSerialized]
	[Token(Token = "0x4001D07")]
	[FieldOffset(Offset = "0x59")]
	private bool _displayEventVisual;

	[Token(Token = "0x6002295")]
	[Address(RVA = "0xA8E250", Offset = "0xA8E250", VA = "0xA8E250", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x6002296")]
	[Address(RVA = "0xA8DB2C", Offset = "0xA8DB2C", VA = "0xA8DB2C")]
	public static CalenderEvent GetEvent(CalenderEvent[] calenderEvents, DateTime currentDateTime)
	{
		return null;
	}

	[Token(Token = "0x6002297")]
	[Address(RVA = "0xA8E578", Offset = "0xA8E578", VA = "0xA8E578", Slot = "6")]
	public void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6002298")]
	[Address(RVA = "0xA8E600", Offset = "0xA8E600", VA = "0xA8E600", Slot = "7")]
	public JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6002299")]
	[Address(RVA = "0xA8E678", Offset = "0xA8E678", VA = "0xA8E678", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600229A")]
	[Address(RVA = "0xA8E78C", Offset = "0xA8E78C", VA = "0xA8E78C")]
	private void RegisterEventsNotifications(object sender, NotificationsManager.RegisterNotificationsEventArgs e)
	{
	}

	[Token(Token = "0x600229B")]
	[Address(RVA = "0xA8EB78", Offset = "0xA8EB78", VA = "0xA8EB78")]
	private void UnregisterEventsNotifications()
	{
	}

	[Token(Token = "0x600229C")]
	[Address(RVA = "0xA8ECC4", Offset = "0xA8ECC4", VA = "0xA8ECC4")]
	public CalenderModel()
	{
	}

	[Token(Token = "0x600229E")]
	[Address(RVA = "0xA8ED9C", Offset = "0xA8ED9C", VA = "0xA8ED9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619F60", Offset = "0x619F60")]
	private object _003CBindAllVariables_003Eb__20_0()
	{
		return null;
	}

	[Token(Token = "0x600229F")]
	[Address(RVA = "0xA8EDA4", Offset = "0xA8EDA4", VA = "0xA8EDA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619F70", Offset = "0x619F70")]
	private void _003CBindAllVariables_003Eb__20_1(object a)
	{
	}

	[Token(Token = "0x60022A0")]
	[Address(RVA = "0xA8EE20", Offset = "0xA8EE20", VA = "0xA8EE20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619F80", Offset = "0x619F80")]
	private object _003CBindAllVariables_003Eb__20_2()
	{
		return null;
	}

	[Token(Token = "0x60022A1")]
	[Address(RVA = "0xA8EE28", Offset = "0xA8EE28", VA = "0xA8EE28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619F90", Offset = "0x619F90")]
	private void _003CBindAllVariables_003Eb__20_3(object a)
	{
	}

	[Token(Token = "0x60022A2")]
	[Address(RVA = "0xA8EEB4", Offset = "0xA8EEB4", VA = "0xA8EEB4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619FA0", Offset = "0x619FA0")]
	private bool _003CBindAllVariables_003Eb__20_4()
	{
		return default(bool);
	}

	[Token(Token = "0x60022A3")]
	[Address(RVA = "0xA8EEBC", Offset = "0xA8EEBC", VA = "0xA8EEBC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619FB0", Offset = "0x619FB0")]
	private void _003CBindAllVariables_003Eb__20_5(bool a)
	{
	}

	[Token(Token = "0x60022A4")]
	[Address(RVA = "0xA8EEC8", Offset = "0xA8EEC8", VA = "0xA8EEC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619FC0", Offset = "0x619FC0")]
	private bool _003CBindAllVariables_003Eb__20_6()
	{
		return default(bool);
	}

	[Token(Token = "0x60022A5")]
	[Address(RVA = "0xA8EED0", Offset = "0xA8EED0", VA = "0xA8EED0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619FD0", Offset = "0x619FD0")]
	private void _003CBindAllVariables_003Eb__20_7(bool a)
	{
	}
}
