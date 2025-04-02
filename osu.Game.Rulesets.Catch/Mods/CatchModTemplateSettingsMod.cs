using System.Linq;
using osu.Framework.Localisation;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Catch.Beatmaps;
using osu.Game.Rulesets.Catch.Objects;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Catch.UI;
using osu.Game.Rulesets.Objects;
using osuTK;

namespace osu.Game.Rulesets.Catch.Mods
{

    public class CatchModTemplateSettings : ModTemplateSettings, IApplicableToBeatmap
    {

        public void ApplyToBeatmap(IBeatmap beatmap)
        {
            var catchBeatmap = (CatchBeatmap)beatmap;
        }
    }
}
