using System;
using System.Collections.Generic;

namespace Jass {

	public class Human06InterludePld {

		private void PreloadFiles() {//function PreloadFiles takes nothing returns nothing
			Preload("Splats\\SplatData.slk");//call Preload( "Splats\\SplatData.slk" )
			Preload("ReplaceableTextures\\Splats\\Splat01Mature.blp");//call Preload( "ReplaceableTextures\\Splats\\Splat01Mature.blp" )
			Preload("ReplaceableTextures\\CameraMasks\\Black_mask.blp");//call Preload( "ReplaceableTextures\\CameraMasks\\Black_mask.blp" )
			Preload("Environment\\Sky\\DalaranSky\\DalaranSky.mdx");//call Preload( "Environment\\Sky\\DalaranSky\\DalaranSky.mdx" )
			Preload("environment\\Sky\\DalaranSky\\DalaranSky.blp");//call Preload( "environment\\Sky\\DalaranSky\\DalaranSky.blp" )
			Preload("Textures\\sun.blp");//call Preload( "Textures\\sun.blp" )
			Preload("ReplaceableTextures\\Weather\\RaysOfLight.blp");//call Preload( "ReplaceableTextures\\Weather\\RaysOfLight.blp" )
			Preload("ReplaceableTextures\\Weather\\rainTail.blp");//call Preload( "ReplaceableTextures\\Weather\\rainTail.blp" )
			Preload("UI\\TipStrings.txt");//call Preload( "UI\\TipStrings.txt" )
			Preload("UI\\Widgets\\EscMenu\\Human\\human-options-button-border-up.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\human-options-button-border-up.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\human-options-button-border-down.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\human-options-button-border-down.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\human-options-button-background-disabled.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\human-options-button-background-disabled.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\editbox-background.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\editbox-background.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\editbox-border.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\editbox-border.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\slider-background.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\slider-background.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\slider-border.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\slider-border.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\slider-knob.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\slider-knob.blp" )
			Preload("UI\\HelpStrings.txt");//call Preload( "UI\\HelpStrings.txt" )
			Preload("UI\\Widgets\\EscMenu\\Human\\slider-borderdisabled.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\slider-borderdisabled.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\slider-knobdisabled.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\slider-knobdisabled.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\checkbox-background.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\checkbox-background.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\checkbox-depressed.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\checkbox-depressed.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\checkbox-background-disabled.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\checkbox-background-disabled.blp" )
			Preload("UI\\Widgets\\Glues\\GlueScreen-PullDown-Arrow.blp");//call Preload( "UI\\Widgets\\Glues\\GlueScreen-PullDown-Arrow.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\alliance-gold.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\alliance-gold.blp" )
			Preload("UI\\Widgets\\EscMenu\\Human\\alliance-lumber.blp");//call Preload( "UI\\Widgets\\EscMenu\\Human\\alliance-lumber.blp" )
			Preload("war3mapMap.blp");//call Preload( "war3mapMap.blp" )
			Preload("UI\\Minimap\\minimap-gold.blp");//call Preload( "UI\\Minimap\\minimap-gold.blp" )
			Preload("UI\\Minimap\\minimap-neutralbuilding.blp");//call Preload( "UI\\Minimap\\minimap-neutralbuilding.blp" )
			Preload("UI\\Minimap\\MinimapIconCircleOfPower.blp");//call Preload( "UI\\Minimap\\MinimapIconCircleOfPower.blp" )
			Preload("UI\\Minimap\\minimap-hero.blp");//call Preload( "UI\\Minimap\\minimap-hero.blp" )
			Preload("Sound\\Ambient\\DoodadEffects\\CityScapeCathedralLoop1.wav");//call Preload( "Sound\\Ambient\\DoodadEffects\\CityScapeCathedralLoop1.wav" )
			Preload("Sound\\Ambient\\DoodadEffects\\CityScapeTavernLoop1.wav");//call Preload( "Sound\\Ambient\\DoodadEffects\\CityScapeTavernLoop1.wav" )
			Preload("Sound\\Buildings\\Fire\\OrcHumanMediumBuildingFire1.wav");//call Preload( "Sound\\Buildings\\Fire\\OrcHumanMediumBuildingFire1.wav" )
			Preload("Sound\\Ambient\\RainAmbience.wav");//call Preload( "Sound\\Ambient\\RainAmbience.wav" )
			Preload("ReplaceableTextures\\Selection\\SelectionCircleSmall.blp");//call Preload( "ReplaceableTextures\\Selection\\SelectionCircleSmall.blp" )
			Preload("Environment\\LargeBuildingFire\\LargeBuildingFire0.mdx");//call Preload( "Environment\\LargeBuildingFire\\LargeBuildingFire0.mdx" )
			Preload("Textures\\Clouds8x8ModFire.blp");//call Preload( "Textures\\Clouds8x8ModFire.blp" )
			Preload("Textures\\CloudSingle.blp");//call Preload( "Textures\\CloudSingle.blp" )
			Preload("Environment\\SmallBuildingFire\\SmallBuildingFire1.mdx");//call Preload( "Environment\\SmallBuildingFire\\SmallBuildingFire1.mdx" )
			Preload("Environment\\LargeBuildingFire\\LargeBuildingFire2.mdx");//call Preload( "Environment\\LargeBuildingFire\\LargeBuildingFire2.mdx" )
			Preload("Environment\\LargeBuildingFire\\LargeBuildingFire1.mdx");//call Preload( "Environment\\LargeBuildingFire\\LargeBuildingFire1.mdx" )
			Preload("Sound\\Buildings\\Fire\\OrcHumanLargeBuildingFire1.wav");//call Preload( "Sound\\Buildings\\Fire\\OrcHumanLargeBuildingFire1.wav" )
			Preload("Sound\\Ambient\\DoodadEffects\\LordaeronSummerFliesLoop1.wav");//call Preload( "Sound\\Ambient\\DoodadEffects\\LordaeronSummerFliesLoop1.wav" )
			Preload("Sound\\Ambient\\DoodadEffects\\LordaeronSummerHumanTorchLoop1.wav");//call Preload( "Sound\\Ambient\\DoodadEffects\\LordaeronSummerHumanTorchLoop1.wav" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Jaina46.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Jaina46.mp3" )
			Preload("ReplaceableTextures\\TeamColor\\TeamColor01.blp");//call Preload( "ReplaceableTextures\\TeamColor\\TeamColor01.blp" )
			Preload("ReplaceableTextures\\TeamGlow\\TeamGlow01.blp");//call Preload( "ReplaceableTextures\\TeamGlow\\TeamGlow01.blp" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Uther47.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Uther47.mp3" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Jaina48.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Jaina48.mp3" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Uther49.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Uther49.mp3" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Jaina50.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Jaina50.mp3" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Uther51.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Uther51.mp3" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Jaina52.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Jaina52.mp3" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Uther53.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Uther53.mp3" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Medivh54.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Medivh54.mp3" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Jaina55.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Jaina55.mp3" )
			Preload("Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Medivh56.mp3");//call Preload( "Sound\\Dialogue\\HumanCampaign\\Human06Interlude\\H06Medivh56.mp3" )
			PreloadEnd(5.00);//call PreloadEnd( 5.00 )
		}//endfunction

	
	}
}

