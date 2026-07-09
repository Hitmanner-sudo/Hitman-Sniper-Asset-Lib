using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B6D")]
	public class NotificationPage : BaseShopPage
	{
		[Token(Token = "0x2000B6E")]
		public enum NotificationType
		{
			[Token(Token = "0x4003A1A")]
			All = 0,
			[Token(Token = "0x4003A1B")]
			List = 1,
			[Token(Token = "0x4003A1C")]
			Basic = 2,
			[Token(Token = "0x4003A1D")]
			Max = 3
		}

		[Token(Token = "0x4003A14")]
		[FieldOffset(Offset = "0xB0")]
		private string[] _pushResultString;

		[Token(Token = "0x4003A15")]
		[FieldOffset(Offset = "0xB8")]
		private PushNotificationData[] _notificationData;

		[Token(Token = "0x4003A16")]
		[FieldOffset(Offset = "0xC0")]
		private bool[] _confirmNotification;

		[Token(Token = "0x4003A17")]
		[FieldOffset(Offset = "0xC8")]
		private readonly string SUCCESS_MESSAGE;

		[Token(Token = "0x4003A18")]
		[FieldOffset(Offset = "0xD0")]
		private readonly string FAIL_MESSAGE;

		[Token(Token = "0x6004860")]
		[Address(RVA = "0xC60CA4", Offset = "0xC60CA4", VA = "0xC60CA4")]
		public NotificationPage()
		{
		}

		[Token(Token = "0x6004861")]
		[Address(RVA = "0xC60E8C", Offset = "0xC60E8C", VA = "0xC60E8C")]
		public void ResetNotificationData()
		{
		}

		[Token(Token = "0x6004862")]
		[Address(RVA = "0xC60FC4", Offset = "0xC60FC4", VA = "0xC60FC4", Slot = "13")]
		protected override void RequestObjectList()
		{
		}

		[Token(Token = "0x6004863")]
		[Address(RVA = "0xC60FC8", Offset = "0xC60FC8", VA = "0xC60FC8")]
		private void OnRequestObjectList(List<NotificationData> notificationList)
		{
		}

		[Token(Token = "0x6004864")]
		[Address(RVA = "0xC610C0", Offset = "0xC610C0", VA = "0xC610C0", Slot = "14")]
		protected override void SelectObject(int notificationId)
		{
		}

		[Token(Token = "0x6004865")]
		[Address(RVA = "0xC610E8", Offset = "0xC610E8", VA = "0xC610E8", Slot = "19")]
		protected override void CreateObject()
		{
		}

		[Token(Token = "0x6004866")]
		[Address(RVA = "0xC611E0", Offset = "0xC611E0", VA = "0xC611E0")]
		private void OnCreateObject(NotificationData data)
		{
		}

		[Token(Token = "0x6004867")]
		[Address(RVA = "0xC612E0", Offset = "0xC612E0", VA = "0xC612E0", Slot = "18")]
		protected override void DisplayObjectInfo()
		{
		}

		[Token(Token = "0x6004868")]
		[Address(RVA = "0xC62D40", Offset = "0xC62D40", VA = "0xC62D40")]
		private void PushNotificationByType(NotificationType type)
		{
		}

		[Token(Token = "0x6004869")]
		[Address(RVA = "0xC62F60", Offset = "0xC62F60", VA = "0xC62F60")]
		private void OnPushNotification(PushNotificationData data, NotificationType type)
		{
		}

		[Token(Token = "0x600486A")]
		[Address(RVA = "0xC63158", Offset = "0xC63158", VA = "0xC63158")]
		private void OnPushError(PushNotificationData data, NotificationType type)
		{
		}

		[Token(Token = "0x600486B")]
		[Address(RVA = "0xC62F88", Offset = "0xC62F88", VA = "0xC62F88")]
		private void WriteResultString(PushNotificationData data, NotificationType type, string result)
		{
		}

		[Token(Token = "0x600486C")]
		[Address(RVA = "0xC63180", Offset = "0xC63180", VA = "0xC63180", Slot = "20")]
		public override void UpdateObject()
		{
		}

		[Token(Token = "0x600486D")]
		[Address(RVA = "0xC6327C", Offset = "0xC6327C", VA = "0xC6327C")]
		private void OnUpdateObject(NotificationData data)
		{
		}

		[Token(Token = "0x600486E")]
		[Address(RVA = "0xC633EC", Offset = "0xC633EC", VA = "0xC633EC", Slot = "21")]
		protected override void RemoveObject()
		{
		}

		[Token(Token = "0x600486F")]
		[Address(RVA = "0xC634E8", Offset = "0xC634E8", VA = "0xC634E8", Slot = "22")]
		protected override void CopyToServer(ToolsGUI.Servers server)
		{
		}

		[Token(Token = "0x6004870")]
		[Address(RVA = "0xC63528", Offset = "0xC63528", VA = "0xC63528")]
		private void OnRemoveObject(NotificationData data)
		{
		}
	}
}
