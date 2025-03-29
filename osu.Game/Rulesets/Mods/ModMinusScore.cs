// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;


namespace osu.Game.Rulesets.Mods

{
    public abstract class ModMinusScore : Mod
    {
        public override string Name => "Minus Score";
        public override string Acronym => "-1";
        public override LocalisableString Description => "Score times -1.";
        public override ModType Type => ModType.System;
        public override double ScoreMultiplier => -1;

    }
}
