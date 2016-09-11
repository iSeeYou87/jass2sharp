using System;
using System.Collections.Generic;

namespace Jass {

	public class U05_tealAi {

		//
		//
		//
		public static player user = Player(3);//player user = Player(3)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ELF_FARM,null);//call CampaignAI(ELF_FARM,null)
			do_campaign_farms = false;//set do_campaign_farms = false
			SetReplacements(1,1,3);//call SetReplacements(1,1,3)
			SetBuildUnitEx(0,0,1, TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL			)
			SetBuildUnitEx(2,2,2, PEASANT);//call SetBuildUnitEx( 2,2,2, PEASANT				)
			SetBuildUnitEx(0,0,1, ELF_HIGH_BARRACKS);//call SetBuildUnitEx( 0,0,1, ELF_HIGH_BARRACKS	)
			SetBuildUnitEx(0,0,8, ELF_FARM);//call SetBuildUnitEx( 0,0,8, ELF_FARM			)
			SetBuildUnitEx(5,5,5, PEASANT);//call SetBuildUnitEx( 5,5,5, PEASANT				)
			CampaignDefenderEx(1,1,1, HIGH_SWORDMAN);//call CampaignDefenderEx( 1,1,1, HIGH_SWORDMAN	)
			CampaignDefenderEx(1,1,1, HIGH_ARCHER);//call CampaignDefenderEx( 1,1,1, HIGH_ARCHER		)
			CampaignDefenderEx(0,0,1, SORCERESS);//call CampaignDefenderEx( 0,0,1, SORCERESS		)
			CampaignDefenderEx(1,1,2, DRAGON_HAWK);//call CampaignDefenderEx( 1,1,2, DRAGON_HAWK		)
			CampaignDefenderEx(0,0,1, ARCHMAGE);//call CampaignDefenderEx( 0,0,1, ARCHMAGE		)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,5, HIGH_SWORDMAN);//call CampaignAttackerEx( 4,4,5, HIGH_SWORDMAN	)
			CampaignAttackerEx(3,3,4, HIGH_ARCHER);//call CampaignAttackerEx( 3,3,4, HIGH_ARCHER		)
			CampaignAttackerEx(0,0,1, SORCERESS);//call CampaignAttackerEx( 0,0,1, SORCERESS		)
			CampaignAttackerEx(0,0,1, BALLISTA);//call CampaignAttackerEx( 0,0,1, BALLISTA		)
			CampaignAttackerEx(1,1,1, ARCHMAGE);//call CampaignAttackerEx( 1,1,1, ARCHMAGE		)
			SuicideOnPlayer(0,user);//call SuicideOnPlayer(0,user)
			SetBuildUpgrEx(1,1,1, UPG_SORCERY);//call SetBuildUpgrEx( 1,1,1, UPG_SORCERY			)
			SetBuildUpgrEx(1,1,1, UPG_PRAYING);//call SetBuildUpgrEx( 1,1,1, UPG_PRAYING			)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,6, DRAGON_HAWK);//call CampaignAttackerEx( 4,4,6, DRAGON_HAWK		)
			SuicideOnPlayerEx(M8,M8,M5,user);//call SuicideOnPlayerEx(M8,M8,M5,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4, HIGH_SWORDMAN);//call CampaignAttackerEx( 2,2,4, HIGH_SWORDMAN	)
			CampaignAttackerEx(3,3,4, HIGH_ARCHER);//call CampaignAttackerEx( 3,3,4, HIGH_ARCHER		)
			CampaignAttackerEx(1,1,1, PRIEST);//call CampaignAttackerEx( 1,1,1, PRIEST			)
			CampaignAttackerEx(1,1,1, ARCHMAGE);//call CampaignAttackerEx( 1,1,1, ARCHMAGE		)
			CampaignAttackerEx(0,0,2, BALLISTA);//call CampaignAttackerEx( 0,0,2, BALLISTA		)
			SuicideOnPlayerEx(M7,M7,M4,user);//call SuicideOnPlayerEx(M7,M7,M4,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,8, DRAGON_HAWK);//call CampaignAttackerEx( 5,5,8, DRAGON_HAWK		)
			SuicideOnPlayerEx(M8,M8,M5,user);//call SuicideOnPlayerEx(M8,M8,M5,user)
			SetBuildUpgrEx(0,0,2, UPG_SORCERY);//call SetBuildUpgrEx( 0,0,2, UPG_SORCERY			)
			SetBuildUpgrEx(0,0,2, UPG_PRAYING);//call SetBuildUpgrEx( 0,0,2, UPG_PRAYING			)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4, HIGH_SWORDMAN);//call CampaignAttackerEx( 3,3,4, HIGH_SWORDMAN	)
			CampaignAttackerEx(3,3,4, HIGH_ARCHER);//call CampaignAttackerEx( 3,3,4, HIGH_ARCHER		)
			CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST			)
			CampaignAttackerEx(0,0,1, SORCERESS);//call CampaignAttackerEx( 0,0,1, SORCERESS		)
			CampaignAttackerEx(1,1,1, ARCHMAGE);//call CampaignAttackerEx( 1,1,1, ARCHMAGE		)
			CampaignAttackerEx(1,1,2, BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA		)
			SuicideOnPlayerEx(M7,M7,M4,user);//call SuicideOnPlayerEx(M7,M7,M4,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,8, DRAGON_HAWK);//call CampaignAttackerEx( 4,4,8, DRAGON_HAWK		)
				SuicideOnPlayerEx(M7,M7,M4,user);//call SuicideOnPlayerEx(M7,M7,M4,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,8, HIGH_SWORDMAN);//call CampaignAttackerEx( 4,4,8, HIGH_SWORDMAN	)
				CampaignAttackerEx(2,2,2, HIGH_ARCHER);//call CampaignAttackerEx( 2,2,2, HIGH_ARCHER		)
				CampaignAttackerEx(1,1,1, ARCHMAGE);//call CampaignAttackerEx( 1,1,1, ARCHMAGE		)
				CampaignAttackerEx(0,0,1, SORCERESS);//call CampaignAttackerEx( 0,0,1, SORCERESS		)
				CampaignAttackerEx(1,1,2, BALLISTA);//call CampaignAttackerEx( 1,1,2, BALLISTA		)
				SuicideOnPlayerEx(M8,M8,M5,user);//call SuicideOnPlayerEx(M8,M8,M5,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(0,0,5, HIGH_SWORDMAN);//call CampaignAttackerEx( 0,0,5, HIGH_SWORDMAN	)
				CampaignAttackerEx(4,4,3, HIGH_ARCHER);//call CampaignAttackerEx( 4,4,3, HIGH_ARCHER		)
				CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST			)
				CampaignAttackerEx(2,2,4, SORCERESS);//call CampaignAttackerEx( 2,2,4, SORCERESS		)
				CampaignAttackerEx(2,2,2, DRAGON_HAWK);//call CampaignAttackerEx( 2,2,2, DRAGON_HAWK		)
				SuicideOnPlayerEx(M7,M7,M4,user);//call SuicideOnPlayerEx(M7,M7,M4,user)
			}//endloop
		}//endfunction

	
	}
}

