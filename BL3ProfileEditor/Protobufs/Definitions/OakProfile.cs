// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: OakProfile.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace OakSave
{

    [global::ProtoBuf.ProtoContract(Name = @"PlayerInputBinding_Button")]
    public partial class PlayerInputBindingButton : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"rebind_data_path")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RebindDataPath
        {
            get { return __pbn__RebindDataPath ?? ""; }
            set { __pbn__RebindDataPath = value; }
        }
        public bool ShouldSerializeRebindDataPath() => __pbn__RebindDataPath != null;
        public void ResetRebindDataPath() => __pbn__RebindDataPath = null;
        private string __pbn__RebindDataPath;

        [global::ProtoBuf.ProtoMember(2, Name = @"key_names")]
        public global::System.Collections.Generic.List<string> KeyNames { get; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"PlayerInputBinding_Axis_Key")]
    public partial class PlayerInputBindingAxisKey : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"key_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string KeyName
        {
            get { return __pbn__KeyName ?? ""; }
            set { __pbn__KeyName = value; }
        }
        public bool ShouldSerializeKeyName() => __pbn__KeyName != null;
        public void ResetKeyName() => __pbn__KeyName = null;
        private string __pbn__KeyName;

        [global::ProtoBuf.ProtoMember(2, Name = @"scale_3d")]
        public Vec3 Scale3d { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"PlayerInputBinding_Axis")]
    public partial class PlayerInputBindingAxis : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"rebind_data_path")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RebindDataPath
        {
            get { return __pbn__RebindDataPath ?? ""; }
            set { __pbn__RebindDataPath = value; }
        }
        public bool ShouldSerializeRebindDataPath() => __pbn__RebindDataPath != null;
        public void ResetRebindDataPath() => __pbn__RebindDataPath = null;
        private string __pbn__RebindDataPath;

        [global::ProtoBuf.ProtoMember(2, Name = @"keys")]
        public global::System.Collections.Generic.List<PlayerInputBindingAxisKey> Keys { get; } = new global::System.Collections.Generic.List<PlayerInputBindingAxisKey>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"PlayerInputBinding_Category")]
    public partial class PlayerInputBindingCategory : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"category_data_path")]
        [global::System.ComponentModel.DefaultValue("")]
        public string CategoryDataPath
        {
            get { return __pbn__CategoryDataPath ?? ""; }
            set { __pbn__CategoryDataPath = value; }
        }
        public bool ShouldSerializeCategoryDataPath() => __pbn__CategoryDataPath != null;
        public void ResetCategoryDataPath() => __pbn__CategoryDataPath = null;
        private string __pbn__CategoryDataPath;

        [global::ProtoBuf.ProtoMember(2, Name = @"context_data_path")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ContextDataPath
        {
            get { return __pbn__ContextDataPath ?? ""; }
            set { __pbn__ContextDataPath = value; }
        }
        public bool ShouldSerializeContextDataPath() => __pbn__ContextDataPath != null;
        public void ResetContextDataPath() => __pbn__ContextDataPath = null;
        private string __pbn__ContextDataPath;

        [global::ProtoBuf.ProtoMember(3, Name = @"button_bindings")]
        public global::System.Collections.Generic.List<PlayerInputBindingButton> ButtonBindings { get; } = new global::System.Collections.Generic.List<PlayerInputBindingButton>();

        [global::ProtoBuf.ProtoMember(4, Name = @"axis_bindings")]
        public global::System.Collections.Generic.List<PlayerInputBindingAxis> AxisBindings { get; } = new global::System.Collections.Generic.List<PlayerInputBindingAxis>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PlayerInputBindings : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"categories")]
        public global::System.Collections.Generic.List<PlayerInputBindingCategory> Categories { get; } = new global::System.Collections.Generic.List<PlayerInputBindingCategory>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class OakProfileLastInventoryFilterInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"slot_type_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SlotTypeId
        {
            get { return __pbn__SlotTypeId ?? ""; }
            set { __pbn__SlotTypeId = value; }
        }
        public bool ShouldSerializeSlotTypeId() => __pbn__SlotTypeId != null;
        public void ResetSlotTypeId() => __pbn__SlotTypeId = null;
        private string __pbn__SlotTypeId;

        [global::ProtoBuf.ProtoMember(2, Name = @"last_filter_index")]
        public int LastFilterIndex
        {
            get { return __pbn__LastFilterIndex.GetValueOrDefault(); }
            set { __pbn__LastFilterIndex = value; }
        }
        public bool ShouldSerializeLastFilterIndex() => __pbn__LastFilterIndex != null;
        public void ResetLastFilterIndex() => __pbn__LastFilterIndex = null;
        private int? __pbn__LastFilterIndex;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class OakProfileMenuTutorialInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"seen_tutorials")]
        public global::System.Collections.Generic.List<string> SeenTutorials { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(2, Name = @"tutorials_disabled")]
        public bool TutorialsDisabled
        {
            get { return __pbn__TutorialsDisabled.GetValueOrDefault(); }
            set { __pbn__TutorialsDisabled = value; }
        }
        public bool ShouldSerializeTutorialsDisabled() => __pbn__TutorialsDisabled != null;
        public void ResetTutorialsDisabled() => __pbn__TutorialsDisabled = null;
        private bool? __pbn__TutorialsDisabled;

        [global::ProtoBuf.ProtoMember(3, Name = @"tutorials_allowed_in_non_game_modes")]
        public bool TutorialsAllowedInNonGameModes
        {
            get { return __pbn__TutorialsAllowedInNonGameModes.GetValueOrDefault(); }
            set { __pbn__TutorialsAllowedInNonGameModes = value; }
        }
        public bool ShouldSerializeTutorialsAllowedInNonGameModes() => __pbn__TutorialsAllowedInNonGameModes != null;
        public void ResetTutorialsAllowedInNonGameModes() => __pbn__TutorialsAllowedInNonGameModes = null;
        private bool? __pbn__TutorialsAllowedInNonGameModes;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class OakFriendEncounterData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"num_encounters")]
        public uint NumEncounters
        {
            get { return __pbn__NumEncounters.GetValueOrDefault(); }
            set { __pbn__NumEncounters = value; }
        }
        public bool ShouldSerializeNumEncounters() => __pbn__NumEncounters != null;
        public void ResetNumEncounters() => __pbn__NumEncounters = null;
        private uint? __pbn__NumEncounters;

        [global::ProtoBuf.ProtoMember(2, Name = @"time_last_encounter")]
        public long TimeLastEncounter
        {
            get { return __pbn__TimeLastEncounter.GetValueOrDefault(); }
            set { __pbn__TimeLastEncounter = value; }
        }
        public bool ShouldSerializeTimeLastEncounter() => __pbn__TimeLastEncounter != null;
        public void ResetTimeLastEncounter() => __pbn__TimeLastEncounter = null;
        private long? __pbn__TimeLastEncounter;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class OakMailItem : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"mail_item_type")]
        public uint MailItemType
        {
            get { return __pbn__MailItemType.GetValueOrDefault(); }
            set { __pbn__MailItemType = value; }
        }
        public bool ShouldSerializeMailItemType() => __pbn__MailItemType != null;
        public void ResetMailItemType() => __pbn__MailItemType = null;
        private uint? __pbn__MailItemType;

        [global::ProtoBuf.ProtoMember(2, Name = @"sender_display_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SenderDisplayName
        {
            get { return __pbn__SenderDisplayName ?? ""; }
            set { __pbn__SenderDisplayName = value; }
        }
        public bool ShouldSerializeSenderDisplayName() => __pbn__SenderDisplayName != null;
        public void ResetSenderDisplayName() => __pbn__SenderDisplayName = null;
        private string __pbn__SenderDisplayName;

        [global::ProtoBuf.ProtoMember(3, Name = @"subject")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Subject
        {
            get { return __pbn__Subject ?? ""; }
            set { __pbn__Subject = value; }
        }
        public bool ShouldSerializeSubject() => __pbn__Subject != null;
        public void ResetSubject() => __pbn__Subject = null;
        private string __pbn__Subject;

        [global::ProtoBuf.ProtoMember(4, Name = @"body")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Body
        {
            get { return __pbn__Body ?? ""; }
            set { __pbn__Body = value; }
        }
        public bool ShouldSerializeBody() => __pbn__Body != null;
        public void ResetBody() => __pbn__Body = null;
        private string __pbn__Body;

        [global::ProtoBuf.ProtoMember(5, Name = @"gear_serial_number")]
        [global::System.ComponentModel.DefaultValue("")]
        public string GearSerialNumber
        {
            get { return __pbn__GearSerialNumber ?? ""; }
            set { __pbn__GearSerialNumber = value; }
        }
        public bool ShouldSerializeGearSerialNumber() => __pbn__GearSerialNumber != null;
        public void ResetGearSerialNumber() => __pbn__GearSerialNumber = null;
        private string __pbn__GearSerialNumber;

        [global::ProtoBuf.ProtoMember(6, Name = @"mail_guid")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MailGuid
        {
            get { return __pbn__MailGuid ?? ""; }
            set { __pbn__MailGuid = value; }
        }
        public bool ShouldSerializeMailGuid() => __pbn__MailGuid != null;
        public void ResetMailGuid() => __pbn__MailGuid = null;
        private string __pbn__MailGuid;

        [global::ProtoBuf.ProtoMember(7, Name = @"date_sent")]
        public long DateSent
        {
            get { return __pbn__DateSent.GetValueOrDefault(); }
            set { __pbn__DateSent = value; }
        }
        public bool ShouldSerializeDateSent() => __pbn__DateSent != null;
        public void ResetDateSent() => __pbn__DateSent = null;
        private long? __pbn__DateSent;

        [global::ProtoBuf.ProtoMember(8, Name = @"expiration_date")]
        public long ExpirationDate
        {
            get { return __pbn__ExpirationDate.GetValueOrDefault(); }
            set { __pbn__ExpirationDate = value; }
        }
        public bool ShouldSerializeExpirationDate() => __pbn__ExpirationDate != null;
        public void ResetExpirationDate() => __pbn__ExpirationDate = null;
        private long? __pbn__ExpirationDate;

        [global::ProtoBuf.ProtoMember(9, Name = @"from_player_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string FromPlayerId
        {
            get { return __pbn__FromPlayerId ?? ""; }
            set { __pbn__FromPlayerId = value; }
        }
        public bool ShouldSerializeFromPlayerId() => __pbn__FromPlayerId != null;
        public void ResetFromPlayerId() => __pbn__FromPlayerId = null;
        private string __pbn__FromPlayerId;

        [global::ProtoBuf.ProtoMember(10, Name = @"has_been_read")]
        public bool HasBeenRead
        {
            get { return __pbn__HasBeenRead.GetValueOrDefault(); }
            set { __pbn__HasBeenRead = value; }
        }
        public bool ShouldSerializeHasBeenRead() => __pbn__HasBeenRead != null;
        public void ResetHasBeenRead() => __pbn__HasBeenRead = null;
        private bool? __pbn__HasBeenRead;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GearSoldByFriendData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"gear_serial_number")]
        [global::System.ComponentModel.DefaultValue("")]
        public string GearSerialNumber
        {
            get { return __pbn__GearSerialNumber ?? ""; }
            set { __pbn__GearSerialNumber = value; }
        }
        public bool ShouldSerializeGearSerialNumber() => __pbn__GearSerialNumber != null;
        public void ResetGearSerialNumber() => __pbn__GearSerialNumber = null;
        private string __pbn__GearSerialNumber;

        [global::ProtoBuf.ProtoMember(2, Name = @"player_class_identifier_hash")]
        public int PlayerClassIdentifierHash
        {
            get { return __pbn__PlayerClassIdentifierHash.GetValueOrDefault(); }
            set { __pbn__PlayerClassIdentifierHash = value; }
        }
        public bool ShouldSerializePlayerClassIdentifierHash() => __pbn__PlayerClassIdentifierHash != null;
        public void ResetPlayerClassIdentifierHash() => __pbn__PlayerClassIdentifierHash = null;
        private int? __pbn__PlayerClassIdentifierHash;

        [global::ProtoBuf.ProtoMember(3, Name = @"friend_net_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string FriendNetId
        {
            get { return __pbn__FriendNetId ?? ""; }
            set { __pbn__FriendNetId = value; }
        }
        public bool ShouldSerializeFriendNetId() => __pbn__FriendNetId != null;
        public void ResetFriendNetId() => __pbn__FriendNetId = null;
        private string __pbn__FriendNetId;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class OakCustomizationSaveGameData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"is_new")]
        public bool IsNew
        {
            get { return __pbn__IsNew.GetValueOrDefault(); }
            set { __pbn__IsNew = value; }
        }
        public bool ShouldSerializeIsNew() => __pbn__IsNew != null;
        public void ResetIsNew() => __pbn__IsNew = null;
        private bool? __pbn__IsNew;

        [global::ProtoBuf.ProtoMember(2, Name = @"customization_asset_path")]
        [global::System.ComponentModel.DefaultValue("")]
        public string CustomizationAssetPath
        {
            get { return __pbn__CustomizationAssetPath ?? ""; }
            set { __pbn__CustomizationAssetPath = value; }
        }
        public bool ShouldSerializeCustomizationAssetPath() => __pbn__CustomizationAssetPath != null;
        public void ResetCustomizationAssetPath() => __pbn__CustomizationAssetPath = null;
        private string __pbn__CustomizationAssetPath;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class OakInventoryCustomizationPartInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"customization_part_hash")]
        public uint CustomizationPartHash
        {
            get { return __pbn__CustomizationPartHash.GetValueOrDefault(); }
            set { __pbn__CustomizationPartHash = value; }
        }
        public bool ShouldSerializeCustomizationPartHash() => __pbn__CustomizationPartHash != null;
        public void ResetCustomizationPartHash() => __pbn__CustomizationPartHash = null;
        private uint? __pbn__CustomizationPartHash;

        [global::ProtoBuf.ProtoMember(2, Name = @"is_new")]
        public bool IsNew
        {
            get { return __pbn__IsNew.GetValueOrDefault(); }
            set { __pbn__IsNew = value; }
        }
        public bool ShouldSerializeIsNew() => __pbn__IsNew != null;
        public void ResetIsNew() => __pbn__IsNew = null;
        private bool? __pbn__IsNew;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GuardianRankRewardSaveGameData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"num_tokens")]
        public int NumTokens
        {
            get { return __pbn__NumTokens.GetValueOrDefault(); }
            set { __pbn__NumTokens = value; }
        }
        public bool ShouldSerializeNumTokens() => __pbn__NumTokens != null;
        public void ResetNumTokens() => __pbn__NumTokens = null;
        private int? __pbn__NumTokens;

        [global::ProtoBuf.ProtoMember(2, Name = @"reward_data_path")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RewardDataPath
        {
            get { return __pbn__RewardDataPath ?? ""; }
            set { __pbn__RewardDataPath = value; }
        }
        public bool ShouldSerializeRewardDataPath() => __pbn__RewardDataPath != null;
        public void ResetRewardDataPath() => __pbn__RewardDataPath = null;
        private string __pbn__RewardDataPath;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GuardianRankProfileData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"available_tokens")]
        public int AvailableTokens
        {
            get { return __pbn__AvailableTokens.GetValueOrDefault(); }
            set { __pbn__AvailableTokens = value; }
        }
        public bool ShouldSerializeAvailableTokens() => __pbn__AvailableTokens != null;
        public void ResetAvailableTokens() => __pbn__AvailableTokens = null;
        private int? __pbn__AvailableTokens;

        [global::ProtoBuf.ProtoMember(2, Name = @"rank_rewards")]
        public global::System.Collections.Generic.List<GuardianRankRewardSaveGameData> RankRewards { get; } = new global::System.Collections.Generic.List<GuardianRankRewardSaveGameData>();

        [global::ProtoBuf.ProtoMember(3, Name = @"guardian_rank")]
        public int GuardianRank
        {
            get { return __pbn__GuardianRank.GetValueOrDefault(); }
            set { __pbn__GuardianRank = value; }
        }
        public bool ShouldSerializeGuardianRank() => __pbn__GuardianRank != null;
        public void ResetGuardianRank() => __pbn__GuardianRank = null;
        private int? __pbn__GuardianRank;

        [global::ProtoBuf.ProtoMember(4, Name = @"guardian_experience")]
        public int GuardianExperience
        {
            get { return __pbn__GuardianExperience.GetValueOrDefault(); }
            set { __pbn__GuardianExperience = value; }
        }
        public bool ShouldSerializeGuardianExperience() => __pbn__GuardianExperience != null;
        public void ResetGuardianExperience() => __pbn__GuardianExperience = null;
        private int? __pbn__GuardianExperience;

        [global::ProtoBuf.ProtoMember(5, Name = @"guardian_reward_random_seed")]
        public int GuardianRewardRandomSeed
        {
            get { return __pbn__GuardianRewardRandomSeed.GetValueOrDefault(); }
            set { __pbn__GuardianRewardRandomSeed = value; }
        }
        public bool ShouldSerializeGuardianRewardRandomSeed() => __pbn__GuardianRewardRandomSeed != null;
        public void ResetGuardianRewardRandomSeed() => __pbn__GuardianRewardRandomSeed = null;
        private int? __pbn__GuardianRewardRandomSeed;

        [global::ProtoBuf.ProtoMember(6, Name = @"new_guardian_experience")]
        public long NewGuardianExperience
        {
            get { return __pbn__NewGuardianExperience.GetValueOrDefault(); }
            set { __pbn__NewGuardianExperience = value; }
        }
        public bool ShouldSerializeNewGuardianExperience() => __pbn__NewGuardianExperience != null;
        public void ResetNewGuardianExperience() => __pbn__NewGuardianExperience = null;
        private long? __pbn__NewGuardianExperience;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CrewQuartersDecorationItemSaveGameData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"is_new")]
        public bool IsNew
        {
            get { return __pbn__IsNew.GetValueOrDefault(); }
            set { __pbn__IsNew = value; }
        }
        public bool ShouldSerializeIsNew() => __pbn__IsNew != null;
        public void ResetIsNew() => __pbn__IsNew = null;
        private bool? __pbn__IsNew;

        [global::ProtoBuf.ProtoMember(2, Name = @"decoration_item_asset_path")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DecorationItemAssetPath
        {
            get { return __pbn__DecorationItemAssetPath ?? ""; }
            set { __pbn__DecorationItemAssetPath = value; }
        }
        public bool ShouldSerializeDecorationItemAssetPath() => __pbn__DecorationItemAssetPath != null;
        public void ResetDecorationItemAssetPath() => __pbn__DecorationItemAssetPath = null;
        private string __pbn__DecorationItemAssetPath;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CrewQuartersRoomItemSaveGameData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"is_new")]
        public bool IsNew
        {
            get { return __pbn__IsNew.GetValueOrDefault(); }
            set { __pbn__IsNew = value; }
        }
        public bool ShouldSerializeIsNew() => __pbn__IsNew != null;
        public void ResetIsNew() => __pbn__IsNew = null;
        private bool? __pbn__IsNew;

        [global::ProtoBuf.ProtoMember(2, Name = @"room_item_asset_path")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RoomItemAssetPath
        {
            get { return __pbn__RoomItemAssetPath ?? ""; }
            set { __pbn__RoomItemAssetPath = value; }
        }
        public bool ShouldSerializeRoomItemAssetPath() => __pbn__RoomItemAssetPath != null;
        public void ResetRoomItemAssetPath() => __pbn__RoomItemAssetPath = null;
        private string __pbn__RoomItemAssetPath;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RecentlyMetPlayer : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"shift_player_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ShiftPlayerId
        {
            get { return __pbn__ShiftPlayerId ?? ""; }
            set { __pbn__ShiftPlayerId = value; }
        }
        public bool ShouldSerializeShiftPlayerId() => __pbn__ShiftPlayerId != null;
        public void ResetShiftPlayerId() => __pbn__ShiftPlayerId = null;
        private string __pbn__ShiftPlayerId;

        [global::ProtoBuf.ProtoMember(2, Name = @"first_party_player_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string FirstPartyPlayerId
        {
            get { return __pbn__FirstPartyPlayerId ?? ""; }
            set { __pbn__FirstPartyPlayerId = value; }
        }
        public bool ShouldSerializeFirstPartyPlayerId() => __pbn__FirstPartyPlayerId != null;
        public void ResetFirstPartyPlayerId() => __pbn__FirstPartyPlayerId = null;
        private string __pbn__FirstPartyPlayerId;

        [global::ProtoBuf.ProtoMember(3, Name = @"show_shift_player_entry")]
        public bool ShowShiftPlayerEntry
        {
            get { return __pbn__ShowShiftPlayerEntry.GetValueOrDefault(); }
            set { __pbn__ShowShiftPlayerEntry = value; }
        }
        public bool ShouldSerializeShowShiftPlayerEntry() => __pbn__ShowShiftPlayerEntry != null;
        public void ResetShowShiftPlayerEntry() => __pbn__ShowShiftPlayerEntry = null;
        private bool? __pbn__ShowShiftPlayerEntry;

    }

}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006
