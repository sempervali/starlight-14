using Content.Shared.Preferences;
using JetBrains.Annotations;
using Robust.Shared.Player;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;
using Robust.Shared.Utility;
using Content.Shared.Roles;
using Content.Shared.Administration;
using Content.Shared.Administration.Managers;

namespace Content.Shared._Ronstation.Roles;

[UsedImplicitly]
[Serializable, NetSerializable]
public sealed partial class MentorFlagRequirement : JobRequirement
{
    [Dependency] private ISharedAdminManager _admin = null!;
    [DataField(required: true)] public ProtoId<flagMentorRequirementPrototype> Proto;

    public override bool Check(IEntityManager entManager,
                               ICommonSession? player,
                               IPrototypeManager protoManager,
                               HumanoidCharacterProfile? profile,
                               IReadOnlyDictionary<string, TimeSpan>? playTimes,
                               out FormattedMessage reason)
    {
        if (player != null)
        {
            var flags = _admin.GetAdminData(player,true);
            var success = flags != null && flags.HasFlag(AdminFlags.RNSLMentor);

            /*reason = FormattedMessage.FromMarkupPermissive(Loc.GetString(
                success ? "roles-req-any-role-required-pass" : "roles-req-any-role-required-fail",
                ("discord", "test"),
                ("roles", "test 2")));*/
            reason = new FormattedMessage();
            return success;
        }
        else
        {
            reason = new FormattedMessage();
            return false;
        }
    }
}
