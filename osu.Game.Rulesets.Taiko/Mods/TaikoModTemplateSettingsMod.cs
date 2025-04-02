using System;
using System.Linq;
using osu.Framework.Localisation;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Taiko.Beatmaps;
using osu.Game.Rulesets.Taiko.Objects;

namespace osu.Game.Rulesets.Taiko.Mods

{

    public class TaikoModTemplateSettings : ModTemplateSettings, IApplicableToBeatmap
    {
        public void ApplyToBeatmap(IBeatmap beatmap)
        {
            var taikoBeatmap = (TaikoBeatmap)beatmap;

        }
    }
}
