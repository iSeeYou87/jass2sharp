using System;
using System.Collections.Generic;

namespace Jass {

	public class Undead05InterludePld {

		private void PreloadFiles() {//function PreloadFiles takes nothing returns nothing
			Preload("Splats\\SplatData.slk");//call Preload( "Splats\\SplatData.slk" )
			Preload("ReplaceableTextures\\Splats\\Splat01Mature.blp");//call Preload( "ReplaceableTextures\\Splats\\Splat01Mature.blp" )
			Preload("Environment\\Sky\\LordaeronWinterSky\\LordaeronWinterSky.mdx");//call Preload( "Environment\\Sky\\LordaeronWinterSky\\LordaeronWinterSky.mdx" )
			Preload("Textures\\LordaeronSkyWrap.blp");//call Preload( "Textures\\LordaeronSkyWrap.blp" )
			Preload("ReplaceableTextures\\CameraMasks\\White_mask.blp");//call Preload( "ReplaceableTextures\\CameraMasks\\White_mask.blp" )
			Preload("Sound\\Ambient\\DoodadEffects\\LordaeronSummerFliesLoop1.wav");//call Preload( "Sound\\Ambient\\DoodadEffects\\LordaeronSummerFliesLoop1.wav" )
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
			Preload("Environment\\BlightDoodad\\BlightDoodad.mdx");//call Preload( "Environment\\BlightDoodad\\BlightDoodad.mdx" )
			Preload("war3mapMap.blp");//call Preload( "war3mapMap.blp" )
			Preload("UI\\Minimap\\minimap-gold.blp");//call Preload( "UI\\Minimap\\minimap-gold.blp" )
			Preload("UI\\Minimap\\minimap-neutralbuilding.blp");//call Preload( "UI\\Minimap\\minimap-neutralbuilding.blp" )
			Preload("UI\\Minimap\\MinimapIconCircleOfPower.blp");//call Preload( "UI\\Minimap\\MinimapIconCircleOfPower.blp" )
			Preload("UI\\Minimap\\minimap-hero.blp");//call Preload( "UI\\Minimap\\minimap-hero.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor01.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor01.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor02.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor02.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor04.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor04.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor05.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor05.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor06.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor06.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor07.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor07.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor08.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor08.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor09.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor09.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor10.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor10.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor11.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor11.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor12.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor12.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor13.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor13.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor14.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor14.blp" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor15.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor15.blp" )
			Preload("ReplaceableTextures\\Selection\\SelectionCircleSmall.blp");//call Preload( "ReplaceableTextures\\Selection\\SelectionCircleSmall.blp" )
			Preload("Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BArthas30.mp3");//call Preload( "Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BArthas30.mp3" )
			Preload("ReplaceableTextures\\Selection\\SelectionCircleMed.blp");//call Preload( "ReplaceableTextures\\Selection\\SelectionCircleMed.blp" )
			Preload("Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BKelThuzad31.mp3");//call Preload( "Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BKelThuzad31.mp3" )
			Preload("Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BArthas32.mp3");//call Preload( "Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BArthas32.mp3" )
			Preload("Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BKelThuzad33.mp3");//call Preload( "Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BKelThuzad33.mp3" )
			Preload("Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BArthas34.mp3");//call Preload( "Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BArthas34.mp3" )
			Preload("Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BKelThuzad35.mp3");//call Preload( "Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BKelThuzad35.mp3" )
			Preload("Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BArthas36.mp3");//call Preload( "Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BArthas36.mp3" )
			Preload("Objects\\Spawnmodels\\Demon\\InfernalMeteor\\InfernalMeteor.mdx");//call Preload( "Objects\\Spawnmodels\\Demon\\InfernalMeteor\\InfernalMeteor.mdx" )
			Preload("Environment\\Sky\\LordaeronWinterSkyRed\\LordaeronWinterSkyRed.mdx");//call Preload( "Environment\\Sky\\LordaeronWinterSkyRed\\LordaeronWinterSkyRed.mdx" )
			Preload("Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BKelThuzad37.mp3");//call Preload( "Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BKelThuzad37.mp3" )
			Preload("Abilities\\Spells\\Human\\MassTeleport\\MassTeleportTarget.mdx");//call Preload( "Abilities\\Spells\\Human\\MassTeleport\\MassTeleportTarget.mdx" )
			Preload("Textures\\GenericGlowX.blp");//call Preload( "Textures\\GenericGlowX.blp" )
			Preload("Textures\\GenericGlow2c.blp");//call Preload( "Textures\\GenericGlow2c.blp" )
			Preload("abilities\\Spells\\Human\\MassTeleport\\Rune1.blp");//call Preload( "abilities\\Spells\\Human\\MassTeleport\\Rune1.blp" )
			Preload("Textures\\Blue_Star2.blp");//call Preload( "Textures\\Blue_Star2.blp" )
			Preload("TerrainArt\\Weather.slk");//call Preload( "TerrainArt\\Weather.slk" )
			Preload("ReplaceableTextures\\Weather\\snow.blp");//call Preload( "ReplaceableTextures\\Weather\\snow.blp" )
			Preload("Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BArthas38.mp3");//call Preload( "Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BArthas38.mp3" )
			Preload("Sound\\Ambient\\WindLoopStereo.wav");//call Preload( "Sound\\Ambient\\WindLoopStereo.wav" )
			Preload("Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BKelThuzad39.mp3");//call Preload( "Sound\\Dialogue\\UndeadCampaign\\Undead05BInterlude\\U05BKelThuzad39.mp3" )
			PreloadEnd(5.0);//call PreloadEnd( 5.0 )
		}//endfunction

	
	}
}

