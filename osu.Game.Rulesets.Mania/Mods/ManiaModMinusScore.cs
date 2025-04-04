// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Rulesets.Mania.Objects;
using osu.Game.Rulesets.Mods;
using System.Linq;
using osu.Framework.Localisation;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Mania.Beatmaps;

namespace osu.Game.Rulesets.Mania.Mods
{
    public class ManiaModMinusScore : ModMinusScore, IApplicableToBeatmap
    {
            public void ApplyToBeatmap(IBeatmap beatmap)
        {
            int availableColumns = ((ManiaBeatmap)beatmap).TotalColumns;
        }
    }
}
