// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Settings/Master/TypeEffectiveSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Settings/Master/TypeEffectiveSettings.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class TypeEffectiveSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for Settings/Master/TypeEffectiveSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TypeEffectiveSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitTZXR0aW5ncy9NYXN0ZXIvVHlwZUVmZmVjdGl2ZVNldHRpbmdzLnByb3Rv",
            "Eg9TZXR0aW5ncy5NYXN0ZXIaF0VudW1zL1Bva2Vtb25UeXBlLnByb3RvIlcK",
            "FVR5cGVFZmZlY3RpdmVTZXR0aW5ncxIVCg1hdHRhY2tfc2NhbGFyGAEgAygC",
            "EicKC2F0dGFja190eXBlGAIgASgOMhIuRW51bXMuUG9rZW1vblR5cGVCHaoC",
            "GlBva2Vtb25Hb0Rlc2t0b3AuQVBJLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.PokemonTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.TypeEffectiveSettings), global::PokemonGoDesktop.API.Proto.TypeEffectiveSettings.Parser, new[]{ "AttackScalar", "AttackType" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class TypeEffectiveSettings : pb::IMessage<TypeEffectiveSettings> {
    private static readonly pb::MessageParser<TypeEffectiveSettings> _parser = new pb::MessageParser<TypeEffectiveSettings>(() => new TypeEffectiveSettings());
    public static pb::MessageParser<TypeEffectiveSettings> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.TypeEffectiveSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public TypeEffectiveSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    public TypeEffectiveSettings(TypeEffectiveSettings other) : this() {
      attackScalar_ = other.attackScalar_.Clone();
      attackType_ = other.attackType_;
    }

    public TypeEffectiveSettings Clone() {
      return new TypeEffectiveSettings(this);
    }

    /// <summary>Field number for the "attack_scalar" field.</summary>
    public const int AttackScalarFieldNumber = 1;
    private static readonly pb::FieldCodec<float> _repeated_attackScalar_codec
        = pb::FieldCodec.ForFloat(10);
    private readonly pbc::RepeatedField<float> attackScalar_ = new pbc::RepeatedField<float>();
    public pbc::RepeatedField<float> AttackScalar {
      get { return attackScalar_; }
    }

    /// <summary>Field number for the "attack_type" field.</summary>
    public const int AttackTypeFieldNumber = 2;
    private global::PokemonGoDesktop.API.Proto.PokemonType attackType_ = 0;
    public global::PokemonGoDesktop.API.Proto.PokemonType AttackType {
      get { return attackType_; }
      set {
        attackType_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as TypeEffectiveSettings);
    }

    public bool Equals(TypeEffectiveSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!attackScalar_.Equals(other.attackScalar_)) return false;
      if (AttackType != other.AttackType) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= attackScalar_.GetHashCode();
      if (AttackType != 0) hash ^= AttackType.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      attackScalar_.WriteTo(output, _repeated_attackScalar_codec);
      if (AttackType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) AttackType);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += attackScalar_.CalculateSize(_repeated_attackScalar_codec);
      if (AttackType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AttackType);
      }
      return size;
    }

    public void MergeFrom(TypeEffectiveSettings other) {
      if (other == null) {
        return;
      }
      attackScalar_.Add(other.attackScalar_);
      if (other.AttackType != 0) {
        AttackType = other.AttackType;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10:
          case 13: {
            attackScalar_.AddEntriesFrom(input, _repeated_attackScalar_codec);
            break;
          }
          case 16: {
            attackType_ = (global::PokemonGoDesktop.API.Proto.PokemonType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
