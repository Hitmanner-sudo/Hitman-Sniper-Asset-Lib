using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BF9")]
	[Attribute(Name = "ResourcePathAttribute", RVA = "0x59852C", Offset = "0x59852C")]
	public class DistributionConfiguration : ScriptableObject
	{
		[Token(Token = "0x4003BE3")]
		[FieldOffset(Offset = "0x0")]
		public static string None;

		[Token(Token = "0x4003BE4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _remoteBundleIdentifier;

		[Token(Token = "0x4003BE5")]
		[FieldOffset(Offset = "0x20")]
		public string[] PrefabBundlesPath;

		[Token(Token = "0x4003BE6")]
		[FieldOffset(Offset = "0x28")]
		public string AdditiveScenesPath;

		[Token(Token = "0x4003BE7")]
		[FieldOffset(Offset = "0x30")]
		public List<SceneGroup> SceneGroups;

		[Token(Token = "0x4003BE8")]
		[FieldOffset(Offset = "0x38")]
		public List<string> StaticScenes;

		[Token(Token = "0x4003BE9")]
		[FieldOffset(Offset = "0x40")]
		public int MaxBackupNumber;

		[Token(Token = "0x170009AD")]
		public string RemoteBundleIdentifier
		{
			[Token(Token = "0x6004BD8")]
			[Address(RVA = "0xC1843C", Offset = "0xC1843C", VA = "0xC1843C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009AE")]
		public string[] SceneGroupsNameArray
		{
			[Token(Token = "0x6004BD9")]
			[Address(RVA = "0xC18444", Offset = "0xC18444", VA = "0xC18444")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009AF")]
		public static int MaxBackupNumberStatic
		{
			[Token(Token = "0x6004BDA")]
			[Address(RVA = "0xC18490", Offset = "0xC18490", VA = "0xC18490")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004BDB")]
		[Address(RVA = "0xC1852C", Offset = "0xC1852C", VA = "0xC1852C")]
		public int IndexOfSceneGroup(string sceneGroup)
		{
			return default(int);
		}

		[Token(Token = "0x6004BDC")]
		[Address(RVA = "0xC18588", Offset = "0xC18588", VA = "0xC18588")]
		public bool SceneGroupsContains(string sceneGroup)
		{
			return default(bool);
		}

		[Token(Token = "0x6004BDD")]
		[Address(RVA = "0xC185E4", Offset = "0xC185E4", VA = "0xC185E4")]
		public DistributionConfiguration()
		{
		}
	}
}
