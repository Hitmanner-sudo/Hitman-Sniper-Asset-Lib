using System;
using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	[Token(Token = "0x2000959")]
	internal class PlayGamesAchievement : IAchievement, IAchievementDescription
	{
		[Token(Token = "0x40032DE")]
		[FieldOffset(Offset = "0x10")]
		private readonly ReportProgress mProgressCallback;

		[Token(Token = "0x40032DF")]
		[FieldOffset(Offset = "0x18")]
		private string mId;

		[Token(Token = "0x40032E0")]
		[FieldOffset(Offset = "0x20")]
		private bool mIsIncremental;

		[Token(Token = "0x40032E1")]
		[FieldOffset(Offset = "0x24")]
		private int mCurrentSteps;

		[Token(Token = "0x40032E2")]
		[FieldOffset(Offset = "0x28")]
		private int mTotalSteps;

		[Token(Token = "0x40032E3")]
		[FieldOffset(Offset = "0x30")]
		private double mPercentComplete;

		[Token(Token = "0x40032E4")]
		[FieldOffset(Offset = "0x38")]
		private bool mCompleted;

		[Token(Token = "0x40032E5")]
		[FieldOffset(Offset = "0x39")]
		private bool mHidden;

		[Token(Token = "0x40032E6")]
		[FieldOffset(Offset = "0x40")]
		private DateTime mLastModifiedTime;

		[Token(Token = "0x40032E7")]
		[FieldOffset(Offset = "0x48")]
		private string mTitle;

		[Token(Token = "0x40032E8")]
		[FieldOffset(Offset = "0x50")]
		private string mRevealedImageUrl;

		[Token(Token = "0x40032E9")]
		[FieldOffset(Offset = "0x58")]
		private string mUnlockedImageUrl;

		[Token(Token = "0x40032EA")]
		[FieldOffset(Offset = "0x60")]
		private UnityWebRequest mImageFetcher;

		[Token(Token = "0x40032EB")]
		[FieldOffset(Offset = "0x68")]
		private Texture2D mImage;

		[Token(Token = "0x40032EC")]
		[FieldOffset(Offset = "0x70")]
		private string mDescription;

		[Token(Token = "0x40032ED")]
		[FieldOffset(Offset = "0x78")]
		private ulong mPoints;

		[Token(Token = "0x17000771")]
		public string id
		{
			[Token(Token = "0x6003BE6")]
			[Address(RVA = "0xB755A4", Offset = "0xB755A4", VA = "0xB755A4", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BE7")]
			[Address(RVA = "0xB755AC", Offset = "0xB755AC", VA = "0xB755AC", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000772")]
		public bool isIncremental
		{
			[Token(Token = "0x6003BE8")]
			[Address(RVA = "0xB755B4", Offset = "0xB755B4", VA = "0xB755B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000773")]
		public int currentSteps
		{
			[Token(Token = "0x6003BE9")]
			[Address(RVA = "0xB755BC", Offset = "0xB755BC", VA = "0xB755BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000774")]
		public int totalSteps
		{
			[Token(Token = "0x6003BEA")]
			[Address(RVA = "0xB755C4", Offset = "0xB755C4", VA = "0xB755C4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000775")]
		public double percentCompleted
		{
			[Token(Token = "0x6003BEB")]
			[Address(RVA = "0xB755CC", Offset = "0xB755CC", VA = "0xB755CC", Slot = "7")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6003BEC")]
			[Address(RVA = "0xB755D4", Offset = "0xB755D4", VA = "0xB755D4", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000776")]
		public bool completed
		{
			[Token(Token = "0x6003BED")]
			[Address(RVA = "0xB755DC", Offset = "0xB755DC", VA = "0xB755DC", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000777")]
		public bool hidden
		{
			[Token(Token = "0x6003BEE")]
			[Address(RVA = "0xB755E4", Offset = "0xB755E4", VA = "0xB755E4", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000778")]
		public DateTime lastReportedDate
		{
			[Token(Token = "0x6003BEF")]
			[Address(RVA = "0xB755EC", Offset = "0xB755EC", VA = "0xB755EC", Slot = "11")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000779")]
		public string title
		{
			[Token(Token = "0x6003BF0")]
			[Address(RVA = "0xB755F4", Offset = "0xB755F4", VA = "0xB755F4", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700077A")]
		public Texture2D image
		{
			[Token(Token = "0x6003BF1")]
			[Address(RVA = "0xB755FC", Offset = "0xB755FC", VA = "0xB755FC", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700077B")]
		public string achievedDescription
		{
			[Token(Token = "0x6003BF2")]
			[Address(RVA = "0xB75600", Offset = "0xB75600", VA = "0xB75600", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700077C")]
		public string unachievedDescription
		{
			[Token(Token = "0x6003BF3")]
			[Address(RVA = "0xB75608", Offset = "0xB75608", VA = "0xB75608", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700077D")]
		public int points
		{
			[Token(Token = "0x6003BF4")]
			[Address(RVA = "0xB75610", Offset = "0xB75610", VA = "0xB75610", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6003BE1")]
		[Address(RVA = "0xB7506C", Offset = "0xB7506C", VA = "0xB7506C")]
		internal PlayGamesAchievement()
		{
		}

		[Token(Token = "0x6003BE2")]
		[Address(RVA = "0xB75270", Offset = "0xB75270", VA = "0xB75270")]
		internal PlayGamesAchievement(ReportProgress progressCallback)
		{
		}

		[Token(Token = "0x6003BE3")]
		[Address(RVA = "0xB75350", Offset = "0xB75350", VA = "0xB75350")]
		internal PlayGamesAchievement(Achievement ach)
		{
		}

		[Token(Token = "0x6003BE4")]
		[Address(RVA = "0xB75440", Offset = "0xB75440", VA = "0xB75440", Slot = "4")]
		public void ReportProgress(Action<bool> callback)
		{
		}

		[Token(Token = "0x6003BE5")]
		[Address(RVA = "0xB7546C", Offset = "0xB7546C", VA = "0xB7546C")]
		private Texture2D LoadImage()
		{
			return null;
		}
	}
}
