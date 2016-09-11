using System;
using System.Collections.Generic;

namespace Jass {

	public class N03_purpleAi {

		//
		//
		//
		public const float MAIN_TOWN_X = -4279;//constant real MAIN_TOWN_X   = -4279
		public const float MAIN_TOWN_Y = 3057;//constant real MAIN_TOWN_Y   =  3057
		public const float DEFENSE_X = -3919;//constant real DEFENSE_X     = -3919
		public const float DEFENSE_Y = 1198;//constant real DEFENSE_Y     =  1198
		public const float FAILSAFE_X = -2700;//constant real FAILSAFE_X    = -2700
		public const float FAILSAFE_Y = 80;//constant real FAILSAFE_Y    =    80
		public const float GRAVEYARD_X = -1979;//constant real GRAVEYARD_X   = -1979
		public const float GRAVEYARD_Y = -1037;//constant real GRAVEYARD_Y   = -1037
		public const int MIN_GHOULS_NORMAL = 3;//constant integer MIN_GHOULS_NORMAL =  3
		public const int MIN_GHOULS_HARD = 8;//constant integer MIN_GHOULS_HARD   =  8
		public const int MAX_GHOULS_NORMAL = 10;//constant integer MAX_GHOULS_NORMAL = 10
		public const int MAX_GHOULS_HARD = 15;//constant integer MAX_GHOULS_HARD   = 15
		public static bool on_alert = false;//boolean on_alert            = false
		public static int defcon = 5;//integer defcon              = 5
		public static int trees_alive = 100;//integer trees_alive         = 100
		public static int best_ghouls = 0;//integer best_ghouls         = 0
		//
		//
		//
		private void lower_defcon() {//function lower_defcon takes nothing returns nothing
			on_alert = true;//set on_alert = true
			defcon = defcon - 1;//set defcon = defcon - 1
			TraceI("DEFCON %d\n",defcon);//debug call TraceI("DEFCON %d\n",defcon)
			//
			if (defcon == 4) {//if defcon == 4 then
				//
				AddGuardPost(NECRO,		-1800,  230);//call AddGuardPost( NECRO,		-1800,  230 )
				CampaignDefenderEx(1,1,2, NECRO);//call CampaignDefenderEx( 1,1,2, NECRO       )
				//
			} else if (defcon == 3) {//elseif defcon == 3 then
				//
				AddGuardPost(GARGOYLE,	-2320,  725);//call AddGuardPost( GARGOYLE,	-2320,  725 )
				AddGuardPost(NECRO,       -2340,  325);//call AddGuardPost( NECRO,       -2340,  325 )
				CampaignDefenderEx(1,1,1, CRYPT_FIEND);//call CampaignDefenderEx( 1,1,1, CRYPT_FIEND )
				//
			} else if (defcon == 2) {//elseif defcon == 2 then
				//
				AddGuardPost(ABOMINATION, -2110,   70);//call AddGuardPost( ABOMINATION, -2110,   70 )
				AddGuardPost(NECRO,       -2620,  480);//call AddGuardPost( NECRO,       -2620,  480 )
				CampaignDefenderEx(1,1,2, ABOMINATION);//call CampaignDefenderEx( 1,1,2, ABOMINATION )
				//
			} else {//else
				//
				AddGuardPost(ABOMINATION, -2025,  570);//call AddGuardPost( ABOMINATION, -2025,  570 )
				AddGuardPost(GARGOYLE,	-2450,  520);//call AddGuardPost( GARGOYLE,	-2450,  520 )
				AddGuardPost(CRYPT_FIEND, -2120,  290);//call AddGuardPost( CRYPT_FIEND, -2120,  290 )
				CampaignDefender(EASY, 1, TICHONDRIUS);//call CampaignDefender( EASY, 1, TICHONDRIUS )
				SetCaptainHome(DEFENSE_CAPTAIN,FAILSAFE_X,FAILSAFE_Y);//call SetCaptainHome(DEFENSE_CAPTAIN,FAILSAFE_X,FAILSAFE_Y)
			}//endif
		}//endfunction
		//
		//
		//
		private void set_wood_ghouls() {//function set_wood_ghouls takes nothing returns nothing
			int ghouls = GetUnitCount(GHOUL);//local integer ghouls = GetUnitCount(GHOUL)
			//
			//
			if (!on_alert && defcon > 1 && ghouls < best_ghouls) {//if not on_alert and defcon > 1 and ghouls < best_ghouls then
				lower_defcon();//call lower_defcon()
			}//endif
			//
			//
			if (on_alert && ghouls >= best_ghouls && !CaptainInCombat(false)) {//if on_alert and ghouls >= best_ghouls and not CaptainInCombat(false) then
				on_alert = false;//set on_alert = false
			}//endif
			//
			//
			if (ghouls > best_ghouls) {//if ghouls > best_ghouls then
				best_ghouls = ghouls;//set best_ghouls = ghouls
			}//endif
			while (true) {//loop
				if (CommandsWaiting() == 0) { break; }//exitwhen CommandsWaiting() == 0
				trees_alive = GetLastData();//set trees_alive = GetLastData()
				PopLastCommand();//call PopLastCommand()
			}//endloop
			if (difficulty==HARD) {//if difficulty==HARD then
				campaign_wood_peons = MAX_GHOULS_HARD - ((MAX_GHOULS_HARD-MIN_GHOULS_HARD+1)*trees_alive)/100;//set campaign_wood_peons = MAX_GHOULS_HARD - ((MAX_GHOULS_HARD-MIN_GHOULS_HARD+1)*trees_alive)/100
			} else {//else
				campaign_wood_peons = MAX_GHOULS_NORMAL - ((MAX_GHOULS_NORMAL-MIN_GHOULS_NORMAL+1)*trees_alive)/100;//set campaign_wood_peons = MAX_GHOULS_NORMAL - ((MAX_GHOULS_NORMAL-MIN_GHOULS_NORMAL+1)*trees_alive)/100
			}//endif
		}//endfunction
		//
		//
		//
		private void rebuild_town() {//function rebuild_town takes nothing returns nothing
			InitBuildArray();//call InitBuildArray()
			//
			//
			if (GetUnitCountDone(UNDEAD_ALTAR)>0) {//if GetUnitCountDone(UNDEAD_ALTAR)>0 then
				SetBuildUnit(1, TICHONDRIUS);//call SetBuildUnit( 1, TICHONDRIUS   )
			}//endif
			SetBuildUnit(1, ACOLYTE);//call SetBuildUnit( 1, ACOLYTE           )
			//
			//
			if (TownCount(NECROPOLIS_1)==0 || GetUnitCount(UNDEAD_MINE)==0 || GetUnitCount(UNDEAD_ALTAR)==0  || GetUnitCount(CRYPT)==0) {//if TownCount(NECROPOLIS_1)==0 or GetUnitCount(UNDEAD_MINE)==0 or GetUnitCount(UNDEAD_ALTAR)==0  or GetUnitCount(CRYPT)==0 then
				ShiftTownSpot(MAIN_TOWN_X,MAIN_TOWN_Y);//call ShiftTownSpot(MAIN_TOWN_X,MAIN_TOWN_Y)
				SetBuildUnit(1, NECROPOLIS_1);//call SetBuildUnit( 1, NECROPOLIS_1  )
				SetBuildUnit(1, UNDEAD_MINE);//call SetBuildUnit( 1, UNDEAD_MINE   )
				SetBuildUnit(1, CRYPT);//call SetBuildUnit( 1, CRYPT         )
				SetBuildUnit(1, UNDEAD_ALTAR);//call SetBuildUnit( 1, UNDEAD_ALTAR  )
				return;//return
			}//endif
			//
			//
			if (GetUnitCount(GRAVEYARD)==0) {//if GetUnitCount(GRAVEYARD)==0 then
				ShiftTownSpot(GRAVEYARD_X,GRAVEYARD_Y);//call ShiftTownSpot(GRAVEYARD_X,GRAVEYARD_Y)
				SetBuildUnit(1, GRAVEYARD);//call SetBuildUnit( 1, GRAVEYARD     )
				return;//return
			}//endif
			SetBuildUnit(campaign_wood_peons, GHOUL);//call SetBuildUnit( campaign_wood_peons, GHOUL )
			//
			//
			ShiftTownSpot(MAIN_TOWN_X,MAIN_TOWN_Y);//call ShiftTownSpot(MAIN_TOWN_X,MAIN_TOWN_Y)
			SetBuildUnit(8, ZIGGURAT_1);//call SetBuildUnit( 8, ZIGGURAT_1        )
			SetBuildUnit(2, CRYPT_FIEND);//call SetBuildUnit( 2, CRYPT_FIEND       )
			SetBuildUnit(1, NECROPOLIS_2);//call SetBuildUnit( 1, NECROPOLIS_2      )
			SetBuildUnit(1, DAMNED_TEMPLE);//call SetBuildUnit( 1, DAMNED_TEMPLE     )
			SetBuildUnit(2, NECRO);//call SetBuildUnit( 2, NECRO             )
			SetBuildUnit(1, SLAUGHTERHOUSE);//call SetBuildUnit( 1, SLAUGHTERHOUSE    )
			SetBuildUnit(2, ABOMINATION);//call SetBuildUnit( 2, ABOMINATION       )
			SetBuildUnit(8, ZIGGURAT_2);//call SetBuildUnit( 8, ZIGGURAT_2        )
			SetBuildUnit(1, NECROPOLIS_3);//call SetBuildUnit( 1, NECROPOLIS_3      )
			SetBuildUnit(5, ACOLYTE);//call SetBuildUnit( 5, ACOLYTE           )
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetSlowChopping(false);//call SetSlowChopping(false)
			SetPeonsRepair(true);//call SetPeonsRepair(true)
			SetReplacementCount(99);//call SetReplacementCount(99)
			SetCaptainHome(DEFENSE_CAPTAIN,DEFENSE_X,DEFENSE_Y);//call SetCaptainHome(DEFENSE_CAPTAIN,DEFENSE_X,DEFENSE_Y)
			CampaignDefenderEx(1,1,1, CRYPT_FIEND);//call CampaignDefenderEx( 1,1,1, CRYPT_FIEND )
			while (true) {//loop
				rebuild_town();//call rebuild_town()
				set_wood_ghouls();//call set_wood_ghouls()
				Sleep(2);//call Sleep(2)
			}//endloop
		}//endfunction

	
	}
}
