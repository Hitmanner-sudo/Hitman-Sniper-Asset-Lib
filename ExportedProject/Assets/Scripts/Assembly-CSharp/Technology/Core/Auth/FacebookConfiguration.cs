using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DAF")]
	public class FacebookConfiguration : ScriptableObject
	{
		[Token(Token = "0x400413C")]
		[FieldOffset(Offset = "0x18")]
		public string AppId;

		[Token(Token = "0x400413D")]
		[FieldOffset(Offset = "0x20")]
		public string DisplayName;

		[Token(Token = "0x400413E")]
		[FieldOffset(Offset = "0x28")]
		public string Namespace;

		[Token(Token = "0x400413F")]
		[FieldOffset(Offset = "0x30")]
		public int DefaultAvatarImageWidth;

		[Token(Token = "0x4004140")]
		[FieldOffset(Offset = "0x34")]
		public int DefaultAvatarImageHeight;

		[Token(Token = "0x4004141")]
		[FieldOffset(Offset = "0x38")]
		public int DefaultTimeoutForRequests;

		[Token(Token = "0x4004142")]
		[FieldOffset(Offset = "0x3C")]
		public int MaximumAllowableFriends;

		[Token(Token = "0x4004143")]
		[FieldOffset(Offset = "0x40")]
		public string FacebookProfileURLFormat;

		[Token(Token = "0x4004144")]
		[FieldOffset(Offset = "0x48")]
		public string FacebookProfileImageURLFormat;

		[Token(Token = "0x4004145")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BE9EC", Offset = "0x5BE9EC")]
		public string EditorFacebookId;

		[Token(Token = "0x4004146")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEA24", Offset = "0x5BEA24")]
		public string EditorFacebookIdOAuthToken;

		[Token(Token = "0x4004147")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEA5C", Offset = "0x5BEA5C")]
		public bool ReadFriendLists;

		[Token(Token = "0x4004148")]
		[FieldOffset(Offset = "0x61")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEA94", Offset = "0x5BEA94")]
		public bool ReadRequests;

		[Token(Token = "0x4004149")]
		[FieldOffset(Offset = "0x62")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEACC", Offset = "0x5BEACC")]
		public bool ReadInsights;

		[Token(Token = "0x400414A")]
		[FieldOffset(Offset = "0x63")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEB04", Offset = "0x5BEB04")]
		public bool ReadMailbox;

		[Token(Token = "0x400414B")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEB3C", Offset = "0x5BEB3C")]
		public bool ReadStream;

		[Token(Token = "0x400414C")]
		[FieldOffset(Offset = "0x65")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEB74", Offset = "0x5BEB74")]
		public bool XmppLogin;

		[Token(Token = "0x400414D")]
		[FieldOffset(Offset = "0x66")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEBAC", Offset = "0x5BEBAC")]
		public bool UserOnlinePresence;

		[Token(Token = "0x400414E")]
		[FieldOffset(Offset = "0x67")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEBE4", Offset = "0x5BEBE4")]
		public bool FriendsOnlinePresence;

		[Token(Token = "0x400414F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEC1C", Offset = "0x5BEC1C")]
		public bool AdsManagement;

		[Token(Token = "0x4004150")]
		[FieldOffset(Offset = "0x69")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEC54", Offset = "0x5BEC54")]
		public bool CreateEvent;

		[Token(Token = "0x4004151")]
		[FieldOffset(Offset = "0x6A")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEC8C", Offset = "0x5BEC8C")]
		public bool ManageFriendLists;

		[Token(Token = "0x4004152")]
		[FieldOffset(Offset = "0x6B")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BECC4", Offset = "0x5BECC4")]
		public bool ManageNotifications;

		[Token(Token = "0x4004153")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BECFC", Offset = "0x5BECFC")]
		public bool PublishActions;

		[Token(Token = "0x4004154")]
		[FieldOffset(Offset = "0x6D")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BED34", Offset = "0x5BED34")]
		public bool PublishStream;

		[Token(Token = "0x4004155")]
		[FieldOffset(Offset = "0x6E")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BED6C", Offset = "0x5BED6C")]
		public bool RsvpEvent;

		[Token(Token = "0x4004156")]
		[FieldOffset(Offset = "0x6F")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEDA4", Offset = "0x5BEDA4")]
		public bool UserEmail;

		[Token(Token = "0x4004157")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEDDC", Offset = "0x5BEDDC")]
		public bool UserFriends;

		[Token(Token = "0x4004158")]
		[FieldOffset(Offset = "0x71")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEE14", Offset = "0x5BEE14")]
		public bool UserAboutMe;

		[Token(Token = "0x4004159")]
		[FieldOffset(Offset = "0x72")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEE4C", Offset = "0x5BEE4C")]
		public bool UserActivities;

		[Token(Token = "0x400415A")]
		[FieldOffset(Offset = "0x73")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEE84", Offset = "0x5BEE84")]
		public bool UserBirthday;

		[Token(Token = "0x400415B")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEEBC", Offset = "0x5BEEBC")]
		public bool UserEducationHistory;

		[Token(Token = "0x400415C")]
		[FieldOffset(Offset = "0x75")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEEF4", Offset = "0x5BEEF4")]
		public bool UserEvents;

		[Token(Token = "0x400415D")]
		[FieldOffset(Offset = "0x76")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEF2C", Offset = "0x5BEF2C")]
		public bool UserGroups;

		[Token(Token = "0x400415E")]
		[FieldOffset(Offset = "0x77")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEF64", Offset = "0x5BEF64")]
		public bool UserHometown;

		[Token(Token = "0x400415F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEF9C", Offset = "0x5BEF9C")]
		public bool UserInterests;

		[Token(Token = "0x4004160")]
		[FieldOffset(Offset = "0x79")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BEFD4", Offset = "0x5BEFD4")]
		public bool UserLikes;

		[Token(Token = "0x4004161")]
		[FieldOffset(Offset = "0x7A")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BF00C", Offset = "0x5BF00C")]
		public bool UserLocation;

		[Token(Token = "0x4004162")]
		[FieldOffset(Offset = "0x7B")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BF044", Offset = "0x5BF044")]
		public bool UserPhotos;

		[Token(Token = "0x4004163")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BF07C", Offset = "0x5BF07C")]
		public bool UserRelationships;

		[Token(Token = "0x4004164")]
		[FieldOffset(Offset = "0x7D")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BF0B4", Offset = "0x5BF0B4")]
		public bool UserRelationshipDetails;

		[Token(Token = "0x4004165")]
		[FieldOffset(Offset = "0x7E")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BF0EC", Offset = "0x5BF0EC")]
		public bool UserReligionPolitics;

		[Token(Token = "0x4004166")]
		[FieldOffset(Offset = "0x7F")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BF124", Offset = "0x5BF124")]
		public bool UserStatus;

		[Token(Token = "0x4004167")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BF15C", Offset = "0x5BF15C")]
		public bool UserTaggedPlaces;

		[Token(Token = "0x4004168")]
		[FieldOffset(Offset = "0x81")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BF194", Offset = "0x5BF194")]
		public bool UserVideos;

		[Token(Token = "0x4004169")]
		[FieldOffset(Offset = "0x82")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BF1CC", Offset = "0x5BF1CC")]
		public bool UserWebsite;

		[Token(Token = "0x400416A")]
		[FieldOffset(Offset = "0x83")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BF204", Offset = "0x5BF204")]
		public bool UserWorkHistory;

		[Token(Token = "0x6005456")]
		[Address(RVA = "0x94DB74", Offset = "0x94DB74", VA = "0x94DB74")]
		public FacebookConfiguration()
		{
		}
	}
}
