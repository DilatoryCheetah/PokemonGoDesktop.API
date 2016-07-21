// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: EquippedBadgeSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master {

  /// <summary>Holder for reflection information generated from EquippedBadgeSettings.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class EquippedBadgeSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for EquippedBadgeSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EquippedBadgeSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtFcXVpcHBlZEJhZGdlU2V0dGluZ3MucHJvdG8SGlBPR09Qcm90b3MuU2V0",
            "dGluZ3MuTWFzdGVyInkKFUVxdWlwcGVkQmFkZ2VTZXR0aW5ncxIfChdlcXVp",
            "cF9iYWRnZV9jb29sZG93bl9tcxgBIAEoAxIfChdjYXRjaF9wcm9iYWJpbGl0",
            "eV9ib251cxgCIAMoAhIeChZmbGVlX3Byb2JhYmlsaXR5X2JvbnVzGAMgAygC",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.EquippedBadgeSettings), global::POGOProtos.Settings.Master.EquippedBadgeSettings.Parser, new[]{ "EquipBadgeCooldownMs", "CatchProbabilityBonus", "FleeProbabilityBonus" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class EquippedBadgeSettings : pb::IMessage<EquippedBadgeSettings> {
    private static readonly pb::MessageParser<EquippedBadgeSettings> _parser = new pb::MessageParser<EquippedBadgeSettings>(() => new EquippedBadgeSettings());
    public static pb::MessageParser<EquippedBadgeSettings> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.EquippedBadgeSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public EquippedBadgeSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    public EquippedBadgeSettings(EquippedBadgeSettings other) : this() {
      equipBadgeCooldownMs_ = other.equipBadgeCooldownMs_;
      catchProbabilityBonus_ = other.catchProbabilityBonus_.Clone();
      fleeProbabilityBonus_ = other.fleeProbabilityBonus_.Clone();
    }

    public EquippedBadgeSettings Clone() {
      return new EquippedBadgeSettings(this);
    }

    /// <summary>Field number for the "equip_badge_cooldown_ms" field.</summary>
    public const int EquipBadgeCooldownMsFieldNumber = 1;
    private long equipBadgeCooldownMs_;
    public long EquipBadgeCooldownMs {
      get { return equipBadgeCooldownMs_; }
      set {
        equipBadgeCooldownMs_ = value;
      }
    }

    /// <summary>Field number for the "catch_probability_bonus" field.</summary>
    public const int CatchProbabilityBonusFieldNumber = 2;
    private static readonly pb::FieldCodec<float> _repeated_catchProbabilityBonus_codec
        = pb::FieldCodec.ForFloat(18);
    private readonly pbc::RepeatedField<float> catchProbabilityBonus_ = new pbc::RepeatedField<float>();
    public pbc::RepeatedField<float> CatchProbabilityBonus {
      get { return catchProbabilityBonus_; }
    }

    /// <summary>Field number for the "flee_probability_bonus" field.</summary>
    public const int FleeProbabilityBonusFieldNumber = 3;
    private static readonly pb::FieldCodec<float> _repeated_fleeProbabilityBonus_codec
        = pb::FieldCodec.ForFloat(26);
    private readonly pbc::RepeatedField<float> fleeProbabilityBonus_ = new pbc::RepeatedField<float>();
    public pbc::RepeatedField<float> FleeProbabilityBonus {
      get { return fleeProbabilityBonus_; }
    }

    public override bool Equals(object other) {
      return Equals(other as EquippedBadgeSettings);
    }

    public bool Equals(EquippedBadgeSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EquipBadgeCooldownMs != other.EquipBadgeCooldownMs) return false;
      if(!catchProbabilityBonus_.Equals(other.catchProbabilityBonus_)) return false;
      if(!fleeProbabilityBonus_.Equals(other.fleeProbabilityBonus_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (EquipBadgeCooldownMs != 0L) hash ^= EquipBadgeCooldownMs.GetHashCode();
      hash ^= catchProbabilityBonus_.GetHashCode();
      hash ^= fleeProbabilityBonus_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (EquipBadgeCooldownMs != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(EquipBadgeCooldownMs);
      }
      catchProbabilityBonus_.WriteTo(output, _repeated_catchProbabilityBonus_codec);
      fleeProbabilityBonus_.WriteTo(output, _repeated_fleeProbabilityBonus_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (EquipBadgeCooldownMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(EquipBadgeCooldownMs);
      }
      size += catchProbabilityBonus_.CalculateSize(_repeated_catchProbabilityBonus_codec);
      size += fleeProbabilityBonus_.CalculateSize(_repeated_fleeProbabilityBonus_codec);
      return size;
    }

    public void MergeFrom(EquippedBadgeSettings other) {
      if (other == null) {
        return;
      }
      if (other.EquipBadgeCooldownMs != 0L) {
        EquipBadgeCooldownMs = other.EquipBadgeCooldownMs;
      }
      catchProbabilityBonus_.Add(other.catchProbabilityBonus_);
      fleeProbabilityBonus_.Add(other.fleeProbabilityBonus_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            EquipBadgeCooldownMs = input.ReadInt64();
            break;
          }
          case 18:
          case 21: {
            catchProbabilityBonus_.AddEntriesFrom(input, _repeated_catchProbabilityBonus_codec);
            break;
          }
          case 26:
          case 29: {
            fleeProbabilityBonus_.AddEntriesFrom(input, _repeated_fleeProbabilityBonus_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code