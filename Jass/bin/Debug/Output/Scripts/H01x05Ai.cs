using System;
using System.Collections.Generic;

namespace Jass {

	public class H01x05Ai {

		//
		//
		//
		public static player user = PlayerEx(1);//player user = PlayerEx(1)
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetReplacements(2,2,3);//call SetReplacements(2,2,3)
			campaign_wood_peons = 2;//set campaign_wood_peons = 2
			SetBuildUnitEx(1, 1, 1, ACOLYTE);//call SetBuildUnitEx( 1, 1, 1, ACOLYTE           )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_1);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_1      )
			SetBuildUnitEx(0, 0, 1, CRYPT);//call SetBuildUnitEx( 0, 0, 1, CRYPT             )
			SetBuildUnitEx(0, 0, 5, ZIGGURAT_1);//call SetBuildUnitEx( 0, 0, 5, ZIGGURAT_1        )
			SetBuildUnitEx(0, 0, 1, GRAVEYARD);//call SetBuildUnitEx( 0, 0, 1, GRAVEYARD         )
			SetBuildUnitEx(0, 0, 1, UNDEAD_ALTAR);//call SetBuildUnitEx( 0, 0, 1, UNDEAD_ALTAR      )
			SetBuildUnitEx(0, 0, 1, NECROPOLIS_2);//call SetBuildUnitEx( 0, 0, 1, NECROPOLIS_2      )
			SetBuildUnitEx(0, 0, 1, DAMNED_TEMPLE);//call SetBuildUnitEx( 0, 0, 1, DAMNED_TEMPLE     )
			SetBuildUnitEx(0, 0, 4, ZIGGURAT_2);//call SetBuildUnitEx( 0, 0, 4, ZIGGURAT_2        )
			SetBuildUnitEx(2, 2, 2, UNDEAD_BARGE);//call SetBuildUnitEx( 2, 2, 2, UNDEAD_BARGE      )
			SetBuildUnitEx(5, 5, 5, ACOLYTE);//call SetBuildUnitEx( 5, 5, 5, ACOLYTE           )
			CampaignDefenderEx(1, 1, 1, GHOUL);//call CampaignDefenderEx( 1, 1, 1, GHOUL			)
			CampaignDefenderEx(1, 1, 1, BANSHEE);//call CampaignDefenderEx( 1, 1, 1, BANSHEE		)
			CampaignDefenderEx(1, 1, 1, NECRO);//call CampaignDefenderEx( 1, 1, 1, NECRO			)
			SetBuildUpgrEx(1,1,1, UPG_FIEND_WEB);//call SetBuildUpgrEx( 1,1,1, UPG_FIEND_WEB	)
			SetBuildUpgrEx(0,0,1, UPG_NECROS);//call SetBuildUpgrEx( 0,0,1, UPG_NECROS		)
			SetBuildUpgrEx(0,0,1, UPG_BANSHEE);//call SetBuildUpgrEx( 0,0,1, UPG_BANSHEE		)
			SetBuildUpgrEx(1,1,1, UPG_SKEL_LIFE);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_LIFE	)
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,4,	GHOUL);//call CampaignAttackerEx( 2,2,4,	GHOUL		)
			CampaignAttackerEx(2,2,4,	BANSHEE);//call CampaignAttackerEx( 2,2,4,	BANSHEE		)
			SuicideOnPlayerEx(M3,M3,M2,user);//call SuicideOnPlayerEx(M3,M3,M2,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(0,1,1, UPG_CR_ATTACK);//call SetBuildUpgrEx( 0,1,1, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,4,	CRYPT_FIEND);//call CampaignAttackerEx( 3,3,4,	CRYPT_FIEND	)
			CampaignAttackerEx(2,2,4,	NECRO);//call CampaignAttackerEx( 2,2,4,	NECRO		)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(0,0,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(0,0,1, UPG_CR_ARMOR);//call SetBuildUpgrEx( 0,0,1, UPG_CR_ARMOR	)
			SetBuildUpgrEx(1,1,1, UPG_NECROS);//call SetBuildUpgrEx( 1,1,1, UPG_NECROS		)
			SetBuildUpgrEx(1,1,1, UPG_BANSHEE);//call SetBuildUpgrEx( 1,1,1, UPG_BANSHEE		)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,5,	GHOUL);//call CampaignAttackerEx( 3,3,5,	GHOUL		)
			CampaignAttackerEx(3,3,5,	BANSHEE);//call CampaignAttackerEx( 3,3,5,	BANSHEE		)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,5,	GHOUL);//call CampaignAttackerEx( 3,3,5,	GHOUL		)
			CampaignAttackerEx(2,2,4,	CRYPT_FIEND);//call CampaignAttackerEx( 2,2,4,	CRYPT_FIEND	)
			CampaignAttackerEx(1,1,2,	BANSHEE);//call CampaignAttackerEx( 1,1,2,	BANSHEE		)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_STR  )
			SetBuildUpgrEx(1,1,2, UPG_CR_ATTACK);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ATTACK   )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,5,	GHOUL);//call CampaignAttackerEx( 4,4,5,	GHOUL		)
			CampaignAttackerEx(1,1,2,	MEAT_WAGON);//call CampaignAttackerEx( 1,1,2,	MEAT_WAGON	)
			CampaignAttackerEx(2,2,3,	NECRO);//call CampaignAttackerEx( 2,2,3,	NECRO		)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(1,1,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_UNHOLY_ARMOR)
			SetBuildUpgrEx(1,1,2, UPG_CR_ARMOR);//call SetBuildUpgrEx( 1,1,2, UPG_CR_ARMOR    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(5,5,7,	GHOUL);//call CampaignAttackerEx( 5,5,7,	GHOUL		)
			CampaignAttackerEx(3,3,4,	BANSHEE);//call CampaignAttackerEx( 3,3,4,	BANSHEE		)
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			//
			while (true) {//loop
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,5,	NECRO);//call CampaignAttackerEx( 3,3,5,	NECRO		)
				CampaignAttackerEx(3,3,4,	CRYPT_FIEND);//call CampaignAttackerEx( 3,3,4,	CRYPT_FIEND	)
				CampaignAttackerEx(1,1,2,	MEAT_WAGON);//call CampaignAttackerEx( 1,1,2,	MEAT_WAGON	)
				SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(5,5,7,	GHOUL);//call CampaignAttackerEx( 5,5,7,	GHOUL		)
				CampaignAttackerEx(3,3,4,	BANSHEE);//call CampaignAttackerEx( 3,3,4,	BANSHEE		)
				SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,5,	GHOUL);//call CampaignAttackerEx( 3,3,5,	GHOUL		)
				CampaignAttackerEx(2,2,4,	CRYPT_FIEND);//call CampaignAttackerEx( 2,2,4,	CRYPT_FIEND	)
				CampaignAttackerEx(2,2,3,	BANSHEE);//call CampaignAttackerEx( 2,2,3,	BANSHEE		)
				CampaignAttackerEx(1,1,2,	NECRO);//call CampaignAttackerEx( 1,1,2,	NECRO		)
				SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			}//endloop
		}//endfunction

	
	}
}
