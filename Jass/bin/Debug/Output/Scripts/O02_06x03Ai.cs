using System;
using System.Collections.Generic;

namespace Jass {

	public class O02_06x03Ai {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(BURROW,null);//call CampaignAI(BURROW,null)
			SetReplacements(2,2,3);//call SetReplacements(2,2,3)
			SetCaptainHome(BOTH_CAPTAINS,640,-3222);//call SetCaptainHome(BOTH_CAPTAINS,640,-3222)
			//
			CampaignDefenderEx(1,1,1, THRALL);//call CampaignDefenderEx( 1,1,1, THRALL        )
			//
			//
			//
			CampaignDefenderEx(2,2,2, SHAMAN);//call CampaignDefenderEx( 2,2,2, SHAMAN        )
			CampaignDefenderEx(2,2,2, WITCH_DOCTOR);//call CampaignDefenderEx( 2,2,2, WITCH_DOCTOR  )
			//
			//
			//
			//
			WaitForSignal();//call WaitForSignal()
		}//endfunction

	
	}
}

