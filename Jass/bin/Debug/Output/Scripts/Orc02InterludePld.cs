using System;
using System.Collections.Generic;

namespace Jass {

	public class Orc02InterludePld {

		private void PreloadFiles() {//function PreloadFiles takes nothing returns nothing
			Preload("ReplaceableTextures\\CameraMasks\\Black_mask.blp");//call Preload( "ReplaceableTextures\\CameraMasks\\Black_mask.blp" )
			Preload("Splats\\SplatData.slk");//call Preload( "Splats\\SplatData.slk" )
			Preload("ReplaceableTextures\\Splats\\Splat01Mature.blp");//call Preload( "ReplaceableTextures\\Splats\\Splat01Mature.blp" )
			Preload("Sound\\Buildings\\Fire\\OrcHumanMediumBuildingFire1.wav");//call Preload( "Sound\\Buildings\\Fire\\OrcHumanMediumBuildingFire1.wav" )
			Preload("UI\\TipStrings.txt");//call Preload( "UI\\TipStrings.txt" )
			Preload("UI\\Widgets\\EscMenu\\Undead\\undead-options-button-background.blp");//call Preload( "UI\\Widgets\\EscMenu\\Undead\\undead-options-button-background.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\human-options-button-border-up.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\human-options-button-border-up.blp" )
			Preload("UI\\Widgets\\EscMenu\\Undead\\undead-options-button-background-down.blp");//call Preload( "UI\\Widgets\\EscMenu\\Undead\\undead-options-button-background-down.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\human-options-button-border-down.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\human-options-button-border-down.blp" )
			Preload("UI\\Widgets\\EscMenu\\Undead\\undead-options-button-background-disabled.blp");//call Preload( "UI\\Widgets\\EscMenu\\Undead\\undead-options-button-background-disabled.blp" )
			Preload("UI\\Widgets\\EscMenu\\Undead\\undead-options-button-border-disabled.blp");//call Preload( "UI\\Widgets\\EscMenu\\Undead\\undead-options-button-border-disabled.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\human-options-button-background-disabled.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\human-options-button-background-disabled.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\editbox-background.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\editbox-background.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\editbox-border.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\editbox-border.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\slider-background.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\slider-background.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\slider-border.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\slider-border.blp" )
			Preload("UI\\Widgets\\EscMenu\\Undead\\undead-slider-knob.blp");//call Preload( "UI\\Widgets\\EscMenu\\Undead\\undead-slider-knob.blp" )
			Preload("UI\\HelpStrings.txt");//call Preload( "UI\\HelpStrings.txt" )
			Preload("UI\\Widgets\\EscMenu\\Human\\slider-borderdisabled.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\slider-borderdisabled.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\slider-knobdisabled.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\slider-knobdisabled.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\checkbox-background.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\checkbox-background.blp" )
			Preload("UI\\Widgets\\EscMenu\\Undead\\undead-checkbox-depressed.blp");//call Preload( "UI\\Widgets\\EscMenu\\Undead\\undead-checkbox-depressed.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\checkbox-background-disabled.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\checkbox-background-disabled.blp" )
			Preload("UI\\Widgets\\Glues\\GlueScreen-PullDown-Arrow.blp");//call Preload( "UI\\Widgets\\Glues\\GlueScreen-PullDown-Arrow.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\alliance-gold.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\alliance-gold.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\alliance-lumber.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\alliance-lumber.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor02.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor02.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor03.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor03.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor04.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor04.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor05.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor05.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor07.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor07.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor08.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor08.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor09.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor09.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor10.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor10.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor11.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor11.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor13.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor13.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor14.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor14.blp" )
			Preload("war3mapMap.blp");//call Preload( "war3mapMap.blp" )
			Preload("UI\\Minimap\\minimap-gold.blp");//call Preload( "UI\\Minimap\\minimap-gold.blp" )
			Preload("UI\\Minimap\\minimap-neutralbuilding.blp");//call Preload( "UI\\Minimap\\minimap-neutralbuilding.blp" )
			Preload("UI\\Minimap\\MinimapIconCircleOfPower.blp");//call Preload( "UI\\Minimap\\MinimapIconCircleOfPower.blp" )
			Preload("UI\\Minimap\\minimap-hero.blp");//call Preload( "UI\\Minimap\\minimap-hero.blp" )
			Preload("Abilities\\Spells\\NightElf\\Immolation\\ImmolationDamage.mdx");//call Preload( "Abilities\\Spells\\NightElf\\Immolation\\ImmolationDamage.mdx" )
			Preload("Environment\\LargeBuildingFire\\LargeBuildingFire0.mdx");//call Preload( "Environment\\LargeBuildingFire\\LargeBuildingFire0.mdx" )
			Preload("Textures\\Clouds8x8ModFire.blp");//call Preload( "Textures\\Clouds8x8ModFire.blp" )
			Preload("Environment\\SmallBuildingFire\\SmallBuildingFire1.mdx");//call Preload( "Environment\\SmallBuildingFire\\SmallBuildingFire1.mdx" )
			Preload("Environment\\LargeBuildingFire\\LargeBuildingFire2.mdx");//call Preload( "Environment\\LargeBuildingFire\\LargeBuildingFire2.mdx" )
			Preload("Environment\\LargeBuildingFire\\LargeBuildingFire1.mdx");//call Preload( "Environment\\LargeBuildingFire\\LargeBuildingFire1.mdx" )
			Preload("Environment\\Sky\\LordaeronWinterSky\\LordaeronWinterSky.mdx");//call Preload( "Environment\\Sky\\LordaeronWinterSky\\LordaeronWinterSky.mdx" )
			Preload("Textures\\LordaeronSkyWrap.blp");//call Preload( "Textures\\LordaeronSkyWrap.blp" )
			Preload("Abilities\\Spells\\Human\\massteleport\\massteleportcaster.mdx");//call Preload( "Abilities\\Spells\\Human\\massteleport\\massteleportcaster.mdx" )
			Preload("Textures\\GenericGlow2_64_blue.blp");//call Preload( "Textures\\GenericGlow2_64_blue.blp" )
			Preload("Textures\\GenericGlow2c.blp");//call Preload( "Textures\\GenericGlow2c.blp" )
			Preload("abilities\\Spells\\Human\\MassTeleport\\Rune1.blp");//call Preload( "abilities\\Spells\\Human\\MassTeleport\\Rune1.blp" )
			Preload("Textures\\Blue_Star2.blp");//call Preload( "Textures\\Blue_Star2.blp" )
			Preload("Abilities\\Spells\\Undead\\AnimateDead\\animatedeadtarget.mdx");//call Preload( "Abilities\\Spells\\Undead\\AnimateDead\\animatedeadtarget.mdx" )
			Preload("Textures\\grad2d.blp");//call Preload( "Textures\\grad2d.blp" )
			Preload("Textures\\Green_Glow2.blp");//call Preload( "Textures\\Green_Glow2.blp" )
			Preload("Textures\\GenericGlow2b.blp");//call Preload( "Textures\\GenericGlow2b.blp" )
			Preload("Splats\\SpawnData.slk");//call Preload( "Splats\\SpawnData.slk" )
			Preload("Objects\\Spawnmodels\\Human\\HumanBlood\\HumanBloodPeasant.mdx");//call Preload( "Objects\\Spawnmodels\\Human\\HumanBlood\\HumanBloodPeasant.mdx" )
			Preload("Textures\\BloodWhiteSmall.blp");//call Preload( "Textures\\BloodWhiteSmall.blp" )
			Preload("Environment\\SmallBuildingFire\\SmallBuildingFire2.mdx");//call Preload( "Environment\\SmallBuildingFire\\SmallBuildingFire2.mdx" )
			Preload("Sound\\Buildings\\Fire\\OrcHumanLargeBuildingFire1.wav");//call Preload( "Sound\\Buildings\\Fire\\OrcHumanLargeBuildingFire1.wav" )
			Preload("Sound\\Buildings\\Fire\\OrcHumanSmallBuildingFire1.wav");//call Preload( "Sound\\Buildings\\Fire\\OrcHumanSmallBuildingFire1.wav" )
			Preload("Objects\\Spawnmodels\\Other\\NPCBlood\\NpcBloodVillagerWoman.mdx");//call Preload( "Objects\\Spawnmodels\\Other\\NPCBlood\\NpcBloodVillagerWoman.mdx" )
			Preload("ReplaceableTextures\\Selection\\SelectionCircleMed.blp");//call Preload( "ReplaceableTextures\\Selection\\SelectionCircleMed.blp" )
			Preload("ReplaceableTextures\\Splats\\ScorchedUberSplat.blp");//call Preload( "ReplaceableTextures\\Splats\\ScorchedUberSplat.blp" )
			Preload("Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Tichondrius33.mp3");//call Preload( "Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Tichondrius33.mp3" )
			Preload("Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Mannoroth34.mp3");//call Preload( "Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Mannoroth34.mp3" )
			Preload("units\\demon\\Mannoroth\\Mannoroth_portrait.mdx");//call Preload( "units\\demon\\Mannoroth\\Mannoroth_portrait.mdx" )
			Preload("Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Tichondrius35.mp3");//call Preload( "Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Tichondrius35.mp3" )
			Preload("Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Mannoroth36.mp3");//call Preload( "Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Mannoroth36.mp3" )
			Preload("Abilities\\Spells\\Orc\\WarStomp\\warstompcaster.mdx");//call Preload( "Abilities\\Spells\\Orc\\WarStomp\\warstompcaster.mdx" )
			Preload("Textures\\LightningBall.blp");//call Preload( "Textures\\LightningBall.blp" )
			Preload("Textures\\Zap1_Red.blp");//call Preload( "Textures\\Zap1_Red.blp" )
			Preload("ReplaceableTextures\\Splats\\ThunderClapUbersplat.blp");//call Preload( "ReplaceableTextures\\Splats\\ThunderClapUbersplat.blp" )
			Preload("Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Tichondrius37.mp3");//call Preload( "Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Tichondrius37.mp3" )
			Preload("Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Mannoroth38.mp3");//call Preload( "Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Mannoroth38.mp3" )
			Preload("Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Tichondrius39.mp3");//call Preload( "Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Tichondrius39.mp3" )
			Preload("Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Mannoroth40.mp3");//call Preload( "Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Mannoroth40.mp3" )
			Preload("Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Archimonde41.mp3");//call Preload( "Sound\\Dialogue\\OrcCampaign\\Orc02Interlude\\O02Archimonde41.mp3" )
			Preload("units\\demon\\Warlock\\Warlock_portrait.mdx");//call Preload( "units\\demon\\Warlock\\Warlock_portrait.mdx" )
			PreloadEnd(5.00);//call PreloadEnd( 5.00 )
		}//endfunction

	
	}
}

