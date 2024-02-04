using Eco.Core.Tests;
using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Gameplay.Systems.Chat;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using System;
using UnityEditor.Experimental.GraphView;

namespace Eco.Mods
{
    public class SkillReset : IChatCommandHandler
    {
        [ChatSubCommand("Skills", "Respec a given user", ChatAuthorizationLevel.Admin)]
        public static void RespecUser(User user, User targetUser)
        {
            foreach (Skill s in targetUser.Skillset.Skills)
            {
                // Skills/Skilltrees can be containers for other skills, (i.e. professions) so only set the ones that are not
                // Abandoning a spec does not un-discover it
                if (!s.IsRoot)
                {
                    if (s.Name.Equals("SelfImprovementSkill"))
                        s.Level = 1;
                    else
                        s.AbandonSpecialty(targetUser.Player);
                }
            }

            targetUser.Player.Client.RPCAsync<bool>("PopupConfirmBox", targetUser.Player.Client, Localizer.Format("Your skills have been respecced. Please disconnect and reconnect immediately."));
        }

        [ChatSubCommand("Skills", "Abandon a given skill for yourself.", ChatAuthorizationLevel.User)]
        public static void AbandonSkill(User user, string skillName, User targetUser = user)
        {

            Skill foundSkill = null;
            foreach (Skill s in toSet.Skillset.Skills)
            {
                if (!s.IsRoot && s.Name.ToLower().Contains(skillName.ToLower()))
                {
                    foundSkill = s;
                    break;
                }
            }
            if (foundSkill == null || foundSkill.Name.Equals("SelfImprovementSkill") || foundSkill.Level > 1)
            {
                user.Player.Error(Localizer.Format("Skill {0} not found / Skill is over level 1", skillName));
                return;
            }
            foundSkill.AbandonSpecialty(toSet.Player);
            toSet.Player.Client.RPCAsync<bool>("PopupConfirmBox", toSet.Player.Client, Localizer.Format("Your {0} skill has been abandonned. Please disconnect and reconnect immediately to resync your skills", foundSkill.Name));
            user.Player.Msg(Localizer.Format("Abandoned skill {0}.", foundSkill.Name));
        }
    }

}