using System;
using System.Collections.Generic;

namespace Jass {

	public class U03_brownAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ELF_FARM,null);//call CampaignAI(ELF_FARM,null)
			SetBuildUnit(1, TOWN_HALL);//call SetBuildUnit( 1, TOWN_HALL         )
			SetBuildUnit(2, PEASANT);//call SetBuildUnit( 2, PEASANT           )
			SetBuildUnit(1, ELF_HIGH_BARRACKS);//call SetBuildUnit( 1, ELF_HIGH_BARRACKS )
			SetBuildUnit(3, PEASANT);//call SetBuildUnit( 3, PEASANT           )
			SetBuildUnit(1, LUMBER_MILL);//call SetBuildUnit( 1, LUMBER_MILL       )
			SetBuildUnit(1, BLACKSMITH);//call SetBuildUnit( 1, BLACKSMITH        )
			SetBuildUnit(7, PEASANT);//call SetBuildUnit( 7, PEASANT           )
			CampaignDefender(EASY, 2, HIGH_FOOTMEN);//call CampaignDefender( EASY, 2, HIGH_FOOTMEN)
			CampaignDefender(EASY, 3, HIGH_ARCHER);//call CampaignDefender( EASY, 3, HIGH_ARCHER )
			CampaignDefender(EASY, 1, PRIEST);//call CampaignDefender( EASY, 1, PRIEST      )
			SleepForever();//call SleepForever()
		}//endfunction

	
	}
}

