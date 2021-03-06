// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Data/PokedexEntry.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Data/PokedexEntry.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PokedexEntryReflection {

    #region Descriptor
    /// <summary>File descriptor for Data/PokedexEntry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokedexEntryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdEYXRhL1Bva2VkZXhFbnRyeS5wcm90bxIERGF0YRoVRW51bXMvUG9rZW1v",
            "bklkLnByb3RvIqEBCgxQb2tlZGV4RW50cnkSJAoKcG9rZW1vbl9pZBgBIAEo",
            "DjIQLkVudW1zLlBva2Vtb25JZBIZChF0aW1lc19lbmNvdW50ZXJlZBgCIAEo",
            "BRIWCg50aW1lc19jYXB0dXJlZBgDIAEoBRIeChZldm9sdXRpb25fc3RvbmVf",
            "cGllY2VzGAQgASgFEhgKEGV2b2x1dGlvbl9zdG9uZXMYBSABKAVCHaoCGlBv",
            "a2Vtb25Hb0Rlc2t0b3AuQVBJLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.PokemonIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.PokedexEntry), global::PokemonGoDesktop.API.Proto.PokedexEntry.Parser, new[]{ "PokemonId", "TimesEncountered", "TimesCaptured", "EvolutionStonePieces", "EvolutionStones" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class PokedexEntry : pb::IMessage<PokedexEntry> {
    private static readonly pb::MessageParser<PokedexEntry> _parser = new pb::MessageParser<PokedexEntry>(() => new PokedexEntry());
    public static pb::MessageParser<PokedexEntry> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.PokedexEntryReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public PokedexEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    public PokedexEntry(PokedexEntry other) : this() {
      pokemonId_ = other.pokemonId_;
      timesEncountered_ = other.timesEncountered_;
      timesCaptured_ = other.timesCaptured_;
      evolutionStonePieces_ = other.evolutionStonePieces_;
      evolutionStones_ = other.evolutionStones_;
    }

    public PokedexEntry Clone() {
      return new PokedexEntry(this);
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 1;
    private global::PokemonGoDesktop.API.Proto.PokemonId pokemonId_ = 0;
    public global::PokemonGoDesktop.API.Proto.PokemonId PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    /// <summary>Field number for the "times_encountered" field.</summary>
    public const int TimesEncounteredFieldNumber = 2;
    private int timesEncountered_;
    public int TimesEncountered {
      get { return timesEncountered_; }
      set {
        timesEncountered_ = value;
      }
    }

    /// <summary>Field number for the "times_captured" field.</summary>
    public const int TimesCapturedFieldNumber = 3;
    private int timesCaptured_;
    public int TimesCaptured {
      get { return timesCaptured_; }
      set {
        timesCaptured_ = value;
      }
    }

    /// <summary>Field number for the "evolution_stone_pieces" field.</summary>
    public const int EvolutionStonePiecesFieldNumber = 4;
    private int evolutionStonePieces_;
    public int EvolutionStonePieces {
      get { return evolutionStonePieces_; }
      set {
        evolutionStonePieces_ = value;
      }
    }

    /// <summary>Field number for the "evolution_stones" field.</summary>
    public const int EvolutionStonesFieldNumber = 5;
    private int evolutionStones_;
    public int EvolutionStones {
      get { return evolutionStones_; }
      set {
        evolutionStones_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as PokedexEntry);
    }

    public bool Equals(PokedexEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PokemonId != other.PokemonId) return false;
      if (TimesEncountered != other.TimesEncountered) return false;
      if (TimesCaptured != other.TimesCaptured) return false;
      if (EvolutionStonePieces != other.EvolutionStonePieces) return false;
      if (EvolutionStones != other.EvolutionStones) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
      if (TimesEncountered != 0) hash ^= TimesEncountered.GetHashCode();
      if (TimesCaptured != 0) hash ^= TimesCaptured.GetHashCode();
      if (EvolutionStonePieces != 0) hash ^= EvolutionStonePieces.GetHashCode();
      if (EvolutionStones != 0) hash ^= EvolutionStones.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (PokemonId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) PokemonId);
      }
      if (TimesEncountered != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TimesEncountered);
      }
      if (TimesCaptured != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TimesCaptured);
      }
      if (EvolutionStonePieces != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(EvolutionStonePieces);
      }
      if (EvolutionStones != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(EvolutionStones);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (PokemonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PokemonId);
      }
      if (TimesEncountered != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimesEncountered);
      }
      if (TimesCaptured != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimesCaptured);
      }
      if (EvolutionStonePieces != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EvolutionStonePieces);
      }
      if (EvolutionStones != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EvolutionStones);
      }
      return size;
    }

    public void MergeFrom(PokedexEntry other) {
      if (other == null) {
        return;
      }
      if (other.PokemonId != 0) {
        PokemonId = other.PokemonId;
      }
      if (other.TimesEncountered != 0) {
        TimesEncountered = other.TimesEncountered;
      }
      if (other.TimesCaptured != 0) {
        TimesCaptured = other.TimesCaptured;
      }
      if (other.EvolutionStonePieces != 0) {
        EvolutionStonePieces = other.EvolutionStonePieces;
      }
      if (other.EvolutionStones != 0) {
        EvolutionStones = other.EvolutionStones;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            pokemonId_ = (global::PokemonGoDesktop.API.Proto.PokemonId) input.ReadEnum();
            break;
          }
          case 16: {
            TimesEncountered = input.ReadInt32();
            break;
          }
          case 24: {
            TimesCaptured = input.ReadInt32();
            break;
          }
          case 32: {
            EvolutionStonePieces = input.ReadInt32();
            break;
          }
          case 40: {
            EvolutionStones = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
