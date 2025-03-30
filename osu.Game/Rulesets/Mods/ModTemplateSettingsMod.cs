using osu.Framework.Localisation;

namespace osu.Game.Rulesets.Mods{

    public class ModTemplateSettings : Mod
    {
        public override string Name => "Example Settings Mod";
        public override string Acronym => "ESM";
        public override LocalisableString Description => "An example mod for the Settings category.";
        public override ModType Type => ModType.Settings;
        public override double ScoreMultiplier => 1.0;
        public override bool Ranked => false;
    }
}
