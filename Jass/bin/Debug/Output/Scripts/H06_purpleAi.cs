using System;
using System.Collections.Generic;

namespace Jass {

	public class H06_purpleAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			SetBuildUnit(1, NECROPOLIS_1);//call SetBuildUnit( 1, NECROPOLIS_1		)
			SetBuildUnit(1, ACOLYTE);//call SetBuildUnit( 1, ACOLYTE			)
			SetBuildUnit(1, UNDEAD_MINE);//call SetBuildUnit( 1, UNDEAD_MINE		)
			SetBuildUnit(2, CRYPT);//call SetBuildUnit( 2, CRYPT				)
			SetBuildUnit(1, UNDEAD_ALTAR);//call SetBuildUnit( 1, UNDEAD_ALTAR      )
			SetBuildUnit(1, GRAVEYARD);//call SetBuildUnit( 1, GRAVEYARD         )
			SetBuildUnit(8, ZIGGURAT_1);//call SetBuildUnit( 8, ZIGGURAT_1  		)
			SetBuildUnit(1, NECROPOLIS_2);//call SetBuildUnit( 1, NECROPOLIS_2		)
			SetBuildUnit(5, ACOLYTE);//call SetBuildUnit( 5, ACOLYTE			)
			SetBuildUnit(8, ZIGGURAT_2);//call SetBuildUnit( 8, ZIGGURAT_2		)
			SetBuildUnit(1, DAMNED_TEMPLE);//call SetBuildUnit( 1, DAMNED_TEMPLE     )
			SetBuildUnit(1, SLAUGHTERHOUSE);//call SetBuildUnit( 1, SLAUGHTERHOUSE	)
			SetBuildUnit(1, NECROPOLIS_3);//call SetBuildUnit( 1, NECROPOLIS_3		)
			CampaignDefender(EASY, 4, GHOUL);//call CampaignDefender( EASY, 4, GHOUL       )
			CampaignDefender(EASY, 2, ABOMINATION);//call CampaignDefender( EASY, 2, ABOMINATION )
			CampaignDefender(EASY, 2, NECRO);//call CampaignDefender( EASY, 2, NECRO       )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0,0,4, GHOUL);//call CampaignAttackerEx( 0,0,4, GHOUL        )
			SuicideOnPlayerEx(0,0,M2,user);//call SuicideOnPlayerEx(0,0,M2,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,6, GHOUL);//call CampaignAttackerEx( 3,3,6, GHOUL        )
			CampaignAttackerEx(0,0,1, ABOMINATION);//call CampaignAttackerEx( 0,0,1, ABOMINATION  )
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(1,1,1, UPG_CANNIBALIZE);//call SetBuildUpgrEx( 1,1,1, UPG_CANNIBALIZE   )
			SetBuildUpgrEx(1,1,1, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 1,1,1, UPG_UNHOLY_STR    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,8, GHOUL);//call CampaignAttackerEx( 3,3,8, GHOUL        )
			CampaignAttackerEx(1,1,2, ABOMINATION);//call CampaignAttackerEx( 1,1,2, ABOMINATION  )
			CampaignAttackerEx(0,0,1, MEAT_WAGON);//call CampaignAttackerEx( 0,0,1, MEAT_WAGON   )
			SuicideOnPlayerEx(M4,M4,M3,user);//call SuicideOnPlayerEx(M4,M4,M3,user)
			SetBuildUpgrEx(1,1,1, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 1,1,1, UPG_UNHOLY_ARMOR  )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(6,6,10, GHOUL);//call CampaignAttackerEx( 6,6,10, GHOUL        )
			CampaignAttackerEx(2,2,2, ABOMINATION);//call CampaignAttackerEx( 2,2,2, ABOMINATION  )
			CampaignAttackerEx(0,0,1, NECRO);//call CampaignAttackerEx( 0,0,1, NECRO        )
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(1,1,1, UPG_SKEL_LIFE);//call SetBuildUpgrEx( 1,1,1, UPG_SKEL_LIFE     )
			SetBuildUpgrEx(0,0,2, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 0,0,2, UPG_UNHOLY_STR    )
			SetBuildUpgrEx(1,1,1, UPG_NECROS);//call SetBuildUpgrEx( 1,1,1, UPG_NECROS        )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(4,4,8, GHOUL);//call CampaignAttackerEx( 4,4,8, GHOUL        )
			CampaignAttackerEx(0,0,2, ABOMINATION);//call CampaignAttackerEx( 0,0,2, ABOMINATION  )
			CampaignAttackerEx(2,2,2, NECRO);//call CampaignAttackerEx( 2,2,2, NECRO        )
			CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON   )
			SuicideOnPlayerEx(M4,M4,M3,user);//call SuicideOnPlayerEx(M4,M4,M3,user)
			SetBuildUpgrEx(0,0,2, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 0,0,2, UPG_UNHOLY_ARMOR  )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(10,10,12, GHOUL);//call CampaignAttackerEx( 10,10,12, GHOUL        )
			SuicideOnPlayerEx(M5,M5,M3,user);//call SuicideOnPlayerEx(M5,M5,M3,user)
			SetBuildUpgrEx(0,0,1, UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE        )
			SetBuildUpgrEx(0,0,2, UPG_NECROS);//call SetBuildUpgrEx( 0,0,2, UPG_NECROS        )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0,0,6, GHOUL);//call CampaignAttackerEx( 0,0,6, GHOUL        )
			CampaignAttackerEx(4,4,2, ABOMINATION);//call CampaignAttackerEx( 4,4,2, ABOMINATION  )
			CampaignAttackerEx(0,0,2, NECRO);//call CampaignAttackerEx( 0,0,2, NECRO        )
			CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON   )
			SuicideOnPlayerEx(M4,M4,M3,user);//call SuicideOnPlayerEx(M4,M4,M3,user)
			SetBuildUpgrEx(0,0,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 0,0,1, UPG_GHOUL_FRENZY  )
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(6,6,6, GHOUL);//call CampaignAttackerEx( 6,6,6, GHOUL        )
				CampaignAttackerEx(0,0,1, ABOMINATION);//call CampaignAttackerEx( 0,0,1, ABOMINATION  )
				CampaignAttackerEx(2,2,3, NECRO);//call CampaignAttackerEx( 2,2,3, NECRO        )
				SuicideOnPlayerEx(M4,M4,M3,user);//call SuicideOnPlayerEx(M4,M4,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,6, GHOUL);//call CampaignAttackerEx( 4,4,6, GHOUL        )
				CampaignAttackerEx(2,2,3, ABOMINATION);//call CampaignAttackerEx( 2,2,3, ABOMINATION  )
				CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON   )
				SuicideOnPlayerEx(M4,M4,M3,user);//call SuicideOnPlayerEx(M4,M4,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,4, NECRO);//call CampaignAttackerEx( 3,3,4, NECRO        )
				CampaignAttackerEx(6,6,8, GHOUL);//call CampaignAttackerEx( 6,6,8, GHOUL        )
				SuicideOnPlayerEx(M4,M4,M3,user);//call SuicideOnPlayerEx(M4,M4,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,6, ABOMINATION);//call CampaignAttackerEx( 3,3,6, ABOMINATION  )
				CampaignAttackerEx(2,2,3, MEAT_WAGON);//call CampaignAttackerEx( 2,2,3, MEAT_WAGON   )
				CampaignAttackerEx(0,0,0, GHOUL);//call CampaignAttackerEx( 0,0,0, GHOUL        )
				SuicideOnPlayerEx(M5,M5,M2,user);//call SuicideOnPlayerEx(M5,M5,M2,user)
			}//endloop
		}//endfunction

	
	}
}

