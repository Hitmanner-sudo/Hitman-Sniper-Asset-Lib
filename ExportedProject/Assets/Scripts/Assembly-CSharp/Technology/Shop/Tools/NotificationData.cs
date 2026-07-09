using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.ServiceOperations;
using Technology.Shop.ServiceOperations;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B62")]
	public class NotificationData : BaseShopData
	{
		[Token(Token = "0x2000B63")]
		public delegate void NotificationsDataHandler(List<NotificationData> notifications);

		[Token(Token = "0x2000B64")]
		public delegate void PushNotificationDataHandler(PushNotificationData notification, NotificationPage.NotificationType type);

		[Token(Token = "0x2000B65")]
		public delegate void NotificationDataHandler(NotificationData notification);

		[Token(Token = "0x2000B66")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x598150", Offset = "0x598150")]
		private sealed class _003C_003Ec__DisplayClass43_0
		{
			[Token(Token = "0x4003A05")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGetNotificationsRaw svcOpc;

			[Token(Token = "0x6004851")]
			[Address(RVA = "0x8CAF8C", Offset = "0x8CAF8C", VA = "0x8CAF8C")]
			public _003C_003Ec__DisplayClass43_0()
			{
			}

			[Token(Token = "0x6004852")]
			[Address(RVA = "0x8CAF94", Offset = "0x8CAF94", VA = "0x8CAF94")]
			internal void _003CGetNotificationList_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000B67")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x598160", Offset = "0x598160")]
		private sealed class _003C_003Ec__DisplayClass44_0
		{
			[Token(Token = "0x4003A06")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpRegisterNotification svcOpC;

			[Token(Token = "0x4003A07")]
			[FieldOffset(Offset = "0x18")]
			public bool create;

			[Token(Token = "0x4003A08")]
			[FieldOffset(Offset = "0x20")]
			public NotificationData _003C_003E4__this;

			[Token(Token = "0x6004853")]
			[Address(RVA = "0x8CB5E0", Offset = "0x8CB5E0", VA = "0x8CB5E0")]
			public _003C_003Ec__DisplayClass44_0()
			{
			}

			[Token(Token = "0x6004854")]
			[Address(RVA = "0x8CB5E8", Offset = "0x8CB5E8", VA = "0x8CB5E8")]
			internal void _003CCreateOrUpdateNotification_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000B68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x598170", Offset = "0x598170")]
		private sealed class _003C_003Ec__DisplayClass47_0
		{
			[Token(Token = "0x4003A09")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpUnregisterNotification svcOpC;

			[Token(Token = "0x4003A0A")]
			[FieldOffset(Offset = "0x18")]
			public NotificationData _003C_003E4__this;

			[Token(Token = "0x6004855")]
			[Address(RVA = "0x8CB784", Offset = "0x8CB784", VA = "0x8CB784")]
			public _003C_003Ec__DisplayClass47_0()
			{
			}

			[Token(Token = "0x6004856")]
			[Address(RVA = "0x8CB78C", Offset = "0x8CB78C", VA = "0x8CB78C")]
			internal void _003CDelete_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000B69")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x598180", Offset = "0x598180")]
		private sealed class _003C_003Ec__DisplayClass48_0
		{
			[Token(Token = "0x4003A0B")]
			[FieldOffset(Offset = "0x10")]
			public Technology.Shop.ServiceOperations.SvcOpPushNotification svcOpC;

			[Token(Token = "0x4003A0C")]
			[FieldOffset(Offset = "0x18")]
			public NotificationData _003C_003E4__this;

			[Token(Token = "0x4003A0D")]
			[FieldOffset(Offset = "0x20")]
			public PushNotificationData data;

			[Token(Token = "0x6004857")]
			[Address(RVA = "0x8CB910", Offset = "0x8CB910", VA = "0x8CB910")]
			public _003C_003Ec__DisplayClass48_0()
			{
			}

			[Token(Token = "0x6004858")]
			[Address(RVA = "0x8CB918", Offset = "0x8CB918", VA = "0x8CB918")]
			internal void _003CPushNotification_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000B6A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x598190", Offset = "0x598190")]
		private sealed class _003C_003Ec__DisplayClass49_0
		{
			[Token(Token = "0x4003A0E")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpPushNotificationAll svcOpC;

			[Token(Token = "0x4003A0F")]
			[FieldOffset(Offset = "0x18")]
			public NotificationData _003C_003E4__this;

			[Token(Token = "0x4003A10")]
			[FieldOffset(Offset = "0x20")]
			public PushNotificationData data;

			[Token(Token = "0x6004859")]
			[Address(RVA = "0x8CBA8C", Offset = "0x8CBA8C", VA = "0x8CBA8C")]
			public _003C_003Ec__DisplayClass49_0()
			{
			}

			[Token(Token = "0x600485A")]
			[Address(RVA = "0x8CBA94", Offset = "0x8CBA94", VA = "0x8CBA94")]
			internal void _003CPushAllNotification_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000B6B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5981A0", Offset = "0x5981A0")]
		private sealed class _003C_003Ec__DisplayClass50_0
		{
			[Token(Token = "0x4003A11")]
			[FieldOffset(Offset = "0x10")]
			public Technology.Shop.ServiceOperations.SvcOpPushNotificationList svcOpC;

			[Token(Token = "0x4003A12")]
			[FieldOffset(Offset = "0x18")]
			public NotificationData _003C_003E4__this;

			[Token(Token = "0x4003A13")]
			[FieldOffset(Offset = "0x20")]
			public PushNotificationData data;

			[Token(Token = "0x600485B")]
			[Address(RVA = "0x8CBC08", Offset = "0x8CBC08", VA = "0x8CBC08")]
			public _003C_003Ec__DisplayClass50_0()
			{
			}

			[Token(Token = "0x600485C")]
			[Address(RVA = "0x8CBC10", Offset = "0x8CBC10", VA = "0x8CBC10")]
			internal void _003CPushNotificationList_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x4003A01")]
		[FieldOffset(Offset = "0x80")]
		public string SoundName;

		[Token(Token = "0x4003A02")]
		[FieldOffset(Offset = "0x88")]
		public string ImageName;

		[Token(Token = "0x4003A03")]
		[FieldOffset(Offset = "0x90")]
		public string TTL;

		[Token(Token = "0x4003A04")]
		[FieldOffset(Offset = "0x98")]
		public Dictionary<LanguageCode, string> LocaInfos;

		[Token(Token = "0x17000922")]
		public override string ObjectName
		{
			[Token(Token = "0x6004833")]
			[Address(RVA = "0xC5FB90", Offset = "0xC5FB90", VA = "0xC5FB90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000923")]
		public override bool HasSetMandatoryValues
		{
			[Token(Token = "0x6004834")]
			[Address(RVA = "0xC5FBD4", Offset = "0xC5FBD4", VA = "0xC5FBD4", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x140000EF")]
		public static event NotificationsDataHandler OnGetNotificationList
		{
			[Token(Token = "0x600481E")]
			[Address(RVA = "0xC5EAFC", Offset = "0xC5EAFC", VA = "0xC5EAFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627038", Offset = "0x627038")]
			add
			{
			}
			[Token(Token = "0x600481F")]
			[Address(RVA = "0xC5EBB8", Offset = "0xC5EBB8", VA = "0xC5EBB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627048", Offset = "0x627048")]
			remove
			{
			}
		}

		[Token(Token = "0x140000F0")]
		public event NotificationDataHandler OnCreate
		{
			[Token(Token = "0x6004820")]
			[Address(RVA = "0xC5EC74", Offset = "0xC5EC74", VA = "0xC5EC74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627058", Offset = "0x627058")]
			add
			{
			}
			[Token(Token = "0x6004821")]
			[Address(RVA = "0xC5ED14", Offset = "0xC5ED14", VA = "0xC5ED14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627068", Offset = "0x627068")]
			remove
			{
			}
		}

		[Token(Token = "0x140000F1")]
		public event NotificationDataHandler OnUpdate
		{
			[Token(Token = "0x6004822")]
			[Address(RVA = "0xC5EDB4", Offset = "0xC5EDB4", VA = "0xC5EDB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627078", Offset = "0x627078")]
			add
			{
			}
			[Token(Token = "0x6004823")]
			[Address(RVA = "0xC5EE54", Offset = "0xC5EE54", VA = "0xC5EE54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627088", Offset = "0x627088")]
			remove
			{
			}
		}

		[Token(Token = "0x140000F2")]
		public event NotificationDataHandler OnDelete
		{
			[Token(Token = "0x6004824")]
			[Address(RVA = "0xC5EEF4", Offset = "0xC5EEF4", VA = "0xC5EEF4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627098", Offset = "0x627098")]
			add
			{
			}
			[Token(Token = "0x6004825")]
			[Address(RVA = "0xC5EF94", Offset = "0xC5EF94", VA = "0xC5EF94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6270A8", Offset = "0x6270A8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000F3")]
		public event NotificationDataHandler OnError
		{
			[Token(Token = "0x6004826")]
			[Address(RVA = "0xC5F034", Offset = "0xC5F034", VA = "0xC5F034")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6270B8", Offset = "0x6270B8")]
			add
			{
			}
			[Token(Token = "0x6004827")]
			[Address(RVA = "0xC5F0D4", Offset = "0xC5F0D4", VA = "0xC5F0D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6270C8", Offset = "0x6270C8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000F4")]
		public event PushNotificationDataHandler OnPushError
		{
			[Token(Token = "0x6004828")]
			[Address(RVA = "0xC5F174", Offset = "0xC5F174", VA = "0xC5F174")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6270D8", Offset = "0x6270D8")]
			add
			{
			}
			[Token(Token = "0x6004829")]
			[Address(RVA = "0xC5F214", Offset = "0xC5F214", VA = "0xC5F214")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6270E8", Offset = "0x6270E8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000F5")]
		public event PushNotificationDataHandler OnPushNotification
		{
			[Token(Token = "0x600482A")]
			[Address(RVA = "0xC5F2B4", Offset = "0xC5F2B4", VA = "0xC5F2B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6270F8", Offset = "0x6270F8")]
			add
			{
			}
			[Token(Token = "0x600482B")]
			[Address(RVA = "0xC5F354", Offset = "0xC5F354", VA = "0xC5F354")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627108", Offset = "0x627108")]
			remove
			{
			}
		}

		[Token(Token = "0x140000F6")]
		public event PushNotificationDataHandler OnPushAllNotification
		{
			[Token(Token = "0x600482C")]
			[Address(RVA = "0xC5F3F4", Offset = "0xC5F3F4", VA = "0xC5F3F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627118", Offset = "0x627118")]
			add
			{
			}
			[Token(Token = "0x600482D")]
			[Address(RVA = "0xC5F494", Offset = "0xC5F494", VA = "0xC5F494")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627128", Offset = "0x627128")]
			remove
			{
			}
		}

		[Token(Token = "0x140000F7")]
		public event PushNotificationDataHandler OnPushNotificationList
		{
			[Token(Token = "0x600482E")]
			[Address(RVA = "0xC5F534", Offset = "0xC5F534", VA = "0xC5F534")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627138", Offset = "0x627138")]
			add
			{
			}
			[Token(Token = "0x600482F")]
			[Address(RVA = "0xC5F5D4", Offset = "0xC5F5D4", VA = "0xC5F5D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627148", Offset = "0x627148")]
			remove
			{
			}
		}

		[Token(Token = "0x6004830")]
		[Address(RVA = "0xC5F674", Offset = "0xC5F674", VA = "0xC5F674")]
		public NotificationData()
		{
		}

		[Token(Token = "0x6004831")]
		[Address(RVA = "0xC5F728", Offset = "0xC5F728", VA = "0xC5F728")]
		public NotificationData(NotificationData obj)
		{
		}

		[Token(Token = "0x6004832")]
		[Address(RVA = "0xC5F990", Offset = "0xC5F990", VA = "0xC5F990", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004835")]
		[Address(RVA = "0xC5FD6C", Offset = "0xC5FD6C", VA = "0xC5FD6C", Slot = "11")]
		internal override void FromJSON(JSONNode node)
		{
		}

		[Token(Token = "0x6004836")]
		[Address(RVA = "0xC5FF9C", Offset = "0xC5FF9C", VA = "0xC5FF9C", Slot = "10")]
		internal override string ToJSON()
		{
			return null;
		}

		[Token(Token = "0x6004837")]
		[Address(RVA = "0xC602B4", Offset = "0xC602B4", VA = "0xC602B4")]
		internal static void GetNotificationList()
		{
		}

		[Token(Token = "0x6004838")]
		[Address(RVA = "0xC603C4", Offset = "0xC603C4", VA = "0xC603C4")]
		private void CreateOrUpdateNotification(bool create)
		{
		}

		[Token(Token = "0x6004839")]
		[Address(RVA = "0xC6051C", Offset = "0xC6051C", VA = "0xC6051C", Slot = "12")]
		public override bool Create()
		{
			return default(bool);
		}

		[Token(Token = "0x600483A")]
		[Address(RVA = "0xC60538", Offset = "0xC60538", VA = "0xC60538", Slot = "13")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x600483B")]
		[Address(RVA = "0xC60554", Offset = "0xC60554", VA = "0xC60554", Slot = "14")]
		public override bool Delete()
		{
			return default(bool);
		}

		[Token(Token = "0x600483C")]
		[Address(RVA = "0xC60688", Offset = "0xC60688", VA = "0xC60688")]
		internal void PushNotification(PushNotificationData data)
		{
		}

		[Token(Token = "0x600483D")]
		[Address(RVA = "0xC607F0", Offset = "0xC607F0", VA = "0xC607F0")]
		internal void PushAllNotification(PushNotificationData data)
		{
		}

		[Token(Token = "0x600483E")]
		[Address(RVA = "0xC6093C", Offset = "0xC6093C", VA = "0xC6093C")]
		internal void PushNotificationList(PushNotificationData data)
		{
		}

		[Token(Token = "0x600483F")]
		[Address(RVA = "0xC60A88", Offset = "0xC60A88", VA = "0xC60A88")]
		private void TriggerEvent(PushNotificationDataHandler handler, PushNotificationData data, NotificationPage.NotificationType type)
		{
		}

		[Token(Token = "0x6004840")]
		[Address(RVA = "0xC60AA4", Offset = "0xC60AA4", VA = "0xC60AA4")]
		private void TriggerEvent(NotificationDataHandler handler, NotificationData data)
		{
		}

		[Token(Token = "0x6004841")]
		[Address(RVA = "0xC60ABC", Offset = "0xC60ABC", VA = "0xC60ABC")]
		private void TriggerEvent(NotificationDataHandler handler)
		{
		}

		[Token(Token = "0x6004842")]
		[Address(RVA = "0xC60AD8", Offset = "0xC60AD8", VA = "0xC60AD8")]
		[DebuggerHidden]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627158", Offset = "0x627158")]
		private bool _003C_003En__0()
		{
			return default(bool);
		}

		[Token(Token = "0x6004843")]
		[Address(RVA = "0xC60AE0", Offset = "0xC60AE0", VA = "0xC60AE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627190", Offset = "0x627190")]
		[DebuggerHidden]
		private bool _003C_003En__1()
		{
			return default(bool);
		}

		[Token(Token = "0x6004844")]
		[Address(RVA = "0xC60AE8", Offset = "0xC60AE8", VA = "0xC60AE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6271C8", Offset = "0x6271C8")]
		[DebuggerHidden]
		private bool _003C_003En__2()
		{
			return default(bool);
		}
	}
}
