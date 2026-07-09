using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Social
{
	[Token(Token = "0x2000AEA")]
	public class NotificationsAndroid : NotificationModuleInterface
	{
		[Serializable]
		[Token(Token = "0x2000AEB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597DF8", Offset = "0x597DF8")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40037CA")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40037CB")]
			[FieldOffset(Offset = "0x8")]
			public static Action<bool> _003C_003E9__6_0;

			[Token(Token = "0x40037CC")]
			[FieldOffset(Offset = "0x10")]
			public static Action _003C_003E9__6_1;

			[Token(Token = "0x600442E")]
			[Address(RVA = "0x8CC714", Offset = "0x8CC714", VA = "0x8CC714")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600442F")]
			[Address(RVA = "0x8CC71C", Offset = "0x8CC71C", VA = "0x8CC71C")]
			internal void _003C_002Ector_003Eb__6_0(bool paused)
			{
			}

			[Token(Token = "0x6004430")]
			[Address(RVA = "0x8CC854", Offset = "0x8CC854", VA = "0x8CC854")]
			internal void _003C_002Ector_003Eb__6_1()
			{
			}
		}

		[Token(Token = "0x40037C4")]
		private const string CLASSPATH = "com.squareenixmontreal.armory.NotificationClient";

		[Token(Token = "0x40037C5")]
		private const string RECEIVER = "NotificationAndroid.HandlePushNotification";

		[Token(Token = "0x40037C6")]
		[FieldOffset(Offset = "0x18")]
		private string _registrationId;

		[Token(Token = "0x40037C7")]
		[FieldOffset(Offset = "0x20")]
		private bool _isRegistered;

		[Token(Token = "0x40037C8")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<object> _notificationAlertList;

		[Token(Token = "0x40037C9")]
		private const string GCM_SENDER_ID = "246152210526";

		[Token(Token = "0x17000893")]
		public override string NotificationDeviceToken
		{
			[Token(Token = "0x6004425")]
			[Address(RVA = "0x9E63C0", Offset = "0x9E63C0", VA = "0x9E63C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004422")]
		[Address(RVA = "0x9E5BA4", Offset = "0x9E5BA4", VA = "0x9E5BA4")]
		public NotificationsAndroid(NotificationConfiguration config)
		{
		}

		[Token(Token = "0x6004423")]
		[Address(RVA = "0x9E5FF8", Offset = "0x9E5FF8", VA = "0x9E5FF8")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6004424")]
		[Address(RVA = "0x9E6100", Offset = "0x9E6100", VA = "0x9E6100")]
		private void OnUpdateRequestToken()
		{
		}

		[Token(Token = "0x6004426")]
		[Address(RVA = "0x9E63C8", Offset = "0x9E63C8", VA = "0x9E63C8", Slot = "8")]
		public override void PollInboundNotifications(ref List<InboundNotification> notifications)
		{
		}

		[Token(Token = "0x6004427")]
		[Address(RVA = "0x9E64F4", Offset = "0x9E64F4", VA = "0x9E64F4", Slot = "4")]
		public override void Shutdown()
		{
		}

		[Token(Token = "0x6004428")]
		[Address(RVA = "0x9E64F8", Offset = "0x9E64F8", VA = "0x9E64F8", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x6004429")]
		[Address(RVA = "0x9E6600", Offset = "0x9E6600", VA = "0x9E6600")]
		private void OnNotificationReceived(JSONNode json)
		{
		}

		[Token(Token = "0x600442A")]
		[Address(RVA = "0x9E629C", Offset = "0x9E629C", VA = "0x9E629C")]
		private static string GetDeviceToken()
		{
			return null;
		}

		[Token(Token = "0x600442B")]
		[Address(RVA = "0x9E66EC", Offset = "0x9E66EC", VA = "0x9E66EC")]
		public static void SendLocalNotification(int delayInSeconds, string title, string subtitle, string url, string launchImagePath, string soundFilePath, Dictionary<string, string> customData, int requestCode)
		{
		}

		[Token(Token = "0x600442C")]
		[Address(RVA = "0x9E6910", Offset = "0x9E6910", VA = "0x9E6910")]
		public static void CancelLocalNotification(int requestCode)
		{
		}
	}
}
