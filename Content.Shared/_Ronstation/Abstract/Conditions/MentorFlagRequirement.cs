using Robust.Shared.Network;
using Robust.Shared.Player;
using Content.Shared.Administration;
using Content.Shared.Administration.Managers;

namespace Content.Shared._Starlight.Abstract.Conditions;

public sealed partial class MentorFlagRequirement : BaseRequirement
{
    [Dependency] private ISharedAdminManager _admin = default!;
    [DataField(required: true)]
    public NetUserId UserId;

    public override string GetRequirementDescription() => ("You must be a Mentor to use this theme.");
    public override bool Handle(ICommonSession user)
    {
        base.Handle(user);
        var flags = _admin.GetAdminData(user,true);
        var isMentor = flags != null && flags.HasFlag(AdminFlags.RNSLMentor);

        return isMentor;
    }
}
